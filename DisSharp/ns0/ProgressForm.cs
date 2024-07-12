/*
 * Created by SharpDevelop.
 * User: Elvev
 * Date: 1/21/2023
 * Time: 9:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
    
namespace ns0
{
	/// <summary>
	/// Description of ProgressForm.
	/// </summary>
	internal partial class ProgressForm : Form0
	{
	
	internal bool bool_0;
	
	internal ProgressForm(string A_1) : this(A_1, false)
    {
    }
	
        internal ProgressForm(string A_1, bool A_2)
        {
            this.InitializeComponent();
            this.Text = A_1;
            this.StopButton.Enabled = A_2;
            base.ControlBox = false;
            Rectangle bounds = Class698.class582_0.mainForm_0.Bounds;
            int num = (bounds.Width - base.Width) / 2;
            int num2 = (bounds.Height - base.Height) / 2;
            base.Left = bounds.Left + num;
            base.Top = bounds.Top + num2;
        }
        
        
        internal void method_0(int A_1, int A_2)
        {
            this.progress.Maximum = A_2;
            this.method_1(A_1);
        }

        internal void method_1(int A_1)
        {
            this.progress.Value = A_1;
            this.label.Text = A_1.ToString() + " from " + this.progress.Maximum.ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.bool_0 = true;
        }

	}
}
