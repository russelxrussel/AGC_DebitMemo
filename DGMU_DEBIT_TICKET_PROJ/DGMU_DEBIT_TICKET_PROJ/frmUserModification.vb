Public Class frmUserModification
    Dim oSystem As New DMT_SYSTEM_C

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewPassword.Focus()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtNewPassword.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please Fill up required field.", vbExclamation, "Aces of Grace Corporation")

            Exit Sub
        ElseIf txtNewPassword.Text = txtPassword.Text Then
            'Execute update password
            oSystem.UPDATE_USER_PASSWORD(frmMain.tsUserCode.Text, txtNewPassword.Text)
            MsgBox("New Password successfully updated.", vbInformation, "Aces of Grace Corporation")
            Me.Close()
        Else
            MsgBox("Mismatch password", vbExclamation, "Aces of Grace Corporation")
            Exit Sub
        End If
    End Sub
End Class