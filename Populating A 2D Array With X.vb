Module Module1

    Sub Main()

        Dim Array(10, 5) As String
        Dim RowCount As Integer = 0
        Dim ColumnCount As Integer = 0
        Dim ArrayHasData As Boolean = False


        For RowCount = 1 To 10
            For ColumnCount = 1 To 5
                Array(RowCount, ColumnCount) = ""
            Next
        Next


        For RowCount = 1 To 10
            For ColumnCount = 1 To 5
                If Array(RowCount, ColumnCount) = "" Then
                    Array(RowCount, ColumnCount) = "X"
                End If
            Next
        Next


        For RowCount = 1 To 10
            For ColumnCount = 1 To 5

                If Array(RowCount, ColumnCount) = "" Then
                    ArrayHasData = False
                ElseIf Array(RowCount, ColumnCount) = "X" Then
                    ArrayHasData = True
                End If
            Next
        Next


                If ArrayHasData = True Then
            Console.WriteLine("THE 2-DIMENSIONAL ARRAY HAS BEEN FULLY POPULATED WITH THE CHARACTER X")
        End If
        Console.ReadKey()

    End Sub

End Module
