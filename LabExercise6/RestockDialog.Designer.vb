<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestockDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProdBarcodeLabel = New System.Windows.Forms.Label()
        Me.StockCountTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateStockBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProdBarcodeLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StockCountTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UpdateStockBtn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(302, 105)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ProdBarcodeLabel
        '
        Me.ProdBarcodeLabel.AutoSize = True
        Me.ProdBarcodeLabel.Location = New System.Drawing.Point(137, 0)
        Me.ProdBarcodeLabel.Name = "ProdBarcodeLabel"
        Me.ProdBarcodeLabel.Size = New System.Drawing.Size(133, 21)
        Me.ProdBarcodeLabel.TabIndex = 0
        Me.ProdBarcodeLabel.Text = "ProdBarcodeLabel"
        '
        'StockCountTextBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StockCountTextBox, 2)
        Me.StockCountTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockCountTextBox.Location = New System.Drawing.Point(3, 24)
        Me.StockCountTextBox.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.StockCountTextBox.Name = "StockCountTextBox"
        Me.StockCountTextBox.Size = New System.Drawing.Size(296, 29)
        Me.StockCountTextBox.TabIndex = 4
        '
        'UpdateStockBtn
        '
        Me.UpdateStockBtn.AutoSize = True
        Me.UpdateStockBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.SetColumnSpan(Me.UpdateStockBtn, 2)
        Me.UpdateStockBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateStockBtn.Location = New System.Drawing.Point(3, 66)
        Me.UpdateStockBtn.Name = "UpdateStockBtn"
        Me.UpdateStockBtn.Size = New System.Drawing.Size(296, 36)
        Me.UpdateStockBtn.TabIndex = 8
        Me.UpdateStockBtn.Text = "Update"
        Me.UpdateStockBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "New stock count:"
        '
        'RestockForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(322, 125)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestockForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RestockForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ProdBarcodeLabel As Label
    Friend WithEvents StockCountTextBox As TextBox
    Friend WithEvents UpdateStockBtn As Button
    Friend WithEvents Label1 As Label
End Class
