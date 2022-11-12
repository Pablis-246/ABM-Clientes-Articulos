Public Class Articulos
    Dim unidades As Integer = 0
    Dim precioUnidad As Integer = 0
    Dim PrecioEfectivo As Integer = 0
    Dim PrecioEfectivoDescuento As Double = 0
    Dim PrecioCuotas As Integer = 0
    Dim PrecioCoutasAumento As Double = 0

    Public Function ObtenerPrecioUnitario()
        Return precioUnidad
    End Function

    Public Function ObtenerUnidades()
        Return unidades
    End Function

    Public Function CalcularPrecioEfectivo()
        PrecioEfectivo = precioUnidad * unidades
        PrecioEfectivoDescuento = PrecioEfectivo - ((10 * PrecioEfectivo) / 100)
        Return PrecioEfectivoDescuento
    End Function

    Public Function CalcularPrecioCuotas()
        PrecioCuotas = precioUnidad * unidades
        PrecioCoutasAumento = PrecioCuotas + (15 * PrecioCuotas) / 100
        Return PrecioCoutasAumento
    End Function

    Private Sub rdbtn6_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn6.CheckedChanged
        unidades = 6
    End Sub
    Private Sub rdbtn12_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn12.CheckedChanged
        unidades = 12
    End Sub
    Private Sub rdbtnOtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnOtra.CheckedChanged
        If rdbtnOtra.Checked Then
            NumericUpDownOtra.Visible = True
        Else
            NumericUpDownOtra.Visible = False
            unidades = 0
        End If
    End Sub
    Private Sub NumericUpDownOtra_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownOtra.ValueChanged
        unidades = NumericUpDownOtra.Value
    End Sub

    Private Sub NumericUpDownPrecio_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownPrecio.ValueChanged
        precioUnidad = NumericUpDownPrecio.Value
    End Sub

    Private Sub btnCalculo_Click(sender As Object, e As EventArgs) Handles btnCalculo.Click
        If unidades = 0 Then
            MsgBox("Falta elegir cantidad unidades")
            Return
        End If
        If NumericUpDownPrecio.Value = 0 Then
            MsgBox("Falta elegir un precio por unidad")
            Return
        End If

        lblEfectivo.Visible = True
        lblCuotas.Visible = True
        lblEfectivo.Text = "Precio en efectivo: $" + CalcularPrecioEfectivo().ToString()
        lblCuotas.Text = "Precio en cuotas: $" + CalcularPrecioCuotas().ToString()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click

        If cmbxArticulos.Text = "" Then
            MsgBox("Especificar el articulo para poder continuar")
            Return
        ElseIf unidades = 0 Then
            MsgBox("Debe elegir las unidades para poder continuar")
            Return
        ElseIf precioUnidad = 0 Then
            MsgBox("Debe elegir el precio para poder continuar")
            Return
        End If

        Liquidacion.Show()
        Me.Close()
    End Sub
End Class