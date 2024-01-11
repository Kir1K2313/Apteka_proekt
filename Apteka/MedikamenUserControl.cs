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
            pictureBox1.Load("../../Картинки/" + id + ".jpg");

        }

        private void MedikamenUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
