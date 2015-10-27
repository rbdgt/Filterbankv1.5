<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fb))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFbmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsFbmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsPNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchematicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsmPresets = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctImage = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPresetName = New System.Windows.Forms.Label()
        Me.jackLinkOut = New Filterbank15.Jack()
        Me.jackSignalIn = New Filterbank15.Jack()
        Me.MidiOut = New Filterbank15.Midi()
        Me.jackLFOOut = New Filterbank15.Jack()
        Me.jackAMIn = New Filterbank15.Jack()
        Me.MidiIn = New Filterbank15.Midi()
        Me.jackFMIn = New Filterbank15.Jack()
        Me.jackPedalIn = New Filterbank15.Jack()
        Me.MidiThru1 = New Filterbank15.Midi()
        Me.MidiThru2 = New Filterbank15.Midi()
        Me.jackTriggerADSR = New Filterbank15.Jack()
        Me.jackLinkIn = New Filterbank15.Jack()
        Me.jackADSR = New Filterbank15.Jack()
        Me.MidiThru3 = New Filterbank15.Midi()
        Me.jackMainOut = New Filterbank15.Jack()
        Me.jackOut1 = New Filterbank15.Jack()
        Me.jackTriggerAR = New Filterbank15.Jack()
        Me.knbBypEff = New Filterbank15.Knob()
        Me.knbFilt2Corr = New Filterbank15.Knob()
        Me.knbFreq1 = New Filterbank15.Knob()
        Me.knbFMR = New Filterbank15.Knob()
        Me.knbReso1 = New Filterbank15.Knob()
        Me.knbFMFilt = New Filterbank15.Knob()
        Me.knbFM = New Filterbank15.Knob()
        Me.knbAMFiltSens = New Filterbank15.Knob()
        Me.knbAM = New Filterbank15.Knob()
        Me.knbFMS = New Filterbank15.Knob()
        Me.knbAMFilt = New Filterbank15.Knob()
        Me.knbDepth = New Filterbank15.Knob()
        Me.knbFMD = New Filterbank15.Knob()
        Me.knbFreq2 = New Filterbank15.Knob()
        Me.knbParSer = New Filterbank15.Knob()
        Me.knbSpeed = New Filterbank15.Knob()
        Me.knbHarm = New Filterbank15.Knob()
        Me.knbInput = New Filterbank15.Knob()
        Me.knbReso2 = New Filterbank15.Knob()
        Me.knbFMA = New Filterbank15.Knob()
        Me.knbFilt1Corr = New Filterbank15.Knob()
        Me.knbAMA = New Filterbank15.Knob()
        Me.knbFMFiltSens = New Filterbank15.Knob()
        Me.knbAMR = New Filterbank15.Knob()
        Me.swtchTrack = New Filterbank15.Switch()
        Me.swtchSensi = New Filterbank15.Switch()
        Me.swtchOctave = New Filterbank15.Switch()
        Me.swtchARADSR = New Filterbank15.Switch()
        Me.swtchAR = New Filterbank15.Switch()
        Me.swtchBoostCut = New Filterbank15.Switch()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LayoutToolStripMenuItem, Me.tlsmPresets, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1316, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFbmToolStripMenuItem, Me.SaveAsFbmToolStripMenuItem, Me.SaveAsPNGToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadFbmToolStripMenuItem
        '
        Me.LoadFbmToolStripMenuItem.Name = "LoadFbmToolStripMenuItem"
        Me.LoadFbmToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.LoadFbmToolStripMenuItem.Text = "Open FBM"
        '
        'SaveAsFbmToolStripMenuItem
        '
        Me.SaveAsFbmToolStripMenuItem.Name = "SaveAsFbmToolStripMenuItem"
        Me.SaveAsFbmToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveAsFbmToolStripMenuItem.Text = "Save as FBM"
        '
        'SaveAsPNGToolStripMenuItem
        '
        Me.SaveAsPNGToolStripMenuItem.Name = "SaveAsPNGToolStripMenuItem"
        Me.SaveAsPNGToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveAsPNGToolStripMenuItem.Text = "Save as PNG"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealToolStripMenuItem, Me.CleanToolStripMenuItem1, Me.SchematicToolStripMenuItem})
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'RealToolStripMenuItem
        '
        Me.RealToolStripMenuItem.Name = "RealToolStripMenuItem"
        Me.RealToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.RealToolStripMenuItem.Text = "Realistic"
        '
        'CleanToolStripMenuItem1
        '
        Me.CleanToolStripMenuItem1.Name = "CleanToolStripMenuItem1"
        Me.CleanToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.CleanToolStripMenuItem1.Text = "Clean"
        '
        'SchematicToolStripMenuItem
        '
        Me.SchematicToolStripMenuItem.Name = "SchematicToolStripMenuItem"
        Me.SchematicToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.SchematicToolStripMenuItem.Text = "Schematic"
        '
        'tlsmPresets
        '
        Me.tlsmPresets.Name = "tlsmPresets"
        Me.tlsmPresets.Size = New System.Drawing.Size(67, 24)
        Me.tlsmPresets.Text = "Presets"
        Me.tlsmPresets.Visible = False
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctImage})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1316, 500)
        Me.ShapeContainer1.TabIndex = 27
        Me.ShapeContainer1.TabStop = False
        '
        'rctImage
        '
        Me.rctImage.Location = New System.Drawing.Point(0, 28)
        Me.rctImage.Name = "rctImage"
        Me.rctImage.Size = New System.Drawing.Size(1315, 471)
        Me.rctImage.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(813, 2)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(486, 22)
        Me.txtTitle.TabIndex = 69
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(239, 310)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(833, 37)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPresetName
        '
        Me.lblPresetName.AutoSize = True
        Me.lblPresetName.BackColor = System.Drawing.SystemColors.Control
        Me.lblPresetName.Location = New System.Drawing.Point(723, 6)
        Me.lblPresetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPresetName.Name = "lblPresetName"
        Me.lblPresetName.Size = New System.Drawing.Size(88, 17)
        Me.lblPresetName.TabIndex = 71
        Me.lblPresetName.Text = "Preset name"
        '
        'jackLinkOut
        '
        Me.jackLinkOut.BackColor = System.Drawing.Color.Transparent
        Me.jackLinkOut.cableColor = 0
        Me.jackLinkOut.cableLabel = False
        Me.jackLinkOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackLinkOut.image = CType(resources.GetObject("jackLinkOut.image"), System.Drawing.Bitmap)
        Me.jackLinkOut.labelText = ""
        Me.jackLinkOut.Location = New System.Drawing.Point(468, 398)
        Me.jackLinkOut.Margin = New System.Windows.Forms.Padding(5)
        Me.jackLinkOut.Name = "jackLinkOut"
        Me.jackLinkOut.Size = New System.Drawing.Size(50, 100)
        Me.jackLinkOut.TabIndex = 84
        '
        'jackSignalIn
        '
        Me.jackSignalIn.BackColor = System.Drawing.Color.Transparent
        Me.jackSignalIn.cableColor = 0
        Me.jackSignalIn.cableLabel = False
        Me.jackSignalIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackSignalIn.image = Global.Filterbank15.My.Resources.Resources.jack
        Me.jackSignalIn.labelText = ""
        Me.jackSignalIn.Location = New System.Drawing.Point(163, 398)
        Me.jackSignalIn.Margin = New System.Windows.Forms.Padding(5)
        Me.jackSignalIn.Name = "jackSignalIn"
        Me.jackSignalIn.Size = New System.Drawing.Size(50, 100)
        Me.jackSignalIn.TabIndex = 80
        '
        'MidiOut
        '
        Me.MidiOut.BackColor = System.Drawing.Color.Transparent
        Me.MidiOut.cableColor = 0
        Me.MidiOut.cableLabel = False
        Me.MidiOut.image = CType(resources.GetObject("MidiOut.image"), System.Drawing.Bitmap)
        Me.MidiOut.labelText = ""
        Me.MidiOut.Location = New System.Drawing.Point(696, 398)
        Me.MidiOut.Margin = New System.Windows.Forms.Padding(5)
        Me.MidiOut.Name = "MidiOut"
        Me.MidiOut.Size = New System.Drawing.Size(50, 100)
        Me.MidiOut.TabIndex = 75
        '
        'jackLFOOut
        '
        Me.jackLFOOut.BackColor = System.Drawing.Color.Transparent
        Me.jackLFOOut.cableColor = 0
        Me.jackLFOOut.cableLabel = False
        Me.jackLFOOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackLFOOut.image = Global.Filterbank15.My.Resources.Resources.jack
        Me.jackLFOOut.labelText = ""
        Me.jackLFOOut.Location = New System.Drawing.Point(12, 398)
        Me.jackLFOOut.Margin = New System.Windows.Forms.Padding(5)
        Me.jackLFOOut.Name = "jackLFOOut"
        Me.jackLFOOut.Size = New System.Drawing.Size(50, 100)
        Me.jackLFOOut.TabIndex = 73
        '
        'jackAMIn
        '
        Me.jackAMIn.BackColor = System.Drawing.Color.Transparent
        Me.jackAMIn.cableColor = 0
        Me.jackAMIn.cableLabel = False
        Me.jackAMIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackAMIn.image = CType(resources.GetObject("jackAMIn.image"), System.Drawing.Bitmap)
        Me.jackAMIn.labelText = ""
        Me.jackAMIn.Location = New System.Drawing.Point(1000, 398)
        Me.jackAMIn.Margin = New System.Windows.Forms.Padding(5)
        Me.jackAMIn.Name = "jackAMIn"
        Me.jackAMIn.Size = New System.Drawing.Size(50, 100)
        Me.jackAMIn.TabIndex = 86
        '
        'MidiIn
        '
        Me.MidiIn.BackColor = System.Drawing.Color.Transparent
        Me.MidiIn.cableColor = 0
        Me.MidiIn.cableLabel = False
        Me.MidiIn.image = CType(resources.GetObject("MidiIn.image"), System.Drawing.Bitmap)
        Me.MidiIn.labelText = ""
        Me.MidiIn.Location = New System.Drawing.Point(620, 398)
        Me.MidiIn.Margin = New System.Windows.Forms.Padding(5)
        Me.MidiIn.Name = "MidiIn"
        Me.MidiIn.Size = New System.Drawing.Size(50, 100)
        Me.MidiIn.TabIndex = 74
        '
        'jackFMIn
        '
        Me.jackFMIn.BackColor = System.Drawing.Color.Transparent
        Me.jackFMIn.cableColor = 0
        Me.jackFMIn.cableLabel = False
        Me.jackFMIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackFMIn.image = Global.Filterbank15.My.Resources.Resources.jack
        Me.jackFMIn.labelText = ""
        Me.jackFMIn.Location = New System.Drawing.Point(239, 398)
        Me.jackFMIn.Margin = New System.Windows.Forms.Padding(5)
        Me.jackFMIn.Name = "jackFMIn"
        Me.jackFMIn.Size = New System.Drawing.Size(50, 100)
        Me.jackFMIn.TabIndex = 81
        '
        'jackPedalIn
        '
        Me.jackPedalIn.BackColor = System.Drawing.Color.Transparent
        Me.jackPedalIn.cableColor = 0
        Me.jackPedalIn.cableLabel = False
        Me.jackPedalIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackPedalIn.image = Global.Filterbank15.My.Resources.Resources.jack
        Me.jackPedalIn.labelText = ""
        Me.jackPedalIn.Location = New System.Drawing.Point(87, 398)
        Me.jackPedalIn.Margin = New System.Windows.Forms.Padding(5)
        Me.jackPedalIn.Name = "jackPedalIn"
        Me.jackPedalIn.Size = New System.Drawing.Size(50, 100)
        Me.jackPedalIn.TabIndex = 79
        '
        'MidiThru1
        '
        Me.MidiThru1.BackColor = System.Drawing.Color.Transparent
        Me.MidiThru1.cableColor = 0
        Me.MidiThru1.cableLabel = False
        Me.MidiThru1.image = CType(resources.GetObject("MidiThru1.image"), System.Drawing.Bitmap)
        Me.MidiThru1.labelText = ""
        Me.MidiThru1.Location = New System.Drawing.Point(772, 398)
        Me.MidiThru1.Margin = New System.Windows.Forms.Padding(5)
        Me.MidiThru1.Name = "MidiThru1"
        Me.MidiThru1.Size = New System.Drawing.Size(50, 100)
        Me.MidiThru1.TabIndex = 76
        '
        'MidiThru2
        '
        Me.MidiThru2.BackColor = System.Drawing.Color.Transparent
        Me.MidiThru2.cableColor = 0
        Me.MidiThru2.cableLabel = False
        Me.MidiThru2.image = CType(resources.GetObject("MidiThru2.image"), System.Drawing.Bitmap)
        Me.MidiThru2.labelText = ""
        Me.MidiThru2.Location = New System.Drawing.Point(848, 398)
        Me.MidiThru2.Margin = New System.Windows.Forms.Padding(5)
        Me.MidiThru2.Name = "MidiThru2"
        Me.MidiThru2.Size = New System.Drawing.Size(50, 100)
        Me.MidiThru2.TabIndex = 77
        '
        'jackTriggerADSR
        '
        Me.jackTriggerADSR.BackColor = System.Drawing.Color.Transparent
        Me.jackTriggerADSR.cableColor = 0
        Me.jackTriggerADSR.cableLabel = False
        Me.jackTriggerADSR.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackTriggerADSR.image = CType(resources.GetObject("jackTriggerADSR.image"), System.Drawing.Bitmap)
        Me.jackTriggerADSR.labelText = ""
        Me.jackTriggerADSR.Location = New System.Drawing.Point(316, 398)
        Me.jackTriggerADSR.Margin = New System.Windows.Forms.Padding(5)
        Me.jackTriggerADSR.Name = "jackTriggerADSR"
        Me.jackTriggerADSR.Size = New System.Drawing.Size(50, 100)
        Me.jackTriggerADSR.TabIndex = 82
        '
        'jackLinkIn
        '
        Me.jackLinkIn.BackColor = System.Drawing.Color.Transparent
        Me.jackLinkIn.cableColor = 0
        Me.jackLinkIn.cableLabel = False
        Me.jackLinkIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackLinkIn.image = CType(resources.GetObject("jackLinkIn.image"), System.Drawing.Bitmap)
        Me.jackLinkIn.labelText = ""
        Me.jackLinkIn.Location = New System.Drawing.Point(392, 398)
        Me.jackLinkIn.Margin = New System.Windows.Forms.Padding(5)
        Me.jackLinkIn.Name = "jackLinkIn"
        Me.jackLinkIn.Size = New System.Drawing.Size(50, 100)
        Me.jackLinkIn.TabIndex = 83
        '
        'jackADSR
        '
        Me.jackADSR.BackColor = System.Drawing.Color.Transparent
        Me.jackADSR.cableColor = 0
        Me.jackADSR.cableLabel = False
        Me.jackADSR.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackADSR.image = CType(resources.GetObject("jackADSR.image"), System.Drawing.Bitmap)
        Me.jackADSR.labelText = ""
        Me.jackADSR.Location = New System.Drawing.Point(544, 398)
        Me.jackADSR.Margin = New System.Windows.Forms.Padding(5)
        Me.jackADSR.Name = "jackADSR"
        Me.jackADSR.Size = New System.Drawing.Size(50, 100)
        Me.jackADSR.TabIndex = 85
        '
        'MidiThru3
        '
        Me.MidiThru3.BackColor = System.Drawing.Color.Transparent
        Me.MidiThru3.cableColor = 0
        Me.MidiThru3.cableLabel = False
        Me.MidiThru3.image = CType(resources.GetObject("MidiThru3.image"), System.Drawing.Bitmap)
        Me.MidiThru3.labelText = ""
        Me.MidiThru3.Location = New System.Drawing.Point(924, 398)
        Me.MidiThru3.Margin = New System.Windows.Forms.Padding(5)
        Me.MidiThru3.Name = "MidiThru3"
        Me.MidiThru3.Size = New System.Drawing.Size(50, 100)
        Me.MidiThru3.TabIndex = 78
        '
        'jackMainOut
        '
        Me.jackMainOut.BackColor = System.Drawing.Color.Transparent
        Me.jackMainOut.cableColor = 0
        Me.jackMainOut.cableLabel = False
        Me.jackMainOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackMainOut.image = CType(resources.GetObject("jackMainOut.image"), System.Drawing.Bitmap)
        Me.jackMainOut.labelText = ""
        Me.jackMainOut.Location = New System.Drawing.Point(1229, 398)
        Me.jackMainOut.Margin = New System.Windows.Forms.Padding(5)
        Me.jackMainOut.Name = "jackMainOut"
        Me.jackMainOut.Size = New System.Drawing.Size(50, 100)
        Me.jackMainOut.TabIndex = 89
        '
        'jackOut1
        '
        Me.jackOut1.BackColor = System.Drawing.Color.Transparent
        Me.jackOut1.cableColor = 0
        Me.jackOut1.cableLabel = False
        Me.jackOut1.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackOut1.image = CType(resources.GetObject("jackOut1.image"), System.Drawing.Bitmap)
        Me.jackOut1.labelText = ""
        Me.jackOut1.Location = New System.Drawing.Point(1153, 398)
        Me.jackOut1.Margin = New System.Windows.Forms.Padding(5)
        Me.jackOut1.Name = "jackOut1"
        Me.jackOut1.Size = New System.Drawing.Size(50, 100)
        Me.jackOut1.TabIndex = 88
        '
        'jackTriggerAR
        '
        Me.jackTriggerAR.BackColor = System.Drawing.Color.Transparent
        Me.jackTriggerAR.cableColor = 0
        Me.jackTriggerAR.cableLabel = False
        Me.jackTriggerAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.jackTriggerAR.image = CType(resources.GetObject("jackTriggerAR.image"), System.Drawing.Bitmap)
        Me.jackTriggerAR.labelText = ""
        Me.jackTriggerAR.Location = New System.Drawing.Point(1077, 398)
        Me.jackTriggerAR.Margin = New System.Windows.Forms.Padding(5)
        Me.jackTriggerAR.Name = "jackTriggerAR"
        Me.jackTriggerAR.Size = New System.Drawing.Size(50, 100)
        Me.jackTriggerAR.TabIndex = 87
        '
        'knbBypEff
        '
        Me.knbBypEff.BackColor = System.Drawing.Color.Transparent
        Me.knbBypEff.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbBypEff.image = Global.Filterbank15.My.Resources.Resources.knbW
        Me.knbBypEff.Location = New System.Drawing.Point(1197, 66)
        Me.knbBypEff.Margin = New System.Windows.Forms.Padding(5)
        Me.knbBypEff.Name = "knbBypEff"
        Me.knbBypEff.SetLastValue = 0R
        Me.knbBypEff.SetMax = 10
        Me.knbBypEff.SetMin = 0
        Me.knbBypEff.SetValue = 10.0R
        Me.knbBypEff.Size = New System.Drawing.Size(64, 64)
        Me.knbBypEff.TabIndex = 62
        Me.knbBypEff.Tag = "normal"
        '
        'knbFilt2Corr
        '
        Me.knbFilt2Corr.BackColor = System.Drawing.Color.Transparent
        Me.knbFilt2Corr.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFilt2Corr.image = Global.Filterbank15.My.Resources.Resources.knbR
        Me.knbFilt2Corr.Location = New System.Drawing.Point(1198, 212)
        Me.knbFilt2Corr.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFilt2Corr.Name = "knbFilt2Corr"
        Me.knbFilt2Corr.SetLastValue = 0R
        Me.knbFilt2Corr.SetMax = 10
        Me.knbFilt2Corr.SetMin = 0
        Me.knbFilt2Corr.SetValue = 5.0R
        Me.knbFilt2Corr.Size = New System.Drawing.Size(64, 64)
        Me.knbFilt2Corr.TabIndex = 46
        Me.knbFilt2Corr.Tag = "normal"
        '
        'knbFreq1
        '
        Me.knbFreq1.BackColor = System.Drawing.Color.Transparent
        Me.knbFreq1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFreq1.image = Global.Filterbank15.My.Resources.Resources.knbFreq
        Me.knbFreq1.Location = New System.Drawing.Point(91, 203)
        Me.knbFreq1.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFreq1.Name = "knbFreq1"
        Me.knbFreq1.SetLastValue = 0R
        Me.knbFreq1.SetMax = 10
        Me.knbFreq1.SetMin = 1
        Me.knbFreq1.SetValue = 1.0R
        Me.knbFreq1.Size = New System.Drawing.Size(84, 84)
        Me.knbFreq1.TabIndex = 64
        Me.knbFreq1.Tag = "normalfreq"
        '
        'knbFMR
        '
        Me.knbFMR.BackColor = System.Drawing.Color.Transparent
        Me.knbFMR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMR.image = Global.Filterbank15.My.Resources.Resources.knbY
        Me.knbFMR.Location = New System.Drawing.Point(594, 108)
        Me.knbFMR.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMR.Name = "knbFMR"
        Me.knbFMR.SetLastValue = 0R
        Me.knbFMR.SetMax = 10
        Me.knbFMR.SetMin = 1
        Me.knbFMR.SetValue = 1.2R
        Me.knbFMR.Size = New System.Drawing.Size(64, 64)
        Me.knbFMR.TabIndex = 55
        Me.knbFMR.Tag = "normal"
        '
        'knbReso1
        '
        Me.knbReso1.BackColor = System.Drawing.Color.Transparent
        Me.knbReso1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbReso1.image = Global.Filterbank15.My.Resources.Resources.knbR
        Me.knbReso1.Location = New System.Drawing.Point(320, 212)
        Me.knbReso1.Margin = New System.Windows.Forms.Padding(5)
        Me.knbReso1.Name = "knbReso1"
        Me.knbReso1.SetLastValue = 0R
        Me.knbReso1.SetMax = 10
        Me.knbReso1.SetMin = 1
        Me.knbReso1.SetValue = 1.0R
        Me.knbReso1.Size = New System.Drawing.Size(64, 64)
        Me.knbReso1.TabIndex = 42
        Me.knbReso1.Tag = "normal"
        '
        'knbFMFilt
        '
        Me.knbFMFilt.BackColor = System.Drawing.Color.Transparent
        Me.knbFMFilt.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMFilt.image = Global.Filterbank15.My.Resources.Resources.knbW
        Me.knbFMFilt.Location = New System.Drawing.Point(430, 212)
        Me.knbFMFilt.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMFilt.Name = "knbFMFilt"
        Me.knbFMFilt.SetLastValue = 0R
        Me.knbFMFilt.SetMax = 10
        Me.knbFMFilt.SetMin = 0
        Me.knbFMFilt.SetValue = 5.0R
        Me.knbFMFilt.Size = New System.Drawing.Size(64, 64)
        Me.knbFMFilt.TabIndex = 60
        Me.knbFMFilt.Tag = "normal"
        '
        'knbFM
        '
        Me.knbFM.BackColor = System.Drawing.Color.Transparent
        Me.knbFM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFM.image = Global.Filterbank15.My.Resources.Resources.knbB
        Me.knbFM.Location = New System.Drawing.Point(175, 108)
        Me.knbFM.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFM.Name = "knbFM"
        Me.knbFM.SetLastValue = 0R
        Me.knbFM.SetMax = 10
        Me.knbFM.SetMin = 1
        Me.knbFM.SetValue = 1.0R
        Me.knbFM.Size = New System.Drawing.Size(64, 64)
        Me.knbFM.TabIndex = 51
        Me.knbFM.Tag = "normal"
        '
        'knbAMFiltSens
        '
        Me.knbAMFiltSens.BackColor = System.Drawing.Color.Transparent
        Me.knbAMFiltSens.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbAMFiltSens.image = Global.Filterbank15.My.Resources.Resources.knbY2
        Me.knbAMFiltSens.Location = New System.Drawing.Point(869, 212)
        Me.knbAMFiltSens.Margin = New System.Windows.Forms.Padding(5)
        Me.knbAMFiltSens.Name = "knbAMFiltSens"
        Me.knbAMFiltSens.SetLastValue = 0R
        Me.knbAMFiltSens.SetMax = 10
        Me.knbAMFiltSens.SetMin = 0
        Me.knbAMFiltSens.SetValue = 5.0R
        Me.knbAMFiltSens.Size = New System.Drawing.Size(64, 64)
        Me.knbAMFiltSens.TabIndex = 57
        Me.knbAMFiltSens.Tag = "side"
        '
        'knbAM
        '
        Me.knbAM.BackColor = System.Drawing.Color.Transparent
        Me.knbAM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbAM.image = Global.Filterbank15.My.Resources.Resources.knbG
        Me.knbAM.Location = New System.Drawing.Point(928, 66)
        Me.knbAM.Margin = New System.Windows.Forms.Padding(5)
        Me.knbAM.Name = "knbAM"
        Me.knbAM.SetLastValue = 0R
        Me.knbAM.SetMax = 10
        Me.knbAM.SetMin = 1
        Me.knbAM.SetValue = 1.0R
        Me.knbAM.Size = New System.Drawing.Size(64, 64)
        Me.knbAM.TabIndex = 48
        Me.knbAM.Tag = "normal"
        '
        'knbFMS
        '
        Me.knbFMS.BackColor = System.Drawing.Color.Transparent
        Me.knbFMS.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMS.image = Global.Filterbank15.My.Resources.Resources.knbY2
        Me.knbFMS.Location = New System.Drawing.Point(484, 108)
        Me.knbFMS.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMS.Name = "knbFMS"
        Me.knbFMS.SetLastValue = 0R
        Me.knbFMS.SetMax = 10
        Me.knbFMS.SetMin = 0
        Me.knbFMS.SetValue = 5.0R
        Me.knbFMS.Size = New System.Drawing.Size(64, 64)
        Me.knbFMS.TabIndex = 54
        Me.knbFMS.Tag = "side"
        '
        'knbAMFilt
        '
        Me.knbAMFilt.BackColor = System.Drawing.Color.Transparent
        Me.knbAMFilt.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbAMFilt.image = Global.Filterbank15.My.Resources.Resources.knbW
        Me.knbAMFilt.Location = New System.Drawing.Point(1088, 212)
        Me.knbAMFilt.Margin = New System.Windows.Forms.Padding(5)
        Me.knbAMFilt.Name = "knbAMFilt"
        Me.knbAMFilt.SetLastValue = 0R
        Me.knbAMFilt.SetMax = 10
        Me.knbAMFilt.SetMin = 0
        Me.knbAMFilt.SetValue = 5.0R
        Me.knbAMFilt.Size = New System.Drawing.Size(64, 64)
        Me.knbAMFilt.TabIndex = 61
        Me.knbAMFilt.Tag = "normal"
        '
        'knbDepth
        '
        Me.knbDepth.BackColor = System.Drawing.Color.Transparent
        Me.knbDepth.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbDepth.image = Global.Filterbank15.My.Resources.Resources.knbB
        Me.knbDepth.Location = New System.Drawing.Point(813, 66)
        Me.knbDepth.Margin = New System.Windows.Forms.Padding(5)
        Me.knbDepth.Name = "knbDepth"
        Me.knbDepth.SetLastValue = 0R
        Me.knbDepth.SetMax = 10
        Me.knbDepth.SetMin = 0
        Me.knbDepth.SetValue = 5.0R
        Me.knbDepth.Size = New System.Drawing.Size(64, 64)
        Me.knbDepth.TabIndex = 59
        Me.knbDepth.Tag = "normal"
        '
        'knbFMD
        '
        Me.knbFMD.BackColor = System.Drawing.Color.Transparent
        Me.knbFMD.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMD.image = Global.Filterbank15.My.Resources.Resources.knbY
        Me.knbFMD.Location = New System.Drawing.Point(384, 66)
        Me.knbFMD.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMD.Name = "knbFMD"
        Me.knbFMD.SetLastValue = 0R
        Me.knbFMD.SetMax = 10
        Me.knbFMD.SetMin = 1
        Me.knbFMD.SetValue = 1.0R
        Me.knbFMD.Size = New System.Drawing.Size(64, 64)
        Me.knbFMD.TabIndex = 53
        Me.knbFMD.Tag = "normal"
        '
        'knbFreq2
        '
        Me.knbFreq2.BackColor = System.Drawing.Color.Transparent
        Me.knbFreq2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFreq2.image = Global.Filterbank15.My.Resources.Resources.knbFreq
        Me.knbFreq2.Location = New System.Drawing.Point(749, 203)
        Me.knbFreq2.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFreq2.Name = "knbFreq2"
        Me.knbFreq2.SetLastValue = 0R
        Me.knbFreq2.SetMax = 10
        Me.knbFreq2.SetMin = 1
        Me.knbFreq2.SetValue = 1.0R
        Me.knbFreq2.Size = New System.Drawing.Size(84, 84)
        Me.knbFreq2.TabIndex = 65
        Me.knbFreq2.Tag = "normalfreq"
        '
        'knbParSer
        '
        Me.knbParSer.BackColor = System.Drawing.Color.Transparent
        Me.knbParSer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbParSer.image = Global.Filterbank15.My.Resources.Resources.knbR
        Me.knbParSer.Location = New System.Drawing.Point(1088, 66)
        Me.knbParSer.Margin = New System.Windows.Forms.Padding(5)
        Me.knbParSer.Name = "knbParSer"
        Me.knbParSer.SetLastValue = 0R
        Me.knbParSer.SetMax = 10
        Me.knbParSer.SetMin = 0
        Me.knbParSer.SetValue = 0R
        Me.knbParSer.Size = New System.Drawing.Size(64, 64)
        Me.knbParSer.TabIndex = 44
        Me.knbParSer.Tag = "normal"
        '
        'knbSpeed
        '
        Me.knbSpeed.BackColor = System.Drawing.Color.Transparent
        Me.knbSpeed.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbSpeed.image = Global.Filterbank15.My.Resources.Resources.knbB
        Me.knbSpeed.Location = New System.Drawing.Point(704, 66)
        Me.knbSpeed.Margin = New System.Windows.Forms.Padding(5)
        Me.knbSpeed.Name = "knbSpeed"
        Me.knbSpeed.SetLastValue = 0R
        Me.knbSpeed.SetMax = 10
        Me.knbSpeed.SetMin = 1
        Me.knbSpeed.SetValue = 1.0R
        Me.knbSpeed.Size = New System.Drawing.Size(64, 64)
        Me.knbSpeed.TabIndex = 58
        Me.knbSpeed.Tag = "normal"
        '
        'knbHarm
        '
        Me.knbHarm.BackColor = System.Drawing.Color.Transparent
        Me.knbHarm.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbHarm.image = Global.Filterbank15.My.Resources.Resources.knbHarm
        Me.knbHarm.Location = New System.Drawing.Point(631, 194)
        Me.knbHarm.Margin = New System.Windows.Forms.Padding(5)
        Me.knbHarm.Name = "knbHarm"
        Me.knbHarm.SetLastValue = 0R
        Me.knbHarm.SetMax = 12
        Me.knbHarm.SetMin = 0
        Me.knbHarm.SetValue = 0R
        Me.knbHarm.Size = New System.Drawing.Size(100, 100)
        Me.knbHarm.TabIndex = 63
        Me.knbHarm.Tag = "normalharm"
        '
        'knbInput
        '
        Me.knbInput.BackColor = System.Drawing.Color.Transparent
        Me.knbInput.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbInput.image = Global.Filterbank15.My.Resources.Resources.knbG
        Me.knbInput.Location = New System.Drawing.Point(101, 66)
        Me.knbInput.Margin = New System.Windows.Forms.Padding(5)
        Me.knbInput.Name = "knbInput"
        Me.knbInput.SetLastValue = 0R
        Me.knbInput.SetMax = 10
        Me.knbInput.SetMin = 1
        Me.knbInput.SetValue = 1.0R
        Me.knbInput.Size = New System.Drawing.Size(64, 64)
        Me.knbInput.TabIndex = 47
        Me.knbInput.Tag = "normal"
        '
        'knbReso2
        '
        Me.knbReso2.BackColor = System.Drawing.Color.Transparent
        Me.knbReso2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbReso2.image = Global.Filterbank15.My.Resources.Resources.knbR
        Me.knbReso2.Location = New System.Drawing.Point(978, 212)
        Me.knbReso2.Margin = New System.Windows.Forms.Padding(5)
        Me.knbReso2.Name = "knbReso2"
        Me.knbReso2.SetLastValue = 0R
        Me.knbReso2.SetMax = 10
        Me.knbReso2.SetMin = 1
        Me.knbReso2.SetValue = 1.0R
        Me.knbReso2.Size = New System.Drawing.Size(64, 64)
        Me.knbReso2.TabIndex = 43
        Me.knbReso2.Tag = "normal"
        '
        'knbFMA
        '
        Me.knbFMA.BackColor = System.Drawing.Color.Transparent
        Me.knbFMA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMA.image = Global.Filterbank15.My.Resources.Resources.knbY
        Me.knbFMA.Location = New System.Drawing.Point(283, 108)
        Me.knbFMA.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMA.Name = "knbFMA"
        Me.knbFMA.SetLastValue = 0R
        Me.knbFMA.SetMax = 10
        Me.knbFMA.SetMin = 1
        Me.knbFMA.SetValue = 1.0R
        Me.knbFMA.Size = New System.Drawing.Size(64, 64)
        Me.knbFMA.TabIndex = 52
        Me.knbFMA.Tag = "normal"
        '
        'knbFilt1Corr
        '
        Me.knbFilt1Corr.BackColor = System.Drawing.Color.Transparent
        Me.knbFilt1Corr.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFilt1Corr.image = Global.Filterbank15.My.Resources.Resources.knbR
        Me.knbFilt1Corr.Location = New System.Drawing.Point(540, 212)
        Me.knbFilt1Corr.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFilt1Corr.Name = "knbFilt1Corr"
        Me.knbFilt1Corr.SetLastValue = 0R
        Me.knbFilt1Corr.SetMax = 10
        Me.knbFilt1Corr.SetMin = 0
        Me.knbFilt1Corr.SetValue = 5.0R
        Me.knbFilt1Corr.Size = New System.Drawing.Size(64, 64)
        Me.knbFilt1Corr.TabIndex = 45
        Me.knbFilt1Corr.Tag = "normal"
        '
        'knbAMA
        '
        Me.knbAMA.BackColor = System.Drawing.Color.Transparent
        Me.knbAMA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbAMA.image = Global.Filterbank15.My.Resources.Resources.knbG
        Me.knbAMA.Location = New System.Drawing.Point(1033, 139)
        Me.knbAMA.Margin = New System.Windows.Forms.Padding(5)
        Me.knbAMA.Name = "knbAMA"
        Me.knbAMA.SetLastValue = 0R
        Me.knbAMA.SetMax = 10
        Me.knbAMA.SetMin = 1
        Me.knbAMA.SetValue = 1.0R
        Me.knbAMA.Size = New System.Drawing.Size(64, 64)
        Me.knbAMA.TabIndex = 49
        Me.knbAMA.Tag = "normal"
        '
        'knbFMFiltSens
        '
        Me.knbFMFiltSens.BackColor = System.Drawing.Color.Transparent
        Me.knbFMFiltSens.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbFMFiltSens.image = Global.Filterbank15.My.Resources.Resources.knbY2
        Me.knbFMFiltSens.Location = New System.Drawing.Point(210, 212)
        Me.knbFMFiltSens.Margin = New System.Windows.Forms.Padding(5)
        Me.knbFMFiltSens.Name = "knbFMFiltSens"
        Me.knbFMFiltSens.SetLastValue = 0R
        Me.knbFMFiltSens.SetMax = 10
        Me.knbFMFiltSens.SetMin = 0
        Me.knbFMFiltSens.SetValue = 5.0R
        Me.knbFMFiltSens.Size = New System.Drawing.Size(64, 64)
        Me.knbFMFiltSens.TabIndex = 56
        Me.knbFMFiltSens.Tag = "side"
        '
        'knbAMR
        '
        Me.knbAMR.BackColor = System.Drawing.Color.Transparent
        Me.knbAMR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.knbAMR.image = Global.Filterbank15.My.Resources.Resources.knbG
        Me.knbAMR.Location = New System.Drawing.Point(1143, 139)
        Me.knbAMR.Margin = New System.Windows.Forms.Padding(5)
        Me.knbAMR.Name = "knbAMR"
        Me.knbAMR.SetLastValue = 0R
        Me.knbAMR.SetMax = 10
        Me.knbAMR.SetMin = 1
        Me.knbAMR.SetValue = 1.0R
        Me.knbAMR.Size = New System.Drawing.Size(64, 64)
        Me.knbAMR.TabIndex = 50
        Me.knbAMR.Tag = "normal"
        '
        'swtchTrack
        '
        Me.swtchTrack.BackColor = System.Drawing.Color.Transparent
        Me.swtchTrack.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchTrack.image = Global.Filterbank15.My.Resources.Resources.switch
        Me.swtchTrack.Location = New System.Drawing.Point(13, 264)
        Me.swtchTrack.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchTrack.Name = "swtchTrack"
        Me.swtchTrack.numberofvalues = 3
        Me.swtchTrack.SetLastValue = 0R
        Me.swtchTrack.SetValue = 2
        Me.swtchTrack.Size = New System.Drawing.Size(50, 50)
        Me.swtchTrack.TabIndex = 33
        Me.swtchTrack.Tag = "normal"
        '
        'swtchSensi
        '
        Me.swtchSensi.BackColor = System.Drawing.Color.Transparent
        Me.swtchSensi.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchSensi.image = Global.Filterbank15.My.Resources.Resources.switch
        Me.swtchSensi.Location = New System.Drawing.Point(51, 137)
        Me.swtchSensi.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchSensi.Name = "swtchSensi"
        Me.swtchSensi.numberofvalues = 3
        Me.swtchSensi.SetLastValue = 0R
        Me.swtchSensi.SetValue = 2
        Me.swtchSensi.Size = New System.Drawing.Size(50, 50)
        Me.swtchSensi.TabIndex = 31
        Me.swtchSensi.Tag = "normal"
        '
        'swtchOctave
        '
        Me.swtchOctave.BackColor = System.Drawing.Color.Transparent
        Me.swtchOctave.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchOctave.image = Global.Filterbank15.My.Resources.Resources.switch
        Me.swtchOctave.Location = New System.Drawing.Point(7, 197)
        Me.swtchOctave.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchOctave.Name = "swtchOctave"
        Me.swtchOctave.numberofvalues = 3
        Me.swtchOctave.SetLastValue = 0R
        Me.swtchOctave.SetValue = 2
        Me.swtchOctave.Size = New System.Drawing.Size(50, 50)
        Me.swtchOctave.TabIndex = 32
        Me.swtchOctave.Tag = "normal"
        '
        'swtchARADSR
        '
        Me.swtchARADSR.BackColor = System.Drawing.Color.Transparent
        Me.swtchARADSR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchARADSR.image = Global.Filterbank15.My.Resources.Resources.switch
        Me.swtchARADSR.Location = New System.Drawing.Point(643, 65)
        Me.swtchARADSR.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchARADSR.Name = "swtchARADSR"
        Me.swtchARADSR.numberofvalues = 2
        Me.swtchARADSR.SetLastValue = 0R
        Me.swtchARADSR.SetValue = 1
        Me.swtchARADSR.Size = New System.Drawing.Size(50, 50)
        Me.swtchARADSR.TabIndex = 35
        Me.swtchARADSR.Tag = "normal"
        '
        'swtchAR
        '
        Me.swtchAR.BackColor = System.Drawing.Color.Transparent
        Me.swtchAR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchAR.image = Global.Filterbank15.My.Resources.Resources.switchside
        Me.swtchAR.Location = New System.Drawing.Point(712, 133)
        Me.swtchAR.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchAR.Name = "swtchAR"
        Me.swtchAR.numberofvalues = 3
        Me.swtchAR.SetLastValue = 0R
        Me.swtchAR.SetValue = 2
        Me.swtchAR.Size = New System.Drawing.Size(50, 50)
        Me.swtchAR.TabIndex = 34
        Me.swtchAR.Tag = "side"
        '
        'swtchBoostCut
        '
        Me.swtchBoostCut.BackColor = System.Drawing.Color.Transparent
        Me.swtchBoostCut.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.swtchBoostCut.image = Global.Filterbank15.My.Resources.Resources.switch
        Me.swtchBoostCut.Location = New System.Drawing.Point(8, 73)
        Me.swtchBoostCut.Margin = New System.Windows.Forms.Padding(4)
        Me.swtchBoostCut.Name = "swtchBoostCut"
        Me.swtchBoostCut.numberofvalues = 3
        Me.swtchBoostCut.SetLastValue = 0R
        Me.swtchBoostCut.SetValue = 2
        Me.swtchBoostCut.Size = New System.Drawing.Size(50, 50)
        Me.swtchBoostCut.TabIndex = 30
        Me.swtchBoostCut.Tag = "normal"
        '
        'fb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Filterbank15.My.Resources.Resources.fb2bgReal15
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1316, 500)
        Me.Controls.Add(Me.jackLinkOut)
        Me.Controls.Add(Me.jackSignalIn)
        Me.Controls.Add(Me.MidiOut)
        Me.Controls.Add(Me.jackLFOOut)
        Me.Controls.Add(Me.jackAMIn)
        Me.Controls.Add(Me.MidiIn)
        Me.Controls.Add(Me.jackFMIn)
        Me.Controls.Add(Me.jackPedalIn)
        Me.Controls.Add(Me.MidiThru1)
        Me.Controls.Add(Me.MidiThru2)
        Me.Controls.Add(Me.jackTriggerADSR)
        Me.Controls.Add(Me.jackLinkIn)
        Me.Controls.Add(Me.jackADSR)
        Me.Controls.Add(Me.MidiThru3)
        Me.Controls.Add(Me.jackMainOut)
        Me.Controls.Add(Me.jackOut1)
        Me.Controls.Add(Me.jackTriggerAR)
        Me.Controls.Add(Me.lblPresetName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.knbBypEff)
        Me.Controls.Add(Me.knbFilt2Corr)
        Me.Controls.Add(Me.knbFreq1)
        Me.Controls.Add(Me.knbFMR)
        Me.Controls.Add(Me.knbReso1)
        Me.Controls.Add(Me.knbFMFilt)
        Me.Controls.Add(Me.knbFM)
        Me.Controls.Add(Me.knbAMFiltSens)
        Me.Controls.Add(Me.knbAM)
        Me.Controls.Add(Me.knbFMS)
        Me.Controls.Add(Me.knbAMFilt)
        Me.Controls.Add(Me.knbDepth)
        Me.Controls.Add(Me.knbFMD)
        Me.Controls.Add(Me.knbFreq2)
        Me.Controls.Add(Me.knbParSer)
        Me.Controls.Add(Me.knbSpeed)
        Me.Controls.Add(Me.knbHarm)
        Me.Controls.Add(Me.knbInput)
        Me.Controls.Add(Me.knbReso2)
        Me.Controls.Add(Me.knbFMA)
        Me.Controls.Add(Me.knbFilt1Corr)
        Me.Controls.Add(Me.knbAMA)
        Me.Controls.Add(Me.knbFMFiltSens)
        Me.Controls.Add(Me.knbAMR)
        Me.Controls.Add(Me.swtchTrack)
        Me.Controls.Add(Me.swtchSensi)
        Me.Controls.Add(Me.swtchOctave)
        Me.Controls.Add(Me.swtchARADSR)
        Me.Controls.Add(Me.swtchAR)
        Me.Controls.Add(Me.swtchBoostCut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1334, 547)
        Me.MinimumSize = New System.Drawing.Size(1334, 547)
        Me.Name = "fb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filterbank Manager v1.5"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchematicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents swtchBoostCut As Filterbank15.Switch
    Friend WithEvents swtchSensi As Filterbank15.Switch
    Friend WithEvents swtchOctave As Filterbank15.Switch
    Friend WithEvents swtchTrack As Filterbank15.Switch
    Friend WithEvents swtchAR As Filterbank15.Switch
    Friend WithEvents swtchARADSR As Filterbank15.Switch
    Friend WithEvents knbReso1 As Filterbank15.Knob
    Friend WithEvents knbReso2 As Filterbank15.Knob
    Friend WithEvents knbParSer As Filterbank15.Knob
    Friend WithEvents knbFilt1Corr As Filterbank15.Knob
    Friend WithEvents knbFilt2Corr As Filterbank15.Knob
    Friend WithEvents knbInput As Filterbank15.Knob
    Friend WithEvents knbAM As Filterbank15.Knob
    Friend WithEvents knbAMA As Filterbank15.Knob
    Friend WithEvents knbAMR As Filterbank15.Knob
    Friend WithEvents knbFM As Filterbank15.Knob
    Friend WithEvents knbFMA As Filterbank15.Knob
    Friend WithEvents knbFMD As Filterbank15.Knob
    Friend WithEvents knbFMS As Filterbank15.Knob
    Friend WithEvents knbFMR As Filterbank15.Knob
    Friend WithEvents knbFMFiltSens As Filterbank15.Knob
    Friend WithEvents knbAMFiltSens As Filterbank15.Knob
    Friend WithEvents knbSpeed As Filterbank15.Knob
    Friend WithEvents knbDepth As Filterbank15.Knob
    Friend WithEvents knbFMFilt As Filterbank15.Knob
    Friend WithEvents knbAMFilt As Filterbank15.Knob
    Friend WithEvents knbBypEff As Filterbank15.Knob
    Friend WithEvents knbHarm As Filterbank15.Knob
    Friend WithEvents knbFreq1 As Filterbank15.Knob
    Friend WithEvents knbFreq2 As Filterbank15.Knob
    Friend WithEvents SaveAsPNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsFbmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadFbmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsmPresets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPresetName As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents jackLFOOut As Filterbank15.Jack
    Friend WithEvents MidiIn As Filterbank15.Midi
    Friend WithEvents MidiOut As Filterbank15.Midi
    Friend WithEvents MidiThru1 As Filterbank15.Midi
    Friend WithEvents MidiThru2 As Filterbank15.Midi
    Friend WithEvents MidiThru3 As Filterbank15.Midi
    Friend WithEvents jackPedalIn As Filterbank15.Jack
    Friend WithEvents jackSignalIn As Filterbank15.Jack
    Friend WithEvents jackFMIn As Filterbank15.Jack
    Friend WithEvents jackTriggerADSR As Filterbank15.Jack
    Friend WithEvents jackLinkIn As Filterbank15.Jack
    Friend WithEvents jackLinkOut As Filterbank15.Jack
    Friend WithEvents jackADSR As Filterbank15.Jack
    Friend WithEvents jackAMIn As Filterbank15.Jack
    Friend WithEvents jackTriggerAR As Filterbank15.Jack
    Friend WithEvents jackOut1 As Filterbank15.Jack
    Friend WithEvents jackMainOut As Filterbank15.Jack
    Friend WithEvents CleanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents rctImage As PowerPacks.RectangleShape
End Class
