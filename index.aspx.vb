
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub Clear_Click(sender As Object, e As System.EventArgs) Handles Clear.Click
        ' clear all input and output textbox and label
        hourlyWage.Text = ""
        numberOfHours.Text = ""
        pretaxDeduction.Text = ""
        aftertaxDeduction.Text = ""
        resultLable.Text = ""
    End Sub

    Protected Sub calculate_Click(sender As Object, e As System.EventArgs) Handles calculate.Click
        ' declare variables to contain user entered input
        Dim wage As Decimal = hourlyWage.Text
        Dim hour As Decimal = numberOfHours.Text
        Dim pretaxD As Decimal = pretaxDeduction.Text
        Dim afterD As Decimal = aftertaxDeduction.Text
        'create constant variable for tax rate
        Const tax As Decimal = 0.18

        'declare a variable to contain result
        Dim result As Decimal

        'calculate before tax and deduction salary
        Dim salary As Decimal
        'if hour is lower than 40, just multiple the hour and hourly wage
        If hour <= 40 Then
            salary = hour * wage
        Else 'if hour is bigger than 40, than calculate the 40 hours salary and the over-time salary
            salary = 40 * wage + (hour - 40) * wage * 1.5
        End If

        'calculate after pre-tax deduction salary
        Dim preSalary As Decimal = salary - pretaxD

        'calculate the after tax salary
        Dim taxedSalary As Decimal = preSalary - preSalary * tax

        'calculate the final result
        result = taxedSalary - afterD

        'display the result
        resultLable.Text = "Your net pay is " & String.Format("{0:C}", result)

    End Sub
End Class
