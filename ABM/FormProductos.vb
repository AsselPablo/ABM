Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormProductos

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar datos de clientes en el DataGridView al cargar el formulario
            LoadClientesData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Configurar el DataGridView
        dgvProductos.Dock = DockStyle.Fill
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Configurar el formulario
        MinimumSize = New Size(1035, 500)
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        FormBorderStyle = FormBorderStyle.FixedSingle

        ' Inicialmente habilitar los controles de entrada
        HabilitarControles(True)
    End Sub

    Private Sub LoadClientesData()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM productos;"
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                dataAdapter.Fill(dataSet, "productos")
                dgvProductos.DataSource = dataSet.Tables("productos")
            End Using
        Catch ex As Exception
            Throw New Exception("Error al cargar datos de clientes.", ex)
        End Try
    End Sub

    Private Sub BtnSave1_Click(sender As Object, e As EventArgs) Handles BtnSave1.Click
        ' Validar que los campos no estén vacíos
        If txtNombre1.Text.Trim() = "" Or txtCat.Text.Trim() = "" Or txtPrecio.Text.Trim() = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determinar si se está guardando un nuevo producto o modificando uno existente
        If BtnSave1.Text = "Guardar" Then
            ' Insertar un nuevo producto en la base de datos
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO productos (nombre, precio, categoria) VALUES (@Nombre, @Precio, @Categoria);"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Nombre", txtNombre1.Text.Trim())
                        command.Parameters.AddWithValue("@Precio", txtPrecio.Text.Trim())
                        command.Parameters.AddWithValue("@Categoria", txtCat.Text.Trim())
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Actualizar el DataGridView después de la inserción
                LoadClientesData()

                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los controles de entrada después de la inserción
                LimpiarControles()
                HabilitarControles(True)

            Catch ex As Exception
                MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf BtnSave1.Text = "Guardar Cambios" Then
            ' Actualizar los datos del producto seleccionado en la base de datos
            Try
                ' Obtener el ID del producto seleccionado
                Dim idCliente As Integer = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("ID").Value)

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE productos SET nombre = @Nombre, precio = @Precio, categoria = @Categoria WHERE ID = @ID;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Nombre", txtNombre1.Text.Trim())
                        command.Parameters.AddWithValue("@Precio", txtPrecio.Text.Trim())
                        command.Parameters.AddWithValue("@Categoria", txtCat.Text.Trim())
                        command.Parameters.AddWithValue("@ID", idCliente)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Actualizar el DataGridView después de la modificación
                LoadClientesData()

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar y restablecer los controles después de la modificación
                LimpiarControles()
                HabilitarControles(True)

                ' Cambiar el texto del botón de guardar de vuelta a "Guardar"
                BtnSave1.Text = "Guardar"
                btnMod1.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Error al modificar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMod1_Click(sender As Object, e As EventArgs) Handles btnMod1.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvProductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los datos del producto seleccionado
        Dim nombre As String = dgvProductos.SelectedRows(0).Cells("nombre").Value.ToString()
        Dim precio As String = dgvProductos.SelectedRows(0).Cells("precio").Value.ToString()
        Dim categoria As String = dgvProductos.SelectedRows(0).Cells("categoria").Value.ToString()

        ' Mostrar los datos del producto seleccionado en los controles de entrada
        txtNombre1.Text = nombre
        txtPrecio.Text = precio
        txtCat.Text = categoria

        ' Habilitar los controles de entrada para editar
        HabilitarControles(True)

        ' Cambiar el texto del botón de guardar para reflejar la operación de modificación
        BtnSave1.Text = "Guardar Cambios"

        ' Deshabilitar el botón de modificar mientras se editan los datos
        BtnSave1.Enabled = True
        btnMod1.Enabled = False
    End Sub

    Private Sub LimpiarControles()
        ' Limpiar los controles de entrada
        txtNombre1.Clear()
        txtPrecio.Clear()
        txtCat.Clear()
    End Sub

    Private Sub HabilitarControles(enable As Boolean)
        ' Habilitar o deshabilitar los controles de entrada
        txtNombre1.Enabled = enable
        txtPrecio.Enabled = enable
        txtCat.Enabled = enable
    End Sub

End Class