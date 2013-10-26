<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.btnGenerateIndexes = New System.Windows.Forms.Button()
        Me.txtReverseIndexes = New System.Windows.Forms.TextBox()
        Me.btnEncryptFile = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnDecryptFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(13, 13)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(259, 39)
        Me.btnLoadFile.TabIndex = 0
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'btnGenerateIndexes
        '
        Me.btnGenerateIndexes.Location = New System.Drawing.Point(13, 77)
        Me.btnGenerateIndexes.Name = "btnGenerateIndexes"
        Me.btnGenerateIndexes.Size = New System.Drawing.Size(259, 39)
        Me.btnGenerateIndexes.TabIndex = 1
        Me.btnGenerateIndexes.Text = "Generate Reverse Indexes"
        Me.btnGenerateIndexes.UseVisualStyleBackColor = True
        '
        'txtReverseIndexes
        '
        Me.txtReverseIndexes.Location = New System.Drawing.Point(13, 122)
        Me.txtReverseIndexes.Multiline = True
        Me.txtReverseIndexes.Name = "txtReverseIndexes"
        Me.txtReverseIndexes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReverseIndexes.Size = New System.Drawing.Size(259, 89)
        Me.txtReverseIndexes.TabIndex = 2
        '
        'btnEncryptFile
        '
        Me.btnEncryptFile.Location = New System.Drawing.Point(13, 217)
        Me.btnEncryptFile.Name = "btnEncryptFile"
        Me.btnEncryptFile.Size = New System.Drawing.Size(259, 39)
        Me.btnEncryptFile.TabIndex = 3
        Me.btnEncryptFile.Text = "Encrypt File"
        Me.btnEncryptFile.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.Filter = "Text Files | *.txt"
        Me.ofd.Title = "Select file to reverse"
        '
        'btnDecryptFile
        '
        Me.btnDecryptFile.Location = New System.Drawing.Point(13, 262)
        Me.btnDecryptFile.Name = "btnDecryptFile"
        Me.btnDecryptFile.Size = New System.Drawing.Size(259, 39)
        Me.btnDecryptFile.TabIndex = 4
        Me.btnDecryptFile.Text = "Decrypt File"
        Me.btnDecryptFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.btnDecryptFile)
        Me.Controls.Add(Me.btnEncryptFile)
        Me.Controls.Add(Me.txtReverseIndexes)
        Me.Controls.Add(Me.btnGenerateIndexes)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Name = "Form1"
        Me.Text = "Reverse Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents btnGenerateIndexes As System.Windows.Forms.Button
    Friend WithEvents txtReverseIndexes As System.Windows.Forms.TextBox
    Friend WithEvents btnEncryptFile As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDecryptFile As System.Windows.Forms.Button

End Class
