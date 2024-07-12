Imports System.Windows.Forms
 Public Class Dialog2
     Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If alerttitle.Text.Length < 1 Then
            MsgBox("Enter Title First!!!")
            Return
        End If
        If aletmsg.Text.Length < 1 Then
            MsgBox("Enter Msg First!!!")
            Return
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
     Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
     Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     End Sub
End Class
