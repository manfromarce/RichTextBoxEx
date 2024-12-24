namespace WinFormsSampleApp;

partial class AboutBox1
{
    /// <summary>
    /// Variabile di progettazione necessaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Pulire le risorse in uso.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Codice generato da Progettazione Windows Form

    /// <summary>
    /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
    /// il contenuto del metodo con l'editor di codice.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
        this.tableLayoutPanel = new TableLayoutPanel();
        this.logoPictureBox = new PictureBox();
        this.labelProductName = new Label();
        this.labelVersion = new Label();
        this.labelCopyright = new Label();
        this.labelCompanyName = new Label();
        this.textBoxDescription = new TextBox();
        this.okButton = new Button();
        this.linkLabel1 = new LinkLabel();
        this.tableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.logoPictureBox).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        this.tableLayoutPanel.ColumnCount = 2;
        this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
        this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
        this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
        this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
        this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
        this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
        this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
        this.tableLayoutPanel.Controls.Add(this.okButton, 1, 6);
        this.tableLayoutPanel.Controls.Add(this.linkLabel1, 1, 5);
        this.tableLayoutPanel.Dock = DockStyle.Fill;
        this.tableLayoutPanel.Location = new Point(12, 14);
        this.tableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
        this.tableLayoutPanel.Name = "tableLayoutPanel";
        this.tableLayoutPanel.RowCount = 7;
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle());
        this.tableLayoutPanel.Size = new Size(556, 407);
        this.tableLayoutPanel.TabIndex = 0;
        // 
        // logoPictureBox
        // 
        this.logoPictureBox.Dock = DockStyle.Fill;
        this.logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
        this.logoPictureBox.Location = new Point(4, 5);
        this.logoPictureBox.Margin = new Padding(4, 5, 4, 5);
        this.logoPictureBox.Name = "logoPictureBox";
        this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
        this.logoPictureBox.Size = new Size(175, 397);
        this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        this.logoPictureBox.TabIndex = 12;
        this.logoPictureBox.TabStop = false;
        // 
        // labelProductName
        // 
        this.labelProductName.Dock = DockStyle.Fill;
        this.labelProductName.Location = new Point(191, 0);
        this.labelProductName.Margin = new Padding(8, 0, 4, 0);
        this.labelProductName.MaximumSize = new Size(0, 26);
        this.labelProductName.Name = "labelProductName";
        this.labelProductName.Size = new Size(361, 26);
        this.labelProductName.TabIndex = 19;
        this.labelProductName.Text = "Product name";
        this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelVersion
        // 
        this.labelVersion.Dock = DockStyle.Fill;
        this.labelVersion.Location = new Point(191, 36);
        this.labelVersion.Margin = new Padding(8, 0, 4, 0);
        this.labelVersion.MaximumSize = new Size(0, 26);
        this.labelVersion.Name = "labelVersion";
        this.labelVersion.Size = new Size(361, 26);
        this.labelVersion.TabIndex = 0;
        this.labelVersion.Text = "Version";
        this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelCopyright
        // 
        this.labelCopyright.Dock = DockStyle.Fill;
        this.labelCopyright.Location = new Point(191, 72);
        this.labelCopyright.Margin = new Padding(8, 0, 4, 0);
        this.labelCopyright.MaximumSize = new Size(0, 26);
        this.labelCopyright.Name = "labelCopyright";
        this.labelCopyright.Size = new Size(361, 26);
        this.labelCopyright.TabIndex = 21;
        this.labelCopyright.Text = "Copyright";
        this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelCompanyName
        // 
        this.labelCompanyName.Dock = DockStyle.Fill;
        this.labelCompanyName.Location = new Point(191, 108);
        this.labelCompanyName.Margin = new Padding(8, 0, 4, 0);
        this.labelCompanyName.MaximumSize = new Size(0, 26);
        this.labelCompanyName.Name = "labelCompanyName";
        this.labelCompanyName.Size = new Size(361, 26);
        this.labelCompanyName.TabIndex = 22;
        this.labelCompanyName.Text = "Company name";
        this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxDescription
        // 
        this.textBoxDescription.Dock = DockStyle.Fill;
        this.textBoxDescription.Location = new Point(191, 149);
        this.textBoxDescription.Margin = new Padding(8, 5, 4, 5);
        this.textBoxDescription.Multiline = true;
        this.textBoxDescription.Name = "textBoxDescription";
        this.textBoxDescription.ReadOnly = true;
        this.textBoxDescription.ScrollBars = ScrollBars.Both;
        this.textBoxDescription.Size = new Size(361, 171);
        this.textBoxDescription.TabIndex = 23;
        this.textBoxDescription.TabStop = false;
        this.textBoxDescription.Text = "Description";
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.DialogResult = DialogResult.Cancel;
        this.okButton.Location = new Point(452, 368);
        this.okButton.Margin = new Padding(4, 5, 4, 5);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(100, 34);
        this.okButton.TabIndex = 24;
        this.okButton.Text = "&OK";
        // 
        // linkLabel1
        // 
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.Location = new Point(186, 325);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new Size(226, 20);
        this.linkLabel1.TabIndex = 25;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "RichTextBoxEx GitHub repository";
        this.linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // AboutBox1
        // 
        AcceptButton = this.okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(580, 435);
        Controls.Add(this.tableLayoutPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 5, 4, 5);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutBox1";
        Padding = new Padding(12, 14, 12, 14);
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "AboutBox1";
        this.tableLayoutPanel.ResumeLayout(false);
        this.tableLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.logoPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelCompanyName;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
    private LinkLabel linkLabel1;
}
