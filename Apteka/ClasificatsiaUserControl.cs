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

            List<string> cluc = SQLClass.myselect("Select ID, name, pic FROM lvl2 WHERE ID = '" + id + "'");

            meduclabel.Text = cluc[1];
            try
            {
                pictureBox1.Load("../../Картинки/" + cluc[2]);
            }
            catch (Exception) { }

        }

        private void ClasificatsiaUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
