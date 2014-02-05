Public Class frmEdit
    ' This form will be used to edit the properties of the CryptyFile

    ' TODO:
    ' Implement Remove and Delete

    Dim cryptyObj As CryptyFile

    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub this_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmMain.ShowButtons()

    End Sub

    ''' <summary>
    ''' Entry point for this form
    ''' </summary>
    ''' <param name="cryptyFileObject">The cryptyFile to edit</param>
    ''' <remarks></remarks>
    Public Sub EditCryptyFile(cryptyFileObject As CryptyFile)
        Me.Show()

        ' Save the object for later use
        cryptyObj = cryptyFileObject

        ' Display the file details for the user
        txtName.Text = cryptyObj.Name
        txtPath.Text = cryptyObj.Path

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        ' Update the object properties
        Dim index As Integer = frmMain.cryptyListObj.GetIndex(cryptyObj.Name)

        If My.Computer.FileSystem.FileExists(txtPath.Text) Then


            cryptyObj.Path = txtPath.Text
            cryptyObj.Name = txtName.Text

            frmMain.cryptyListObj.FileList.Item(index).Path = cryptyObj.Path

            frmMain.cryptyListObj.FileList.Item(index).Name = cryptyObj.Name

            frmMain.cryptyListObj.Refresh()

            Me.Close()

        Else
            MsgBox("File does not exist")
        End If


    End Sub
End Class