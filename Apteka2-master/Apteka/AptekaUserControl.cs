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
            DesignUserControl.useDesign(this);

            List<string> apteka = SQLClass.myselect("Select id, name, pic FROM level1 WHERE id = '" + id + "'");

            label1.Text = apteka[1];

            try
            {
                pictureBox1.Load("../../Картинки/" + apteka[2]);
            }
            catch (Exception) { }

            List<string> classif = SQLClass.myselect("Select id, name, pic FROM level2 WHERE id_apteka = '" + id + "'");

            int x = 400;
            for(int i=0; i<classif.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, 60);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Arial", 13);
                lbl.Text = classif[i + 1];
                lbl.Tag = classif[i];
                lbl.Click += new EventHandler(label1_Click);
                infopanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + classif[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(300, 93);
                pb.Size = new Size(344, 240);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = classif[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                infopanel.Controls.Add(pb);

                x += 210;
            }

        }

        private void AptekaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ClasificatsiaUserControl cluc = new ClasificatsiaUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(cluc);
            cluc.Dock = DockStyle.None;
        }

        private void infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            ClasificatsiaUserControl cluc = new ClasificatsiaUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(cluc);
            cluc.Dock = DockStyle.None;
        }
    }
}
