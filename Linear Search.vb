Module Module1

    Sub Main()

        Dim Number(8) As String
        Dim i As Integer = 0
        Dim IsFound As Boolean = False
        Dim X As String = ""
        Dim Y As String = ""

        For i = 1 To 8
            Console.Write("Enter Values For An Array: ")
            X = Console.ReadLine
            Number(i) = X
        Next

        Console.Write("Enter The Value You Want To Look For: ")
        Y = Console.ReadLine

        For i = 1 To 8
            If Number(i) = Y Then
                IsFound = True
                Exit For
            End If
        Next

    

        If IsFound = True Then
            Console.WriteLine("Found At " & i)
        ElseIf IsFound = False Then
            Console.WriteLine("Not Found")
        End If

        Console.ReadKey()

    End Sub

End Module
