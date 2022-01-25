Public Class Class1
    Implements EsimenePraktikum

    Const KM2MI = 1.609344

    Private millid As Double = 0

    Public Function teisendaKilomeetridMiilideks(km As Double) As Double Implements 
        teisendaKmMi(km)
        Return millid
    End Function
    Private Sub teisendaKmMi(ByVal km As Double)
        millid = km / KM2MI
    End Sub
End Class
