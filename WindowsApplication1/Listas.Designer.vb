<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listas
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
        Me.lstbxEfectivo = New System.Windows.Forms.ListBox()
        Me.lstbxCuotas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstbxEfectivo
        '
        Me.lstbxEfectivo.FormattingEnabled = True
        Me.lstbxEfectivo.Location = New System.Drawing.Point(48, 93)
        Me.lstbxEfectivo.Name = "lstbxEfectivo"
        Me.lstbxEfectivo.Size = New System.Drawing.Size(96, 108)
        Me.lstbxEfectivo.TabIndex = 0
        '
        'lstbxCuotas
        '
        Me.lstbxCuotas.FormattingEnabled = True
        Me.lstbxCuotas.Location = New System.Drawing.Point(195, 93)
        Me.lstbxCuotas.Name = "lstbxCuotas"
        Me.lstbxCuotas.Size = New System.Drawing.Size(96, 108)
        Me.lstbxCuotas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PAGO EFECTIVO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PAGO CUOTAS"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(137, 241)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(85, 35)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 378)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbxCuotas)
        Me.Controls.Add(Me.lstbxEfectivo)
        Me.Name = "Listas"
        Me.Text = "LISTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbxEfectivo As System.Windows.Forms.ListBox
    Friend WithEvents lstbxCuotas As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
