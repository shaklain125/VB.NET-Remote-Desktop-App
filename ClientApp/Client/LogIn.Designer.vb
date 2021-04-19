<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_SignUp = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_LogIn = New System.Windows.Forms.Button()
        Me.lbl_ForgotPass = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_IDorEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "db_connection_status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Status :"
        '
        'lbl_SignUp
        '
        Me.lbl_SignUp.AutoSize = True
        Me.lbl_SignUp.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SignUp.LinkColor = System.Drawing.Color.Green
        Me.lbl_SignUp.Location = New System.Drawing.Point(220, 262)
        Me.lbl_SignUp.Name = "lbl_SignUp"
        Me.lbl_SignUp.Size = New System.Drawing.Size(48, 14)
        Me.lbl_SignUp.TabIndex = 27
        Me.lbl_SignUp.TabStop = True
        Me.lbl_SignUp.Text = "Sign Up"
        Me.lbl_SignUp.VisitedLinkColor = System.Drawing.Color.DarkGreen
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(189, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Not an existing user?"
        '
        'btn_LogIn
        '
        Me.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogIn.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogIn.Location = New System.Drawing.Point(298, 208)
        Me.btn_LogIn.Name = "btn_LogIn"
        Me.btn_LogIn.Size = New System.Drawing.Size(54, 27)
        Me.btn_LogIn.TabIndex = 25
        Me.btn_LogIn.Text = "Log In"
        Me.btn_LogIn.UseVisualStyleBackColor = True
        '
        'lbl_ForgotPass
        '
        Me.lbl_ForgotPass.AutoSize = True
        Me.lbl_ForgotPass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ForgotPass.LinkColor = System.Drawing.Color.Red
        Me.lbl_ForgotPass.Location = New System.Drawing.Point(129, 194)
        Me.lbl_ForgotPass.Name = "lbl_ForgotPass"
        Me.lbl_ForgotPass.Size = New System.Drawing.Size(90, 13)
        Me.lbl_ForgotPass.TabIndex = 24
        Me.lbl_ForgotPass.TabStop = True
        Me.lbl_ForgotPass.Text = "Forgot Password?"
        Me.lbl_ForgotPass.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(128, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(128, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID or Email"
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(131, 164)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(221, 21)
        Me.tb_password.TabIndex = 21
        Me.tb_password.UseSystemPasswordChar = True
        '
        'tb_IDorEmail
        '
        Me.tb_IDorEmail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_IDorEmail.Location = New System.Drawing.Point(131, 110)
        Me.tb_IDorEmail.Name = "tb_IDorEmail"
        Me.tb_IDorEmail.Size = New System.Drawing.Size(221, 23)
        Me.tb_IDorEmail.TabIndex = 20
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_SignUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_LogIn)
        Me.Controls.Add(Me.lbl_ForgotPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_IDorEmail)
        Me.Name = "LogIn"
        Me.Size = New System.Drawing.Size(473, 401)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_SignUp As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_LogIn As System.Windows.Forms.Button
    Friend WithEvents lbl_ForgotPass As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_password As System.Windows.Forms.TextBox
    Friend WithEvents tb_IDorEmail As System.Windows.Forms.TextBox

End Class
