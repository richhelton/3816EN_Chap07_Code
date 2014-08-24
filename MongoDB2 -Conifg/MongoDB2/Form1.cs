using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB2.Model;

namespace MongoDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnCreateData_Click(object sender, EventArgs e)
        {
            MyConfig.CreateData();
        }

        private void btnGetUnicasts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyConfig.GetUnicasts();
        }

        private void btnGetEndpoints_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyConfig.GetMessageMaps();
        }

        private void btnDeleteUnicasts_Click(object sender, EventArgs e)
        {
            MyConfig.DeleteUnicasts();
        }

        private void btnDeleteEndpoints_Click(object sender, EventArgs e)
        {
           MyConfig.DeleteMessageMaps();
        }

    }
}
