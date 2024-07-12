<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMSManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ctx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueuedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FailedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.BoxTitle = New System.Windows.Forms.PictureBox()
        Me.sendsbtn = New MetroSet_UI.Controls.MetroSetButton()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx.SuspendLayout()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV0
        '
        Me.DGV0.AllowUserToAddRows = False
        Me.DGV0.AllowUserToDeleteRows = False
        Me.DGV0.AllowUserToResizeColumns = False
        Me.DGV0.AllowUserToResizeRows = False
        Me.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV0.BackgroundColor = System.Drawing.Color.Black
        Me.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column9, Me.Column7, Me.Column2, Me.Column3})
        Me.DGV0.ContextMenuStrip = Me.ctx
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(0, 0)
        Me.DGV0.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(987, 560)
        Me.DGV0.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "address"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 92
        '
        'Column6
        '
        Me.Column6.HeaderText = "name"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 73
        '
        'Column9
        '
        Me.Column9.HeaderText = "date"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 66
        '
        'Column7
        '
        Me.Column7.HeaderText = "part"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 63
        '
        'Column2
        '
        Me.Column2.HeaderText = "path"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 66
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.FillWeight = 1.0!
        Me.Column3.HeaderText = ""
        Me.Column3.MinimumWidth = 2
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column3.Width = 2
        '
        'ctx
        '
        Me.ctx.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathsToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.ctx.Name = "ContextMenuStrip1"
        Me.ctx.ShowImageMargin = False
        Me.ctx.Size = New System.Drawing.Size(105, 76)
        '
        'PathsToolStripMenuItem
        '
        Me.PathsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.OutboxToolStripMenuItem, Me.InboxToolStripMenuItem, Me.SentToolStripMenuItem, Me.QueuedToolStripMenuItem, Me.FailedToolStripMenuItem})
        Me.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem"
        Me.PathsToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.PathsToolStripMenuItem.Text = "Paths"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.AllToolStripMenuItem.Text = "all"
        '
        'OutboxToolStripMenuItem
        '
        Me.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem"
        Me.OutboxToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.OutboxToolStripMenuItem.Text = "outbox"
        '
        'InboxToolStripMenuItem
        '
        Me.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem"
        Me.InboxToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.InboxToolStripMenuItem.Text = "inbox"
        '
        'SentToolStripMenuItem
        '
        Me.SentToolStripMenuItem.Name = "SentToolStripMenuItem"
        Me.SentToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.SentToolStripMenuItem.Text = "sent"
        '
        'QueuedToolStripMenuItem
        '
        Me.QueuedToolStripMenuItem.Name = "QueuedToolStripMenuItem"
        Me.QueuedToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.QueuedToolStripMenuItem.Text = "queued"
        '
        'FailedToolStripMenuItem
        '
        Me.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem"
        Me.FailedToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.FailedToolStripMenuItem.Text = "failed"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        Me.SaveAsToolStripMenuItem.Visible = False
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB.Location = New System.Drawing.Point(0, 560)
        Me.PB.Margin = New System.Windows.Forms.Padding(4)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(987, 12)
        Me.PB.TabIndex = 6
        '
        'BoxTitle
        '
        Me.BoxTitle.BackColor = System.Drawing.Color.Black
        Me.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxTitle.ErrorImage = Nothing
        Me.BoxTitle.InitialImage = Nothing
        Me.BoxTitle.Location = New System.Drawing.Point(0, 572)
        Me.BoxTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.BoxTitle.Name = "BoxTitle"
        Me.BoxTitle.Size = New System.Drawing.Size(987, 22)
        Me.BoxTitle.TabIndex = 7
        Me.BoxTitle.TabStop = False
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
        Me.sendsbtn.Location = New System.Drawing.Point(863, 500)
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
        Me.sendsbtn.TabIndex = 8
        Me.sendsbtn.Text = "Send SMS"
        Me.sendsbtn.ThemeAuthor = "Narwin"
        Me.sendsbtn.ThemeName = "MetroLite"
        '
        'SMSManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 594)
        Me.Controls.Add(Me.sendsbtn)
        Me.Controls.Add(Me.DGV0)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BoxTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SMSManager"
        Me.Opacity = 0R
        Me.Text = "SMSManager"
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx.ResumeLayout(False)
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents ctx As ContextMenuStrip
    Friend WithEvents PathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueuedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FailedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOpacity As Timer
    Friend WithEvents PB As ProgressBar
    Friend WithEvents BoxTitle As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents sendsbtn As MetroSet_UI.Controls.MetroSetButton
End Class
