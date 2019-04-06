Public class Form 1
  Dim namaBarang As String
  Dim jumlah As String
  Dim manu As String
  Dim expir As String

  Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

    namaBarang = txtnamaBarang.Text
    jumlah= txtJumlah.Text
    manu = txtManu.Text
    expir = txtExpire.Text
    lvDisplay.Items.Add(New ListViewItem(New String(){namaBarang, jumlah, manu, expir}))

    End sub
    End Class
