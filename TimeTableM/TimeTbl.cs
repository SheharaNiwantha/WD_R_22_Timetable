using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeTableM
{
    public partial class TimeTbl : Form
    {
        MySqlConnection con = null;
        public TimeTbl()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Time generate part start
            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox15.Text = sdr.GetValue(0).ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox16.Text = sdr.GetValue(0).ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox21.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox29.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            //Time generate part end





            //Day generate part start
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Evening
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();




            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox22.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox23.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox24.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox25.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox26.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox27.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox28.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();





            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox30.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox31.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox32.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox33.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox34.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox35.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox36.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

        private void btnLecGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox17.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox18.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox52.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox44.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();









            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            





            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();






            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox51.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox50.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox49.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox48.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox47.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox46.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox45.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();






            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox43.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox42.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox41.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox40.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox39.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox38.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox37.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLocGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox19.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox20.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox68.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4)";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    richTextBox60.Text = sdr.GetValue(0).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();








            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox14.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox13.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox12.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox11.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox10.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox9.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 1));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox8.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Evening

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox7.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox6.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox5.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox4.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox3.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox2.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 2));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox1.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();






            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox67.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox66.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox65.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox64.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox63.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox62.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 3));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox61.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();








            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox59.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox58.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox57.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox56.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox55.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox54.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = (SELECT `allTimes` FROM `addtime` WHERE `allTimes` = (SELECT `allTimes` FROM `addtime` WHERE `timeID` = 4));";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox53.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbGrp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbGrp.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT GrpID FROM addstudentgrp";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbGrp.Items.Add(dr["GrpID"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb1Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb1Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb1Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb2Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb2Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb2Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbLocation_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbLocation.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT room FROM addsesstion";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLocation.Items.Add(dr["room"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void TimeTbl_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}
