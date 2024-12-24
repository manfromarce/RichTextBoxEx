namespace WinFormsSampleApp;

partial class FontFormatDialog
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
        this.checkBoxBold = new CheckBox();
        this.checkBoxSmallCaps = new CheckBox();
        this.comboBoxUnderlineType = new ComboBox();
        this.comboBoxUnderlineColor = new ComboBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.comboBoxFontStretch = new ComboBox();
        this.okButton = new Button();
        this.cancelButton = new Button();
        this.checkBoxAllCaps = new CheckBox();
        this.checkBoxItalic = new CheckBox();
        this.checkBoxStrikethrough = new CheckBox();
        this.checkBoxSuperscript = new CheckBox();
        this.checkBoxSubscript = new CheckBox();
        this.label4 = new Label();
        this.checkBoxShadow = new CheckBox();
        SuspendLayout();
        // 
        // checkBoxBold
        // 
        this.checkBoxBold.AutoSize = true;
        this.checkBoxBold.Location = new Point(22, 179);
        this.checkBoxBold.Name = "checkBoxBold";
        this.checkBoxBold.Size = new Size(62, 24);
        this.checkBoxBold.TabIndex = 0;
        this.checkBoxBold.Text = "Bold";
        this.checkBoxBold.UseVisualStyleBackColor = true;
        // 
        // checkBoxSmallCaps
        // 
        this.checkBoxSmallCaps.AutoSize = true;
        this.checkBoxSmallCaps.Location = new Point(22, 239);
        this.checkBoxSmallCaps.Name = "checkBoxSmallCaps";
        this.checkBoxSmallCaps.Size = new Size(102, 24);
        this.checkBoxSmallCaps.TabIndex = 1;
        this.checkBoxSmallCaps.Text = "Small caps";
        this.checkBoxSmallCaps.UseVisualStyleBackColor = true;
        this.checkBoxSmallCaps.CheckedChanged += checkBoxSmallCaps_CheckedChanged;
        // 
        // comboBoxUnderlineType
        // 
        this.comboBoxUnderlineType.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBoxUnderlineType.FormattingEnabled = true;
        this.comboBoxUnderlineType.Location = new Point(164, 14);
        this.comboBoxUnderlineType.Name = "comboBoxUnderlineType";
        this.comboBoxUnderlineType.Size = new Size(189, 28);
        this.comboBoxUnderlineType.TabIndex = 2;
        // 
        // comboBoxUnderlineColor
        // 
        this.comboBoxUnderlineColor.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBoxUnderlineColor.FormattingEnabled = true;
        this.comboBoxUnderlineColor.Location = new Point(164, 51);
        this.comboBoxUnderlineColor.Name = "comboBoxUnderlineColor";
        this.comboBoxUnderlineColor.Size = new Size(189, 28);
        this.comboBoxUnderlineColor.TabIndex = 3;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(19, 17);
        this.label1.Name = "label1";
        this.label1.Size = new Size(109, 20);
        this.label1.TabIndex = 4;
        this.label1.Text = "Underline type:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(19, 54);
        this.label2.Name = "label2";
        this.label2.Size = new Size(114, 20);
        this.label2.TabIndex = 5;
        this.label2.Text = "Underline color:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(19, 91);
        this.label3.Name = "label3";
        this.label3.Size = new Size(89, 20);
        this.label3.TabIndex = 7;
        this.label3.Text = "Font stretch:";
        // 
        // comboBoxFontStretch
        // 
        this.comboBoxFontStretch.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBoxFontStretch.FormattingEnabled = true;
        this.comboBoxFontStretch.Location = new Point(164, 88);
        this.comboBoxFontStretch.Name = "comboBoxFontStretch";
        this.comboBoxFontStretch.Size = new Size(189, 28);
        this.comboBoxFontStretch.TabIndex = 6;
        // 
        // okButton
        // 
        this.okButton.Location = new Point(159, 333);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 8;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.Location = new Point(259, 333);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 9;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += cancelButton_Click;
        // 
        // checkBoxAllCaps
        // 
        this.checkBoxAllCaps.AutoSize = true;
        this.checkBoxAllCaps.Location = new Point(22, 269);
        this.checkBoxAllCaps.Name = "checkBoxAllCaps";
        this.checkBoxAllCaps.Size = new Size(83, 24);
        this.checkBoxAllCaps.TabIndex = 11;
        this.checkBoxAllCaps.Text = "All caps";
        this.checkBoxAllCaps.UseVisualStyleBackColor = true;
        this.checkBoxAllCaps.CheckedChanged += checkBoxAllCaps_CheckedChanged;
        // 
        // checkBoxItalic
        // 
        this.checkBoxItalic.AutoSize = true;
        this.checkBoxItalic.Location = new Point(248, 179);
        this.checkBoxItalic.Name = "checkBoxItalic";
        this.checkBoxItalic.Size = new Size(63, 24);
        this.checkBoxItalic.TabIndex = 10;
        this.checkBoxItalic.Text = "Italic";
        this.checkBoxItalic.UseVisualStyleBackColor = true;
        // 
        // checkBoxStrikethrough
        // 
        this.checkBoxStrikethrough.AutoSize = true;
        this.checkBoxStrikethrough.Location = new Point(22, 209);
        this.checkBoxStrikethrough.Name = "checkBoxStrikethrough";
        this.checkBoxStrikethrough.Size = new Size(120, 24);
        this.checkBoxStrikethrough.TabIndex = 12;
        this.checkBoxStrikethrough.Text = "Strikethrough";
        this.checkBoxStrikethrough.UseVisualStyleBackColor = true;
        // 
        // checkBoxSuperscript
        // 
        this.checkBoxSuperscript.AutoSize = true;
        this.checkBoxSuperscript.Location = new Point(248, 209);
        this.checkBoxSuperscript.Name = "checkBoxSuperscript";
        this.checkBoxSuperscript.Size = new Size(105, 24);
        this.checkBoxSuperscript.TabIndex = 13;
        this.checkBoxSuperscript.Text = "Superscript";
        this.checkBoxSuperscript.UseVisualStyleBackColor = true;
        this.checkBoxSuperscript.CheckedChanged += checkBoxSuperscript_CheckedChanged;
        // 
        // checkBoxSubscript
        // 
        this.checkBoxSubscript.AutoSize = true;
        this.checkBoxSubscript.Location = new Point(248, 239);
        this.checkBoxSubscript.Name = "checkBoxSubscript";
        this.checkBoxSubscript.Size = new Size(92, 24);
        this.checkBoxSubscript.TabIndex = 14;
        this.checkBoxSubscript.Text = "Subscript";
        this.checkBoxSubscript.UseVisualStyleBackColor = true;
        this.checkBoxSubscript.CheckedChanged += checkBoxSubscript_CheckedChanged;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
        this.label4.Location = new Point(19, 141);
        this.label4.Name = "label4";
        this.label4.Size = new Size(56, 20);
        this.label4.TabIndex = 15;
        this.label4.Text = "Effects:";
        // 
        // checkBoxShadow
        // 
        this.checkBoxShadow.AutoSize = true;
        this.checkBoxShadow.Location = new Point(248, 269);
        this.checkBoxShadow.Name = "checkBoxShadow";
        this.checkBoxShadow.Size = new Size(84, 24);
        this.checkBoxShadow.TabIndex = 17;
        this.checkBoxShadow.Text = "Shadow";
        this.checkBoxShadow.UseVisualStyleBackColor = true;
        // 
        // FontFormatDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(374, 375);
        Controls.Add(this.checkBoxShadow);
        Controls.Add(this.label4);
        Controls.Add(this.checkBoxSubscript);
        Controls.Add(this.checkBoxSuperscript);
        Controls.Add(this.checkBoxStrikethrough);
        Controls.Add(this.checkBoxAllCaps);
        Controls.Add(this.checkBoxItalic);
        Controls.Add(this.cancelButton);
        Controls.Add(this.okButton);
        Controls.Add(this.label3);
        Controls.Add(this.comboBoxFontStretch);
        Controls.Add(this.label2);
        Controls.Add(this.label1);
        Controls.Add(this.comboBoxUnderlineColor);
        Controls.Add(this.comboBoxUnderlineType);
        Controls.Add(this.checkBoxSmallCaps);
        Controls.Add(this.checkBoxBold);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FontFormatDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Font Properties";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Label label2;
    private Label label3;
    private Button okButton;
    private Button cancelButton;
    private Label label4;
    public CheckBox checkBoxBold;
    public CheckBox checkBoxSmallCaps;
    public ComboBox comboBoxUnderlineType;
    public ComboBox comboBoxUnderlineColor;
    public ComboBox comboBoxFontStretch;
    public CheckBox checkBoxAllCaps;
    public CheckBox checkBoxItalic;
    public CheckBox checkBoxStrikethrough;
    public CheckBox checkBoxSuperscript;
    public CheckBox checkBoxSubscript;
    public CheckBox checkBoxShadow;
}