Public Class thankyou

    Private Sub thankyou_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim num As Integer
        Dim r As New Random()

        num = r.Next(1, 8)

        If num = 1 Then
            'PictureBox1.Image = My.Resources.ty1
            PictureBox1.BackgroundImage = My.Resources.ty1
        ElseIf num = 2 Then
            'PictureBox1.Image = My.Resources.ty2
            PictureBox1.BackgroundImage = My.Resources.ty2
        ElseIf num = 3 Then
            'PictureBox1.Image = My.Resources.ty3
            PictureBox1.BackgroundImage = My.Resources.ty3
        ElseIf num = 4 Then
            'PictureBox1.Image = My.Resources.ty4
            PictureBox1.BackgroundImage = My.Resources.ty4
        ElseIf num = 5 Then
            'PictureBox1.Image = My.Resources.ty5
            PictureBox1.BackgroundImage = My.Resources.ty5
        ElseIf num = 6 Then
            'PictureBox1.Image = My.Resources.ty6
            PictureBox1.BackgroundImage = My.Resources.ty6
        ElseIf num = 7 Then
            'PictureBox1.Image = My.Resources.ty7
            PictureBox1.BackgroundImage = My.Resources.ty7
        End If
    End Sub
End Class