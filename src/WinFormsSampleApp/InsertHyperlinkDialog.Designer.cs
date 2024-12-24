namespace WinFormsSampleApp;

partial class InsertHyperlinkDialog
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
        this.cancelButton = new Button();
        this.okButton = new Button();
        this.label1 = new Label();
        this.label2 = new Label();
        this.displayTextBox = new TextBox();
        this.urlTextBox = new TextBox();
        SuspendLayout();
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(447, 130);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 13;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += cancelButton_Click;
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.Location = new Point(347, 130);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 12;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += okButton_Click;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 29);
        this.label1.Name = "label1";
        this.label1.Size = new Size(90, 20);
        this.label1.TabIndex = 14;
        this.label1.Text = "Display text:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(12, 80);
        this.label2.Name = "label2";
        this.label2.Size = new Size(38, 20);
        this.label2.TabIndex = 15;
        this.label2.Text = "URL:";
        // 
        // displayTextBox
        // 
        this.displayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.displayTextBox.Location = new Point(144, 26);
        this.displayTextBox.Name = "displayTextBox";
        this.displayTextBox.Size = new Size(397, 27);
        this.displayTextBox.TabIndex = 16;
        this.displayTextBox.TextChanged += displayTextBox_TextChanged;
        // 
        // urlTextBox
        // 
        this.urlTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.urlTextBox.Location = new Point(144, 77);
        this.urlTextBox.Name = "urlTextBox";
        this.urlTextBox.Size = new Size(397, 27);
        this.urlTextBox.TabIndex = 17;
        this.urlTextBox.TextChanged += urlTextBox_TextChanged;
        // 
        // InsertHyperlinkDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(553, 171);
        Controls.Add(this.urlTextBox);
        Controls.Add(this.displayTextBox);
        Controls.Add(this.label2);
        Controls.Add(this.label1);
        Controls.Add(this.cancelButton);
        Controls.Add(this.okButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InsertHyperlinkDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Insert / Edit Hyperlink";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button cancelButton;
    private Button okButton;
    private Label label1;
    private Label label2;
    private TextBox displayTextBox;
    private TextBox urlTextBox;
}