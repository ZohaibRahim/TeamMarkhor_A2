'Event class

Public Class BankEvent
    Public Property TypeOfEvent As String
    Public Property EventTime As Integer
    Public Property Customer As Customer

    Public Sub New(eventType As String, eventTime As Integer, customer As Customer)
        Me.TypeOfEvent = eventType
        Me.EventTime = eventTime
        Me.Customer = customer
    End Sub
End Class
