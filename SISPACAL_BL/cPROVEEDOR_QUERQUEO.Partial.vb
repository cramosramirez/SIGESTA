Partial Public Class cPROVEEDOR_QUERQUEO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function ObtenerListaPorCODISIS(ByVal CODISIS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_QUERQUEO
        Try

            Return mDb.ObtenerListaPorCODISIS(CODISIS, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
