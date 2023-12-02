'Zachary Christensen
'RCET 2265
'Fall 2023
'Etch-A-Sketch
'https://github.com/Minidude140/Etch-A-Sketch.git

Option Explicit On
Option Strict On

Public Class Form1
    Dim penColor As Color
    Dim backgroundColor As Color

    'Custom Methods
    ''' <summary>
    ''' Sets the Default Colors and clears picture box
    ''' </summary>
    Sub SetDefaults()
        'Erase the screen
        DrawingPictureBox.Refresh()
        'Change pen color to black
        Me.penColor = Color.Black
        'Change background color to "Blanched Almond"
        Me.backgroundColor = Color.BlanchedAlmond
        DrawingPictureBox.BackColor = Me.backgroundColor
    End Sub

    ''' <summary>
    ''' Draws line from given fist point(x1,y1) to second point(x2,y2)
    ''' </summary>
    ''' <param name="x1%"></param>
    ''' <param name="y1%"></param>
    ''' <param name="x2%"></param>
    ''' <param name="y2%"></param>
    Sub DrawLine(x1%, y1%, x2%, y2%) 'Denotation of % declares an integer
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        'initialize pen as color black
        Dim pen As New Pen(Me.penColor)
        'draws a line from given co-ordinates (x,y) to (x,y); (0,0) in upper left hand corner
        g.DrawLine(pen, x1, y1, x2, y2)
        'dispose of the pen and graphics object to clear memory
        pen.Dispose()
        g.Dispose()
    End Sub

    ''' <summary>
    ''' Change Color of the pen by default.
    ''' Optional Change background color(set second parameter false)
    ''' </summary>
    ''' <param name="newColor"></param>
    ''' <param name="changePenColor"></param>
    Sub ChangeColor(newColor As Color, Optional changePenColor As Boolean = True)
        If changePenColor = True Then
            'change pen color
            penColor = newColor
        Else
            'change background color
            backgroundColor = newColor
            DrawingPictureBox.BackColor = newColor
        End If
    End Sub

    'Test Button
    ''' <summary>
    ''' DEV Test Button.  (Will be removed at some point)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        DrawLine(0, 0, (DrawingPictureBox.Width - 10), (DrawingPictureBox.Height - 10))
    End Sub

    'Event Handlers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click,
                                                                           ExitContextStripItem.Click,
                                                                           ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click,
                                                                            ClearContextStripItem.Click,
                                                                            ClearToolStripMenuItem.Click
        'Erase the current drawings
        DrawingPictureBox.Refresh()
        '**Need to add shake**
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click,
                                                                                  SelectColorContextStripItem.Click,
                                                                                  SelectColorToolStripMenuItem.Click
        'Need to ask user for pen or background
        'Started creating custom message box to determine which color user wants to change need to ask for help
    End Sub

    Private Sub PenColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenColorContextStripItem.Click,
                                                                                          PenColorToolStripMenuItem.Click
        'Change the color of the pen
        SelectColorDialog.ShowDialog()
        'Set Pen Color to Chosen Dialog Option
        ChangeColor(SelectColorDialog.Color)
        '**Need to add middle mouse button**
    End Sub

    Private Sub BackgroundColorContextStripItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextStripItem.Click,
                                                                                                BackgroundColorToolStripMenuItem.Click
        'Change the color of the background here
        SelectColorDialog.ShowDialog()
        'Set Background Color to Chosen Dialog Option
        ChangeColor(SelectColorDialog.Color, False)
    End Sub

End Class
