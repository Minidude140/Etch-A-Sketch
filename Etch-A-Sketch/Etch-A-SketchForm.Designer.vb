<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DrawingPictureBox.Location = New System.Drawing.Point(11, 42)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(784, 330)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(535, 391)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 47)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(401, 391)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 47)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(267, 391)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(128, 47)
        Me.SelectColorButton.TabIndex = 3
        Me.SelectColorButton.Text = "&Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(133, 391)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(128, 47)
        Me.DrawWaveformsButton.TabIndex = 4
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "Form1"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
End Class
