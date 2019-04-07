Public Class Form1
    Dim nama, jumlah, manu, expir As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nama = txtnama.Text
        jumlah = txtjumlah.Text
        manu = txtmanu.Text
        expir = txtexp.Text
        Dim produk As Object
        produk = New Class1()
        produk.tambah(nama, jumlah, manu, expir)

        lvDisplay.Items.Add(New ListViewItem(New String() {produk.NamaProduk, produk.JumlahProduk, produk.Manufakturer, produk.Expiry}))

    End Sub
End Class
