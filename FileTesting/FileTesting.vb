Module FileTesting

    Sub Main()
        Dim currentRecord As String


        FileOpen(1, "grocery.txt", OpenMode.Input)
        '    'The number "1" is now the variable by which the text file is known in the program
        '    'Append is used to add to a text file or create the text file
        '     Input is used to read the text file
        '    'Output is used to rewrite a text file

        'Commas work as delimiters in the text file.
        Do Until EOF(1)
            ' Input(1, currentRecord)
            currentRecord = LineInput(1)
            Console.WriteLine(currentRecord)
        Loop


        FileClose(1)
        Console.ReadLine()

    End Sub

    Sub Test()
        Dim record As String = "$$ABCApple,$$ABCPear"
        Dim temp() As String
        Dim cleanData() As String
        Dim result As String

        temp = Split(record, ",")

        For i = LBound(temp) To UBound(temp) 'Step 3. This can be added to make the loop read every third line.
            Console.WriteLine(Mid(temp(i), 6))
        Next

        cleanData = Split(temp(0), "$$ABC")

        result = Mid(record, 6)

        Console.WriteLine(result)

        Console.ReadLine()

    End Sub



End Module
