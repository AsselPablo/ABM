<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrar3 = New System.Windows.Forms.Button()
        Me.btnMod3 = New System.Windows.Forms.Button()
        Me.BtnSave3 = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Label()
        Me.txtTootal = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelIdCliente = New System.Windows.Forms.Label()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(362, 72)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(386, 261)
        Me.dgvVentas.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBorrar3)
        Me.Panel1.Controls.Add(Me.btnMod3)
        Me.Panel1.Controls.Add(Me.BtnSave3)
        Me.Panel1.Controls.Add(Me.Ventas)
        Me.Panel1.Controls.Add(Me.txtTootal)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtIdCliente)
        Me.Panel1.Controls.Add(Me.labelTotal)
        Me.Panel1.Controls.Add(Me.labelFecha)
        Me.Panel1.Controls.Add(Me.labelIdCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 450)
        Me.Panel1.TabIndex = 4
        '
        'btnBorrar3
        '
        Me.btnBorrar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBorrar3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnBorrar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar3.Location = New System.Drawing.Point(156, 285)
        Me.btnBorrar3.Name = "btnBorrar3"
        Me.btnBorrar3.Size = New System.Drawing.Size(118, 37)
        Me.btnBorrar3.TabIndex = 9
        Me.btnBorrar3.Text = "Borrar"
        Me.btnBorrar3.UseVisualStyleBackColor = False
        '
        'btnMod3
        '
        Me.btnMod3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMod3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnMod3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMod3.Location = New System.Drawing.Point(10, 285)
        Me.btnMod3.Name = "btnMod3"
        Me.btnMod3.Size = New System.Drawing.Size(118, 37)
        Me.btnMod3.TabIndex = 8
        Me.btnMod3.Text = "Modificar"
        Me.btnMod3.UseVisualStyleBackColor = False
        '
        'BtnSave3
        '
        Me.BtnSave3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSave3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave3.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnSave3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave3.Location = New System.Drawing.Point(12, 233)
        Me.BtnSave3.Name = "BtnSave3"
        Me.BtnSave3.Size = New System.Drawing.Size(262, 37)
        Me.BtnSave3.TabIndex = 7
        Me.BtnSave3.Text = "Guardar"
        Me.BtnSave3.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.Ventas.AutoSize = True
        Me.Ventas.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.ForeColor = System.Drawing.Color.Green
        Me.Ventas.Location = New System.Drawing.Point(51, 36)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(150, 22)
        Me.Ventas.TabIndex = 6
        Me.Ventas.Text = "Agregar Ventas"
        '
        'txtTootal
        '
        Me.txtTootal.Location = New System.Drawing.Point(128, 166)
        Me.txtTootal.Name = "txtTootal"
        Me.txtTootal.Size = New System.Drawing.Size(146, 20)
        Me.txtTootal.TabIndex = 5
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(128, 130)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(146, 20)
        Me.txtFecha.TabIndex = 4
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(128, 95)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(146, 20)
        Me.txtIdCliente.TabIndex = 3
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.ForeColor = System.Drawing.Color.White
        Me.labelTotal.Location = New System.Drawing.Point(12, 163)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(70, 22)
        Me.labelTotal.TabIndex = 2
        Me.labelTotal.Text = "Total:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFecha.ForeColor = System.Drawing.Color.White
        Me.labelFecha.Location = New System.Drawing.Point(12, 127)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(70, 22)
        Me.labelFecha.TabIndex = 1
        Me.labelFecha.Text = "Fecha:"
        '
        'labelIdCliente
        '
        Me.labelIdCliente.AutoSize = True
        Me.labelIdCliente.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdCliente.ForeColor = System.Drawing.Color.White
        Me.labelIdCliente.Location = New System.Drawing.Point(12, 92)
        Me.labelIdCliente.Name = "labelIdCliente"
        Me.labelIdCliente.Size = New System.Drawing.Size(110, 22)
        Me.labelIdCliente.TabIndex = 0
        Me.labelIdCliente.Text = "IdCliente:"
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBorrar3 As Button
    Friend WithEvents btnMod3 As Button
    Friend WithEvents BtnSave3 As Button
    Friend WithEvents Ventas As Label
    Friend WithEvents txtTootal As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents labelTotal As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelIdCliente As Label
End Class
