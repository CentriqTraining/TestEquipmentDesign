Public Class RackConfiguration
    Private _LoadID As String
    Private _PSID As String
    Private _DACID As String
    Private _ScopeID As String
    Public Sub New()
        SetLoadID()
        SetPowerSupplyID()
        SetDACID()
        SetScopeID()
    End Sub

    Public Property LoadController As ILoadController
    Public Property PSController As IPowerSupplyController
    Public Property DACController As IDACController

    Protected Overridable Sub GetControllers()
        '  Use dependancy injection to Get the 
        '  correct class that controls the 
        '  specific piece of equipment that
        '  is on this rack.  This can be read
        '  in from a ini file
    End Sub
    Protected Overridable Sub SetLoadID()
        '  Send IDN to unit and read info back
    End Sub
    Protected Overridable Sub SetPowerSupplyID()
        '  Send IDN to unit and read info back
    End Sub
    Protected Overridable Sub SetDACID()
        '  Send IDN to unit and read info back
    End Sub
    Protected Overridable Sub SetScopeID()
        '  Send IDN to unit and read info back
    End Sub
End Class
