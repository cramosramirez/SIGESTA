﻿Partial Public Class cPLANTILLA_PRODU_DATOS

    Public Function ObtenerListaAgrupadaProductores(ByVal UID_REFERENCIA As Guid, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_PRODU_DATOS
        Try
            Return mDb.ObtenerListaAgrupadaProductores(UID_REFERENCIA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCriterios(ByVal UID_REFERENCIA As Guid, ByVal CODIPROVEEDOR As String, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPLANTILLA_PRODU_DATOS
        Try
            Return mDb.ObtenerListaPorCriterios(UID_REFERENCIA, CODIPROVEEDOR, CONCEPTO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerDetalleParaPlantilla(ByVal UID_REFERENCIA As Guid) As DataSet
        Try
            Return mDb.ObtenerDetalleParaPlantilla(UID_REFERENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTotalesCantidadesParaPlantilla(ByVal UID_REFERENCIA As Guid, ByVal CODIPROVEEDOR As String, ByVal CONCEPTO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerTotalesCantidadesParaPlantilla(UID_REFERENCIA, CODIPROVEEDOR, CONCEPTO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
