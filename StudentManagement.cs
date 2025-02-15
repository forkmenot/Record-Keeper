using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace StudentManagement
{
    public partial class StudentManagement : Form
    {
        private DataTable profileTable;
        private List<List<string>> accountTable;
        private List<string> accountHeaders;

        public StudentManagement()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeTables();
            SetDataGridViewStyles();
        }

        private void InitializeTables()
        {
            profileTable = new DataTable();
            dgvProfile.DataSource = profileTable;

            accountTable = new List<List<string>>();
            accountHeaders = new List<string>();
            dgvAccount.ColumnCount = 0;
        }

        private void SetDataGridViewStyles()
        {
            dgvProfile.DefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
            dgvProfile.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);

            dgvAccount.DefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
            dgvAccount.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
        }

        private void paROW_Click(object sender, EventArgs e)
        {
            profileTable.Rows.Add(profileTable.NewRow());
        }

        private void paCOL_Click(object sender, EventArgs e)
        {
            string headerName = InputDialog.ShowDialog("Enter column header name:");
            if (headerName != null)
            {
                if (!string.IsNullOrWhiteSpace(headerName))
                {
                    if (!profileTable.Columns.Contains(headerName))
                    {
                        profileTable.Columns.Add(headerName);
                    }
                    else
                    {
                        MessageBox.Show("Duplicate column header is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Column header is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pdROW_Click(object sender, EventArgs e)
        {
            if (dgvProfile.SelectedCells.Count > 0)
            {
                int rowIndex = dgvProfile.SelectedCells[0].RowIndex;
                if (rowIndex >= 0 && rowIndex < profileTable.Rows.Count)
                {
                    profileTable.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void pdCOL_Click(object sender, EventArgs e)
        {
            if (dgvProfile.SelectedCells.Count > 0)
            {
                int colIndex = dgvProfile.SelectedCells[0].ColumnIndex;
                if (colIndex >= 0 && colIndex < profileTable.Columns.Count)
                {
                    profileTable.Columns.RemoveAt(colIndex);
                }
            }
        }

        private void aaROW_Click(object sender, EventArgs e)
        {
            accountTable.Add(new List<string>(new string[dgvAccount.ColumnCount]));
            dgvAccount.Rows.Add();
        }

        private void aaCOL_Click(object sender, EventArgs e)
        {
            string headerName = InputDialog.ShowDialog("Enter column header name:");
            if (headerName != null)
            {
                if (!string.IsNullOrWhiteSpace(headerName))
                {
                    if (!accountHeaders.Contains(headerName))
                    {
                        accountHeaders.Add(headerName);
                        dgvAccount.Columns.Add(headerName, headerName);
                        foreach (var row in accountTable)
                        {
                            row.Add("");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate column header is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Column header is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adROW_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedCells.Count > 0)
            {
                int rowIndex = dgvAccount.SelectedCells[0].RowIndex;
                if (rowIndex >= 0 && rowIndex < accountTable.Count)
                {
                    accountTable.RemoveAt(rowIndex);
                    dgvAccount.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void adCOL_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedCells.Count > 0)
            {
                int colIndex = dgvAccount.SelectedCells[0].ColumnIndex;
                if (colIndex >= 0 && colIndex < accountHeaders.Count)
                {
                    accountHeaders.RemoveAt(colIndex);
                    dgvAccount.Columns.RemoveAt(colIndex);
                    foreach (var row in accountTable)
                    {
                        if (row.Count > colIndex)
                            row.RemoveAt(colIndex);
                    }
                }
            }
        }

        private void flProfile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
                "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
                "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
                "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
                "HTML files (*.html, *.htm)|*.html;*.htm";

            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;

                profileTable = worksheet.CreateDataTable(new CreateDataTableOptions() { ColumnHeaders = true });

                dgvProfile.DataSource = profileTable;
            }
        }

        private void flAccount_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
                "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
                "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
                "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
                "HTML files (*.html, *.htm)|*.html;*.htm";

            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;

                accountHeaders.Clear();
                accountTable.Clear();
                dgvAccount.Rows.Clear();
                dgvAccount.Columns.Clear();

                foreach (var cell in worksheet.Rows[0].AllocatedCells)
                {
                    string headerText = cell.Value?.ToString() ?? "";
                    accountHeaders.Add(headerText);
                    dgvAccount.Columns.Add(headerText, headerText);
                }

                for (int i = 1; i < worksheet.Rows.Count; i++)
                {
                    List<string> rowData = new List<string>();
                    foreach (var cell in worksheet.Rows[i].AllocatedCells)
                    {
                        rowData.Add(cell.Value?.ToString() ?? "");
                    }
                    accountTable.Add(rowData);
                    dgvAccount.Rows.Add(rowData.ToArray());
                }
            }
        }

        private void fsProfile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (*.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dgvProfile,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }

        private void fsAccount_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (*.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dgvAccount,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }
    }

    public static class InputDialog
    {
        public static string ShowDialog(string promptText, string title = "Column Header", string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = promptText, AutoSize = true };
            TextBox textBox = new TextBox() { Width = 350, Text = defaultValue };
            textBox.Left = (prompt.ClientSize.Width - textBox.Width) / 2;
            textBox.Top = 50;

            Button confirmation = new Button() { Text = "OK", Width = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Width = 80, DialogResult = DialogResult.Cancel };
            confirmation.Top = cancel.Top = 90;
            confirmation.Left = (prompt.ClientSize.Width - 2 * confirmation.Width - 10) / 2;
            cancel.Left = confirmation.Right + 10;

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
