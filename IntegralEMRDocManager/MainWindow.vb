Public Class MainWindow
    Dim mDirMgr As New DirectoryManager("E:\MedVocab\MSA01092012002")
    Dim mOEMRServer As String = "http://ubuntu/openemr"

    Private Sub MainWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mDirMgr.PopulateGrid(dgFileStatuses)
        wbOpenEMRSession.Navigate(mOEMRServer)

    End Sub
End Class
