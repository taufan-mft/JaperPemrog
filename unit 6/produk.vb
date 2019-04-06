Public class produk
    Dim k, d, f, p, A, B As Double
  Public Shared Function EPQ(k, d, f, p)
    A = (((2*k*d)/f)*(p/(p-d)))^0.5

  End Function

  Public Shared Function tc(k, d, f, p)
    B = ((1-(d/A))*k) + (1-(d/p)) * ((EPQ/2)*f)

    End Function

    End class
