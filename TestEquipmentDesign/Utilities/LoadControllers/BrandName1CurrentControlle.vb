Imports Utilities

Public Class BrandName1CurrentControlle
    Implements ILoadController

    Public Function ReadCurrent() As Decimal Implements ILoadController.ReadCurrent
        Throw New NotImplementedException()
    End Function

    Public Function ReadVoltage() As Decimal Implements ILoadController.ReadVoltage
        Throw New NotImplementedException()
    End Function

    Public Function SetCurrent(val As Decimal) As Boolean Implements ILoadController.SetCurrent
        Throw New NotImplementedException()
    End Function

    Public Function SetVoltage(val As Decimal) As Boolean Implements ILoadController.SetVoltage
        Throw New NotImplementedException()
    End Function
End Class
