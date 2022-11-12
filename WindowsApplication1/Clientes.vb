Public Class Clientes
    Private Sub btnCarga_Click(sender As Object, e As EventArgs) Handles btnCarga.Click
        If txtNombre.Text = "" Then
            MsgBox("Falta cargar el nombre!!")
            Return
        End If
        If Not rdbtnEfectivo.Checked And Not rdbtnCuotas.Checked Then
            MsgBox("Falta elegir un metodo de pago!!")
            Return
        End If

        Dim cliente As String = txtNombre.Text
        If Listas.lstbxEfectivo.Items.Contains(cliente) Or Listas.lstbxCuotas.Items.Contains(cliente) Then
            MsgBox("El cliente ya esta registrado")
            Return
        End If

        If rdbtnEfectivo.Checked Then
            Listas.lstbxEfectivo.Items.Add(cliente)
        ElseIf rdbtnCuotas.Checked Then
            Listas.lstbxCuotas.Items.Add(cliente)
        End If

        txtNombre.Text = ""
        rdbtnEfectivo.Checked = False
        rdbtnCuotas.Checked = False
    End Sub

    Private Sub btnListas_Click(sender As Object, e As EventArgs) Handles btnListas.Click
        Listas.Show()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Articulos.Show()
    End Sub

    Private Sub btnFIN_Click(sender As Object, e As EventArgs) Handles btnFIN.Click
        Me.Close()
    End Sub
End Class