namespace WinFormsSampleApp;

partial class InsertDateDialog
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
        this.listBox1 = new ListBox();
        SuspendLayout();
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(276, 379);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(94, 29);
        this.cancelButton.TabIndex = 15;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += cancelButton_Click;
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.Location = new Point(176, 379);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 14;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += okButton_Click;
        // 
        // listBox1
        // 
        this.listBox1.FormattingEnabled = true;
        this.listBox1.HorizontalScrollbar = true;
        this.listBox1.Location = new Point(12, 12);
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new Size(358, 344);
        this.listBox1.TabIndex = 16;
        this.listBox1.DoubleClick += listBox1_DoubleClick;
        // 
        // InsertDateDialog
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(382, 420);
        Controls.Add(this.listBox1);
        Controls.Add(this.cancelButton);
        Controls.Add(this.okButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InsertDateDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Insert date / time";
        ResumeLayout(false);
    }

    #endregion

    private Button cancelButton;
    private Button okButton;
    private ListBox listBox1;
}