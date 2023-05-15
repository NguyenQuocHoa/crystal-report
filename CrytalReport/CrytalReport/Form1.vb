Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlConn As MySqlConnection
    Dim LstCustomer As New List(Of CustomerDTO)
    Private Sub btnCheckConn_Click(sender As Object, e As EventArgs) Handles btnCheckConn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=12345678;database=lt_java"
        Try
            MySqlConn.Open()
            MessageBox.Show("Connect Successful")
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnCountCustomer_Click(sender As Object, e As EventArgs) Handles btnCountCustomer.Click, btnPrint.Click
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM lt_java.customer"
            Dim COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim Count As Integer
            Count = 0
            While READER.Read
                Count += 1
            End While
            MessageBox.Show("Number of customer is: " & Count)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT id, address, code FROM lt_java.customer"
            Dim COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            LstCustomer = New List(Of CustomerDTO)
            While READER.Read
                Dim customer As CustomerDTO = New CustomerDTO()
                customer.Address = READER("address").ToString
                customer.Code = READER("code").ToString
                LstCustomer.Add(customer)
            End While
            DgvCustomer.DataSource = LstCustomer
            MessageBox.Show("Number of customer is: " & LstCustomer.Count.ToString)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class
