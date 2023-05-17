﻿'Program Name: StarterExample
'Programmer  : b_crocker
'Date		 : 2/26/2021 2:36:00 PM
'Purpose     : FILL OUT HERE!!!

'Test Cases:
'
'
'
'
'
'
'
'


Option Strict On

Public Class StarterExample

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        'This code is run whenever the clear button is pressed

        'Insert your code for clearing here

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        '(Insert what it does after that here)

        If CheckAllValid() Then

            'Enter code to run when everything is valid here

        End If

    End Sub

    Private Function CheckAllValid() As Boolean
        'Use this code to check if all TextFields are valid
        'It loops through each text field and checks if its valid
        'If any are invalid, it will return false

        Dim blnIsValid As Boolean = True

        For Each txtField As Fields.TextField In Controls.OfType(Of Fields.TextField)

            txtField.Validate()

            If txtField.IsValid() <> True Then

                blnIsValid = False

            End If


        Next

        Return blnIsValid

    End Function

    Private Sub StarterExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts

        'Initialize fields and other stuff here

    End Sub

End Class
