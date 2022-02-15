Public Class main

    Private Sub WFRDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WFRDownload.Click
        ' https://github.com/Secret-Shopper-Servicing/Wii-Fit-Reminder
        Process.Start("https://github.com/Secret-Shopper-Servicing/Wii-Fit-Reminder/releases/download/Release/Wii-Fit-Reminder.exe")
        thankyou.Show()
    End Sub

    Private Sub MHADownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MHADownload.Click
        ' https://github.com/Secret-Shopper-Servicing/MyHealthAssistance
        Process.Start("https://github.com/Secret-Shopper-Servicing/MyHealthAssistance/releases/download/v1/MyHealthAssistance.exe")
        thankyou.Show()
    End Sub

    Private Sub DDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDownload.Click
        ' https://github.com/Secret-Shopper-Servicing/Drinks
        Process.Start("https://github.com/Secret-Shopper-Servicing/Drinks/releases/download/Latest/Drinks.exe")
        thankyou.Show()
    End Sub
End Class
