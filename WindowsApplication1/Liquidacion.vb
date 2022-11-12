Public Class Liquidacion
    Dim cliente As String
    Dim lista As String
    Dim precio As Integer
    Private Sub Liquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente = InputBox("Ingrese nombre del cliente")
        While Not Listas.lstbxEfectivo.Items.Contains(cliente) And Not Listas.lstbxCuotas.Items.Contains(cliente)
            MsgBox("El cliente que ingreso no se encuentra en la lista de efectivo o cuotas")
            cliente = InputBox("Ingrese nombre del cliente")
        End While

        If Listas.lstbxEfectivo.Items.Contains(cliente) Then
            lista = "Efectivo"
            precio = Articulos.CalcularPrecioEfectivo()
        Else
            lista = "Cuotas"
            precio = Articulos.CalcularPrecioCuotas()
        End If

        txtbxCliente.Text = cliente
        txtbxArticulo.Text = Articulos.cmbxArticulos.Text
        txtbxMetodopago.Text = lista.ToString
        txtbxCantidadPrecio.Text = $"{Articulos.ObtenerUnidades()}  x  ${Articulos.ObtenerPrecioUnitario()}"
        txtbxTotal.Text = "$" + precio.ToString()
    End Sub

    Private Sub btnListas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListas.Click
        Dim result As DialogResult = MessageBox.Show("¿Desea realizar el pago?", "Confirmacion", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            If lista = "efectivo" Then
                Listas.lstbxEfectivo.Items.Remove(cliente)
            ElseIf lista = "cuotas" Then
                Listas.lstbxCuotas.Items.Remove(cliente)
            End If
            MsgBox($"El cliente se elimino de la lista {lista}")
        End If

        Clientes.Show()
        Me.Close()
    End Sub
End Class