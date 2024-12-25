using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSampleApp;
public partial class InsertHyperlinkDialog : Form
{
    public InsertHyperlinkDialog()
    {
        InitializeComponent();
    }

    public string LinkDisplayText
    {
        get
        {
            return displayTextBox.Text;
        }
        set
        {
            displayTextBox.Text = value;
        }
    }

    public string LinkUrl
    {
        get
        {
            return urlTextBox.Text;
        }
        set
        {
            urlTextBox.Text = value;
        }
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(displayTextBox.Text) ||
            string.IsNullOrWhiteSpace(urlTextBox.Text))
        {
            MessageBox.Show("Display text and URL cannot be empty.");
            return;
        }
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    //If display text is blank, suggest the URL as display text until the user changes it)
    //bool autoDisplayText = true;

    private void urlTextBox_TextChanged(object sender, EventArgs e)
    {
        okButton.Enabled = (!string.IsNullOrWhiteSpace(urlTextBox.Text)) &&
                           (!string.IsNullOrWhiteSpace(displayTextBox.Text));
        if (displayTextBox.Text == string.Empty)
        {
            displayTextBox.Text = urlTextBox.Text;
        }
    }

    private void displayTextBox_TextChanged(object sender, EventArgs e)
    {
        okButton.Enabled = (!string.IsNullOrWhiteSpace(urlTextBox.Text)) &&
                   (!string.IsNullOrWhiteSpace(displayTextBox.Text));
        //autoDisplayText = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        LinkUrl = ""; // handled by RichTextBoxEx
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
