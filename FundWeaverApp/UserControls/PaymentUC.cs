﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundWeaverApp.UserControls
{
    public partial class PaymentUC : UserControl
    {
        
        public PaymentUC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            DbOperations db = new DbOperations();
            string a = "select max(Id) from Fund";
            pymttextBox.Text = db.maxid(a).ToString();
        }
    }
}
