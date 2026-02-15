namespace Screensaver;

partial class ScreensaverForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Timer animationTimer;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        animationTimer = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        
        // animationTimer
        animationTimer.Interval = 20;
        animationTimer.Tick += AnimationTimer_Tick;
        
        // ScreensaverForm
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size(1940, 1100);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "ScreensaverForm";
        TopMost = true;
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        
        // Events
        FormClosing += ScreensaverForm_FormClosing;
        KeyDown += ScreensaverForm_KeyDown;
        MouseClick += ScreensaverForm_MouseClick;
        
        ResumeLayout(false);
    }
}