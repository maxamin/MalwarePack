Imports System.Windows.Forms
 Public Class dia
     Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
     Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
     Private Sub NewKey_Click(sender As Object, e As EventArgs) Handles NewKey.Click
        NewKey.Text = ""
    End Sub
End Class
