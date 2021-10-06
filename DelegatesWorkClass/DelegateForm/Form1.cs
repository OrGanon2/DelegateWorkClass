
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public int add(int a,int b)
        {
            return a + b;
        }
        public  int sub(int a,int b)
        {
            return a - b;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Dele Deleg = new Dele(add);
            textBox2.Text = Deleg(int.Parse(textBox1.Text),int.Parse(Text.Text)).ToString();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Dele Deleg = new Dele(sub);
            textBox2.Text = Deleg(int.Parse(textBox1.Text), int.Parse(Text.Text)).ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
