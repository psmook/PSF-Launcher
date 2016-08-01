Public Class Launcher
    Function GetCurrentPath()
        Dim CurrentPath As String

        CurrentPath = System.IO.Directory.GetCurrentDirectory
        CurrentPath = System.Uri.UnescapeDataString(CurrentPath)
        CurrentPath = System.IO.Path.GetFullPath(CurrentPath)

        Return CurrentPath
    End Function

    Function DownloadManifestXML(ByVal url As String) As XDocument
        Dim request As System.Net.HttpWebRequest
        Dim response As System.Net.HttpWebResponse
        Dim manifest As XDocument

        request = System.Net.HttpWebRequest.Create(url)
        response = request.GetResponse()

        If response.StatusCode = 200 Then
            ' Download the manifest from the URL
            manifest = XDocument.Load(url)

            Return manifest
        End If

    End Function

    Public Sub RefreshConnection()
        Dim Manifest As XDocument

        Manifest = DownloadManifestXML(My.Settings.Manifest)

        For Each network In Manifest.Descendants("network")
            Dim ServerName As String

            ServerName = network.Attribute("name").Value

            ConnectedServerLabel.Text = ServerName

            My.Settings.AccountURL = network.Attribute("url").Value
        Next

        SetPatchNotes(Manifest)

        UpdateClientIni(Manifest)
    End Sub

    Private Sub SetPatchNotes(ByVal manifest As XDocument)
        PatchNotes.Text = ""

        For Each node In manifest.Descendants("patch")
            Dim version As String

            version = node.<version>.Value

            PatchNotes.Text &= "Version: " & version & Environment.NewLine

            For Each change In node.Descendants("change")
                Dim dateValue As String
                Dim changeValue As String

                dateValue = change.Attribute("date").Value
                changeValue = change.Value.Trim()

                PatchNotes.Text &= " - " & dateValue & ": " & changeValue & Environment.NewLine
            Next

            PatchNotes.Text &= Environment.NewLine
        Next
    End Sub

    Private Sub UpdateClientIni(ByVal manifest As XDocument)
        Dim Path As String
        Dim File As String

        Path = GetCurrentPath()
        File = Path & "\client.ini"

        If Not System.IO.File.Exists(File) Then
            If (MessageBox.Show("The Launcher is not currently in the PSForever directory.")) Then
                Me.Close()
            End If
        Else
            System.IO.File.Copy(File, File & ".bak", True)

            Using StrWriter As New System.IO.StreamWriter(File, False)
                StrWriter.WriteLine("[network]" & Environment.NewLine)

                For Each node In manifest.Descendants("server")
                    Dim Address As String

                    Address = node.<address>.Value & ":" & node.<port>.Value

                    StrWriter.WriteLine("# " & node.Attribute("namespace").Value & Environment.NewLine)
                    StrWriter.WriteLine(node.Attribute("id").Value & "=" & Address & Environment.NewLine)
                Next

            End Using
        End If

        PlayButton.Enabled = True
    End Sub

    Private Sub RunGame()
        Dim Path As String
        Dim File As String
        Dim App As System.Diagnostics.Process

        Path = GetCurrentPath()
        File = Path & "\planetside.exe"

        If Not System.IO.File.Exists(File) Then
            If (MessageBox.Show("The Launcher is not currently in the PSForever directory.")) Then
                Me.Close()
            End If
        Else
            App = New System.Diagnostics.Process

            App.StartInfo.FileName = File
            App.StartInfo.Arguments = "/K:StagingTest"

            App.Start()

            Me.Close()
        End If
    End Sub

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        RunGame()
    End Sub

    Private Sub Launcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshConnection()
    End Sub

    Private Sub ChangeServerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeServerButton.Click
        Dim ChangeServers As ChangeServers

        ChangeServers = New ChangeServers()

        ChangeServers.Show()
    End Sub

    Private Sub RefreshServerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshServerButton.Click
        RefreshConnection()
    End Sub

    Private Sub AccountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountButton.Click
        Process.Start(My.Settings.AccountURL)
    End Sub
End Class
