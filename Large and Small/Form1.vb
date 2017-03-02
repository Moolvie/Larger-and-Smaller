Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        ' Declare variable
        Dim intNumberA As Integer
        Dim intNumberB As Integer

        If Integer.TryParse(txtIntA.Text, intNumberA) Then
            ' Check second number
            If Integer.TryParse(txtIntB.Text, intNumberB) Then
                'Compare the integers
                If intNumberA > intNumberB Then
                    lblMessage.Text = " Value A is greatest."
                ElseIf intNumberA < intNumberB Then
                    lblMessage.Text = " Value B is greatest."
                Else
                    lblMessage.Text = " The Values are equal."
                End If
            Else
                ' Display error message
                lblMessage.Text = " you must enter an integer for B"
            End If
        Else
            ' display error message for A
            lblMessage.Text = "you must enter an integer for A"
        End If
    End Sub
End Class
