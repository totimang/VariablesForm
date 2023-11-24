Public Class Form1

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim A, B, C, D, ANuevo, BNuevo, CNuevo, DNuevo As Single

        A = TxtA.Text
        ANuevo = TxtD.Text
        TxtANuevo.Text = ANuevo

        B = TxtB.Text
        BNuevo = TxtC.Text
        TxtBNuevo.Text = BNuevo

        C = TxtC.Text
        CNuevo = TxtA.Text
        TxtCNuevo.Text = CNuevo

        D = TxtD.Text
        DNuevo = TxtB.Text
        TxtDNuevo.Text = DNuevo



    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtA.Text = ""
        TxtB.Text = ""
        TxtC.Text = ""
        TxtD.Text = ""
        TxtANuevo.Clear()
        TxtBNuevo.Clear()
        TxtCNuevo.Clear()
        TxtDNuevo.Clear()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
