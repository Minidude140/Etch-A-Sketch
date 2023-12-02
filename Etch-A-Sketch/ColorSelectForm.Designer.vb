<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorSelectForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PenColorButton = New System.Windows.Forms.Button()
        Me.BackGroundColorButton = New System.Windows.Forms.Button()
        Me.ColorPromptLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PenColorButton
        '
        Me.PenColorButton.Location = New System.Drawing.Point(32, 94)
        Me.PenColorButton.Name = "PenColorButton"
        Me.PenColorButton.Size = New System.Drawing.Size(97, 43)
        Me.PenColorButton.TabIndex = 0
        Me.PenColorButton.Text = "Pen Color"
        Me.PenColorButton.UseVisualStyleBackColor = True
        '
        'BackGroundColorButton
        '
        Me.BackGroundColorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BackGroundColorButton.Location = New System.Drawing.Point(175, 94)
        Me.BackGroundColorButton.Name = "BackGroundColorButton"
        Me.BackGroundColorButton.Size = New System.Drawing.Size(97, 43)
        Me.BackGroundColorButton.TabIndex = 1
        Me.BackGroundColorButton.Text = "Background Color"
        Me.BackGroundColorButton.UseVisualStyleBackColor = True
        '
        'ColorPromptLabel
        '
        Me.ColorPromptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPromptLabel.Location = New System.Drawing.Point(12, 9)
        Me.ColorPromptLabel.Name = "ColorPromptLabel"
        Me.ColorPromptLabel.Size = New System.Drawing.Size(272, 64)
        Me.ColorPromptLabel.TabIndex = 2
        Me.ColorPromptLabel.Text = "Would you like to change the Pen Color or the Backgournd color?"
        Me.ColorPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorSelectForm
        '
        Me.AcceptButton = Me.PenColorButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BackGroundColorButton
        Me.ClientSize = New System.Drawing.Size(310, 149)
        Me.Controls.Add(Me.ColorPromptLabel)
        Me.Controls.Add(Me.BackGroundColorButton)
        Me.Controls.Add(Me.PenColorButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(326, 188)
        Me.Name = "ColorSelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Select"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PenColorButton As Button
    Friend WithEvents BackGroundColorButton As Button
    Friend WithEvents ColorPromptLabel As Label
End Class
