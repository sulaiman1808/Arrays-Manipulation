Module Module1

    Sub Main()
        Dim Number(8) As Integer
        Dim I As Integer = 0
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim X As Integer = 0

        For I = 1 To 8
            Console.Write("Enter Values For An Array: ")
            a = Console.ReadLine
            Number(I) = a

        Next

        For C = 7 To 1 Step -1
            For I = 1 To C
                If Number(I) > Number(I + 1) Then
                    X = Number(I)
                    Number(I) = Number(I + 1)
                    Number(I + 1) = X

                End If
            Next
        Next
        Console.WriteLine("The Array's Values Rearranged In Ascending Order Are: ")
        For I = 1 To 8
            b = Number(I)
            Console.WriteLine(b)
        Next
        Console.ReadKey()

    End Sub

End Module
