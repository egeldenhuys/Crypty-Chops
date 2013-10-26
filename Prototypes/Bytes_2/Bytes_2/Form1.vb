Imports System.IO
Imports System.Text
Imports System.Diagnostics


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click

        ' Show the open File Dialog
        OpenFileDialog1.ShowDialog()

        
        ' Create a stopwatch for timing
        Dim stopWatch As New Stopwatch
        Dim ts As TimeSpan

        stopWatch.Start()

        ' Get the Chosen File name
        Dim path As String = OpenFileDialog1.FileName

        ' Get the bytes of the file
        cWriteLine("Getting bytes of file " & OpenFileDialog1.FileName)


        Dim bytes() As Byte = GetBytes(path)

        cWriteLine("Fetched all bytes.")

        ' Get the elapsed time as a TimeSpan value. 
        ts = stopWatch.Elapsed

        ' Format and display the TimeSpan value. 
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        cWriteLine("Operation Time " & elapsedTime)

        ' Print the bytes to the textbox in HEX value

        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        ' Can Cause out of memory exception
        DisplayHex(bytes)

        stopWatch.Stop()

        ' Get the elapsed time as a TimeSpan value. 
        ts = stopWatch.Elapsed

        ' Format and display the TimeSpan value. 
        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        cWriteLine("Total Operation Time " & elapsedTime)
        cWriteLine("-----------")

    End Sub

    Private Function GetBytes(path As String) As Byte()

        ' Create a new file FileStream for the specified path
        Dim fsSource As New FileStream(path, FileMode.Open, FileAccess.Read)

        ' Create an array of bytes for reading into. The length is the same as the source file.
        Dim bytes(CInt(fsSource.Length)) As Byte ' Array for storing the bytes

        cWriteLine("File Size: " & fsSource.Length / 1000 & " KB")

        Dim numBytesToRead As Integer = CInt(fsSource.Length) ' How many bytes we have to read
        Dim numBytesRead As Integer = 0 ' How many bytes we have already read.

        ' Read each byte into the array
        While (numBytesToRead > 0) ' Keep reading if we still have bytes left to read.

            ' Read may return anything from 0 to numBytesToRead.
            Dim n As Integer = fsSource.Read(bytes, numBytesRead, numBytesToRead) ' Reads from numBytesRead to numBytesToRead and stores it in bytes().

            ' Break when the end of the file is reached. 
            If (n = 0) Then
                Exit While
            End If

            ' n is how many bytes has been read?

            ' Increment counters.
            numBytesRead = (numBytesRead + n)
            numBytesToRead = (numBytesToRead - n)

        End While

        ' Return the bytes of the file
        Return bytes

    End Function

    Private Function ToBin(singleByte As Byte) As String


    End Function

    Private Function ToHex(singleByte As Byte) As String

        Return Conversion.Hex(singleByte)

    End Function

    Private Function ToUnicode(bytes As Byte()) As Char()

    End Function

    Private Sub DisplayHex(bytes As Byte())

        ' Convert each byte to its HEX value and print it to the text box

        Dim formatCounter = 0 ' Counter for when to create a new line in text box
        Dim tmpHex As String = ""  ' Var for temporary storing the converted value

        Dim sBuilder As New StringBuilder ' String builder for increased performance

        cWriteLine("Converting bytes to HEX and building string...")
        For i As Integer = 0 To bytes.GetUpperBound(0)

            formatCounter += 1

            ' Convert the byte to HEX value
            tmpHex = ToHex(bytes(i))

            ' Add the HEX value to the textbox
            sBuilder.Append(tmpHex & " ")

            ' Start a new line every 16 values to make it easier to compare with HxD
            If formatCounter = 16 Then
                sBuilder.AppendLine()
                formatCounter = 0
            End If

            
        Next

        cWriteLine("Printing HEX values...")
        txtHex.Text = sBuilder.ToString
        cWriteLine("Finished.")

    End Sub

    Private Sub cWriteLine(ByVal text As String)

        txtConsole.AppendText(text & vbNewLine)

    End Sub

End Class
