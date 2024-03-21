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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasttextBox.Text == ConfirtextBox.Text)
            {


                SQLClass.myUpdate("INSERT INTO users (login, pass, name, familliya, admin) VALUES ('" + LogintextBox.Text + "', '" + PasttextBox.Text + "', '" + NametextBox.Text + "', '" + FamaletextBox.Text + "', 0)");
                MessageBox.Show("Зарегистрация завершена");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
            Close();
        }
    }
}
