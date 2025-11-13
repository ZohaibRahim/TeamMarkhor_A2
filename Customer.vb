
' This class represents a custoer class .
Public Class Customer
    Public Property ID As Integer
    Public Property ArrivalTime As Integer
    Public Property TimeRequired As Integer
    Public Property WaitTime As Integer

    'Constructor for Cx object
    Public Sub New(customerID As Integer, arrival As Integer, duration As Integer)
        Me.ID = customerID
        Me.ArrivalTime = arrival
        Me.TimeRequired = duration
        Me.WaitTime = 0
    End Sub
End Class
