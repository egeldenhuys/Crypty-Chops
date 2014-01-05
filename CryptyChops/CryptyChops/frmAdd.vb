Imports System.IO

Public Class frmAdd
    ' This form is used to add a CryptyFile to the list

    Dim tmpFileInfo As FileInfo

    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Entry point for this form. Display the information on the selected file.
    ''' </summary>
    ''' <param name="path"></param>
    ''' <remarks></remarks>
    Public Sub ShowFileInfo(ByVal path As String)
        Me.Show()

        tmpFileInfo = New FileInfo(path)

        ' Name
        lstInfo.Items(0).SubItems.Add(tmpFileInfo.Name)

        ' Path
        lstInfo.Items(1).SubItems.Add(tmpFileInfo.FullName)

        ' Size
        lstInfo.Items(2).SubItems.Add(tmpFileInfo.Length.ToString)

        ' Populate Textbox
        txtName.Text = tmpFileInfo.Name


    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

        lstInfo.Items(0).SubItems(1).Text = txtName.Text

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        ' Create a CryptyFile object to send to the encrypting form
        Dim _cryptyFile As CryptyFile = CreateCryptyFile()
        frmMain.cryptyListObj.Add(_cryptyFile)

        ' Initialize a new form
        Dim _frmEncrypt As New frmEncrypt
        frmMain.SetupForm(_frmEncrypt)

        ' Pass the CryptyFile object we have just created to the form
        _frmEncrypt.EncryptFile(_cryptyFile)

        Me.Close()

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

        ' Create a CryptyFile object to send to the Decryption form
        Dim _cryptyFile As CryptyFile = CreateCryptyFile()
        frmMain.cryptyListObj.Add(_cryptyFile)

        ' Initialize a new form
        Dim _frmDecrypt As New frmDecrypt
        frmMain.SetupForm(_frmDecrypt)

        ' Pass the CryptyFile object we have just created to the form
        _frmDecrypt.DecryptFile(_cryptyFile)

        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        ' Create a new cryptyFile and add it to the list

        frmMain.cryptyListObj.Add(CreateCryptyFile())
        frmMain.ShowButtons()
        Me.Close()

    End Sub

    Private Function CreateCryptyFile() As CryptyFile

        ' Create a new CryptyFile based on the given path
        Dim tmpItem As New CryptyFile(tmpFileInfo.FullName)

        tmpItem.Name = txtName.Text

        Return tmpItem

    End Function
End Class