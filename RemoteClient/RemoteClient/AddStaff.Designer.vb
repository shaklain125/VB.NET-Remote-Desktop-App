<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StaffAdminTxt = New System.Windows.Forms.ComboBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StaffEmailTxt = New System.Windows.Forms.TextBox()
        Me.StaffPhoneTxt = New System.Windows.Forms.TextBox()
        Me.StaffPassTxt = New System.Windows.Forms.TextBox()
        Me.StaffLNTxt = New System.Windows.Forms.TextBox()
        Me.StaffFNTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.StaffAdminTxt)
        Me.Panel4.Controls.Add(Me.AddBtn)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.StaffEmailTxt)
        Me.Panel4.Controls.Add(Me.StaffPhoneTxt)
        Me.Panel4.Controls.Add(Me.StaffPassTxt)
        Me.Panel4.Controls.Add(Me.StaffLNTxt)
        Me.Panel4.Controls.Add(Me.StaffFNTxt)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(789, 127)
        Me.Panel4.TabIndex = 2
        '
        'StaffAdminTxt
        '
        Me.StaffAdminTxt.BackColor = System.Drawing.Color.White
        Me.StaffAdminTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StaffAdminTxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StaffAdminTxt.FormattingEnabled = True
        Me.StaffAdminTxt.Items.AddRange(New Object() {"True", "False"})
        Me.StaffAdminTxt.Location = New System.Drawing.Point(617, 48)
        Me.StaffAdminTxt.Name = "StaffAdminTxt"
        Me.StaffAdminTxt.Size = New System.Drawing.Size(134, 21)
        Me.StaffAdminTxt.TabIndex = 25
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(29, 83)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(722, 28)
        Me.AddBtn.TabIndex = 4
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(543, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "IsAdmin : "
        '
        'StaffEmailTxt
        '
        Me.StaffEmailTxt.BackColor = System.Drawing.Color.Black
        Me.StaffEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffEmailTxt.ForeColor = System.Drawing.Color.White
        Me.StaffEmailTxt.Location = New System.Drawing.Point(372, 18)
        Me.StaffEmailTxt.Name = "StaffEmailTxt"
        Me.StaffEmailTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffEmailTxt.TabIndex = 23
        '
        'StaffPhoneTxt
        '
        Me.StaffPhoneTxt.BackColor = System.Drawing.Color.Black
        Me.StaffPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffPhoneTxt.ForeColor = System.Drawing.Color.White
        Me.StaffPhoneTxt.Location = New System.Drawing.Point(372, 48)
        Me.StaffPhoneTxt.Name = "StaffPhoneTxt"
        Me.StaffPhoneTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffPhoneTxt.TabIndex = 22
        '
        'StaffPassTxt
        '
        Me.StaffPassTxt.BackColor = System.Drawing.Color.Black
        Me.StaffPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffPassTxt.ForeColor = System.Drawing.Color.White
        Me.StaffPassTxt.Location = New System.Drawing.Point(617, 18)
        Me.StaffPassTxt.Name = "StaffPassTxt"
        Me.StaffPassTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffPassTxt.TabIndex = 21
        '
        'StaffLNTxt
        '
        Me.StaffLNTxt.BackColor = System.Drawing.Color.Black
        Me.StaffLNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffLNTxt.ForeColor = System.Drawing.Color.White
        Me.StaffLNTxt.Location = New System.Drawing.Point(110, 43)
        Me.StaffLNTxt.Name = "StaffLNTxt"
        Me.StaffLNTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffLNTxt.TabIndex = 20
        '
        'StaffFNTxt
        '
        Me.StaffFNTxt.BackColor = System.Drawing.Color.Black
        Me.StaffFNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffFNTxt.ForeColor = System.Drawing.Color.White
        Me.StaffFNTxt.Location = New System.Drawing.Point(110, 17)
        Me.StaffFNTxt.Name = "StaffFNTxt"
        Me.StaffFNTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffFNTxt.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(543, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(273, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "E-mail :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First Name :"
        '
        'AddStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Name = "AddStaff"
        Me.Size = New System.Drawing.Size(789, 127)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents StaffAdminTxt As System.Windows.Forms.ComboBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StaffEmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents StaffPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents StaffPassTxt As System.Windows.Forms.TextBox
    Friend WithEvents StaffLNTxt As System.Windows.Forms.TextBox
    Friend WithEvents StaffFNTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
