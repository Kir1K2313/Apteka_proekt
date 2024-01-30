using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class AptekaUserControl : UserControl
    {
        public AptekaUserControl(string id)
        {
            InitializeComponent();

            List<string> apteka = SQLClass.myselect("Select ID, name, pic FROM lvl1 WHERE ID = '" + id + "'");

            label1.Text = apteka[1];

            try
            {
                pictureBox1.Load("../../Картинки/" + apteka[2]);
            }
            catch (Exception) { }

            List<string> classif = SQLClass.myselect("Select ID, name, pic FROM lvl2 WHERE ID_APTEKA = '" + id + "'");

            int x = 400;
            int x1 = 10;
            for(int i=0; i<classif.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 60);
                lbl.Size = new Size(260, 30);
                lbl.Font = new Font("Arial", 13);
                lbl.Text = classif[i + 1];
                lbl.Tag = classif[i];
                lbl.Click += new EventHandler(label6_Click_1);
                infopanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + classif[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x1, 93);
                pb.Size = new Size(344, 240);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = classif[i];
                pb.Click += new EventHandler(Picture_Click_1);
                infopanel.Controls.Add(pb);

                x += 110;
            }

        }

        private void AptekaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            ClasificatsiaUserControl cluc = new ClasificatsiaUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(cluc);
            cluc.Dock = DockStyle.None;
        }
        private void Picture_Click_1(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ClasificatsiaUserControl cluc = new ClasificatsiaUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(cluc);
            cluc.Dock = DockStyle.None;
        }
    }
}
