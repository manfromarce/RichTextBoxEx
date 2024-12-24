namespace WinFormsSampleApp.UserControls;

partial class ContextMenuForm
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
        this.panelMain = new Panel();
        SuspendLayout();
        // 
        // panelMain
        // 
        this.panelMain.BackColor = Color.White;
        this.panelMain.BorderStyle = BorderStyle.FixedSingle;
        this.panelMain.Dock = DockStyle.Fill;
        this.panelMain.Location = new Point(0, 0);
        this.panelMain.Name = "panelMain";
        this.panelMain.Size = new Size(832, 312);
        this.panelMain.TabIndex = 0;
        // 
        // ContextMenuForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.White;
        ClientSize = new Size(832, 312);
        ControlBox = false;
        Controls.Add(this.panelMain);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ContextMenuForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.Manual;
        Text = "ContextMenuPanel";
        Deactivate += ContextMenuPanel_Deactivate;
        Leave += ContextMenuPanel_Leave;
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelMain;
}