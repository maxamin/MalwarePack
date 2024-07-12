Public Class EditConnections
    Public NewHost As String = ""
    Public NewPort As String = ""
    Public NewName As String = ""
    Public targetclient As sockets.Client = Nothing
    Sub New(cli As sockets.Client)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        targetclient = cli
    End Sub

    Private Sub EditConnections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = targetclient.Wallpaper(0)
        Nametext.Text = targetclient.ClientName
        Dim DNS As String = My.Settings.build_DGV_list

        Try
            If Not DNS = "null" Then

                Dim spl_Lines As String() = DNS.Split({"[x0DNS0x]"}, StringSplitOptions.None)

                For Each row In spl_Lines

                    If row.Length > 0 Then

                        If row.Contains(":") Then

                            Try
                                Hosttext.Text = row.Split(":")(0)
                                Exit For
                            Catch ex As Exception

                            End Try
                        End If

                    End If

                Next

            End If
        Catch ex As Exception

        End Try
        Porttext.Text = My.Settings.build_text_port

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(Hosttext.Text) Or String.IsNullOrWhiteSpace(Hosttext.Text) Then
            MsgBox("Enter Host Name First")
            Return
        End If
        If String.IsNullOrEmpty(Porttext.Text) Or String.IsNullOrWhiteSpace(Porttext.Text) Then
            MsgBox("Enter Port First")
            Return
        End If
        If String.IsNullOrEmpty(Nametext.Text) Or String.IsNullOrWhiteSpace(Nametext.Text) Then
            MsgBox("Enter Name First")
            Return
        End If
        NewHost = Hosttext.Text
        NewPort = Porttext.Text
        NewName = Nametext.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class