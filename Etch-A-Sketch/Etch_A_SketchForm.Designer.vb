<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.PenColorContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.CoordinatesLabel = New System.Windows.Forms.Label()
        Me.SelectColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DrawingPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DrawingPictureBox.Location = New System.Drawing.Point(15, 52)
        Me.DrawingPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(1036, 406)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip.SetToolTip(Me.DrawingPictureBox, "Left Click to Draw.  Scroll to Change Pen Size")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextStripItem, Me.EditContextStripItem, Me.HelpContextStripItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(111, 76)
        '
        'FileContextStripItem
        '
        Me.FileContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextStripItem})
        Me.FileContextStripItem.Name = "FileContextStripItem"
        Me.FileContextStripItem.Size = New System.Drawing.Size(110, 24)
        Me.FileContextStripItem.Text = "File"
        '
        'ExitContextStripItem
        '
        Me.ExitContextStripItem.Name = "ExitContextStripItem"
        Me.ExitContextStripItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitContextStripItem.Text = "Exit"
        '
        'EditContextStripItem
        '
        Me.EditContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextStripItem, Me.DrawWaveformsContextStripItem, Me.ClearContextStripItem})
        Me.EditContextStripItem.Name = "EditContextStripItem"
        Me.EditContextStripItem.Size = New System.Drawing.Size(110, 24)
        Me.EditContextStripItem.Text = "Edit"
        '
        'SelectColorContextStripItem
        '
        Me.SelectColorContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenColorContextStripItem, Me.BackgroundColorContextStripItem})
        Me.SelectColorContextStripItem.Name = "SelectColorContextStripItem"
        Me.SelectColorContextStripItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorContextStripItem.Text = "Select Color"
        '
        'PenColorContextStripItem
        '
        Me.PenColorContextStripItem.Name = "PenColorContextStripItem"
        Me.PenColorContextStripItem.Size = New System.Drawing.Size(211, 26)
        Me.PenColorContextStripItem.Text = "Pen Color"
        '
        'BackgroundColorContextStripItem
        '
        Me.BackgroundColorContextStripItem.Name = "BackgroundColorContextStripItem"
        Me.BackgroundColorContextStripItem.Size = New System.Drawing.Size(211, 26)
        Me.BackgroundColorContextStripItem.Text = "Background Color"
        '
        'DrawWaveformsContextStripItem
        '
        Me.DrawWaveformsContextStripItem.Name = "DrawWaveformsContextStripItem"
        Me.DrawWaveformsContextStripItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsContextStripItem.Text = "Draw Waveforms"
        '
        'ClearContextStripItem
        '
        Me.ClearContextStripItem.Name = "ClearContextStripItem"
        Me.ClearContextStripItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearContextStripItem.Text = "Clear"
        '
        'HelpContextStripItem
        '
        Me.HelpContextStripItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextStripItem})
        Me.HelpContextStripItem.Name = "HelpContextStripItem"
        Me.HelpContextStripItem.Size = New System.Drawing.Size(110, 24)
        Me.HelpContextStripItem.Text = "Help"
        '
        'AboutContextStripItem
        '
        Me.AboutContextStripItem.Name = "AboutContextStripItem"
        Me.AboutContextStripItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutContextStripItem.Text = "About"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExitButton.Location = New System.Drawing.Point(708, 20)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(171, 58)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(529, 20)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(171, 58)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clear Drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SelectColorButton.Location = New System.Drawing.Point(351, 20)
        Me.SelectColorButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(171, 58)
        Me.SelectColorButton.TabIndex = 2
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "Select Pen Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(172, 20)
        Me.DrawWaveformsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(171, 58)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.ToolTip.SetToolTip(Me.DrawWaveformsButton, "Draws a Sin, Cos, and Tan Waveform")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem})
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'PenColorToolStripMenuItem
        '
        Me.PenColorToolStripMenuItem.Name = "PenColorToolStripMenuItem"
        Me.PenColorToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.PenColorToolStripMenuItem.Text = "Pen Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.AutoSize = True
        Me.ButtonGroupBox.Controls.Add(Me.CoordinatesLabel)
        Me.ButtonGroupBox.Controls.Add(Me.DrawWaveformsButton)
        Me.ButtonGroupBox.Controls.Add(Me.SelectColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(15, 454)
        Me.ButtonGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGroupBox.Size = New System.Drawing.Size(1036, 101)
        Me.ButtonGroupBox.TabIndex = 6
        Me.ButtonGroupBox.TabStop = False
        '
        'CoordinatesLabel
        '
        Me.CoordinatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CoordinatesLabel.AutoSize = True
        Me.CoordinatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordinatesLabel.Location = New System.Drawing.Point(887, 34)
        Me.CoordinatesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CoordinatesLabel.Name = "CoordinatesLabel"
        Me.CoordinatesLabel.Size = New System.Drawing.Size(58, 25)
        Me.CoordinatesLabel.TabIndex = 7
        Me.CoordinatesLabel.Text = "(X,Y)"
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1082, 591)
        Me.Name = "EtchASketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ButtonGroupBox.PerformLayout()
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
    Friend WithEvents SelectColorDialog As ColorDialog
    Friend WithEvents PenColorContextStripItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorContextStripItem As ToolStripMenuItem
    Friend WithEvents PenColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoordinatesLabel As Label
End Class
