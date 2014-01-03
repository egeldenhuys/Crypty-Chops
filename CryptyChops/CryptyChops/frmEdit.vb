Public Class frmEdit

    ' TODO:
    ' Implement Remove and Delete
    ' Algorithms

    Private Sub this_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.ShowButtons()
    End Sub

    Dim cryptyObj As CryptyFile

    ' This form will be used to edit the properties of the CryptyFile
    Private Sub frmEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Entry point for this form
    ''' </summary>
    ''' <param name="cryptyFileObject"></param>
    ''' <remarks></remarks>
    Public Sub EditCryptyFile(cryptyFileObject As CryptyFile)
        Me.Show()

        cryptyObj = cryptyFileObject

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
        Dim index As Integer = frmMain.cryptyListObj.GetIndex(cryptyObj.Name)

        cryptyObj.Path = txtPath.Text
        cryptyObj.Name = txtName.Text

        frmMain.cryptyListObj.FileList.Item(index).Path = txtPath.Text
        frmMain.cryptyListObj.FileList.Item(index).Name = txtName.Text

        frmMain.cryptyListObj.Refresh()

        Me.Close()

    End Sub
End Class