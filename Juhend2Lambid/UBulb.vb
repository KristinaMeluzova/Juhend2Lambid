Public Class UBulb
    'Meetod kuvatava pildi määramiseks
    Private Sub selectState(ByVal intLamp As Integer)
        pbLamp.Image = imageLoend.Images(intLamp)
    End Sub


    'Avalik liidesmeetod 
    Public Sub setState(ByVal strState As String)
        Select Case strState
            Case "Off"
                Me.selectState(0)
            Case "On"
                Me.selectState(1)
        End Select
    End Sub

End Class
