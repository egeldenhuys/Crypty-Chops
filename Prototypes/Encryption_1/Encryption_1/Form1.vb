Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        Dim cryptyObj As New CryptyEncrypt

        lblStatus.Text = "Encrypting"

        cryptyObj.ApplyAlgorithm(txtPathIn.Text, txtPathOut.Text, txtKey.Text)

        lblStatus.Text = "Done"

    End Sub

    Private Sub btnIn_Click(sender As System.Object, e As System.EventArgs) Handles btnIn.Click
        OpenFileDialog1.ShowDialog()

        txtPathIn.Text = OpenFileDialog1.FileName
        txtPathOut.Text = txtPathIn.Text & "_Encrypted"

    End Sub
End Class
