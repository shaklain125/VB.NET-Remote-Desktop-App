<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TechSettings
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaterialFlatButton1 = New RemoteClient.MaterialFlatButton()
        Me.MaterialFlatButton2 = New RemoteClient.MaterialFlatButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(813, 438)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MaterialFlatButton1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MaterialFlatButton2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(302, 148)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(209, 142)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MaterialFlatButton1.FlatAppearance.BorderSize = 2
        Me.MaterialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(3, 71)
        Me.MaterialFlatButton1.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(203, 68)
        Me.MaterialFlatButton1.TabIndex = 4
        Me.MaterialFlatButton1.Text = "Clients Management"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton2.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MaterialFlatButton2.FlatAppearance.BorderSize = 2
        Me.MaterialFlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.MaterialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaterialFlatButton2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(3, 3)
        Me.MaterialFlatButton2.MouseDownForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.MouseHoverForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.MouseLeaveForeColor = System.Drawing.Color.Empty
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(203, 62)
        Me.MaterialFlatButton2.TabIndex = 3
        Me.MaterialFlatButton2.Text = "Staff Management"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = False
        '
        'TechSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TechSettings"
        Me.Size = New System.Drawing.Size(813, 438)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MaterialFlatButton1 As RemoteClient.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As RemoteClient.MaterialFlatButton

End Class
