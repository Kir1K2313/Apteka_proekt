﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class MedikamenUserControl : UserControl
    {
        public MedikamenUserControl(string id)
        {
            InitializeComponent();
         

            List<string> meduc = SQLClass.myselect("Select ID, name, pic FROM lvl3 WHERE ID = '" + id + "'");

            meduclabel.Text = meduc[1];
            try
            {
                pictureBox1.Load("../../Картинки/" + meduc[2]);
            }
            catch (Exception) { }

            DesignUserControl.useDesign(this);
        }

        private void MedikamenUserControl_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
