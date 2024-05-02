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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Apteka
{
    public partial class MainForm : Form
    {
        public static string Login = "";
        public static string NameFamale = "";
        public static int isAdmin;
        public static string OldVal = "RUB";
        public static string NewVal = "RUB";
        public MainForm()
        {
            InitializeComponent();
            

            Text = "Аптека";

            MainUserControl mauc = new MainUserControl();
            mauc.Dock = DockStyle.Fill;
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(mauc);
            Adminbutton.Visible = false;
            dizainbutton.Visible = false;
            DesignUserControl.ReadDesign();
            DesignUserControl.useDesign(this);
            DesignUserControl.useMenu(this);
            VkpictureBox.Size = new Size(DesignUserControl.HeightPanel, DesignUserControl.HeightPanel);

            APIClass.Weather();
            Weatherlabel.Text = "Температура " + APIClass.temper + " C";
            APIClass.Vals();
            ValcomboBox.SelectedIndex = 0;
            ExchangeLabel.Text = "Курс: $ " + APIClass.vals["USD"] + ",  € " + APIClass.vals["EUR"] + ",  ¥ " + APIClass.vals["CNY"];
           // APIClass.MedPrice();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node.Level == 0 && e.Node.Text == "Аптеки")
            {
                ValcomboBox.SelectedIndex = 0;
                MainUserControl main = new MainUserControl();
                main.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(main);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
                ValcomboBox.SelectedIndex = 0;
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

            else if (e.Node.Level == 0 && e.Node.Text == "Админка")
            {
                AdminUserControl admin = new AdminUserControl();
                admin.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(admin);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление аптеками")
            {
                AdminAptekUCcs AAUC = new AdminAptekUCcs();
                AAUC.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(AAUC);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление классификациями")
            {
                AdminClassifUC ACUC = new AdminClassifUC();
                ACUC.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(ACUC);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление медикоментами")
            {
                AdminMedikomUC AMUC = new AdminMedikomUC();
                AMUC.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(AMUC);
            }
            else if (e.Node.Level == 1 && e.Node.Parent.Text == "Админка" && e.Node.Text == "Управление пользователями")
            {
                AdminUsersUC AUUC = new AdminUsersUC();
                AUUC.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(AUUC);
            }
            else if (e.Node.Level == 0 && e.Node.Text == "Дизайн")
            {
                DesignUserControl dsuc = new DesignUserControl();
                dsuc.Dock = DockStyle.Fill;
                Controls.Clear();
                Controls.Add(dsuc);
            }



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string id_apteka;
            string id_classif;
            DesignUserControl.button_conmenu = contextMenuStrip1;
            DesignUserControl.panel_conmenu = contextMenuEditpanel;
            DesignUserControl.useMenu(this);

            List<string> apteki = SQLClass.myselect("Select ID, name FROM level1 ");

            for (int i = 0; i < apteki.Count; i += 2)
            {
                id_apteka = apteki[i];
                TreeNode node0 = new TreeNode(apteki[i + 1]);
                node0.Tag = apteki[i];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> classif = SQLClass.myselect("Select ID, name FROM level2 WHERE ID_APTEKA = '" + id_apteka + "'");
                for (int j = 0; j < classif.Count; j += 2)
                {
                    id_classif = classif[j];
                    TreeNode node1 = new TreeNode(classif[j + 1]);
                    node1.Tag = classif[j];
                    node0.Nodes.Add(node1);

                    List<string> meduc = SQLClass.myselect("Select ID, name FROM level3 WHERE ID_CLASS = '" + id_classif + "'");

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
            List<string> user_date = SQLClass.myselect("SELECT login, name, familiya, admin FROM users WHERE login = '" + LogintextBox.Text + "' AND pass = '" + PasstextBox.Text + "'");

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
                MainUserControl mauc = new MainUserControl();
                mauc.Dock = DockStyle.Fill;
                Infopanel.Controls.Clear();
                Infopanel.Controls.Add(mauc);



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
                    dizainbutton.Visible = Convert.ToBoolean(isAdmin);
                    Authpanel.Controls.Add(Adminbutton);
                    Authpanel.Controls.Add(dizainbutton);
                    DesignUserControl.useMenu(this);
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
          //  DesignUserControl.useDesign(this);
            if (Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count == 1)
            {
                
                TreeNode node = new TreeNode("Админка");
                treeView1.Nodes.Add(node);

                TreeNode node1 = new TreeNode("Управление аптеками");
                node.Nodes.Add(node1);

                TreeNode node2 = new TreeNode("Управление классификациями");
                node.Nodes.Add(node2);

                TreeNode node3 = new TreeNode("Управление медикоментами");
                node.Nodes.Add(node3);

                TreeNode node4 = new TreeNode("Управление пользователями");
                node.Nodes.Add(node4);

                TreeNode diznode = new TreeNode("Дизайн");
                treeView1.Nodes.Add(diznode);
            }
            else if(!Convert.ToBoolean(isAdmin) && treeView1.Nodes.Count > 1)
            {
                treeView1.Nodes.RemoveAt(1);
            }
        }

        private void dizainbutton_Click(object sender, EventArgs e)
        {
            DesignUserControl dsuc = new DesignUserControl();
            dsuc.Dock = DockStyle.Fill;
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(dsuc);
        }

        private void дизайнКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ContextMenuStrip conmenu = (ContextMenuStrip)(item.GetCurrentParent());
            Button btn = (Button)(conmenu.SourceControl);
            UnigueDesignForm UniqueDesign = new UnigueDesignForm(btn);
            UniqueDesign.ShowDialog();
        }

        private void изменениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ContextMenuStrip conmenu = (ContextMenuStrip)(item.GetCurrentParent());
            Panel pan = (Panel)(conmenu.SourceControl);

            EditpanelForm panform = new EditpanelForm(pan);
            panform.ShowDialog();

            pan.Size = panform.ctrl.Size;

            VkpictureBox.Size = new Size(pan.Height, pan.Height);
        }

        private void VkpictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/aptekaaprel");
        }

        private void ValcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OldVal = NewVal;
            NewVal = ValcomboBox.Text;

            double coef = APIClass.vals[OldVal] / APIClass.vals[NewVal];

            var pricelbl = Controls.Find("PriceLabel", true);

            foreach (Label lbl in pricelbl)
            {
                double price = Convert.ToDouble(lbl.Text);
                price = Math.Round((price * coef), 2);
                lbl.Text = price.ToString();
            }

            var lbllbl = Controls.Find("LabelLabel", true);

            foreach (Label lbl in lbllbl)
            {
                if (NewVal == "RUB")
                    lbl.Text = "Цена, руб.: ";
                else if (NewVal == "USD")
                    lbl.Text = "Цена, $";
                else if (NewVal == "EUR")
                    lbl.Text = "Цена, €";
                else if (NewVal == "CNY")
                    lbl.Text = "Цена, ¥";
            }
        }
    }
  
}