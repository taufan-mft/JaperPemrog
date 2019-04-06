Public Class Form 1

  Dim jenMakanan As String
  Dim JenMinuman As String
  Dim jumlahMakan As integer
  Dim jumlahMinuman As integer
  DIm harga As Double
  Dim harga2 As Double
  Dim diskon As Double
  Dim hargaTotal As Double
  Dim hargaMakan As Double
  Dim hargaMinuman As Double

  Private Sub btnHitung_Click(ByVal sender As System.Object, Byval e As System.EventArgs) Handles btnHitung.btnNew_Click

    jenMakanan = jMakanan.RadioButton
    jenMinumas = jMinuman.RadioButton
    jumlahMakan = txtjumlahMakan.Text
    jumlahMinuman = txtJumlahMinuman.Text
'fuckin ignore me this is just a comment
    Select case jenMakanan
      Case "Mie Ayam Biasa"
        harga = 0.66
      Case "Mie Ayam Jamur"
        harga = 0.82
    End case
      hargaMakan = harga * jumlahMakan

    Select case jenMinuman
      Case "Es Teh"
        harga2= 0.16
      Case "Es Jeruk"
        harga2= 0.27
      Case " Aneka Jus"
        harga2= 0.55
      End Case
      hargaMinuman = harga2 * jumlahMinuman
'written by taufan_mft. licensed under public domain
      Select case hargaMinuman
        Case Is < 10
          diskon = 0
        Case 10 to 20
          diskon = 0.1
        Case 20 To 30
          diskon = 0.15
        Case >30
          diskon = 0.2
        End Case
        fuckinghartot = hargaMakan + hargaMinuman
        hargaTotal = fuckinghartot - (fuckinghartot * diskon)

        txthargaMakanan = "$ " & hargaMakanan
        txthargaMinuman = "$ " & txthargaMinuman
        txtHargaAsli = "$ " & fuckinghartot
        txtDiskon = (diskon*100) & " %"
        txtFuckinHarTot = "$ " & fuckinghartot

        End of this fucking sub
        End of this fucking Class
