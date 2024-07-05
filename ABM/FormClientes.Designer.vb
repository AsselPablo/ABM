<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.labelCorreo = New System.Windows.Forms.Label()
        Me.labelTel = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnMod)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Clientes)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.labelCorreo)
        Me.Panel1.Controls.Add(Me.labelTel)
        Me.Panel1.Controls.Add(Me.labelName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 450)
        Me.Panel1.TabIndex = 2
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar.Location = New System.Drawing.Point(156, 285)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(118, 37)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMod.Location = New System.Drawing.Point(10, 285)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(118, 37)
        Me.btnMod.TabIndex = 8
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(12, 233)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(262, 37)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Guardar"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.Clientes.AutoSize = True
        Me.Clientes.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.ForeColor = System.Drawing.Color.Green
        Me.Clientes.Location = New System.Drawing.Point(51, 36)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(170, 22)
        Me.Clientes.TabIndex = 6
        Me.Clientes.Text = "Agregar clientes"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(128, 166)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(146, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(128, 130)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(146, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(128, 95)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(146, 20)
        Me.txtNombre.TabIndex = 3
        '
        'labelCorreo
        '
        Me.labelCorreo.AutoSize = True
        Me.labelCorreo.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCorreo.ForeColor = System.Drawing.Color.White
        Me.labelCorreo.Location = New System.Drawing.Point(12, 163)
        Me.labelCorreo.Name = "labelCorreo"
        Me.labelCorreo.Size = New System.Drawing.Size(80, 22)
        Me.labelCorreo.TabIndex = 2
        Me.labelCorreo.Text = "Correo:"
        '
        'labelTel
        '
        Me.labelTel.AutoSize = True
        Me.labelTel.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTel.ForeColor = System.Drawing.Color.White
        Me.labelTel.Location = New System.Drawing.Point(12, 127)
        Me.labelTel.Name = "labelTel"
        Me.labelTel.Size = New System.Drawing.Size(100, 22)
        Me.labelTel.TabIndex = 1
        Me.labelTel.Text = "Teléfono:"
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.ForeColor = System.Drawing.Color.White
        Me.labelName.Location = New System.Drawing.Point(12, 92)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(80, 22)
        Me.labelName.TabIndex = 0
        Me.labelName.Text = "Nombre:"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(310, 72)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(386, 261)
        Me.dgvClientes.TabIndex = 3
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormClientes"
        Me.Text = "FormClientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents labelCorreo As Label
    Friend WithEvents labelTel As Label
    Friend WithEvents labelName As Label
    Friend WithEvents Clientes As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnMod As Button
End Class
