using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparcialEntrega
{
    public partial class Form2 : Form
    {
        private UserControl current = null;

        public Form2()
        {
            InitializeComponent();
            current = logIn1;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
           var usuario = ConectionBD.ExecuteQuery("SELECT")
        }
        private void AcercaDeNosotros_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AcercaDeNosotros();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
            tableLayoutPanel1.SetColumnSpan(current, 3);
        }
        private void Register_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
