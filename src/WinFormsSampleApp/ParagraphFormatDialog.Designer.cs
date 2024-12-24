namespace WinFormsSampleApp;

partial class ParagraphFormatDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.groupBox1 = new GroupBox();
        this.groupBox2 = new GroupBox();
        this.cancelButton = new Button();
        this.okButton = new Button();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.tabPage2 = new TabPage();
        this.tabPage3 = new TabPage();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Location = new Point(6, 6);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(359, 141);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Indent";
        // 
        // groupBox2
        // 
        this.groupBox2.Location = new Point(6, 153);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(359, 157);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Spacing";
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(289, 415);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 11;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.Location = new Point(189, 415);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 10;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Location = new Point(4, 5);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new Size(389, 404);
        this.tabControl1.TabIndex = 13;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.groupBox1);
        this.tabPage1.Controls.Add(this.groupBox2);
        this.tabPage1.Location = new Point(4, 29);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(381, 371);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Paragraph";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        this.tabPage2.Location = new Point(4, 29);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(381, 371);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Tabs";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        this.tabPage3.Location = new Point(4, 29);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(381, 371);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "List";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // ParagraphFormatDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(396, 456);
        Controls.Add(this.tabControl1);
        Controls.Add(this.cancelButton);
        Controls.Add(this.okButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ParagraphFormatDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Paragraph Properties";
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Button cancelButton;
    private Button okButton;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
}