<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Me.cmbxArticulos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbtn6 = New System.Windows.Forms.RadioButton()
        Me.rdbtn12 = New System.Windows.Forms.RadioButton()
        Me.rdbtnOtra = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculo = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.NumericUpDownOtra = New System.Windows.Forms.NumericUpDown()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.lblCuotas = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbxArticulos
        '
        Me.cmbxArticulos.FormattingEnabled = True
        Me.cmbxArticulos.Items.AddRange(New Object() {"BLOCK LISO", "BLOCK RAYADO", "CARPETA", "CUADERNO", "LAPICERA", "LAPIZ HB"})
        Me.cmbxArticulos.Location = New System.Drawing.Point(21, 58)
        Me.cmbxArticulos.Name = "cmbxArticulos"
        Me.cmbxArticulos.Size = New System.Drawing.Size(121, 21)
        Me.cmbxArticulos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIDADES"
        '
        'rdbtn6
        '
        Me.rdbtn6.AutoSize = True
        Me.rdbtn6.Location = New System.Drawing.Point(195, 63)
        Me.rdbtn6.Name = "rdbtn6"
        Me.rdbtn6.Size = New System.Drawing.Size(31, 17)
        Me.rdbtn6.TabIndex = 2
        Me.rdbtn6.TabStop = True
        Me.rdbtn6.Tag = ""
        Me.rdbtn6.Text = "6"
        Me.rdbtn6.UseVisualStyleBackColor = True
        '
        'rdbtn12
        '
        Me.rdbtn12.AutoSize = True
        Me.rdbtn12.Location = New System.Drawing.Point(195, 93)
        Me.rdbtn12.Name = "rdbtn12"
        Me.rdbtn12.Size = New System.Drawing.Size(37, 17)
        Me.rdbtn12.TabIndex = 3
        Me.rdbtn12.TabStop = True
        Me.rdbtn12.Text = "12"
        Me.rdbtn12.UseVisualStyleBackColor = True
        '
        'rdbtnOtra
        '
        Me.rdbtnOtra.AutoSize = True
        Me.rdbtnOtra.Location = New System.Drawing.Point(195, 123)
        Me.rdbtnOtra.Name = "rdbtnOtra"
        Me.rdbtnOtra.Size = New System.Drawing.Size(55, 17)
        Me.rdbtnOtra.TabIndex = 4
        Me.rdbtnOtra.TabStop = True
        Me.rdbtnOtra.Text = "OTRA"
        Me.rdbtnOtra.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ARTICULOS"
        '
        'NumericUpDownPrecio
        '
        Me.NumericUpDownPrecio.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPrecio.InterceptArrowKeys = False
        Me.NumericUpDownPrecio.Location = New System.Drawing.Point(222, 219)
        Me.NumericUpDownPrecio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownPrecio.Name = "NumericUpDownPrecio"
        Me.NumericUpDownPrecio.Size = New System.Drawing.Size(110, 23)
        Me.NumericUpDownPrecio.TabIndex = 6
        Me.NumericUpDownPrecio.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRECIO (por unidad)"
        '
        'btnCalculo
        '
        Me.btnCalculo.Location = New System.Drawing.Point(57, 273)
        Me.btnCalculo.Name = "btnCalculo"
        Me.btnCalculo.Size = New System.Drawing.Size(85, 35)
        Me.btnCalculo.TabIndex = 8
        Me.btnCalculo.Text = "CALCULO"
        Me.btnCalculo.UseVisualStyleBackColor = True
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(222, 274)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(85, 35)
        Me.btnContinuar.TabIndex = 9
        Me.btnContinuar.Text = "CONTINUAR"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'NumericUpDownOtra
        '
        Me.NumericUpDownOtra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownOtra.InterceptArrowKeys = False
        Me.NumericUpDownOtra.Location = New System.Drawing.Point(279, 117)
        Me.NumericUpDownOtra.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownOtra.Name = "NumericUpDownOtra"
        Me.NumericUpDownOtra.Size = New System.Drawing.Size(45, 23)
        Me.NumericUpDownOtra.TabIndex = 10
        Me.NumericUpDownOtra.ThousandsSeparator = True
        Me.NumericUpDownOtra.Visible = False
        '
        'lblEfectivo
        '
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Location = New System.Drawing.Point(12, 186)
        Me.lblEfectivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(99, 13)
        Me.lblEfectivo.TabIndex = 11
        Me.lblEfectivo.Text = "Precio en efectivo: "
        Me.lblEfectivo.Visible = False
        '
        'lblCuotas
        '
        Me.lblCuotas.AutoSize = True
        Me.lblCuotas.Location = New System.Drawing.Point(12, 208)
        Me.lblCuotas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(93, 13)
        Me.lblCuotas.TabIndex = 12
        Me.lblCuotas.Text = "Precio en cuotas: "
        Me.lblCuotas.Visible = False
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 378)
        Me.Controls.Add(Me.lblCuotas)
        Me.Controls.Add(Me.lblEfectivo)
        Me.Controls.Add(Me.NumericUpDownOtra)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.btnCalculo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbtnOtra)
        Me.Controls.Add(Me.rdbtn12)
        Me.Controls.Add(Me.rdbtn6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbxArticulos)
        Me.Name = "Articulos"
        Me.Text = "ARTICULOS"
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbxArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbtn6 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn12 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnOtra As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculo As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownOtra As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblEfectivo As Label
    Friend WithEvents lblCuotas As Label
End Class
