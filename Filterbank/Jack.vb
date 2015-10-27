Public Class Jack
    Dim scales As String = "1"
    Dim knobImg As Bitmap = New Bitmap(My.Resources.jack)
    Dim knobWidth = knobImg.Width
    Dim knobHeight = 100
    Dim imgPosPoint As Point = New Point(0, 0)
    Dim savedPos As Double = imgPosPoint.Y
    Dim JackLabel As String
    Dim MSSansSerif As Font = New Font("Microsoft Sans Serif", 8.25)

    Dim ShowLabel As Boolean
    Dim Color As Integer


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        txtPlugLabel.Visible = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Property image() As Bitmap
        Get
            image = knobImg
        End Get
        Set(ByVal value As Bitmap)
            knobImg = value
            knobWidth = knobImg.Width
            knobHeight = 100
            'imgPosPoint = New Point(0, 0)
        End Set
    End Property

    Property cableColor() As Integer
        Get
            cableColor = Color
        End Get
        Set(value As Integer)
            If value < 10 And value >= 0 Then
                Color = value
            Else
                Color = 0
            End If
            Ref()
        End Set
    End Property

    Property cableLabel As Boolean
        Get
            cableLabel = ShowLabel
        End Get
        Set(value As Boolean)
            ShowLabel = value
        End Set
    End Property

    Property labelText As String
        Get
            labelText = txtPlugLabel.Text
        End Get
        Set(value As String)
            txtPlugLabel.Text = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.ScaleTransform(scales, scales)
        Me.Height = knobHeight * scales
        Me.Width = knobWidth * scales
        e.Graphics.ResetTransform()
        e.Graphics.ScaleTransform(scales, scales)
        'e.Graphics.TranslateTransform(knobWidth, knobHeight)
        e.Graphics.DrawImage(knobImg, imgPosPoint)
    End Sub

    Public Sub Ref()
        imgPosPoint.Y = -100 * Color
        txtPlugLabel.Visible = ShowLabel
        Me.Refresh()
        EnableDoubleBuffering()
    End Sub

    Public Sub SetLabelCheck(ByVal value As Boolean)
        SetLabelToolStripMenuItem1.Checked = value
        ShowLabel = value
    End Sub

    Sub EnableDoubleBuffering()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Jack_RightMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ctxtColor.Show(CType(sender, Control), e.Location)
        End If
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Color = 1
        Ref()
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Color = 2
        Ref()
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        Color = 3
        Ref()
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        Color = 4
        Ref()
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Color = 5
        Ref()
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Color = 6
        Ref()
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Color = 7
        Ref()
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Color = 8
        Ref()
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Color = 9
        Ref()
    End Sub

    Private Sub UnplugToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UnplugToolStripMenuItem1.Click
        Color = 0
        'txtPlugLabel.Text = ""
        SetLabelCheck(False)
        Ref()
    End Sub

    Private Sub txtPlugLabel_TextChanged(sender As Object, e As EventArgs) Handles txtPlugLabel.TextChanged
        JackLabel = txtPlugLabel.Text
        Dim textSize As Size = TextRenderer.MeasureText(txtPlugLabel.Text, MSSansSerif)
        Console.WriteLine(textSize)
        If textSize.Width > 50 Then
            txtPlugLabel.Height = 40
            txtPlugLabel.WordWrap = True
        End If
    End Sub

    Private Sub SetLabelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetLabelToolStripMenuItem1.Click
        If SetLabelToolStripMenuItem1.Checked Then
            SetLabelToolStripMenuItem1.Checked = False
            ShowLabel = False
            Ref()
        Else
            SetLabelToolStripMenuItem1.Checked = True
            ShowLabel = True
            Ref()
        End If
    End Sub
End Class
