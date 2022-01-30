Public Class Form1

    Const precioarroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIva As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoconIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Txtarroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtfrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtfrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Btnaceptar_Click(sender As Object, e As EventArgs) Handles Btnaceptar.Click
        pagoSinIva = Txtarroz.Text * precioarroz + Txtfrijol.Text * preciofrijol + Txtazucar.Text * precioazucar
        valorIVA = pagoSinIva * IVA
        pagoconIVA = pagoSinIva + valorIVA
        descuento = pagoconIVA * 0.025
        pagofinal = pagoconIVA - descuento

        LblR1.Text = pagoSinIva
        LblR2.Text = valorIVA
        LblR3.Text = pagoconIVA
        LblR4.Text = descuento
        LblR5.Text = pagofinal

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Txtarroz.Clear()
        Txtazucar.Clear()
        Txtfrijol.Clear()
        LblR1.Text = 0.0
        LblR2.Text = 0.0
        LblR3.Text = 0.0
        LblR4.Text = 0.0
        LblR5.Text = 0.0



    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
