﻿Imports System.IO

Public Class frmMain
    ' This is the main form of the program
    ' It is where all functions are initiated from

    ' TODO:
    ' Help

    Public cryptyListObj As CryptyList

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.CryptyChops__2_

            ' We need to do pass the ListView object in the load function
            ' as it is not initialized before this.
            cryptyListObj = New CryptyList(lstFiles)

            FileBtnsVisible(False)


            cryptyListObj.LoadList()
        Catch ex As Exception

            'MsgBox(ex.Message)
        End Try


        Try
            If Directory.Exists(CurDir() & "\7za920") Then ' If the compression folder hasn't been moved
                If (Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypt-Chops")) Then ' If there's no Crypty-Chops folder in the roaming folder
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops\Compression") ' Create the Crypty-Chops folder
                    Directory.Move(CurDir() & "\7za920", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Crypty-Chops\Compression")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try


    End Sub

    
#Region "Functions"

    ''' <summary>
    ''' Encrypt the selected file, opens a new form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EncryptFile()

        HideButtons()
        Try
            Dim _frmEncrypt As New frmEncrypt
            SetupForm(_frmEncrypt)

            ' Get all the selected items
            Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

            Dim cryptyObj As CryptyFile = cryptyListObj.GetObjByName(selItems.Item(0).Name)

            _frmEncrypt.EncryptFile(cryptyObj)
        Catch ex As Exception

        End Try



    End Sub

    ''' <summary>
    ''' Edit the selected file, opens a new form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EditFile()
        HideButtons()

        Dim _frmEdit As New frmEdit
        SetupForm(_frmEdit)

        ' Get the name of the selected item
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        ' open edit file dialog so user can edit the properties easily.
        _frmEdit.EditCryptyFile(cryptyListObj.GetObjByName(selItems.Item(0).Name))

    End Sub

    ''' <summary>
    ''' Open the location of the selected file
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenLocation()
        ' Get all selected items
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        ' Open the folder of each selected item
        For i As Integer = 0 To selItems.Count - 1

            ' Get file info
            Dim tmpFileInfo As New FileInfo(selItems(i).SubItems(4).Text)

            ' Pass the Directory path of the file to explorer
            Process.Start("explorer.exe", tmpFileInfo.DirectoryName)

        Next

    End Sub

    '' Delete the selected file, opens a new form
    Public Sub DeleteFile()
        HideButtons()

        Dim _frmDelConfirm As New frmDelConfirm
        SetupForm(_frmDelConfirm)

        ' Get the name of the selected item
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        Try
            _frmDelConfirm.DeleteFile(cryptyListObj.GetObjByName(selItems(0).Name))
        Catch ex As Exception

        End Try


    End Sub

    ''' <summary>
    ''' Remove the selcted file
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub RemoveFile()
        ' Get the name of the selected item
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        ' Remove all selected items
        For i As Integer = 0 To selItems.Count - 1
            cryptyListObj.Remove(selItems(i).Name)
        Next

    End Sub

    ''' <summary>
    ''' Decrypt the slected file, opens a new form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DecryptFile()
        HideButtons()

        Dim _frmDecrypt As New frmDecrypt
        SetupForm(_frmDecrypt)

        ' Get all the selected items
        Dim selItems As New ListView.SelectedListViewItemCollection(lstFiles)

        Try
            Dim cryptyObj As CryptyFile = cryptyListObj.GetObjByName(selItems.Item(0).Name)

            _frmDecrypt.DecryptFile(cryptyObj)
        Catch ex As Exception
            MsgBox("Couldn't do that")
        End Try


    End Sub

    ''' <summary>
    ''' Add a new file to the list, opens a new form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddFile()

        ' This is needed otherwise the previous path is passed even if they press cancel
        OpenFileDialog1.FileName = ""

        ' Collect the path
        OpenFileDialog1.ShowDialog()

        Dim path As String = OpenFileDialog1.FileName

        'If the user does not select a file do not display the next window
        If path <> "" Then
            Dim tmpFileInfo As New FileInfo(path)

            'Test permissions

            Try
                Dim fs As New FileStream(path, FileMode.Open)
                fs.Close()

            ' Create a new CryptyFile based on the given path
            Dim tmpItem As New CryptyFile(tmpFileInfo.FullName)

            tmpItem.Name = tmpFileInfo.Name
                cryptyListObj.Add(tmpItem)
            Catch ex As Exception
                MsgBox("You need to run Crypty Chops as a administrator to encrypt that file")
            End Try
        End If

    End Sub
#End Region

#Region "Button Events"

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EditFile()

    End Sub

    Private Sub btnOpenLoc_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenLoc.Click

        OpenLocation()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        DeleteFile()

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        RemoveFile()

    End Sub

    Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click

        DecryptFile()


    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        AddFile()

    End Sub

    Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click

        EncryptFile()

    End Sub

#End Region

#Region "Context Menu Events"

    Private Sub EncryptToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EncryptToolStripMenuItem1.Click
        EncryptFile()

    End Sub

    Private Sub DecryptToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DecryptToolStripMenuItem1.Click
        DecryptFile()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        AddFile()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        EditFile()
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RemoveToolStripMenuItem1.Click
        RemoveFile()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteFile()
    End Sub

#End Region

#Region "Menu Strip Events"
    Private Sub EncryptToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EncryptToolStripMenuItem.Click
        EncryptFile()

    End Sub

    Private Sub DecryptToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DecryptToolStripMenuItem.Click
        DecryptFile()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripMenuItem.Click
        AddFile()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        EditFile()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveFile()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteFile()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click

        ' TODO:
        ' Help
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

#End Region

#Region "Form Modifiers"
    ''' <summary>
    ''' Set form properties and add it to the panel, ready to be displayed
    ''' </summary>
    ''' <param name="tmpForm">The form to prepare for the panel</param>
    ''' <remarks></remarks>
    Public Sub SetupForm(tmpForm As Form)

        tmpForm.TopLevel = False

        ' We do not want a border, it should look like it is part of the main form.
        tmpForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        ' After we have added it we can use .show() and it will appear in the panel
        panelForms.Controls.Add(tmpForm)

    End Sub

    ''' <summary>
    ''' Hide the control buttons in the panelForms
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub HideButtons()
        panelButtons.Visible = False
    End Sub

    ''' <summary>
    ''' Show the control buttons in the panelForms
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowButtons()
        panelButtons.Visible = True
    End Sub

#End Region

    Private Sub lstFiles_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstFiles.SelectedIndexChanged

        ' Show buttons only when a file is selected

        If lstFiles.SelectedIndices.Count = 0 Then
            FileBtnsVisible(False)
        Else
            FileBtnsVisible(True)
        End If

    End Sub

    ''' <summary>
    ''' Set the visibility of the file manuipulation buttons
    ''' </summary>
    ''' <param name="value">True/False</param>
    ''' <remarks></remarks>
    Private Sub FileBtnsVisible(value As Boolean)

        btnEdit.Visible = value
        btnEncrypt.Visible = value
        btnDecrypt.Visible = value
        btnRemove.Visible = value
        btnDelete.Visible = value
        btnOpenLoc.Visible = value

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        cryptyListObj.SaveList()

    End Sub

End Class
