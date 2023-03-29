using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Int32 = System.Int32;

namespace WindowsFormsApp1
{
    public partial class AddNewStudent : Form
    {
        public Student newStudent = new Student();
        List<int> Scores = new List<int>();
        public StudentScores studentScores;
        
        
        public AddNewStudent(StudentScores studentScores)
        {
            InitializeComponent();
            this.studentScores = studentScores;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtScore.Text) >= 0 && Int32.Parse(txtScore.Text) <= 100)
                {
                    Scores.Add(Int32.Parse(txtScore.Text));
                    lbxScores.Items.Add(Int32.Parse(txtScore.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1-100");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid number..");
            }
            txtScore.Text = " ";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                newStudent.Name = txtName.Text;
                newStudent.Scores = Scores;
                this.DialogResult = DialogResult.OK;
                studentScores.StudentList.Add(newStudent);
            }
            else
            {
                MessageBox.Show("Please enter a name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
