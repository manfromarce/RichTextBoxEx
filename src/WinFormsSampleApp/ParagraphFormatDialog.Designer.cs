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
        this.components = new System.ComponentModel.Container();
        this.groupBox1 = new GroupBox();
        this.specialIndentComboBox = new ComboBox();
        this.label14 = new Label();
        this.label13 = new Label();
        this.label12 = new Label();
        this.label3 = new Label();
        this.hangingIndentUpDown = new NumericUpDown();
        this.rightIndentUpDown = new NumericUpDown();
        this.leftIndentUpDown = new NumericUpDown();
        this.label2 = new Label();
        this.label1 = new Label();
        this.groupBox2 = new GroupBox();
        this.label17 = new Label();
        this.label16 = new Label();
        this.lineSpacingUnitLabel = new Label();
        this.lineSpacingValueLabel = new Label();
        this.label8 = new Label();
        this.label7 = new Label();
        this.lineSpacingValueUpDown = new NumericUpDown();
        this.spaceAfterUpDown = new NumericUpDown();
        this.spaceBeforeUpDown = new NumericUpDown();
        this.spacingRuleComboBox = new ComboBox();
        this.label5 = new Label();
        this.defaultSettingsCheckBox = new CheckBox();
        this.cancelButton = new Button();
        this.okButton = new Button();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.groupBox3 = new GroupBox();
        this.label4 = new Label();
        this.alignmentComboBox = new ComboBox();
        this.tabPage2 = new TabPage();
        this.label11 = new Label();
        this.button3 = new Button();
        this.button2 = new Button();
        this.button1 = new Button();
        this.tabsComboBox = new ComboBox();
        this.tabPage3 = new TabPage();
        this.numberStyleComboBox = new ComboBox();
        this.numberStyleLabel = new Label();
        this.bulletTextDistanceUpDown = new NumericUpDown();
        this.firstNumberUpDown = new NumericUpDown();
        this.label10 = new Label();
        this.firstNumberLabel = new Label();
        this.listTypeComboBox = new ComboBox();
        this.label6 = new Label();
        this.toolTip1 = new ToolTip(this.components);
        this.defaultBulletIndentUpDown = new NumericUpDown();
        this.label9 = new Label();
        this.defaultBulletTextDistanceUpDown = new NumericUpDown();
        this.label15 = new Label();
        this.label18 = new Label();
        this.label19 = new Label();
        this.label20 = new Label();
        this.groupBox4 = new GroupBox();
        this.groupBox5 = new GroupBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.hangingIndentUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.rightIndentUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.leftIndentUpDown).BeginInit();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.lineSpacingValueUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.spaceAfterUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.spaceBeforeUpDown).BeginInit();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.bulletTextDistanceUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.firstNumberUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.defaultBulletIndentUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.defaultBulletTextDistanceUpDown).BeginInit();
        this.groupBox4.SuspendLayout();
        this.groupBox5.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.specialIndentComboBox);
        this.groupBox1.Controls.Add(this.label14);
        this.groupBox1.Controls.Add(this.label13);
        this.groupBox1.Controls.Add(this.label12);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.hangingIndentUpDown);
        this.groupBox1.Controls.Add(this.rightIndentUpDown);
        this.groupBox1.Controls.Add(this.leftIndentUpDown);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Location = new Point(6, 96);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(390, 197);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Indent";
        // 
        // specialIndentComboBox
        // 
        this.specialIndentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.specialIndentComboBox.FormattingEnabled = true;
        this.specialIndentComboBox.Items.AddRange(new object[] { "None", "Indent first line", "Indent second and subsequent lines" });
        this.specialIndentComboBox.Location = new Point(193, 117);
        this.specialIndentComboBox.Name = "specialIndentComboBox";
        this.specialIndentComboBox.Size = new Size(183, 28);
        this.specialIndentComboBox.TabIndex = 4;
        this.specialIndentComboBox.SelectedIndexChanged += specialIndentComboBox_SelectedIndexChanged;
        // 
        // label14
        // 
        this.label14.AutoSize = true;
        this.label14.Location = new Point(348, 153);
        this.label14.Name = "label14";
        this.label14.Size = new Size(23, 20);
        this.label14.TabIndex = 8;
        this.label14.Text = "pt";
        // 
        // label13
        // 
        this.label13.AutoSize = true;
        this.label13.Location = new Point(348, 75);
        this.label13.Name = "label13";
        this.label13.Size = new Size(23, 20);
        this.label13.TabIndex = 7;
        this.label13.Text = "pt";
        // 
        // label12
        // 
        this.label12.AutoSize = true;
        this.label12.Location = new Point(348, 33);
        this.label12.Name = "label12";
        this.label12.Size = new Size(23, 20);
        this.label12.TabIndex = 6;
        this.label12.Text = "pt";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(12, 117);
        this.label3.Name = "label3";
        this.label3.Size = new Size(60, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "Special:";
        // 
        // hangingIndentUpDown
        // 
        this.hangingIndentUpDown.Location = new Point(193, 151);
        this.hangingIndentUpDown.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
        this.hangingIndentUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.hangingIndentUpDown.Name = "hangingIndentUpDown";
        this.hangingIndentUpDown.Size = new Size(147, 27);
        this.hangingIndentUpDown.TabIndex = 5;
        this.hangingIndentUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // rightIndentUpDown
        // 
        this.rightIndentUpDown.Location = new Point(193, 73);
        this.rightIndentUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.rightIndentUpDown.Name = "rightIndentUpDown";
        this.rightIndentUpDown.Size = new Size(147, 27);
        this.rightIndentUpDown.TabIndex = 4;
        // 
        // leftIndentUpDown
        // 
        this.leftIndentUpDown.Location = new Point(193, 31);
        this.leftIndentUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.leftIndentUpDown.Name = "leftIndentUpDown";
        this.leftIndentUpDown.Size = new Size(147, 27);
        this.leftIndentUpDown.TabIndex = 3;
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
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 33);
        this.label1.Name = "label1";
        this.label1.Size = new Size(37, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Left:";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.label17);
        this.groupBox2.Controls.Add(this.label16);
        this.groupBox2.Controls.Add(this.lineSpacingUnitLabel);
        this.groupBox2.Controls.Add(this.lineSpacingValueLabel);
        this.groupBox2.Controls.Add(this.label8);
        this.groupBox2.Controls.Add(this.label7);
        this.groupBox2.Controls.Add(this.lineSpacingValueUpDown);
        this.groupBox2.Controls.Add(this.spaceAfterUpDown);
        this.groupBox2.Controls.Add(this.spaceBeforeUpDown);
        this.groupBox2.Controls.Add(this.spacingRuleComboBox);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Location = new Point(6, 300);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new Size(390, 201);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Spacing";
        // 
        // label17
        // 
        this.label17.AutoSize = true;
        this.label17.Location = new Point(348, 160);
        this.label17.Name = "label17";
        this.label17.Size = new Size(23, 20);
        this.label17.TabIndex = 14;
        this.label17.Text = "pt";
        // 
        // label16
        // 
        this.label16.AutoSize = true;
        this.label16.Location = new Point(348, 116);
        this.label16.Name = "label16";
        this.label16.Size = new Size(23, 20);
        this.label16.TabIndex = 13;
        this.label16.Text = "pt";
        // 
        // lineSpacingUnitLabel
        // 
        this.lineSpacingUnitLabel.AutoSize = true;
        this.lineSpacingUnitLabel.Location = new Point(348, 68);
        this.lineSpacingUnitLabel.Name = "lineSpacingUnitLabel";
        this.lineSpacingUnitLabel.Size = new Size(23, 20);
        this.lineSpacingUnitLabel.TabIndex = 12;
        this.lineSpacingUnitLabel.Text = "pt";
        // 
        // lineSpacingValueLabel
        // 
        this.lineSpacingValueLabel.AutoSize = true;
        this.lineSpacingValueLabel.Location = new Point(12, 68);
        this.lineSpacingValueLabel.Name = "lineSpacingValueLabel";
        this.lineSpacingValueLabel.Size = new Size(133, 20);
        this.lineSpacingValueLabel.TabIndex = 11;
        this.lineSpacingValueLabel.Text = "Line spacing value:";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(12, 160);
        this.label8.Name = "label8";
        this.label8.Size = new Size(160, 20);
        this.label8.TabIndex = 10;
        this.label8.Text = "Space after paragraph:";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(12, 116);
        this.label7.Name = "label7";
        this.label7.Size = new Size(173, 20);
        this.label7.TabIndex = 9;
        this.label7.Text = "Space before paragraph:";
        // 
        // lineSpacingValueUpDown
        // 
        this.lineSpacingValueUpDown.Location = new Point(193, 66);
        this.lineSpacingValueUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.lineSpacingValueUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.lineSpacingValueUpDown.Name = "lineSpacingValueUpDown";
        this.lineSpacingValueUpDown.Size = new Size(147, 27);
        this.lineSpacingValueUpDown.TabIndex = 8;
        this.lineSpacingValueUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // spaceAfterUpDown
        // 
        this.spaceAfterUpDown.Location = new Point(193, 158);
        this.spaceAfterUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.spaceAfterUpDown.Name = "spaceAfterUpDown";
        this.spaceAfterUpDown.Size = new Size(147, 27);
        this.spaceAfterUpDown.TabIndex = 7;
        // 
        // spaceBeforeUpDown
        // 
        this.spaceBeforeUpDown.Location = new Point(193, 114);
        this.spaceBeforeUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.spaceBeforeUpDown.Name = "spaceBeforeUpDown";
        this.spaceBeforeUpDown.Size = new Size(147, 27);
        this.spaceBeforeUpDown.TabIndex = 6;
        // 
        // spacingRuleComboBox
        // 
        this.spacingRuleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.spacingRuleComboBox.FormattingEnabled = true;
        this.spacingRuleComboBox.Items.AddRange(new object[] { "Single", "One and a half", "Double", "Minimum", "Exact", "Multiple" });
        this.spacingRuleComboBox.Location = new Point(193, 32);
        this.spacingRuleComboBox.Name = "spacingRuleComboBox";
        this.spacingRuleComboBox.Size = new Size(183, 28);
        this.spacingRuleComboBox.TabIndex = 5;
        this.spacingRuleComboBox.SelectedIndexChanged += spacingRuleComboBox_SelectedIndexChanged;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(12, 35);
        this.label5.Name = "label5";
        this.label5.Size = new Size(137, 20);
        this.label5.TabIndex = 4;
        this.label5.Text = "Line spacing mode:";
        // 
        // defaultSettingsCheckBox
        // 
        this.defaultSettingsCheckBox.AutoSize = true;
        this.defaultSettingsCheckBox.Location = new Point(11, 506);
        this.defaultSettingsCheckBox.Name = "defaultSettingsCheckBox";
        this.defaultSettingsCheckBox.Size = new Size(306, 24);
        this.defaultSettingsCheckBox.TabIndex = 0;
        this.defaultSettingsCheckBox.Text = "Set spacing and indent settings as default";
        this.defaultSettingsCheckBox.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(310, 586);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 11;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += cancelButton_Click;
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.Location = new Point(210, 586);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 10;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += okButton_Click;
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
        this.tabControl1.Size = new Size(410, 572);
        this.tabControl1.TabIndex = 13;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.groupBox3);
        this.tabPage1.Controls.Add(this.groupBox1);
        this.tabPage1.Controls.Add(this.groupBox2);
        this.tabPage1.Controls.Add(this.defaultSettingsCheckBox);
        this.tabPage1.Location = new Point(4, 29);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(402, 539);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Paragraph";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.label4);
        this.groupBox3.Controls.Add(this.alignmentComboBox);
        this.groupBox3.Location = new Point(6, 12);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new Size(390, 78);
        this.groupBox3.TabIndex = 4;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "General";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(14, 34);
        this.label4.Name = "label4";
        this.label4.Size = new Size(81, 20);
        this.label4.TabIndex = 2;
        this.label4.Text = "Alignment:";
        // 
        // alignmentComboBox
        // 
        this.alignmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.alignmentComboBox.FormattingEnabled = true;
        this.alignmentComboBox.Items.AddRange(new object[] { "Left", "Right", "Center", "Justified" });
        this.alignmentComboBox.Location = new Point(193, 31);
        this.alignmentComboBox.Name = "alignmentComboBox";
        this.alignmentComboBox.Size = new Size(183, 28);
        this.alignmentComboBox.TabIndex = 3;
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.label11);
        this.tabPage2.Controls.Add(this.button3);
        this.tabPage2.Controls.Add(this.button2);
        this.tabPage2.Controls.Add(this.button1);
        this.tabPage2.Controls.Add(this.tabsComboBox);
        this.tabPage2.Location = new Point(4, 29);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(402, 539);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Tabs";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        this.label11.AutoSize = true;
        this.label11.Location = new Point(238, 22);
        this.label11.Name = "label11";
        this.label11.Size = new Size(57, 20);
        this.label11.TabIndex = 7;
        this.label11.Text = "(pixels)";
        // 
        // button3
        // 
        this.button3.Location = new Point(229, 230);
        this.button3.Name = "button3";
        this.button3.Size = new Size(103, 29);
        this.button3.TabIndex = 6;
        this.button3.Text = "Remove all";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += button3_Click;
        // 
        // button2
        // 
        this.button2.Location = new Point(120, 230);
        this.button2.Name = "button2";
        this.button2.Size = new Size(103, 29);
        this.button2.TabIndex = 5;
        this.button2.Text = "Remove";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += button2_Click;
        // 
        // button1
        // 
        this.button1.Location = new Point(11, 230);
        this.button1.Name = "button1";
        this.button1.Size = new Size(103, 29);
        this.button1.TabIndex = 4;
        this.button1.Text = "Add";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += button1_Click;
        // 
        // tabsComboBox
        // 
        this.tabsComboBox.DropDownStyle = ComboBoxStyle.Simple;
        this.tabsComboBox.FormattingEnabled = true;
        this.tabsComboBox.IntegralHeight = false;
        this.tabsComboBox.Location = new Point(11, 19);
        this.tabsComboBox.Name = "tabsComboBox";
        this.tabsComboBox.Size = new Size(212, 195);
        this.tabsComboBox.TabIndex = 3;
        this.tabsComboBox.KeyUp += tabsComboBox_KeyUp;
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.groupBox5);
        this.tabPage3.Controls.Add(this.groupBox4);
        this.tabPage3.Location = new Point(4, 29);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(402, 539);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "List";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // numberStyleComboBox
        // 
        this.numberStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.numberStyleComboBox.FormattingEnabled = true;
        this.numberStyleComboBox.Items.AddRange(new object[] { "Right parenthesis - 1) / A) / ...", "Double parenthesis - (1) / (A) / ...", "Period - 1. / 2. / 3.", "Number or letter only" });
        this.numberStyleComboBox.Location = new Point(221, 77);
        this.numberStyleComboBox.Name = "numberStyleComboBox";
        this.numberStyleComboBox.Size = new Size(163, 28);
        this.numberStyleComboBox.TabIndex = 17;
        // 
        // numberStyleLabel
        // 
        this.numberStyleLabel.AutoSize = true;
        this.numberStyleLabel.Location = new Point(15, 80);
        this.numberStyleLabel.Name = "numberStyleLabel";
        this.numberStyleLabel.Size = new Size(100, 20);
        this.numberStyleLabel.TabIndex = 16;
        this.numberStyleLabel.Text = "Number style:";
        // 
        // bulletTextDistanceUpDown
        // 
        this.bulletTextDistanceUpDown.Location = new Point(221, 165);
        this.bulletTextDistanceUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.bulletTextDistanceUpDown.Name = "bulletTextDistanceUpDown";
        this.bulletTextDistanceUpDown.Size = new Size(133, 27);
        this.bulletTextDistanceUpDown.TabIndex = 15;
        // 
        // firstNumberUpDown
        // 
        this.firstNumberUpDown.Location = new Point(221, 123);
        this.firstNumberUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.firstNumberUpDown.Name = "firstNumberUpDown";
        this.firstNumberUpDown.Size = new Size(163, 27);
        this.firstNumberUpDown.TabIndex = 13;
        this.firstNumberUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new Point(15, 167);
        this.label10.Name = "label10";
        this.label10.Size = new Size(140, 20);
        this.label10.TabIndex = 12;
        this.label10.Text = "Bullet-text distance:";
        // 
        // firstNumberLabel
        // 
        this.firstNumberLabel.AutoSize = true;
        this.firstNumberLabel.Location = new Point(15, 125);
        this.firstNumberLabel.Name = "firstNumberLabel";
        this.firstNumberLabel.Size = new Size(94, 20);
        this.firstNumberLabel.TabIndex = 10;
        this.firstNumberLabel.Text = "First number:";
        // 
        // listTypeComboBox
        // 
        this.listTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this.listTypeComboBox.FormattingEnabled = true;
        this.listTypeComboBox.Items.AddRange(new object[] { "None", "Bulleted (•)", "1, 2, 3, 4, 5", "a, b, c, d, e", "A, B, C, D, E", "i, ii, iii, iv, v", "I, II, III, IV, V" });
        this.listTypeComboBox.Location = new Point(221, 30);
        this.listTypeComboBox.Name = "listTypeComboBox";
        this.listTypeComboBox.Size = new Size(163, 28);
        this.listTypeComboBox.TabIndex = 7;
        this.listTypeComboBox.SelectedIndexChanged += listTypeComboBox_SelectedIndexChanged;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(15, 33);
        this.label6.Name = "label6";
        this.label6.Size = new Size(67, 20);
        this.label6.TabIndex = 6;
        this.label6.Text = "List type:";
        // 
        // toolTip1
        // 
        this.toolTip1.AutomaticDelay = 0;
        this.toolTip1.AutoPopDelay = 999999;
        this.toolTip1.InitialDelay = 0;
        this.toolTip1.ReshowDelay = 0;
        this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
        this.toolTip1.ToolTipTitle = "Hint";
        // 
        // defaultBulletIndentUpDown
        // 
        this.defaultBulletIndentUpDown.Location = new Point(221, 37);
        this.defaultBulletIndentUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.defaultBulletIndentUpDown.Name = "defaultBulletIndentUpDown";
        this.defaultBulletIndentUpDown.Size = new Size(133, 27);
        this.defaultBulletIndentUpDown.TabIndex = 19;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new Point(15, 39);
        this.label9.Name = "label9";
        this.label9.Size = new Size(149, 20);
        this.label9.TabIndex = 18;
        this.label9.Text = "Default bullet indent:";
        // 
        // defaultBulletTextDistanceUpDown
        // 
        this.defaultBulletTextDistanceUpDown.Location = new Point(221, 79);
        this.defaultBulletTextDistanceUpDown.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
        this.defaultBulletTextDistanceUpDown.Name = "defaultBulletTextDistanceUpDown";
        this.defaultBulletTextDistanceUpDown.Size = new Size(133, 27);
        this.defaultBulletTextDistanceUpDown.TabIndex = 21;
        // 
        // label15
        // 
        this.label15.AutoSize = true;
        this.label15.Location = new Point(15, 81);
        this.label15.Name = "label15";
        this.label15.Size = new Size(193, 20);
        this.label15.TabIndex = 20;
        this.label15.Text = "Default bullet-text distance:";
        // 
        // label18
        // 
        this.label18.AutoSize = true;
        this.label18.Location = new Point(361, 81);
        this.label18.Name = "label18";
        this.label18.Size = new Size(23, 20);
        this.label18.TabIndex = 22;
        this.label18.Text = "pt";
        // 
        // label19
        // 
        this.label19.AutoSize = true;
        this.label19.Location = new Point(361, 39);
        this.label19.Name = "label19";
        this.label19.Size = new Size(23, 20);
        this.label19.TabIndex = 23;
        this.label19.Text = "pt";
        // 
        // label20
        // 
        this.label20.AutoSize = true;
        this.label20.Location = new Point(361, 167);
        this.label20.Name = "label20";
        this.label20.Size = new Size(23, 20);
        this.label20.TabIndex = 24;
        this.label20.Text = "pt";
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.label6);
        this.groupBox4.Controls.Add(this.label20);
        this.groupBox4.Controls.Add(this.listTypeComboBox);
        this.groupBox4.Controls.Add(this.firstNumberLabel);
        this.groupBox4.Controls.Add(this.label10);
        this.groupBox4.Controls.Add(this.firstNumberUpDown);
        this.groupBox4.Controls.Add(this.bulletTextDistanceUpDown);
        this.groupBox4.Controls.Add(this.numberStyleLabel);
        this.groupBox4.Controls.Add(this.numberStyleComboBox);
        this.groupBox4.Location = new Point(4, 6);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new Size(390, 212);
        this.groupBox4.TabIndex = 25;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Current paragraph settings";
        // 
        // groupBox5
        // 
        this.groupBox5.Controls.Add(this.defaultBulletIndentUpDown);
        this.groupBox5.Controls.Add(this.label9);
        this.groupBox5.Controls.Add(this.label19);
        this.groupBox5.Controls.Add(this.label15);
        this.groupBox5.Controls.Add(this.label18);
        this.groupBox5.Controls.Add(this.defaultBulletTextDistanceUpDown);
        this.groupBox5.Location = new Point(4, 224);
        this.groupBox5.Name = "groupBox5";
        this.groupBox5.Size = new Size(390, 125);
        this.groupBox5.TabIndex = 26;
        this.groupBox5.TabStop = false;
        this.groupBox5.Text = "Default settings";
        // 
        // ParagraphFormatDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(417, 624);
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
        ((System.ComponentModel.ISupportInitialize)this.hangingIndentUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.rightIndentUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.leftIndentUpDown).EndInit();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.lineSpacingValueUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.spaceAfterUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.spaceBeforeUpDown).EndInit();
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.bulletTextDistanceUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.firstNumberUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.defaultBulletIndentUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.defaultBulletTextDistanceUpDown).EndInit();
        this.groupBox4.ResumeLayout(false);
        this.groupBox4.PerformLayout();
        this.groupBox5.ResumeLayout(false);
        this.groupBox5.PerformLayout();
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
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label5;
    private Label label4;
    private Button button3;
    private Button button2;
    private Button button1;
    private Label label10;
    private Label firstNumberLabel;
    private Label label6;
    public NumericUpDown leftIndentUpDown;
    public NumericUpDown hangingIndentUpDown;
    public NumericUpDown rightIndentUpDown;
    public ComboBox spacingRuleComboBox;
    public CheckBox defaultSettingsCheckBox;
    public ComboBox alignmentComboBox;
    public ComboBox tabsComboBox;
    public NumericUpDown bulletTextDistanceUpDown;
    public NumericUpDown firstNumberUpDown;
    public ComboBox listTypeComboBox;
    public NumericUpDown spaceAfterUpDown;
    public NumericUpDown spaceBeforeUpDown;
    public NumericUpDown lineSpacingValueUpDown;
    private Label label8;
    private Label label7;
    private Label lineSpacingValueLabel;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label16;
    private Label lineSpacingUnitLabel;
    private Label label17;
    public ComboBox numberStyleComboBox;
    private Label numberStyleLabel;
    private Label label11;
    private GroupBox groupBox3;
    private ToolTip toolTip1;
    public ComboBox specialIndentComboBox;
    private Label label20;
    private Label label19;
    private Label label18;
    public NumericUpDown defaultBulletTextDistanceUpDown;
    private Label label15;
    public NumericUpDown defaultBulletIndentUpDown;
    private Label label9;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
}