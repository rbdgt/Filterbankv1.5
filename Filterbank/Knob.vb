

Public Class Knob
    Dim scales As String = "1"
    Dim knobImg As Bitmap = New Bitmap(My.Resources.knbY)
    Dim knobWidth As Integer
    Dim knobHeight As Integer
    Dim imgPosPoint As Point = New Point(-knobImg.Width, -knobImg.Width)
    Dim lastValue As Double
    Dim realValue As Double = 0
    Dim realMax As Double = 10
    Dim realMin As Double = 0
    Dim newImgPos As Double
    Dim newValue As Double
    Dim shownValue As Double
    Dim shownMax As Double = 10
    Dim shownMin As Double = 1
    Dim knobismoving As Boolean = False
    Dim mouseClickY As Integer

    Dim savedPos As Double

    Dim defaultvalue As Double

    Dim lVal As Double

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Property image() As Bitmap
        Get
            image = knobImg
        End Get
        Set(ByVal value As Bitmap)
            knobImg = value
            knobWidth = knobImg.Width
            knobHeight = knobImg.Width
            imgPosPoint = New Point(-knobImg.Width, savedPos)
        End Set
    End Property

    Property SetValue() As Double
        Get
            SetValue = shownValue
        End Get
        Set(ByVal value As Double)
            If value > shownMax Then value = shownMax
            If value < shownMin Then value = shownMin
            defaultvalue = value
            setInternalValue(value)
            shownValue = value
            lastValue = (((value - shownMin) * (realMax - realMin)) / (shownMax - shownMin)) + realMin
        End Set
    End Property

    Property SetMax() As Integer
        Get
            SetMax = shownMax
        End Get
        Set(value As Integer)
            shownMax = value
            If shownValue > shownMax Then shownValue = shownMax
            If shownValue < shownMin Then shownValue = shownMin
            setInternalValue(shownValue)
        End Set
    End Property

    Property SetMin() As Integer
        Get
            SetMin = shownMin
        End Get
        Set(value As Integer)
            shownMin = value
            If shownValue > shownMax Then shownValue = shownMax
            If shownValue < shownMin Then shownValue = shownMin
            setInternalValue(shownValue)
        End Set
    End Property

    Property SetLastValue() As Double
        Get
            SetLastValue = lVal
        End Get
        Set(value As Double)
        End Set
    End Property

    Public Sub Report()
        Console.WriteLine("realvalue: " & realValue & " // shownvalue: " & shownValue & " // newvalue: " & newValue & " // lastvalue: " & lastValue)
    End Sub

    Private Sub setInternalValue(ByVal value As Double)
        newValue = (((value - shownMin) * (realMax - realMin)) / (shownMax - shownMin)) + realMin
        Dim newImgPos As Double = Math.Round(((-newValue * ((knobImg.Height - knobWidth) / (realMax - realMin))) - knobWidth) / knobWidth) * knobWidth
        realValue = newValue
        imgPosPoint.Y = newImgPos
        savedPos = imgPosPoint.Y
        Ref()
    End Sub

    Private Sub knob_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If knobismoving = False Then
            mouseClickY = e.Y
            knobismoving = True
            'Report()
        End If
    End Sub

    Private Sub knob_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If knobismoving = True Then
            Dim diff As Integer = mouseClickY - e.Y
            Dim newVal As Double = lastValue + diff / 10
            If newVal < realMin Then newVal = realMin
            If newVal > realMax Then newVal = realMax
            Dim newImgPos As Double = Math.Round(((-newVal * ((knobImg.Height - knobWidth) / (realMax - realMin))) - knobWidth) / knobWidth) * knobWidth
            realValue = newVal
            shownValue = (((newVal - realMin) * (shownMax - shownMin)) / (realMax - realMin)) + shownMin
            imgPosPoint.Y = newImgPos
            savedPos = imgPosPoint.Y
        End If
        Ref()
    End Sub

    Private Sub UserControl11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        knobismoving = False
        lastValue = realValue
        'Report()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.ScaleTransform(scales, scales)
        Me.Height = knobWidth * scales
        Me.Width = knobHeight * scales
        e.Graphics.ResetTransform()
        e.Graphics.ScaleTransform(scales, scales)
        e.Graphics.TranslateTransform(knobWidth, knobHeight)
        e.Graphics.DrawImage(knobImg, imgPosPoint)
    End Sub

    Public Sub Ref()
        Me.Refresh()
        EnableDoubleBuffering()
    End Sub

    Sub EnableDoubleBuffering()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Knob_RightMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            KnobMenuStrip.Show(CType(sender, Control), e.Location)
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        SetValue = defaultvalue
    End Sub
End Class

