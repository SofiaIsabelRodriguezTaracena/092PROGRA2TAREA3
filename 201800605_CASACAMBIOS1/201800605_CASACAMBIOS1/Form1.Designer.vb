<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBVenta = New System.Windows.Forms.CheckBox()
        Me.CBCompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textventa = New System.Windows.Forms.TextBox()
        Me.textcompra = New System.Windows.Forms.TextBox()
        Me.compras = New System.Windows.Forms.GroupBox()
        Me.compracolones = New System.Windows.Forms.RadioButton()
        Me.compraeuros = New System.Windows.Forms.RadioButton()
        Me.comprapesos = New System.Windows.Forms.RadioButton()
        Me.Compradolar = New System.Windows.Forms.RadioButton()
        Me.ventas = New System.Windows.Forms.GroupBox()
        Me.ventacolones = New System.Windows.Forms.RadioButton()
        Me.ventaeuros = New System.Windows.Forms.RadioButton()
        Me.ventapesos = New System.Windows.Forms.RadioButton()
        Me.ventadolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.compras.SuspendLayout()
        Me.ventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CBVenta)
        Me.GroupBox1.Controls.Add(Me.CBCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSACCIONES"
        '
        'CBVenta
        '
        Me.CBVenta.AutoSize = True
        Me.CBVenta.Location = New System.Drawing.Point(6, 43)
        Me.CBVenta.Name = "CBVenta"
        Me.CBVenta.Size = New System.Drawing.Size(62, 17)
        Me.CBVenta.TabIndex = 1
        Me.CBVenta.Text = "VENTA"
        Me.CBVenta.UseVisualStyleBackColor = True
        '
        'CBCompra
        '
        Me.CBCompra.AutoSize = True
        Me.CBCompra.Location = New System.Drawing.Point(7, 20)
        Me.CBCompra.Name = "CBCompra"
        Me.CBCompra.Size = New System.Drawing.Size(72, 17)
        Me.CBCompra.TabIndex = 0
        Me.CBCompra.Text = "COMPRA"
        Me.CBCompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.textventa)
        Me.GroupBox2.Controls.Add(Me.textcompra)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESO DE CANTIDADES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "COMPRA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VENTA"
        '
        'textventa
        '
        Me.textventa.Enabled = False
        Me.textventa.Location = New System.Drawing.Point(72, 47)
        Me.textventa.Name = "textventa"
        Me.textventa.Size = New System.Drawing.Size(100, 20)
        Me.textventa.TabIndex = 1
        '
        'textcompra
        '
        Me.textcompra.Enabled = False
        Me.textcompra.Location = New System.Drawing.Point(72, 20)
        Me.textcompra.Name = "textcompra"
        Me.textcompra.Size = New System.Drawing.Size(100, 20)
        Me.textcompra.TabIndex = 0
        '
        'compras
        '
        Me.compras.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.compras.Controls.Add(Me.compracolones)
        Me.compras.Controls.Add(Me.compraeuros)
        Me.compras.Controls.Add(Me.comprapesos)
        Me.compras.Controls.Add(Me.Compradolar)
        Me.compras.Enabled = False
        Me.compras.Location = New System.Drawing.Point(12, 118)
        Me.compras.Name = "compras"
        Me.compras.Size = New System.Drawing.Size(179, 130)
        Me.compras.TabIndex = 2
        Me.compras.TabStop = False
        Me.compras.Text = "COMPRA"
        '
        'compracolones
        '
        Me.compracolones.AutoSize = True
        Me.compracolones.Location = New System.Drawing.Point(6, 88)
        Me.compracolones.Name = "compracolones"
        Me.compracolones.Size = New System.Drawing.Size(177, 17)
        Me.compracolones.TabIndex = 6
        Me.compracolones.TabStop = True
        Me.compracolones.Text = "COLONES COSTARRICENSES"
        Me.compracolones.UseVisualStyleBackColor = True
        '
        'compraeuros
        '
        Me.compraeuros.AutoSize = True
        Me.compraeuros.Location = New System.Drawing.Point(6, 65)
        Me.compraeuros.Name = "compraeuros"
        Me.compraeuros.Size = New System.Drawing.Size(63, 17)
        Me.compraeuros.TabIndex = 5
        Me.compraeuros.TabStop = True
        Me.compraeuros.Text = "EUROS"
        Me.compraeuros.UseVisualStyleBackColor = True
        '
        'comprapesos
        '
        Me.comprapesos.AutoSize = True
        Me.comprapesos.Location = New System.Drawing.Point(7, 42)
        Me.comprapesos.Name = "comprapesos"
        Me.comprapesos.Size = New System.Drawing.Size(127, 17)
        Me.comprapesos.TabIndex = 4
        Me.comprapesos.TabStop = True
        Me.comprapesos.Text = "PESOS MEXICANOS"
        Me.comprapesos.UseVisualStyleBackColor = True
        '
        'Compradolar
        '
        Me.Compradolar.AutoSize = True
        Me.Compradolar.Location = New System.Drawing.Point(7, 19)
        Me.Compradolar.Name = "Compradolar"
        Me.Compradolar.Size = New System.Drawing.Size(62, 17)
        Me.Compradolar.TabIndex = 3
        Me.Compradolar.TabStop = True
        Me.Compradolar.Text = "DÓLAR"
        Me.Compradolar.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.ventas.BackColor = System.Drawing.Color.Thistle
        Me.ventas.Controls.Add(Me.ventacolones)
        Me.ventas.Controls.Add(Me.ventaeuros)
        Me.ventas.Controls.Add(Me.ventapesos)
        Me.ventas.Controls.Add(Me.ventadolar)
        Me.ventas.Enabled = False
        Me.ventas.Location = New System.Drawing.Point(201, 118)
        Me.ventas.Name = "ventas"
        Me.ventas.Size = New System.Drawing.Size(179, 130)
        Me.ventas.TabIndex = 7
        Me.ventas.TabStop = False
        Me.ventas.Text = "VENTA"
        '
        'ventacolones
        '
        Me.ventacolones.AutoSize = True
        Me.ventacolones.Location = New System.Drawing.Point(6, 88)
        Me.ventacolones.Name = "ventacolones"
        Me.ventacolones.Size = New System.Drawing.Size(177, 17)
        Me.ventacolones.TabIndex = 6
        Me.ventacolones.TabStop = True
        Me.ventacolones.Text = "COLONES COSTARRICENSES"
        Me.ventacolones.UseVisualStyleBackColor = True
        '
        'ventaeuros
        '
        Me.ventaeuros.AutoSize = True
        Me.ventaeuros.Location = New System.Drawing.Point(6, 65)
        Me.ventaeuros.Name = "ventaeuros"
        Me.ventaeuros.Size = New System.Drawing.Size(63, 17)
        Me.ventaeuros.TabIndex = 5
        Me.ventaeuros.TabStop = True
        Me.ventaeuros.Text = "EUROS"
        Me.ventaeuros.UseVisualStyleBackColor = True
        '
        'ventapesos
        '
        Me.ventapesos.AutoSize = True
        Me.ventapesos.Location = New System.Drawing.Point(7, 42)
        Me.ventapesos.Name = "ventapesos"
        Me.ventapesos.Size = New System.Drawing.Size(127, 17)
        Me.ventapesos.TabIndex = 4
        Me.ventapesos.TabStop = True
        Me.ventapesos.Text = "PESOS MEXICANOS"
        Me.ventapesos.UseVisualStyleBackColor = True
        '
        'ventadolar
        '
        Me.ventadolar.AutoSize = True
        Me.ventadolar.Location = New System.Drawing.Point(7, 19)
        Me.ventadolar.Name = "ventadolar"
        Me.ventadolar.Size = New System.Drawing.Size(62, 17)
        Me.ventadolar.TabIndex = 3
        Me.ventadolar.TabStop = True
        Me.ventadolar.Text = "DÓLAR"
        Me.ventadolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONFIRMAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(386, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ventas)
        Me.Controls.Add(Me.compras)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.compras.ResumeLayout(False)
        Me.compras.PerformLayout()
        Me.ventas.ResumeLayout(False)
        Me.ventas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBVenta As CheckBox
    Friend WithEvents CBCompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textventa As TextBox
    Friend WithEvents textcompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents compras As GroupBox
    Friend WithEvents compracolones As RadioButton
    Friend WithEvents compraeuros As RadioButton
    Friend WithEvents comprapesos As RadioButton
    Friend WithEvents Compradolar As RadioButton
    Friend WithEvents ventas As GroupBox
    Friend WithEvents ventacolones As RadioButton
    Friend WithEvents ventaeuros As RadioButton
    Friend WithEvents ventapesos As RadioButton
    Friend WithEvents ventadolar As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
