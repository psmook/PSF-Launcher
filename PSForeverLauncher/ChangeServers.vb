Public Class ChangeServers
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Dim request As System.Net.HttpWebRequest
        Dim response As System.Net.HttpWebResponse

        request = System.Net.HttpWebRequest.Create(ManifestFile.Text.ToString)

        request.ContentType = "text/xml"
        request.ReadWriteTimeout = 5000
        request.Timeout = 5000

        response = request.GetResponse()

        response.Close()

        If response.StatusCode = 200 Then
            My.Settings.Manifest = ManifestFile.Text
            My.Settings.Save()

            Launcher.RefreshConnection()
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ChangeServers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ManifestFile.Text = My.Settings.Manifest
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        ManifestFile.Text = My.Settings.DefaultManifest
    End Sub
End Class