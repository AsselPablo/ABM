Imports System.Configuration
Imports System.Data.SqlClient
Public Class FormVentas

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar datos de ventas en el DataGridView al cargar el formulario
            LoadClientesData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Configurar el DataGridView
        dgvVentas.Dock = DockStyle.Fill
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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
                Dim query As String = "SELECT * FROM ventas;"
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                dataAdapter.Fill(dataSet, "ventas")
                dgvVentas.DataSource = dataSet.Tables("ventas")
            End Using
        Catch ex As Exception
            Throw New Exception("Error al cargar datos de ventas.", ex)
        End Try
    End Sub

    Private Sub BtnSave3_Click(sender As Object, e As EventArgs) Handles BtnSave3.Click
        ' Validar que los campos no estén vacíos
        If txtIdCliente.Text.Trim() = "" Or txtTootal.Text.Trim() = "" Or txtFecha.Text.Trim() = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determinar si se está guardando una nueva venta o modificando una existente
        If BtnSave3.Text = "Guardar" Then
            ' Insertar una nueva venta en la base de datos
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO ventas (idcliente, fecha, total) VALUES (@IDCliente, @Fecha, @Total);"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IDCliente", txtIdCliente.Text.Trim())
                        command.Parameters.AddWithValue("@Fecha", txtFecha.Text.Trim())
                        command.Parameters.AddWithValue("@Total", txtTootal.Text.Trim())
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
                MessageBox.Show("Error al agregar una venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf BtnSave3.Text = "Guardar Cambios" Then
            ' Actualizar los datos del venta seleccionado en la base de datos
            Try
                ' Obtener el ID del cliente seleccionado
                Dim idCliente As Integer = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("ID").Value)

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE ventas SET idcliente = @IDCliente, fecha = @Fecha, total = @Total WHERE ID = @ID;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IDCliente", txtIdCliente.Text.Trim())
                        command.Parameters.AddWithValue("@Fecha", txtFecha.Text.Trim())
                        command.Parameters.AddWithValue("@Total", txtTootal.Text.Trim())
                        command.Parameters.AddWithValue("@ID", idCliente)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Actualizar el DataGridView después de la modificación
                LoadClientesData()

                MessageBox.Show("Venta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar y restablecer los controles después de la modificación
                LimpiarControles()
                HabilitarControles(True)

                ' Cambiar el texto del botón de guardar de vuelta a "Guardar"
                BtnSave3.Text = "Guardar"
                btnMod3.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Error al modificar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMod3_Click(sender As Object, e As EventArgs) Handles btnMod3.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvVentas.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una venta para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los datos de la venta seleccionado
        Dim idcliente As String = dgvVentas.SelectedRows(0).Cells("idcliente").Value.ToString()
        Dim fecha As String = dgvVentas.SelectedRows(0).Cells("fecha").Value.ToString()
        Dim total As String = dgvVentas.SelectedRows(0).Cells("total").Value.ToString()

        ' Mostrar los datos de la venta seleccionado en los controles de entrada
        txtIdCliente.Text = idcliente
        txtFecha.Text = fecha
        txtTootal.Text = total

        ' Habilitar los controles de entrada para editar
        HabilitarControles(True)

        ' Cambiar el texto del botón de guardar para reflejar la operación de modificación
        BtnSave3.Text = "Guardar Cambios"

        ' Deshabilitar el botón de modificar mientras se editan los datos
        BtnSave3.Enabled = True
        btnMod3.Enabled = False
    End Sub

    Private Sub LimpiarControles()
        ' Limpiar los controles de entrada
        txtIdCliente.Clear()
        txtFecha.Clear()
        txtTootal.Clear()
    End Sub

    Private Sub HabilitarControles(enable As Boolean)
        ' Habilitar o deshabilitar los controles de entrada
        txtIdCliente.Enabled = enable
        txtFecha.Enabled = enable
        txtTootal.Enabled = enable
    End Sub

End Class