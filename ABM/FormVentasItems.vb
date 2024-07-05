Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormVentasItems

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Private Sub FormVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar datos de clientes en el DataGridView al cargar el formulario
            LoadClientesData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Configurar el DataGridView
        dgvVentasItems.Dock = DockStyle.Fill
        dgvVentasItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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
                Dim query As String = "SELECT * FROM ventasitems;"
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                dataAdapter.Fill(dataSet, "ventasitems")
                dgvVentasItems.DataSource = dataSet.Tables("ventasitems")
            End Using
        Catch ex As Exception
            Throw New Exception("Error al cargar datos de ventasitems.", ex)
        End Try
    End Sub

    Private Sub BtnSave2_Click(sender As Object, e As EventArgs) Handles BtnSave2.Click
        ' Validar que los campos no estén vacíos
        If txtIdVenta.Text.Trim() = "" Or txtIdProducto.Text.Trim() = "" Or txtPrecioU.Text.Trim() = "" Or txtCantidad.Text.Trim() = "" Or txtTotal.Text.Trim() = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determinar si se está guardando un nuevo ID de Venta o modificando uno existente
        If BtnSave2.Text = "Guardar" Then
            ' Insertar un nuevo ID de Venta en la base de datos
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO ventasitems (idventa, idproducto, preciounitario, cantidad, preciototal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal);"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IDVenta", txtIdVenta.Text.Trim())
                        command.Parameters.AddWithValue("@IDProducto", txtIdProducto.Text.Trim())
                        command.Parameters.AddWithValue("@PrecioUnitario", txtPrecioU.Text.Trim())
                        command.Parameters.AddWithValue("@Cantidad", txtCantidad.Text.Trim())
                        command.Parameters.AddWithValue("@PrecioTotal", txtTotal.Text.Trim())
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Actualizar el DataGridView después de la inserción
                LoadClientesData()

                MessageBox.Show("ID de Venta agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los controles de entrada después de la inserción
                LimpiarControles()
                HabilitarControles(True)

            Catch ex As Exception
                MessageBox.Show("Error al agregar ID de Venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf BtnSave2.Text = "Guardar Cambios" Then
            ' Actualizar los datos del cliente seleccionado en la base de datos
            Try
                ' Obtener el ID del cliente seleccionado
                Dim idCliente As Integer = Convert.ToInt32(dgvVentasItems.SelectedRows(0).Cells("ID").Value)

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE ventasitems SET idventa = @IDVenta, idproducto = @IDProducto, preciounitari = @PrecioUnitario, cantidad = @Cantidad, preciototal = @PrecioTotal WHERE ID = @ID;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IDVenta", txtIdVenta.Text.Trim())
                        command.Parameters.AddWithValue("@IDProducto", txtIdProducto.Text.Trim())
                        command.Parameters.AddWithValue("@PrecioUnitario", txtPrecioU.Text.Trim())
                        command.Parameters.AddWithValue("@Cantidad", txtCantidad.Text.Trim())
                        command.Parameters.AddWithValue("@PrecioTotal", txtTotal.Text.Trim())
                        command.Parameters.AddWithValue("@ID", idCliente)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Actualizar el DataGridView después de la modificación
                LoadClientesData()

                MessageBox.Show("ID de Venta modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar y restablecer los controles después de la modificación
                LimpiarControles()
                HabilitarControles(True)

                ' Cambiar el texto del botón de guardar de vuelta a "Guardar"
                BtnSave2.Text = "Guardar"
                btnMod2.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Error al modificar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnMod2_Click(sender As Object, e As EventArgs) Handles btnMod2.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvVentasItems.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un ID de Venta para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener los datos del cliente seleccionado
        Dim idventa As String = dgvVentasItems.SelectedRows(0).Cells("idventa").Value.ToString()
        Dim idproducto As String = dgvVentasItems.SelectedRows(0).Cells("idproducto").Value.ToString()
        Dim preciounitario As String = dgvVentasItems.SelectedRows(0).Cells("preciounitario").Value.ToString()
        Dim cantidad As String = dgvVentasItems.SelectedRows(0).Cells("cantidad").Value.ToString()
        Dim preciototal As String = dgvVentasItems.SelectedRows(0).Cells("preciototal").Value.ToString()

        ' Mostrar los datos del cliente seleccionado en los controles de entrada
        txtIdVenta.Text = idventa
        txtIdProducto.Text = idproducto
        txtPrecioU.Text = preciounitario
        txtCantidad.Text = cantidad
        txtTotal.Text = preciototal

        ' Habilitar los controles de entrada para editar
        HabilitarControles(True)

        ' Cambiar el texto del botón de guardar para reflejar la operación de modificación
        BtnSave2.Text = "Guardar Cambios"

        ' Deshabilitar el botón de modificar mientras se editan los datos
        BtnSave2.Enabled = True
        btnMod2.Enabled = False
    End Sub

    Private Sub LimpiarControles()
        ' Limpiar los controles de entrada
        txtIdVenta.Clear()
        txtIdProducto.Clear()
        txtPrecioU.Clear()
        txtCantidad.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub HabilitarControles(enable As Boolean)
        ' Habilitar o deshabilitar los controles de entrada
        txtIdVenta.Enabled = enable
        txtIdProducto.Enabled = enable
        txtPrecioU.Enabled = enable
        txtCantidad.Enabled = enable
        txtTotal.Enabled = enable
    End Sub

End Class