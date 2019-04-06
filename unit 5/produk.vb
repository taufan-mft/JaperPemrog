Public class produk
  Dim a, b, c, d As String
  Dim nama, jumlah, manu, expir As String

  Private Sub tambah(a, b, c, d)
    nama = a
    jumlah = b
    manu = c
    expir = d

  End sub

  Private Sub tampilkan()
  lvDisplay.Items.Add(New ListViewItem(New String(){nama, jumlah, manu, expir}))

  End sub

  End class
