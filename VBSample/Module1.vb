Imports CSMathLibrary
Imports VBMathLibrary

Module Module1

    Sub Main()
        Console.WriteLine("Calculating the 42nd Fibonacci number using C#.")
        Console.WriteLine("The 42nd Fibonacci number is " & CSMath.Fib(42))
        Console.WriteLine("Calculating the 42nd Fibonacci number using VB.")
        Console.WriteLine("The 42nd Fibonacci number is " & VBMath.Fib(42))
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

End Module
