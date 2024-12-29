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
        bool isNumbered = listTypeComboBox.SelectedIndex >= 2 && listTypeComboBox.SelectedIndex <= 9;
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
                lineSpacingValueUpDown.DecimalPlaces = 0; // disable decimals in this mode
                lineSpacingValueUpDown.Minimum = 1;
                lineSpacingValueUpDown.Increment = 1;
                lineSpacingValueUpDown.Value = 12; // 12 pt (example value)
                break;
            case 5:
                lineSpacingValueLabel.Enabled = true;
                lineSpacingValueUpDown.Enabled = true;
                lineSpacingUnitLabel.Enabled = true;
                lineSpacingUnitLabel.Text = "lines";
                lineSpacingValueUpDown.DecimalPlaces = 1; // allow decimals in this mode
                lineSpacingValueUpDown.Minimum = 0.5M;
                lineSpacingValueUpDown.Increment = 0.5M;
                lineSpacingValueUpDown.Value = 1.5M; // 1,5 lines (example value)
                break;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if ((!string.IsNullOrWhiteSpace(tabsComboBox.Text)) &&
            int.TryParse(tabsComboBox.Text, out int newValue) &&
            newValue >= 0 &&
            (!tabsComboBox.Items.Contains(newValue)))
        {
            int index = 0;

            while (index <= tabsComboBox.Items.Count)
            {
                if (index == tabsComboBox.Items.Count)
                {
                    tabsComboBox.Items.Add(newValue);
                    break;
                }
                else if (tabsComboBox.Items[index] is int val && val > newValue)
                {
                    tabsComboBox.Items.Insert(index, newValue);
                    break;
                }
                ++index;
            }
        }
        tabsComboBox.Text = string.Empty;
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

    private void specialIndentComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool specialIndentEnabled = specialIndentComboBox.SelectedIndex != 0;
        hangingIndentUpDown.Enabled = specialIndentEnabled;
        label14.Enabled = specialIndentEnabled;
    }

    private void tabsComboBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            button1_Click(sender, e);
        }
    }
}
