<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoPlayer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton4 = New RemoteClient.MaterialFlatButton()
        Me.MaterialFlatButton3 = New RemoteClient.MaterialFlatButton()
        Me.MaterialFlatButton2 = New RemoteClient.MaterialFlatButton()
        Me.MaterialFlatButton1 = New RemoteClient.MaterialFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialFlatButton5 = New RemoteClient.MaterialFlatButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Duration_trackb = New System.Windows.Forms.TrackBar()
        Me.Panel1.SuspendLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Duration_trackb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Volume)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 371)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(200, 0, 200, 0)
        Me.Panel1.Size = New System.Drawing.Size(590, 40)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "🔊"
        '
        'Volume
        '
        Me.Volume.AutoSize = False
        Me.Volume.BackColor = System.Drawing.Color.White
        Me.Volume.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Volume.Location = New System.Drawing.Point(45, 14)
        Me.Volume.Maximum = 100
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(113, 18)
        Me.Volume.TabIndex = 4
        Me.Volume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Volume.Value = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.MaterialFlatButton4)
        Me.Panel2.Controls.Add(Me.MaterialFlatButton3)
        Me.Panel2.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel2.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 40)
        Me.Panel2.TabIndex = 0
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton4.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(145, 0)
        Me.MaterialFlatButton4.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton4.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton4.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(45, 40)
        Me.MaterialFlatButton4.TabIndex = 3
        Me.MaterialFlatButton4.Text = "◼ "
        Me.ToolTip1.SetToolTip(Me.MaterialFlatButton4, "Stop")
        Me.MaterialFlatButton4.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton3.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton3.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(95, 0)
        Me.MaterialFlatButton3.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton3.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton3.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(50, 40)
        Me.MaterialFlatButton3.TabIndex = 2
        Me.MaterialFlatButton3.Text = "⏭"
        Me.ToolTip1.SetToolTip(Me.MaterialFlatButton3, "Fast Forward")
        Me.MaterialFlatButton3.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton2.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(50, 0)
        Me.MaterialFlatButton2.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(45, 40)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "❚❚"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton1.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton1.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(50, 40)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "⏮"
        Me.ToolTip1.SetToolTip(Me.MaterialFlatButton1, "Fast Reverse")
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Inverse Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Current Duration"
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Volume %"
        Me.Label4.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'MaterialFlatButton5
        '
        Me.MaterialFlatButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton5.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton5.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton5.Location = New System.Drawing.Point(535, 0)
        Me.MaterialFlatButton5.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton5.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton5.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton5.Name = "MaterialFlatButton5"
        Me.MaterialFlatButton5.Size = New System.Drawing.Size(55, 47)
        Me.MaterialFlatButton5.TabIndex = 11
        Me.MaterialFlatButton5.Text = "➤"
        Me.ToolTip1.SetToolTip(Me.MaterialFlatButton5, "Send To Client")
        Me.MaterialFlatButton5.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(590, 371)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Duration_trackb)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 347)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(590, 24)
        Me.Panel3.TabIndex = 12
        '
        'Duration_trackb
        '
        Me.Duration_trackb.AutoSize = False
        Me.Duration_trackb.BackColor = System.Drawing.Color.White
        Me.Duration_trackb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Duration_trackb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Duration_trackb.LargeChange = 1
        Me.Duration_trackb.Location = New System.Drawing.Point(99, 3)
        Me.Duration_trackb.Name = "Duration_trackb"
        Me.Duration_trackb.Size = New System.Drawing.Size(391, 18)
        Me.Duration_trackb.TabIndex = 11
        Me.Duration_trackb.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'VideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 411)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MaterialFlatButton5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(606, 450)
        Me.Name = "VideoPlayer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "player"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Duration_trackb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Volume As System.Windows.Forms.TrackBar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton4 As RemoteClient.MaterialFlatButton
    Friend WithEvents MaterialFlatButton3 As RemoteClient.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As RemoteClient.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As RemoteClient.MaterialFlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents MaterialFlatButton5 As RemoteClient.MaterialFlatButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Duration_trackb As System.Windows.Forms.TrackBar
End Class
