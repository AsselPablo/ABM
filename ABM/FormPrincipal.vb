Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormPrincipal
    Private connectionString As String
    Private connection As SqlConnection
    Private dataSet As DataSet

    Private Declare Function ReleaseCapture Lib "user32.dll" () As Boolean
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    ' Constante para el mensaje de mover formulario
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    ' Variables para manejar el estado del arrastre
    Private dragging As Boolean
    Private startPoint As Point

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        connection = New SqlConnection(connectionString)
        LoadData()
        PopulateComboBox()
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowOnly
    End Sub

    Private Sub LoadData()
        dataSet = New DataSet()
        Dim tables() As String = {"ventas", "ventasitems", "productos", "clientes"}

        For Each table As String In tables
            Dim query As String = $"SELECT * FROM {table};"
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.Fill(dataSet, table)
        Next
    End Sub

    Private Sub PopulateComboBox()
        ComboBoxTables.Items.Clear()
        For Each table As DataTable In dataSet.Tables
            ComboBoxTables.Items.Add(table.TableName)
        Next
    End Sub

    Private Sub ComboBoxTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTables.SelectedIndexChanged
        Dim selectedTable As String = ComboBoxTables.SelectedItem.ToString()

        ' Abrir el formulario secundario correspondiente según la tabla seleccionada
        Select Case selectedTable
            Case "ventas"
                Dim formVentas As New FormVentas()
                formVentas.ShowDialog()
            Case "ventasitems"
                Dim formVentasItems As New FormVentasItems()
                formVentasItems.ShowDialog()
            Case "productos"
                Dim formProductos As New FormProductos()
                formProductos.ShowDialog()
            Case "clientes"
                Dim formClientes As New FormClientes()
                formClientes.ShowDialog()
        End Select
    End Sub

    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        If e.Button = MouseButtons.Left Then
            dragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If dragging Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
            dragging = False
        End If
    End Sub

    Private Sub PanelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseUp
        If e.Button = MouseButtons.Left Then
            dragging = False
        End If
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Me.Close()
    End Sub

    Private Sub pbMin_Click(sender As Object, e As EventArgs) Handles pbMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class