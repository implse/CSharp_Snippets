# Enable and Disable texBox using Checkbox

In a Windows Forms application in C#, you can enable and disable a TextBox based on the Checked state of a CheckBox by handling the CheckBox's CheckedChanged event. Here's how you can do it.

## First

Create an event handler for the CheckBox's CheckedChanged event. You can do this in your Form's constructor or Load event:

```
public Form1()
{
    InitializeComponent();

    // Add a CheckedChanged event handler for the CheckBox
    checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
}
```

## Second

Define the event handler for the CheckBox's CheckedChanged event.

```
private void CheckBox1_CheckedChanged(object sender, EventArgs e)
{
    // Enable or disable the TextBox based on the CheckBox's Checked state
    textBox1.Enabled = checkBox1.Checked;
}

```



