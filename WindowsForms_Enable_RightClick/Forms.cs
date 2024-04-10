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

namespace StorImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create a new ContextMenuStrip
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            // Create a new ToolStripMenuItem
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            // Add the ToolStripMenuItem to the ContextMenuStrip
            contextMenuStrip.Items.Add(pasteItem);
            // Assign the ContextMenuStrip to the TextBox
            TextBoxContent.ContextMenuStrip = contextMenuStrip;

            // Add a click event handler for the Paste menu item
            pasteItem.Click += PasteItem_Click;
        }

        private void PasteItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TextBoxContent.Paste();
            }
        }

        private void buttonExecuteClick(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
            string barcode = TextBoxContent.Text;
            List<string> listOfBarcode = barcode.Split('\n').Where(line => !string.IsNullOrWhiteSpace(line)).ToList();

            foreach (string item in listOfBarcode)
            {
                Console.WriteLine($"barcode: {item}");
            }
        }
    }
}
