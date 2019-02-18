Public Class Form6

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 20
        If ProgressBar1.Value = 100 Then
            LoginForm1.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
End Class