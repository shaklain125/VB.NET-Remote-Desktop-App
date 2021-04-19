<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffSignUp
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
        Me.cb_MailService = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_re_enterPass = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_MobileNo = New System.Windows.Forms.TextBox()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_LastName = New System.Windows.Forms.TextBox()
        Me.tb_FirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cb_MailService
        '
        Me.cb_MailService.DropDownWidth = 110
        Me.cb_MailService.FormattingEnabled = True
        Me.cb_MailService.Items.AddRange(New Object() {"gmail.com", "hotmail.com", "hotmail.co.uk", "icloud.com", "yahoo.com", "other - Please Specify"})
        Me.cb_MailService.Location = New System.Drawing.Point(160, 242)
        Me.cb_MailService.Name = "cb_MailService"
        Me.cb_MailService.Size = New System.Drawing.Size(80, 21)
        Me.cb_MailService.TabIndex = 45
        Me.cb_MailService.Text = "Select Mail"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(272, 269)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "                     "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(272, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "                     "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(271, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "                     "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "                     "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "                              "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "                         "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 29)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Registration"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Complete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_re_enterPass
        '
        Me.tb_re_enterPass.Location = New System.Drawing.Point(275, 242)
        Me.tb_re_enterPass.Name = "tb_re_enterPass"
        Me.tb_re_enterPass.Size = New System.Drawing.Size(195, 20)
        Me.tb_re_enterPass.TabIndex = 34
        Me.tb_re_enterPass.UseSystemPasswordChar = True
        '
        'tb_Password
        '
        Me.tb_Password.Location = New System.Drawing.Point(275, 164)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.Size = New System.Drawing.Size(195, 20)
        Me.tb_Password.TabIndex = 33
        Me.tb_Password.UseSystemPasswordChar = True
        '
        'tb_MobileNo
        '
        Me.tb_MobileNo.Location = New System.Drawing.Point(274, 93)
        Me.tb_MobileNo.Name = "tb_MobileNo"
        Me.tb_MobileNo.Size = New System.Drawing.Size(195, 20)
        Me.tb_MobileNo.TabIndex = 32
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(41, 242)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(95, 20)
        Me.tb_Email.TabIndex = 31
        '
        'tb_LastName
        '
        Me.tb_LastName.Location = New System.Drawing.Point(38, 167)
        Me.tb_LastName.Name = "tb_LastName"
        Me.tb_LastName.Size = New System.Drawing.Size(195, 20)
        Me.tb_LastName.TabIndex = 30
        '
        'tb_FirstName
        '
        Me.tb_FirstName.Location = New System.Drawing.Point(38, 96)
        Me.tb_FirstName.Name = "tb_FirstName"
        Me.tb_FirstName.Size = New System.Drawing.Size(195, 20)
        Me.tb_FirstName.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Mobile No.*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Confirm Password *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Password *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "E-Mail *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Last Name *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "First Name *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(135, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(1)
        Me.Label15.Size = New System.Drawing.Size(26, 20)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "@"
        '
        'StaffSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 347)
        Me.Controls.Add(Me.cb_MailService)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_re_enterPass)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_MobileNo)
        Me.Controls.Add(Me.tb_Email)
        Me.Controls.Add(Me.tb_LastName)
        Me.Controls.Add(Me.tb_FirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Name = "StaffSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffSignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_MailService As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tb_re_enterPass As System.Windows.Forms.TextBox
    Friend WithEvents tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents tb_MobileNo As System.Windows.Forms.TextBox
    Friend WithEvents tb_Email As System.Windows.Forms.TextBox
    Friend WithEvents tb_LastName As System.Windows.Forms.TextBox
    Friend WithEvents tb_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
