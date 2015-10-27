Imports System.Xml
Imports System.IO
Imports System.Text.RegularExpressions

Public Class fb

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Owner = Me
        About.Show()
    End Sub


    Private Sub SchematicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchematicToolStripMenuItem.Click
        LoadSchematicGui()
    End Sub

    Private Sub RealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealToolStripMenuItem.Click
        LoadRealGUI()
    End Sub

    Private Sub CleanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CleanToolStripMenuItem1.Click
        LoadCleanGUI()
    End Sub

    Public Sub LoadRealGUI()
        Try
            knbFMA.image = My.Resources.knbY
            knbFMFiltSens.image = My.Resources.knbY2
            knbFMR.image = My.Resources.knbY
            knbFMS.image = My.Resources.knbY2
            knbFMD.image = My.Resources.knbY
            knbAMFiltSens.image = My.Resources.knbY2
            knbFilt1Corr.image = My.Resources.knbR
            knbFilt2Corr.image = My.Resources.knbR
            knbParSer.image = My.Resources.knbR
            knbReso1.image = My.Resources.knbR
            knbReso2.image = My.Resources.knbR
            knbFM.image = My.Resources.knbB

            knbSpeed.image = My.Resources.knbB
            knbDepth.image = My.Resources.knbB
            knbInput.image = My.Resources.knbG
            knbAMA.image = My.Resources.knbG
            knbAM.image = My.Resources.knbG
            knbAMR.image = My.Resources.knbG
            knbBypEff.image = My.Resources.knbW
            knbAMFilt.image = My.Resources.knbW
            knbFMFilt.image = My.Resources.knbW
            knbFreq1.image = My.Resources.knbFreq
            knbFreq2.image = My.Resources.knbFreq
            knbHarm.image = My.Resources.knbHarm

            swtchAR.image = My.Resources.switchside
            swtchARADSR.image = My.Resources.switch
            swtchBoostCut.image = My.Resources.switch
            swtchOctave.image = My.Resources.switch
            swtchSensi.image = My.Resources.switch
            swtchTrack.image = My.Resources.switch

            For Each ctrl In Me.Controls
                If ctrl.GetType() Is GetType(Jack) Then
                    ctrl.image = My.Resources.jack
                End If
            Next

            For Each ctrl In Me.Controls
                If ctrl.GetType() Is GetType(Midi) Then
                    ctrl.image = My.Resources.midi
                End If
            Next

            Me.BackgroundImage = My.Resources.fb2bgReal15
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Er... Something didn't go as planned...")
        End Try
        'Console.WriteLine("gui loaded")
    End Sub

    Public Sub LoadCleanGUI()
        Try
            knbFMA.image = My.Resources.knbYSchem15
            knbFMFiltSens.image = My.Resources.knbYSchem152
            knbFMR.image = My.Resources.knbYSchem15
            knbFMS.image = My.Resources.knbYSchem152
            knbFMD.image = My.Resources.knbYSchem15
            knbAMFiltSens.image = My.Resources.knbYSchem152
            knbFilt1Corr.image = My.Resources.knbRSchem15
            knbFilt2Corr.image = My.Resources.knbRSchem15
            knbParSer.image = My.Resources.knbRSchem15
            knbReso1.image = My.Resources.knbRSchem15
            knbReso2.image = My.Resources.knbRSchem15
            knbFM.image = My.Resources.knbBSchem15
            knbSpeed.image = My.Resources.knbBSchem15
            knbDepth.image = My.Resources.knbBSchem15
            knbInput.image = My.Resources.knbGSchem15
            knbAMA.image = My.Resources.knbGSchem15
            knbAM.image = My.Resources.knbGSchem15
            knbAMR.image = My.Resources.knbGSchem15
            knbBypEff.image = My.Resources.knbWSchem15
            knbAMFilt.image = My.Resources.knbWSchem15
            knbFMFilt.image = My.Resources.knbWSchem15
            knbFreq1.image = My.Resources.knbFreqSchem15
            knbFreq2.image = My.Resources.knbFreqSchem15
            knbHarm.image = My.Resources.knbHarmSchem15

            swtchAR.image = My.Resources.switchsideSchem15
            swtchARADSR.image = My.Resources.switchSchem15
            swtchBoostCut.image = My.Resources.switchSchem15
            swtchOctave.image = My.Resources.switchSchem15
            swtchSensi.image = My.Resources.switchSchem15
            swtchTrack.image = My.Resources.switchSchem15

            For Each ctrl In Me.Controls
                If ctrl.GetType() Is GetType(Jack) Then
                    ctrl.image = My.Resources.jackSchem
                End If
            Next

            For Each ctrl In Me.Controls
                If ctrl.GetType() Is GetType(Midi) Then
                    ctrl.image = My.Resources.midiSchem
                End If
            Next

            Me.BackgroundImage = My.Resources.fb2bgSchem15
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Er... Something didn't go as planned...")
        End Try
        'Console.WriteLine("gui loaded")
    End Sub

    Private Sub LoadSchematicGui()
        Try
            For Each ctrl In Me.Controls
                If ctrl.GetType() Is GetType(Knob) Then
                    'ctrl.visible = False
                    If ctrl.Tag = "normal" Then
                        ctrl.image = My.Resources.knbDefSchem
                    End If
                    If ctrl.Tag = "normalfreq" Then
                        ctrl.image = My.Resources.knbFreqSchem
                    End If
                    If ctrl.Tag = "normalharm" Then
                        ctrl.image = My.Resources.knbHarmSchem
                    End If
                    If ctrl.Tag = "side" Then
                        ctrl.image = My.Resources.knbDefSchem2
                    End If
                End If
                If ctrl.GetType() Is GetType(Switch) Then
                    'ctrl.visible = False
                    If ctrl.Tag = "normal" Then
                        ctrl.image = My.Resources.switchSchem
                    End If
                    If ctrl.Tag = "side" Then
                        ctrl.image = My.Resources.switchsideSchem
                    End If
                End If
                If ctrl.GetType() Is GetType(Jack) Then
                    ctrl.image = My.Resources.jackSchem
                End If
                If ctrl.GetType() Is GetType(Midi) Then
                    ctrl.image = My.Resources.midiSchem
                End If

            Next

            'For Each ctrl In Me.Controls
            '    If ctrl.GetType() Is GetType(Knob) Or ctrl.GetType() Is GetType(Switch) Then
            '        ctrl.visible = True
            '    End If
            'Next

            Me.BackgroundImage = My.Resources.fb2bgSchem15

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hmmm, something is not quite right...")
        End Try
    End Sub

    Private Sub LoadPreset(ByVal filename As String)
        Try
            Dim xmlDoc As XmlReader = New XmlTextReader(filename)
            While (xmlDoc.Read())
                Dim type = xmlDoc.NodeType
                For Each ctrl In Me.Controls
                    If ctrl.GetType() = GetType(Knob) Or ctrl.GetType() = GetType(Switch) Then
                        If (type = XmlNodeType.Element) Then
                            If (xmlDoc.Name = "title") Then
                                txtTitle.Text = xmlDoc.ReadInnerXml.ToString()
                                Refresh()
                            End If
                            If (xmlDoc.Name = ctrl.name) Then
                                Dim value = xmlDoc.ReadInnerXml.ToString()
                                ctrl.SetValue = value
                                ctrl.SetLastValue = value
                            End If
                            If (type = XmlNodeType.Element) Then
                                If (xmlDoc.Name = ctrl.name) Then
                                    Dim value = xmlDoc.ReadInnerXml.ToString()
                                    ctrl.cableColor = value
                                End If
                            End If
                        End If
                    End If
                    If ctrl.GetType() = GetType(Midi) Or ctrl.GetType() = GetType(Jack) Then
                        If (type = XmlNodeType.Element) Then
                            If (xmlDoc.Name = ctrl.name) Then
                                If xmlDoc.HasAttributes Then
                                    If xmlDoc.GetAttribute(0).Equals("True") Then
                                        ctrl.setLabelCheck(True)
                                    Else
                                        ctrl.setLabelCheck(False)
                                    End If
                                    If xmlDoc.GetAttribute(1).Equals("") Then
                                        ctrl.labelText = ""
                                    Else
                                        ctrl.labelText = xmlDoc.GetAttribute(1)
                                    End If
                                End If
                                Dim value = xmlDoc.ReadInnerXml.ToString()
                                ctrl.cableColor = value
                            End If
                        End If
                    End If
                Next
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message & Environment.NewLine & "There's probably something wrong with the file..." & Environment.NewLine & "Maybe use a texteditor to see if it's corrupted.", "I'm sorry Dave, I'm afraid I can't do that...")
        End Try
    End Sub

    Private Sub LoadFBMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFbmToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "fbm files|*.fbm"
        openFileDialog1.Title = "Open a preset file"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LoadPreset(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveAsFBMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsFbmToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "fbm files|*.fbm"
        saveFileDialog1.Title = "Save the preset file"
        Dim sFilename As String = Regex.Replace(txtTitle.Text, "\s", "_")
        sFilename = Regex.Replace(sFilename, "[^A-Za-z0-9_.]*", "")
        saveFileDialog1.FileName = sFilename
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            Try
                Dim xmlDoc As New Xml.XmlDocument
                Dim root As Xml.XmlElement = xmlDoc.CreateElement("Controls")
                Dim filename As String = System.IO.Path.GetFileName(saveFileDialog1.FileName)
                root.SetAttribute("presetname", filename)
                xmlDoc.AppendChild(root)
                Dim title As Xml.XmlElement = xmlDoc.CreateElement("title")
                title.InnerText = txtTitle.Text
                root.AppendChild(title)
                For Each ctrl In Me.Controls
                    If ctrl.GetType() = GetType(Knob) Or ctrl.GetType() = GetType(Switch) Then
                        Dim control As Xml.XmlElement = xmlDoc.CreateElement(ctrl.Name)
                        control.InnerText = ctrl.SetValue
                        root.AppendChild(control)
                    End If

                    If ctrl.GetType() = GetType(Jack) Or ctrl.GetType() = GetType(Midi) Then
                        Dim control As Xml.XmlElement = xmlDoc.CreateElement(ctrl.Name)
                        Dim LabelShown As Xml.XmlAttribute = xmlDoc.CreateAttribute("LabelShown")
                        Dim LabelText As Xml.XmlAttribute = xmlDoc.CreateAttribute("LabelText")
                        control.SetAttributeNode(LabelShown)
                        control.SetAttributeNode(LabelText)
                        LabelShown.InnerText = ctrl.cableLabel
                        LabelText.InnerText = ctrl.labelText
                        control.InnerText = ctrl.cableColor
                        root.AppendChild(control)
                    End If
                Next
                xmlDoc.Save(saveFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Uh oh...")
            End Try
        End If
    End Sub

    Private Sub SaveAsPNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsPNGToolStripMenuItem.Click
        Try
            Dim bounds As Rectangle = rctImage.Bounds
            Dim pt As Point = rctImage.PointToScreen(bounds.Location)
            Dim bitmap As New Bitmap(bounds.Width, bounds.Height)
            Using g As Graphics = Graphics.FromImage(bitmap)
                g.CopyFromScreen(New Point(pt.X - rctImage.Location.X, pt.Y - rctImage.Location.Y), Point.Empty, bounds.Size)
            End Using
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Png Image|*.png"
            saveFileDialog1.Title = "Save the preset-image"
            Dim sFilename As String = Regex.Replace(txtTitle.Text, "\s", "_")
            sFilename = Regex.Replace(sFilename, "[^A-Za-z0-9_.]*", "")
            saveFileDialog1.FileName = sFilename
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName <> "" Then
                bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Urgh, something is messed up...")
        End Try
    End Sub

    Sub EnableDoubleBuffering()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub FocusLost(sender As Object, a As EventArgs) Handles MyBase.LostFocus
        Me.TopMost = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False

        'colorpicker.Show()

        'Me.CenterToParent()
        EnableDoubleBuffering()
        LoadRealGUI()
        lblTitle.Text = txtTitle.Text
        Dim dir As String
        For Each dir In Directory.EnumerateDirectories(AppDomain.CurrentDomain.BaseDirectory())
            Dim d As New DirectoryInfo(dir)
            If d.Name = "defaultpresets" Then
                tlsmPresets.Visible = True
                Dim filelist = Directory.EnumerateFiles(dir)
                For Each file In filelist
                    If file.EndsWith(".fbm") Then
                        Dim preset As New ToolStripMenuItem
                        Dim xmlDoc As XmlReader = New XmlTextReader(file)
                        While (xmlDoc.Read())
                            Dim type = xmlDoc.NodeType
                            If (type = XmlNodeType.Element) Then
                                If (xmlDoc.Name = "title") Then
                                    preset.Text = xmlDoc.ReadInnerXml.ToString()
                                    preset.Tag = file
                                    AddHandler preset.Click, AddressOf Clickhandler
                                    tlsmPresets.DropDownItems.Add(preset)
                                End If
                            End If
                        End While
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Refresh()
    End Sub

    Private Sub Clickhandler(ByVal sender As Object, ByVal e As EventArgs)
        LoadPreset(sender.tag())
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        lblTitle.Text = txtTitle.Text
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
