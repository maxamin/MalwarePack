<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Host = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Port = New System.Windows.Forms.TextBox()
        Me.TheKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MainPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.log = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CLiname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Host
        '
        Me.Host.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Host.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Host.ForeColor = System.Drawing.Color.White
        Me.Host.Location = New System.Drawing.Point(141, 103)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(168, 26)
        Me.Host.TabIndex = 0
        Me.Host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(4, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host or IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(412, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'Port
        '
        Me.Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Port.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Port.ForeColor = System.Drawing.Color.White
        Me.Port.Location = New System.Drawing.Point(476, 40)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(168, 26)
        Me.Port.TabIndex = 3
        Me.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TheKey
        '
        Me.TheKey.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TheKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheKey.ForeColor = System.Drawing.Color.White
        Me.TheKey.Location = New System.Drawing.Point(476, 103)
        Me.TheKey.Name = "TheKey"
        Me.TheKey.Size = New System.Drawing.Size(168, 26)
        Me.TheKey.TabIndex = 5
        Me.TheKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(412, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Key"
        '
        'FolderPath
        '
        Me.FolderPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.FolderPath.ForeColor = System.Drawing.Color.White
        Me.FolderPath.Location = New System.Drawing.Point(8, 50)
        Me.FolderPath.Name = "FolderPath"
        Me.FolderPath.ReadOnly = True
        Me.FolderPath.Size = New System.Drawing.Size(290, 24)
        Me.FolderPath.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(8, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(380, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(290, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainPath
        '
        Me.MainPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.MainPath.ForeColor = System.Drawing.Color.White
        Me.MainPath.Location = New System.Drawing.Point(380, 50)
        Me.MainPath.Name = "MainPath"
        Me.MainPath.ReadOnly = True
        Me.MainPath.Size = New System.Drawing.Size(290, 24)
        Me.MainPath.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(457, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 27)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "2 : Target Main"
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.log.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ForeColor = System.Drawing.Color.Lime
        Me.log.Location = New System.Drawing.Point(12, 490)
        Me.log.Multiline = True
        Me.log.Name = "log"
        Me.log.ReadOnly = True
        Me.log.Size = New System.Drawing.Size(682, 141)
        Me.log.TabIndex = 12
        Me.log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(188, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(331, 54)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Start injection"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(66, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "1 : Target Apk Foder "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 30.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(120, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(461, 61)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cypher Apk Injector"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox1.Location = New System.Drawing.Point(77, 438)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(102, 22)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Keep Alive"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "To Hide Notification Disable This Option")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CLiname
        '
        Me.CLiname.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.CLiname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLiname.ForeColor = System.Drawing.Color.White
        Me.CLiname.Location = New System.Drawing.Point(141, 40)
        Me.CLiname.Name = "CLiname"
        Me.CLiname.Size = New System.Drawing.Size(168, 26)
        Me.CLiname.TabIndex = 17
        Me.CLiname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(4, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Client Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TheKey)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Host)
        Me.Panel1.Controls.Add(Me.CLiname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Port)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 150)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.FolderPath)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.MainPath)
        Me.Panel2.Location = New System.Drawing.Point(12, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 115)
        Me.Panel2.TabIndex = 20
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(502, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "By EvLF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(31, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 29)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Information"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(525, 419)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 54)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "About"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(706, 638)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.log)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Host As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Port As TextBox
    Friend WithEvents TheKey As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderPath As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MainPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents log As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CLiname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
End Class
