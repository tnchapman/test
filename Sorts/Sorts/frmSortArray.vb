Public Class frmSortArray
    Dim arrItems(5) As Integer

    Private Sub loadArray()
        ' clear listboxes each time array is loaded
        lstDisplayArray.Items.Clear()
        lstDisplaySort.Items.Clear()

        'load test data into array
        txtItem1.Text = 2
        txtItem2.Text = 6
        txtItem3.Text = 4
        txtItem4.Text = 3
        txtItem5.Text = 1

        'display array in text boxes
        arrItems(1) = txtItem1.Text
        arrItems(2) = txtItem2.Text
        arrItems(3) = txtItem3.Text
        arrItems(4) = txtItem4.Text
        arrItems(5) = txtItem5.Text

        'display array in list box
        For i = 1 To UBound(arrItems)
            lstDisplayArray.Items.Add(arrItems(i))
        Next
        'End If
    End Sub

   Private Sub btnCreateArray_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateArray.Click
        'call load array sub
        loadArray()
    End Sub

    Private Sub btnBubbleSort_Click(sender As System.Object, e As System.EventArgs) Handles btnBubbleSort.Click
        'call load array sub
        loadArray()

        ' bubble sort the array
        Dim firstIndex As Integer = 1 'first position in the array
        Dim lastIndex As Integer = UBound(arrItems) ' last position in the array
        Dim currentIndex As Integer

        Dim temp As String ' temporary store of data to allow swap
        While lastIndex > firstIndex
            currentIndex = 1 ' reset index to start of array for another pass
            While currentIndex < lastIndex ' loop to check each pair of items and swap where necessary

                If arrItems(currentIndex) > arrItems(currentIndex + 1) Then 'check the pair and if the fist item is larger than the second then start the swap
                    'swap the first and second item in pair
                    temp = arrItems(currentIndex)
                    arrItems(currentIndex) = arrItems(currentIndex + 1)
                    arrItems(currentIndex + 1) = temp
                End If
                lstDisplaySort.Items.Add(arrItems(1) & ", " & arrItems(2) & ", " & arrItems(3) & ", " & arrItems(4) & ", " & arrItems(5)) 'display to result of each pass as a group
                currentIndex = currentIndex + 1 ' process of checking and swapping moves on to next pair in the array
            End While
            lastIndex = lastIndex - 1 'ensures the number of passes stops at the number of items in the array.
        End While
        lstDisplaySort.Items.Add(arrItems(1) & ", " & arrItems(2) & ", " & arrItems(3) & ", " & arrItems(4) & ", " & arrItems(5)) ' display sorted array as a group

        'display sorted array as list
        For i = 1 To UBound(arrItems)
            lstDisplaySort.Items.Add(arrItems(i))
        Next
    End Sub

    Private Sub btnSelectionSort_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectionSort.Click
        Dim firstIndex As Integer = 1
        Dim lastIndex As Integer = UBound(arrItems)
        Dim endUnsortedIndex As Integer = firstIndex
        Dim currentIndex As Integer
        Dim minItem As String
        Dim minIndex As Integer
        Dim temp As String

        'load array
        loadArray()

        While endUnsortedIndex < lastIndex
            currentIndex = endUnsortedIndex
            minItem = arrItems(currentIndex)
            minIndex = currentIndex

            While currentIndex < lastIndex
                currentIndex = currentIndex + 1
                If arrItems(currentIndex) < minItem Then
                    minItem = arrItems(currentIndex)
                    minIndex = currentIndex
                End If
            End While
            'swap items
            temp = arrItems(minIndex)
            arrItems(minIndex) = arrItems(endUnsortedIndex)
            arrItems(endUnsortedIndex) = temp
            endUnsortedIndex = endUnsortedIndex + 1
            lstDisplaySort.Items.Add(arrItems(1) & ", " & arrItems(2) & ", " & arrItems(3) & ", " & arrItems(4) & ", " & arrItems(5)) 'display the result of each pass as a group
        End While
        lstDisplaySort.Items.Add(arrItems(1) & ", " & arrItems(2) & ", " & arrItems(3) & ", " & arrItems(4) & ", " & arrItems(5)) ' display sorted array as a group

        'display sorted array as list
        For i = 1 To UBound(arrItems)
            lstDisplaySort.Items.Add(arrItems(i))
        Next
    End Sub

    Private Sub btnInsertionSort_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertionSort.Click
        'load array
        loadArray()

        Dim firstIndex As Integer
        Dim lastIndex As Integer
        Dim currentIndex As Integer
        Dim temp As String
        Dim shuffleIndex As Integer


        firstIndex = 1
        lastIndex = UBound(arrItems)
        currentIndex = firstIndex

        While currentIndex <= lastIndex - 1
            If arrItems(currentIndex) > arrItems(currentIndex + 1) Then
                temp = arrItems(currentIndex + 1)
                shuffleIndex = currentIndex
                While shuffleIndex >= 1 And arrItems(shuffleIndex) > temp
                    arrItems(shuffleIndex + 1) = arrItems(shuffleIndex)
                    shuffleIndex = shuffleIndex - 1

                End While
                arrItems(shuffleIndex + 1) = temp
                lstDisplaySort.Items.Add(arrItems(1) & ", " & arrItems(2) & ", " & arrItems(3) & ", " & arrItems(4) & ", " & arrItems(5)) 'display the result of each pass as a group
            End If
            currentIndex = currentIndex + 1
        End While

        'display sorted array as list
        For i = 1 To UBound(arrItems)
            lstDisplaySort.Items.Add(arrItems(i))
        Next

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnOpenSortRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenSortRecords.Click
        frmSortRecord.Show()
    End Sub
Private Sub test()
end sub

End Class
