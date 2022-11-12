<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Liquidacion
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
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelNombreArticulo = New System.Windows.Forms.Label()
        Me.LabelCantYPrecio = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.btnListas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxMetodopago = New System.Windows.Forms.TextBox()
        Me.txtbxCliente = New System.Windows.Forms.TextBox()
        Me.txtbxArticulo = New System.Windows.Forms.TextBox()
        Me.txtbxCantidadPrecio = New System.Windows.Forms.TextBox()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Location = New System.Drawing.Point(92, 15)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(95, 13)
        Me.LabelNombreCliente.TabIndex = 0
        Me.LabelNombreCliente.Text = "Nombre del cliente"
        '
        'LabelNombreArticulo
        '
        Me.LabelNombreArticulo.AutoSize = True
        Me.LabelNombreArticulo.Location = New System.Drawing.Point(88, 67)
        Me.LabelNombreArticulo.Name = "LabelNombreArticulo"
        Me.LabelNombreArticulo.Size = New System.Drawing.Size(98, 13)
        Me.LabelNombreArticulo.TabIndex = 1
        Me.LabelNombreArticulo.Text = "Nombre del articulo"
        '
        'LabelCantYPrecio
        '
        Me.LabelCantYPrecio.AutoSize = True
        Me.LabelCantYPrecio.Location = New System.Drawing.Point(80, 195)
        Me.LabelCantYPrecio.Name = "LabelCantYPrecio"
        Me.LabelCantYPrecio.Size = New System.Drawing.Size(126, 13)
        Me.LabelCantYPrecio.TabIndex = 2
        Me.LabelCantYPrecio.Text = "Cantidad y precio unitario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(99, 258)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(76, 13)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Total a abonar"
        '
        'btnListas
        '
        Me.btnListas.Location = New System.Drawing.Point(96, 317)
        Me.btnListas.Name = "btnListas"
        Me.btnListas.Size = New System.Drawing.Size(85, 46)
        Me.btnListas.TabIndex = 9
        Me.btnListas.Text = "VER LAS LISTAS"
        Me.btnListas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Metodo de Pago"
        '
        'txtbxMetodopago
        '
        Me.txtbxMetodopago.Location = New System.Drawing.Point(91, 151)
        Me.txtbxMetodopago.Name = "txtbxMetodopago"
        Me.txtbxMetodopago.Size = New System.Drawing.Size(94, 20)
        Me.txtbxMetodopago.TabIndex = 15
        '
        'txtbxCliente
        '
        Me.txtbxCliente.Location = New System.Drawing.Point(95, 36)
        Me.txtbxCliente.Name = "txtbxCliente"
        Me.txtbxCliente.Size = New System.Drawing.Size(94, 20)
        Me.txtbxCliente.TabIndex = 16
        '
        'txtbxArticulo
        '
        Me.txtbxArticulo.Location = New System.Drawing.Point(91, 89)
        Me.txtbxArticulo.Name = "txtbxArticulo"
        Me.txtbxArticulo.Size = New System.Drawing.Size(94, 20)
        Me.txtbxArticulo.TabIndex = 17
        '
        'txtbxCantidadPrecio
        '
        Me.txtbxCantidadPrecio.Location = New System.Drawing.Point(94, 217)
        Me.txtbxCantidadPrecio.Name = "txtbxCantidadPrecio"
        Me.txtbxCantidadPrecio.Size = New System.Drawing.Size(94, 20)
        Me.txtbxCantidadPrecio.TabIndex = 18
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Location = New System.Drawing.Point(91, 279)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.Size = New System.Drawing.Size(94, 20)
        Me.txtbxTotal.TabIndex = 19
        '
        'Liquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 397)
        Me.Controls.Add(Me.txtbxTotal)
        Me.Controls.Add(Me.txtbxCantidadPrecio)
        Me.Controls.Add(Me.txtbxArticulo)
        Me.Controls.Add(Me.txtbxCliente)
        Me.Controls.Add(Me.txtbxMetodopago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnListas)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelCantYPrecio)
        Me.Controls.Add(Me.LabelNombreArticulo)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Name = "Liquidacion"
        Me.Text = "LIQUIDACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNombreCliente As System.Windows.Forms.Label
    Friend WithEvents LabelNombreArticulo As System.Windows.Forms.Label
    Friend WithEvents LabelCantYPrecio As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents btnListas As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxMetodopago As TextBox
    Friend WithEvents txtbxCliente As TextBox
    Friend WithEvents txtbxArticulo As TextBox
    Friend WithEvents txtbxCantidadPrecio As TextBox
    Friend WithEvents txtbxTotal As TextBox
End Class
