<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CypherRat
    Inherits System.Windows.Forms.Form
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
      Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CypherRat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.notfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Mainpanel = New System.Windows.Forms.Panel()
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.OnlinText = New System.Windows.Forms.Label()
        Me.PortText = New System.Windows.Forms.Label()
        Me.SntText = New System.Windows.Forms.Label()
        Me.RcvText = New System.Windows.Forms.Label()
        Me.DataLog = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.clientsflow = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Mainpanel.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        CType(Me.DataLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'notfi
        '
        Me.notfi.Icon = CType(resources.GetObject("notfi.Icon"), System.Drawing.Icon)
        Me.notfi.Text = "Cypher Rat - t.me/evlfev"
        Me.notfi.Visible = True
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 10
        '
        'Mainpanel
        '
        Me.Mainpanel.Controls.Add(Me.clientsflow)
        Me.Mainpanel.Controls.Add(Me.StatusPanel)
        Me.Mainpanel.Controls.Add(Me.DataLog)
        Me.Mainpanel.Controls.Add(Me.LeftPanel)
        Me.Mainpanel.Controls.Add(Me.Panel1)
        Me.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mainpanel.Location = New System.Drawing.Point(0, 0)
        Me.Mainpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.Mainpanel.Name = "Mainpanel"
        Me.Mainpanel.Size = New System.Drawing.Size(1448, 677)
        Me.Mainpanel.TabIndex = 3
        '
        'StatusPanel
        '
        Me.StatusPanel.BackColor = System.Drawing.Color.Black
        Me.StatusPanel.Controls.Add(Me.OnlinText)
        Me.StatusPanel.Controls.Add(Me.PortText)
        Me.StatusPanel.Controls.Add(Me.SntText)
        Me.StatusPanel.Controls.Add(Me.RcvText)
        Me.StatusPanel.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanel.ForeColor = System.Drawing.Color.White
        Me.StatusPanel.Location = New System.Drawing.Point(213, 643)
        Me.StatusPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(1235, 34)
        Me.StatusPanel.TabIndex = 2
        '
        'OnlinText
        '
        Me.OnlinText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlinText.AutoSize = True
        Me.OnlinText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnlinText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OnlinText.Location = New System.Drawing.Point(968, 5)
        Me.OnlinText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OnlinText.Name = "OnlinText"
        Me.OnlinText.Size = New System.Drawing.Size(62, 23)
        Me.OnlinText.TabIndex = 9
        Me.OnlinText.Text = "Online"
        '
        'PortText
        '
        Me.PortText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortText.AutoSize = True
        Me.PortText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PortText.Location = New System.Drawing.Point(1135, 5)
        Me.PortText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PortText.Name = "PortText"
        Me.PortText.Size = New System.Drawing.Size(42, 23)
        Me.PortText.TabIndex = 8
        Me.PortText.Text = "Port"
        '
        'SntText
        '
        Me.SntText.AutoSize = True
        Me.SntText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SntText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SntText.Location = New System.Drawing.Point(204, 4)
        Me.SntText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SntText.Name = "SntText"
        Me.SntText.Size = New System.Drawing.Size(44, 23)
        Me.SntText.TabIndex = 7
        Me.SntText.Text = "Sent"
        '
        'RcvText
        '
        Me.RcvText.AutoSize = True
        Me.RcvText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RcvText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RcvText.Location = New System.Drawing.Point(4, 4)
        Me.RcvText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RcvText.Name = "RcvText"
        Me.RcvText.Size = New System.Drawing.Size(78, 23)
        Me.RcvText.TabIndex = 6
        Me.RcvText.Text = "Received"
        '
        'DataLog
        '
        Me.DataLog.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataLog.AllowUserToAddRows = False
        Me.DataLog.AllowUserToDeleteRows = False
        Me.DataLog.AllowUserToResizeColumns = False
        Me.DataLog.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataLog.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DataLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7})
        Me.DataLog.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLog.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataLog.EnableHeadersVisualStyles = False
        Me.DataLog.GridColor = System.Drawing.Color.Black
        Me.DataLog.Location = New System.Drawing.Point(213, 43)
        Me.DataLog.Margin = New System.Windows.Forms.Padding(4)
        Me.DataLog.Name = "DataLog"
        Me.DataLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataLog.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DataLog.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLog.ShowCellToolTips = False
        Me.DataLog.Size = New System.Drawing.Size(1235, 634)
        Me.DataLog.TabIndex = 2
        Me.DataLog.Tag = "b"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Flag"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "ip"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 43)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "By EVLF"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1394, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1421, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.Black
        Me.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LeftPanel.Controls.Add(Me.Button8)
        Me.LeftPanel.Controls.Add(Me.Button9)
        Me.LeftPanel.Controls.Add(Me.clearbtn)
        Me.LeftPanel.Controls.Add(Me.Button3)
        Me.LeftPanel.Controls.Add(Me.Button5)
        Me.LeftPanel.Controls.Add(Me.Button6)
        Me.LeftPanel.Controls.Add(Me.Button7)
        Me.LeftPanel.Controls.Add(Me.Button4)
        Me.LeftPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 43)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(213, 634)
        Me.LeftPanel.TabIndex = 2
        Me.LeftPanel.Tag = "off"
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.Black
        Me.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clearbtn.FlatAppearance.BorderSize = 0
        Me.clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.ForeColor = System.Drawing.Color.Red
        Me.clearbtn.Image = CType(resources.GetObject("clearbtn.Image"), System.Drawing.Image)
        Me.clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearbtn.Location = New System.Drawing.Point(0, 460)
        Me.clearbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(213, 58)
        Me.clearbtn.TabIndex = 7
        Me.clearbtn.Text = "Clear Log"
        Me.clearbtn.UseVisualStyleBackColor = False
        Me.clearbtn.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 518)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(213, 58)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Settings"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 576)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(213, 58)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 169)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(213, 58)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Logs"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Palatino Linotype", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 119)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(213, 50)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Cypher Rat"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImage = Global.AngelAndroid_v2.My.Resources.Resources.LOGO
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 119)
        Me.Button4.TabIndex = 8
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.Black
        Me.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(1448, 0)
        Me.RightPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(9, 677)
        Me.RightPanel.TabIndex = 10
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(0, 279)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(213, 52)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "    Injection   "
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Roboto Slab", 10.0!)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(0, 227)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(213, 52)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Build"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'clientsflow
        '
        Me.clientsflow.AutoScroll = True
        Me.clientsflow.BackColor = System.Drawing.Color.Black
        Me.clientsflow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientsflow.Location = New System.Drawing.Point(213, 43)
        Me.clientsflow.Margin = New System.Windows.Forms.Padding(4)
        Me.clientsflow.Name = "clientsflow"
        Me.clientsflow.Size = New System.Drawing.Size(1235, 600)
        Me.clientsflow.TabIndex = 3
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(1367, 0)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(27, 43)
        Me.Button10.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button10, "support")
        Me.Button10.UseVisualStyleBackColor = False
        '
        'CypherRat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1457, 677)
        Me.Controls.Add(Me.Mainpanel)
        Me.Controls.Add(Me.RightPanel)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(735, 95)
        Me.Name = "CypherRat"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spy Max"
        Me.Mainpanel.ResumeLayout(False)
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        CType(Me.DataLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.LeftPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents notfi As NotifyIcon
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Mainpanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusPanel As Panel
    Friend WithEvents OnlinText As Label
    Friend WithEvents PortText As Label
    Friend WithEvents SntText As Label
    Friend WithEvents RcvText As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RightPanel As Panel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Button6 As Button
    Public WithEvents DataLog As DataGridView
    Friend WithEvents clearbtn As Button
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents clientsflow As FlowLayoutPanel
    Friend WithEvents Button10 As Button
End Class
