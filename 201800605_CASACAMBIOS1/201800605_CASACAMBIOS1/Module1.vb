Module Module1
    Public Const TCdolar = 7.69
    Public Const TCpesos = 0.38
    Public Const TCeuro = 7.89
    Public Const TCcolones = 0.012
    Public Const comisiondecompra = 2.5 / 100
    Public Const comisiondeventa = 3 / 100

    Dim totalparcial = 0
    Dim total

    Sub Limpiar()
        Form1.textcompra.Clear()
        Form1.textventa.Clear()

        Form1.CBCompra.Checked = False
        Form1.CBVenta.Checked = False
    End Sub

    Function calcularcompra(Cantidadcompra As Double, tipocompra As Double) As Double

        If Cantidadcompra > 0 Then
            totalparcial = Cantidadcompra / tipocompra
            total = totalparcial * comisiondecompra + totalparcial

        End If
        Return Math.Round(total, 2)
    End Function

    Function calcularventa(Cantidadventa As Double, tipoventa As Double) As Double

        If Cantidadventa > 0 Then
            totalparcial = Cantidadventa * tipoventa
            total = totalparcial * comisiondeventa + totalparcial

        End If
        Return Math.Round(total, 2)
    End Function
End Module
