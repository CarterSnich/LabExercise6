<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReceiptLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportsDataGrid = New System.Windows.Forms.DataGridView()
        Me.TransactionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ReportsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReportsDataGrid, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(780, 430)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ReceiptLabel
        '
        Me.ReceiptLabel.BackColor = System.Drawing.Color.White
        Me.ReceiptLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiptLabel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReceiptLabel.ForeColor = System.Drawing.Color.Black
        Me.ReceiptLabel.Location = New System.Drawing.Point(503, 3)
        Me.ReceiptLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ReceiptLabel.Name = "ReceiptLabel"
        Me.ReceiptLabel.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.SetRowSpan(Me.ReceiptLabel, 2)
        Me.ReceiptLabel.Size = New System.Drawing.Size(274, 424)
        Me.ReceiptLabel.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports"
        '
        'ReportsDataGrid
        '
        Me.ReportsDataGrid.AllowUserToAddRows = False
        Me.ReportsDataGrid.AllowUserToDeleteRows = False
        Me.ReportsDataGrid.AllowUserToResizeColumns = False
        Me.ReportsDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReportsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ReportsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionId, Me.TransactionDate, Me.CustomerName, Me.Column1})
        Me.ReportsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportsDataGrid.Location = New System.Drawing.Point(3, 50)
        Me.ReportsDataGrid.Name = "ReportsDataGrid"
        Me.ReportsDataGrid.ReadOnly = True
        Me.ReportsDataGrid.RowHeadersVisible = False
        Me.ReportsDataGrid.RowTemplate.Height = 25
        Me.ReportsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ReportsDataGrid.Size = New System.Drawing.Size(494, 377)
        Me.ReportsDataGrid.TabIndex = 1
        '
        'TransactionId
        '
        Me.TransactionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionId.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionId.HeaderText = "Transaction ID"
        Me.TransactionId.Name = "TransactionId"
        Me.TransactionId.ReadOnly = True
        Me.TransactionId.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransactionId.Width = 113
        '
        'TransactionDate
        '
        Me.TransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TransactionDate.HeaderText = "Transaction date"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        Me.TransactionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransactionDate.Width = 128
        '
        'CustomerName
        '
        Me.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerName.HeaderText = "Customer name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CustomerName.Width = 124
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
        'ReportsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportsForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "ReportsForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ReportsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportsDataGrid As DataGridView
    Friend WithEvents ReceiptLabel As Label
    Friend WithEvents TransactionId As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
