Public Class Form1


    'Declare global vars above the buttons
    '*************************************
    Dim tokens As Integer
    'This variable will be seen in all
    'subs and will never be reset to 0
    '(unless you tell it to)


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Relational operators are used to compare two
        'values. They give a BOOLEAN (true/false) result

        'Relational operators: <, >, =, <>, <=, >=

        Label2.Text = (5 < 2) 'Puts 'false' in the label
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If-Then
        '**********
        'If-thens use a BOOLEAN expression to make a choice
        'and then act based on that choice
        Dim temp As Integer
        temp = TextBox1.Text

        If temp >= 1000 Then
            Label2.Text = "Warning - temp is too high"
        End If
    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If/Else
        '**********
        'The ELSE clause represents an alternative action
        'for when the BOOLEAN expression is false
        'You can only have one 'else'
        Dim temp As Integer
        temp = TextBox1.Text

        If temp > 1000 Then
            Label2.Text = "Warning - temp is too high"
        Else
            Label2.Text = "Temp is OK"
        End If
    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If/Else If/Else
        '***************
        'In addition to IF and ELSE, the optional ELSE IF
        'clause allows us to check additional conditions

        'The code will work from top to bottom and will stop as
        'soon as it finds one condition that is true

        'You can have 0 to infinite else ifs

        Dim temp As Integer
        temp = TextBox1.Text

        If temp > 1200 Then
            Label2.Text = "Sweet Merciful Crap!"
            Label2.ForeColor = Color.Red
        ElseIf temp > 1000 Then
            Label2.Text = "Warning - temp too high"
            Label2.ForeColor = Color.Orange
        ElseIf temp > 800 Then
            Label2.Text = "Getting warmer..."
            Label2.ForeColor = Color.Yellow
        Else
            Label2.Text = "Temp is OK"
            Label2.ForeColor = Color.Green
        End If

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'The LOGICAL OPERATORS let you look at two
        'or more conditions in a single if
        Dim temp As Integer
        temp = TextBox1.Text

        'AND checks to see if both (all) conditions
        'are true
        If temp > 0 And temp <= 800 Then
            MsgBox("Temp OK")
        End If

        'OR checks to see if any of the conditions
        'are true
        If temp < 0 Or temp > 2000 Then
            MsgBox("Invalid input")
        End If
    End Sub




    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'When you make a variable under a button
        'it is created when the button is clicked and
        'destroyed afterwards
        'Dim tokens As Integer

        tokens = tokens + 10 'Increase tokens by 10
        MsgBox(tokens)

        'tokens will now be destroyed UNLESS
        'we make the variable GLOBAL
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'make some numbers at random
        '****************************
        '1. Make the random number generator
        Dim r As New Random 'r is a random number factory

        '2. Create two random numbers
        Dim num1, num2 As Integer
        num1 = r.Next(0, 11) '0-10
        num2 = r.Next(1, 100) '1-99
        'Note: the 2nd number in the range is NON-INCLUSIVE

        MsgBox(num1 & " " & num2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this stuff happens before the app runs
        MsgBox("Welcome to the If-Then notes!")
        tokens = 100
    End Sub





    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Write a program that takes input from the textbox
        'and uses an if/else to determine if the number is
        'positive or negative (zero counts as positive for this)
        'Display "positive" or "negative" in the label

        Dim num As Integer
        num = TextBox1.Text

        If num >= 0 Then
            Label2.Text = "Positive"
        Else
            Label2.Text = "Negative"
        End If




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Write a program that takes input from the textbox
        'representing a restaurant check. Display the tip in the
        'label. The tip should be 15% of the check, with a minimum 
        'of $3. 

        'The code is mostly done. Add an if statement
        'that changes the tip to 3 if necessary
        Dim check, tip As Double
        check = TextBox1.Text 'Input
        tip = check * 0.15 'Compute

        If tip < 3 Then
            tip = 3
        End If

        Label2.Text = tip 'Output


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Write a program where the user will enter the percentage
        'of cloud cover in the sky (e.g. 50 means 50% cloudy)
        'In the label, display the sky conditions as follows:
        '0-30 clear, 31-70 partly cloudy, 71-99 cloudy, 100 overcast

        Dim clouds As Integer
        clouds = TextBox1.Text

        If clouds >= 0 And clouds < 31 Then
            Label2.Text = "clear"
        ElseIf clouds >= 31 And clouds < 70 Then
            Label2.Text = "partly cloudy"
        ElseIf clouds >= 71 And clouds <= 99 Then
            Label2.Text = "cloudy"
        Else
            Label2.Text = "overcast"
        End If


    End Sub













    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'We can use if-statements to determine if checkboxes
        'and radiobuttons are checked

        If CheckBox1.Checked = True Then
            MsgBox("The box is checked!")
        End If

        If RadioButton1.Checked = False Then
            MsgBox("The radiobutton is NOT checked")
        End If

    End Sub
End Class
