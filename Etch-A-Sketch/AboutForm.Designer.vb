﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.CloseAboutButton = New System.Windows.Forms.Button()
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseAboutButton
        '
        Me.CloseAboutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseAboutButton.Location = New System.Drawing.Point(197, 319)
        Me.CloseAboutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseAboutButton.Name = "CloseAboutButton"
        Me.CloseAboutButton.Size = New System.Drawing.Size(248, 37)
        Me.CloseAboutButton.TabIndex = 0
        Me.CloseAboutButton.Text = "Close"
        Me.CloseAboutButton.UseVisualStyleBackColor = True
        '
        'AboutLabel
        '
        Me.AboutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.Location = New System.Drawing.Point(47, 11)
        Me.AboutLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(565, 304)
        Me.AboutLabel.TabIndex = 1
        Me.AboutLabel.Text = resources.GetString("AboutLabel.Text")
        Me.AboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutForm
        '
        Me.AcceptButton = Me.CloseAboutButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 364)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.CloseAboutButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseAboutButton As Button
    Friend WithEvents AboutLabel As Label
End Class
