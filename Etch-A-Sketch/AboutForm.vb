Public Class AboutForm
    Private Sub CloseAboutButton_Click(sender As Object, e As EventArgs) Handles CloseAboutButton.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class