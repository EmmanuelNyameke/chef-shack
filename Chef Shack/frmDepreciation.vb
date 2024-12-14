' Program Name: Chef Shack Food Truck Depreciation Window Application
' Author: K Bola
' Date: December 12, 2024
' Purpose: The chef shack inventory window application dtermines the depreciation based on a 5 year life of items in inventory using the straight-line or double-declining balance method

Option Strict On
Public Class frmDepreciation
    ' Class level private variables
    Private _intLifeOfItems As Integer = 5
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private _intQuantity(_intSizeOfArray) As Integer

    Private Sub frmDepreciation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This reads the inventory text file and fills the listbox object with the inventory items

        ' Initializing the instance of the StreamReader Object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Users\HELLO\Source\Repos\Chef Shack\inventory.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available"

        ' Verifying whether the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1
                _strInventoryItem(intCount) = objReader.ReadLine()
                _strItemId(intCount) = objReader.ReadLine()
                _decInitialPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())
                _intQuantity(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            ' Filling the listbox with inventory IDs
            For intFill = 0 To (_strItemId.Length - 1)
                lstInventoryId.Items.Add(_strItemId(intFill))
            Next
        Else
            MsgBox(strFileError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
            Close()
        End If
    End Sub

    Private Sub btnCalculateDepreciation_Click(sender As Object, e As EventArgs) Handles btnCalculateDepreciation.Click
        ' Declaring vaiables 
        Dim intSelectedItemId As Integer
        Dim strMissingSelection As String = "Missing Selection"
        Dim strSelectDepreciationError As String = "Select a Depreciation Method"
        Dim strSelectInventoryItemIdError As String = "Select an Inventory Item ID"

        ' If the listbox and depreciation radio button are selected, call the depreciation procedures
        If lstInventoryId.SelectedIndex >= 0 Then
            intSelectedItemId = lstInventoryId.SelectedIndex
            If radStraightLine.Checked Then
                StraightLineDepreciation(intSelectedItemId)
            ElseIf radDoubleDeclining.Checked Then
                DoubleDecliningDepreciation(intSelectedItemId)
            Else
                MsgBox(strSelectDepreciationError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, strMissingSelection)
            End If
        Else
            MsgBox(strSelectInventoryItemIdError, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, strMissingSelection)
        End If
    End Sub
    Private Sub StraightLineDepreciation(ByVal intItemId As Integer)
        ' Declaring Variables
        Dim intStraightPresentYear As Integer
        Dim decStraightPresentYearValue As Decimal = 0
        Dim decStraightDepreciation As Decimal
        Dim decStraightTotal As Decimal
        Dim strDepreciationItem As String = "The depreciation of the item: "
        Dim strQuantityMessage As String = "Quantity: "

        'This procedure is called to display the form objects
        MakeObjectsVisible()

        ' Displaying the item and quantity of the selected item
        lblItem.Text = strDepreciationItem & _strInventoryItem(intItemId)
        lblQuantity.Text = strQuantityMessage & _intQuantity(intItemId).ToString()

        ' Formula for finding the straight line depreciation
        decStraightDepreciation = _decInitialPrice(intItemId) / _intLifeOfItems
        decStraightPresentYearValue = _decInitialPrice(intItemId)

        ' The loop repeats for the life of the items
        For intStraightPresentYear = 1 To _intLifeOfItems
            ' Accumulates the total of depreciation
            decStraightTotal += decStraightDepreciation
            ' Displaying the depreciation amounts
            lstYear.Items.Add(intStraightPresentYear.ToString())
            lstPresentValue.Items.Add(decStraightPresentYearValue.ToString("C"))
            lstYearDepreciation.Items.Add(decStraightDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decStraightTotal.ToString("C"))
            decStraightPresentYearValue -= decStraightDepreciation
        Next
    End Sub

    Private Sub DoubleDecliningDepreciation(ByVal intItemId As Integer)
        ' Declaring Variables
        Dim intDoublePresentYear As Integer
        Dim decDoublePresentYearValue As Decimal = 0
        Dim decDoubleDepreciation As Decimal
        Dim decDoubleTotal As Decimal
        Dim strDepreciationItem As String = "The depreciation of the item: "
        Dim strQuantityMessage As String = "Quantity: "

        'This procedure is called to display the form objects
        MakeObjectsVisible()

        ' Displaying the item and quantity of the selected item
        lblItem.Text = strDepreciationItem & _strInventoryItem(intItemId)
        lblQuantity.Text = strQuantityMessage & _intQuantity(intItemId).ToString()
        decDoublePresentYearValue = _decInitialPrice(intItemId)

        ' The loop repeats for the life of the items
        For intDoublePresentYear = 1 To _intLifeOfItems
            ' Formula for finding the Double-declining depreciation
            decDoubleDepreciation = (decDoublePresentYearValue * 2D) / _intLifeOfItems
            ' Accumulates the total of depreciation
            decDoubleTotal += decDoubleDepreciation
            ' Displaying the depreciation amounts
            lstYear.Items.Add(intDoublePresentYear.ToString())
            lstPresentValue.Items.Add(decDoublePresentYearValue.ToString("C"))
            lstYearDepreciation.Items.Add(decDoubleDepreciation.ToString("C"))
            lstTotalDepreciation.Items.Add(decDoubleTotal.ToString("C"))
            decDoublePresentYearValue -= decDoubleDepreciation
        Next
    End Sub

    Private Sub MakeObjectsVisible()
        lblItem.Visible = True
        lblQuantity.Visible = True
        lblYear.Visible = True
        lblPresentValue.Visible = True
        lblYearDepreciation.Visible = True
        lblTotalDepreciation.Visible = True
        lstYear.Visible = True
        lstPresentValue.Visible = True
        lstYearDepreciation.Visible = True
        lstTotalDepreciation.Visible = True

        ' Removing the previous data
        lstYear.Items.Clear()
        lstPresentValue.Items.Clear()
        lstYearDepreciation.Items.Clear()
        lstTotalDepreciation.Items.Clear()
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        ' Creating an instance of the frmDisplayInventory
        Dim frmSecond As New frmDisplayInventory
        ' Hiding this form
        Hide()
        ' Showing the frmDisplayInventory
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstInventoryId.SelectedIndex = -1
        radStraightLine.Checked = False
        radDoubleDeclining.Checked = False
        lblItem.Visible = False
        lblQuantity.Visible = False
        lblYear.Visible = False
        lblPresentValue.Visible = False
        lblYearDepreciation.Visible = False
        lblTotalDepreciation.Visible = False
        lstYear.Visible = False
        lstPresentValue.Visible = False
        lstYearDepreciation.Visible = False
        lstTotalDepreciation.Visible = False

        ' Removing the previous data
        lstYear.Items.Clear()
        lstPresentValue.Items.Clear()
        lstYearDepreciation.Items.Clear()
        lstTotalDepreciation.Items.Clear()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
