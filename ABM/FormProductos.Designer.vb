<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBorrar1 = New System.Windows.Forms.Button()
        Me.btnMod1 = New System.Windows.Forms.Button()
        Me.BtnSave1 = New System.Windows.Forms.Button()
        Me.labelProductos = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.labelCat = New System.Windows.Forms.Label()
        Me.labelPrecio = New System.Windows.Forms.Label()
        Me.labelName1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBorrar1)
        Me.Panel1.Controls.Add(Me.btnMod1)
        Me.Panel1.Controls.Add(Me.BtnSave1)
        Me.Panel1.Controls.Add(Me.labelProductos)
        Me.Panel1.Controls.Add(Me.txtCat)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.txtNombre1)
        Me.Panel1.Controls.Add(Me.labelCat)
        Me.Panel1.Controls.Add(Me.labelPrecio)
        Me.Panel1.Controls.Add(Me.labelName1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 496)
        Me.Panel1.TabIndex = 1
        '
        'btnBorrar1
        '
        Me.btnBorrar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBorrar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnBorrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar1.Location = New System.Drawing.Point(157, 303)
        Me.btnBorrar1.Name = "btnBorrar1"
        Me.btnBorrar1.Size = New System.Drawing.Size(118, 37)
        Me.btnBorrar1.TabIndex = 19
        Me.btnBorrar1.Text = "Borrar"
        Me.btnBorrar1.UseVisualStyleBackColor = False
        '
        'btnMod1
        '
        Me.btnMod1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMod1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnMod1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMod1.Location = New System.Drawing.Point(11, 303)
        Me.btnMod1.Name = "btnMod1"
        Me.btnMod1.Size = New System.Drawing.Size(118, 37)
        Me.btnMod1.TabIndex = 18
        Me.btnMod1.Text = "Modificar"
        Me.btnMod1.UseVisualStyleBackColor = False
        '
        'BtnSave1
        '
        Me.BtnSave1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSave1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave1.Location = New System.Drawing.Point(13, 251)
        Me.BtnSave1.Name = "BtnSave1"
        Me.BtnSave1.Size = New System.Drawing.Size(262, 37)
        Me.BtnSave1.TabIndex = 17
        Me.BtnSave1.Text = "Guardar"
        Me.BtnSave1.UseVisualStyleBackColor = False
        '
        'labelProductos
        '
        Me.labelProductos.AutoSize = True
        Me.labelProductos.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelProductos.ForeColor = System.Drawing.Color.Green
        Me.labelProductos.Location = New System.Drawing.Point(52, 54)
        Me.labelProductos.Name = "labelProductos"
        Me.labelProductos.Size = New System.Drawing.Size(180, 22)
        Me.labelProductos.TabIndex = 16
        Me.labelProductos.Text = "Agregar productos"
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(129, 184)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(146, 20)
        Me.txtCat.TabIndex = 15
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(129, 148)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(146, 20)
        Me.txtPrecio.TabIndex = 14
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(129, 113)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(146, 20)
        Me.txtNombre1.TabIndex = 13
        '
        'labelCat
        '
        Me.labelCat.AutoSize = True
        Me.labelCat.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCat.ForeColor = System.Drawing.Color.White
        Me.labelCat.Location = New System.Drawing.Point(13, 181)
        Me.labelCat.Name = "labelCat"
        Me.labelCat.Size = New System.Drawing.Size(110, 22)
        Me.labelCat.TabIndex = 12
        Me.labelCat.Text = "Categoría:"
        '
        'labelPrecio
        '
        Me.labelPrecio.AutoSize = True
        Me.labelPrecio.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecio.ForeColor = System.Drawing.Color.White
        Me.labelPrecio.Location = New System.Drawing.Point(13, 145)
        Me.labelPrecio.Name = "labelPrecio"
        Me.labelPrecio.Size = New System.Drawing.Size(80, 22)
        Me.labelPrecio.TabIndex = 11
        Me.labelPrecio.Text = "Precio:"
        '
        'labelName1
        '
        Me.labelName1.AutoSize = True
        Me.labelName1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName1.ForeColor = System.Drawing.Color.White
        Me.labelName1.Location = New System.Drawing.Point(13, 110)
        Me.labelName1.Name = "labelName1"
        Me.labelName1.Size = New System.Drawing.Size(80, 22)
        Me.labelName1.TabIndex = 10
        Me.labelName1.Text = "Nombre:"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvProductos.Location = New System.Drawing.Point(328, 0)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(596, 496)
        Me.dgvProductos.TabIndex = 2
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 496)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProductos"
        Me.Text = "FormProductos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnBorrar1 As Button
    Friend WithEvents btnMod1 As Button
    Friend WithEvents BtnSave1 As Button
    Friend WithEvents labelProductos As Label
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents labelCat As Label
    Friend WithEvents labelPrecio As Label
    Friend WithEvents labelName1 As Label
End Class
