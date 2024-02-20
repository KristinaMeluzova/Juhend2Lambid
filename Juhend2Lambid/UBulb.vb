Imports System.Windows.Forms.AxHost
Imports Juhen2Lüliti
Imports Microsoft.Win32

Public Class UBulb
    Public state As Boolean = False
    'Meetod kuvatava pildi määramiseks
    Private Sub selectState(ByVal intLamp As Integer)
        pbLamp.Image = imageLoend.Images(intLamp)
    End Sub

    Public Sub lampClear()
        ' PictureBoxi Image väärtuseks omistame Nothing
        If pbLamp.Image IsNot Nothing Then
            pbLamp.Image.Dispose()
        End If
        pbLamp.Image = Nothing
    End Sub

    'Avalik liidesmeetod 
    Public Sub setState(ByVal strState As String)
        Select Case strState
            Case "Off"
                Me.selectState(0)
            Case "On"
                Me.selectState(1)
            Case Else
                Me.selectState(0)
        End Select
    End Sub
End Class
