Public Class frmMain

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click


        OpenFileDialog1.ShowDialog()

        Dim path As String = OpenFileDialog1.FileName

        frmAdd.ShowFileInfo(path)

    End Sub

End Class
