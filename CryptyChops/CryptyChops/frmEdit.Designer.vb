<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtnAES = New System.Windows.Forms.RadioButton()
        Me.rbtnReverse = New System.Windows.Forms.RadioButton()
        Me.rbtnNoPass = New System.Windows.Forms.RadioButton()
        Me.rbtnCrypty = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPath)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 52)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(273, 20)
        Me.txtPath.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 52)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 20)
        Me.txtName.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtnAES)
        Me.GroupBox4.Controls.Add(Me.rbtnReverse)
        Me.GroupBox4.Controls.Add(Me.rbtnNoPass)
        Me.GroupBox4.Controls.Add(Me.rbtnCrypty)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(111, 116)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Algorithm"
        '
        'rbtnAES
        '
        Me.rbtnAES.AutoSize = True
        Me.rbtnAES.Location = New System.Drawing.Point(6, 88)
        Me.rbtnAES.Name = "rbtnAES"
        Me.rbtnAES.Size = New System.Drawing.Size(46, 17)
        Me.rbtnAES.TabIndex = 5
        Me.rbtnAES.TabStop = True
        Me.rbtnAES.Text = "AES"
        Me.rbtnAES.UseVisualStyleBackColor = True
        '
        'rbtnReverse
        '
        Me.rbtnReverse.AutoSize = True
        Me.rbtnReverse.Location = New System.Drawing.Point(6, 65)
        Me.rbtnReverse.Name = "rbtnReverse"
        Me.rbtnReverse.Size = New System.Drawing.Size(65, 17)
        Me.rbtnReverse.TabIndex = 4
        Me.rbtnReverse.TabStop = True
        Me.rbtnReverse.Text = "Reverse"
        Me.rbtnReverse.UseVisualStyleBackColor = True
        '
        'rbtnNoPass
        '
        Me.rbtnNoPass.AutoSize = True
        Me.rbtnNoPass.Location = New System.Drawing.Point(6, 42)
        Me.rbtnNoPass.Name = "rbtnNoPass"
        Me.rbtnNoPass.Size = New System.Drawing.Size(88, 17)
        Me.rbtnNoPass.TabIndex = 3
        Me.rbtnNoPass.TabStop = True
        Me.rbtnNoPass.Text = "No Password"
        Me.rbtnNoPass.UseVisualStyleBackColor = True
        '
        'rbtnCrypty
        '
        Me.rbtnCrypty.AutoSize = True
        Me.rbtnCrypty.Location = New System.Drawing.Point(6, 19)
        Me.rbtnCrypty.Name = "rbtnCrypty"
        Me.rbtnCrypty.Size = New System.Drawing.Size(93, 17)
        Me.rbtnCrypty.TabIndex = 2
        Me.rbtnCrypty.TabStop = True
        Me.rbtnCrypty.Text = "Crypty-Encrypt"
        Me.rbtnCrypty.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.CryptyChops.My.Resources.Resources.cross
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(8, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.CryptyChops.My.Resources.Resources.minus
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(203, 159)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(110, 24)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove from list"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.CryptyChops.My.Resources.Resources.bin
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(203, 189)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete from disk"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.CryptyChops.My.Resources.Resources.tick
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(239, 288)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 324)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEdit"
        Me.Text = "Edit File"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAES As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReverse As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNoPass As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCrypty As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
