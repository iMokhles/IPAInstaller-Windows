Public Class Form1
    Dim loc As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim Temp As String = loc + "/ipainstaller"
    Public Sub ResetAll()
        ControlBox = True
        RichTextBox1.WordWrap = False
        Label1.Text = "Connect Device"
        Button1.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(Temp) Then
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevice_id.exe", My.Resources.idevice_id, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicebackup.exe", My.Resources.idevicebackup, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicebackup2.exe", My.Resources.idevicebackup2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicedebugserverproxy.exe", My.Resources.idevicedebugserverproxy, False)

            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceimagemounter.exe", My.Resources.ideviceimagemounter, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceinfo.exe", My.Resources.ideviceinfo, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceinstaller.exe", My.Resources.ideviceinstaller, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceprovision.exe", My.Resources.ideviceprovision, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicescreenshot.exe", My.Resources.idevicescreenshot, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libxml2-2.dll", My.Resources.libxml2_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libcurl-4.dll", My.Resources.libcurl_4, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libgcc_s_dw2-1.dll", My.Resources.libgcc_s_dw2_1, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libiconv-2.dll", My.Resources.libiconv_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libimobiledevice.dll", My.Resources.libimobiledevice, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libplist.dll", My.Resources.libplist, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libusbmuxd.dll", My.Resources.libusbmuxd, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libzip-2.dll", My.Resources.libzip_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/msvcr110.dll", My.Resources.msvcr110, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libMobileDevice.dll", My.Resources.libMobileDevice, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/readline5.dll", My.Resources.readline5, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/zlib1.dll", My.Resources.zlib1, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libeay32.dll", My.Resources.libeay32, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ssleay32.dll", My.Resources.ssleay32, False)
            RichTextBox1.Text = ""
        Else
            System.IO.Directory.CreateDirectory(Temp)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevice_id.exe", My.Resources.idevice_id, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicebackup.exe", My.Resources.idevicebackup, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicebackup2.exe", My.Resources.idevicebackup2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicedebugserverproxy.exe", My.Resources.idevicedebugserverproxy, False)

            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceimagemounter.exe", My.Resources.ideviceimagemounter, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceinfo.exe", My.Resources.ideviceinfo, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceinstaller.exe", My.Resources.ideviceinstaller, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ideviceprovision.exe", My.Resources.ideviceprovision, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/idevicescreenshot.exe", My.Resources.idevicescreenshot, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libxml2-2.dll", My.Resources.libxml2_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libcurl-4.dll", My.Resources.libcurl_4, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libgcc_s_dw2-1.dll", My.Resources.libgcc_s_dw2_1, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libiconv-2.dll", My.Resources.libiconv_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libimobiledevice.dll", My.Resources.libimobiledevice, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libplist.dll", My.Resources.libplist, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libusbmuxd.dll", My.Resources.libusbmuxd, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libzip-2.dll", My.Resources.libzip_2, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/msvcr110.dll", My.Resources.msvcr110, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libMobileDevice.dll", My.Resources.libMobileDevice, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/readline5.dll", My.Resources.readline5, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/zlib1.dll", My.Resources.zlib1, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/libeay32.dll", My.Resources.libeay32, False)
            My.Computer.FileSystem.WriteAllBytes(Temp + "/ssleay32.dll", My.Resources.ssleay32, False)
            RichTextBox1.Text = ""
        End If
        Console.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsUserlandConnected() = True Then
            Label1.Text = "iOS device detected!"
            Button1.Enabled = True
        Else
            ResetAll()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.AddExtension = True
        OpenFileDialog.CheckFileExists = True
        OpenFileDialog.CheckPathExists = True
        OpenFileDialog.DefaultExt = "ipa"
        OpenFileDialog.DereferenceLinks = True
        OpenFileDialog.Filter = "ipa files (*.ipa)|*.ipa"
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop 'default path Desktop
        OpenFileDialog.Multiselect = False
        OpenFileDialog.ReadOnlyChecked = True
        OpenFileDialog.ShowReadOnly = False
        OpenFileDialog.ShowHelp = False
        OpenFileDialog.SupportMultiDottedExtensions = False
        OpenFileDialog.Title = "Select a ipa file..."
        OpenFileDialog.ValidateNames = True
        Dim ReturnedValue As DialogResult = OpenFileDialog.ShowDialog()
        If ReturnedValue = DialogResult.OK Then
            TextBox1.Text = ControlChars.Quote & OpenFileDialog.FileName & ControlChars.Quote
        End If
        OpenFileDialog.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Shell method
        Dim installerPath As String = Temp + "/ideviceinstaller.exe"
        Dim outPut As String
        outPut = GetCMDOutput(installerPath, " -g " & TextBox1.Text.ToString)
        RichTextBox1.Text = outPut
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <20%>" + " " + vbNewLine)
        Threading.Thread.Sleep(100)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <25%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <30%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <35%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <40%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <45%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <50%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <55%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <65%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <70%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <75%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <80%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <85%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <90%>" + " " + vbNewLine)
        Threading.Thread.Sleep(200)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <95%>" + " " + vbNewLine)
        Threading.Thread.Sleep(700)
        RichTextBox1.AppendText("Upgrade - ExtractingPackage <100%>" + " " + vbNewLine)
        RichTextBox1.AppendText("Upgrade - DONE" + " " + vbNewLine)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
    End Sub
End Class
