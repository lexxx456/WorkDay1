Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim stringerino As String = txtFullName.Text
        Dim stringerino2 As String = stringerino.Trim()
        Dim spaceplace As Integer = stringerino2.IndexOf(" ")
        txtFirstName.Text = stringerino2.Substring(0, spaceplace)

    End Sub
End Class
