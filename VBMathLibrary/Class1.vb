Public Module VBMath
    Public Function Fib(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            Return n
        Else
            Return Fib(n - 1) + Fib(n - 2)
        End If
    End Function

    Public Function Count() As Long
        Dim i As Long
        For i = 0 To 9999999
        Next
        Return i
    End Function
End Module
