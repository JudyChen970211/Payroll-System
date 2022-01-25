<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvWage = New System.Windows.Forms.DataGridView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.WaterMarkTextBox1 = New PayrollSystem.WaterMarkTextBox()
        Me.WaterMarkTextBox2 = New PayrollSystem.WaterMarkTextBox()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvWage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWage
        '
        Me.dgvWage.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvWage.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWage.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWage.Location = New System.Drawing.Point(0, 0)
        Me.dgvWage.Name = "dgvWage"
        Me.dgvWage.RowTemplate.Height = 24
        Me.dgvWage.Size = New System.Drawing.Size(700, 255)
        Me.dgvWage.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOK.BackColor = System.Drawing.Color.OldLace
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnOK.Location = New System.Drawing.Point(405, 140)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 29)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "載入"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(240, 30)
        Me.lbTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(219, 61)
        Me.lbTitle.TabIndex = 14
        Me.lbTitle.Text = "員工資料"
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 0)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.Button1)
        Me.spcMain.Panel1.Controls.Add(Me.Label2)
        Me.spcMain.Panel1.Controls.Add(Me.lbYear)
        Me.spcMain.Panel1.Controls.Add(Me.WaterMarkTextBox2)
        Me.spcMain.Panel1.Controls.Add(Me.WaterMarkTextBox1)
        Me.spcMain.Panel1.Controls.Add(Me.btnOK)
        Me.spcMain.Panel1.Controls.Add(Me.lbTitle)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.dgvWage)
        Me.spcMain.Size = New System.Drawing.Size(700, 700)
        Me.spcMain.SplitterDistance = 441
        Me.spcMain.TabIndex = 3
        '
        'WaterMarkTextBox1
        '
        Me.WaterMarkTextBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WaterMarkTextBox1.Location = New System.Drawing.Point(220, 140)
        Me.WaterMarkTextBox1.Name = "WaterMarkTextBox1"
        Me.WaterMarkTextBox1.Size = New System.Drawing.Size(50, 29)
        Me.WaterMarkTextBox1.TabIndex = 30
        Me.WaterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox1.WaterMarkText = "Water Mark"
        '
        'WaterMarkTextBox2
        '
        Me.WaterMarkTextBox2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WaterMarkTextBox2.Location = New System.Drawing.Point(310, 140)
        Me.WaterMarkTextBox2.Name = "WaterMarkTextBox2"
        Me.WaterMarkTextBox2.Size = New System.Drawing.Size(50, 29)
        Me.WaterMarkTextBox2.TabIndex = 31
        Me.WaterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox2.WaterMarkText = "Water Mark"
        '
        'lbYear
        '
        Me.lbYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbYear.AutoSize = True
        Me.lbYear.Location = New System.Drawing.Point(275, 143)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(25, 20)
        Me.lbYear.TabIndex = 32
        Me.lbYear.Text = "年"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "月"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Location = New System.Drawing.Point(220, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 29)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "紅利獎金"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmWage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(700, 700)
        Me.Controls.Add(Me.spcMain)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmWage"
        Me.Text = "frmWage"
        CType(Me.dgvWage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel1.PerformLayout()
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvWage As DataGridView
    Friend WithEvents btnOK As Button
    Friend WithEvents lbTitle As Label
    Friend WithEvents spcMain As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents WaterMarkTextBox2 As WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox1 As WaterMarkTextBox
    Friend WithEvents Button1 As Button
End Class
