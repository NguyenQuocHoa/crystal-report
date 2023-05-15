<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCheckConn = New System.Windows.Forms.Button()
        Me.btnCountCustomer = New System.Windows.Forms.Button()
        Me.DgvCustomer = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLoadData = New System.Windows.Forms.Button()
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheckConn
        '
        Me.btnCheckConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckConn.Location = New System.Drawing.Point(48, 23)
        Me.btnCheckConn.Name = "btnCheckConn"
        Me.btnCheckConn.Size = New System.Drawing.Size(141, 49)
        Me.btnCheckConn.TabIndex = 0
        Me.btnCheckConn.Text = "Check Connection"
        Me.btnCheckConn.UseVisualStyleBackColor = True
        '
        'btnCountCustomer
        '
        Me.btnCountCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountCustomer.Location = New System.Drawing.Point(235, 23)
        Me.btnCountCustomer.Name = "btnCountCustomer"
        Me.btnCountCustomer.Size = New System.Drawing.Size(141, 48)
        Me.btnCountCustomer.TabIndex = 1
        Me.btnCountCustomer.Text = "Count Customer"
        Me.btnCountCustomer.UseVisualStyleBackColor = True
        '
        'DgvCustomer
        '
        Me.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomer.Location = New System.Drawing.Point(12, 112)
        Me.DgvCustomer.Name = "DgvCustomer"
        Me.DgvCustomer.Size = New System.Drawing.Size(765, 311)
        Me.DgvCustomer.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(416, 24)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 48)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnLoadData
        '
        Me.btnLoadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadData.Location = New System.Drawing.Point(599, 24)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(141, 48)
        Me.btnLoadData.TabIndex = 1
        Me.btnLoadData.Text = "Load Data"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvCustomer)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCountCustomer)
        Me.Controls.Add(Me.btnCheckConn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheckConn As Button
    Friend WithEvents btnCountCustomer As Button
    Friend WithEvents DgvCustomer As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLoadData As Button
End Class
