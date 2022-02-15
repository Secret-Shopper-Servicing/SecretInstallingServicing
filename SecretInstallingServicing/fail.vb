Public Class fail
    Dim donepeptalk As Boolean = False
    Private Sub fail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If donepeptalk = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub fail_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        donepeptalk = False
        Button1.Enabled = False
        Waiting.Enabled = True
        My.Computer.Audio.Play(My.Resources.DTFailure, AudioPlayMode.Background)
    End Sub

    Private Sub Waiting_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Waiting.Tick
        donepeptalk = True
        Button1.Enabled = True
        Waiting.Enabled = False
    End Sub
End Class