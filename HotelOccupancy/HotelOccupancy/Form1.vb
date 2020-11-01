
Public Class Form1
    'declare constants and variables
    Const intROOMS As Integer = 30
    Const intFLOORS As Integer = 8
    Dim intOccupiedRooms As Integer


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'start a loop to display in the lstbox
        Dim intTotal As Integer = 0  'variable accumulator
        Dim intCount As Integer
        Dim intRooms As Integer
        intRooms = CInt(txtOccupiedRooms.Text)
        For intCount = 1 To 8
            intTotal = intRooms \ 30
            intTotal *= 100

        Next
        'display in list box the total occupancy rate with the floor
        lstData.Items.Add("Floor: " & cboFloorNumber.SelectedIndex.ToString() & "Rooms Occupied: " & txtOccupiedRooms.Text.ToString() & "Occupanycy Rate ")
    End Sub
End Class
