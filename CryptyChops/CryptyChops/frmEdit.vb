Public Class frmEdit

    ' TODO:
    ' Algorithms

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

        txtName.Text = cryptyFileObject.Name
        txtPath.Text = cryptyFileObject.Path

        cryptyObj = cryptyFileObject

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        cryptyObj.Path = txtPath.Text
        cryptyObj.Name = txtName.Text

    End Sub
End Class