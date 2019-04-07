Public Class Class1
    Inherits Form1

    Dim a, b, c, d As String
    Dim nama, jumlah, manu, expir As String

    Public Sub tambah(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String)
        nama = a
        jumlah = b
        manu = c
        expir = d

    End Sub

    Public Property NamaProduk() As String
        Get
            Return nama
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property JumlahProduk() As String
        Get
            Return jumlah

        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Manufakturer() As String
        Get
            Return manu

        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Expiry() As String
        Get
            Return expir

        End Get
        Set(value As String)

        End Set
    End Property
End Class
