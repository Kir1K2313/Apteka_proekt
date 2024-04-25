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
    public partial class ClasificatsiaUserControl : UserControl
    {
        public ClasificatsiaUserControl(string id)
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);

            List<string> classif = SQLClass.myselect("Select id, name, pic FROM level2 WHERE id = '" + id + "'");


            string id_class = classif[0];
            meduclabel.Text = classif[1];
            try
            {
                pictureBox1.Load("../../Картинки/" + classif[2]);
            }
            catch (Exception) { }

            List<string> meduc = SQLClass.myselect("Select id, name, pic, price FROM level3 WHERE id_class = '" + id_class + "'");

            int x = 400;
            for (int i = 0; i < meduc.Count; i += 4)
            {
                Label Namelbl = new Label();
                Namelbl.Name = "Labellabel";
                Namelbl.Location = new Point(x, 60);
                Namelbl.Size = new Size(200, 30);
                Namelbl.Font = new Font("Arial", 13);
                Namelbl.Text = meduc[i + 1];
                Namelbl.Tag = meduc[i];
                Vievpanel.Controls.Add(Namelbl);


                Label Pricelabel = new Label();
                Pricelabel.Location = new Point(x, 360);
                Pricelabel.Name = "Pricelabel";
                Pricelabel.Size = new Size(200, 30);
                Pricelabel.Font = new Font("Arial", 13);
                Pricelabel.Text = "Цена,  руб.:" + meduc[i + 3];
                Vievpanel.Controls.Add(Pricelabel);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + classif[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(300, 93);
                pb.Size = new Size(344, 240);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = meduc[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Vievpanel.Controls.Add(pb);

                x += 210;

            }

        }

        private void meduclabel_Click(object sender, EventArgs e)
        {
              Label lb = (Label)sender;
              MedikamenUserControl meduc = new MedikamenUserControl(lb.Tag.ToString());
              Controls.Clear();
              Controls.Add(meduc);
              meduc.Dock = DockStyle.None;    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MedikamenUserControl meduc = new MedikamenUserControl(pb.Tag.ToString());
            Controls.Clear();
            Controls.Add(meduc);
            meduc.Dock = DockStyle.None;
        }

        private void Vievpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
