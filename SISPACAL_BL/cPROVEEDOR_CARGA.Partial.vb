Partial Public Class cPROVEEDOR_CARGA
    Public Shared Function EsIngenio(ByVal ID_PROVEEDOR_CARGA As Integer) As Boolean
        Try
            Dim lEntidad As PROVEEDOR_CARGA
            lEntidad = (New cPROVEEDOR_CARGA).ObtenerPROVEEDOR_CARGA(ID_PROVEEDOR_CARGA)
            If lEntidad IsNot Nothing Then
                Return lEntidad.ES_INGENIO
            Else
                Return False
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function
End Class
