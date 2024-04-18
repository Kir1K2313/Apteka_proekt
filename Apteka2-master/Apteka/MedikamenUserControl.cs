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
    public partial class MedikamenUserControl : UserControl
    {
        public MedikamenUserControl(string id)
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);

            List<string> meduc = SQLClass.myselect("Select id, name, pic, price FROM level3 WHERE id = '" + id + "'");

            meduclabel.Text = meduc[1];
            Pricelabel.Text = "Цена: " + meduc[3] + " руб";
            try
            {
                pictureBox1.Load("../../Картинки/" + meduc[2]);
            }
            catch (Exception) { }

        }

        private void MedikamenUserControl_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
