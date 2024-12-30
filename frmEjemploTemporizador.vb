Public Class frmEjemploTemporizador
    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        lblReloj.Text = TimeOfDay
    End Sub
End Class