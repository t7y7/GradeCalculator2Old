Public Class Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private logincounter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim admin As String = "Justine"
        Dim password As String = "123"

        If TxtUsername.Text = admin And TxtPass.Text = password Then
            MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form2.Show()
        Else

            logincounter += 1
            Dim remaining As Integer = 3 - logincounter

            If logincounter >= 3 Then

                MessageBox.Show("Maximum attempts reached. System shutting down.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Application.Exit()

            Else


                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUsername.Clear()
                TxtPass.Clear()
                TxtUsername.Focus()

            End If

        End If
    End Sub
End Class