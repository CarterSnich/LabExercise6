﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputCustomerCashDialog
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PaymentLabel = New System.Windows.Forms.Label()
        Me.CustomerCashTextbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(3, 0)
        Me.MessageLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(109, 21)
        Me.MessageLabel.TabIndex = 9
        Me.MessageLabel.Text = "Total payment:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MessageLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PaymentLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomerCashTextbox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(302, 108)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PaymentLabel
        '
        Me.PaymentLabel.AutoSize = True
        Me.PaymentLabel.Location = New System.Drawing.Point(118, 0)
        Me.PaymentLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(52, 21)
        Me.PaymentLabel.TabIndex = 11
        Me.PaymentLabel.Text = "Label1"
        '
        'CustomerCashTextbox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.CustomerCashTextbox, 2)
        Me.CustomerCashTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerCashTextbox.Location = New System.Drawing.Point(3, 34)
        Me.CustomerCashTextbox.Name = "CustomerCashTextbox"
        Me.CustomerCashTextbox.Size = New System.Drawing.Size(296, 29)
        Me.CustomerCashTextbox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Button1, 2)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(3, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InputCustomerCashForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(322, 128)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputCustomerCashForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputCustomerCashForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PaymentLabel As Label
    Friend WithEvents CustomerCashTextbox As TextBox
    Friend WithEvents Button1 As Button
End Class
