<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManagementUC
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StaffAdminTxt = New System.Windows.Forms.ComboBox()
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
        Me.StaffIDLbl = New System.Windows.Forms.Label()
        Me.StaffIDTxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UsersCountLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 32)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search by"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"StaffID", "FirstName", "LastName", "Email", "PhoneNO."})
        Me.ComboBox1.Location = New System.Drawing.Point(70, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(319, 20)
        Me.TextBox1.TabIndex = 0
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Enabled = False
        Me.UpdateBtn.Location = New System.Drawing.Point(12, 104)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(719, 23)
        Me.UpdateBtn.TabIndex = 4
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 371)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(782, 209)
        Me.DataGridView1.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveStaffToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 26)
        '
        'RemoveStaffToolStripMenuItem
        '
        Me.RemoveStaffToolStripMenuItem.Name = "RemoveStaffToolStripMenuItem"
        Me.RemoveStaffToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RemoveStaffToolStripMenuItem.Text = "Remove Staff"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel4.Controls.Add(Me.StaffAdminTxt)
        Me.Panel4.Controls.Add(Me.UpdateBtn)
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
        Me.Panel4.Controls.Add(Me.StaffIDLbl)
        Me.Panel4.Controls.Add(Me.StaffIDTxt)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 209)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 140)
        Me.Panel4.TabIndex = 1
        '
        'StaffAdminTxt
        '
        Me.StaffAdminTxt.BackColor = System.Drawing.Color.White
        Me.StaffAdminTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StaffAdminTxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StaffAdminTxt.FormattingEnabled = True
        Me.StaffAdminTxt.Items.AddRange(New Object() {"True", "False"})
        Me.StaffAdminTxt.Location = New System.Drawing.Point(83, 66)
        Me.StaffAdminTxt.Name = "StaffAdminTxt"
        Me.StaffAdminTxt.Size = New System.Drawing.Size(134, 21)
        Me.StaffAdminTxt.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "IsAdmin : "
        '
        'StaffEmailTxt
        '
        Me.StaffEmailTxt.BackColor = System.Drawing.Color.Black
        Me.StaffEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffEmailTxt.ForeColor = System.Drawing.Color.White
        Me.StaffEmailTxt.Location = New System.Drawing.Point(352, 6)
        Me.StaffEmailTxt.Name = "StaffEmailTxt"
        Me.StaffEmailTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffEmailTxt.TabIndex = 23
        '
        'StaffPhoneTxt
        '
        Me.StaffPhoneTxt.BackColor = System.Drawing.Color.Black
        Me.StaffPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffPhoneTxt.ForeColor = System.Drawing.Color.White
        Me.StaffPhoneTxt.Location = New System.Drawing.Point(352, 36)
        Me.StaffPhoneTxt.Name = "StaffPhoneTxt"
        Me.StaffPhoneTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffPhoneTxt.TabIndex = 22
        '
        'StaffPassTxt
        '
        Me.StaffPassTxt.BackColor = System.Drawing.Color.Black
        Me.StaffPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffPassTxt.ForeColor = System.Drawing.Color.White
        Me.StaffPassTxt.Location = New System.Drawing.Point(83, 36)
        Me.StaffPassTxt.Name = "StaffPassTxt"
        Me.StaffPassTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffPassTxt.TabIndex = 21
        '
        'StaffLNTxt
        '
        Me.StaffLNTxt.BackColor = System.Drawing.Color.Black
        Me.StaffLNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffLNTxt.ForeColor = System.Drawing.Color.White
        Me.StaffLNTxt.Location = New System.Drawing.Point(597, 34)
        Me.StaffLNTxt.Name = "StaffLNTxt"
        Me.StaffLNTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffLNTxt.TabIndex = 20
        '
        'StaffFNTxt
        '
        Me.StaffFNTxt.BackColor = System.Drawing.Color.Black
        Me.StaffFNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffFNTxt.ForeColor = System.Drawing.Color.White
        Me.StaffFNTxt.Location = New System.Drawing.Point(597, 8)
        Me.StaffFNTxt.Name = "StaffFNTxt"
        Me.StaffFNTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffFNTxt.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(253, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(253, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "E-mail :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(516, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(516, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First Name :"
        '
        'StaffIDLbl
        '
        Me.StaffIDLbl.AutoSize = True
        Me.StaffIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffIDLbl.ForeColor = System.Drawing.Color.White
        Me.StaffIDLbl.Location = New System.Drawing.Point(9, 6)
        Me.StaffIDLbl.Name = "StaffIDLbl"
        Me.StaffIDLbl.Size = New System.Drawing.Size(52, 15)
        Me.StaffIDLbl.TabIndex = 13
        Me.StaffIDLbl.Text = "Staff ID :"
        '
        'StaffIDTxt
        '
        Me.StaffIDTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StaffIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StaffIDTxt.ForeColor = System.Drawing.Color.White
        Me.StaffIDTxt.Location = New System.Drawing.Point(83, 6)
        Me.StaffIDTxt.Name = "StaffIDTxt"
        Me.StaffIDTxt.ReadOnly = True
        Me.StaffIDTxt.Size = New System.Drawing.Size(134, 20)
        Me.StaffIDTxt.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.UsersCountLbl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 349)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.Panel3.Size = New System.Drawing.Size(782, 22)
        Me.Panel3.TabIndex = 0
        '
        'UsersCountLbl
        '
        Me.UsersCountLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsersCountLbl.ForeColor = System.Drawing.Color.Black
        Me.UsersCountLbl.Location = New System.Drawing.Point(3, 0)
        Me.UsersCountLbl.Name = "UsersCountLbl"
        Me.UsersCountLbl.Size = New System.Drawing.Size(779, 19)
        Me.UsersCountLbl.TabIndex = 0
        Me.UsersCountLbl.Text = "0"
        Me.UsersCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 18)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffManagementUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffManagementUC"
        Me.Size = New System.Drawing.Size(782, 403)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UsersCountLbl As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
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
    Friend WithEvents StaffIDLbl As System.Windows.Forms.Label
    Friend WithEvents StaffIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents StaffAdminTxt As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
