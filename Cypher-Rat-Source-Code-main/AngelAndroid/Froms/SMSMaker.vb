Public Class SMSMaker
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phonetext.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Sendsbtn_Click(sender As Object, e As EventArgs) Handles sendsbtn.Click
        If String.IsNullOrEmpty(phonetext.Text) Or String.IsNullOrWhiteSpace(phonetext.Text) Then
            MsgBox("Enter Phone Number First")
            Return
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs) Handles MetroSetButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class