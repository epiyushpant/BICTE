using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace StudentManagementSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read input values
            string faculty = cmbFaculty.Text.Trim();
            string course = txtCourse.Text.Trim();
            int yearPassed = (int)nudYearPassed.Value;
            string marks = txtMarks.Text.Trim();

            // Check if any field is empty
            if (faculty == "" || course == "" || marks == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Add data to the grid
            dgvQualifications.Rows.Add(faculty, course, yearPassed, marks, "Edit", "Delete");

            // Optional: Clear fields after adding
            cmbFaculty.SelectedIndex = -1;
            txtCourse.Clear();
            nudYearPassed.Value = nudYearPassed.Minimum;
            txtMarks.Clear();
        }

        private void dgvQualifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not header row
            {
                // "Edit" clicked
                if (dgvQualifications.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    // Get row values
                    string faculty = dgvQualifications.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string course = dgvQualifications.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int year = Convert.ToInt32(dgvQualifications.Rows[e.RowIndex].Cells[2].Value);
                    string marks = dgvQualifications.Rows[e.RowIndex].Cells[3].Value.ToString();

                    // Load into input controls
                    cmbFaculty.Text = faculty;
                    txtCourse.Text = course;
                    nudYearPassed.Value = year;
                    txtMarks.Text = marks;

                    // Optional: remove the row after editing
                    dgvQualifications.Rows.RemoveAt(e.RowIndex);
                }

                // "Delete" clicked
                if (dgvQualifications.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        dgvQualifications.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            if (dgvQualifications.Rows.Count == 0)
            {
                MessageBox.Show("No qualifications to export.");
                return;
            }

            // Create Excel application
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            Excel._Worksheet worksheet = excelApp.ActiveSheet;

            // Set column headers
            for (int i = 0; i < dgvQualifications.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvQualifications.Columns[i].HeaderText;
            }

            // Add rows to sheet
            for (int i = 0; i < dgvQualifications.Rows.Count; i++)
            {
                for (int j = 0; j < dgvQualifications.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvQualifications.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Ask where to save
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "Qualifications.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Data exported successfully!");
            }

            // Cleanup
            excelApp.Quit();
        }
    }
}
