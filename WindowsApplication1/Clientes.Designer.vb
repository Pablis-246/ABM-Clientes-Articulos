<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbtnEfectivo = New System.Windows.Forms.RadioButton()
        Me.rdbtnCuotas = New System.Windows.Forms.RadioButton()
        Me.btnCarga = New System.Windows.Forms.Button()
        Me.btnListas = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnFIN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 77)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(119, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forma de Pago"
        '
        'rdbtnEfectivo
        '
        Me.rdbtnEfectivo.AutoSize = True
        Me.rdbtnEfectivo.Location = New System.Drawing.Point(175, 123)
        Me.rdbtnEfectivo.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnEfectivo.Name = "rdbtnEfectivo"
        Me.rdbtnEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rdbtnEfectivo.TabIndex = 3
        Me.rdbtnEfectivo.TabStop = True
        Me.rdbtnEfectivo.Text = "Efectivo"
        Me.rdbtnEfectivo.UseVisualStyleBackColor = True
        '
        'rdbtnCuotas
        '
        Me.rdbtnCuotas.AutoSize = True
        Me.rdbtnCuotas.Location = New System.Drawing.Point(175, 145)
        Me.rdbtnCuotas.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnCuotas.Name = "rdbtnCuotas"
        Me.rdbtnCuotas.Size = New System.Drawing.Size(58, 17)
        Me.rdbtnCuotas.TabIndex = 4
        Me.rdbtnCuotas.TabStop = True
        Me.rdbtnCuotas.Text = "Cuotas"
        Me.rdbtnCuotas.UseVisualStyleBackColor = True
        '
        'btnCarga
        '
        Me.btnCarga.Location = New System.Drawing.Point(10, 195)
        Me.btnCarga.Name = "btnCarga"
        Me.btnCarga.Size = New System.Drawing.Size(85, 35)
        Me.btnCarga.TabIndex = 7
        Me.btnCarga.Text = "CARGA"
        Me.btnCarga.UseVisualStyleBackColor = True
        '
        'btnListas
        '
        Me.btnListas.Location = New System.Drawing.Point(127, 195)
        Me.btnListas.Name = "btnListas"
        Me.btnListas.Size = New System.Drawing.Size(85, 35)
        Me.btnListas.TabIndex = 8
        Me.btnListas.Text = "VER LISTAS"
        Me.btnListas.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(243, 195)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(85, 35)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnFIN
        '
        Me.btnFIN.Location = New System.Drawing.Point(127, 260)
        Me.btnFIN.Name = "btnFIN"
        Me.btnFIN.Size = New System.Drawing.Size(85, 35)
        Me.btnFIN.TabIndex = 10
        Me.btnFIN.Text = "FIN"
        Me.btnFIN.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 366)
        Me.Controls.Add(Me.btnFIN)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnListas)
        Me.Controls.Add(Me.btnCarga)
        Me.Controls.Add(Me.rdbtnCuotas)
        Me.Controls.Add(Me.rdbtnEfectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Clientes"
        Me.Text = "CARGA DE CLIENTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbtnEfectivo As RadioButton
    Friend WithEvents rdbtnCuotas As RadioButton
    Friend WithEvents btnCarga As Button
    Friend WithEvents btnListas As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnFIN As Button
End Class
