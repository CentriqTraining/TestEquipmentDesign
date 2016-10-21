Public Class TestName
    Private rack As RackConfiguration
    Public Sub New()
        rack = New RackConfiguration()
    End Sub
    Public Sub Test1()
        rack.LoadController.SetVoltage(200)
        rack.LoadController.SetCurrent(0.01)
        rack.DACController.SetSomeSetting(5)
        rack.PSController.Enable()
        Dim result = rack.LoadController.ReadVoltage()
        rack.PSController.Disable()
    End Sub
End Class
