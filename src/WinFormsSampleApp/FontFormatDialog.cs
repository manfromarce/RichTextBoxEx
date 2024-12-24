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
public partial class FontFormatDialog : Form
{
    public FontFormatDialog()
    {
        InitializeComponent();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void checkBoxAllCaps_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxAllCaps.Checked)
        {
            checkBoxSmallCaps.Checked = false;
        }
    }

    private void checkBoxSmallCaps_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxSmallCaps.Checked)
        {
            checkBoxAllCaps.Checked = false;
        }
    }

    private void checkBoxSubscript_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxSubscript.Checked)
        {
            checkBoxSuperscript.Checked = false;
        }
    }

    private void checkBoxSuperscript_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxSuperscript.Checked)
        {
            checkBoxSubscript.Checked = false;
        }
    }
}
