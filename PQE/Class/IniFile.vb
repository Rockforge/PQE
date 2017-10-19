Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Math
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Public Class IniFile

    ' credits to felixLindemann on CodeProject.com

    Private _strFileName As String
    Private _strIniArgumentsBegins As String = "[Arguments]"
    Private _strPrefix As String
    Private _dataTable As DataTable
    Private _dataSet As DataSet
    Private _dataView As DataView
    Private _dataRow As DataRow
    Private TmpStringInhaltKomplett As New StringBuilder
    Private StringIniFile As String

    Public Property Filename() As String
        Get
            Return _strFileName
        End Get
        Set(ByVal Value As String)
            _strFileName = Value
        End Set
    End Property

    Public Property Prefix() As String
        Get
            Return _strPrefix
        End Get
        Set(ByVal Value As String)
            _strPrefix = Value
        End Set
    End Property

    Public Sub New()
        _dataSet = New DataSet
        _dataTable = New DataTable
        _dataView = New DataView

        _dataTable.Columns.Add("Key")
        _dataTable.Columns.Add("Value")

        _dataSet.Tables.Add(_dataTable)
        _dataView.Table = _dataSet.Tables(0)
    End Sub


    ' The OpenIniFile() function reads every line of the INI file. 
    ' After the argument value strIniArgumentsBegins the keys And values list begins. 
    ' Every New key And its value Is added To the dataset. 
    ' And after everything, the changes are accepted:
    '
    Public Function OpenIniFile() As Boolean
        Try

            Dim tmpStringLine As String
            Dim tmpStringArguments() As String
            Dim tmpBool As Boolean = False
            If Not File.Exists(Filename) Then
                Return False
            End If

            Dim ssr As StreamReader = New StreamReader(Filename)
            _dataSet = New DataSet
            _dataTable = New DataTable
            _dataView = New DataView

            _dataTable.Columns.Add("Key")
            _dataTable.Columns.Add("Value")

            _dataSet.Tables.Add(_dataTable)
            _dataView.Table = _dataSet.Tables(0)

            Do
                tmpStringLine = ssr.ReadLine()

                If tmpStringLine Is Nothing Then Exit Do

                If tmpBool Then
                    Try
                        tmpStringArguments = tmpStringLine.Split("=")
                        _dataRow = _dataSet.Tables(0).NewRow
                        _dataRow("Key") = tmpStringArguments(0)
                        _dataRow("Value") = tmpStringArguments(1)
                        _dataSet.Tables(0).Rows.Add(_dataRow)
                    Catch ex As Exception

                    End Try
                End If

                If tmpStringLine.StartsWith(_strIniArgumentsBegins) Then
                    tmpBool = True
                    _strPrefix = TmpStringInhaltKomplett.ToString
                End If
                TmpStringInhaltKomplett.Append(tmpStringLine & Environment.NewLine)

            Loop Until tmpStringLine Is Nothing

            ssr.Close()
            StringIniFile = TmpStringInhaltKomplett.ToString
            Return True
            _dataSet.AcceptChanges()
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' The values in GetValue will be read from a DataView:
    '
    Public Function GetValue(ByVal Key As String) As String
        _dataView.RowFilter = "Key = '" & Key & "'"
        If _dataView.Count > 0 Then
            Return _dataView.Item(0).Item("Value")
        Else
            Return "NOTHING"
        End If
    End Function

    ' To set values in SetValue, 
    ' the DataView checks If the key has To be added Or changed
    '
    Public Function SetValue(ByVal Key As String, ByVal Value As String) As Boolean
        _dataView.RowFilter = "Key = '" & Key & "'"
        If _dataView.Count > 0 Then
            _dataView.Item(0).Item("Value") = Value
            Console.WriteLine("Änderung am Key '{0}'", Key)
        Else
            _dataRow = _dataSet.Tables(0).NewRow
            _dataRow("Key") = Key
            _dataRow("Value") = Value
            _dataSet.Tables(0).Rows.Add(_dataRow)
            Console.WriteLine("Neuer Eintrag: Key ='{0}' & Value = {1}", Key, Value)
        End If
    End Function


    ' In the last step, changes have to be saved. 
    ' Here, will be checked if there are any changes and if the file already exists:
    '
    Public Function SaveIni() As Boolean
        If Not IsNothing(_dataSet.GetChanges) Then
            SetValue("_LastSaveOfIniFile", Date.Now.ToLongDateString)
            Try
                _dataView.RowFilter = ""
                _dataView.Sort = "KEY ASC"

                Dim StringIni As New StringBuilder

                StringIni.Append(_strPrefix & Environment.NewLine)
                StringIni.Append(_strIniArgumentsBegins & Environment.NewLine)

                For i As Integer = 0 To _dataView.Count - 1
                    StringIni.Append(_dataView.Item(i).Item("Key") & "=" &
                                     _dataView.Item(i).Item("Value") & Environment.NewLine)
                Next

                If File.Exists(_strFileName) Then File.Delete(_strFileName)

                Dim ssw As New StreamWriter(_strFileName)
                ssw.WriteLine(StringIni.ToString)
                ssw.Close()
                _dataSet.AcceptChanges()
                Return True

            Catch ex As Exception
                Return False
            End Try
        Else
            Return True
        End If
    End Function

End Class
