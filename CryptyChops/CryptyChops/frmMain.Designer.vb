<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lstFiles = New System.Windows.Forms.ListView()
        Me.StatusColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateModifiedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EncryptToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifiyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnOpenLoc = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DecryptToolStripMenuItem
        '
        Me.DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem"
        Me.DecryptToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DecryptToolStripMenuItem.Text = "Decrypt"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.DeleteToolStripMenuItem1})
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EncryptToolStripMenuItem
        '
        Me.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem"
        Me.EncryptToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EncryptToolStripMenuItem.Text = "Encrypt"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptToolStripMenuItem, Me.DecryptToolStripMenuItem, Me.AddToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'FileNameColumn
        '
        Me.FileNameColumn.Text = "File Name"
        Me.FileNameColumn.Width = 199
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lstFiles
        '
        Me.lstFiles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileNameColumn, Me.StatusColumn, Me.SizeColumn, Me.DateModifiedColumn, Me.PathColumn})
        Me.lstFiles.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstFiles.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstFiles.FullRowSelect = True
        Me.lstFiles.GridLines = True
        Me.lstFiles.Location = New System.Drawing.Point(0, 24)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(738, 318)
        Me.lstFiles.TabIndex = 12
        Me.lstFiles.UseCompatibleStateImageBehavior = False
        Me.lstFiles.View = System.Windows.Forms.View.Details
        '
        'StatusColumn
        '
        Me.StatusColumn.Text = "Status"
        '
        'SizeColumn
        '
        Me.SizeColumn.Text = "Size"
        Me.SizeColumn.Width = 64
        '
        'DateModifiedColumn
        '
        Me.DateModifiedColumn.Text = "Date Modified"
        Me.DateModifiedColumn.Width = 207
        '
        'PathColumn
        '
        Me.PathColumn.Text = "Path"
        Me.PathColumn.Width = 203
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptToolStripMenuItem1, Me.DecryptToolStripMenuItem1, Me.AddToolStripMenuItem1, Me.ModifiyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(116, 92)
        '
        'EncryptToolStripMenuItem1
        '
        Me.EncryptToolStripMenuItem1.Name = "EncryptToolStripMenuItem1"
        Me.EncryptToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.EncryptToolStripMenuItem1.Text = "Encrypt"
        '
        'DecryptToolStripMenuItem1
        '
        Me.DecryptToolStripMenuItem1.Name = "DecryptToolStripMenuItem1"
        Me.DecryptToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.DecryptToolStripMenuItem1.Text = "Decrypt"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'ModifiyToolStripMenuItem
        '
        Me.ModifiyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.RemoveToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.ModifiyToolStripMenuItem.Name = "ModifiyToolStripMenuItem"
        Me.ModifiyToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ModifiyToolStripMenuItem.Text = "Modifiy"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(110, 18)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.ToolStripStatusLabel2, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(738, 24)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 19)
        Me.lblStatus.Text = "Status: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(43, 19)
        Me.ToolStripStatusLabel2.Text = "Ready"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Image = Global.CryptyChops.My.Resources.Resources.lock_unlock
        Me.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDecrypt.Location = New System.Drawing.Point(12, 377)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 14
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.CryptyChops.My.Resources.Resources.bin
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(174, 377)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 24)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete File"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.CryptyChops.My.Resources.Resources.plus
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(93, 348)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 24)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add File"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnOpenLoc
        '
        Me.btnOpenLoc.Image = Global.CryptyChops.My.Resources.Resources.folder_horizontal_open
        Me.btnOpenLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenLoc.Location = New System.Drawing.Point(271, 348)
        Me.btnOpenLoc.Name = "btnOpenLoc"
        Me.btnOpenLoc.Size = New System.Drawing.Size(121, 24)
        Me.btnOpenLoc.TabIndex = 8
        Me.btnOpenLoc.Text = "Open File Location"
        Me.btnOpenLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOpenLoc.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.CryptyChops.My.Resources.Resources.minus
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(174, 348)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(91, 24)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove File"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.CryptyChops.My.Resources.Resources.pencil
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(93, 377)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 24)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit File"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Image = Global.CryptyChops.My.Resources.Resources.lock
        Me.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncrypt.Location = New System.Drawing.Point(12, 348)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 24)
        Me.btnEncrypt.TabIndex = 6
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 437)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOpenLoc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Crypty Chops"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecryptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnOpenLoc As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents EncryptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileNameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lstFiles As System.Windows.Forms.ListView
    Friend WithEvents StatusColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents SizeColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateModifiedColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EncryptToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecryptToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifiyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
