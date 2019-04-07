Public Class Produk
    Dim k, d, f, p, A, B As Double
    Public Sub EPQ(k, d, f, p)
        A = (((2 * k * d) / f) * (p / (p - d))) ^ 0.5

    End Sub

    Public Sub tc(k, d, f, p)
        B = ((1 - (d / A)) * k) + (1 - (d / p)) * ((A / 2) * f)

    End Sub

    Public Property nilaiEPQ() As Double
        Get
            Return A
        End Get
        Set(value As Double)

        End Set
    End Property

    Public Property nilaiTC() As Double
        Get
            Return B
        End Get
        Set(value As Double)

        End Set
    End Property


End Class
