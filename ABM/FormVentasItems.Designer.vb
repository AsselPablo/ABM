<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentasItems
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblPrecioT = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnBorrar2 = New System.Windows.Forms.Button()
        Me.btnMod2 = New System.Windows.Forms.Button()
        Me.BtnSave2 = New System.Windows.Forms.Button()
        Me.Ventas = New System.Windows.Forms.Label()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.labelPrecioU = New System.Windows.Forms.Label()
        Me.labelIdProducto = New System.Windows.Forms.Label()
        Me.labelid = New System.Windows.Forms.Label()
        Me.dgvVentasItems = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.lblPrecioT)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.btnBorrar2)
        Me.Panel1.Controls.Add(Me.btnMod2)
        Me.Panel1.Controls.Add(Me.BtnSave2)
        Me.Panel1.Controls.Add(Me.Ventas)
        Me.Panel1.Controls.Add(Me.txtPrecioU)
        Me.Panel1.Controls.Add(Me.txtIdProducto)
        Me.Panel1.Controls.Add(Me.txtIdVenta)
        Me.Panel1.Controls.Add(Me.labelPrecioU)
        Me.Panel1.Controls.Add(Me.labelIdProducto)
        Me.Panel1.Controls.Add(Me.labelid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 450)
        Me.Panel1.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(128, 241)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(146, 20)
        Me.txtTotal.TabIndex = 37
        '
        'lblPrecioT
        '
        Me.lblPrecioT.AutoSize = True
        Me.lblPrecioT.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioT.ForeColor = System.Drawing.Color.White
        Me.lblPrecioT.Location = New System.Drawing.Point(12, 238)
        Me.lblPrecioT.Name = "lblPrecioT"
        Me.lblPrecioT.Size = New System.Drawing.Size(100, 22)
        Me.lblPrecioT.TabIndex = 36
        Me.lblPrecioT.Text = "Precio/T:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(128, 206)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(146, 20)
        Me.txtCantidad.TabIndex = 35
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(12, 203)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(100, 22)
        Me.lblCantidad.TabIndex = 34
        Me.lblCantidad.Text = "Cantidad:"
        '
        'btnBorrar2
        '
        Me.btnBorrar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBorrar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnBorrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar2.Location = New System.Drawing.Point(156, 349)
        Me.btnBorrar2.Name = "btnBorrar2"
        Me.btnBorrar2.Size = New System.Drawing.Size(118, 37)
        Me.btnBorrar2.TabIndex = 33
        Me.btnBorrar2.Text = "Borrar"
        Me.btnBorrar2.UseVisualStyleBackColor = False
        '
        'btnMod2
        '
        Me.btnMod2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMod2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnMod2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMod2.Location = New System.Drawing.Point(10, 349)
        Me.btnMod2.Name = "btnMod2"
        Me.btnMod2.Size = New System.Drawing.Size(118, 37)
        Me.btnMod2.TabIndex = 32
        Me.btnMod2.Text = "Modificar"
        Me.btnMod2.UseVisualStyleBackColor = False
        '
        'BtnSave2
        '
        Me.BtnSave2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSave2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave2.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave2.Location = New System.Drawing.Point(12, 297)
        Me.BtnSave2.Name = "BtnSave2"
        Me.BtnSave2.Size = New System.Drawing.Size(262, 37)
        Me.BtnSave2.TabIndex = 31
        Me.BtnSave2.Text = "Guardar"
        Me.BtnSave2.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.Ventas.AutoSize = True
        Me.Ventas.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.ForeColor = System.Drawing.Color.Green
        Me.Ventas.Location = New System.Drawing.Point(43, 48)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(200, 22)
        Me.Ventas.TabIndex = 30
        Me.Ventas.Text = "Agregar ID de venta"
        '
        'txtPrecioU
        '
        Me.txtPrecioU.Location = New System.Drawing.Point(128, 169)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(146, 20)
        Me.txtPrecioU.TabIndex = 29
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(128, 133)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(146, 20)
        Me.txtIdProducto.TabIndex = 28
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(128, 98)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(146, 20)
        Me.txtIdVenta.TabIndex = 27
        '
        'labelPrecioU
        '
        Me.labelPrecioU.AutoSize = True
        Me.labelPrecioU.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecioU.ForeColor = System.Drawing.Color.White
        Me.labelPrecioU.Location = New System.Drawing.Point(12, 166)
        Me.labelPrecioU.Name = "labelPrecioU"
        Me.labelPrecioU.Size = New System.Drawing.Size(100, 22)
        Me.labelPrecioU.TabIndex = 26
        Me.labelPrecioU.Text = "Precio/U:"
        '
        'labelIdProducto
        '
        Me.labelIdProducto.AutoSize = True
        Me.labelIdProducto.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdProducto.ForeColor = System.Drawing.Color.White
        Me.labelIdProducto.Location = New System.Drawing.Point(12, 130)
        Me.labelIdProducto.Name = "labelIdProducto"
        Me.labelIdProducto.Size = New System.Drawing.Size(120, 22)
        Me.labelIdProducto.TabIndex = 25
        Me.labelIdProducto.Text = "IdProducto:"
        '
        'labelid
        '
        Me.labelid.AutoSize = True
        Me.labelid.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelid.ForeColor = System.Drawing.Color.White
        Me.labelid.Location = New System.Drawing.Point(12, 95)
        Me.labelid.Name = "labelid"
        Me.labelid.Size = New System.Drawing.Size(90, 22)
        Me.labelid.TabIndex = 24
        Me.labelid.Text = "IdVenta:"
        '
        'dgvVentasItems
        '
        Me.dgvVentasItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentasItems.Location = New System.Drawing.Point(494, 232)
        Me.dgvVentasItems.Name = "dgvVentasItems"
        Me.dgvVentasItems.Size = New System.Drawing.Size(240, 150)
        Me.dgvVentasItems.TabIndex = 2
        '
        'FormVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvVentasItems)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormVentasItems"
        Me.Text = "FormVentasItems"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvVentasItems As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblPrecioT As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnBorrar2 As Button
    Friend WithEvents btnMod2 As Button
    Friend WithEvents BtnSave2 As Button
    Friend WithEvents Ventas As Label
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents labelPrecioU As Label
    Friend WithEvents labelIdProducto As Label
    Friend WithEvents labelid As Label
End Class
