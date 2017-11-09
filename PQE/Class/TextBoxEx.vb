Imports System
Imports System.Text.RegularExpressions

Public Class TextBoxEx
    Inherits TextBox

    Private Sub TextBoxEx_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.BackColor = Color.LightCyan
    End Sub

    Function EmailAddressCheck(ByVal emailAddress As String, examineeDateID As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        'Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then

            ' Check if existing Email
            If AdminDashboard.CheckEmailIfExisting(emailAddress, examineeDateID) Then
                Me.BackColor = Color.Orange
                MessageBox.Show("Email Address already existing.")
                EmailAddressCheck = False
                Exit Function
            End If

            Me.BackColor = Color.LightGreen
            EmailAddressCheck = True
        Else
            Me.BackColor = Color.FromArgb(250, 160, 122)
            EmailAddressCheck = False
        End If
    End Function

    Function NameCheck(ByVal name As String)
        ' Original Regex Pattern = ^[a-zA-ZÑñ'-]+$
        ' New Regex Pattern = ^[a-zA-Z_]+( [a-zA-Z_]+)*$
        ' New Regex Pattern is to catch single space between names
        Dim pattern As String = "^[a-zA-Z_]+( [a-zA-Z_]+)*$"
        Dim nameMatch As Match = Regex.Match(name, pattern)
        If nameMatch.Success Then
            Me.BackColor = Color.LightGreen
            Return True
        Else
            Me.BackColor = Color.FromArgb(250, 160, 122)
            Return False
        End If
    End Function

    Sub GoGreen()
        Me.BackColor = Color.LightGreen
    End Sub

    Sub GoWhite()
        Me.BackColor = Color.White
    End Sub

End Class
