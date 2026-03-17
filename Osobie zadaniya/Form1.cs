using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osobie_zadaniya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 qwe;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //объект
            qwe = new Class1(textBox1, label2, label4, listBox1);
            // выполнение функций    
            qwe.Creating(textBox1, label2, label4, listBox1);

        }

        private void условьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form();
            f2.Show();

        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Яковлев Андрей");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
