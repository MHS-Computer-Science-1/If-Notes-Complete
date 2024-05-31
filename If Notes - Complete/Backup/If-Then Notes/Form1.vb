Public Class Form1
    'Declare global vars above the subs
    '**********************************
    Dim globalVar As Integer
    'This variable will be usable in all
    'subs and will never be reset to 0
    '(unless you tell it to)

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Relational operators are used to compare two
        'values with a result of true or false (boolean)

        'Relational operators: <, >, =, <>, <=, >=

        Label1.Text = 5 > 2
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If-Then
        '**********

        'If-thens use a boolean expression to make a choice
        'and then act based on that choice
        Dim temp As Integer
        temp = TextBox1.Text

        If temp > 1000 Then
            Label1.Text = "Warning - temp is too high"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If/Else
        '**********

        'The else clause represents an alternative action
        'for when the boolean expression is false
        'You can only have one 'else'
        Dim temp As Integer
        temp = TextBox1.Text

        If temp > 1000 Then
            Label1.Text = "Warning - temp is too high"
        Else
            Label1.Text = "Temp is OK"
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If/Else If/Else
        '***************
        'In addition to if and else, the optional else if
        'clause allows us to check additional conditions

        'VB will work from top to bottom and will stop as
        'soon as it finds one condition that is true

        'You can have 0 to infinite else ifs

        Dim temp As Integer
        temp = TextBox1.Text

        If temp > 1200 Then
            Label1.Text = "Warning - DEATH"
        ElseIf temp > 1000 Then
            Label1.Text = "Warning -  temp too high"
        ElseIf temp > 800 Then
            Label1.Text = "getting warmer..."
        Else
            Label1.Text = "Temp is OK"
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'The LOGICAL OPERATORS let you look at two
        'or more conditions in a single if

        Dim temp As Integer
        temp = TextBox1.Text

        '"And" checks to see if both (all) conditions
        'are true
        If temp > 0 And temp <= 800 Then
            MsgBox("Temp OK")
        End If

        '"Or" checks to see if any of the conditions
        'are true
        If temp < 0 Or temp > 2000 Then
            MsgBox("Invalid input")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim localVar As Integer

        localVar = localVar + 10
        globalVar = globalVar + 10
        MsgBox("localvar: " & localVar)
        MsgBox("globalvar: " & globalVar)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'make some numbers at random
        '****************************

        '1. Make the random number generator
        Dim r As New Random

        '2. Create two random numbers
        Dim num1, num2 As Integer
        num1 = r.Next(0, 11) '0-10
        num2 = r.Next(1, 100) '1-99
        'Note: 1 higher on 2nd number

        MsgBox(num1 & " " & num2)
    End Sub
End Class
