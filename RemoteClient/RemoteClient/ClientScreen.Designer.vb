<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientScreen
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
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MaterialFlatButton1 = New RemoteClient.MaterialFlatButton()
        Me.tbl_ConnStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_ConnStatus = New System.Windows.Forms.Label()
        Me.theImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbl_ConnStatus.SuspendLayout()
        CType(Me.theImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.FlatAppearance.BorderSize = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialFlatButton1.ForeColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton1.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseHoverForeColor = System.Drawing.Color.Gray
        Me.MaterialFlatButton1.MouseLeaveForeColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(27, 27)
        Me.MaterialFlatButton1.TabIndex = 97
        Me.MaterialFlatButton1.Text = "╳"
        Me.toolTip1.SetToolTip(Me.MaterialFlatButton1, "Exit Full Screen")
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'tbl_ConnStatus
        '
        Me.tbl_ConnStatus.BackColor = System.Drawing.Color.Black
        Me.tbl_ConnStatus.ColumnCount = 1
        Me.tbl_ConnStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbl_ConnStatus.Controls.Add(Me.lbl_ConnStatus, 0, 0)
        Me.tbl_ConnStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl_ConnStatus.Location = New System.Drawing.Point(0, 0)
        Me.tbl_ConnStatus.Name = "tbl_ConnStatus"
        Me.tbl_ConnStatus.RowCount = 1
        Me.tbl_ConnStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbl_ConnStatus.Size = New System.Drawing.Size(749, 452)
        Me.tbl_ConnStatus.TabIndex = 95
        '
        'lbl_ConnStatus
        '
        Me.lbl_ConnStatus.BackColor = System.Drawing.Color.Black
        Me.lbl_ConnStatus.ForeColor = System.Drawing.Color.White
        Me.lbl_ConnStatus.Location = New System.Drawing.Point(3, 0)
        Me.lbl_ConnStatus.Name = "lbl_ConnStatus"
        Me.lbl_ConnStatus.Size = New System.Drawing.Size(743, 452)
        Me.lbl_ConnStatus.TabIndex = 94
        Me.lbl_ConnStatus.Text = "Connection Status"
        Me.lbl_ConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'theImage
        '
        Me.theImage.BackColor = System.Drawing.Color.Black
        Me.theImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.theImage.Location = New System.Drawing.Point(0, 0)
        Me.theImage.Margin = New System.Windows.Forms.Padding(0)
        Me.theImage.Name = "theImage"
        Me.theImage.Size = New System.Drawing.Size(749, 452)
        Me.theImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.theImage.TabIndex = 96
        Me.theImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(634, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 14)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "⏺ Recording Started"
        Me.Label1.Visible = False
        '
        'ClientScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.tbl_ConnStatus)
        Me.Controls.Add(Me.theImage)
        Me.Name = "ClientScreen"
        Me.Size = New System.Drawing.Size(749, 452)
        Me.tbl_ConnStatus.ResumeLayout(False)
        CType(Me.theImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents theImage As System.Windows.Forms.PictureBox
    Friend WithEvents tbl_ConnStatus As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MaterialFlatButton1 As RemoteClient.MaterialFlatButton
    Friend WithEvents lbl_ConnStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
