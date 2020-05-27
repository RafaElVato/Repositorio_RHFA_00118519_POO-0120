using System;
using System.Windows.Forms;

namespace PreparcialEntrega
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Inicio_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
    
        }
    }
}
