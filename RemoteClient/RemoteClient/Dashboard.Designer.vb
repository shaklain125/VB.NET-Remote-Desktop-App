<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Settings_btn = New RemoteClient.MaterialFlatButton()
        Me.ScreenRecord_btn = New RemoteClient.MaterialFlatButton()
        Me.CNotify = New System.Windows.Forms.Label()
        Me.Computers_btn = New RemoteClient.MaterialFlatButton()
        Me.JobDeclined_btn = New RemoteClient.MaterialFlatButton()
        Me.JPNotify = New System.Windows.Forms.Label()
        Me.JobsCompleted_btn = New RemoteClient.MaterialFlatButton()
        Me.JobsPending_btn = New RemoteClient.MaterialFlatButton()
        Me.Dashboard_btn = New RemoteClient.MaterialFlatButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DashboardPanel1 = New RemoteClient.DashboardPanel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Settings_btn)
        Me.Panel2.Controls.Add(Me.ScreenRecord_btn)
        Me.Panel2.Controls.Add(Me.CNotify)
        Me.Panel2.Controls.Add(Me.Computers_btn)
        Me.Panel2.Controls.Add(Me.JobDeclined_btn)
        Me.Panel2.Controls.Add(Me.JPNotify)
        Me.Panel2.Controls.Add(Me.JobsCompleted_btn)
        Me.Panel2.Controls.Add(Me.JobsPending_btn)
        Me.Panel2.Controls.Add(Me.Dashboard_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(65, 427)
        Me.Panel2.TabIndex = 2
        '
        'Settings_btn
        '
        Me.Settings_btn.AutoSize = True
        Me.Settings_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Settings_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Settings_btn.FlatAppearance.BorderSize = 0
        Me.Settings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Settings_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_btn.Font = New System.Drawing.Font("Calibri", 28.0!, System.Drawing.FontStyle.Bold)
        Me.Settings_btn.Location = New System.Drawing.Point(0, 354)
        Me.Settings_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.Settings_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Settings_btn.Name = "Settings_btn"
        Me.Settings_btn.Size = New System.Drawing.Size(65, 59)
        Me.Settings_btn.TabIndex = 23
        Me.Settings_btn.Text = "⚙"
        Me.ToolTip1.SetToolTip(Me.Settings_btn, "Settings")
        Me.Settings_btn.UseVisualStyleBackColor = False
        '
        'ScreenRecord_btn
        '
        Me.ScreenRecord_btn.AutoSize = True
        Me.ScreenRecord_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ScreenRecord_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ScreenRecord_btn.FlatAppearance.BorderSize = 0
        Me.ScreenRecord_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ScreenRecord_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ScreenRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenRecord_btn.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenRecord_btn.Location = New System.Drawing.Point(0, 295)
        Me.ScreenRecord_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.ScreenRecord_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.ScreenRecord_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.ScreenRecord_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.ScreenRecord_btn.Name = "ScreenRecord_btn"
        Me.ScreenRecord_btn.Size = New System.Drawing.Size(65, 59)
        Me.ScreenRecord_btn.TabIndex = 22
        Me.ScreenRecord_btn.Text = "▶"
        Me.ToolTip1.SetToolTip(Me.ScreenRecord_btn, "Screen Records")
        Me.ScreenRecord_btn.UseVisualStyleBackColor = False
        Me.ScreenRecord_btn.Visible = False
        '
        'CNotify
        '
        Me.CNotify.AutoSize = True
        Me.CNotify.BackColor = System.Drawing.Color.Black
        Me.CNotify.Enabled = False
        Me.CNotify.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNotify.ForeColor = System.Drawing.Color.White
        Me.CNotify.Location = New System.Drawing.Point(1, 236)
        Me.CNotify.Name = "CNotify"
        Me.CNotify.Size = New System.Drawing.Size(22, 18)
        Me.CNotify.TabIndex = 21
        Me.CNotify.Text = "11"
        Me.CNotify.Visible = False
        '
        'Computers_btn
        '
        Me.Computers_btn.AutoSize = True
        Me.Computers_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Computers_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Computers_btn.FlatAppearance.BorderSize = 0
        Me.Computers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Computers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Computers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Computers_btn.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.Computers_btn.Location = New System.Drawing.Point(0, 236)
        Me.Computers_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.Computers_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Computers_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Computers_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Computers_btn.Name = "Computers_btn"
        Me.Computers_btn.Size = New System.Drawing.Size(65, 59)
        Me.Computers_btn.TabIndex = 19
        Me.Computers_btn.Text = "💻"
        Me.ToolTip1.SetToolTip(Me.Computers_btn, "Computers")
        Me.Computers_btn.UseVisualStyleBackColor = False
        '
        'JobDeclined_btn
        '
        Me.JobDeclined_btn.AutoSize = True
        Me.JobDeclined_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.JobDeclined_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.JobDeclined_btn.FlatAppearance.BorderSize = 0
        Me.JobDeclined_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.JobDeclined_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.JobDeclined_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JobDeclined_btn.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.JobDeclined_btn.ForeColor = System.Drawing.Color.Black
        Me.JobDeclined_btn.Location = New System.Drawing.Point(0, 177)
        Me.JobDeclined_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.JobDeclined_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.JobDeclined_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.JobDeclined_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.JobDeclined_btn.Name = "JobDeclined_btn"
        Me.JobDeclined_btn.Size = New System.Drawing.Size(65, 59)
        Me.JobDeclined_btn.TabIndex = 18
        Me.JobDeclined_btn.Text = "☒"
        Me.ToolTip1.SetToolTip(Me.JobDeclined_btn, "Jobs Declined")
        Me.JobDeclined_btn.UseVisualStyleBackColor = False
        '
        'JPNotify
        '
        Me.JPNotify.AutoSize = True
        Me.JPNotify.BackColor = System.Drawing.Color.Black
        Me.JPNotify.Enabled = False
        Me.JPNotify.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JPNotify.ForeColor = System.Drawing.Color.White
        Me.JPNotify.Location = New System.Drawing.Point(1, 59)
        Me.JPNotify.Name = "JPNotify"
        Me.JPNotify.Size = New System.Drawing.Size(22, 18)
        Me.JPNotify.TabIndex = 15
        Me.JPNotify.Text = "11"
        Me.JPNotify.Visible = False
        '
        'JobsCompleted_btn
        '
        Me.JobsCompleted_btn.AutoSize = True
        Me.JobsCompleted_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.JobsCompleted_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.JobsCompleted_btn.FlatAppearance.BorderSize = 0
        Me.JobsCompleted_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.JobsCompleted_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.JobsCompleted_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JobsCompleted_btn.Font = New System.Drawing.Font("Calibri", 26.0!)
        Me.JobsCompleted_btn.ForeColor = System.Drawing.Color.Black
        Me.JobsCompleted_btn.Location = New System.Drawing.Point(0, 118)
        Me.JobsCompleted_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.JobsCompleted_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.JobsCompleted_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.JobsCompleted_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.JobsCompleted_btn.Name = "JobsCompleted_btn"
        Me.JobsCompleted_btn.Size = New System.Drawing.Size(65, 59)
        Me.JobsCompleted_btn.TabIndex = 9
        Me.JobsCompleted_btn.Text = "☑"
        Me.ToolTip1.SetToolTip(Me.JobsCompleted_btn, "Jobs Completed")
        Me.JobsCompleted_btn.UseVisualStyleBackColor = False
        '
        'JobsPending_btn
        '
        Me.JobsPending_btn.AutoSize = True
        Me.JobsPending_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.JobsPending_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.JobsPending_btn.FlatAppearance.BorderSize = 0
        Me.JobsPending_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.JobsPending_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.JobsPending_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JobsPending_btn.Font = New System.Drawing.Font("Calibri", 30.0!)
        Me.JobsPending_btn.Location = New System.Drawing.Point(0, 59)
        Me.JobsPending_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.JobsPending_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.JobsPending_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.JobsPending_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.JobsPending_btn.Name = "JobsPending_btn"
        Me.JobsPending_btn.Size = New System.Drawing.Size(65, 59)
        Me.JobsPending_btn.TabIndex = 8
        Me.JobsPending_btn.Text = "⌛"
        Me.ToolTip1.SetToolTip(Me.JobsPending_btn, "Jobs Pending")
        Me.JobsPending_btn.UseVisualStyleBackColor = False
        '
        'Dashboard_btn
        '
        Me.Dashboard_btn.AutoSize = True
        Me.Dashboard_btn.BackColor = System.Drawing.Color.DarkGray
        Me.Dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard_btn.FlatAppearance.BorderSize = 0
        Me.Dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlanchedAlmond
        Me.Dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond
        Me.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard_btn.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_btn.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.Dashboard_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Dashboard_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Dashboard_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Dashboard_btn.Name = "Dashboard_btn"
        Me.Dashboard_btn.Size = New System.Drawing.Size(65, 59)
        Me.Dashboard_btn.TabIndex = 7
        Me.Dashboard_btn.Text = "☰"
        Me.Dashboard_btn.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'DashboardPanel1
        '
        Me.DashboardPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardPanel1.Location = New System.Drawing.Point(65, 0)
        Me.DashboardPanel1.Name = "DashboardPanel1"
        Me.DashboardPanel1.Size = New System.Drawing.Size(743, 427)
        Me.DashboardPanel1.TabIndex = 3
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 427)
        Me.Controls.Add(Me.DashboardPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents JobsCompleted_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents JobsPending_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents Dashboard_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents JPNotify As System.Windows.Forms.Label
    Friend WithEvents DashboardPanel1 As RemoteClient.DashboardPanel
    Friend WithEvents CNotify As System.Windows.Forms.Label
    Friend WithEvents Computers_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents JobDeclined_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ScreenRecord_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents Settings_btn As RemoteClient.MaterialFlatButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
