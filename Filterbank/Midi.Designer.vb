<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Midi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ctxtColor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetLabelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnplugToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPlugLabel = New System.Windows.Forms.TextBox()
        Me.ctxtColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctxtColor
        '
        Me.ctxtColor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxtColor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetLabelToolStripMenuItem1, Me.UnplugToolStripMenuItem1, Me.ToolStripSeparator1, Me.RedToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.YellowToolStripMenuItem, Me.BlackToolStripMenuItem, Me.BlueToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.GreenToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem})
        Me.ctxtColor.Name = "ContextMenuStrip1"
        Me.ctxtColor.Size = New System.Drawing.Size(141, 296)
        '
        'SetLabelToolStripMenuItem1
        '
        Me.SetLabelToolStripMenuItem1.Name = "SetLabelToolStripMenuItem1"
        Me.SetLabelToolStripMenuItem1.Size = New System.Drawing.Size(140, 26)
        Me.SetLabelToolStripMenuItem1.Text = "Label"
        '
        'UnplugToolStripMenuItem1
        '
        Me.UnplugToolStripMenuItem1.Name = "UnplugToolStripMenuItem1"
        Me.UnplugToolStripMenuItem1.Size = New System.Drawing.Size(140, 26)
        Me.UnplugToolStripMenuItem1.Text = "UNPLUG"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.YellowToolStripMenuItem.Text = "Black"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.BlackToolStripMenuItem.Text = "Yellow"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'txtPlugLabel
        '
        Me.txtPlugLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlugLabel.Location = New System.Drawing.Point(0, 70)
        Me.txtPlugLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPlugLabel.Name = "txtPlugLabel"
        Me.txtPlugLabel.Size = New System.Drawing.Size(50, 19)
        Me.txtPlugLabel.TabIndex = 1
        Me.txtPlugLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Midi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtPlugLabel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Midi"
        Me.Size = New System.Drawing.Size(200, 185)
        Me.ctxtColor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctxtColor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnplugToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPlugLabel As System.Windows.Forms.TextBox
    Friend WithEvents SetLabelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
