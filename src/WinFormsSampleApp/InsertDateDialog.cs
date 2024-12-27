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
public partial class InsertDateDialog : Form
{
    public InsertDateDialog()
    {
        InitializeComponent();
        var dateTime = DateTime.Now;
        listBox1.Items.AddRange([
            dateTime.ToString("dd/MM/yyyy"),
            dateTime.ToString("MM/dd/yyyy"),
            dateTime.ToString("yyyy-MM-dd"),
            dateTime.ToString("T"),
            dateTime.ToString("t"),
            dateTime.ToString("D"),
            dateTime.ToString("G"),
            dateTime.ToString("g"),
            dateTime.ToString("F"),
            dateTime.ToString("f"),
            dateTime.ToString("dd.MM.yy"),
            dateTime.ToString("dd-MMM-yy"),
            dateTime.ToString("M"),
            dateTime.ToString("Y"),
            ]);
        listBox1.SelectedIndex = 0;
    }

    public string SelectedDateTime = string.Empty;

    private void okButton_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem is string dateTime)
        {
            SelectedDateTime = dateTime;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
        okButton_Click(sender, e);
    }
}
