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
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TestButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
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
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextStripItem, Me.EditContextStripItem, Me.HelpContextStripItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(100, 70)
        '
        'FileContextStripItem
        '
        Me.FileContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextStripItem})
        Me.FileContextStripItem.Name = "FileContextStripItem"
        Me.FileContextStripItem.Size = New System.Drawing.Size(99, 22)
        Me.FileContextStripItem.Text = "File"
        '
        'ExitContextStripItem
        '
        Me.ExitContextStripItem.Name = "ExitContextStripItem"
        Me.ExitContextStripItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitContextStripItem.Text = "Exit"
        '
        'EditContextStripItem
        '
        Me.EditContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextStripItem, Me.DrawWaveformsContextStripItem, Me.ClearContextStripItem})
        Me.EditContextStripItem.Name = "EditContextStripItem"
        Me.EditContextStripItem.Size = New System.Drawing.Size(99, 22)
        Me.EditContextStripItem.Text = "Edit"
        '
        'SelectColorContextStripItem
        '
        Me.SelectColorContextStripItem.Name = "SelectColorContextStripItem"
        Me.SelectColorContextStripItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectColorContextStripItem.Text = "Select Color"
        '
        'DrawWaveformsContextStripItem
        '
        Me.DrawWaveformsContextStripItem.Name = "DrawWaveformsContextStripItem"
        Me.DrawWaveformsContextStripItem.Size = New System.Drawing.Size(164, 22)
        Me.DrawWaveformsContextStripItem.Text = "Draw Waveforms"
        '
        'ClearContextStripItem
        '
        Me.ClearContextStripItem.Name = "ClearContextStripItem"
        Me.ClearContextStripItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearContextStripItem.Text = "Clear"
        '
        'HelpContextStripItem
        '
        Me.HelpContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextStripItem})
        Me.HelpContextStripItem.Name = "HelpContextStripItem"
        Me.HelpContextStripItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpContextStripItem.Text = "Help"
        '
        'AboutContextStripItem
        '
        Me.AboutContextStripItem.Name = "AboutContextStripItem"
        Me.AboutContextStripItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutContextStripItem.Text = "About"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(531, 16)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 47)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(397, 16)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 47)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clear Drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(263, 16)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(128, 47)
        Me.SelectColorButton.TabIndex = 2
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "Select Pen Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(129, 16)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(128, 47)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.ToolTip.SetToolTip(Me.DrawWaveformsButton, "Draws a Sin, Cos, and Tan Waveform")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(24, 27)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(46, 24)
        Me.TestButton.TabIndex = 0
        Me.TestButton.Text = "Test"
        Me.ToolTip.SetToolTip(Me.TestButton, "Button Used For Dev Testing")
        Me.TestButton.UseVisualStyleBackColor = True
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
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.TestButton)
        Me.ButtonGroupBox.Controls.Add(Me.DrawWaveformsButton)
        Me.ButtonGroupBox.Controls.Add(Me.SelectColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(5, 378)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(783, 73)
        Me.ButtonGroupBox.TabIndex = 6
        Me.ButtonGroupBox.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileContextStripItem As ToolStripMenuItem
    Friend WithEvents ExitContextStripItem As ToolStripMenuItem
    Friend WithEvents EditContextStripItem As ToolStripMenuItem
    Friend WithEvents SelectColorContextStripItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsContextStripItem As ToolStripMenuItem
    Friend WithEvents ClearContextStripItem As ToolStripMenuItem
    Friend WithEvents HelpContextStripItem As ToolStripMenuItem
    Friend WithEvents AboutContextStripItem As ToolStripMenuItem
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
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents TestButton As Button
End Class
