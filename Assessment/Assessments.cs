using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessments
{
    public partial class Assessments : Form
    {
        private static List<Assignment> _assignments = new List<Assignment>();
        private static List<AssignmentScore> _score = new List<AssignmentScore>();
        private static List<Student> _student = Student.GetStudents();
        public Assessments()
        {
            InitializeComponent();
        }

        private void Assessments_Load(object sender, EventArgs e)
        {
            
            
        }

        private void RefreshCBO()
        {
           cboAssess.DataSource = _assignments.ToList();
          
        }

        private void RefreshDGV()
        {
            dgvStudents.DataSource = null;
            if (Student.GetStudents().Count>0) 
            {
                dgvStudents.DataSource = Student.GetStudents();
            }
           
                string name = dgvStudents.SelectedCells[0].Value.ToString();
                lblAutoFill1.Text = name;

        }

        private void btnAddAssess_Click(object sender, EventArgs e)
        {
            
            string name;
            int max;
            name = txtName.Text;
            max = int.Parse(txtMax.Text);
            Assignment newAs = new Assignment(name, max);
            _assignments.Add(newAs);
            txtName.Clear();
            txtMax.Clear();
            RefreshCBO();
        }

        private void btnNewStu_Click(object sender, EventArgs e)
        {
            string name;
            name = txtNewStu.Text;
            Student newStu = new Student(name);
            txtNewStu.Clear();
            RefreshDGV();

        }


        private void btnScore_Click(object sender, EventArgs e)
        {
            AssignmentScore newScore = new AssignmentScore();
            bool ok = false;
            foreach (Assignment newAssignmentScore in _assignments)
            {
                if (newAssignmentScore.ToString() == cboAssess.GetItemText(cboAssess.SelectedItem))
                {
                    newScore.Assignment = newAssignmentScore;
                }
            }

            if (int.Parse(txtScore.Text) <= newScore.Assignment.MaximumScore) 
                newScore.Score = int.Parse(txtScore.Text);

            foreach (Student student in _student)
            {
                if (dgvStudents.SelectedCells[0].Value.ToString() == student.Name)
                {
                    newScore.Name = student.Name;
                    ok = true;
                }
            }

            if(ok)_score.Add(newScore);
            dgvStudents.DataSource = _score;
            
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                string name = dgvStudents.SelectedCells[0].Value.ToString();
                lblAutoFill1.Text = name;
            
        }

        private void cboAssess_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (Assignment name in _assignments)
            {
                if (name.ToString() == cboAssess.GetItemText(cboAssess.SelectedItem))
                {
                    lblAutoFill2.Text = name.Name;
                }
            }

            foreach (Assignment points in _assignments)
            {
                if (points.ToString() == cboAssess.GetItemText(cboAssess.SelectedItem))
                {
                    lblMax.Text = "/ " + points.MaximumScore.ToString();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = _score;
        }
    }
}
