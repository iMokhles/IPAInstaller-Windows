Imports System.Management
Module DeviceModule
    Public Sub Kill(ProcessesList As String())
        For Each ProcessName In ProcessesList
            Dim SubProcesses() As Process = Process.GetProcessesByName(ProcessName)
            For Each SubProcess As Process In SubProcesses
                If IsProcessRunning(SubProcess.ProcessName) = True Then
                    SubProcess.Kill()
                End If
            Next
        Next
    End Sub
    Public Function GetCMDOutput(path As String, Optional args As String = """") As String
        Dim proc As New Process
        proc.StartInfo.FileName = path
        proc.StartInfo.Arguments = args
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardInput = True
        proc.StartInfo.RedirectStandardError = True

        proc.Start()
        proc.WaitForExit()

        Dim output As String = proc.StandardOutput.ReadToEnd()
        Return output
    End Function
    Public Function IsProcessRunning(name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsUserlandConnected()
        Dim forever As Boolean = True
        Dim USBName As String = String.Empty
        Dim USBSearcher As New ManagementObjectSearcher(
                  "root\CIMV2",
                  "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Mobile Device USB Driver'")
        For Each queryObj As ManagementObject In USBSearcher.Get()
            USBName += (queryObj("Description"))
        Next
        If USBName = "Apple Mobile Device USB Driver" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsDFUConnected()
        Dim forever As Boolean = True
        Dim text1 As String = ""
        text1 = " "
        Dim searcher As New ManagementObjectSearcher(
              "root\CIMV2",
              "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
        For Each queryObj As ManagementObject In searcher.Get()

            text1 += (queryObj("Description"))
        Next
        If text1.Contains("DFU") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsRecoveryConnected()
        Dim text1 As String = ""
        text1 = " "
        Dim searcher As New ManagementObjectSearcher(
              "root\CIMV2",
              "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (iBoot) USB Driver'")
        For Each queryObj As ManagementObject In searcher.Get()

            text1 += (queryObj("Description"))
        Next
        If text1.Contains("iBoot") Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
