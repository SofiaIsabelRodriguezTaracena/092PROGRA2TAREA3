Public Class Form1
    Private Sub CBCompra_CheckedChanged(sender As Object, e As EventArgs) Handles CBCompra.CheckedChanged
        If CBCompra.Checked = True Then
            textcompra.Enabled = True
            compras.Enabled = True
        Else
            textcompra.Enabled = False

        End If
    End Sub

    Private Sub CBVenta_CheckedChanged(sender As Object, e As EventArgs) Handles CBVenta.CheckedChanged
        If CBVenta.Checked = True Then
            textventa.Enabled = True
            ventas.Enabled = True
        Else
            textventa.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "pregunta") = vbYes Then
            End
        End If
    End Sub


End Class



