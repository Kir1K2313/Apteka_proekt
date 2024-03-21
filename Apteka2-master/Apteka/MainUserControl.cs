using System;
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
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            List<string> apteka = SQLClass.myselect("SELECT id, name, pic FROM level1");
            int x = 50;
            int y = 130;
            for (int i = 0; i < apteka.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(200, 30);
                lbl.Tag = apteka[i];
                lbl.Text = apteka[i + 1];
                lbl.Click += new EventHandler(label2_Click);
                Infopanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Картинки/" + apteka[i+2]);
                }
                catch (Exception) { }
           
                pb.Location = new Point(x, y + 40);
                pb.Size = new Size(200, 130);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = apteka[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Infopanel.Controls.Add(pb);

                x += 210;
                if (x > this.Width)
                {
                    x = 10;
                    y += 180;
                }

            }
            DesignUserControl.useDesign(this);

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            AptekaUserControl aptekaUc = new AptekaUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(aptekaUc);
            aptekaUc.Dock = DockStyle.Fill;
        }


        private void MainUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            AptekaUserControl aptekaUc = new AptekaUserControl(lbl.Tag.ToString());
            Controls.Clear();
            Controls.Add(aptekaUc);
            aptekaUc.Dock = DockStyle.Fill;
        }
    }
}
