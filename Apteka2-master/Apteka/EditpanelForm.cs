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
    public partial class EditpanelForm : Form
    {
        Control ctrl;
        public EditpanelForm(Control _ctrl)
        {
            InitializeComponent();

            ctrl = _ctrl;
            Text = "Изменение параметров панели " + ctrl.Name;
            ctrl.Height = _ctrl.Height;
            EditHeightTB.Text = ctrl.Height.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SQLClass.myUpdate("DELETE FROM paneldesign WHERE type = '" + ctrl.GetType() + "' AND '" + ctrl.Name +  "' AND parametr = 'PANEL_HEIGHT'");

            SQLClass.myUpdate("INSERT INTO paneldesign (type, parametr, name, value) VALUE ('" + ctrl.GetType() + "', 'PANEL_HEIGHT','" + ctrl.Name + "', '" + EditHeightTB.Text + "')");

        }
        
    }
}
