'Zachary Christensen
'RCET 2265
'Fall 2023
'Etch-A-Sketch
'https://github.com/Minidude140/Etch-A-Sketch.git

Option Explicit On
Option Strict On

Public Class Form1
    'Custom Methods
    ''' <summary>
    ''' Sets the Default Colors and clears picture box
    ''' </summary>
    Sub SetDefaults()
        DrawingPictureBox.Refresh()
        DrawingPictureBox.BackColor = Color.BlanchedAlmond
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
        Dim pen As New Pen(Color.Black)
        'draws a line from given co-ordinates (x,y) to (x,y); (0,0) in upper left hand corner
        g.DrawLine(pen, x1, y1, x2, y2)
        'dispose of the pen and graphics object to clear memory
        pen.Dispose()
        g.Dispose()
    End Sub


    'Event Handlers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click,
                                                                           ExitContextStripMenuItem.Click,
                                                                           ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
