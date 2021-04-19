<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientSettings
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
        Me.ClientSettingsTitle = New System.Windows.Forms.Panel()
        Me.ControlBox1 = New Client.ControlBox()
        Me.MinimiseControl1 = New Client.MinimiseControl()
        Me.RestoreControl1 = New Client.RestoreControl()
        Me.CloseControl1 = New Client.CloseControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClientSettingsMenu = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton4 = New Client.MaterialFlatButton()
        Me.MaterialFlatButton3 = New Client.MaterialFlatButton()
        Me.MaterialFlatButton2 = New Client.MaterialFlatButton()
        Me.MaterialFlatButton1 = New Client.MaterialFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DisplayInfo1 = New Client.DisplayInfo()
        Me.ClientSettingsTitle.SuspendLayout()
        Me.ControlBox1.SuspendLayout()
        Me.ClientSettingsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientSettingsTitle
        '
        Me.ClientSettingsTitle.BackColor = System.Drawing.Color.White
        Me.ClientSettingsTitle.Controls.Add(Me.ControlBox1)
        Me.ClientSettingsTitle.Controls.Add(Me.Label1)
        Me.ClientSettingsTitle.Controls.Add(Me.Panel1)
        Me.ClientSettingsTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClientSettingsTitle.Location = New System.Drawing.Point(1, 1)
        Me.ClientSettingsTitle.Name = "ClientSettingsTitle"
        Me.ClientSettingsTitle.Size = New System.Drawing.Size(555, 58)
        Me.ClientSettingsTitle.TabIndex = 1
        '
        'ControlBox1
        '
        Me.ControlBox1.Controls.Add(Me.MinimiseControl1)
        Me.ControlBox1.Controls.Add(Me.RestoreControl1)
        Me.ControlBox1.Controls.Add(Me.CloseControl1)
        Me.ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ControlBox1.Location = New System.Drawing.Point(403, 0)
        Me.ControlBox1.Name = "ControlBox1"
        Me.ControlBox1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.ControlBox1.Size = New System.Drawing.Size(152, 58)
        Me.ControlBox1.TabIndex = 2
        '
        'MinimiseControl1
        '
        Me.MinimiseControl1.AutoSize = True
        Me.MinimiseControl1.BackColor = System.Drawing.Color.White
        Me.MinimiseControl1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MinimiseControl1.ForeColor = System.Drawing.Color.Black
        Me.MinimiseControl1.Location = New System.Drawing.Point(60, 3)
        Me.MinimiseControl1.MouseHoverColor = System.Drawing.Color.Gray
        Me.MinimiseControl1.MouseLeaveColor = System.Drawing.Color.Black
        Me.MinimiseControl1.Name = "MinimiseControl1"
        Me.MinimiseControl1.Size = New System.Drawing.Size(17, 19)
        Me.MinimiseControl1.TabIndex = 2
        Me.MinimiseControl1.Text = "_"
        Me.MinimiseControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RestoreControl1
        '
        Me.RestoreControl1.AutoSize = True
        Me.RestoreControl1.BackColor = System.Drawing.Color.White
        Me.RestoreControl1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.RestoreControl1.ForeColor = System.Drawing.Color.Black
        Me.RestoreControl1.Location = New System.Drawing.Point(93, 1)
        Me.RestoreControl1.MouseHoverColor = System.Drawing.Color.Gray
        Me.RestoreControl1.MouseLeaveColor = System.Drawing.Color.Black
        Me.RestoreControl1.Name = "RestoreControl1"
        Me.RestoreControl1.Size = New System.Drawing.Size(22, 24)
        Me.RestoreControl1.TabIndex = 1
        Me.RestoreControl1.Text = "□"
        Me.RestoreControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseControl1
        '
        Me.CloseControl1.AutoSize = True
        Me.CloseControl1.BackColor = System.Drawing.Color.White
        Me.CloseControl1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.CloseControl1.ForeColor = System.Drawing.Color.Black
        Me.CloseControl1.Location = New System.Drawing.Point(128, 5)
        Me.CloseControl1.MouseHoverColor = System.Drawing.Color.Gray
        Me.CloseControl1.MouseLeaveColor = System.Drawing.Color.Black
        Me.CloseControl1.Name = "CloseControl1"
        Me.CloseControl1.Size = New System.Drawing.Size(17, 19)
        Me.CloseControl1.TabIndex = 0
        Me.CloseControl1.Text = "X"
        Me.CloseControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PageTitle"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 58)
        Me.Panel1.TabIndex = 0
        '
        'ClientSettingsMenu
        '
        Me.ClientSettingsMenu.BackColor = System.Drawing.Color.White
        Me.ClientSettingsMenu.Controls.Add(Me.MaterialFlatButton4)
        Me.ClientSettingsMenu.Controls.Add(Me.MaterialFlatButton3)
        Me.ClientSettingsMenu.Controls.Add(Me.MaterialFlatButton2)
        Me.ClientSettingsMenu.Controls.Add(Me.MaterialFlatButton1)
        Me.ClientSettingsMenu.Controls.Add(Me.Panel3)
        Me.ClientSettingsMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.ClientSettingsMenu.Location = New System.Drawing.Point(1, 59)
        Me.ClientSettingsMenu.Name = "ClientSettingsMenu"
        Me.ClientSettingsMenu.Size = New System.Drawing.Size(138, 376)
        Me.ClientSettingsMenu.TabIndex = 2
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialFlatButton4.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(0, 111)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton4.MouseDownForeColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.MouseHoverForeColor = System.Drawing.Color.DarkGray
        Me.MaterialFlatButton4.MouseLeaveForeColor = System.Drawing.Color.Black
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(138, 37)
        Me.MaterialFlatButton4.TabIndex = 14
        Me.MaterialFlatButton4.Text = "Change Full Name"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialFlatButton3.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(0, 74)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton3.MouseDownForeColor = System.Drawing.Color.White
        Me.MaterialFlatButton3.MouseHoverForeColor = System.Drawing.Color.DarkGray
        Me.MaterialFlatButton3.MouseLeaveForeColor = System.Drawing.Color.Black
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(138, 37)
        Me.MaterialFlatButton3.TabIndex = 13
        Me.MaterialFlatButton3.Text = "Change Password"
        Me.MaterialFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton3.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialFlatButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialFlatButton2.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(0, 37)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton2.MouseDownForeColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.MouseHoverForeColor = System.Drawing.Color.DarkGray
        Me.MaterialFlatButton2.MouseLeaveForeColor = System.Drawing.Color.Black
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(138, 37)
        Me.MaterialFlatButton2.TabIndex = 12
        Me.MaterialFlatButton2.Text = "Change Email"
        Me.MaterialFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton2.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialFlatButton1.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton1.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(138, 37)
        Me.MaterialFlatButton1.TabIndex = 11
        Me.MaterialFlatButton1.Text = "Overview"
        Me.MaterialFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(138, 111)
        Me.Panel3.TabIndex = 0
        '
        'DisplayInfo1
        '
        Me.DisplayInfo1.BackColor = System.Drawing.Color.Black
        Me.DisplayInfo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayInfo1.Location = New System.Drawing.Point(139, 59)
        Me.DisplayInfo1.Name = "DisplayInfo1"
        Me.DisplayInfo1.Size = New System.Drawing.Size(417, 376)
        Me.DisplayInfo1.TabIndex = 3
        '
        'ClientSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(557, 436)
        Me.Controls.Add(Me.DisplayInfo1)
        Me.Controls.Add(Me.ClientSettingsMenu)
        Me.Controls.Add(Me.ClientSettingsTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientSettings"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientSettings"
        Me.TopMost = True
        Me.ClientSettingsTitle.ResumeLayout(False)
        Me.ClientSettingsTitle.PerformLayout()
        Me.ControlBox1.ResumeLayout(False)
        Me.ControlBox1.PerformLayout()
        Me.ClientSettingsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClientSettingsTitle As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ClientSettingsMenu As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton4 As Client.MaterialFlatButton
    Friend WithEvents MaterialFlatButton3 As Client.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As Client.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As Client.MaterialFlatButton
    Friend WithEvents DisplayInfo1 As Client.DisplayInfo
    Friend WithEvents ControlBox1 As Client.ControlBox
    Friend WithEvents RestoreControl1 As Client.RestoreControl
    Friend WithEvents CloseControl1 As Client.CloseControl
    Friend WithEvents MinimiseControl1 As Client.MinimiseControl
End Class
