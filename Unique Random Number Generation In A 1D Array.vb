Module Module1

    Sub Main()

        Dim NoArr(10) As Integer
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim C As Integer = 0
        Dim D As Integer = 0
        Dim AlreadyFound As Boolean = False

        Randomize()


        For A = 1 To 10
            NoArr(A) = 0
        Next

        For A = 1 To 10
            Do
                C = C + 1
                AlreadyFound = False
                B = Int(Rnd() * 20) + 1
                For D = A To 1 Step -1
                    If NoArr(D) = B Then AlreadyFound = True
                Next
            Loop Until AlreadyFound = False
            NoArr(A) = B
        Next

        For A = 1 To 10
            Console.WriteLine(NoArr(A))
        Next

        Console.WriteLine("LOOP WORKED FOR " & C & " TIMES")
        Console.ReadKey()
    End Sub

End Module
