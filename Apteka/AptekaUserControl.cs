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
    public partial class AptekaUserControl : UserControl
    {
        public AptekaUserControl(string id)
        {
            InitializeComponent();

            pictureBox1.Load("../../Картинки/Аптека" + id + ".jpg");
        }

        private void AptekaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainUserControl mauc = new MainUserControl();
            Controls.Clear();
            Controls.Add(mauc);
            mauc.Dock = DockStyle.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            MedikamenUserControl meduc = new MedikamenUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(meduc);
            meduc.Dock = DockStyle.None;
        }
    }
}
