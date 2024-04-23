using System;
using System.Windows.Forms;

namespace StorImageClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }
        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int text1 = Int32.Parse(textBox1.Text.Trim());
                Console.WriteLine("Check1 is true");
                int result = Process.compute(text1);
                Console.WriteLine("Result: " + result);

            }
            else if (checkBox2.Checked)
            {
                int text2 = Int32.Parse(textBox2.Text.Trim());
                Console.WriteLine("Check2 is true");
                int result = Process.compute(text2);
                Console.WriteLine("Result: " + result);

            }
            else if (checkBox3.Checked)
            {
                int text3 = Int32.Parse(richTextBox1.Text.Trim());
                Console.WriteLine("Check3 is true");
                int result = Process.compute(text3);
                Console.WriteLine("Result: " + result); 

            }

        }
    }
}
