<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialFlatButton1 = New RemoteClient.MaterialFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.RemoteClient.My.Resources.Resources.User
        Me.PictureBox1.Location = New System.Drawing.Point(280, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(280, 268)
        Me.MaterialFlatButton1.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(183, 29)
        Me.MaterialFlatButton1.TabIndex = 5
        Me.MaterialFlatButton1.Text = "Log Out"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'DashboardPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DashboardPage"
        Me.Padding = New System.Windows.Forms.Padding(280, 0, 280, 0)
        Me.Size = New System.Drawing.Size(743, 427)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaterialFlatButton1 As RemoteClient.MaterialFlatButton

End Class
