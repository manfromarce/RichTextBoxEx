namespace WinFormsSampleApp;

partial class InsertTableDialog
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
        this.rowsUpDown = new NumericUpDown();
        this.columnsUpDown = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)this.rowsUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.columnsUpDown).BeginInit();
        SuspendLayout();
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(249, 145);
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
        this.okButton.Location = new Point(149, 145);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(94, 29);
        this.okButton.TabIndex = 14;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += okButton_Click;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(18, 32);
        this.label1.Name = "label1";
        this.label1.Size = new Size(47, 20);
        this.label1.TabIndex = 16;
        this.label1.Text = "Rows:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(18, 74);
        this.label2.Name = "label2";
        this.label2.Size = new Size(69, 20);
        this.label2.TabIndex = 17;
        this.label2.Text = "Columns:";
        // 
        // rowsUpDown
        // 
        this.rowsUpDown.Location = new Point(149, 30);
        this.rowsUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        this.rowsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.rowsUpDown.Name = "rowsUpDown";
        this.rowsUpDown.Size = new Size(189, 27);
        this.rowsUpDown.TabIndex = 18;
        this.rowsUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // columnsUpDown
        // 
        this.columnsUpDown.Location = new Point(149, 72);
        this.columnsUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        this.columnsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.columnsUpDown.Name = "columnsUpDown";
        this.columnsUpDown.Size = new Size(189, 27);
        this.columnsUpDown.TabIndex = 19;
        this.columnsUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // InsertTableDialog
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = this.cancelButton;
        ClientSize = new Size(355, 186);
        Controls.Add(this.columnsUpDown);
        Controls.Add(this.rowsUpDown);
        Controls.Add(this.label2);
        Controls.Add(this.label1);
        Controls.Add(this.cancelButton);
        Controls.Add(this.okButton);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "InsertTableDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Insert table";
        ((System.ComponentModel.ISupportInitialize)this.rowsUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.columnsUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button cancelButton;
    private Button okButton;
    private Label label1;
    private Label label2;
    public NumericUpDown rowsUpDown;
    public NumericUpDown columnsUpDown;
}