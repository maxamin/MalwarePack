/*
 * Created by SharpDevelop.
 * User: Elvev
 * Date: 1/21/2023
 * Time: 9:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    
namespace ns0
{
	partial class ProgressForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager manager = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.progress = new ProgressBar();
            this.StopButton = new Button();
            this.label = new Label();
            base.SuspendLayout();
            this.progress.Location = new Point(0x10, 0x48);
            this.progress.Maximum = 1;
            this.progress.Name = "progress";
            this.progress.Size = new Size(0xe0, 0x17);
            this.progress.TabIndex = 2;
            this.StopButton.FlatStyle = FlatStyle.System;
            this.StopButton.Location = new Point(80, 120);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new Size(0x60, 0x20);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new EventHandler(this.StopButton_Click);
            this.label.FlatStyle = FlatStyle.System;
            this.label.Location = new Point(0x10, 0x18);
            this.label.Name = "label";
            this.label.Size = new Size(0xe0, 0x20);
            this.label.TabIndex = 4;
            this.label.Text = "label1";
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(0x100, 0xae);
            base.ControlBox = false;
            base.Controls.Add(this.label);
            base.Controls.Add(this.StopButton);
            base.Controls.Add(this.progress);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Location = new Point(0, 0);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ProgressForm";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Title";
            base.ResumeLayout(false);
        }
        
		private System.ComponentModel.Container container_0;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button StopButton;
	}
}
