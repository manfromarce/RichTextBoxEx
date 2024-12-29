namespace WinFormsSampleApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        var singleLineSpacing1 = new RichTextBoxEx.SingleLineSpacing();
        var singleLineSpacing2 = new RichTextBoxEx.SingleLineSpacing();
        this.toolStrip1 = new ToolStrip();
        this.fontComboBox = new ToolStripComboBox();
        this.fontSizeComboBox = new ToolStripComboBox();
        this.boldButton = new ToolStripButton();
        this.italicButton = new ToolStripButton();
        this.underlineButton = new ToolStripButton();
        this.strikethroughButton = new ToolStripButton();
        this.superScriptButton = new ToolStripButton();
        this.subscriptButton = new ToolStripButton();
        this.fontColorPicker = new UserControls.ToolStripColorPicker();
        this.textHighlightColorPicker = new UserControls.ToolStripColorPicker();
        this.fontOptionsButton = new ToolStripButton();
        this.toolStripSeparator1 = new ToolStripSeparator();
        this.alignLeftButton = new ToolStripButton();
        this.alignCenterButton = new ToolStripButton();
        this.alignRightButton = new ToolStripButton();
        this.alignJustifiedButton = new ToolStripButton();
        this.bulletedListButton = new ToolStripButton();
        this.numberedListButton = new ToolStripButton();
        this.outdentButton = new ToolStripButton();
        this.indentButton = new ToolStripButton();
        this.paragraphOptionsButton = new ToolStripButton();
        this.toolStripSeparator2 = new ToolStripSeparator();
        this.imageButton = new ToolStripButton();
        this.tableButton = new ToolStripButton();
        this.hyperlinkButton = new ToolStripButton();
        this.dateTimeButton = new ToolStripButton();
        this.richTextBoxEx1 = new RichTextBoxEx.RichTextBoxEx();
        this.printDocument1 = new System.Drawing.Printing.PrintDocument();
        this.pageSetupDialog1 = new PageSetupDialog();
        this.printDialog1 = new PrintDialog();
        this.printPreviewDialog1 = new PrintPreviewDialog();
        this.openFileDialog1 = new OpenFileDialog();
        this.saveFileDialog1 = new SaveFileDialog();
        this.menuStrip1 = new MenuStrip();
        this.fileToolStripMenuItem = new ToolStripMenuItem();
        this.newToolStripMenuItem = new ToolStripMenuItem();
        this.openToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripSeparator = new ToolStripSeparator();
        this.saveToolStripMenuItem = new ToolStripMenuItem();
        this.saveAsToolStripMenuItem = new ToolStripMenuItem();
        this.saveAsCopyToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripSeparator3 = new ToolStripSeparator();
        this.printToolStripMenuItem = new ToolStripMenuItem();
        this.printPreviewToolStripMenuItem = new ToolStripMenuItem();
        this.pageSetupToolStripMenuItem1 = new ToolStripMenuItem();
        this.toolStripSeparator4 = new ToolStripSeparator();
        this.exitToolStripMenuItem = new ToolStripMenuItem();
        this.editToolStripMenuItem = new ToolStripMenuItem();
        this.undoToolStripMenuItem = new ToolStripMenuItem();
        this.redoToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripSeparator5 = new ToolStripSeparator();
        this.cutToolStripMenuItem = new ToolStripMenuItem();
        this.copyToolStripMenuItem = new ToolStripMenuItem();
        this.pasteToolStripMenuItem = new ToolStripMenuItem();
        this.pasteAsPlainTextToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripSeparator6 = new ToolStripSeparator();
        this.selectAllToolStripMenuItem = new ToolStripMenuItem();
        this.findReplaceToolStripMenuItem = new ToolStripMenuItem();
        this.viewToolStripMenuItem = new ToolStripMenuItem();
        this.zoomToolStripMenuItem = new ToolStripMenuItem();
        this.zoomInToolStripMenuItem = new ToolStripMenuItem();
        this.zoomOutToolStripMenuItem = new ToolStripMenuItem();
        this.restore100ToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripSeparator7 = new ToolStripSeparator();
        this.wordWrapToolStripMenuItem = new ToolStripMenuItem();
        this.optionsToolStripMenuItem = new ToolStripMenuItem();
        this.enableSpellCheckToolStripMenuItem = new ToolStripMenuItem();
        this.autoWordSelectionToolStripMenuItem = new ToolStripMenuItem();
        this.enableDragAndDropContentToolStripMenuItem = new ToolStripMenuItem();
        this.enableKeyboardShortcutsToolStripMenuItem = new ToolStripMenuItem();
        this.useCtrlClickForOpeningHyperlinksToolStripMenuItem = new ToolStripMenuItem();
        this.toolStripMenuItem1 = new ToolStripMenuItem();
        this.aboutToolStripMenuItem = new ToolStripMenuItem();
        this.imageOpenFileDialog = new OpenFileDialog();
        this.toolStrip1.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // toolStrip1
        // 
        this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        this.toolStrip1.ImageScalingSize = new Size(20, 20);
        this.toolStrip1.Items.AddRange(new ToolStripItem[] { this.fontComboBox, this.fontSizeComboBox, this.boldButton, this.italicButton, this.underlineButton, this.strikethroughButton, this.superScriptButton, this.subscriptButton, this.fontColorPicker, this.textHighlightColorPicker, this.fontOptionsButton, this.toolStripSeparator1, this.alignLeftButton, this.alignCenterButton, this.alignRightButton, this.alignJustifiedButton, this.bulletedListButton, this.numberedListButton, this.outdentButton, this.indentButton, this.paragraphOptionsButton, this.toolStripSeparator2, this.imageButton, this.tableButton, this.hyperlinkButton, this.dateTimeButton });
        this.toolStrip1.Location = new Point(0, 28);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new Size(1149, 28);
        this.toolStrip1.TabIndex = 0;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // fontComboBox
        // 
        this.fontComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.fontComboBox.Name = "fontComboBox";
        this.fontComboBox.Size = new Size(170, 28);
        this.fontComboBox.ToolTipText = "Font name";
        this.fontComboBox.DropDownClosed += fontComboBox_DropDownClosed;
        this.fontComboBox.SelectedIndexChanged += fontComboBox_SelectedIndexChanged;
        // 
        // fontSizeComboBox
        // 
        this.fontSizeComboBox.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
        this.fontSizeComboBox.MaxDropDownItems = 16;
        this.fontSizeComboBox.Name = "fontSizeComboBox";
        this.fontSizeComboBox.Size = new Size(75, 28);
        this.fontSizeComboBox.ToolTipText = "Font size";
        this.fontSizeComboBox.DropDownClosed += fontSizeComboBox_DropDownClosed;
        this.fontSizeComboBox.TextChanged += fontSizeComboBox_TextChanged;
        // 
        // boldButton
        // 
        this.boldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.boldButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        this.boldButton.Image = (Image)resources.GetObject("boldButton.Image");
        this.boldButton.ImageTransparentColor = Color.Magenta;
        this.boldButton.Name = "boldButton";
        this.boldButton.Size = new Size(29, 25);
        this.boldButton.Text = "B";
        this.boldButton.ToolTipText = "Bold";
        this.boldButton.Click += boldButton_Click;
        // 
        // italicButton
        // 
        this.italicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.italicButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        this.italicButton.Image = (Image)resources.GetObject("italicButton.Image");
        this.italicButton.ImageTransparentColor = Color.Magenta;
        this.italicButton.Name = "italicButton";
        this.italicButton.Size = new Size(29, 25);
        this.italicButton.Text = "I";
        this.italicButton.ToolTipText = "Italic";
        this.italicButton.Click += italicButton_Click;
        // 
        // underlineButton
        // 
        this.underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.underlineButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
        this.underlineButton.Image = (Image)resources.GetObject("underlineButton.Image");
        this.underlineButton.ImageTransparentColor = Color.Magenta;
        this.underlineButton.Name = "underlineButton";
        this.underlineButton.Size = new Size(29, 25);
        this.underlineButton.Text = "U";
        this.underlineButton.ToolTipText = "Underline";
        this.underlineButton.Click += underlineButton_Click;
        // 
        // strikethroughButton
        // 
        this.strikethroughButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.strikethroughButton.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout);
        this.strikethroughButton.Image = (Image)resources.GetObject("strikethroughButton.Image");
        this.strikethroughButton.ImageTransparentColor = Color.Magenta;
        this.strikethroughButton.Name = "strikethroughButton";
        this.strikethroughButton.Size = new Size(29, 25);
        this.strikethroughButton.Text = "S";
        this.strikethroughButton.ToolTipText = "Strikethrough";
        this.strikethroughButton.Click += strikethroughButton_Click;
        // 
        // superScriptButton
        // 
        this.superScriptButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.superScriptButton.Image = (Image)resources.GetObject("superScriptButton.Image");
        this.superScriptButton.ImageTransparentColor = Color.Magenta;
        this.superScriptButton.Name = "superScriptButton";
        this.superScriptButton.Size = new Size(29, 25);
        this.superScriptButton.Text = "²";
        this.superScriptButton.ToolTipText = "Superscript";
        this.superScriptButton.Click += superScriptButton_Click;
        // 
        // subscriptButton
        // 
        this.subscriptButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.subscriptButton.Image = (Image)resources.GetObject("subscriptButton.Image");
        this.subscriptButton.ImageTransparentColor = Color.Magenta;
        this.subscriptButton.Name = "subscriptButton";
        this.subscriptButton.Size = new Size(29, 25);
        this.subscriptButton.Text = "₂";
        this.subscriptButton.ToolTipText = "Subscript";
        this.subscriptButton.Click += subscriptButton_Click;
        // 
        // fontColorPicker
        // 
        this.fontColorPicker.AutoSize = false;
        this.fontColorPicker.ButtonDisplayStyle = UserControls.ToolStripColorPickerDisplayType.UnderLineAndText;
        this.fontColorPicker.Color = Color.Black;
        this.fontColorPicker.DisplayStyle = ToolStripItemDisplayStyle.None;
        this.fontColorPicker.Font = new Font("Segoe UI", 8F);
        this.fontColorPicker.Image = (Image)resources.GetObject("fontColorPicker.Image");
        this.fontColorPicker.ImageTransparentColor = Color.Magenta;
        this.fontColorPicker.IsHighlightColorPicker = false;
        this.fontColorPicker.Name = "fontColorPicker";
        this.fontColorPicker.Size = new Size(30, 23);
        this.fontColorPicker.Text = "A";
        this.fontColorPicker.TextAlign = ContentAlignment.TopCenter;
        this.fontColorPicker.ToolTipText = "Font color";
        this.fontColorPicker.SelectedColorChanged += fontColorPicker_SelectedColorChanged;
        this.fontColorPicker.ButtonPortionClicked += fontColorPicker_SelectedColorChanged;
        // 
        // textHighlightColorPicker
        // 
        this.textHighlightColorPicker.AutoSize = false;
        this.textHighlightColorPicker.ButtonDisplayStyle = UserControls.ToolStripColorPickerDisplayType.UnderLineAndImage;
        this.textHighlightColorPicker.Color = Color.Transparent;
        this.textHighlightColorPicker.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.textHighlightColorPicker.Image = Properties.Resources.hghlight;
        this.textHighlightColorPicker.ImageScaling = ToolStripItemImageScaling.None;
        this.textHighlightColorPicker.ImageTransparentColor = Color.Magenta;
        this.textHighlightColorPicker.IsHighlightColorPicker = true;
        this.textHighlightColorPicker.Name = "textHighlightColorPicker";
        this.textHighlightColorPicker.Size = new Size(30, 23);
        this.textHighlightColorPicker.Text = "Text highlight color";
        this.textHighlightColorPicker.ToolTipText = "Text highlight color";
        this.textHighlightColorPicker.SelectedColorChanged += highlightColorPicker_SelectedColorChanged;
        this.textHighlightColorPicker.ButtonPortionClicked += highlightColorPicker_SelectedColorChanged;
        // 
        // fontOptionsButton
        // 
        this.fontOptionsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.fontOptionsButton.Image = (Image)resources.GetObject("fontOptionsButton.Image");
        this.fontOptionsButton.ImageTransparentColor = Color.Magenta;
        this.fontOptionsButton.Name = "fontOptionsButton";
        this.fontOptionsButton.Size = new Size(51, 25);
        this.fontOptionsButton.Text = "Font...";
        this.fontOptionsButton.ToolTipText = "Additional font options";
        this.fontOptionsButton.Click += fontOptionsButton_Click;
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new Size(6, 28);
        // 
        // alignLeftButton
        // 
        this.alignLeftButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.alignLeftButton.Image = Properties.Resources.align_left;
        this.alignLeftButton.ImageTransparentColor = Color.Magenta;
        this.alignLeftButton.Name = "alignLeftButton";
        this.alignLeftButton.Size = new Size(29, 25);
        this.alignLeftButton.Text = "Align left";
        this.alignLeftButton.Click += alignLeftButton_Click;
        // 
        // alignCenterButton
        // 
        this.alignCenterButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.alignCenterButton.Image = Properties.Resources.align_center;
        this.alignCenterButton.ImageTransparentColor = Color.Magenta;
        this.alignCenterButton.Name = "alignCenterButton";
        this.alignCenterButton.Size = new Size(29, 25);
        this.alignCenterButton.Text = "Align center";
        this.alignCenterButton.Click += alignCenterButton_Click;
        // 
        // alignRightButton
        // 
        this.alignRightButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.alignRightButton.Image = Properties.Resources.align_left;
        this.alignRightButton.ImageTransparentColor = Color.Magenta;
        this.alignRightButton.Name = "alignRightButton";
        this.alignRightButton.Size = new Size(29, 25);
        this.alignRightButton.Text = "Align right";
        this.alignRightButton.Click += alignRightButton_Click;
        // 
        // alignJustifiedButton
        // 
        this.alignJustifiedButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.alignJustifiedButton.Image = Properties.Resources.align_justify;
        this.alignJustifiedButton.ImageTransparentColor = Color.Magenta;
        this.alignJustifiedButton.Name = "alignJustifiedButton";
        this.alignJustifiedButton.Size = new Size(29, 25);
        this.alignJustifiedButton.Text = "Justify";
        this.alignJustifiedButton.Click += alignJustifiedButton_Click;
        // 
        // bulletedListButton
        // 
        this.bulletedListButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.bulletedListButton.Image = Properties.Resources.bulleted_list;
        this.bulletedListButton.ImageTransparentColor = Color.Magenta;
        this.bulletedListButton.Name = "bulletedListButton";
        this.bulletedListButton.Size = new Size(29, 25);
        this.bulletedListButton.Text = "Bulleted list";
        this.bulletedListButton.Click += bulletedListButton_Click;
        // 
        // numberedListButton
        // 
        this.numberedListButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.numberedListButton.Image = Properties.Resources.numbered_list;
        this.numberedListButton.ImageTransparentColor = Color.Magenta;
        this.numberedListButton.Name = "numberedListButton";
        this.numberedListButton.Size = new Size(29, 25);
        this.numberedListButton.Text = "Numbered list";
        this.numberedListButton.Click += numberedListButton_Click;
        // 
        // outdentButton
        // 
        this.outdentButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.outdentButton.Image = Properties.Resources.indent;
        this.outdentButton.ImageTransparentColor = Color.Magenta;
        this.outdentButton.Name = "outdentButton";
        this.outdentButton.Size = new Size(29, 25);
        this.outdentButton.Text = "Decrease indent";
        this.outdentButton.Click += outdentButton_Click;
        // 
        // indentButton
        // 
        this.indentButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.indentButton.Image = Properties.Resources.outdent;
        this.indentButton.ImageTransparentColor = Color.Magenta;
        this.indentButton.Name = "indentButton";
        this.indentButton.Size = new Size(29, 25);
        this.indentButton.Text = "Increase indent";
        this.indentButton.Click += indentButton_Click;
        // 
        // paragraphOptionsButton
        // 
        this.paragraphOptionsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
        this.paragraphOptionsButton.Image = (Image)resources.GetObject("paragraphOptionsButton.Image");
        this.paragraphOptionsButton.ImageTransparentColor = Color.Magenta;
        this.paragraphOptionsButton.Name = "paragraphOptionsButton";
        this.paragraphOptionsButton.Size = new Size(89, 25);
        this.paragraphOptionsButton.Text = "Paragraph...";
        this.paragraphOptionsButton.ToolTipText = "Additional paragraph and list options";
        this.paragraphOptionsButton.Click += ParagraphOptionsButton_Click;
        // 
        // toolStripSeparator2
        // 
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new Size(6, 28);
        // 
        // imageButton
        // 
        this.imageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.imageButton.Image = (Image)resources.GetObject("imageButton.Image");
        this.imageButton.ImageTransparentColor = Color.Magenta;
        this.imageButton.Name = "imageButton";
        this.imageButton.Size = new Size(29, 25);
        this.imageButton.Text = "Insert image";
        this.imageButton.ToolTipText = "Insert image from file";
        this.imageButton.Click += imageButton_Click;
        // 
        // tableButton
        // 
        this.tableButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.tableButton.Image = Properties.Resources.table;
        this.tableButton.ImageTransparentColor = Color.Magenta;
        this.tableButton.Name = "tableButton";
        this.tableButton.Size = new Size(29, 25);
        this.tableButton.Text = "Insert table";
        this.tableButton.Click += tableButton_Click;
        // 
        // hyperlinkButton
        // 
        this.hyperlinkButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.hyperlinkButton.Image = Properties.Resources.link;
        this.hyperlinkButton.ImageTransparentColor = Color.Magenta;
        this.hyperlinkButton.Name = "hyperlinkButton";
        this.hyperlinkButton.Size = new Size(29, 25);
        this.hyperlinkButton.Text = "Insert hyperlink";
        this.hyperlinkButton.ToolTipText = "Insert, edit or remove hyperlink";
        this.hyperlinkButton.Click += hyperlinkButton_Click;
        // 
        // dateTimeButton
        // 
        this.dateTimeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.dateTimeButton.Image = Properties.Resources.calendar;
        this.dateTimeButton.ImageTransparentColor = Color.Magenta;
        this.dateTimeButton.Name = "dateTimeButton";
        this.dateTimeButton.Size = new Size(29, 25);
        this.dateTimeButton.Text = "Insert date and time";
        this.dateTimeButton.Click += dateTimeButton_Click;
        // 
        // richTextBoxEx1
        // 
        this.richTextBoxEx1.AcceptsTab = true;
        this.richTextBoxEx1.DetectUrls = false;
        this.richTextBoxEx1.Dock = DockStyle.Fill;
        this.richTextBoxEx1.EnableAutoDragDrop = true;
        this.richTextBoxEx1.HideSelection = false;
        this.richTextBoxEx1.IsSpellCheckEnabled = false;
        this.richTextBoxEx1.Location = new Point(0, 56);
        this.richTextBoxEx1.Name = "richTextBoxEx1";
        this.richTextBoxEx1.PrintDocument = this.printDocument1;
        this.richTextBoxEx1.RequireCtrlForLinkClick = false;
        this.richTextBoxEx1.ShowSelectionMargin = true;
        this.richTextBoxEx1.Size = new Size(1149, 394);
        this.richTextBoxEx1.TabIndex = 1;
        this.richTextBoxEx1.Text = "";
        this.richTextBoxEx1.LinkClicked += richTextBoxEx1_LinkClicked;
        this.richTextBoxEx1.SelectionChanged += richTextBoxEx1_SelectionChanged;
        // 
        // pageSetupDialog1
        // 
        this.pageSetupDialog1.Document = this.printDocument1;
        // 
        // printDialog1
        // 
        this.printDialog1.Document = this.printDocument1;
        this.printDialog1.UseEXDialog = true;
        // 
        // printPreviewDialog1
        // 
        this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
        this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
        this.printPreviewDialog1.ClientSize = new Size(400, 300);
        this.printPreviewDialog1.Document = this.printDocument1;
        this.printPreviewDialog1.Enabled = true;
        this.printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
        this.printPreviewDialog1.Name = "printPreviewDialog1";
        this.printPreviewDialog1.Visible = false;
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.DefaultExt = "rtf";
        this.openFileDialog1.Filter = "Rich Text Format|*.rtf|Plain text|*.txt";
        // 
        // saveFileDialog1
        // 
        this.saveFileDialog1.DefaultExt = "rtf";
        this.saveFileDialog1.Filter = "Rich Text Format|*.rtf|Plain text|*.txt";
        // 
        // menuStrip1
        // 
        this.menuStrip1.ImageScalingSize = new Size(20, 20);
        this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.editToolStripMenuItem, this.viewToolStripMenuItem, this.optionsToolStripMenuItem, this.toolStripMenuItem1 });
        this.menuStrip1.Location = new Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new Size(1149, 28);
        this.menuStrip1.TabIndex = 2;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.newToolStripMenuItem, this.openToolStripMenuItem, this.toolStripSeparator, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.saveAsCopyToolStripMenuItem, this.toolStripSeparator3, this.printToolStripMenuItem, this.printPreviewToolStripMenuItem, this.pageSetupToolStripMenuItem1, this.toolStripSeparator4, this.exitToolStripMenuItem });
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new Size(46, 24);
        this.fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        this.newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
        this.newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        this.newToolStripMenuItem.Size = new Size(257, 26);
        this.newToolStripMenuItem.Text = "&New";
        this.newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        this.openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
        this.openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        this.openToolStripMenuItem.Size = new Size(257, 26);
        this.openToolStripMenuItem.Text = "&Open";
        this.openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // toolStripSeparator
        // 
        this.toolStripSeparator.Name = "toolStripSeparator";
        this.toolStripSeparator.Size = new Size(254, 6);
        // 
        // saveToolStripMenuItem
        // 
        this.saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
        this.saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        this.saveToolStripMenuItem.Size = new Size(257, 26);
        this.saveToolStripMenuItem.Text = "&Save";
        this.saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // saveAsToolStripMenuItem
        // 
        this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        this.saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        this.saveAsToolStripMenuItem.Size = new Size(257, 26);
        this.saveAsToolStripMenuItem.Text = "Save &As";
        this.saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // saveAsCopyToolStripMenuItem
        // 
        this.saveAsCopyToolStripMenuItem.Name = "saveAsCopyToolStripMenuItem";
        this.saveAsCopyToolStripMenuItem.Size = new Size(257, 26);
        this.saveAsCopyToolStripMenuItem.Text = "Save As &Copy";
        this.saveAsCopyToolStripMenuItem.Click += saveAsCopyToolStripMenuItem_Click;
        // 
        // toolStripSeparator3
        // 
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new Size(254, 6);
        // 
        // printToolStripMenuItem
        // 
        this.printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
        this.printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.printToolStripMenuItem.Name = "printToolStripMenuItem";
        this.printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        this.printToolStripMenuItem.Size = new Size(257, 26);
        this.printToolStripMenuItem.Text = "&Print";
        this.printToolStripMenuItem.Click += printToolStripMenuItem_Click;
        // 
        // printPreviewToolStripMenuItem
        // 
        this.printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
        this.printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        this.printPreviewToolStripMenuItem.Size = new Size(257, 26);
        this.printPreviewToolStripMenuItem.Text = "Print pre&view";
        this.printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
        // 
        // pageSetupToolStripMenuItem1
        // 
        this.pageSetupToolStripMenuItem1.Name = "pageSetupToolStripMenuItem1";
        this.pageSetupToolStripMenuItem1.Size = new Size(257, 26);
        this.pageSetupToolStripMenuItem1.Text = "Pa&ge Setup";
        this.pageSetupToolStripMenuItem1.Click += pageSetupToolStripMenuItem_Click;
        // 
        // toolStripSeparator4
        // 
        this.toolStripSeparator4.Name = "toolStripSeparator4";
        this.toolStripSeparator4.Size = new Size(254, 6);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
        this.exitToolStripMenuItem.Size = new Size(257, 26);
        this.exitToolStripMenuItem.Text = "E&xit";
        this.exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.undoToolStripMenuItem, this.redoToolStripMenuItem, this.toolStripSeparator5, this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.pasteAsPlainTextToolStripMenuItem, this.toolStripSeparator6, this.selectAllToolStripMenuItem, this.findReplaceToolStripMenuItem });
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new Size(49, 24);
        this.editToolStripMenuItem.Text = "&Edit";
        this.editToolStripMenuItem.DropDownOpening += editToolStripMenuItem_DropDownOpening;
        // 
        // undoToolStripMenuItem
        // 
        this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        this.undoToolStripMenuItem.Size = new Size(325, 26);
        this.undoToolStripMenuItem.Text = "&Undo";
        this.undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
        // 
        // redoToolStripMenuItem
        // 
        this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        this.redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        this.redoToolStripMenuItem.Size = new Size(325, 26);
        this.redoToolStripMenuItem.Text = "&Redo";
        this.redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
        // 
        // toolStripSeparator5
        // 
        this.toolStripSeparator5.Name = "toolStripSeparator5";
        this.toolStripSeparator5.Size = new Size(322, 6);
        // 
        // cutToolStripMenuItem
        // 
        this.cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
        this.cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        this.cutToolStripMenuItem.Size = new Size(325, 26);
        this.cutToolStripMenuItem.Text = "Cu&t";
        this.cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
        // 
        // copyToolStripMenuItem
        // 
        this.copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
        this.copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        this.copyToolStripMenuItem.Size = new Size(325, 26);
        this.copyToolStripMenuItem.Text = "&Copy";
        this.copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
        // 
        // pasteToolStripMenuItem
        // 
        this.pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
        this.pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        this.pasteToolStripMenuItem.Size = new Size(325, 26);
        this.pasteToolStripMenuItem.Text = "&Paste";
        this.pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
        // 
        // pasteAsPlainTextToolStripMenuItem
        // 
        this.pasteAsPlainTextToolStripMenuItem.Name = "pasteAsPlainTextToolStripMenuItem";
        this.pasteAsPlainTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
        this.pasteAsPlainTextToolStripMenuItem.Size = new Size(325, 26);
        this.pasteAsPlainTextToolStripMenuItem.Text = "Paste as plain text";
        this.pasteAsPlainTextToolStripMenuItem.Click += pasteAsPlainTextToolStripMenuItem_Click;
        // 
        // toolStripSeparator6
        // 
        this.toolStripSeparator6.Name = "toolStripSeparator6";
        this.toolStripSeparator6.Size = new Size(322, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
        this.selectAllToolStripMenuItem.Size = new Size(325, 26);
        this.selectAllToolStripMenuItem.Text = "Select &all";
        this.selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
        // 
        // findReplaceToolStripMenuItem
        // 
        this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
        this.findReplaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
        this.findReplaceToolStripMenuItem.Size = new Size(325, 26);
        this.findReplaceToolStripMenuItem.Text = "Find / Replace";
        this.findReplaceToolStripMenuItem.Click += findReplaceToolStripMenuItem_Click;
        // 
        // viewToolStripMenuItem
        // 
        this.viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.zoomToolStripMenuItem, this.toolStripSeparator7, this.wordWrapToolStripMenuItem });
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Size = new Size(55, 24);
        this.viewToolStripMenuItem.Text = "&View";
        this.viewToolStripMenuItem.DropDownOpening += viewToolStripMenuItem_DropDownOpening;
        // 
        // zoomToolStripMenuItem
        // 
        this.zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.zoomInToolStripMenuItem, this.zoomOutToolStripMenuItem, this.restore100ToolStripMenuItem });
        this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
        this.zoomToolStripMenuItem.Size = new Size(165, 26);
        this.zoomToolStripMenuItem.Text = "Zoom";
        // 
        // zoomInToolStripMenuItem
        // 
        this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
        this.zoomInToolStripMenuItem.Size = new Size(160, 26);
        this.zoomInToolStripMenuItem.Text = "Zoom In";
        this.zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
        // 
        // zoomOutToolStripMenuItem
        // 
        this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
        this.zoomOutToolStripMenuItem.Size = new Size(160, 26);
        this.zoomOutToolStripMenuItem.Text = "Zoom Out";
        this.zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
        // 
        // restore100ToolStripMenuItem
        // 
        this.restore100ToolStripMenuItem.Name = "restore100ToolStripMenuItem";
        this.restore100ToolStripMenuItem.Size = new Size(160, 26);
        this.restore100ToolStripMenuItem.Text = "100%";
        this.restore100ToolStripMenuItem.Click += restore100ToolStripMenuItem_Click;
        // 
        // toolStripSeparator7
        // 
        this.toolStripSeparator7.Name = "toolStripSeparator7";
        this.toolStripSeparator7.Size = new Size(162, 6);
        // 
        // wordWrapToolStripMenuItem
        // 
        this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
        this.wordWrapToolStripMenuItem.Size = new Size(165, 26);
        this.wordWrapToolStripMenuItem.Text = "Word wrap";
        this.wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
        // 
        // optionsToolStripMenuItem
        // 
        this.optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.enableSpellCheckToolStripMenuItem, this.autoWordSelectionToolStripMenuItem, this.enableDragAndDropContentToolStripMenuItem, this.enableKeyboardShortcutsToolStripMenuItem, this.useCtrlClickForOpeningHyperlinksToolStripMenuItem });
        this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        this.optionsToolStripMenuItem.Size = new Size(75, 24);
        this.optionsToolStripMenuItem.Text = "&Options";
        this.optionsToolStripMenuItem.DropDownOpening += optionsToolStripMenuItem_DropDownOpening;
        // 
        // enableSpellCheckToolStripMenuItem
        // 
        this.enableSpellCheckToolStripMenuItem.Name = "enableSpellCheckToolStripMenuItem";
        this.enableSpellCheckToolStripMenuItem.Size = new Size(336, 26);
        this.enableSpellCheckToolStripMenuItem.Text = "Enable spell check";
        this.enableSpellCheckToolStripMenuItem.Click += enableSpellCheckToolStripMenuItem_Click;
        // 
        // autoWordSelectionToolStripMenuItem
        // 
        this.autoWordSelectionToolStripMenuItem.Name = "autoWordSelectionToolStripMenuItem";
        this.autoWordSelectionToolStripMenuItem.Size = new Size(336, 26);
        this.autoWordSelectionToolStripMenuItem.Text = "Auto word selection";
        this.autoWordSelectionToolStripMenuItem.Click += autoWordSelectionToolStripMenuItem_Click;
        // 
        // enableDragAndDropContentToolStripMenuItem
        // 
        this.enableDragAndDropContentToolStripMenuItem.Name = "enableDragAndDropContentToolStripMenuItem";
        this.enableDragAndDropContentToolStripMenuItem.Size = new Size(336, 26);
        this.enableDragAndDropContentToolStripMenuItem.Text = "Enable drag and drop content";
        this.enableDragAndDropContentToolStripMenuItem.Click += enableDragAndDropContentToolStripMenuItem_Click;
        // 
        // enableKeyboardShortcutsToolStripMenuItem
        // 
        this.enableKeyboardShortcutsToolStripMenuItem.Name = "enableKeyboardShortcutsToolStripMenuItem";
        this.enableKeyboardShortcutsToolStripMenuItem.Size = new Size(336, 26);
        this.enableKeyboardShortcutsToolStripMenuItem.Text = "Enable keyboard shortcuts";
        this.enableKeyboardShortcutsToolStripMenuItem.Click += enableKeyboardShortcutsToolStripMenuItem_Click;
        // 
        // useCtrlClickForOpeningHyperlinksToolStripMenuItem
        // 
        this.useCtrlClickForOpeningHyperlinksToolStripMenuItem.Name = "useCtrlClickForOpeningHyperlinksToolStripMenuItem";
        this.useCtrlClickForOpeningHyperlinksToolStripMenuItem.Size = new Size(336, 26);
        this.useCtrlClickForOpeningHyperlinksToolStripMenuItem.Text = "Use Ctrl+Click for opening hyperlinks";
        this.useCtrlClickForOpeningHyperlinksToolStripMenuItem.Click += useCtrlClickForOpeningHyperlinksToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
        this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        this.toolStripMenuItem1.Size = new Size(30, 24);
        this.toolStripMenuItem1.Text = "?";
        // 
        // aboutToolStripMenuItem
        // 
        this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        this.aboutToolStripMenuItem.Size = new Size(142, 26);
        this.aboutToolStripMenuItem.Text = "&About...";
        this.aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // imageOpenFileDialog
        // 
        this.imageOpenFileDialog.AddToRecent = false;
        this.imageOpenFileDialog.Filter = resources.GetString("imageOpenFileDialog.Filter");
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1149, 450);
        Controls.Add(this.richTextBoxEx1);
        Controls.Add(this.toolStrip1);
        Controls.Add(this.menuStrip1);
        DoubleBuffered = true;
        MainMenuStrip = this.menuStrip1;
        Name = "Form1";
        Text = "Rich Text Editor";
        Shown += Form1_Shown;
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStrip1;
    private ToolStripComboBox fontComboBox;
    private ToolStripButton boldButton;
    private ToolStripButton italicButton;
    private ToolStripButton strikethroughButton;
    private ToolStripButton fontOptionsButton;
    private ToolStripComboBox fontSizeComboBox;
    private ToolStripButton underlineButton;
    private RichTextBoxEx.RichTextBoxEx richTextBoxEx1;
    private ToolStripButton paragraphOptionsButton;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton alignLeftButton;
    private ToolStripButton alignCenterButton;
    private ToolStripButton alignRightButton;
    private ToolStripButton alignJustifiedButton;
    private ToolStripButton bulletedListButton;
    private ToolStripButton numberedListButton;
    private ToolStripButton outdentButton;
    private ToolStripButton indentButton;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton imageButton;
    private ToolStripButton superScriptButton;
    private ToolStripButton subscriptButton;
    private ToolStripButton tableButton;
    private ToolStripButton hyperlinkButton;
    private PageSetupDialog pageSetupDialog1;
    private PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private PrintPreviewDialog printPreviewDialog1;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem printToolStripMenuItem;
    private ToolStripMenuItem printPreviewToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem pageSetupToolStripMenuItem1;
    private ToolStripButton dateTimeButton;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem enableSpellCheckToolStripMenuItem;
    private ToolStripMenuItem autoWordSelectionToolStripMenuItem;
    private ToolStripMenuItem enableDragAndDropContentToolStripMenuItem;
    private ToolStripMenuItem enableKeyboardShortcutsToolStripMenuItem;
    private ToolStripMenuItem findReplaceToolStripMenuItem;
    private ToolStripMenuItem saveAsCopyToolStripMenuItem;
    private ToolStripMenuItem pasteAsPlainTextToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private OpenFileDialog imageOpenFileDialog;
    private UserControls.ToolStripColorPicker fontColorPicker;
    private UserControls.ToolStripColorPicker textHighlightColorPicker;
    private ToolStripMenuItem useCtrlClickForOpeningHyperlinksToolStripMenuItem;
    private ToolStripMenuItem zoomToolStripMenuItem;
    private ToolStripMenuItem zoomInToolStripMenuItem;
    private ToolStripMenuItem zoomOutToolStripMenuItem;
    private ToolStripMenuItem restore100ToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem wordWrapToolStripMenuItem;
}
