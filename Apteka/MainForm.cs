using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Apteka
{
    public partial class MainForm : Form
    {
        public static string Login = "";
        public static string NameFamale = "";
        public static int isAdmin;
        public MainForm()
        {
            InitializeComponent();

            Text = "Аптека";

            MainUserControl mauc = new MainUserControl();
            mauc.Dock = DockStyle.Fill;
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(mauc);
            Adminbutton.Visible = false;
            Designbutton.Visible = false;
            DesignUserControl.
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
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
                AptekaUserControl apteka = new AptekaUserControl(e.Node.Tag.ToString());
                apteka.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(apteka);
            }

            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Аптеки")
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

            if (e.Node.Level == 0 && e.Node.Text == "Админка")
            {
                AdminUserControl admin = new AdminUserControl();
                admin.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(admin);
            }    


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_apteka;
            string id_classif;

            List<string> apteki = SQLClass.myselect("Select ID, name FROM lvl1 ");

            for (int i = 0; i < apteki.Count; i += 2)
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

                    for (int g = 0; g < meduc.Count; g += 2)
                    {
                        TreeNode node2 = new TreeNode(meduc[g + 1]);
                        node2.Tag = meduc[g];
                        node1.Nodes.Add(node2);

                    }

                }
            }



        }

        private void Authpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Authbutton_Click(object sender, EventArgs e)
        {
            List<string> user_date = SQLClass.myselect("SELECT login, name, famillia, Admin FROM user WHERE login = '" + LogintextBox.Text + "' AND pass = '" + PasstextBox.Text + "'");

            if (Authbutton.Text == "Выйти")
            {
                Login = "";
                Authpanel.Controls.Clear();
                Authbutton.Text = "Войти";
                Authpanel.Controls.Add(Authbutton);
                Authpanel.Controls.Add(Loginlabel);
                Authpanel.Controls.Add(Passlabel);
                Authpanel.Controls.Add(Regbutton);
                PasstextBox.Text = "";
                Authpanel.Controls.Add(PasstextBox);
                LogintextBox.Text = "";
                Authpanel.Controls.Add(LogintextBox);
                Hellolabel.Visible = false;
                Hellolabel.Text = "";
                isAdmin = 0;



            }
            else
            {
                if (user_date.Count > 0)
                {
                    isAdmin = Convert.ToInt32(user_date[3]);
                    Login = user_date[0];
                    NameFamale = user_date[1] + " " + user_date[2];
                    Authpanel.Controls.Clear();
                    Authbutton.Text = "Выйти";
                    Authpanel.Controls.Add(Authbutton);
                    Authpanel.Controls.Add(Hellolabel);
                    Hellolabel.Visible = true;
                    Hellolabel.Text = "Добро пожаловать, " + NameFamale;
                    Adminbutton.Visible = Convert.ToBoolean(isAdmin);
                    Designbutton.Visible = Convert.ToBoolean(isAdmin);
                    Authpanel.Controls.Add(Adminbutton);
                    Authpanel.Controls.Add(Designbutton);
                }
                else
                {
                    MessageBox.Show("Вы указали неверный логин/пароль или не зарегистрированы");

                    LogintextBox.Text = "";
                    PasstextBox.Text = "";
                }

            }
        }



        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

         private void Regbutton_Click(object sender, EventArgs e)
         {
             RegForm rg = new RegForm();
             rg.ShowDialog();
         }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            AdminUserControl mauc = new AdminUserControl();
            mauc.Dock = DockStyle.Fill;
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(mauc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count == 1)
            {
                TreeNode node = new TreeNode("Админка");
                treeView1.Nodes.Add(node);
            }
            else if(!Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void Designbutton_Click(object sender, EventArgs e)
        {
            DesignUserControl dsuc = new DesignUserControl();
            dsuc.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(dsuc);
        }
    }
  
}
