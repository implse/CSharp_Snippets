# Enable TextBox Right Click Pasting

You can enable right-click paste functionality on a TextBox by creating a ContextMenuStrip with a "Paste" option.

## First

Create a ContextMenuStrip in your Form's constructor or Load event.

```
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
    textBox1.ContextMenuStrip = contextMenuStrip;

    // Add a click event handler for the Paste menu item
    pasteItem.Click += PasteItem_Click;
}
```

## Second

Define the event handler for the Paste menu item.

```
private void PasteItem_Click(object sender, EventArgs e)
{
    if (Clipboard.ContainsText())
    {
        textBox1.Paste();
    }
}
```