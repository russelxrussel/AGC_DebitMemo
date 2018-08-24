Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class Employee_C
    Inherits Base_C


    Public Function GET_GENDER_LIST() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_GENDER_LIST]")
        Return dt
    End Function

    Public Function GET_MARITAL_STATUS_LIST() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_MARITAL_STATUS_LIST]")
        Return dt
    End Function
    Public Function GET_JOB_POSITION_LIST() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_JOB_POSITION_LIST]")
        Return dt
    End Function

    Public Function GET_DEPARTMENT_LIST() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_DEPARTMENT_LIST]")
        Return dt
    End Function

    Public Function GET_EMPLOYMENT_STATUS_LIST() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_EMPLOYMENT_STATUS_LIST]")
        Return dt
    End Function

    Public Function GET_EMPLOYEE_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[HR].[spGET_EMPLOYEE_LIST]")
        Return dt
    End Function

    Public Function GET_EMPLOYEE_LIST_FOR_DISPLAY() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[HR].[spGET_EMPLOYEE_LIST_DISPLAY]")
        Return dt
    End Function

    Public Function GET_EMPLOYEE_PHOTO(ByVal _empCode As String) As Byte()
        Dim photo As Byte()

        Using cn As New SqlConnection(_CONSTRING)
            Dim cmd As New SqlCommand("[HR].[spGET_EMPLOYEE_PHOTO]", cn)

            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@EMPCODE", _empCode)
            End With


            cn.Open()


            If IsDBNull(cmd.ExecuteScalar) Then
                photo = Nothing
            Else
                photo = DirectCast(cmd.ExecuteScalar, Byte())
            End If

        End Using


        Return photo
    End Function



#Region "DB CREATE / UPDATE"

    'INSERT NEW EMPLOYEE WITH PHOTO
    Public Sub INSERT_EMPLOYEE_INFORMATION(ByVal _empCode As String, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String,
                                           ByVal _suffix As String, ByVal _birthDate As DateTime, ByVal _genderCode As String,
                                           ByVal _maritalCode As String,
                                           ByVal _tin As String, ByVal _sss As String, ByVal _hdmf As String, ByVal _philHealth As String,
                                           ByVal _dateHired As DateTime, ByVal _companyCode As String, ByVal _jpCode As String, ByVal _departmentCode As String,
                                           ByVal _employmentStatusCode As String,
                                           ByVal _photoFileSize As Integer, ByVal _empPhoto As Byte())

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[HR].[spINSERT_EMPLOYEE_INFORMATION]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@EMPCODE", _empCode)
                    .Parameters.AddWithValue("@LASTNAME", _lastName)
                    .Parameters.AddWithValue("@FIRSTNAME", _firstName)
                    .Parameters.AddWithValue("@MIDDLENAME", _middleName)
                    .Parameters.AddWithValue("@SUFFIX", _suffix)
                    .Parameters.AddWithValue("@BIRTHDATE", _birthDate)
                    .Parameters.AddWithValue("@GENDERCODE", _genderCode)
                    .Parameters.AddWithValue("@MARITALCODE", _maritalCode)
                    .Parameters.AddWithValue("@TIN", _tin)
                    .Parameters.AddWithValue("@SSS", _sss)
                    .Parameters.AddWithValue("@HDMF", _hdmf)
                    .Parameters.AddWithValue("@PHILHEALTH", _philHealth)
                    .Parameters.AddWithValue("@DATEHIRED", _dateHired)
                    .Parameters.AddWithValue("@COMPANYCODE", _companyCode)
                    .Parameters.AddWithValue("@JPCODE", _jpCode)
                    .Parameters.AddWithValue("@DEPARTMENTCODE", _departmentCode)
                    .Parameters.AddWithValue("@EMPLOYMENTSTATUS", _employmentStatusCode)
                    .Parameters.AddWithValue("@PHOTOFILESIZE", _photoFileSize)
                    .Parameters.AddWithValue("@EMPPHOTO", _empPhoto)

                End With

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UPDATE_EMPLOYEE_INFORMATION(ByVal _empCode As String, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String,
                                           ByVal _suffix As String, ByVal _birthDate As DateTime, ByVal _genderCode As String,
                                           ByVal _maritalCode As String,
                                           ByVal _tin As String, ByVal _sss As String, ByVal _hdmf As String, ByVal _philHealth As String,
                                           ByVal _dateHired As DateTime, ByVal _companyCode As String, ByVal _jpCode As String, ByVal _departmentCode As String,
                                           ByVal _employmentStatusCode As String,
                                           ByVal _isPhotoChange As Boolean, ByVal _empPhoto As Byte())

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[HR].[spUPDATE_EMPLOYEE_INFORMATION]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@EMPCODE", _empCode)
                    .Parameters.AddWithValue("@LASTNAME", _lastName)
                    .Parameters.AddWithValue("@FIRSTNAME", _firstName)
                    .Parameters.AddWithValue("@MIDDLENAME", _middleName)
                    .Parameters.AddWithValue("@SUFFIX", _suffix)
                    .Parameters.AddWithValue("@BIRTHDATE", _birthDate)
                    .Parameters.AddWithValue("@GENDERCODE", _genderCode)
                    .Parameters.AddWithValue("@MARITALCODE", _maritalCode)
                    .Parameters.AddWithValue("@TIN", _tin)
                    .Parameters.AddWithValue("@SSS", _sss)
                    .Parameters.AddWithValue("@HDMF", _hdmf)
                    .Parameters.AddWithValue("@PHILHEALTH", _philHealth)
                    .Parameters.AddWithValue("@DATEHIRED", _dateHired)
                    .Parameters.AddWithValue("@COMPANYCODE", _companyCode)
                    .Parameters.AddWithValue("@JPCODE", _jpCode)
                    .Parameters.AddWithValue("@DEPARTMENTCODE", _departmentCode)
                    .Parameters.AddWithValue("@EMPLOYMENTSTATUS", _employmentStatusCode)
                    .Parameters.AddWithValue("@ISPHOTOCHANGE", _isPhotoChange)
                    .Parameters.AddWithValue("@EMPPHOTO", _empPhoto)


                End With

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub INSERT_EMPLOYEE_PHOTO(ByVal _empCode As String, ByVal _empPhoto As Byte())
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[HR].[spINSERT_EMPLOYEE_PHOTO]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@EMPCODE", _empCode)
                    .Parameters.AddWithValue("@EMPPHOTO", _empPhoto)
                End With

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using


    End Sub
#End Region
End Class
