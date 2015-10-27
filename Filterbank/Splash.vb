Public Class Splash

    Dim WithEvents timer As New Timer
    Dim msgs As String() = {"Loading menu", "Loading presets", "Loading background", "Loading switches", "Loading knobs", "Almost done..."}
    Dim i As Integer = 0


    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Application.MinimumSplashScreenDisplayTime = 5000
        'Me.CenterToParent()
        pb1.Maximum = 20
        pb1.Minimum = 0
        timer.Enabled = True
        timer.Start()
        timer.Interval = 50
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        If i < msgs.Length - 1 Then
            i = Math.Round(pb1.Value / 4)
        End If

        Label1.Text = msgs(i)
        If pb1.Value < pb1.Maximum Then
            pb1.Value += 1
        End If
    End Sub

    Private Sub splash_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing


    End Sub

End Class