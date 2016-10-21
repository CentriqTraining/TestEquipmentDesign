Public Interface ILoadController
    Function SetCurrent(val As Decimal) As Boolean
    Function SetVoltage(val As Decimal) As Boolean
    Function ReadCurrent() As Decimal
    Function ReadVoltage() As Decimal
End Interface

