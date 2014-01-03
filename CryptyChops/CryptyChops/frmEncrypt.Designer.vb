<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncrypt
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
        Me.rbtnNoPass = New System.Windows.Forms.RadioButton()
        Me.rbtnReverse = New System.Windows.Forms.RadioButton()
        Me.rbtnAes = New System.Windows.Forms.RadioButton()
        Me.rbtnCrypty = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbFile = New System.Windows.Forms.CheckBox()
        Me.grpFilepath = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.chkCompress = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpFilepath.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnNoPass)
        Me.GroupBox1.Controls.Add(Me.rbtnReverse)
        Me.GroupBox1.Controls.Add(Me.rbtnAes)
        Me.GroupBox1.Controls.Add(Me.rbtnCrypty)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algorithm"
        '
        'rbtnNoPass
        '
        Me.rbtnNoPass.AutoSize = True
        Me.rbtnNoPass.Location = New System.Drawing.Point(6, 88)
        Me.rbtnNoPass.Name = "rbtnNoPass"
        Me.rbtnNoPass.Size = New System.Drawing.Size(88, 17)
        Me.rbtnNoPass.TabIndex = 3
        Me.rbtnNoPass.TabStop = True
        Me.rbtnNoPass.Text = "No Password"
        Me.rbtnNoPass.UseVisualStyleBackColor = True
        '
        'rbtnReverse
        '
        Me.rbtnReverse.AutoSize = True
        Me.rbtnReverse.Location = New System.Drawing.Point(6, 65)
        Me.rbtnReverse.Name = "rbtnReverse"
        Me.rbtnReverse.Size = New System.Drawing.Size(65, 17)
        Me.rbtnReverse.TabIndex = 2
        Me.rbtnReverse.TabStop = True
        Me.rbtnReverse.Text = "Reverse"
        Me.rbtnReverse.UseVisualStyleBackColor = True
        '
        'rbtnAes
        '
        Me.rbtnAes.AutoSize = True
        Me.rbtnAes.Location = New System.Drawing.Point(6, 42)
        Me.rbtnAes.Name = "rbtnAes"
        Me.rbtnAes.Size = New System.Drawing.Size(46, 17)
        Me.rbtnAes.TabIndex = 1
        Me.rbtnAes.TabStop = True
        Me.rbtnAes.Text = "AES"
        Me.rbtnAes.UseVisualStyleBackColor = True
        '
        'rbtnCrypty
        '
        Me.rbtnCrypty.AutoSize = True
        Me.rbtnCrypty.Location = New System.Drawing.Point(6, 19)
        Me.rbtnCrypty.Name = "rbtnCrypty"
        Me.rbtnCrypty.Size = New System.Drawing.Size(93, 17)
        Me.rbtnCrypty.TabIndex = 0
        Me.rbtnCrypty.TabStop = True
        Me.rbtnCrypty.Text = "Crypty Encrypt"
        Me.rbtnCrypty.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbFile)
        Me.GroupBox2.Controls.Add(Me.grpFilepath)
        Me.GroupBox2.Controls.Add(Me.txtPass)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Password"
        '
        'chbFile
        '
        Me.chbFile.AutoSize = True
        Me.chbFile.Location = New System.Drawing.Point(6, 56)
        Me.chbFile.Name = "chbFile"
        Me.chbFile.Size = New System.Drawing.Size(127, 17)
        Me.chbFile.TabIndex = 3
        Me.chbFile.Text = "Use File as Password"
        Me.chbFile.UseVisualStyleBackColor = True
        '
        'grpFilepath
        '
        Me.grpFilepath.Controls.Add(Me.btnBrowse)
        Me.grpFilepath.Controls.Add(Me.txtPath)
        Me.grpFilepath.Enabled = False
        Me.grpFilepath.Location = New System.Drawing.Point(6, 79)
        Me.grpFilepath.Name = "grpFilepath"
        Me.grpFilepath.Size = New System.Drawing.Size(269, 51)
        Me.grpFilepath.TabIndex = 4
        Me.grpFilepath.TabStop = False
        Me.grpFilepath.Text = "File path"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(237, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(26, 24)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(6, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(225, 20)
        Me.txtPath.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(6, 19)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(263, 20)
        Me.txtPass.TabIndex = 0
        '
        'chkCompress
        '
        Me.chkCompress.AutoSize = True
        Me.chkCompress.Location = New System.Drawing.Point(6, 19)
        Me.chkCompress.Name = "chkCompress"
        Me.chkCompress.Size = New System.Drawing.Size(72, 17)
        Me.chkCompress.TabIndex = 2
        Me.chkCompress.Text = "Compress"
        Me.chkCompress.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCompress)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 41)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Options"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Image = Global.CryptyChops.My.Resources.Resources.lock
        Me.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncrypt.Location = New System.Drawing.Point(8, 241)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 24)
        Me.btnEncrypt.TabIndex = 5
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.CryptyChops.My.Resources.Resources.cross
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(362, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEncrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 277)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEncrypt"
        Me.Text = "Encrypt File"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpFilepath.ResumeLayout(False)
        Me.grpFilepath.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnNoPass As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReverse As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCrypty As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents chbFile As System.Windows.Forms.CheckBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents chkCompress As System.Windows.Forms.CheckBox
    Friend WithEvents grpFilepath As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
