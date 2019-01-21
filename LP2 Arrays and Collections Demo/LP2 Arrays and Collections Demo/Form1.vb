Option Strict On
Option Explicit On

Public Class Form1

    Dim anArrayOfNumbers As Integer()
    Dim aListOfWords As New List(Of String)     ' Specify data type
    Dim anArrayListOfStuff As New ArrayList()   ' Don't specify data type, can hold more than one

    Dim aDictionary As New Dictionary(Of String, Integer) ' Two data types, contains key value pairs

    Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
        anArrayOfNumbers = {2, 1, 5, 7}

        ' List demo
        aListOfWords.Add("First")
        aListOfWords.Add("Second")
        aListOfWords.Add("Third")
        aListOfWords.Add("Fourth")

        ' Array list demo
        anArrayListOfStuff.Add("A String")
        anArrayListOfStuff.Add(1)

        ' Dictionary demo
        aDictionary.Add("Key_1", 32)
        aDictionary.Add("Key_2", 42)



        lstCollections.Items.Add(anArrayOfNumbers(0))
        lstCollections.Items.Add(aListOfWords(0))
        lstCollections.Items.Add(anArrayListOfStuff(0))
        lstCollections.Items.Add(anArrayListOfStuff(1))

        ' lstCollections.Items.Add(aDictionary(1))
        lstCollections.Items.Add(aDictionary("Key_1"))

    End Sub
End Class
