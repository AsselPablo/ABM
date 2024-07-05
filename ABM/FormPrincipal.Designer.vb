<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.pbMin = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.ComboBoxTables = New System.Windows.Forms.ComboBox()
        Me.IconToolStripButton1 = New FontAwesome.Sharp.IconToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.pbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PanelTop)
        Me.Panel1.Controls.Add(Me.ComboBoxTables)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 427)
        Me.Panel1.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.pbMin)
        Me.PanelTop.Controls.Add(Me.pbCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1019, 40)
        Me.PanelTop.TabIndex = 1
        '
        'pbMin
        '
        Me.pbMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMin.Image = Global.ABM.My.Resources.Resources.minimazar
        Me.pbMin.Location = New System.Drawing.Point(960, 3)
        Me.pbMin.Name = "pbMin"
        Me.pbMin.Size = New System.Drawing.Size(25, 25)
        Me.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMin.TabIndex = 1
        Me.pbMin.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCerrar.Image = Global.ABM.My.Resources.Resources.cerrar
        Me.pbCerrar.Location = New System.Drawing.Point(991, 3)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(25, 25)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 0
        Me.pbCerrar.TabStop = False
        '
        'ComboBoxTables
        '
        Me.ComboBoxTables.FormattingEnabled = True
        Me.ComboBoxTables.Location = New System.Drawing.Point(415, 169)
        Me.ComboBoxTables.Name = "ComboBoxTables"
        Me.ComboBoxTables.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTables.TabIndex = 0
        '
        'IconToolStripButton1
        '
        Me.IconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconToolStripButton1.IconColor = System.Drawing.Color.Black
        Me.IconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconToolStripButton1.Name = "IconToolStripButton1"
        Me.IconToolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconToolStripButton1.Text = "IconToolStripButton1"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 427)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.Text = "ABM VB.Net y SQL"
        Me.Panel1.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        CType(Me.pbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconToolStripButton1 As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxTables As ComboBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents pbCerrar As PictureBox
    Friend WithEvents pbMin As PictureBox
End Class
