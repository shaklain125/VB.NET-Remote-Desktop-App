<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.components = New System.ComponentModel.Container()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Extra_btn = New RemoteClient.MaterialFlatButton()
        Me.Complete_btn = New RemoteClient.MaterialFlatButton()
        Me.EndSession_btn = New RemoteClient.MaterialFlatButton()
        Me.EndSessionMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings_btn = New RemoteClient.MaterialFlatButton()
        Me.LiveChat_btn = New RemoteClient.MaterialFlatButton()
        Me.ScreenRecording_btn = New RemoteClient.MaterialFlatButton()
        Me.FileTransfer_btn = New RemoteClient.MaterialFlatButton()
        Me.CurrentScreen_btn = New RemoteClient.MaterialFlatButton()
        Me.FullScreen_btn = New RemoteClient.MaterialFlatButton()
        Me.MainMenu_btn = New RemoteClient.MaterialFlatButton()
        Me.AllButtonsContainer = New System.Windows.Forms.Panel()
        Me.CentreButtonsContainer = New System.Windows.Forms.Panel()
        Me.SRecordMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ControlKeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowWindowsStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirewallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ServiceTime_lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Desktop_pb = New System.Windows.Forms.Panel()
        Me.LiveChatPanel = New System.Windows.Forms.Panel()
        Me.EndSessionMenu.SuspendLayout()
        Me.AllButtonsContainer.SuspendLayout()
        Me.CentreButtonsContainer.SuspendLayout()
        Me.SRecordMenu.SuspendLayout()
        Me.ExtraMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Extra_btn
        '
        Me.Extra_btn.BackColor = System.Drawing.Color.Gray
        Me.Extra_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Extra_btn.FlatAppearance.BorderSize = 0
        Me.Extra_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Extra_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Extra_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Extra_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Extra_btn.Location = New System.Drawing.Point(350, 0)
        Me.Extra_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Extra_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Extra_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Extra_btn.Name = "Extra_btn"
        Me.Extra_btn.Size = New System.Drawing.Size(50, 44)
        Me.Extra_btn.TabIndex = 10
        Me.Extra_btn.Text = ". . ."
        Me.toolTip1.SetToolTip(Me.Extra_btn, "More")
        Me.Extra_btn.UseVisualStyleBackColor = False
        '
        'Complete_btn
        '
        Me.Complete_btn.BackColor = System.Drawing.Color.Gray
        Me.Complete_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Complete_btn.FlatAppearance.BorderSize = 0
        Me.Complete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Complete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Complete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Complete_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Complete_btn.Location = New System.Drawing.Point(300, 0)
        Me.Complete_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Complete_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Complete_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Complete_btn.Name = "Complete_btn"
        Me.Complete_btn.Size = New System.Drawing.Size(50, 44)
        Me.Complete_btn.TabIndex = 9
        Me.Complete_btn.Text = "✔"
        Me.toolTip1.SetToolTip(Me.Complete_btn, "Complete")
        Me.Complete_btn.UseVisualStyleBackColor = False
        '
        'EndSession_btn
        '
        Me.EndSession_btn.BackColor = System.Drawing.Color.Gray
        Me.EndSession_btn.ContextMenuStrip = Me.EndSessionMenu
        Me.EndSession_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.EndSession_btn.FlatAppearance.BorderSize = 0
        Me.EndSession_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.EndSession_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.EndSession_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EndSession_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.EndSession_btn.Location = New System.Drawing.Point(250, 0)
        Me.EndSession_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.EndSession_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.EndSession_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.EndSession_btn.Name = "EndSession_btn"
        Me.EndSession_btn.Size = New System.Drawing.Size(50, 44)
        Me.EndSession_btn.TabIndex = 7
        Me.EndSession_btn.Text = "✖"
        Me.toolTip1.SetToolTip(Me.EndSession_btn, "End Session")
        Me.EndSession_btn.UseVisualStyleBackColor = False
        '
        'EndSessionMenu
        '
        Me.EndSessionMenu.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndSessionMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.ShutdownToolStripMenuItem})
        Me.EndSessionMenu.Name = "ContextMenuStrip1"
        Me.EndSessionMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.EndSessionMenu.ShowImageMargin = False
        Me.EndSessionMenu.Size = New System.Drawing.Size(111, 48)
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'Settings_btn
        '
        Me.Settings_btn.BackColor = System.Drawing.Color.Gray
        Me.Settings_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Settings_btn.FlatAppearance.BorderSize = 0
        Me.Settings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Settings_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Settings_btn.Location = New System.Drawing.Point(200, 0)
        Me.Settings_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.Name = "Settings_btn"
        Me.Settings_btn.Size = New System.Drawing.Size(50, 44)
        Me.Settings_btn.TabIndex = 6
        Me.Settings_btn.Text = "⚙"
        Me.toolTip1.SetToolTip(Me.Settings_btn, "Settings")
        Me.Settings_btn.UseVisualStyleBackColor = False
        '
        'LiveChat_btn
        '
        Me.LiveChat_btn.BackColor = System.Drawing.Color.Gray
        Me.LiveChat_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.LiveChat_btn.FlatAppearance.BorderSize = 0
        Me.LiveChat_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.LiveChat_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.LiveChat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiveChat_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.LiveChat_btn.Location = New System.Drawing.Point(150, 0)
        Me.LiveChat_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.LiveChat_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.LiveChat_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.LiveChat_btn.Name = "LiveChat_btn"
        Me.LiveChat_btn.Size = New System.Drawing.Size(50, 44)
        Me.LiveChat_btn.TabIndex = 5
        Me.LiveChat_btn.Text = "🗪"
        Me.toolTip1.SetToolTip(Me.LiveChat_btn, "Live Chat")
        Me.LiveChat_btn.UseVisualStyleBackColor = False
        '
        'ScreenRecording_btn
        '
        Me.ScreenRecording_btn.BackColor = System.Drawing.Color.Gray
        Me.ScreenRecording_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.ScreenRecording_btn.FlatAppearance.BorderSize = 0
        Me.ScreenRecording_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ScreenRecording_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ScreenRecording_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenRecording_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.ScreenRecording_btn.Location = New System.Drawing.Point(100, 0)
        Me.ScreenRecording_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.ScreenRecording_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.ScreenRecording_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.ScreenRecording_btn.Name = "ScreenRecording_btn"
        Me.ScreenRecording_btn.Size = New System.Drawing.Size(50, 44)
        Me.ScreenRecording_btn.TabIndex = 4
        Me.ScreenRecording_btn.Text = "⏺"
        Me.toolTip1.SetToolTip(Me.ScreenRecording_btn, "Screen Record")
        Me.ScreenRecording_btn.UseVisualStyleBackColor = False
        '
        'FileTransfer_btn
        '
        Me.FileTransfer_btn.BackColor = System.Drawing.Color.Gray
        Me.FileTransfer_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.FileTransfer_btn.FlatAppearance.BorderSize = 0
        Me.FileTransfer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.FileTransfer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.FileTransfer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileTransfer_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.FileTransfer_btn.Location = New System.Drawing.Point(50, 0)
        Me.FileTransfer_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.FileTransfer_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.FileTransfer_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.FileTransfer_btn.Name = "FileTransfer_btn"
        Me.FileTransfer_btn.Size = New System.Drawing.Size(50, 44)
        Me.FileTransfer_btn.TabIndex = 3
        Me.FileTransfer_btn.Text = "⇄"
        Me.toolTip1.SetToolTip(Me.FileTransfer_btn, "File Transfer")
        Me.FileTransfer_btn.UseVisualStyleBackColor = False
        '
        'CurrentScreen_btn
        '
        Me.CurrentScreen_btn.BackColor = System.Drawing.Color.Gray
        Me.CurrentScreen_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.CurrentScreen_btn.FlatAppearance.BorderSize = 0
        Me.CurrentScreen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CurrentScreen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CurrentScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentScreen_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.CurrentScreen_btn.Location = New System.Drawing.Point(0, 0)
        Me.CurrentScreen_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.CurrentScreen_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.CurrentScreen_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.CurrentScreen_btn.Name = "CurrentScreen_btn"
        Me.CurrentScreen_btn.Size = New System.Drawing.Size(50, 44)
        Me.CurrentScreen_btn.TabIndex = 2
        Me.CurrentScreen_btn.Text = "⎚"
        Me.toolTip1.SetToolTip(Me.CurrentScreen_btn, "Client Screen")
        Me.CurrentScreen_btn.UseVisualStyleBackColor = False
        '
        'FullScreen_btn
        '
        Me.FullScreen_btn.BackColor = System.Drawing.Color.Gray
        Me.FullScreen_btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.FullScreen_btn.FlatAppearance.BorderSize = 0
        Me.FullScreen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.FullScreen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.FullScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FullScreen_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.FullScreen_btn.Location = New System.Drawing.Point(769, 0)
        Me.FullScreen_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.FullScreen_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.FullScreen_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.FullScreen_btn.Name = "FullScreen_btn"
        Me.FullScreen_btn.Size = New System.Drawing.Size(50, 44)
        Me.FullScreen_btn.TabIndex = 2
        Me.FullScreen_btn.Text = "⛚"
        Me.toolTip1.SetToolTip(Me.FullScreen_btn, "Full Screen")
        Me.FullScreen_btn.UseVisualStyleBackColor = False
        '
        'MainMenu_btn
        '
        Me.MainMenu_btn.BackColor = System.Drawing.Color.Gray
        Me.MainMenu_btn.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu_btn.FlatAppearance.BorderSize = 0
        Me.MainMenu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MainMenu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MainMenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenu_btn.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.MainMenu_btn.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MainMenu_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MainMenu_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MainMenu_btn.Name = "MainMenu_btn"
        Me.MainMenu_btn.Size = New System.Drawing.Size(50, 44)
        Me.MainMenu_btn.TabIndex = 1
        Me.MainMenu_btn.Text = "☰"
        Me.toolTip1.SetToolTip(Me.MainMenu_btn, "Main Menu")
        Me.MainMenu_btn.UseVisualStyleBackColor = False
        '
        'AllButtonsContainer
        '
        Me.AllButtonsContainer.Controls.Add(Me.CentreButtonsContainer)
        Me.AllButtonsContainer.Controls.Add(Me.FullScreen_btn)
        Me.AllButtonsContainer.Controls.Add(Me.MainMenu_btn)
        Me.AllButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.AllButtonsContainer.Location = New System.Drawing.Point(0, 0)
        Me.AllButtonsContainer.Name = "AllButtonsContainer"
        Me.AllButtonsContainer.Size = New System.Drawing.Size(819, 44)
        Me.AllButtonsContainer.TabIndex = 90
        '
        'CentreButtonsContainer
        '
        Me.CentreButtonsContainer.BackColor = System.Drawing.Color.Gray
        Me.CentreButtonsContainer.Controls.Add(Me.Extra_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.Complete_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.EndSession_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.Settings_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.LiveChat_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.ScreenRecording_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.FileTransfer_btn)
        Me.CentreButtonsContainer.Controls.Add(Me.CurrentScreen_btn)
        Me.CentreButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CentreButtonsContainer.Location = New System.Drawing.Point(50, 0)
        Me.CentreButtonsContainer.Name = "CentreButtonsContainer"
        Me.CentreButtonsContainer.Size = New System.Drawing.Size(719, 44)
        Me.CentreButtonsContainer.TabIndex = 4
        '
        'SRecordMenu
        '
        Me.SRecordMenu.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRecordMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartRecordingToolStripMenuItem})
        Me.SRecordMenu.Name = "SRecordMenu"
        Me.SRecordMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SRecordMenu.ShowImageMargin = False
        Me.SRecordMenu.Size = New System.Drawing.Size(134, 26)
        '
        'StartRecordingToolStripMenuItem
        '
        Me.StartRecordingToolStripMenuItem.Name = "StartRecordingToolStripMenuItem"
        Me.StartRecordingToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.StartRecordingToolStripMenuItem.Text = "Start Recording"
        '
        'ExtraMenu
        '
        Me.ExtraMenu.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlKeyboardToolStripMenuItem, Me.ShowWindowsStartToolStripMenuItem, Me.FirewallToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ExtraMenu.Name = "ExtraMenu"
        Me.ExtraMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ExtraMenu.ShowImageMargin = False
        Me.ExtraMenu.Size = New System.Drawing.Size(211, 92)
        '
        'ControlKeyboardToolStripMenuItem
        '
        Me.ControlKeyboardToolStripMenuItem.Name = "ControlKeyboardToolStripMenuItem"
        Me.ControlKeyboardToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ControlKeyboardToolStripMenuItem.Text = "Disable Mouse and Keyboard"
        '
        'ShowWindowsStartToolStripMenuItem
        '
        Me.ShowWindowsStartToolStripMenuItem.Name = "ShowWindowsStartToolStripMenuItem"
        Me.ShowWindowsStartToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ShowWindowsStartToolStripMenuItem.Text = "Show Windows Start"
        '
        'FirewallToolStripMenuItem
        '
        Me.FirewallToolStripMenuItem.Name = "FirewallToolStripMenuItem"
        Me.FirewallToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FirewallToolStripMenuItem.Text = "Firewall"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ServiceTime_lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 429)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 23)
        Me.Panel1.TabIndex = 97
        '
        'ServiceTime_lbl
        '
        Me.ServiceTime_lbl.AutoSize = True
        Me.ServiceTime_lbl.Location = New System.Drawing.Point(5, 5)
        Me.ServiceTime_lbl.Name = "ServiceTime_lbl"
        Me.ServiceTime_lbl.Size = New System.Drawing.Size(39, 13)
        Me.ServiceTime_lbl.TabIndex = 1
        Me.ServiceTime_lbl.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Desktop_pb
        '
        Me.Desktop_pb.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Desktop_pb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Desktop_pb.Location = New System.Drawing.Point(0, 44)
        Me.Desktop_pb.Name = "Desktop_pb"
        Me.Desktop_pb.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.Desktop_pb.Size = New System.Drawing.Size(819, 385)
        Me.Desktop_pb.TabIndex = 99
        '
        'LiveChatPanel
        '
        Me.LiveChatPanel.Location = New System.Drawing.Point(7, 54)
        Me.LiveChatPanel.Name = "LiveChatPanel"
        Me.LiveChatPanel.Size = New System.Drawing.Size(200, 100)
        Me.LiveChatPanel.TabIndex = 101
        Me.LiveChatPanel.Visible = False
        '
        'Server
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 452)
        Me.Controls.Add(Me.LiveChatPanel)
        Me.Controls.Add(Me.Desktop_pb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AllButtonsContainer)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1170, 743)
        Me.MinimumSize = New System.Drawing.Size(469, 339)
        Me.Name = "Server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.EndSessionMenu.ResumeLayout(False)
        Me.AllButtonsContainer.ResumeLayout(False)
        Me.CentreButtonsContainer.ResumeLayout(False)
        Me.SRecordMenu.ResumeLayout(False)
        Me.ExtraMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AllButtonsContainer As System.Windows.Forms.Panel
    Friend WithEvents MainMenu_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents CentreButtonsContainer As System.Windows.Forms.Panel
    Friend WithEvents CurrentScreen_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents FullScreen_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents EndSession_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents Settings_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents LiveChat_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents ScreenRecording_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents FileTransfer_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents EndSessionMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SRecordMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ControlKeyboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowWindowsStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirewallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ServiceTime_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Desktop_pb As System.Windows.Forms.Panel
    Friend WithEvents LiveChatPanel As System.Windows.Forms.Panel
    Friend WithEvents Extra_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents Complete_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
