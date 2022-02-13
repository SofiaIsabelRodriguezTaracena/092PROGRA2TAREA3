Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Compradolar.Checked Then
            LabelFORM.Text = "la cantidad de tu compra es: " + Str(calcularcompra(Form1.textcompra.Text, TCdolar))
        End If

        If Form1.ventadolar.Checked Then
            LabelFORM.Text = "la cantidad de tu venta es: " + Str(calcularventa(Form1.textventa.Text, TCdolar))
        End If

        If Form1.comprapesos.Checked Then
            LabelFORM.Text = "la cantidad de tu compra es: " + Str(calcularcompra(Form1.textcompra.Text, TCpesos))
        End If

        If Form1.ventapesos.Checked Then
            LabelFORM.Text = "la cantidad de tu venta es: " + Str(calcularventa(Form1.textventa.Text, TCpesos))
        End If

        If Form1.compraeuros.Checked Then
            LabelFORM.Text = "la cantidad de tu compra es: " + Str(calcularcompra(Form1.textcompra.Text, TCeuro))
        End If

        If Form1.ventaeuros.Checked Then
            LabelFORM.Text = "la cantidad de tu venta es: " + Str(calcularventa(Form1.textventa.Text, TCeuro))
        End If

        If Form1.compracolones.Checked Then
            LabelFORM.Text = "la cantidad de tu compra es: " + Str(calcularcompra(Form1.textcompra.Text, TCcolones))
        End If

        If Form1.ventacolones.Checked Then
            LabelFORM.Text = "la cantidad de tu venta es: " + Str(calcularventa(Form1.textventa.Text, TCcolones))
        End If





    End Sub

    Private Sub LabelFORM_Click(sender As Object, e As EventArgs) Handles LabelFORM.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class