Public Class main

    Dim num As Integer
    Dim r As New Random()

    Private Sub WFRDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WFRDownload.Click, Button1.Click
        ' https://github.com/Secret-Shopper-Servicing/Wii-Fit-Reminder

        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            fail.ShowDialog()
        Else
            Process.Start("https://github.com/Secret-Shopper-Servicing/Wii-Fit-Reminder/releases/download/Release/Wii-Fit-Reminder.exe")
            thankyou.Show()
        End If

    End Sub

    Private Sub MHADownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MHADownload.Click, Button1.Click
        ' https://github.com/Secret-Shopper-Servicing/MyHealthAssistance

        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            fail.ShowDialog()
        Else
            Process.Start("https://github.com/Secret-Shopper-Servicing/MyHealthAssistance/releases/download/v1/MyHealthAssistance.exe")
            thankyou.Show()
        End If

    End Sub

    Private Sub DDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDownload.Click, Button1.Click
        ' https://github.com/Secret-Shopper-Servicing/Drinks

        num = r.Next(1, 11)

        If num = 6 Or num = 7 Or num = 8 Then
            fail.ShowDialog()
        Else
            Process.Start("https://github.com/Secret-Shopper-Servicing/Drinks/releases/download/Latest/Drinks.exe")
            thankyou.Show()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
