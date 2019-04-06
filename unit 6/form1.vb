Public class Form1

  Dim productCode As integer
  dim productName As Strings
  Dim demandRate As integer
  Dim productionRate As integer
  Dim holdingCost As integer
  dim SetupCost As Integer
  Dim EPQ As Double
  Dim totalCost As Double
  Dim indexngentot As Byte = 0
  Private jumlah_ngentot As Byte = 5
  Dim ngentot(5,4) As String


    Private Sub btnCount_Click(ByVal sender As System.Object, Byval e As System.EventArgs) Handles btnCount.Click
      SetupCost = txtSetupCost.Text
      demandRate = txt.DemandRate.Text
      productionRate = txtProductionRate.Text
      holdingCost = txtHoldingCost.Text
      Dim baru As Object
      baru = New produk()
      EPQ = produk.epq(SetupCost, demandRate, holdingCost, productionRate)

      totalCost = produk.tc(SetupCost, demandRate, holdingCost, productionRate)
      txtEPQ.Text = EPQ
      txtTotalCost.Text = totalCost

      Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.btnNew_Click
        productCode = txtProductCode.Text
        productName = txtProductName.Text
        If jumlah_anjing > jumlah_ngentot - 1 Then
          MsgBox("List sudah penuh")

        else
          ngentot(jumlah_anjing, 0) = productCode
          ngentot(jumlah_anjing, 1) = productName
          ngentot(jumlah_anjing, 2) = EPQ
          ngentot(jumlah_anjing, 3) = totalCost
          txtProductCode.Text = " "
          txtProductName.Text = " "
          txtEPQ.Text=" "
          txtTotalCost = " "

          jumlah_anjing = jumlah_anjing + 1

        End If
      ENd Sub

      Private Sub btnLihatData_Click(ByVal sender As System.Object, byVal e As System.EventArgs) Handles btnLihatData.btnNew_Click
        Dim i As byte
        If jumlah_anjing >0 Then
          Listbox1.Items.Clear()
          Listbox2.Items.Clear()
          Listbox3.Items.Clear()
          Listbox4.Items.Clear()

          For i = 0 To jumlah_anjing - 1
            Listbox1.Items.Add(ngentot(i,0))
            Listbox2.Items.Add(ngentot(i, 1))
            Listbox3.Items.Add(ngentot(i, 2))
            Listbox4.Items.Add(ngentot(i, 3))
          Next
        End If
      End Sub
