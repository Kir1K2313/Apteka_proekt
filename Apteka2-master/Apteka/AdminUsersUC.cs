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
    public partial class AdminUsersUC : UserControl
    {
        public AdminUsersUC()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void AdminUsersUC_Load(object sender, EventArgs e)
        {
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(label2);
            Infopanel.Controls.Add(label3);
            List<string> user = SQLClass.myselect("Select id, name, familiya FROM users ORDER BY name");
            int y = 200;
            for (int i = 0; i < user.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial", 13);
                lbl.Tag = user[i];
                lbl.Text = user[i + 1];
                Infopanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(400, y);
                lbl1.Size = new Size(200, 30);
                lbl1.Font = new Font("Arial", 13);
                lbl1.Text = user[i + 2];
                Infopanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(800, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial", 13);
                btn.Click += new EventHandler(DeleteUserClick);
                btn.Text = "Удалить";
                Infopanel.Controls.Add(btn);
                y += 35;
            }
        }
        private void DeleteUserClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in Infopanel.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    SQLClass.myUpdate("Delete FROM users WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление прошло успешно");
                    AdminUsersUC_Load(sender, e);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
