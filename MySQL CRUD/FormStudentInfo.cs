using System;
using System.Windows.Forms;

namespace MySQL_CRUD
{
    public partial class FormStudentInfo : Form
    {
        FormStudent form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name,  Reg, Class, Section FROM student_table", dataGridView1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name,  Reg, Class, Section FROM student_table WHERE Name LIKE'%" + txtSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.reg = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.@class = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.section = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete student record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
