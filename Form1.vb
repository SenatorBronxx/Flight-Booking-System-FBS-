Public Class Form1
    ' Single shared Random object to guarantee unique, sequential seat blocks
    Private Shared RandGenerator As New Random()

    ' Array of destination cities matching your layout list
    Private stCities As String() = {
        "Rome (Italy)", "Kyoto (Japan)", "Cairo (Egypt)",
        "London (UK)", "Paris (France)", "Cape Town (South Africa)",
        "Lisbon (Portugal)", "Sydney (Australia)", "Istanbul (Turkyie)",
        "Ontario (Canada)", "Moscow (Russia)", "Kyiv (Ukraine)", "Warsaw (Poland)",
        "Barcalona (Spain)", "New York (USA)", "California (USA)", "Nairobi (Kenya)",
        "Tel Aviv (Israel)"
    }

    ' Form Load event to safely populate your Destination ComboBox dropdown
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDestination.Items.Clear()
        cmbDestination.Items.AddRange(stCities)

        ' Set default choices
        radEconomy.Checked = True

        ' Clean setup properties for your DataGridView grid tool
        dgvTagAlongs.AllowUserToAddRows = True ' Allows users to type into a blank row to add a name
        dgvTagAlongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' Helper Function: Generates a unique 6-character alphanumeric booking reference
    Private Function GenerateBookingReference() As String
        Dim validChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim referenceCode As String = ""

        For i As Integer = 1 To 6
            referenceCode &= validChars(RandGenerator.Next(0, validChars.Length))
        Next

        Return referenceCode
    End Function

    ' Helper Function: Generates distinct seating assignments for the primary passenger and all custom names from the grid tool
    Private Function GeneratePassengerManifest(travelClass As String, tagAlongNames As List(Of String)) As String
        Dim manifestLayout As String = ""
        Dim seatLetters As String() = {"A", "B", "C", "D", "E", "F"}

        Dim startRow As Integer = 1
        Dim endRow As Integer = 5

        Select Case travelClass
            Case "First Class"
                startRow = 1
                endRow = 5
                seatLetters = New String() {"A", "F"} ' Premium window rows
            Case "Business Class"
                startRow = 6
                endRow = 15
            Case Else
                startRow = 16
                endRow = 40
        End Select

        ' Establish initial rows for the traveling party group block
        Dim currentGroupRow As Integer = RandGenerator.Next(startRow, endRow + 1)
        Dim letterIndex As Integer = RandGenerator.Next(0, seatLetters.Length)

        ' 1. Book Primary Passenger Seat
        Dim primarySeat As String = String.Format("{0}{1}", currentGroupRow, seatLetters(letterIndex))
        manifestLayout &= String.Format("  * [Primary Booker] {0} -> Seat: {1}", txtFullName.Text.ToUpper(), primarySeat) & Environment.NewLine

        ' Shift index over for next person sitting together
        letterIndex += 1

        ' 2. Loop through and dynamically book seat tokens for every typed tag-along name
        For Each passengerName In tagAlongNames
            If letterIndex >= seatLetters.Length Then
                letterIndex = 0
                currentGroupRow += 1
                If currentGroupRow > endRow Then currentGroupRow = startRow
            End If

            Dim currentSeat As String = String.Format("{0}{1}", currentGroupRow, seatLetters(letterIndex))
            manifestLayout &= String.Format("  * [Tag-Along] {0} -> Seat: {1}", passengerName.ToUpper(), currentSeat) & Environment.NewLine

            letterIndex += 1
        Next

        Return manifestLayout
    End Function

    ' Button event for when "ISSUE RECEIPT" is clicked
    Private Sub btnIssueReceipt_Click(sender As Object, e As EventArgs) Handles btnIssueReceipt.Click
        ' 1. Form Validation: Make sure base fields are filled out before proceeding
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCityOfOrigin.Text) OrElse
           cmbDestination.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out Full Name, City of Origin, and select a Destination.",
                            "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Age Restriction Rule Validation Check
        Dim passengerAge As Integer = 0
        If Not Integer.TryParse(txtAge.Text, passengerAge) Then
            MessageBox.Show("Please enter a valid numeric value for Age.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If passengerAge < 18 Then
            MessageBox.Show("Booking Permit Denied: Primary passengers must be 18 years or older to book flights.",
                            "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        ' 3. Dynamically extract typed names out of your DataGridView rows grid
        Dim extraPassengersList As New List(Of String)()

        For Each row As DataGridViewRow In dgvTagAlongs.Rows
            ' Ignore the last empty placeholder row in the editable grid framework
            If Not row.IsNewRow Then
                Dim cellValue As Object = row.Cells(0).Value
                ' Fixed with "Nothing" keyword reference to compile smoothly
                If cellValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                    extraPassengersList.Add(cellValue.ToString().Trim())
                End If
            End If
        Next

        ' Update your numerical text counter box to show the accurate count from the table spreadsheet rows grid
        txtTgA.Text = extraPassengersList.Count.ToString()

        ' 4. Determine a unique base price based on the chosen city
        Dim flightBasePrice As Double = 0.0

        Select Case cmbDestination.Text
            Case "Rome (Italy)"
                flightBasePrice = 400.0
            Case "Kyoto (Japan)"
                flightBasePrice = 800.0
            Case "Cairo (Egypt)"
                flightBasePrice = 500.0
            Case "London (UK)"
                flightBasePrice = 450.0
            Case "Paris (France)"
                flightBasePrice = 480.0
            Case "Cape Town (South Africa)"
                flightBasePrice = 650.0
            Case "Lisbon (Portugal)"
                flightBasePrice = 420.0
            Case "Sydney (Australia)"
                flightBasePrice = 950.0
            Case "Istanbul (Turkyie)"
                flightBasePrice = 900.0
            Case "Ontario (Canada)"
                flightBasePrice = 450.0
            Case "Moscow (Russia)"
                flightBasePrice = 600.0
            Case "Kyiv (Ukraine)"
                flightBasePrice = 570.0
            Case "Warsaw (Poland)"
                flightBasePrice = 860.0
            Case "Barcalona (Spain)"
                flightBasePrice = 750.0
            Case "New York (USA)"
                flightBasePrice = 704.0
            Case "California (USA)"
                flightBasePrice = 509.0
            Case "Nairobi (Kenya)"
                flightBasePrice = 670.0
            Case "Tel Aviv (Israel)"
                flightBasePrice = 874.0
            Case Else
                flightBasePrice = 300.0
        End Select

        ' 5. Apply class multipliers
        Dim travelClass As String = ""
        If radFirstClass.Checked Then
            travelClass = "First Class"
            flightBasePrice *= 3.0
        ElseIf radBusinessClass.Checked Then
            travelClass = "Business Class"
            flightBasePrice *= 2.0
        Else
            travelClass = "Economy"
        End If

        ' 6. Calculate total for all passengers (1 Main passenger + extracted list length count)
        Dim totalPassengersCount As Integer = 1 + extraPassengersList.Count
        Dim finalTotalCost As Double = flightBasePrice * totalPassengersCount

        ' 7. AUTO-GENERATE TICKETING AND ADVANCED MANIFEST VALUES
        Dim bookingPNR As String = GenerateBookingReference()
        Dim passengerSeatsManifest As String = GeneratePassengerManifest(travelClass, extraPassengersList)

        ' 8. Generate the complete booking summary receipt window text layout
        Dim receiptSummary As String = String.Format(
            "==========================================" & Environment.NewLine &
            "            BOARDING PASS VOUCHER          " & Environment.NewLine &
            "==========================================" & Environment.NewLine &
            "BOOKING REF (PNR): {0}" & Environment.NewLine &
            "CABIN CLASS      : {1}" & Environment.NewLine &
            "FLIGHT DATE      : {2}" & Environment.NewLine &
            "------------------------------------------" & Environment.NewLine &
            "PASSENGER SEATING MANIFEST: " & Environment.NewLine &
            "{3}" & Environment.NewLine &
            "------------------------------------------" & Environment.NewLine &
            "AGE / CONTACT    : Age {4} | Ph: {5}" & Environment.NewLine &
            "ROUTE ROUTING    : {6} ---> {7}" & Environment.NewLine &
            "TOTAL TRAVELERS  : {8}" & Environment.NewLine &
            "------------------------------------------" & Environment.NewLine &
            "FINAL TOTAL PAID : ${9:F2}" & Environment.NewLine &
            "==========================================",
            bookingPNR,
            travelClass,
            dtpDeparture.Value.ToShortDateString(),
            passengerSeatsManifest,
            txtAge.Text,
            txtPhoneNumber.Text,
            txtCityOfOrigin.Text.ToUpper(),
            cmbDestination.Text.ToUpper(),
            totalPassengersCount,
            finalTotalCost
        )

        ' 9. Display the comprehensive digital boarding pass confirmation ticket screen
        MessageBox.Show(receiptSummary, "Electronic Ticket Issued", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Optional Input Guard: Force numeric entry on Age field automatically
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class