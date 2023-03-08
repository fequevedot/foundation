Public Class frmPrincipal
    Private Sub btnSalid_Click(sender As Object, e As EventArgs) Handles btnSalid.Click
        Close()
    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        MsgBox("Mensaje")
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        frmUsuarios.Show()
    End Sub
End Class
