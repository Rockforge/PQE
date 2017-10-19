Imports System.ComponentModel
Imports System.Configuration.Install


Public Class Installer1

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent

    End Sub

    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)
        Dim db_Server As String = Me.Context.Parameters.Item("TEXT_DATABASE_IP")
        Dim db_Name As String = Me.Context.Parameters.Item("TEXT_DATABASE_NAME")
        Dim db_Username As String = Me.Context.Parameters.Item("TEXT_DATABASE_USERID")
        Dim db_Password As String = Me.Context.Parameters.Item("TEXT_DATABASE_PASSWORD")

        ' Writes INI with connection fields
        Dim connectionIni As New PQE.IniFile
        With connectionIni
            .Filename = My.Application.Info.DirectoryPath & "\config.ini"

            If .OpenIniFile Then
                .SetValue("1", db_Server)
                .SetValue("2", db_Name)
                .SetValue("3", db_Username)
                .SetValue("4", db_Password)
                .SaveIni()
            End If

        End With

    End Sub

    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        MyBase.Commit(savedState)
    End Sub

    Public Overrides Sub Rollback(ByVal savedState As System.Collections.IDictionary)
        MyBase.Rollback(savedState)
    End Sub

    Public Overrides Sub Uninstall(ByVal savedState As System.Collections.IDictionary)
        MyBase.Uninstall(savedState)
    End Sub

End Class
