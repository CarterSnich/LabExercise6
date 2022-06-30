<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PosForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.CashierNameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProdItemDetailsContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProdQtyTextbox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextbox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextbox = New System.Windows.Forms.TextBox()
        Me.ProdSubtotalTextbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InsertItemBtn = New System.Windows.Forms.Button()
        Me.RemoveItemBtn = New System.Windows.Forms.Button()
        Me.CheckoutBtn = New System.Windows.Forms.Button()
        Me.BarcodeTextbox = New System.Windows.Forms.TextBox()
        Me.BarcodeSearchBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductStockQtyLabel = New System.Windows.Forms.Label()
        Me.CartItemsDatagrid = New System.Windows.Forms.DataGridView()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUmmy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TransDetailsContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TransIdTextbox = New System.Windows.Forms.TextBox()
        Me.CustNameTexbox = New System.Windows.Forms.TextBox()
        Me.TransDateTimeTextbox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ResetTransBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReceiptLabel = New System.Windows.Forms.Label()
        Me.DateTimeWorker = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ProdItemDetailsContainer.SuspendLayout()
        CType(Me.CartItemsDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransDetailsContainer.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Point of Sale System"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 441)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimeLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CashierNameLabel, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(474, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(196, 42)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeLabel.Location = New System.Drawing.Point(3, 0)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(190, 21)
        Me.DateTimeLabel.TabIndex = 0
        Me.DateTimeLabel.Text = "DateTimeLabel"
        Me.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CashierNameLabel
        '
        Me.CashierNameLabel.AutoSize = True
        Me.CashierNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CashierNameLabel.Location = New System.Drawing.Point(3, 21)
        Me.CashierNameLabel.Name = "CashierNameLabel"
        Me.CashierNameLabel.Size = New System.Drawing.Size(190, 21)
        Me.CashierNameLabel.TabIndex = 2
        Me.CashierNameLabel.Text = "CashierNameLabel"
        Me.CashierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ProdItemDetailsContainer, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.CartItemsDatagrid, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TransDetailsContainer, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(673, 393)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'ProdItemDetailsContainer
        '
        Me.ProdItemDetailsContainer.AutoSize = True
        Me.ProdItemDetailsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProdItemDetailsContainer.ColumnCount = 10
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label2, 0, 0)
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label3, 0, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label5, 4, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.ProdQtyTextbox, 1, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.ItemNameTextbox, 1, 2)
        Me.ProdItemDetailsContainer.Controls.Add(Me.ProductPriceTextbox, 5, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.ProdSubtotalTextbox, 7, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label7, 6, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.InsertItemBtn, 9, 0)
        Me.ProdItemDetailsContainer.Controls.Add(Me.RemoveItemBtn, 9, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.CheckoutBtn, 9, 2)
        Me.ProdItemDetailsContainer.Controls.Add(Me.BarcodeTextbox, 1, 0)
        Me.ProdItemDetailsContainer.Controls.Add(Me.BarcodeSearchBtn, 8, 0)
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label4, 0, 2)
        Me.ProdItemDetailsContainer.Controls.Add(Me.Label10, 2, 1)
        Me.ProdItemDetailsContainer.Controls.Add(Me.ProductStockQtyLabel, 3, 1)
        Me.ProdItemDetailsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdItemDetailsContainer.Location = New System.Drawing.Point(0, 86)
        Me.ProdItemDetailsContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.ProdItemDetailsContainer.Name = "ProdItemDetailsContainer"
        Me.ProdItemDetailsContainer.RowCount = 3
        Me.ProdItemDetailsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProdItemDetailsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProdItemDetailsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProdItemDetailsContainer.Size = New System.Drawing.Size(673, 111)
        Me.ProdItemDetailsContainer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Barcode:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Qty.:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Price:"
        '
        'ProdQtyTextbox
        '
        Me.ProdQtyTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdQtyTextbox.Enabled = False
        Me.ProdQtyTextbox.Location = New System.Drawing.Point(95, 40)
        Me.ProdQtyTextbox.Name = "ProdQtyTextbox"
        Me.ProdQtyTextbox.Size = New System.Drawing.Size(56, 29)
        Me.ProdQtyTextbox.TabIndex = 5
        '
        'ItemNameTextbox
        '
        Me.ItemNameTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProdItemDetailsContainer.SetColumnSpan(Me.ItemNameTextbox, 8)
        Me.ItemNameTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemNameTextbox.Location = New System.Drawing.Point(95, 77)
        Me.ItemNameTextbox.Name = "ItemNameTextbox"
        Me.ItemNameTextbox.ReadOnly = True
        Me.ItemNameTextbox.Size = New System.Drawing.Size(448, 29)
        Me.ItemNameTextbox.TabIndex = 6
        '
        'ProductPriceTextbox
        '
        Me.ProductPriceTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProductPriceTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductPriceTextbox.Location = New System.Drawing.Point(254, 40)
        Me.ProductPriceTextbox.Name = "ProductPriceTextbox"
        Me.ProductPriceTextbox.ReadOnly = True
        Me.ProductPriceTextbox.Size = New System.Drawing.Size(56, 29)
        Me.ProductPriceTextbox.TabIndex = 7
        '
        'ProdSubtotalTextbox
        '
        Me.ProdSubtotalTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProdItemDetailsContainer.SetColumnSpan(Me.ProdSubtotalTextbox, 2)
        Me.ProdSubtotalTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdSubtotalTextbox.Location = New System.Drawing.Point(405, 40)
        Me.ProdSubtotalTextbox.Name = "ProdSubtotalTextbox"
        Me.ProdSubtotalTextbox.ReadOnly = True
        Me.ProdSubtotalTextbox.Size = New System.Drawing.Size(138, 29)
        Me.ProdSubtotalTextbox.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total price:"
        '
        'InsertItemBtn
        '
        Me.InsertItemBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.InsertItemBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertItemBtn.Enabled = False
        Me.InsertItemBtn.ForeColor = System.Drawing.Color.Black
        Me.InsertItemBtn.Location = New System.Drawing.Point(549, 3)
        Me.InsertItemBtn.Name = "InsertItemBtn"
        Me.InsertItemBtn.Size = New System.Drawing.Size(121, 31)
        Me.InsertItemBtn.TabIndex = 13
        Me.InsertItemBtn.Text = "Insert item"
        Me.InsertItemBtn.UseVisualStyleBackColor = True
        '
        'RemoveItemBtn
        '
        Me.RemoveItemBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RemoveItemBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemoveItemBtn.Enabled = False
        Me.RemoveItemBtn.ForeColor = System.Drawing.Color.Black
        Me.RemoveItemBtn.Location = New System.Drawing.Point(549, 40)
        Me.RemoveItemBtn.Name = "RemoveItemBtn"
        Me.RemoveItemBtn.Size = New System.Drawing.Size(121, 31)
        Me.RemoveItemBtn.TabIndex = 14
        Me.RemoveItemBtn.Text = "Remove item"
        Me.RemoveItemBtn.UseVisualStyleBackColor = True
        '
        'CheckoutBtn
        '
        Me.CheckoutBtn.AutoSize = True
        Me.CheckoutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CheckoutBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckoutBtn.Enabled = False
        Me.CheckoutBtn.ForeColor = System.Drawing.Color.Black
        Me.CheckoutBtn.Location = New System.Drawing.Point(549, 77)
        Me.CheckoutBtn.Name = "CheckoutBtn"
        Me.CheckoutBtn.Size = New System.Drawing.Size(121, 31)
        Me.CheckoutBtn.TabIndex = 15
        Me.CheckoutBtn.Text = "Check out"
        Me.CheckoutBtn.UseVisualStyleBackColor = True
        '
        'BarcodeTextbox
        '
        Me.ProdItemDetailsContainer.SetColumnSpan(Me.BarcodeTextbox, 7)
        Me.BarcodeTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeTextbox.Location = New System.Drawing.Point(95, 3)
        Me.BarcodeTextbox.Name = "BarcodeTextbox"
        Me.BarcodeTextbox.Size = New System.Drawing.Size(367, 29)
        Me.BarcodeTextbox.TabIndex = 16
        '
        'BarcodeSearchBtn
        '
        Me.BarcodeSearchBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeSearchBtn.ForeColor = System.Drawing.Color.Black
        Me.BarcodeSearchBtn.Location = New System.Drawing.Point(468, 3)
        Me.BarcodeSearchBtn.Name = "BarcodeSearchBtn"
        Me.BarcodeSearchBtn.Size = New System.Drawing.Size(75, 31)
        Me.BarcodeSearchBtn.TabIndex = 17
        Me.BarcodeSearchBtn.Text = "Search"
        Me.BarcodeSearchBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Item name:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(154, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "/"
        '
        'ProductStockQtyLabel
        '
        Me.ProductStockQtyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProductStockQtyLabel.AutoSize = True
        Me.ProductStockQtyLabel.Location = New System.Drawing.Point(170, 45)
        Me.ProductStockQtyLabel.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ProductStockQtyLabel.Name = "ProductStockQtyLabel"
        Me.ProductStockQtyLabel.Size = New System.Drawing.Size(18, 21)
        Me.ProductStockQtyLabel.TabIndex = 20
        Me.ProductStockQtyLabel.Text = "0"
        '
        'CartItemsDatagrid
        '
        Me.CartItemsDatagrid.AllowUserToAddRows = False
        Me.CartItemsDatagrid.AllowUserToDeleteRows = False
        Me.CartItemsDatagrid.AllowUserToResizeColumns = False
        Me.CartItemsDatagrid.AllowUserToResizeRows = False
        Me.CartItemsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartItemsDatagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Barcode, Me.ItemName, Me.Price, Me.Quantity, Me.Subtotal, Me.DUmmy})
        Me.CartItemsDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartItemsDatagrid.Location = New System.Drawing.Point(3, 208)
        Me.CartItemsDatagrid.Name = "CartItemsDatagrid"
        Me.CartItemsDatagrid.ReadOnly = True
        Me.CartItemsDatagrid.RowHeadersVisible = False
        Me.CartItemsDatagrid.RowTemplate.Height = 25
        Me.CartItemsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CartItemsDatagrid.Size = New System.Drawing.Size(667, 182)
        Me.CartItemsDatagrid.TabIndex = 1
        '
        'Barcode
        '
        Me.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Barcode.DefaultCellStyle = DataGridViewCellStyle1
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        Me.Barcode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Barcode.Width = 71
        '
        'ItemName
        '
        Me.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ItemName.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemName.HeaderText = "Item name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Price.DefaultCellStyle = DataGridViewCellStyle3
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 49
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 75
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Subtotal.Width = 73
        '
        'DUmmy
        '
        Me.DUmmy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DUmmy.HeaderText = ""
        Me.DUmmy.Name = "DUmmy"
        Me.DUmmy.ReadOnly = True
        Me.DUmmy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DUmmy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 81)
        Me.Panel2.MaximumSize = New System.Drawing.Size(0, 2)
        Me.Panel2.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 2)
        Me.Panel2.TabIndex = 4
        '
        'TransDetailsContainer
        '
        Me.TransDetailsContainer.AutoSize = True
        Me.TransDetailsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TransDetailsContainer.ColumnCount = 4
        Me.TransDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TransDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TransDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TransDetailsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TransDetailsContainer.Controls.Add(Me.Label6, 0, 0)
        Me.TransDetailsContainer.Controls.Add(Me.Label8, 0, 1)
        Me.TransDetailsContainer.Controls.Add(Me.Label9, 2, 0)
        Me.TransDetailsContainer.Controls.Add(Me.TransIdTextbox, 1, 0)
        Me.TransDetailsContainer.Controls.Add(Me.CustNameTexbox, 1, 1)
        Me.TransDetailsContainer.Controls.Add(Me.TransDateTimeTextbox, 3, 0)
        Me.TransDetailsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransDetailsContainer.Location = New System.Drawing.Point(0, 8)
        Me.TransDetailsContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.TransDetailsContainer.Name = "TransDetailsContainer"
        Me.TransDetailsContainer.RowCount = 2
        Me.TransDetailsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TransDetailsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TransDetailsContainer.Size = New System.Drawing.Size(673, 70)
        Me.TransDetailsContainer.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Transaction ID:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Customer name:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(360, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Date time:"
        '
        'TransIdTextbox
        '
        Me.TransIdTextbox.BackColor = System.Drawing.Color.White
        Me.TransIdTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransIdTextbox.ForeColor = System.Drawing.Color.Black
        Me.TransIdTextbox.Location = New System.Drawing.Point(131, 3)
        Me.TransIdTextbox.Name = "TransIdTextbox"
        Me.TransIdTextbox.ReadOnly = True
        Me.TransIdTextbox.Size = New System.Drawing.Size(223, 29)
        Me.TransIdTextbox.TabIndex = 3
        '
        'CustNameTexbox
        '
        Me.TransDetailsContainer.SetColumnSpan(Me.CustNameTexbox, 3)
        Me.CustNameTexbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustNameTexbox.Location = New System.Drawing.Point(131, 38)
        Me.CustNameTexbox.Name = "CustNameTexbox"
        Me.CustNameTexbox.Size = New System.Drawing.Size(539, 29)
        Me.CustNameTexbox.TabIndex = 4
        '
        'TransDateTimeTextbox
        '
        Me.TransDateTimeTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TransDateTimeTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransDateTimeTextbox.Location = New System.Drawing.Point(446, 3)
        Me.TransDateTimeTextbox.Name = "TransDateTimeTextbox"
        Me.TransDateTimeTextbox.ReadOnly = True
        Me.TransDateTimeTextbox.Size = New System.Drawing.Size(224, 29)
        Me.TransDateTimeTextbox.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.MaximumSize = New System.Drawing.Size(0, 2)
        Me.Panel3.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(667, 2)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 200)
        Me.Panel4.MaximumSize = New System.Drawing.Size(0, 2)
        Me.Panel4.MinimumSize = New System.Drawing.Size(0, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(667, 2)
        Me.Panel4.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ResetTransBtn, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(673, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel1.SetRowSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(281, 441)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'ResetTransBtn
        '
        Me.ResetTransBtn.AutoSize = True
        Me.ResetTransBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ResetTransBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResetTransBtn.ForeColor = System.Drawing.Color.Black
        Me.ResetTransBtn.Location = New System.Drawing.Point(3, 407)
        Me.ResetTransBtn.Name = "ResetTransBtn"
        Me.ResetTransBtn.Size = New System.Drawing.Size(275, 31)
        Me.ResetTransBtn.TabIndex = 7
        Me.ResetTransBtn.Text = "New transaction"
        Me.ResetTransBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ReceiptLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 398)
        Me.Panel1.TabIndex = 8
        '
        'ReceiptLabel
        '
        Me.ReceiptLabel.BackColor = System.Drawing.Color.White
        Me.ReceiptLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiptLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReceiptLabel.ForeColor = System.Drawing.Color.Black
        Me.ReceiptLabel.Location = New System.Drawing.Point(0, 0)
        Me.ReceiptLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ReceiptLabel.Name = "ReceiptLabel"
        Me.ReceiptLabel.Padding = New System.Windows.Forms.Padding(10)
        Me.ReceiptLabel.Size = New System.Drawing.Size(275, 398)
        Me.ReceiptLabel.TabIndex = 9
        '
        'DateTimeWorker
        '
        '
        'PosForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(974, 461)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PosForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ProdItemDetailsContainer.ResumeLayout(False)
        Me.ProdItemDetailsContainer.PerformLayout()
        CType(Me.CartItemsDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransDetailsContainer.ResumeLayout(False)
        Me.TransDetailsContainer.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DateTimeLabel As Label
    Public WithEvents DateTimeWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CashierNameLabel As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CartItemsDatagrid As DataGridView
    Friend WithEvents ProdItemDetailsContainer As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProdQtyTextbox As TextBox
    Friend WithEvents ItemNameTextbox As TextBox
    Friend WithEvents ProductPriceTextbox As TextBox
    Friend WithEvents ProdSubtotalTextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InsertItemBtn As Button
    Friend WithEvents RemoveItemBtn As Button
    Friend WithEvents CheckoutBtn As Button
    Friend WithEvents BarcodeTextbox As TextBox
    Friend WithEvents BarcodeSearchBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TransDetailsContainer As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TransIdTextbox As TextBox
    Friend WithEvents CustNameTexbox As TextBox
    Friend WithEvents TransDateTimeTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ResetTransBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ProductStockQtyLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReceiptLabel As Label
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents DUmmy As DataGridViewTextBoxColumn
End Class
