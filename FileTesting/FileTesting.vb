Module FileTesting

    Sub Main()
        Dim currentRecord As String


        '    FileOpen(1, "sample.txt", OpenMode.Input)
        '    'The number "1" is now the variable by which the text file is known in the program
        '    'Append is used to add to a text file or create the text file
        '    'Input is used to read the text file
        '    'Output is used to rewrite a text file

        '    'Commas work as delimiters in the text file.
        '    Do Until EOF(1)
        '        Input(1, currentRecord)
        '        Console.WriteLine(currentRecord)
        '    Loop


        '    FileClose(1)
        '    Console.ReadLine()




        Dim record As String = "$$ABCApple,$$ABCPear"
        Dim temp() As String
        Dim cleanData() As String

        temp = Split(record, ",")

        cleanData = Split(temp(0), "$$ABC")
        Console.WriteLine(cleanData(1))

        Console.ReadLine()

    End Sub

End Module
