<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitingForReply
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Continue_btn = New Client.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(5, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(506, 119)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Your job has been accepted. Waiting for a member of staff to aid with your comput" & _
    "er issues. Please keep your machine awake as it enables remote connections."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Silver
        Me.TextBox2.Location = New System.Drawing.Point(5, 124)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(506, 123)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "A message sent by a technician will be displayed here."
        '
        'Continue_btn
        '
        Me.Continue_btn.BackColor = System.Drawing.Color.White
        Me.Continue_btn.FlatAppearance.BorderSize = 0
        Me.Continue_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Continue_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Continue_btn.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Continue_btn.ForeColor = System.Drawing.Color.Black
        Me.Continue_btn.Location = New System.Drawing.Point(418, 216)
        Me.Continue_btn.MouseDownForeColor = System.Drawing.Color.Empty
        Me.Continue_btn.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.Continue_btn.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.Continue_btn.Name = "Continue_btn"
        Me.Continue_btn.Size = New System.Drawing.Size(71, 28)
        Me.Continue_btn.TabIndex = 4
        Me.Continue_btn.Text = "Continue"
        Me.Continue_btn.UseVisualStyleBackColor = False
        '
        'WaitingForReply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(511, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Continue_btn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WaitingForReply"
        Me.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RDC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Continue_btn As Client.MaterialFlatButton
End Class
