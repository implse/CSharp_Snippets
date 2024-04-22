using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string box1 = textBox1.Text.Trim();
            string box2 = textBox2.Text.Trim();
            string box3 = textBox3.Text.Trim();

            Logic.logicMethod(checkBox1.Checked, checkBox2.Checked, checkBox1.Checked, box1, box2, box3);

        }
    }
}
