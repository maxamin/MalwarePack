<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.msgtext = New MetroSet_UI.Controls.MetroSetTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sendsbtn = New MetroSet_UI.Controls.MetroSetButton()
        Me.MetroSetButton1 = New MetroSet_UI.Controls.MetroSetButton()
        Me.phonetext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'msgtext
        '
        Me.msgtext.AutoCompleteCustomSource = Nothing
        Me.msgtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.msgtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.msgtext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.msgtext.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.msgtext.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.msgtext.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.msgtext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msgtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.msgtext.HoverColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.msgtext.Image = Nothing
        Me.msgtext.IsDerivedStyle = False
        Me.msgtext.Lines = Nothing
        Me.msgtext.Location = New System.Drawing.Point(0, 60)
        Me.msgtext.MaxLength = 32767
        Me.msgtext.Multiline = True
        Me.msgtext.Name = "msgtext"
        Me.msgtext.ReadOnly = False
        Me.msgtext.Size = New System.Drawing.Size(377, 425)
        Me.msgtext.Style = MetroSet_UI.Enums.Style.Light
        Me.msgtext.StyleManager = Nothing
        Me.msgtext.TabIndex = 0
        Me.msgtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.msgtext.ThemeAuthor = "Narwin"
        Me.msgtext.ThemeName = "MetroLite"
        Me.msgtext.UseSystemPasswordChar = False
        Me.msgtext.WatermarkText = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.phonetext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 60)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MetroSetButton1)
        Me.Panel2.Controls.Add(Me.sendsbtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 65)
        Me.Panel2.TabIndex = 2
        '
        'sendsbtn
        '
        Me.sendsbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendsbtn.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.sendsbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.sendsbtn.DisabledForeColor = System.Drawing.Color.Gray
        Me.sendsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sendsbtn.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sendsbtn.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sendsbtn.HoverTextColor = System.Drawing.Color.White
        Me.sendsbtn.IsDerivedStyle = False
        Me.sendsbtn.Location = New System.Drawing.Point(253, 10)
        Me.sendsbtn.Name = "sendsbtn"
        Me.sendsbtn.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.sendsbtn.NormalColor = System.Drawing.Color.Black
        Me.sendsbtn.NormalTextColor = System.Drawing.Color.White
        Me.sendsbtn.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.sendsbtn.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.sendsbtn.PressTextColor = System.Drawing.Color.White
        Me.sendsbtn.Size = New System.Drawing.Size(112, 43)
        Me.sendsbtn.Style = MetroSet_UI.Enums.Style.Custom
        Me.sendsbtn.StyleManager = Nothing
        Me.sendsbtn.TabIndex = 9
        Me.sendsbtn.Text = "Send"
        Me.sendsbtn.ThemeAuthor = "Narwin"
        Me.sendsbtn.ThemeName = "MetroLite"
        '
        'MetroSetButton1
        '
        Me.MetroSetButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MetroSetButton1.DisabledForeColor = System.Drawing.Color.Gray
        Me.MetroSetButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MetroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroSetButton1.HoverTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.IsDerivedStyle = False
        Me.MetroSetButton1.Location = New System.Drawing.Point(20, 10)
        Me.MetroSetButton1.Name = "MetroSetButton1"
        Me.MetroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroSetButton1.NormalColor = System.Drawing.Color.Black
        Me.MetroSetButton1.NormalTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.MetroSetButton1.PressTextColor = System.Drawing.Color.White
        Me.MetroSetButton1.Size = New System.Drawing.Size(112, 43)
        Me.MetroSetButton1.Style = MetroSet_UI.Enums.Style.Custom
        Me.MetroSetButton1.StyleManager = Nothing
        Me.MetroSetButton1.TabIndex = 10
        Me.MetroSetButton1.Text = "Cancel"
        Me.MetroSetButton1.ThemeAuthor = "Narwin"
        Me.MetroSetButton1.ThemeName = "MetroLite"
        '
        'phonetext
        '
        Me.phonetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonetext.Location = New System.Drawing.Point(109, 12)
        Me.phonetext.Name = "phonetext"
        Me.phonetext.Size = New System.Drawing.Size(248, 30)
        Me.phonetext.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number"
        '
        'SMSMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(377, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.msgtext)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SMSMaker"
        Me.ShowIcon = False
        Me.Text = "SMSMaker"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents msgtext As MetroSet_UI.Controls.MetroSetTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents phonetext As TextBox
    Friend WithEvents MetroSetButton1 As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents sendsbtn As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents Label1 As Label
End Class
