using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentScores : Form
    {
        public List<Student> StudentList = new List<Student>();
        public static int selected;
        public StudentScores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentList.Add(new Student("Michael felps", new List<int>{12,27,28}));
            StudentList.Add(new Student("John Bayer", new List<int> { 12, 27, 28 }));
            StudentList.Add(new Student("Frodo Baggins", new List<int> { 12, 27, 28 }));
            DisplayStudentList();
        }

        private void DisplayStudentList()
        {
            lbxStudents.Items.Clear();
            foreach (var Student in StudentList)
            {
                lbxStudents.Items.Add(Student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (var addNewStudent = new AddNewStudent(this))
            {
                var result = addNewStudent.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DisplayStudentList();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var updateScores = new UpdateScores(StudentList[lbxStudents.SelectedIndex]))
            {
                selected = lbxStudents.SelectedIndex;
               var result = updateScores.ShowDialog();
               if (result == DialogResult.OK)
               {
                   DisplayStudentList();
               }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbxStudents.Items.RemoveAt(lbxStudents.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
