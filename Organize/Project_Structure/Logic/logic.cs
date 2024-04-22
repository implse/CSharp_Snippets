using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Structure
{
    internal class Logic
    {
        public static void logicMethod(bool checkBox1, bool checkBox2, bool checkBox3, string textBox1, string textBox2, string textBox3)
        {
            Console.WriteLine(checkBox1);
            Console.WriteLine(checkBox2);
            Console.WriteLine(checkBox3);

            if (checkBox1)
            {
                string box1 = textBox1.Trim();
                Console.WriteLine(box1);
            }
            if (checkBox2)
            {
                string box2 = textBox2.Trim();
                Console.WriteLine(box2);
            }
            if (checkBox3)
            {
                string box3 = textBox3.Trim();
                Console.WriteLine(box3);
            }
        }
    }
}
