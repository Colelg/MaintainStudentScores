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
    public partial class AddScore : Form
    {
        public Student updateScore = new Student();
        public AddScore(Student student)
        {
            InitializeComponent();
            this.updateScore = student;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtScore.Text) >= 0 && Int32.Parse(txtScore.Text) <= 100)
            {
                UpdateScores s = new UpdateScores(updateScore);
                s.UpdateScoreList(Int32.Parse(txtScore.Text));
                this.Close();

            }
            else
            {
                MessageBox.Show("Please enter a score between 1-100");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
