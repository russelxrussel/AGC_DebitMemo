Imports System.IO

Public Class frmCA_RequestForm
    Dim oSystem As New System_C
    Dim oEmployee As New Employee_C

    Private Sub frmCA_RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initState()

        'Display List of Requestee
        displayEmployeeList()

    End Sub

    Private Sub initState()
        dtRequestDate.Value = oSystem.GET_SERVER_DATE_TIME()
    End Sub

    Private Sub displayEmployeeList()
        Dim dt As DataTable = oEmployee.GET_EMPLOYEE_LIST

        Dim dr As DataRow = dt.NewRow()
        dr("EmployeeName") = "---Select Requestee---"
        dr("EmpCode") = 0
        dt.Rows.InsertAt(dr, 0)

        With cmbRequestee
            .DataSource = dt
            .DisplayMember = dt.Columns("EmployeeName").ToString()
            .ValueMember = dt.Columns("EmpCode").ToString()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image (*.jpg;*.png ) | *.jpg; *.png"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.ImageLocation = opf.FileName
            TextBox3.Text = opf.FileName
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bAttachment As Byte() = IO.File.ReadAllBytes(TextBox3.Text)

        oEmployee.INSERT_EMPLOYEE_PHOTO(cmbRequestee.SelectedValue.ToString(), bAttachment)
        MessageBox.Show("Save")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'DISPLAY REQUESTEE PHOTO
        Dim empPhoto As Byte() = oEmployee.GET_EMPLOYEE_PHOTO(cmbRequestee.SelectedValue)
        If Not empPhoto Is Nothing Then
            Using ms As New MemoryStream(empPhoto, 0, empPhoto.Length)
                ms.Write(empPhoto, 0, empPhoto.Length)
                PictureBox1.Image = Image.FromStream(ms, True)
            End Using
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub cmbRequestee_Leave(sender As Object, e As EventArgs) Handles cmbRequestee.Leave
        'DISPLAY REQUESTEE PHOTO
        Dim empPhoto As Byte() = oEmployee.GET_EMPLOYEE_PHOTO(cmbRequestee.SelectedValue)
        If Not empPhoto Is Nothing Then
            Using ms As New MemoryStream(empPhoto, 0, empPhoto.Length)
                ms.Write(empPhoto, 0, empPhoto.Length)
                PictureBox1.Image = Image.FromStream(ms, True)
            End Using
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class