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
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.numericUpDown1 = new NumericUpDown();
        this.numericUpDown2 = new NumericUpDown();
        this.numericUpDown3 = new NumericUpDown();
        this.label4 = new Label();
        this.checkBox1 = new CheckBox();
        this.comboBox1 = new ComboBox();
        this.comboBox2 = new ComboBox();
        this.label5 = new Label();
        this.comboBox3 = new ComboBox();
        this.button3 = new Button();
        this.button2 = new Button();
        this.button1 = new Button();
        this.comboBox4 = new ComboBox();
        this.label6 = new Label();
        this.comboBox5 = new ComboBox();
        this.label7 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.numericUpDown4 = new NumericUpDown();
        this.numericUpDown5 = new NumericUpDown();
        this.numericUpDown6 = new NumericUpDown();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown6).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.numericUpDown3);
        this.groupBox1.Controls.Add(this.numericUpDown2);
        this.groupBox1.Controls.Add(this.numericUpDown1);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Location = new Point(6, 6);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(330, 159);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Indent";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.comboBox2);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Controls.Add(this.checkBox1);
        this.groupBox2.Location = new Point(6, 171);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(330, 124);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Spacing";
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(250, 415);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 11;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.Location = new Point(150, 415);
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
        this.tabControl1.Size = new Size(350, 404);
        this.tabControl1.TabIndex = 13;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.comboBox1);
        this.tabPage1.Controls.Add(this.label4);
        this.tabPage1.Controls.Add(this.groupBox1);
        this.tabPage1.Controls.Add(this.groupBox2);
        this.tabPage1.Location = new Point(4, 29);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(342, 371);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Paragraph";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.button3);
        this.tabPage2.Controls.Add(this.button2);
        this.tabPage2.Controls.Add(this.button1);
        this.tabPage2.Controls.Add(this.comboBox3);
        this.tabPage2.Location = new Point(4, 29);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(342, 371);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Tabs";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.numericUpDown6);
        this.tabPage3.Controls.Add(this.numericUpDown5);
        this.tabPage3.Controls.Add(this.numericUpDown4);
        this.tabPage3.Controls.Add(this.label10);
        this.tabPage3.Controls.Add(this.label9);
        this.tabPage3.Controls.Add(this.label8);
        this.tabPage3.Controls.Add(this.comboBox5);
        this.tabPage3.Controls.Add(this.label7);
        this.tabPage3.Controls.Add(this.comboBox4);
        this.tabPage3.Controls.Add(this.label6);
        this.tabPage3.Location = new Point(4, 29);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(342, 371);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "List";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 33);
        this.label1.Name = "label1";
        this.label1.Size = new Size(37, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Left:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(12, 75);
        this.label2.Name = "label2";
        this.label2.Size = new Size(47, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "Right:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(12, 117);
        this.label3.Name = "label3";
        this.label3.Size = new Size(67, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "First line:";
        // 
        // numericUpDown1
        // 
        this.numericUpDown1.Location = new Point(139, 31);
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new Size(180, 27);
        this.numericUpDown1.TabIndex = 3;
        // 
        // numericUpDown2
        // 
        this.numericUpDown2.Location = new Point(139, 73);
        this.numericUpDown2.Name = "numericUpDown2";
        this.numericUpDown2.Size = new Size(180, 27);
        this.numericUpDown2.TabIndex = 4;
        // 
        // numericUpDown3
        // 
        this.numericUpDown3.Location = new Point(139, 115);
        this.numericUpDown3.Name = "numericUpDown3";
        this.numericUpDown3.Size = new Size(180, 27);
        this.numericUpDown3.TabIndex = 5;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(18, 317);
        this.label4.Name = "label4";
        this.label4.Size = new Size(81, 20);
        this.label4.TabIndex = 2;
        this.label4.Text = "Alignment:";
        // 
        // checkBox1
        // 
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new Point(12, 82);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new Size(207, 24);
        this.checkBox1.TabIndex = 0;
        this.checkBox1.Text = "Add 10pt after paragraphs";
        this.checkBox1.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] { "Left", "Right", "Center", "Justified" });
        this.comboBox1.Location = new Point(142, 314);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new Size(183, 28);
        this.comboBox1.TabIndex = 3;
        // 
        // comboBox2
        // 
        this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox2.FormattingEnabled = true;
        this.comboBox2.Items.AddRange(new object[] { "1.00", "1.15", "1.50", "2.00", "3.00" });
        this.comboBox2.Location = new Point(136, 37);
        this.comboBox2.Name = "comboBox2";
        this.comboBox2.Size = new Size(183, 28);
        this.comboBox2.TabIndex = 5;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(12, 40);
        this.label5.Name = "label5";
        this.label5.Size = new Size(81, 20);
        this.label5.TabIndex = 4;
        this.label5.Text = "Alignment:";
        // 
        // comboBox3
        // 
        this.comboBox3.DropDownStyle = ComboBoxStyle.Simple;
        this.comboBox3.FormattingEnabled = true;
        this.comboBox3.Location = new Point(11, 19);
        this.comboBox3.Name = "comboBox3";
        this.comboBox3.Size = new Size(212, 195);
        this.comboBox3.Sorted = true;
        this.comboBox3.TabIndex = 3;
        // 
        // button3
        // 
        this.button3.Location = new Point(229, 230);
        this.button3.Name = "button3";
        this.button3.Size = new Size(103, 29);
        this.button3.TabIndex = 6;
        this.button3.Text = "Remove all";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Location = new Point(120, 230);
        this.button2.Name = "button2";
        this.button2.Size = new Size(103, 29);
        this.button2.TabIndex = 5;
        this.button2.Text = "Remove";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Location = new Point(11, 230);
        this.button1.Name = "button1";
        this.button1.Size = new Size(103, 29);
        this.button1.TabIndex = 4;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // comboBox4
        // 
        this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox4.FormattingEnabled = true;
        this.comboBox4.Items.AddRange(new object[] { "None", "Bulleted", "Numbered" });
        this.comboBox4.Location = new Point(175, 15);
        this.comboBox4.Name = "comboBox4";
        this.comboBox4.Size = new Size(150, 28);
        this.comboBox4.TabIndex = 7;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(7, 18);
        this.label6.Name = "label6";
        this.label6.Size = new Size(67, 20);
        this.label6.TabIndex = 6;
        this.label6.Text = "List type:";
        // 
        // comboBox5
        // 
        this.comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox5.FormattingEnabled = true;
        this.comboBox5.Items.AddRange(new object[] { "1.00", "1.15", "1.50", "2.00", "3.00" });
        this.comboBox5.Location = new Point(175, 59);
        this.comboBox5.Name = "comboBox5";
        this.comboBox5.Size = new Size(150, 28);
        this.comboBox5.TabIndex = 9;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(7, 62);
        this.label7.Name = "label7";
        this.label7.Size = new Size(121, 20);
        this.label7.TabIndex = 8;
        this.label7.Text = "Numbering style:";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(7, 107);
        this.label8.Name = "label8";
        this.label8.Size = new Size(94, 20);
        this.label8.TabIndex = 10;
        this.label8.Text = "First number:";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(7, 152);
        this.label9.Name = "label9";
        this.label9.Size = new Size(153, 20);
        this.label9.TabIndex = 11;
        this.label9.Text = "Bullet/number indent:";
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new Point(7, 197);
        this.label10.Name = "label10";
        this.label10.Size = new Size(98, 20);
        this.label10.TabIndex = 12;
        this.label10.Text = "Text distance:";
        // 
        // numericUpDown4
        // 
        this.numericUpDown4.Location = new Point(175, 105);
        this.numericUpDown4.Name = "numericUpDown4";
        this.numericUpDown4.Size = new Size(150, 27);
        this.numericUpDown4.TabIndex = 13;
        // 
        // numericUpDown5
        // 
        this.numericUpDown5.Location = new Point(175, 150);
        this.numericUpDown5.Name = "numericUpDown5";
        this.numericUpDown5.Size = new Size(150, 27);
        this.numericUpDown5.TabIndex = 14;
        // 
        // numericUpDown6
        // 
        this.numericUpDown6.Location = new Point(175, 195);
        this.numericUpDown6.Name = "numericUpDown6";
        this.numericUpDown6.Size = new Size(150, 27);
        this.numericUpDown6.TabIndex = 15;
        // 
        // ParagraphFormatDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(357, 456);
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
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown3).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown4).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown5).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.numericUpDown6).EndInit();
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
    private NumericUpDown numericUpDown1;
    private Label label3;
    private Label label2;
    private Label label1;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown2;
    private ComboBox comboBox2;
    private Label label5;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private Label label4;
    private Button button3;
    private Button button2;
    private Button button1;
    private ComboBox comboBox3;
    private NumericUpDown numericUpDown6;
    private NumericUpDown numericUpDown5;
    private NumericUpDown numericUpDown4;
    private Label label10;
    private Label label9;
    private Label label8;
    private ComboBox comboBox5;
    private Label label7;
    private ComboBox comboBox4;
    private Label label6;
}