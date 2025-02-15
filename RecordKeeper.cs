using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace RecordKeeper
{
    public partial class RecordKeeper : Form
    {
        private DataTable profileTable;
        private List<List<string>> accountTable;
        private List<string> accountHeaders;

        public RecordKeeper()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeTables();
            SetDataGridViewStyles();
        }

        private void InitializeTables()
        {
            profileTable = new DataTable();
            dgvRA.DataSource = profileTable;

            accountTable = new List<List<string>>();
            accountHeaders = new List<string>();
            dgvRB.ColumnCount = 0;
        }

        private void SetDataGridViewStyles()
        {
            dgvRA.DefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
            dgvRA.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);

            dgvRB.DefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular);
            dgvRB.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold);
        }

        private void aaROW_Click(object sender, EventArgs e)
        {
            profileTable.Rows.Add(profileTable.NewRow());
        }

        private void aaCOL_Click(object sender, EventArgs e)
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

        private void adROW_Click(object sender, EventArgs e)
        {
            if (dgvRA.SelectedCells.Count > 0)
            {
                int rowIndex = dgvRA.SelectedCells[0].RowIndex;
                if (rowIndex >= 0 && rowIndex < profileTable.Rows.Count)
                {
                    profileTable.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void adCOL_Click(object sender, EventArgs e)
        {
            if (dgvRA.SelectedCells.Count > 0)
            {
                int colIndex = dgvRA.SelectedCells[0].ColumnIndex;
                if (colIndex >= 0 && colIndex < profileTable.Columns.Count)
                {
                    profileTable.Columns.RemoveAt(colIndex);
                }
            }
        }

        private void baROW_Click(object sender, EventArgs e)
        {
            accountTable.Add(new List<string>(new string[dgvRB.ColumnCount]));
            dgvRB.Rows.Add();
        }

        private void baCOL_Click(object sender, EventArgs e)
        {
            string headerName = InputDialog.ShowDialog("Enter column header name:");
            if (headerName != null)
            {
                if (!string.IsNullOrWhiteSpace(headerName))
                {
                    if (!accountHeaders.Contains(headerName))
                    {
                        accountHeaders.Add(headerName);
                        dgvRB.Columns.Add(headerName, headerName);
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

        private void bdROW_Click(object sender, EventArgs e)
        {
            if (dgvRB.SelectedCells.Count > 0)
            {
                int rowIndex = dgvRB.SelectedCells[0].RowIndex;
                if (rowIndex >= 0 && rowIndex < accountTable.Count)
                {
                    accountTable.RemoveAt(rowIndex);
                    dgvRB.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void bdCOL_Click(object sender, EventArgs e)
        {
            if (dgvRB.SelectedCells.Count > 0)
            {
                int colIndex = dgvRB.SelectedCells[0].ColumnIndex;
                if (colIndex >= 0 && colIndex < accountHeaders.Count)
                {
                    accountHeaders.RemoveAt(colIndex);
                    dgvRB.Columns.RemoveAt(colIndex);
                    foreach (var row in accountTable)
                    {
                        if (row.Count > colIndex)
                            row.RemoveAt(colIndex);
                    }
                }
            }
        }

        private void flRA_Click(object sender, EventArgs e)
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

                dgvRA.DataSource = profileTable;
            }
        }

        private void flRB_Click(object sender, EventArgs e)
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
                dgvRB.Rows.Clear();
                dgvRB.Columns.Clear();

                foreach (var cell in worksheet.Rows[0].AllocatedCells)
                {
                    string headerText = cell.Value?.ToString() ?? "";
                    accountHeaders.Add(headerText);
                    dgvRB.Columns.Add(headerText, headerText);
                }

                for (int i = 1; i < worksheet.Rows.Count; i++)
                {
                    List<string> rowData = new List<string>();
                    foreach (var cell in worksheet.Rows[i].AllocatedCells)
                    {
                        rowData.Add(cell.Value?.ToString() ?? "");
                    }
                    accountTable.Add(rowData);
                    dgvRB.Rows.Add(rowData.ToArray());
                }
            }
        }

        private void fsRA_Click(object sender, EventArgs e)
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
                    this.dgvRA,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
            }
        }

        private void fsRB_Click(object sender, EventArgs e)
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
                    this.dgvRB,
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
