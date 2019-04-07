Public Class Form1

    Dim jenMakanan As String
    Dim JenMinuman As String
    Dim jumlahMakan As Integer
    Dim jumlahMinuman As Integer
    Dim harga As Double
    Dim harga2 As Double
    Dim diskon As Double
    Dim hargaTotal As Double
    Dim hargaMakan As Double
    Dim hargaMinuman As Double
    Dim fuckinghartot As Double

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click

        jumlahMakan = txtjumlahMakan.Text
        jumlahMinuman = txtJumlahMinuman.Text
        'fuckin ignore me this is just a comment
        Select Case jenMakanan
            Case "Mie Ayam Biasa"
                harga = 0.66
            Case "Mie Ayam Jamur"
                harga = 0.82
        End Select
        hargaMakan = harga * jumlahMakan

        Select Case JenMinuman
            Case "Es Teh"
                harga2 = 0.16
            Case "Es Jeruk"
                harga2 = 0.27
            Case "Aneka Jus"
                harga2 = 0.55
        End Select
        hargaMinuman = harga2 * jumlahMinuman
        'written by taufan_mft. licensed under public domain
        fuckinghartot = hargaMakan + hargaMinuman
        Select Case fuckinghartot
            Case Is < 10
                diskon = 0
            Case 10 To 20
                diskon = 0.1
            Case 20 To 30
                diskon = 0.15
            Case > 30
                diskon = 0.2
        End Select

        fuckinghartot = hargaMakan + hargaMinuman
        hargaTotal = fuckinghartot - (fuckinghartot * diskon)

        txthargaMakanan.Text = "$ " & hargaMakan
        txthargaMinuman.Text = "$ " & hargaMinuman
        txtHargaAsli.Text = "$ " & fuckinghartot
        txtDiskon.Text = (diskon * 100) & " %"
        txtFuckinHartot.Text = "$ " & hargaTotal

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jenMakanan = "Mie Ayam Biasa"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jenMakanan = "Mie Ayam Jamur"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        JenMinuman = "Es Teh"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        JenMinuman = "Es Jeruk"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        JenMinuman = "Aneka Jus"
    End Sub
End Class
