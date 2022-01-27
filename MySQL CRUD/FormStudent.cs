using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_CRUD
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        private string id;
        private string name;
        private string reg;
        private string @class;
        private string section;

        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            laltext.Text = "Update Student";
            btnSave.Text = "Update";
            txtName.Text = name;
            txtReg.Text = reg;
            txtClass.Text = @class;
            txtSection.Text = section;
        }

        public void SaveInfo()
        {
            laltext.Text = "Add Student";
            btnSave.Text = "Save";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void laltext_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtName.Text = txtReg.Text = txtClass.Text = txtSection.Text = String.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is Empty ( > 3 ).");
            }
            if (txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student reg is Empty ( > 1 ).");
                return;
            }
            if (txtClass.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student class is Empty ( > 1 ).");
                return;
            }
            if (txtSection.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student section is Empty ( > 1 ).");
                return;
            }
            if(btnSave.Text == "Save")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            if(btnSave.Text == "Update")
            {
                Student std = new Student(txtName.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.UpdateStudent(std, id);
            }
            _parent.Display();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
