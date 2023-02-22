Public Class frmAirBnB

    Const _cdecCostPPerNight As Decimal = 79D
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Headerlbl.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCostOfStay.Click

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        txtNights.Clear()
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = "Only" & _cdecCostPPerNight.ToString("C") & " per night"
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub Displaybtn_Click(sender As Object, e As EventArgs) Handles Displaybtn.Click
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        strEnterNumberOfNights = txtNights.Text
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        decTotalCostOfStay = intEnterNumberOfNights * _cdecCostPPerNight
        lblTotalCost.Text = decTotalCostOfStay.ToString("C")
    End Sub

End Class