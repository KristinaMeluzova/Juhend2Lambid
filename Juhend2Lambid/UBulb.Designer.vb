﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UBulb
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UBulb))
        Me.pbLamp = New System.Windows.Forms.PictureBox()
        Me.imageLoend = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbLamp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLamp
        '
        Me.pbLamp.Location = New System.Drawing.Point(331, 109)
        Me.pbLamp.Name = "pbLamp"
        Me.pbLamp.Size = New System.Drawing.Size(138, 201)
        Me.pbLamp.TabIndex = 0
        Me.pbLamp.TabStop = False
        '
        'imageLoend
        '
        Me.imageLoend.ImageStream = CType(resources.GetObject("imageLoend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageLoend.TransparentColor = System.Drawing.Color.Transparent
        Me.imageLoend.Images.SetKeyName(0, "lamp off.jpg")
        Me.imageLoend.Images.SetKeyName(1, "lamp on.jpg")
        '
        'UBulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbLamp)
        Me.Name = "UBulb"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.pbLamp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLamp As PictureBox
    Friend WithEvents imageLoend As ImageList
End Class