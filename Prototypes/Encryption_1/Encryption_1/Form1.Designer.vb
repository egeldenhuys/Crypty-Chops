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
        Me.txtPathIn = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.txtPathOut = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPathIn
        '
        Me.txtPathIn.Location = New System.Drawing.Point(6, 19)
        Me.txtPathIn.Multiline = True
        Me.txtPathIn.Name = "txtPathIn"
        Me.txtPathIn.Size = New System.Drawing.Size(435, 20)
        Me.txtPathIn.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(212, 171)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(87, 23)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "Apply Algorithm"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(485, 32)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "lblStatus"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIn)
        Me.GroupBox1.Controls.Add(Me.txtPathIn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 47)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Path"
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(447, 17)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(29, 23)
        Me.btnIn.TabIndex = 8
        Me.btnIn.Text = "..."
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOut)
        Me.GroupBox2.Controls.Add(Me.txtPathOut)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 47)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Path"
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(447, 17)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(29, 23)
        Me.btnOut.TabIndex = 8
        Me.btnOut.Text = "..."
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'txtPathOut
        '
        Me.txtPathOut.Location = New System.Drawing.Point(6, 19)
        Me.txtPathOut.Multiline = True
        Me.txtPathOut.Name = "txtPathOut"
        Me.txtPathOut.Size = New System.Drawing.Size(435, 20)
        Me.txtPathOut.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtKey)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(487, 47)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Key"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(6, 19)
        Me.txtKey.Multiline = True
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(435, 20)
        Me.txtKey.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 231)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "Form1"
        Me.Text = "Encryption_1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPathIn As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents txtPathOut As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
