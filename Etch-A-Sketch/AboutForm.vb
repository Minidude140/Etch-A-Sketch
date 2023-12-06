Public Class AboutForm
    Private Sub CloseAboutButton_Click(sender As Object, e As EventArgs) Handles CloseAboutButton.Click
        Me.Close()
        EtchASketchForm.Show()
    End Sub
End Class