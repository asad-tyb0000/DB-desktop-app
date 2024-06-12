using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher tec = new Teacher();
            tec.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin1484")
            {
                Admin adm = new Admin();
                adm.Show();
                this.Hide();
            }
            else if(textBox1.Text == "teacher1484")
            {
                Teacher tec = new Teacher();
                tec.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
