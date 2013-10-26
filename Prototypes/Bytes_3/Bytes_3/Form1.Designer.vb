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
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBin = New System.Windows.Forms.TextBox()
        Me.txtBuffer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtConsole.Location = New System.Drawing.Point(363, 322)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(645, 165)
        Me.txtConsole.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 55)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(6, 19)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(839, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Unicode"
        '
        'txtUni
        '
        Me.txtUni.Location = New System.Drawing.Point(717, 31)
        Me.txtUni.Multiline = True
        Me.txtUni.Name = "txtUni"
        Me.txtUni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUni.Size = New System.Drawing.Size(291, 285)
        Me.txtUni.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(494, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "HEX"
        '
        'txtHex
        '
        Me.txtHex.Location = New System.Drawing.Point(363, 31)
        Me.txtHex.Multiline = True
        Me.txtHex.Name = "txtHex"
        Me.txtHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHex.Size = New System.Drawing.Size(291, 285)
        Me.txtHex.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BIN"
        '
        'txtBin
        '
        Me.txtBin.Location = New System.Drawing.Point(9, 31)
        Me.txtBin.Multiline = True
        Me.txtBin.Name = "txtBin"
        Me.txtBin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBin.Size = New System.Drawing.Size(291, 285)
        Me.txtBin.TabIndex = 9
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(108, 454)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(126, 20)
        Me.txtBuffer.TabIndex = 17
        Me.txtBuffer.Text = "58720256"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Buffer Size (Bytes)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 506)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBuffer)
        Me.Controls.Add(Me.txtConsole)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBin)
        Me.Name = "Form1"
        Me.Text = "Bytes_3"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBin As System.Windows.Forms.TextBox
    Friend WithEvents txtBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
