Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Encrypt_File.Show()
    End Sub

    Private Sub EncryptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptToolStripMenuItem.Click
        Encrypt_File.Show()
    End Sub

    Private Sub EncryptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptToolStripMenuItem1.Click
        Encrypt_File.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Decrypt_File.Show()
    End Sub

    Private Sub DecryptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptToolStripMenuItem.Click
        Decrypt_File.Show()
    End Sub

    Private Sub DecryptToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptToolStripMenuItem1.Click
        Decrypt_File.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Key Preview must be set to true in the forms properties otherwise this code won't work.

        If e.KeyCode = Keys.E Then

            Encrypt_File.Show()

        End If

        If e.KeyCode = Keys.D Then

            Decrypt_File.Show()

        End If

    End Sub
End Class
