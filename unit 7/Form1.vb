Public Class Form1
    Dim jumlah_Alma As Byte = 0
    Private jumlah_Lily As Byte = 5
    Dim caca(5, 4) As String
    Dim baru As Object
    Dim code, jumlah, beli, pesan, biaya, EOQ, nilaiEOQ As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Dim nama, manu As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nama = txtname.Text
        manu = txtmanu.Text
        code = txtcode.Text
        jumlah = txtjumlah.Text
        beli = txtbeli.Text
        pesan = txtpesan.Text
        biaya = txtbiaya.Text

        baru = New Produk()

        EOQ = baru.EOQ(jumlah, pesan, beli, biaya)


        If jumlah_Alma > jumlah_Lily - 1 Then
            MsgBox("List sudah penuh")

        Else
            caca(jumlah_Alma, 0) = code
            caca(jumlah_Alma, 1) = nama
            caca(jumlah_Alma, 2) = manu
            caca(jumlah_Alma, 3) = baru.nilaiEOQ
            txtname.Text = " "
            txtmanu.Text = " "
            txtcode.Text = " "
            txtjumlah.Text = " "
            'written by taufan_mft. licensed under public domain
            jumlah_Alma = jumlah_Alma + 1

        End If

    End Sub
End Class
