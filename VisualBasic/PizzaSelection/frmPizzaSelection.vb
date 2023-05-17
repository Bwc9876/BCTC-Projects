' Program Name: Pizza Selection
' Developer:    Ben Crocker
' Date:         September 3rd, 2020
' Purpose:      This application displays two pizza types
'               (Deep Dish and Thin Crust). The user can select a pizza type 

Public Class frmPizzaSelection
    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        ' This code is executed when the user clicks taps or clicks
        ' the Deep Dish button. It displays the Deep Dish picture,
        ' hides the Thin Crust picture, and enables the Select
        ' Pizza button.

        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user taps or clicks the Exit Window
        ' button. It closes the window and terminates the program execution

        Close()

    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        ' This code is executed when the user clicks taps or clicks
        ' the Thin Crust button. It hides the Deep Dish picture,
        ' displays the Thin Crust picture, and enables the Select
        ' Pizza button.

        picDeepDish.Visible = False
        picThinCrust.Visible = True
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        ' This code is executed when the user clicks taps or clicks
        ' the Select Pizza button. It disables the Deep Dish button,
        ' disables the Thin Crust button, disables the Select Pizza button,
        ' hides the Instructions label, displays the Confirmation Message,
        ' and enables the Exit button.

        btnDeepDish.Enabled = False
        btnSelectPizza.Enabled = False
        btnThinCrust.Enabled = False
        lblDirections.Visible = False
        lblEnjoy.Visible = True
        btnExit.Enabled = True

    End Sub
End Class
