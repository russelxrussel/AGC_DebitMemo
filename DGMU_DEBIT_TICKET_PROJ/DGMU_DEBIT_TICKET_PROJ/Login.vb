
Public Class Login
    Dim oSystem As New DMT_SYSTEM_C

    Dim dt As New DataTable
    

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dt = oSystem.GET_USER_DATA()
    End Sub


    
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUserName.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("Please Fill up username and password")
            txtUserName.Focus()
            Exit Sub
        Else
            Dim dv As New DataView
            dv = dt.DefaultView

            dv.RowFilter = "Usercode ='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'"

            If dv.Count > 0 Then
                txtUserName.Text = ""
                txtPassword.Text = ""

                For Each rowView As DataRowView In dv
                    frmMain.lnkUserName.Text = rowView("UserName").ToString()
                    frmMain.tsUserCode.Text = rowView("UserCode").ToString()

                    frmMain.ACCESSTYPE = rowView("Account_Type_Code").ToString
                Next

                Me.Hide()
                frmMain.Show()

            Else
                MsgBox("not valid")
            End If
        End If
       
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUserName.Focus()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        End
    End Sub
End Class