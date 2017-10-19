Public Class CustomActions

    <CustomAction()>
    Public Shared Function InitializeConnection(ByVal session As Session) As ActionResult
        session.Log("Begin CustomAction1")

        PQE.SQLControl.sqlConn.ConnectionString = "server=" & session.Item("TEXT_DATABASE_SERVER") & "; userid=" & session.Item("TEXT_DATABASE_USERID") & "; password= " & session.Item("TEXT_DATABASE_PASSWORD") & "; database=" & session.Item("TEXT_DATABASE_NAME") & "; allowuservariables=true"



        Return ActionResult.Success
    End Function

End Class
