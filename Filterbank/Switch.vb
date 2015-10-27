Public Class Switch

    Dim nrvals As Integer = 3
    Dim scales As String = "1"
    Dim knobImg As Bitmap = New Bitmap(My.Resources.switch)
    Dim knobWidth As Integer = knobImg.Width
    Dim knobHeight As Integer = knobImg.Width
    Dim imgPosPoint As Point = New Point(-knobImg.Width, -knobImg.Width)
    Dim lastImgPos As Integer = imgPosPoint.Y
    Dim newImgPos As Integer
    'Dim side As Boolean = False
    Dim currentvalue As Integer = SetValue

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
            imgPosPoint = New Point(-knobImg.Width, -knobImg.Width)
            imgPosPoint.Y = -knobWidth * currentvalue
            Ref()
        End Set
    End Property

    Property numberofvalues() As Integer
        Get
            numberofvalues = nrvals
        End Get
        Set(ByVal value As Integer)
            If value > 3 Then nrvals = 3
            If value < 2 Then nrvals = 2
            nrvals = value
        End Set
    End Property

    Property SetValue() As Integer
        Get
            SetValue = currentvalue
        End Get
        Set(ByVal value As Integer)
            currentvalue = value
            If value = 1 Then
                imgPosPoint = New Point(-knobImg.Width, -knobImg.Width)
                newImgPos = -knobWidth
                lastImgPos = newImgPos
                imgPosPoint.Y = newImgPos
            End If
            If value = 2 And nrvals = 3 Then
                imgPosPoint.Y = -knobWidth * value
                newImgPos = -knobWidth * value
                lastImgPos = newImgPos
                imgPosPoint.Y = newImgPos
            End If
            If value = 3 Then
                imgPosPoint.Y = -knobWidth * value
                newImgPos = -knobWidth * value
                lastImgPos = newImgPos
                imgPosPoint.Y = newImgPos
            End If
            Ref()
        End Set
    End Property

    Property SetLastValue As Double
        Get
            SetLastValue = 0
        End Get
        Set(value As Double)

        End Set
    End Property

    Private Sub UserControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If nrvals = 3 Then
            newImgPos = lastImgPos - knobWidth
            currentvalue = currentvalue + 1
        Else
            newImgPos = lastImgPos - knobWidth - knobWidth
            currentvalue = currentvalue + 2
        End If

        If newImgPos < -knobImg.Height Then newImgPos = -knobImg.Width
        If currentvalue > 3 Then currentvalue = 1

        lastImgPos = newImgPos
        imgPosPoint.Y = newImgPos
        Ref()
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

End Class

