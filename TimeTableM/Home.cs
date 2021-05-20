using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            AddLecturer AddLecturer = new AddLecturer();
            AddLecturer.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            AddWorking AddWorking = new AddWorking();
            AddWorking.Show();
            this.Hide();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject AddSubject = new AddSubject();
            AddSubject.Show();
            this.Hide();
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            AddTag AddTag = new AddTag();
            AddTag.Show();
            this.Hide();
        }

        private void btnStdGrp_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            AddStudent.Show();
            this.Hide();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocation AddLocation = new AddLocation();
            AddLocation.Show();
            this.Hide();
        }

        private void btnVisuStat_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTbl TimeTbl = new TimeTbl();
            TimeTbl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageLecturers ManageLecturers = new ManageLecturers();
            ManageLecturers.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageSubject ManageSubject = new ManageSubject();
            ManageSubject.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageTag ManageTag = new ManageTag();
            ManageTag.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageLocation ManageLocation = new ManageLocation();
            ManageLocation.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageStudent ManageStudent = new ManageStudent();
            ManageStudent.Show();
            this.Hide();
        }
    }
}
