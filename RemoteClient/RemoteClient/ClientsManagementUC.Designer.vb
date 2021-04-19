<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientsManagementUC
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ClientIPTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.ClientEmailTxt = New System.Windows.Forms.TextBox()
        Me.ClientPhoneTxt = New System.Windows.Forms.TextBox()
        Me.ClientPassTxt = New System.Windows.Forms.TextBox()
        Me.ClientLNTxt = New System.Windows.Forms.TextBox()
        Me.ClientFNTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClientIDLbl = New System.Windows.Forms.Label()
        Me.ClientIDTxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UsersCountLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveClientToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'RemoveClientToolStripMenuItem
        '
        Me.RemoveClientToolStripMenuItem.Name = "RemoveClientToolStripMenuItem"
        Me.RemoveClientToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RemoveClientToolStripMenuItem.Text = "Remove Client"
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
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 9)
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
        Me.ComboBox1.Items.AddRange(New Object() {"ClientID", "FirstName", "LastName", "Email", "PhoneNO.", "IPAddress"})
        Me.ComboBox1.Location = New System.Drawing.Point(67, 5)
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
        Me.Panel2.TabIndex = 5
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel4.Controls.Add(Me.ClientIPTxt)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.UpdateBtn)
        Me.Panel4.Controls.Add(Me.ClientEmailTxt)
        Me.Panel4.Controls.Add(Me.ClientPhoneTxt)
        Me.Panel4.Controls.Add(Me.ClientPassTxt)
        Me.Panel4.Controls.Add(Me.ClientLNTxt)
        Me.Panel4.Controls.Add(Me.ClientFNTxt)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ClientIDLbl)
        Me.Panel4.Controls.Add(Me.ClientIDTxt)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 209)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 140)
        Me.Panel4.TabIndex = 1
        '
        'ClientIPTxt
        '
        Me.ClientIPTxt.BackColor = System.Drawing.Color.Black
        Me.ClientIPTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientIPTxt.ForeColor = System.Drawing.Color.White
        Me.ClientIPTxt.Location = New System.Drawing.Point(83, 66)
        Me.ClientIPTxt.Name = "ClientIPTxt"
        Me.ClientIPTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientIPTxt.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "IP Address :"
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
        'ClientEmailTxt
        '
        Me.ClientEmailTxt.BackColor = System.Drawing.Color.Black
        Me.ClientEmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientEmailTxt.ForeColor = System.Drawing.Color.White
        Me.ClientEmailTxt.Location = New System.Drawing.Point(352, 6)
        Me.ClientEmailTxt.Name = "ClientEmailTxt"
        Me.ClientEmailTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientEmailTxt.TabIndex = 23
        '
        'ClientPhoneTxt
        '
        Me.ClientPhoneTxt.BackColor = System.Drawing.Color.Black
        Me.ClientPhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientPhoneTxt.ForeColor = System.Drawing.Color.White
        Me.ClientPhoneTxt.Location = New System.Drawing.Point(352, 36)
        Me.ClientPhoneTxt.Name = "ClientPhoneTxt"
        Me.ClientPhoneTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientPhoneTxt.TabIndex = 22
        '
        'ClientPassTxt
        '
        Me.ClientPassTxt.BackColor = System.Drawing.Color.Black
        Me.ClientPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientPassTxt.ForeColor = System.Drawing.Color.White
        Me.ClientPassTxt.Location = New System.Drawing.Point(83, 36)
        Me.ClientPassTxt.Name = "ClientPassTxt"
        Me.ClientPassTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientPassTxt.TabIndex = 21
        '
        'ClientLNTxt
        '
        Me.ClientLNTxt.BackColor = System.Drawing.Color.Black
        Me.ClientLNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientLNTxt.ForeColor = System.Drawing.Color.White
        Me.ClientLNTxt.Location = New System.Drawing.Point(597, 34)
        Me.ClientLNTxt.Name = "ClientLNTxt"
        Me.ClientLNTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientLNTxt.TabIndex = 20
        '
        'ClientFNTxt
        '
        Me.ClientFNTxt.BackColor = System.Drawing.Color.Black
        Me.ClientFNTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientFNTxt.ForeColor = System.Drawing.Color.White
        Me.ClientFNTxt.Location = New System.Drawing.Point(597, 8)
        Me.ClientFNTxt.Name = "ClientFNTxt"
        Me.ClientFNTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientFNTxt.TabIndex = 19
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
        'ClientIDLbl
        '
        Me.ClientIDLbl.AutoSize = True
        Me.ClientIDLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientIDLbl.ForeColor = System.Drawing.Color.White
        Me.ClientIDLbl.Location = New System.Drawing.Point(9, 6)
        Me.ClientIDLbl.Name = "ClientIDLbl"
        Me.ClientIDLbl.Size = New System.Drawing.Size(59, 15)
        Me.ClientIDLbl.TabIndex = 13
        Me.ClientIDLbl.Text = "Client ID :"
        '
        'ClientIDTxt
        '
        Me.ClientIDTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientIDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientIDTxt.ForeColor = System.Drawing.Color.White
        Me.ClientIDTxt.Location = New System.Drawing.Point(83, 6)
        Me.ClientIDTxt.Name = "ClientIDTxt"
        Me.ClientIDTxt.ReadOnly = True
        Me.ClientIDTxt.Size = New System.Drawing.Size(134, 20)
        Me.ClientIDTxt.TabIndex = 12
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
        'AddClientToolStripMenuItem
        '
        Me.AddClientToolStripMenuItem.Name = "AddClientToolStripMenuItem"
        Me.AddClientToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddClientToolStripMenuItem.Text = "Add Client"
        '
        'ClientsManagementUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClientsManagementUC"
        Me.Size = New System.Drawing.Size(782, 403)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents ClientEmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClientPhoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClientPassTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClientLNTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClientFNTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClientIDLbl As System.Windows.Forms.Label
    Friend WithEvents ClientIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UsersCountLbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ClientIPTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AddClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
