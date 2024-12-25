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
public partial class ParagraphFormatDialog : Form
{
    public ParagraphFormatDialog()
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

    private void listTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool isNumbered = listTypeComboBox.SelectedIndex >= 2;
        numberStyleLabel.Enabled = isNumbered;
        numberStyleComboBox.Enabled = isNumbered;
        firstNumberLabel.Enabled = isNumbered;
        firstNumberUpDown.Enabled = isNumbered;
    }

    private void spacingRuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (spacingRuleComboBox.SelectedIndex)
        {
            case 0:
            case 1:
            case 2:
                lineSpacingValueLabel.Enabled = false;
                lineSpacingValueUpDown.Enabled = false;
                lineSpacingUnitLabel.Enabled = false;
                break;
            case 3:
            case 4:
                lineSpacingValueLabel.Enabled = true;
                lineSpacingValueUpDown.Enabled = true;
                lineSpacingUnitLabel.Enabled = true;
                lineSpacingUnitLabel.Text = "pt";
                break;
            case 5:
                lineSpacingValueLabel.Enabled = true;
                lineSpacingValueUpDown.Enabled = true;
                lineSpacingUnitLabel.Enabled = true;
                lineSpacingUnitLabel.Text = "lines";
                break;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if ((!string.IsNullOrWhiteSpace(tabsComboBox.Text)) && 
            (!tabsComboBox.Items.Contains(tabsComboBox.Text)))
        {
            tabsComboBox.Items.Add(tabsComboBox.Text);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (tabsComboBox.SelectedIndex > -1)
            tabsComboBox.Items.RemoveAt(tabsComboBox.SelectedIndex);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        tabsComboBox.Items.Clear();
    }
}
