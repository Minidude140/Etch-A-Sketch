Public Class ColorSelectForm
    Private Sub PenColorButton_Click(sender As Object, e As EventArgs) Handles PenColorButton.Click
        'User Clicked the Change Pen Color Button
        ColorDialogFormSelect.ShowDialog()
        EtchASketchForm.ChangeColor(ColorDialogFormSelect.Color)
        Me.Close()
    End Sub

    Private Sub BackGroundColorButton_Click(sender As Object, e As EventArgs) Handles BackGroundColorButton.Click
        'User Clicked the Change Background Color Button
        ColorDialogFormSelect.ShowDialog()
        EtchASketchForm.ChangeColor(ColorDialogFormSelect.Color, False)
        Me.Close()
    End Sub
End Class