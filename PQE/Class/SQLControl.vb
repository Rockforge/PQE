Imports MySql.Data.MySqlClient

Public Class SQLControl

    Public Shared sqlConn As New MySqlConnection ' With {.ConnectionString = "server=localhost; database=db_dost; userid=root; allowuservariables=true"}
    Public sqlCommand As MySqlCommand
    Public sqlDataAdapter As MySqlDataAdapter
    Public sqlDataSet As DataSet

    'Query parameters
    Public param As New List(Of MySqlParameter)
    Dim query As String

    'Stores record count
    Public recordCount As Integer


    Public Shared Sub TestConnection()
        Try
            sqlConn.Open()
            MessageBox.Show("Connection successful")
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    'add Param
    Public Sub AddParam(name As String, value As Object)
        Dim _newParam As New MySqlParameter(name, value)
        param.Add(_newParam)
    End Sub

    'execute query sub
    Public Sub ExecuteQuery(query As String)
        recordCount = 0
        Try
            sqlConn.Open()
            'Create's our db command
            sqlCommand = New MySqlCommand(query, sqlConn)

            'Lambda expression
            param.ForEach(Sub(p) sqlCommand.Parameters.Add(p))

            'Clears the list
            param.Clear()

            sqlDataAdapter = New MySqlDataAdapter(sqlCommand)
            sqlDataSet = New DataSet()

            'Gets the number of record
            recordCount = sqlDataAdapter.Fill(sqlDataSet)

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            param.Clear()
        Finally
            sqlConn.Dispose()
        End Try
    End Sub



End Class
