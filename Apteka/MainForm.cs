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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = "Аптека";

            MainUserControl mauc = new MainUserControl();
            mauc.Dock = DockStyle.Fill;
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(mauc);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0 && e.Node.Text == "Аптеки")
            {
                MainUserControl mauc = new MainUserControl();
                mauc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(mauc);
            }

            else if(e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
                AptekaUserControl aptekaUc = new AptekaUserControl(e.Node.Tag.ToString());
                aptekaUc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(aptekaUc);
            }

            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Аптеки")
            {
                MedikamenUserControl medUc = new MedikamenUserControl(e.Node.Tag.ToString());
                medUc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(medUc);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
