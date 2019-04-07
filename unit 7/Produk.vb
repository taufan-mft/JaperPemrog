Public Class Produk
    Inherits Form1

    Dim r, s, p, i, A As Double

    Public Sub eoq(r, s, p, i)
        A = ((2 * r * s) / (p * i)) ^ 0.5

    End Sub

    Public Property nilaiEOQ() As Double
        Get
            Return A
        End Get
        Set(value As Double)

        End Set
    End Property

End Class
