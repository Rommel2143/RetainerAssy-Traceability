<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sub_Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_Frame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_menu = New Guna.UI2.WinForms.Guna2Button()
        Me.system_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartsScanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCScanningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraceabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_profile = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_administrator = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_stock = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2.SuspendLayout()
        Me.system_menu.SuspendLayout()
        Me.profile_menu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 519)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.btn_menu)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_stock)
        Me.Panel2.Controls.Add(Me.btn_profile)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 51)
        Me.Panel2.TabIndex = 6
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu.BorderRadius = 5
        Me.btn_menu.ContextMenuStrip = Me.system_menu
        Me.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_menu.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btn_menu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_menu.ForeColor = System.Drawing.Color.DimGray
        Me.btn_menu.Image = CType(resources.GetObject("btn_menu.Image"), System.Drawing.Image)
        Me.btn_menu.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_menu.Location = New System.Drawing.Point(869, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(46, 51)
        Me.btn_menu.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btn_menu, "Menu")
        Me.btn_menu.UseTransparentBackground = True
        '
        'system_menu
        '
        Me.system_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.PartsScanningToolStripMenuItem, Me.QCScanningToolStripMenuItem, Me.TraceabilityToolStripMenuItem})
        Me.system_menu.Name = "ContextMenuStrip1"
        Me.system_menu.Size = New System.Drawing.Size(180, 124)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanINToolStripMenuItem})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.DimGray
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(179, 30)
        Me.ToolStripMenuItem2.Text = "Kitting"
        '
        'ScanINToolStripMenuItem
        '
        Me.ScanINToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.ScanINToolStripMenuItem.Name = "ScanINToolStripMenuItem"
        Me.ScanINToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.ScanINToolStripMenuItem.Text = "Scan IN"
        '
        'PartsScanningToolStripMenuItem
        '
        Me.PartsScanningToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartsScanningToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.PartsScanningToolStripMenuItem.Image = CType(resources.GetObject("PartsScanningToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PartsScanningToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PartsScanningToolStripMenuItem.Name = "PartsScanningToolStripMenuItem"
        Me.PartsScanningToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.PartsScanningToolStripMenuItem.Text = "Parts Scanning"
        '
        'QCScanningToolStripMenuItem
        '
        Me.QCScanningToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QCScanningToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.QCScanningToolStripMenuItem.Image = CType(resources.GetObject("QCScanningToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QCScanningToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QCScanningToolStripMenuItem.Name = "QCScanningToolStripMenuItem"
        Me.QCScanningToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.QCScanningToolStripMenuItem.Text = "QC Scanning"
        '
        'TraceabilityToolStripMenuItem
        '
        Me.TraceabilityToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TraceabilityToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.TraceabilityToolStripMenuItem.Image = CType(resources.GetObject("TraceabilityToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TraceabilityToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TraceabilityToolStripMenuItem.Name = "TraceabilityToolStripMenuItem"
        Me.TraceabilityToolStripMenuItem.Size = New System.Drawing.Size(179, 30)
        Me.TraceabilityToolStripMenuItem.Text = "Traceability"
        '
        'btn_profile
        '
        Me.btn_profile.BackColor = System.Drawing.Color.Transparent
        Me.btn_profile.ContextMenuStrip = Me.profile_menu
        Me.btn_profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_profile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_profile.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btn_profile.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_profile.ForeColor = System.Drawing.Color.DimGray
        Me.btn_profile.Image = CType(resources.GetObject("btn_profile.Image"), System.Drawing.Image)
        Me.btn_profile.ImageSize = New System.Drawing.Size(32, 32)
        Me.btn_profile.Location = New System.Drawing.Point(961, 0)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_profile.Size = New System.Drawing.Size(55, 51)
        Me.btn_profile.TabIndex = 2
        Me.btn_profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.btn_profile, "Profile")
        Me.btn_profile.UseTransparentBackground = True
        '
        'profile_menu
        '
        Me.profile_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_user, Me.btn_administrator, Me.LogoutToolStripMenuItem})
        Me.profile_menu.Name = "ContextMenuStrip1"
        Me.profile_menu.Size = New System.Drawing.Size(165, 70)
        '
        'btn_user
        '
        Me.btn_user.Enabled = False
        Me.btn_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_user.ForeColor = System.Drawing.Color.DimGray
        Me.btn_user.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(164, 22)
        Me.btn_user.Text = "Manage Profile"
        '
        'btn_administrator
        '
        Me.btn_administrator.BackColor = System.Drawing.Color.MistyRose
        Me.btn_administrator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_administrator.ForeColor = System.Drawing.Color.DimGray
        Me.btn_administrator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_administrator.Name = "btn_administrator"
        Me.btn_administrator.Size = New System.Drawing.Size(164, 22)
        Me.btn_administrator.Text = "Administrator"
        Me.btn_administrator.Visible = False
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(216, 51)
        Me.Panel3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(78, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Retainer Assembly"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Philippines TRC Inc."
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(19, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(53, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btn_stock
        '
        Me.btn_stock.BackColor = System.Drawing.Color.Transparent
        Me.btn_stock.BorderRadius = 5
        Me.btn_stock.ContextMenuStrip = Me.system_menu
        Me.btn_stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_stock.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_stock.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btn_stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_stock.ForeColor = System.Drawing.Color.DimGray
        Me.btn_stock.Image = CType(resources.GetObject("btn_stock.Image"), System.Drawing.Image)
        Me.btn_stock.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_stock.Location = New System.Drawing.Point(915, 0)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(46, 51)
        Me.btn_stock.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btn_stock, "Menu")
        Me.btn_stock.UseTransparentBackground = True
        '
        'sub_Frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 570)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_Frame"
        Me.Text = "sub_Frame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.system_menu.ResumeLayout(False)
        Me.profile_menu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_menu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_profile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents profile_menu As ContextMenuStrip
    Friend WithEvents btn_user As ToolStripMenuItem
    Friend WithEvents btn_administrator As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents system_menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PartsScanningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCScanningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraceabilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ScanINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_stock As Guna.UI2.WinForms.Guna2Button
End Class
