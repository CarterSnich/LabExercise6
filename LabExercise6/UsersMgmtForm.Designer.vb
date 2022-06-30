<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersMgmtForm
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
        Me.NewUserBtn = New System.Windows.Forms.Button()
        Me.EditUserBtn = New System.Windows.Forms.Button()
        Me.DeleteUserBtn = New System.Windows.Forms.Button()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.NewUserBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EditUserBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteUserBtn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UsersDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 442)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NewUserBtn
        '
        Me.NewUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NewUserBtn.Location = New System.Drawing.Point(592, 13)
        Me.NewUserBtn.Name = "NewUserBtn"
        Me.NewUserBtn.Size = New System.Drawing.Size(75, 31)
        Me.NewUserBtn.TabIndex = 0
        Me.NewUserBtn.Text = "New"
        Me.NewUserBtn.UseVisualStyleBackColor = True
        '
        'EditUserBtn
        '
        Me.EditUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditUserBtn.Enabled = False
        Me.EditUserBtn.Location = New System.Drawing.Point(673, 13)
        Me.EditUserBtn.Name = "EditUserBtn"
        Me.EditUserBtn.Size = New System.Drawing.Size(75, 31)
        Me.EditUserBtn.TabIndex = 1
        Me.EditUserBtn.Text = "Edit"
        Me.EditUserBtn.UseVisualStyleBackColor = True
        '
        'DeleteUserBtn
        '
        Me.DeleteUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DeleteUserBtn.Enabled = False
        Me.DeleteUserBtn.Location = New System.Drawing.Point(754, 13)
        Me.DeleteUserBtn.Name = "DeleteUserBtn"
        Me.DeleteUserBtn.Size = New System.Drawing.Size(75, 31)
        Me.DeleteUserBtn.TabIndex = 2
        Me.DeleteUserBtn.Text = "Delete"
        Me.DeleteUserBtn.UseVisualStyleBackColor = True
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.AllowUserToAddRows = False
        Me.UsersDataGridView.AllowUserToDeleteRows = False
        Me.UsersDataGridView.AllowUserToResizeColumns = False
        Me.UsersDataGridView.AllowUserToResizeRows = False
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Username})
        Me.TableLayoutPanel1.SetColumnSpan(Me.UsersDataGridView, 4)
        Me.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsersDataGridView.Location = New System.Drawing.Point(3, 50)
        Me.UsersDataGridView.MultiSelect = False
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.ReadOnly = True
        Me.UsersDataGridView.RowHeadersVisible = False
        Me.UsersDataGridView.RowTemplate.Height = 25
        Me.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDataGridView.Size = New System.Drawing.Size(826, 389)
        Me.UsersDataGridView.TabIndex = 3
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.HeaderText = "#"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 26
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(583, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Users Management"
        '
        'UsersMgmtForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(852, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UsersMgmtForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "UsersMgmtForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NewUserBtn As Button
    Friend WithEvents EditUserBtn As Button
    Friend WithEvents DeleteUserBtn As Button
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
