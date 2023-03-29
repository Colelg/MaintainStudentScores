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
    public partial class UpdateScores : Form
    {
        public Student UpdateStudent = new Student();
        public List<int> scores;
        public UpdateScores(Student student)
        {
            InitializeComponent();
            this.UpdateStudent = student;
            this.scores = UpdateStudent.Scores;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                AddScore addScore = new AddScore(UpdateStudent);
                    addScore.ShowDialog();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid information...");
            }
        }

        private void UpdateScores_Load(object sender, EventArgs e)
        {
            txtName.Text = UpdateStudent.Name;
            foreach (int score in UpdateStudent.Scores)
            {
                lbxScores.Items.Add(score);
            }

        }
        public void UpdateScoreList(int newScore)
        {
            UpdateStudent.Scores.Add(newScore);
            foreach (int score in UpdateStudent.Scores)
            {
                lbxScores.Items.Add(score);
            }
            lbxScores.Refresh();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxScores.Items.RemoveAt(lbxScores.SelectedIndex);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                UpdateStudent.Scores.Clear();
                foreach (var score in lbxScores.Items)
                {
                    UpdateStudent.Scores.Add(Convert.ToInt32(score.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Please select a student");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnClear_Click(object sender, EventArgs e) => lbxScores.Items.Clear();
    }


}
