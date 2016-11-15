using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstvwFiles.Columns.Add("FilePath", 100);
            lstvwFiles.Columns.Add("FileName", 100);
            lstvwFiles.Columns.Add("DirectoryName", 100);
            lstvwFiles.Columns.Add("Extension", 100);
            lstvwFiles.Columns.Add("FullName", 100);
            lstvwFiles.Columns.Add("CreationTime", 100);
        }

        private int _counter = 0;
        readonly StringBuilder _builder = new StringBuilder();
        private void btnBrows_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            var result = browserDialog.ShowDialog();

            if (result != DialogResult.OK)
                return;
            lstvwFiles.Items.Clear();
            _counter = 0;
            _builder.Clear();
            txtPath.Text = browserDialog.SelectedPath;
            LoadFiles(txtPath.Text);
        }


        private void LoadFiles(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                _counter++;

                string[] arr = new string[6];
                var fileInfo = new FileInfo(file);
                arr[0] = file;
                arr[1] = fileInfo.Name;
                arr[2] = fileInfo.DirectoryName;
                arr[3] = fileInfo.Extension;
                arr[4] = fileInfo.FullName;
                arr[5] = fileInfo.CreationTime.ToLongDateString();
                _builder.AppendLine("{" + $"id : {_counter}, url: 'www/img/{fileInfo.Name}' , name : '{fileInfo.Name}' " + "} ,");
                var item = new ListViewItem(arr);
                lstvwFiles.Items.Add(item);

            }

            foreach (var folder in Directory.GetDirectories(path))
            {
                LoadFiles(folder);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (_builder.Length == 0) return;
            Cursor.Current = Cursors.WaitCursor;
            var saveFileDialog = new SaveFileDialog
            {
                FileName = "DB.Json",
                DefaultExt = "Json",
                Filter = @"JSON File|*.Json"
            };
            var result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            string path = saveFileDialog.FileName;
            saveFileDialog.Dispose();

            if (File.Exists(path))
                File.Delete(path);
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {

                    //streamWriter.WriteLine("[");
                    streamWriter.Write(_builder);
                    //streamWriter.WriteLine("]");
                    streamWriter.AutoFlush = true;
                    streamWriter.Flush();
                }
                MessageBox.Show("File saved");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void btnLdTables_Click(object sender, EventArgs e)
        {
            if (txtDataBaseName.Text == "" || txtUserName.Text == "" || txtServer.Text == "" || txtPassword.Text == "")
                return;

            string conn = $"Password={txtPassword.Text};Persist Security Info=True;User ID={txtUserName.Text};Initial Catalog={txtDataBaseName.Text};Data Source={txtServer.Text}";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                using (var adapter =
                    new SqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", conn))
                {

                    using (DataTable dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            _builder.Clear();

                            lstbxTables.Items.Clear();
                            int x = 0;
                            _builder.Append("{");
                            foreach (DataRow dr in dataTable.Rows)
                            {
                                lstbxTables.Items.Add(dr["Table_Name"]);
                                CreateJson(dr["Table_Name"].ToString());
                            }
                            _builder.Remove(_builder.Length - 1, 1);
                            _builder.Append("}");
                        }

                    }
                    MessageBox.Show("Done");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        public void CreateJson(string tbName)
        {
            if (txtDataBaseName.Text == "" || txtUserName.Text == "" || txtServer.Text == "" || txtPassword.Text == "")
                return;

            string conn = $"Password={txtPassword.Text};Persist Security Info=True;User ID={txtUserName.Text};Initial Catalog={txtDataBaseName.Text};Data Source={txtServer.Text}";

            try
            {
                using (var adapter =
                    new SqlDataAdapter($"SELECT * FROM {tbName}", conn))
                {

                    using (var dataTable = new DataTable())
                    {
                        adapter.Fill(dataTable);
                        _builder.AppendLine('"' + tbName + '"');
                        if (dataTable.Rows.Count > 0)
                        {
                            _builder.Append(":[");
                            int countRows = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                countRows++;
                                _builder.Append("{");
                                int countColumns = 0;
                                foreach (DataColumn clmn in dataTable.Columns)
                                {
                                    countColumns++;
                                    var isnumber = clmn.DataType.Name.ToLower().Contains("int") || clmn.DataType.Name.ToLower().Contains("float") ||
                                    clmn.DataType.Name.ToLower().Contains("double") || clmn.DataType.Name.ToLower().Contains("decimal");

                                    string line = '"' + clmn.ColumnName + '"' + ":" + (isnumber ? (row[clmn.ColumnName] == null ? "0" : row[clmn.ColumnName].ToString()) : (row[clmn.ColumnName] == null ? "null" : '"'
                                        + row[clmn.ColumnName].ToString() + '"')) + (dataTable.Columns.Count != countColumns ? "," : "");
                                    _builder.Append(line);
                                }

                                _builder.Append(dataTable.Rows.Count != countRows ? "}," : "}");

                            }
                            _builder.Append("],");
                        }
                        else
                        {
                            _builder.Append(":[{");
                            int countColumns = 0;
                            foreach (DataColumn clmn in dataTable.Columns)
                            {
                                countColumns++;
                                bool isnumber = clmn.DataType.Name.ToLower().Contains("int") || clmn.DataType.Name.ToLower().Contains("float") ||
                                    clmn.DataType.Name.ToLower().Contains("double") || clmn.DataType.Name.ToLower().Contains("decimal");

                                string line = '"' + clmn.ColumnName + '"' + ":" + (isnumber ? "0" : ('"' + "" + '"')) + (dataTable.Columns.Count != countColumns ? "," : "");
                                _builder.Append(line);
                            }
                            _builder.Append("}],");
                        }

                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}
