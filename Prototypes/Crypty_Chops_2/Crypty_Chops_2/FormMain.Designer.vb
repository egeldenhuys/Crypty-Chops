<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonEncrypt = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCompress = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNoPass = New System.Windows.Forms.RadioButton()
        Me.RadioButtonReverse = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAes = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCrypty = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxKey = New System.Windows.Forms.TextBox()
        Me.TextBoxConsole = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxPath.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBrowse)
        Me.GroupBox1.Controls.Add(Me.TextBoxPath)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 53)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Path"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(306, 17)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(31, 23)
        Me.ButtonBrowse.TabIndex = 1
        Me.ButtonBrowse.Text = "..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonEncrypt)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 337)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encrypt File"
        '
        'ButtonEncrypt
        '
        Me.ButtonEncrypt.Location = New System.Drawing.Point(135, 308)
        Me.ButtonEncrypt.Name = "ButtonEncrypt"
        Me.ButtonEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEncrypt.TabIndex = 6
        Me.ButtonEncrypt.Text = "Encrypt"
        Me.ButtonEncrypt.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBoxCompress)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 253)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(343, 45)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Options"
        '
        'CheckBoxCompress
        '
        Me.CheckBoxCompress.AutoSize = True
        Me.CheckBoxCompress.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxCompress.Name = "CheckBoxCompress"
        Me.CheckBoxCompress.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxCompress.TabIndex = 4
        Me.CheckBoxCompress.Text = "Compress"
        Me.CheckBoxCompress.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButtonNoPass)
        Me.GroupBox4.Controls.Add(Me.RadioButtonReverse)
        Me.GroupBox4.Controls.Add(Me.RadioButtonAes)
        Me.GroupBox4.Controls.Add(Me.RadioButtonCrypty)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 110)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Algorithm"
        '
        'RadioButtonNoPass
        '
        Me.RadioButtonNoPass.AutoSize = True
        Me.RadioButtonNoPass.Location = New System.Drawing.Point(6, 88)
        Me.RadioButtonNoPass.Name = "RadioButtonNoPass"
        Me.RadioButtonNoPass.Size = New System.Drawing.Size(88, 17)
        Me.RadioButtonNoPass.TabIndex = 6
        Me.RadioButtonNoPass.TabStop = True
        Me.RadioButtonNoPass.Text = "No Password"
        Me.RadioButtonNoPass.UseVisualStyleBackColor = True
        '
        'RadioButtonReverse
        '
        Me.RadioButtonReverse.AutoSize = True
        Me.RadioButtonReverse.Location = New System.Drawing.Point(6, 65)
        Me.RadioButtonReverse.Name = "RadioButtonReverse"
        Me.RadioButtonReverse.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonReverse.TabIndex = 5
        Me.RadioButtonReverse.TabStop = True
        Me.RadioButtonReverse.Text = "Reverse"
        Me.RadioButtonReverse.UseVisualStyleBackColor = True
        '
        'RadioButtonAes
        '
        Me.RadioButtonAes.AutoSize = True
        Me.RadioButtonAes.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonAes.Name = "RadioButtonAes"
        Me.RadioButtonAes.Size = New System.Drawing.Size(46, 17)
        Me.RadioButtonAes.TabIndex = 4
        Me.RadioButtonAes.TabStop = True
        Me.RadioButtonAes.Text = "AES"
        Me.RadioButtonAes.UseVisualStyleBackColor = True
        '
        'RadioButtonCrypty
        '
        Me.RadioButtonCrypty.AutoSize = True
        Me.RadioButtonCrypty.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonCrypty.Name = "RadioButtonCrypty"
        Me.RadioButtonCrypty.Size = New System.Drawing.Size(93, 17)
        Me.RadioButtonCrypty.TabIndex = 3
        Me.RadioButtonCrypty.TabStop = True
        Me.RadioButtonCrypty.Text = "Crypty-Encrypt"
        Me.RadioButtonCrypty.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxKey)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 53)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Key"
        '
        'TextBoxKey
        '
        Me.TextBoxKey.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxKey.Name = "TextBoxKey"
        Me.TextBoxKey.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxKey.TabIndex = 0
        '
        'TextBoxConsole
        '
        Me.TextBoxConsole.BackColor = System.Drawing.Color.Black
        Me.TextBoxConsole.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxConsole.Location = New System.Drawing.Point(12, 367)
        Me.TextBoxConsole.Multiline = True
        Me.TextBoxConsole.Name = "TextBoxConsole"
        Me.TextBoxConsole.ReadOnly = True
        Me.TextBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxConsole.Size = New System.Drawing.Size(614, 194)
        Me.TextBoxConsole.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 573)
        Me.Controls.Add(Me.TextBoxConsole)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormMain"
        Me.Text = "Crypty_Chops_2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonEncrypt As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxCompress As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonNoPass As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonReverse As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAes As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCrypty As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxKey As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConsole As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
