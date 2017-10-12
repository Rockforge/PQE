Public Class CustomActions

    <CustomAction()> _
    Public Shared Function CustomAction1(ByVal session As Session) As ActionResult
        session.Log("Begin CustomAction1")


        PQE.SQLControl.sqlConn.ConnectionString = "server=" & session("") & "; uid=client; database=db_dost;"

        Return ActionResult.Success
    End Function

End Class
