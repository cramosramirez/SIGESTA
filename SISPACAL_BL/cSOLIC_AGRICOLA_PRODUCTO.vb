''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cSOLIC_AGRICOLA_PRODUCTO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLIC_AGRICOLA_PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLIC_AGRICOLA_PRODUCTO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLIC_AGRICOLA_PRODUCTO()
    Private mEntidad as New SOLIC_AGRICOLA_PRODUCTO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_PRODUCTO
        Try
            Dim mListaSOLIC_AGRICOLA_PRODUCTO As New ListaSOLIC_AGRICOLA_PRODUCTO
            mListaSOLIC_AGRICOLA_PRODUCTO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_PRODUCTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO in  mListaSOLIC_AGRICOLA_PRODUCTO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_PRODUCTO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLIC_AGRICOLA_PRODUCTO(ByRef aEntidad As SOLIC_AGRICOLA_PRODUCTO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLIC_AGRICOLA_PRODUCTO.
    ''' </summary>
    ''' <param name="ID_SOLIC_AGRI_PROD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLIC_AGRICOLA_PRODUCTO(ByVal ID_SOLIC_AGRI_PROD As Int32, ByVal Optional recuperarForaneas As Boolean = False) As SOLIC_AGRICOLA_PRODUCTO
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_PRODUCTO
            lEntidad.ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aSOLIC_AGRICOLA">Recuperar registro foraneo de la Entidad SOLIC_AGRICOLA.</param>
    ''' <param name="aPRODUCTO">Recuperar registro foraneo de la Entidad PRODUCTO.</param>
    ''' <param name="aPROVEEDOR_AGRICOLA">Recuperar registro foraneo de la Entidad PROVEEDOR_AGRICOLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLIC_AGRICOLA_PRODUCTOConForaneas(ByVal aEntidad As SOLIC_AGRICOLA_PRODUCTO, Optional ByVal aSOLIC_AGRICOLA As Boolean = False, Optional ByVal aPRODUCTO As Boolean = False, Optional ByVal aPROVEEDOR_AGRICOLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLIC_AGRICOLA, aPRODUCTO, aPROVEEDOR_AGRICOLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA_PRODUCTO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_AGRI_PROD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA_PRODUCTO(ByVal ID_SOLIC_AGRI_PROD As Int32) As Integer
        Try
            mEntidad.ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLIC_AGRICOLA_PRODUCTO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLIC_AGRICOLA_PRODUCTO(ByVal aEntidad As SOLIC_AGRICOLA_PRODUCTO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLIC_AGRICOLA_PRODUCTO(ByVal ID_SOLIC_AGRI_PROD As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PRODUCTO As Int32, ByVal CANT_X_MZ As Decimal, ByVal TOTAL_PRODUCTO As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal PRECIO_TOTAL As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal UID_SOLIC_AGRI_PROD As Guid, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal ID_PROVEE As Int32, ByVal UNIDAD As String, ByVal ID_PROVEE_ADJU As Int32, ByVal CANT_ADJU As Decimal, ByVal PRECIO_ADJU As Decimal, ByVal TOTAL_ADJU As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_PRODUCTO
            lEntidad.ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANT_X_MZ = CANT_X_MZ
            lEntidad.TOTAL_PRODUCTO = TOTAL_PRODUCTO
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.PRECIO_TOTAL = PRECIO_TOTAL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_SOLIC_AGRI_PROD = UID_SOLIC_AGRI_PROD
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.UNIDAD = UNIDAD
            lEntidad.ID_PROVEE_ADJU = ID_PROVEE_ADJU
            lEntidad.CANT_ADJU = CANT_ADJU
            lEntidad.PRECIO_ADJU = PRECIO_ADJU
            lEntidad.TOTAL_ADJU = TOTAL_ADJU
            Return Me.ActualizarSOLIC_AGRICOLA_PRODUCTO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

  

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLIC_AGRICOLA_PRODUCTO(ByVal ID_SOLIC_AGRI_PROD As Int32, ByVal ID_SOLICITUD As Int32, ByVal ID_PRODUCTO As Int32, ByVal CANT_X_MZ As Decimal, ByVal TOTAL_PRODUCTO As Decimal, ByVal PRECIO_UNITARIO As Decimal, ByVal PRECIO_TOTAL As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal ZAFRA As String, ByVal UID_SOLIC_AGRI_PROD As Guid, ByVal NOMBRE_PRODUCTO As String, ByVal PRESENTACION As String, ByVal ID_PROVEE As Int32, ByVal UNIDAD As String, ByVal ID_PROVEE_ADJU As Int32, ByVal CANT_ADJU As Decimal, ByVal PRECIO_ADJU As Decimal, ByVal TOTAL_ADJU As Decimal) As Integer
        Try
            Dim lEntidad As New SOLIC_AGRICOLA_PRODUCTO
            lEntidad.ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_PRODUCTO = ID_PRODUCTO
            lEntidad.CANT_X_MZ = CANT_X_MZ
            lEntidad.TOTAL_PRODUCTO = TOTAL_PRODUCTO
            lEntidad.PRECIO_UNITARIO = PRECIO_UNITARIO
            lEntidad.PRECIO_TOTAL = PRECIO_TOTAL
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.ZAFRA = ZAFRA
            lEntidad.UID_SOLIC_AGRI_PROD = UID_SOLIC_AGRI_PROD
            lEntidad.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO
            lEntidad.PRESENTACION = PRESENTACION
            lEntidad.ID_PROVEE = ID_PROVEE
            lEntidad.UNIDAD = UNIDAD
            lEntidad.ID_PROVEE_ADJU = ID_PROVEE_ADJU
            lEntidad.CANT_ADJU = CANT_ADJU
            lEntidad.PRECIO_ADJU = PRECIO_ADJU
            lEntidad.TOTAL_ADJU = TOTAL_ADJU
            Return Me.ActualizarSOLIC_AGRICOLA_PRODUCTO(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLIC_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLIC_AGRICOLA(ByVal ID_SOLICITUD As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_PRODUCTO
        Try
            Dim mListaSOLIC_AGRICOLA_PRODUCTO As New ListaSOLIC_AGRICOLA_PRODUCTO
            mListaSOLIC_AGRICOLA_PRODUCTO = mDb.ObtenerListaPorSOLIC_AGRICOLA(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_PRODUCTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO in  mListaSOLIC_AGRICOLA_PRODUCTO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_PRODUCTO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PRODUCTO .
    ''' </summary>
    ''' <param name="ID_PRODUCTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPRODUCTO(ByVal ID_PRODUCTO As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_PRODUCTO
        Try
            Dim mListaSOLIC_AGRICOLA_PRODUCTO As New ListaSOLIC_AGRICOLA_PRODUCTO
            mListaSOLIC_AGRICOLA_PRODUCTO = mDb.ObtenerListaPorPRODUCTO(ID_PRODUCTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_PRODUCTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO in  mListaSOLIC_AGRICOLA_PRODUCTO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_PRODUCTO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AGRICOLA .
    ''' </summary>
    ''' <param name="ID_PROVEE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AGRICOLA(ByVal ID_PROVEE As Int32, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLIC_AGRICOLA_PRODUCTO
        Try
            Dim mListaSOLIC_AGRICOLA_PRODUCTO As New ListaSOLIC_AGRICOLA_PRODUCTO
            mListaSOLIC_AGRICOLA_PRODUCTO = mDb.ObtenerListaPorPROVEEDOR_AGRICOLA(ID_PROVEE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLIC_AGRICOLA_PRODUCTO Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLIC_AGRICOLA_PRODUCTO in  mListaSOLIC_AGRICOLA_PRODUCTO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLIC_AGRICOLA_PRODUCTO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLIC_AGRICOLA_PRODUCTO )
        aEntidad.fkID_SOLICITUD = (New cSOLIC_AGRICOLA).ObtenerSOLIC_AGRICOLA(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_PRODUCTO = (New cPRODUCTO).ObtenerPRODUCTO(aEntidad.ID_PRODUCTO)
        aEntidad.fkID_PROVEE = (New cPROVEEDOR_AGRICOLA).ObtenerPROVEEDOR_AGRICOLA(aEntidad.ID_PROVEE)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/06/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLIC_AGRICOLA_PRODUCTO )
    End Sub

#End Region

End Class
