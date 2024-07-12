Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices

Module Starter

    Public id As Integer = Nothing


    <STAThread>
    Sub Main(args As String())

        If args.Length = 0 Then
            Return
        End If

        If args(0) = Nothing Then
            ' System.IO.File.Delete(Application.ExecutablePath)
            Return

        Else

            If Not IsNumeric(args(0)) Then
                Return
            End If

            Dim Procid As String = RD(args(0))
            If Procid Is Nothing Then
                Return
            End If

            Dim cont As Integer = 0
            For Each p In Process.GetProcesses
                If p.Id.ToString = Procid Then
                    cont = 1
                End If
            Next

            If cont = 0 Then
                Return
            End If
            id = Procid
        End If


        'Application.EnableVisualStyles()
        'Application.SetCompatibleTextRenderingDefault(False)
        Form1.ST(args(1))
        'Call CallByName(Form1, "ST", vbMethod, New Object() {args(1)})
        'Application.Run(Form1)
    End Sub
    Const WDA_NONE As UInteger = 0
    Public Const WDA_MONITOR As UInteger = 1
    <DllImport("user32.dll")>
    Public Function SetWindowDisplayAffinity(ByVal hWnd As IntPtr, ByVal dwAffinity As UInteger) As UInteger

    End Function
    Public Function RD(ByVal ar As String) As String
        Return Form1.Fi(ar)

    End Function


End Module
