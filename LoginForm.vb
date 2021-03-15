Public Class LoginForm
    Private Sub OpenRegisterFormLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OpenRegisterFormLinkLabel.LinkClicked
        RegisterForm.ShowDialog()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Select()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        With ShowPasswordCheckBox
            If .Checked Then
                PasswordTextBox.UseSystemPasswordChar = False
            Else
                PasswordTextBox.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Not String.IsNullOrEmpty(UsernameTextBox.Text) And
                Not String.IsNullOrEmpty(PasswordTextBox.Text) Then

            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM UserLogin "
            SQL &= "WHERE Username = '" & UsernameTextBox.Text & "' "
            SQL &= "AND Password = '" & PasswordTextBox.Text & "' "

            Dim UserData As DataTable = ExecuteSQL(SQL)

            If UserData.Rows.Count > 0 Then

                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                ShowPasswordCheckBox.Checked = False

                Me.Hide()

                Dim formMain As New MainForm()
                formMain.ShowDialog()
                formMain = Nothing

                Me.Show()
                Me.UsernameTextBox.Select()

            Else
                MsgBox("The Username or Password is incorrect. Try again.", MsgBoxStyle.Critical, "Login Form : ")
                UsernameTextBox.Focus()
                UsernameTextBox.SelectAll()
            End If

        Else
            MsgBox("Please enter Username and Password.", MsgBoxStyle.Critical, "Login Form : ")
        End If
    End Sub
End Class