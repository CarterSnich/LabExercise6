<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewItemBtn = New System.Windows.Forms.Button()
        Me.EditItemBtn = New System.Windows.Forms.Button()
        Me.DeleteItemBtn = New System.Windows.Forms.Button()
        Me.RestockBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProductDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NewItemBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EditItemBtn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteItemBtn, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RestockBtn, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(780, 430)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 47)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stocks"
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.AllowUserToResizeColumns = False
        Me.ProductDataGridView.AllowUserToResizeRows = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemId, Me.ItemName, Me.Price, Me.Quantity, Me.Column1})
        Me.TableLayoutPanel1.SetColumnSpan(Me.ProductDataGridView, 5)
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 50)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.RowHeadersVisible = False
        Me.ProductDataGridView.RowTemplate.Height = 25
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(774, 377)
        Me.ProductDataGridView.TabIndex = 4
        '
        'ItemId
        '
        Me.ItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ItemId.Frozen = True
        Me.ItemId.HeaderText = "ID"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.ReadOnly = True
        Me.ItemId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ItemId.Width = 31
        '
        'ItemName
        '
        Me.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ItemName.Frozen = True
        Me.ItemName.HeaderText = "Item name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ItemName.Width = 390
        '
        'Price
        '
        Me.Price.Frozen = True
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 75
        '
        'iQuantity
        '
        Me.Quantity.Frozen = True
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "iQuantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 75
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NewItemBtn
        '
        Me.NewItemBtn.AutoSize = True
        Me.NewItemBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NewItemBtn.Location = New System.Drawing.Point(459, 13)
        Me.NewItemBtn.Name = "NewItemBtn"
        Me.NewItemBtn.Size = New System.Drawing.Size(75, 31)
        Me.NewItemBtn.TabIndex = 0
        Me.NewItemBtn.Text = "New"
        Me.NewItemBtn.UseVisualStyleBackColor = True
        '
        'EditItemBtn
        '
        Me.EditItemBtn.AutoSize = True
        Me.EditItemBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditItemBtn.Enabled = False
        Me.EditItemBtn.Location = New System.Drawing.Point(621, 13)
        Me.EditItemBtn.Name = "EditItemBtn"
        Me.EditItemBtn.Size = New System.Drawing.Size(75, 31)
        Me.EditItemBtn.TabIndex = 1
        Me.EditItemBtn.Text = "Edit"
        Me.EditItemBtn.UseVisualStyleBackColor = True
        '
        'DeleteItemBtn
        '
        Me.DeleteItemBtn.AutoSize = True
        Me.DeleteItemBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DeleteItemBtn.Enabled = False
        Me.DeleteItemBtn.Location = New System.Drawing.Point(702, 13)
        Me.DeleteItemBtn.Name = "DeleteItemBtn"
        Me.DeleteItemBtn.Size = New System.Drawing.Size(75, 31)
        Me.DeleteItemBtn.TabIndex = 2
        Me.DeleteItemBtn.Text = "Delete"
        Me.DeleteItemBtn.UseVisualStyleBackColor = True
        '
        'RestockBtn
        '
        Me.RestockBtn.AutoSize = True
        Me.RestockBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RestockBtn.Enabled = False
        Me.RestockBtn.Location = New System.Drawing.Point(540, 13)
        Me.RestockBtn.Name = "RestockBtn"
        Me.RestockBtn.Size = New System.Drawing.Size(75, 31)
        Me.RestockBtn.TabIndex = 5
        Me.RestockBtn.Text = "Restock"
        Me.RestockBtn.UseVisualStyleBackColor = True
        '
        'StocksForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StocksForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "StocksForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NewItemBtn As Button
    Friend WithEvents EditItemBtn As Button
    Friend WithEvents DeleteItemBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents RestockBtn As Button
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
