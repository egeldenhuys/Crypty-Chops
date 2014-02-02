Public Class FormMain

    Dim algorithm As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Shared Sub ConsoleWrite(ByVal text As String)
        FormMain.TextBoxConsole.AppendText(text & vbCrLf)

    End Sub

    Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click
        OpenFileDialog1.ShowDialog()

        TextBoxPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub ButtonEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEncrypt.Click
        TextBoxConsole.Clear()

        ' Get properties
        Dim path As String = TextBoxPath.Text
        Dim password As String = TextBoxKey.Text
        Dim compress As Boolean = CheckBoxCompress.Checked


        ' Create a new CryptyFile
        Dim myFile As New CryptyFile()
        myFile.path = path
        myFile.password = password
        myFile.algorithm = algorithm
        myFile.compress = compress

        ConsoleWrite("CryptyFile object has been created.")

        ConsoleWrite("Starting encryption process...")
        myFile.Encrypt()

    End Sub

    Private Sub RadioButtonNoPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonReverse.CheckedChanged, _
        RadioButtonNoPass.CheckedChanged, RadioButtonCrypty.CheckedChanged, RadioButtonAes.CheckedChanged

        Dim rbtn As RadioButton = sender

        If rbtn.Checked = True Then
            algorithm = rbtn.Text
        End If


    End Sub
End Class
