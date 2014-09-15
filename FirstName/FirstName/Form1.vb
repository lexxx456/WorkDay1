Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim stringerino As String = txtFullName.Text
        Dim spaceplace As Integer = stringerino.IndexOf(" ")
        txtFirstName.Text = stringerino.Substring(0, spaceplace)

    End Sub
End Class
