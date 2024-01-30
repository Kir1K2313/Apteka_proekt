using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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

           if (e.Node.Level == 0 && e.Node.Text == "Аптеки")
            {
                MainUserControl main = new MainUserControl();
                main.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(main);
            }
            else  if (e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
                AptekaUserControl apteka = new AptekaUserControl(e.Node.Tag.ToString());
                apteka.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(apteka);
            }

            else if(e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Аптеки")
            {
                ClasificatsiaUserControl cluc = new ClasificatsiaUserControl(e.Node.Tag.ToString());
                cluc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(cluc);
            }

            else if (e.Node.Level == 3 && e.Node.Parent.Parent.Parent.Text == "Аптеки")
            {
                MedikamenUserControl meduc = new MedikamenUserControl(e.Node.Tag.ToString());
                meduc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(meduc);
            }


  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_apteka;
            string id_classif;

            List<string> apteki = SQLClass.myselect("Select ID, name FROM lvl1 ");

            for(int i = 0; i<apteki.Count; i += 2)
            {
                id_apteka = apteki[i];
                TreeNode node0 = new TreeNode(apteki[i + 1]);
                node0.Tag = apteki[i];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> classif = SQLClass.myselect("Select ID, name FROM lvl2 WHERE ID_APTEKA = '" + id_apteka + "'");
                for (int j = 0; j < classif.Count; j += 2)
                {
                    id_classif = classif[j];
                    TreeNode node1 = new TreeNode(classif[j + 1]);
                    node1.Tag = classif[j];
                    node0.Nodes.Add(node1);

                    List<string> meduc = SQLClass.myselect("Select ID, name FROM lvl3 WHERE ID_CLASS = '" + id_classif + "'");

                    for(int g=0; g< meduc.Count; g += 2)
                    {
                        TreeNode node2 = new TreeNode(meduc[g + 1]);
                        node2.Tag = meduc[g];
                        node1.Nodes.Add(node2);

                    }

                }
            }
           

            
        }
    }
}
