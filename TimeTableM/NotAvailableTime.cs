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
    public partial class NotAvailableTime : Form
    {
        MySqlConnection con = null;
        
        public NotAvailableTime()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            
        }

        string timee;
        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `nottimeavailable`(`firstLec`, `grp`, `subject`, `tag`, `day`, `noOfStd`) VALUES ('" + cmb1Lec.Text + "','" + cmbGrop.Text + "','" + cmbSuGrp.Text + "','" + cmbTimeSlot.Text + "','" + cmbDay.Text + "','" + txtNoOfStd.Text + "')"; 
                 MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `nottimeavailable`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMngeNt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmb1Lec.Text = sdr.GetValue(0).ToString();
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            cmb1Lec.Text = string.Empty;
           
            cmbTimeSlot.Text = string.Empty;
            cmbGrop.Text = string.Empty;
            cmbSuGrp.Text = string.Empty;
            txtNoOfStd.Clear();

            cmbDay.Text = string.Empty;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `nottimeavailable`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dgvMngeNt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbnMor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbnEve_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTime_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTime1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb1Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb1Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `LecName` FROM `addlecture`";
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

        private void cmbGrop_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbGrop.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `GrpID` FROM `addstudentgrp`";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbGrop.Items.Add(dr["GrpID"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbSuGrp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbSuGrp.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `SubjectName` FROM `addsubject`";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSuGrp.Items.Add(dr["SubjectName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbTimeSlot_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbTimeSlot.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT `SubjectTagName` FROM `addtag`";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTimeSlot.Items.Add(dr["SubjectTagName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }
    }
    }
