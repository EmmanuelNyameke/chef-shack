Option Strict On
Public Class frmDisplayInventory
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strItem As String
        ' Sorts the strInventoryItem Array
        Array.Sort(frmDepreciation._strInventoryItem)
        ' Display the inventory item array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmFirst As New frmDepreciation
        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class