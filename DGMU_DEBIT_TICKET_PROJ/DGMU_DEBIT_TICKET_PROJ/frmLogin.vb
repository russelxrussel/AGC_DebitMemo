Public Class frmLogin
    Dim oSystem As New DMT_SYSTEM_C

    Dim dt As New DataTable


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        tsCopyright.Text = "Developed by: " & My.Application.Info.Copyright.ToString()
    End Sub

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        dt = oSystem.GET_USER_DATA()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please Fill up username and password", vbExclamation, "Aces of Grace Corporation")
            txtUsername.Focus()
            Exit Sub
        Else
            Dim dv As New DataView
            dv = dt.DefaultView

            dv.RowFilter = "Usercode ='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'"

            If dv.Count > 0 Then
                txtUsername.Text = ""
                txtPassword.Text = ""

                For Each rowView As DataRowView In dv
                    frmMain.lnkUserName.Text = rowView("UserName").ToString()
                    frmMain.tsUserCode.Text = rowView("UserCode").ToString()

                    frmMain.ACCESSTYPE = rowView("Account_Type_Code").ToString
                Next

                Me.Hide()
                frmMain.Show()

            Else
                MsgBox("Invalid username and password", vbExclamation, "Aces of Grace Corporation")
            End If
        End If
    End Sub
End Class