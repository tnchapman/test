Public Class frmSortRecord
    Public Structure contact
        Dim ID As Integer
        Dim name As String
        Dim surname As String
    End Structure

    Public arrContact(4) As contact

    'load data into array of records
    Private Sub loadArray()
        arrContact(1).ID = 1
        arrContact(1).name = "Fred"
        arrContact(1).surname = "Jones"

        arrContact(2).ID = 2
        arrContact(2).name = "Anna"
        arrContact(2).surname = "Smith"

        arrContact(3).ID = 3
        arrContact(3).name = "Craig"
        arrContact(3).surname = "Adams"

        arrContact(4).ID = 4
        arrContact(4).name = "Bree"
        arrContact(4).surname = "Donaldson"
    End Sub
        Private Sub frmSortRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load records
        loadArray()
    End Sub

    Private Sub btnLoadRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadRecords.Click
        For i = 1 To UBound(arrContact)
            lstRecords.Items.Add(arrContact(i).ID & vbTab & arrContact(i).name & vbTab & arrContact(i).surname)
        Next
    End Sub

  
    Private Sub btnSortName_Click(sender As System.Object, e As System.EventArgs) Handles btnSortName.Click
        lstSortedRecords.Items.Clear()

        'local variables for sort
        Dim firstIndex As Integer = 1
        Dim lastIndex As Integer = UBound(arrContact)
        Dim endUnsortedIndex As Integer = firstIndex
        Dim currentIndex As Integer
        Dim minItem As String
        Dim minIndex As Integer
        Dim temp As contact

        'selection sort of records using the GIVEN NAME as the sort parameter
        While endUnsortedIndex < lastIndex
            currentIndex = endUnsortedIndex
            minItem = arrContact(currentIndex).name
            minIndex = currentIndex

            While currentIndex < lastIndex
                currentIndex = currentIndex + 1
                If arrContact(currentIndex).name < minItem Then
                    minItem = arrContact(currentIndex).name
                    minIndex = currentIndex
                End If
            End While
            'swap items
            temp = arrContact(minIndex)
            arrContact(minIndex) = arrContact(endUnsortedIndex)
            arrContact(endUnsortedIndex) = temp
            endUnsortedIndex = endUnsortedIndex + 1
        End While

        'display sorted array as list
        For i = 1 To UBound(arrContact)
            lstSortedRecords.Items.Add(arrContact(i).ID & vbTab & arrContact(i).name & vbTab & arrContact(i).surname)
        Next

    End Sub

    Private Sub btnSortSurname_Click(sender As System.Object, e As System.EventArgs) Handles btnSortSurname.Click
        lstSortedRecords.Items.Clear()

        'local variables for sort
        Dim firstIndex As Integer
        Dim lastIndex As Integer
        Dim currentIndex As Integer
        Dim temp As contact
        Dim shuffleIndex As Integer

        firstIndex = 1
        lastIndex = UBound(arrContact)
        currentIndex = firstIndex

        'insertion sort of records using the SURNAME name as the sort parameter
        While currentIndex <= lastIndex - 1
            If arrContact(currentIndex).surname > arrContact(currentIndex + 1).surname Then
                temp = arrContact(currentIndex + 1)
                shuffleIndex = currentIndex
                While shuffleIndex >= 1 And arrContact(shuffleIndex).surname > temp.surname
                    arrContact(shuffleIndex + 1) = arrContact(shuffleIndex)
                    shuffleIndex = shuffleIndex - 1
                End While
                arrContact(shuffleIndex + 1) = temp
            End If
            currentIndex = currentIndex + 1
        End While

        'display sorted array as list
        For i = 1 To UBound(arrContact)
            lstSortedRecords.Items.Add(arrContact(i).ID & vbTab & arrContact(i).name & vbTab & arrContact(i).surname)
        Next
    End Sub
End Class