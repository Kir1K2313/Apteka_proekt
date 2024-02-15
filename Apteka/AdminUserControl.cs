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
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {

        }

        private void Aptekabutton_Click(object sender, EventArgs e)
        {
            AdminAptekUC AAUC = new AdminAptekUC();
            AAUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(AAUC);
        }

        private void Classifbutton_Click(object sender, EventArgs e)
        {
            AdminClassifUC ACUC = new AdminClassifUC();
            ACUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(ACUC);
        }
        private void Medicombutton_Click(object sender, EventArgs e)
        {
            AdminMedikomUC AMUC = new AdminMedikomUC();
            AMUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(AMUC);
        }
        private void Usersbutton_Click(object sender, EventArgs e)
        {
            AdminUsersUC AUUC = new AdminUsersUC();
            AUUC.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(AUUC);
        }

    }
}
