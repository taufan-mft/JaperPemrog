Public Class Form1


    Dim productCode As Integer
    Dim productNam As String
    Dim demandRate As Integer
    Dim productionRate As Integer
    Dim holdingCost As Integer
    Dim SetupCost As Integer
    Dim EPQ As Double
    Dim totalCost As Double
    Dim jumlah_Alma As Byte = 0
    Private jumlah_Lily As Byte = 5
    Dim caca(5, 4) As String
    Dim baru As Object



    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        SetupCost = txtSetupCost.Text
        demandRate = txtDemandRate.Text
        productionRate = txtProductionRate.Text
        holdingCost = txtHoldingCost.Text
        baru = New Produk()
        EPQ = baru.EPQ(SetupCost, demandRate, holdingCost, productionRate)

        totalCost = baru.tc(SetupCost, demandRate, holdingCost, productionRate)
        txtEPQ.Text = baru.nilaiEPQ
        txtTotalCost.Text = baru.nilaiTC
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        productCode = txtProductCode.Text
        productNam = txtProductName.Text
        If jumlah_Alma > jumlah_Lily - 1 Then
            MsgBox("List sudah penuh")

        Else
            caca(jumlah_Alma, 0) = productCode
            caca(jumlah_Alma, 1) = productNam
            caca(jumlah_Alma, 2) = baru.nilaiEPQ
            caca(jumlah_Alma, 3) = baru.nilaiTC
            txtProductCode.Text = " "
            txtProductName.Text = " "
            txtEPQ.Text = " "
            txtTotalCost.Text = " "
            'written by taufan_mft. licensed under public domain
            jumlah_Alma = jumlah_Alma + 1

        End If
    End Sub

    Private Sub btnLihatData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLihatData.Click
        Dim i As Byte
        If jumlah_Alma > 0 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()

            For i = 0 To jumlah_Alma - 1
                ListBox1.Items.Add(caca(i, 0))
                ListBox2.Items.Add(caca(i, 1))
                ListBox3.Items.Add(caca(i, 2))
                ListBox4.Items.Add(caca(i, 3))
            Next
        End If
    End Sub
End Class
