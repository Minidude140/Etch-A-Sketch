﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Etch-A-Sketch
'https://github.com/Minidude140/Etch-A-Sketch.git

Option Explicit On
Option Strict On


'TODO
'[]Figure out custom message box form
'[~]Figure out middle mouse click
'[~]Change pen size
'[]Shake Screen when clear button is clicked
'[]Create about form

'[]Draw waveforms
'{}Sin wave sub (red)
'{}Cos wave sub (Blue)
'{}Tan wave sub (Green)
'{}Draw 10x10 Graticule (Black)
'{}set default background color and change pen color before drawing each wave type

Public Class Form1
    Dim penColor As Color
    Dim backgroundColor As Color
    Dim penSize As Integer

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
        'Set default pen size
        Me.penSize = 2
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
        Dim pen As New Pen(Me.penColor, Me.penSize)
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

    ''' <summary>
    ''' Draws a Sin Wave across the picture box
    ''' </summary>
    Sub DrawSinWave()
        'Declare points to draw from and maximum wave size
        Dim oldX%, oldY%, newX%, newY%
        Dim yMax As Integer = (DrawingPictureBox.Height \ 2)
        Dim xMax As Integer = DrawingPictureBox.Width
        Const pi As Double = System.Math.PI
        'set start point
        oldX = 0
        oldY = CInt((DrawingPictureBox.Height / 2))
        'iterate(Increment) through the x and calculate y value
        For i = 0 To xMax Step (xMax / 360)
            'calculate new points
            newX = CInt(i * (xMax / 360))
            newY = CInt(((yMax - 10) * System.Math.Sin(((i * pi) / 180) + pi)) + yMax)
            'drawn calculated points
            DrawLine(oldX, oldY, newX, newY)
            'set old points to current point
            oldX = newX
            oldY = newY
        Next
    End Sub

    Sub DrawCosWave()
        'Declare points to draw from and maximum wave size
        Dim oldX%, oldY%, newX%, newY%
        Dim yMax As Integer = (DrawingPictureBox.Height \ 2)
        Dim xMax As Integer = DrawingPictureBox.Width
        Const pi As Double = System.Math.PI
        'set start point
        oldX = 0
        oldY = 10
        'iterate(Increment) through the x and calculate y value
        For i = 0 To xMax Step (xMax / 360)
            'calculate new points
            newX = CInt(i * (xMax / 360))
            newY = CInt(((yMax - 10) * System.Math.Sin(((i * pi) / 180) - (pi / 2))) + yMax)
            'drawn calculated points
            DrawLine(oldX, oldY, newX, newY)
            'set old points to current point
            oldX = newX
            oldY = newY
        Next
    End Sub

    'Test Button
    ''' <summary>
    ''' DEV Test Button.  (Will be removed at some point)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        DrawCosWave()
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
    End Sub

    Private Sub BackgroundColorContextStripItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextStripItem.Click,
                                                                                                BackgroundColorToolStripMenuItem.Click
        'Change the color of the background here
        SelectColorDialog.ShowDialog()
        'Set Background Color to Chosen Dialog Option
        ChangeColor(SelectColorDialog.Color, False)
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove,
                                                                                           DrawingPictureBox.MouseDown
        Static oldX As Integer
        Static oldY As Integer
        Select Case True
            'if left mouse button is clicked draw line
            Case e.Button = MouseButtons.Left
                'draw line from old mouse point to current mouse point
                DrawLine(oldX, oldY, e.X, e.Y)
                'if middle mouse button is clicked select pen color
            Case e.Button = MouseButtons.Middle
                'Change the color of the pen
                SelectColorDialog.ShowDialog()
                'Set Pen Color to Chosen Dialog Option
                ChangeColor(SelectColorDialog.Color)
        End Select
        'update old mouse points with current
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub DrawingPictureBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseWheel
        If e.Delta > 0 Then
            'mouse scroll up
            penSize += 1
        Else
            'mouse scroll down
            penSize -= 1
        End If
    End Sub

End Class
