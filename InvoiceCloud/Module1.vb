Imports System
Imports System.IO

Module Module1
    Sub Main()
        Try
            Dim line As String
            ' This reads the files
            For Each line In File.ReadAllLines("/Users/nathanael/Google Drive (nathanaelcarr01@gmail.com)/RiderPrograms/InvoiceCloud_VBnetProject/ICTest.txt")
                ' This splits the lines at ','
                Dim sentence As String() = line.Split(CChar(vbCrLf))
                Dim sentences As String
                ' This sends the string formatted
                For Each sentences In sentence
                    Dim sentences1 As String = sentences.Replace("," , " | ")
                    Console.WriteLine(sentences1)
                    ' This writes to the file
                    Using writer As New StreamWriter("/Users/nathanael/Google Drive (nathanaelcarr01@gmail.com)/RiderPrograms/InvoiceCloud_VBnetProject/ICTestOutput.txt", True)
                        writer.WriteLine(sentences1)
                    End Using
                Next
            Next
            ' This is just in case something went wrong
            Catch e As Exception
                Console.WriteLine("This file could not be read")
                Console.WriteLine(e.Message)
        End Try
    End Sub
End Module


'ICTest.txt