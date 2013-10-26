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
        Me.btnBytes = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtBytes = New System.Windows.Forms.TextBox()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBytes
        '
        Me.btnBytes.Location = New System.Drawing.Point(444, 293)
        Me.btnBytes.Name = "btnBytes"
        Me.btnBytes.Size = New System.Drawing.Size(75, 23)
        Me.btnBytes.TabIndex = 11
        Me.btnBytes.Text = "To bytes"
        Me.btnBytes.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(151, 293)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 10
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(102, 345)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(170, 20)
        Me.txtKey.TabIndex = 9
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(70, 293)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Encrypt"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtBytes
        '
        Me.txtBytes.Location = New System.Drawing.Point(222, 12)
        Me.txtBytes.Multiline = True
        Me.txtBytes.Name = "txtBytes"
        Me.txtBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBytes.Size = New System.Drawing.Size(521, 275)
        Me.txtBytes.TabIndex = 7
        '
        'txtRaw
        '
        Me.txtRaw.Location = New System.Drawing.Point(13, 12)
        Me.txtRaw.Multiline = True
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRaw.Size = New System.Drawing.Size(203, 275)
        Me.txtRaw.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Key"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBytes)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtBytes)
        Me.Controls.Add(Me.txtRaw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBytes As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents txtBytes As System.Windows.Forms.TextBox
    Friend WithEvents txtRaw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
