'Program Name: FoodTruck
'Programmer  : #203
'Date	     : 10-28-21
'Purpose     : Allow the user to buy food from a food truck. Then, the business manager can view various statistics about the business day


Option Strict On

Public Class FoodTruck

    Private ReadOnly Property dicMenu As New Dictionary(Of String, Decimal) From {
        {"Hot Dog", 2.25D},
        {"Hot Dog w/ fried peppers & onions", 4.5D},
        {"Hamburger", 3D},
        {"Cheeseburger", 3.5D},
        {"Fries", 2.5D},
        {"Soda", 2D},
        {"Water", 1.5D}
    }
    Private Property dicCurrentCart As New Dictionary(Of String, Integer)
    Private Property dicTotalItemsSold As New Dictionary(Of String, Integer)
    Private Property decTotalSales As Decimal = 0D
    Private Property decTotalTips As Decimal = 0D
    Private Property intTotalCustomers As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub CartInfo(ByRef decSubTotal As Decimal, ByRef decTip As Decimal, ByRef decTotal As Decimal)
        'This Sub gives infomration about the Cart
        'It gives back the SubTotal, Tip, and Total

        decSubTotal = 0D

        For Each kvpItemQuantity As KeyValuePair(Of String, Integer) In dicCurrentCart

            decSubTotal += dicMenu(kvpItemQuantity.Key) * kvpItemQuantity.Value

        Next

        decTip = decSubTotal * (txtTip.Value / 100)
        decTotal = decSubTotal + decTip

    End Sub

    Private Sub DisplayCart()
        'This Sub takes the dicCurrentCart dictionary and displays it in the listbox
        'It loops through every key in the dictionary, checking if the user has bought any of them
        'If the user has, it will add it to the lstCart ListBox and display the amount
        'It then updates the Labels with new sub totals, totals, and tips

        Dim intCurrentSelected As Integer = lstCart.SelectedIndex

        lstCart.Items.Clear()

        For Each kvpItemQuantity As KeyValuePair(Of String, Integer) In dicCurrentCart

            If kvpItemQuantity.Value <> 0 Then

                lstCart.Items.Add(kvpItemQuantity.Key & " | x" & kvpItemQuantity.Value.ToString())

            End If

        Next

        Dim decSubTotal, decTip, decTotal As Decimal
        CartInfo(decSubTotal, decTip, decTotal)

        lblSubTotal.Text = "Sub Total: " & decSubTotal.ToString("c")
        lblTax.Text = "Tip: " & decTip.ToString("c") & " (" & txtTip.Value.ToString() & "%)"
        lblTotal.Text = "Total: " & decTotal.ToString("c")

        If intCurrentSelected <> -1 AndAlso intCurrentSelected <= lstCart.Items.Count() - 1 Then

            lstCart.SelectedIndex = intCurrentSelected

        End If

    End Sub

    Private Sub ClearCart()
        'This procedure clears the Cart

        For Each strItem As String In dicMenu.Keys

            dicCurrentCart(strItem) = 0

        Next

        DisplayCart()

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'This code is run whenever the checkout button is clicked
        'It first gets info about the Cart
        'If the user hasn't put anything in their cart, we tell them to
        'Otherwise, we add th values to the running totals and say goodbye to the user
        'Finally, we clear the cart for the next user

        Dim decSubTotal, decTip, decTotal As Decimal
        CartInfo(decSubTotal, decTip, decTotal)

        If decSubTotal > 0 Then

            decTotalSales += decSubTotal
            decTotalTips += decTip
            intTotalCustomers += 1

            For Each strItem In dicCurrentCart.Keys

                dicTotalItemsSold(strItem) += dicCurrentCart(strItem)

            Next

            MsgBox("Your total is " & decTotal.ToString("c") & ". Thank you for your purchase!", , "Thank You")

            ClearCart()
            txtTip.Value = 20

        Else

            MsgBox("Please put at least one item in your cart first!", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Private Sub FoodTruck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It sets up items for our menu

        For Each kvpItemPrice As KeyValuePair(Of String, Decimal) In dicMenu

            lstMenu.Items.Add($"{kvpItemPrice.Key} : {kvpItemPrice.Value.ToString("c")}")
            dicTotalItemsSold.Add(kvpItemPrice.Key, 0)
            dicCurrentCart.Add(kvpItemPrice.Key, 0)

        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This code is run when the Add To Cart button is pressed
        'It adds the requested item to the cart and then updates the totals

        If lstMenu.SelectedIndex <> -1 Then

            Dim strSelectedItem As String = lstMenu.SelectedItem.ToString().Split(":"c)(0).TrimEnd()
            dicCurrentCart(strSelectedItem) += 1
            DisplayCart()

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'This code is run when the Remove From Cart button is pressed
        'It removes the requested Item from the cart and then updates the totals

        If lstCart.SelectedIndex <> -1 Then

            Dim strSelectedItem As String = lstCart.SelectedItem.ToString().Split("|"c)(0).TrimEnd()
            dicCurrentCart(strSelectedItem) -= 1
            DisplayCart()

        End If

    End Sub

    Private Sub btnCartClear_Click(sender As Object, e As EventArgs) Handles btnCartClear.Click
        'This code is run when the Clear Cart button is clicked
        'It clears the cart

        ClearCart()

    End Sub

    Private Sub txtTax_ValueChanged(sender As Object, e As EventArgs) Handles txtTip.ValueChanged
        'This code is run when the user changes the tax
        'It updates the totals

        DisplayCart()

    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        'This code is run when the End menu item is pressed
        'It first confirms that the user wishes to end the day
        'If the user says yes, we display all the totals that we counted throughout the day.
        'Once the user is done looking, they can press "Ok" to exit the program

        Dim msgResult As MsgBoxResult = MsgBox("End the business day?", MsgBoxStyle.YesNo, "End Day")

        If msgResult = MsgBoxResult.Yes Then

            Dim strTotalItemsSold As String = ""

            For Each kvpItemQuantity As KeyValuePair(Of String, Integer) In dicTotalItemsSold

                strTotalItemsSold &= Environment.NewLine & kvpItemQuantity.Key & ": " & kvpItemQuantity.Value.ToString()

            Next

            ClearCart()

            MsgBox("Total Customers: " & intTotalCustomers.ToString() & Environment.NewLine _
                & "Total Sales (without tips): " & decTotalSales.ToString("c") & Environment.NewLine _
                & "Total Tips: " & decTotalTips.ToString("c") & Environment.NewLine _
                & "Total Sales: " & (decTotalSales + decTotalTips).ToString("c") & Environment.NewLine & Environment.NewLine _
                & "Total Of Each Item Sold: " & strTotalItemsSold & Environment.NewLine & Environment.NewLine _
                & "Press Ok to Exit", MsgBoxStyle.Information, "Day Complete")

            Close()

        End If

    End Sub

End Class
