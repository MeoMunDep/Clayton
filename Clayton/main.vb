Module Logger

    Sub Main()
        LogInfo("Clayton bot by Meomundep.")
        LogWarning("This is a announcement!")
        LogError("Stop this game, please choose another scripts!")
        Console.ReadLine()
    End Sub

    Sub LogInfo(message As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("[INFO] " & message)
        Console.ResetColor()
    End Sub

    Sub LogWarning(message As String)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("[WARNING] " & message)
        Console.ResetColor()
    End Sub

    Sub LogError(message As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("[ERROR] " & message)
        Console.ResetColor()
    End Sub

End Module
