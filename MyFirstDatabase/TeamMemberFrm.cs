﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyFirstDatabase
{
    public partial class TeamMembersFrm : Form
    {
        public TeamMembersFrm()
        {
            InitializeComponent();
        }
        private void TeamMembersFrm_Load(object sender, EventArgs e)
        {
            //string that connects form to mdf database
            string strConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\randa\source\repos\CSC262\MyFirstDatabase\Employees.mdf;Integrated Security=True;Connect Timeout=30;";
            //query to return all rows from table
            string strQuery = "SELECT * FROM TeamMemberTable";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                connection.Open();

                //sets up query with resources automatically managed for us
                using (SqlCommand cmd = new SqlCommand())
                {
                    //data adapter so the data can be used
                    SqlDataAdapter adapter = new SqlDataAdapter(strQuery, strConnString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvTeamMember.DataSource = dataTable;
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //creates instance of main menu
            dbMenuForm frmMainMenu = new dbMenuForm();
            //closes teamMemberform
            this.Close();
            //shows main menu
            frmMainMenu.Show();
        }
    }
}
