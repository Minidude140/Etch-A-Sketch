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
        Me.components = New System.ComponentModel.Container()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContextStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenuStrip
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
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(401, 391)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 47)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clear Drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(267, 391)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(128, 47)
        Me.SelectColorButton.TabIndex = 3
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "Select Pen Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(133, 391)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(128, 47)
        Me.DrawWaveformsButton.TabIndex = 4
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.ToolTip.SetToolTip(Me.DrawWaveformsButton, "Draws a Sin, Cos, and Tan Waveform")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextStripMenuItem, Me.EditContextStripMenuItem1, Me.HelpContextStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(100, 70)
        '
        'FileContextStripMenuItem
        '
        Me.FileContextStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextStripMenuItem})
        Me.FileContextStripMenuItem.Name = "FileContextStripMenuItem"
        Me.FileContextStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.FileContextStripMenuItem.Text = "File"
        '
        'ExitContextStripMenuItem
        '
        Me.ExitContextStripMenuItem.Name = "ExitContextStripMenuItem"
        Me.ExitContextStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitContextStripMenuItem.Text = "Exit"
        '
        'EditContextStripMenuItem1
        '
        Me.EditContextStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextStripMenuItem, Me.DrawWaveformsContextStripMenuItem, Me.ClearContextStripMenuItem})
        Me.EditContextStripMenuItem1.Name = "EditContextStripMenuItem1"
        Me.EditContextStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.EditContextStripMenuItem1.Text = "Edit"
        '
        'SelectColorContextStripMenuItem
        '
        Me.SelectColorContextStripMenuItem.Name = "SelectColorContextStripMenuItem"
        Me.SelectColorContextStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectColorContextStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsContextStripMenuItem
        '
        Me.DrawWaveformsContextStripMenuItem.Name = "DrawWaveformsContextStripMenuItem"
        Me.DrawWaveformsContextStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsContextStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearContextStripMenuItem
        '
        Me.ClearContextStripMenuItem.Name = "ClearContextStripMenuItem"
        Me.ClearContextStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearContextStripMenuItem.Text = "Clear"
        '
        'HelpContextStripMenuItem
        '
        Me.HelpContextStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextStripMenuItem1})
        Me.HelpContextStripMenuItem.Name = "HelpContextStripMenuItem"
        Me.HelpContextStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpContextStripMenuItem.Text = "Help"
        '
        'AboutContextStripMenuItem1
        '
        Me.AboutContextStripMenuItem1.Name = "AboutContextStripMenuItem1"
        Me.AboutContextStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AboutContextStripMenuItem1.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditContextStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpContextStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutContextStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
