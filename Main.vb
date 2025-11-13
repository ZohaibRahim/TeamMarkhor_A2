' SAMPLE MAIN FOR TESTING, PLEASE DELETE THE BELOW
' ONCE YOU CONNECT THE BACK END TO THE FRONT END. AHAD

Module Program
    Sub Main()
        Dim sim As New BankSimulation()

        ' Create some customers manually
        Dim cust1 As New Customer(1, 10, 7)
        Dim cust2 As New Customer(2, 15, 5)
        Dim cust3 As New Customer(3, 10, 6)

        ' Insert arrival events
        sim.InsertEvent(New BankEvent("Arrival", cust1.ArrivalTime, cust1))
        sim.InsertEvent(New BankEvent("Arrival", cust2.ArrivalTime, cust2))
        sim.InsertEvent(New BankEvent("Arrival", cust3.ArrivalTime, cust3))

        ' Simulation loop handled right here
        While sim.eventList.Count > 0
            ' Take the earliest event
            Dim currentEvent As BankEvent = sim.eventList(0)
            sim.eventList.RemoveAt(0)

            ' Process the event
            If currentEvent.TypeOfEvent = "Arrival" Then
                sim.ProcessArrival(currentEvent)
            ElseIf currentEvent.TypeOfEvent = "Departure" Then
                sim.ProcessDeparture(currentEvent)
            End If

            Console.WriteLine($"{currentEvent.TypeOfEvent} for Customer {currentEvent.Customer.ID} at time {currentEvent.EventTime}")
        End While

        Console.WriteLine("Simulation completed.")
    End Sub
End Module
