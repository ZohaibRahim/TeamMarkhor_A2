
Imports System.Collections.Generic



Public Class BankSimulation
    ' Simulation parameters
    Public eventList As New List(Of BankEvent)()
    Public queue As New Queue(Of Customer)()

    'Insertion method, basically goes over the event list and inserts new events in sorted order
    Public Sub InsertEvent(NewEvent As BankEvent)
        ' Insert event into event list in sorted order
        Dim inserted As Boolean = False

        For i As Integer = 0 To eventList.Count - 1
            Dim currentEvent As BankEvent = eventList(i)

            If NewEvent.EventTime < currentEvent.EventTime Then
                eventList.Insert(i, NewEvent)
                inserted = True
                Exit For
            End If
        Next
        ' if the event wasnt inserted above, it goes to the last position/index 
        If Not inserted Then
            eventList.Add(NewEvent)
        End If
    End Sub

    ' Process arrival events from above/ eventlist
    Public Sub ProcessArrival(arrivalEvent As BankEvent)
        queue.Enqueue(arrivalEvent.Customer)

        If queue.Count = 1 Then
            Dim departureTime As Integer = arrivalEvent.EventTime + arrivalEvent.Customer.TimeRequired
            Dim departureEvent As New BankEvent("Departure", departureTime, arrivalEvent.Customer)
            InsertEvent(departureEvent)
        End If
    End Sub

    'Deals with departure events and adds thems to the eventlist
    Public Sub ProcessDeparture(departureEvent As BankEvent)
        Dim ServedCustomer As Customer = queue.Dequeue()

        If queue.Count > 0 Then
            Dim nextCustomer As Customer = queue.Peek()

            Dim departureTime As Integer = departureEvent.EventTime + nextCustomer.TimeRequired
            Dim newDepartureEvent As New BankEvent("Departure", departureTime, nextCustomer)
            InsertEvent(newDepartureEvent)
        End If
    End Sub
End Class
