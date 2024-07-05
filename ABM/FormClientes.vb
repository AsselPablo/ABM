Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormClientes

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar datos de clientes en el DataGridView al cargar el formulario
            LoadClientesData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Configurar el DataGridView
        dgvClientes.Dock = DockStyle.Fill
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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
                Dim query As String = "SELECT * FROM clientes;"
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                dataAdapter.Fill(dataSet, "clientes")
                dgvClientes.DataSource = dataSet.Tables("clientes")
            End Using
        Catch ex As Exception
            Throw New Exception("Error al cargar datos de clientes.", ex)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Validar que los campos no estén vacíos
        If txtNombre.Text.Trim() = "" Or txtDireccion.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determinar si se está guardando un nuevo cliente o modificando uno existente
        If BtnSave.Text = "Guardar" Then
            ' Insertar un nuevo cliente en la base de datos
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO clientes (cliente, telefono, correo) VALUES (@Cliente, @Telefono, @Correo);"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Cliente", txtNombre.Text.Trim())
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim())
                        command.Parameters.AddWithValue("@Correo", txtDireccion.Text.Trim())
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
        ElseIf BtnSave.Text = "Guardar Cambios" Then
            ' Actualizar los datos del cliente seleccionado en la base de datos
            Try
                ' Obtener el ID del cliente seleccionado
                Dim idCliente As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("ID").Value)

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE clientes SET cliente = @Cliente, telefono = @Telefono, correo = @Correo WHERE ID = @ID;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Cliente", txtNombre.Text.Trim())
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim())
                        command.Parameters.AddWithValue("@Correo", txtDireccion.Text.Trim())
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
                BtnSave.Text = "Guardar"
                btnMod.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Error al modificar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvClientes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un cliente para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los datos del cliente seleccionado
        Dim nombre As String = dgvClientes.SelectedRows(0).Cells("cliente").Value.ToString()
        Dim telefono As String = dgvClientes.SelectedRows(0).Cells("telefono").Value.ToString()
        Dim correo As String = dgvClientes.SelectedRows(0).Cells("correo").Value.ToString()

        ' Mostrar los datos del cliente seleccionado en los controles de entrada
        txtNombre.Text = nombre
        txtTelefono.Text = telefono
        txtDireccion.Text = correo

        ' Habilitar los controles de entrada para editar
        HabilitarControles(True)

        ' Cambiar el texto del botón de guardar para reflejar la operación de modificación
        BtnSave.Text = "Guardar Cambios"

        ' Deshabilitar el botón de modificar mientras se editan los datos
        BtnSave.Enabled = True
        btnMod.Enabled = False
    End Sub

    Private Sub LimpiarControles()
        ' Limpiar los controles de entrada
        txtNombre.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
    End Sub

    Private Sub HabilitarControles(enable As Boolean)
        ' Habilitar o deshabilitar los controles de entrada
        txtNombre.Enabled = enable
        txtTelefono.Enabled = enable
        txtDireccion.Enabled = enable
    End Sub

End Class