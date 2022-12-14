''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cPLANILLA_BASE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PLANILLA_BASE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPLANILLA_BASE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPLANILLA_BASE()
    Private mEntidad as New PLANILLA_BASE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA_BASE
        Try
            Dim mListaPLANILLA_BASE As New ListaPLANILLA_BASE
            mListaPLANILLA_BASE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA_BASE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA_BASE
            If Not mListaPLANILLA_BASE Is Nothing Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA_BASE
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
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPLANILLA_BASE(ByRef aEntidad As PLANILLA_BASE, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return liRet
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(aEntidad)
                Catch ex as Exception
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PLANILLA_BASE.
    ''' </summary>
    ''' <param name="ID_PLANILLA_BASE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As PLANILLA_BASE
        Try
            Dim lEntidad As New PLANILLA_BASE
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then
                If liRet = 1 Then Return lEntidad
                Return Nothing
            End If
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(lEntidad)
                Catch ex as Exception
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
    ''' <param name="aZAFRA">Recuperar registro foraneo de la Entidad ZAFRA.</param>
    ''' <param name="aTIPO_PLANILLA">Recuperar registro foraneo de la Entidad TIPO_PLANILLA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPLANILLA_BASEConForaneas(ByVal aEntidad As PLANILLA_BASE, Optional ByVal aZAFRA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aZAFRA, aTIPO_PLANILLA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA_BASE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PLANILLA_BASE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32) As Integer
        Try
            mEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PLANILLA_BASE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPLANILLA_BASE(ByVal aEntidad As PLANILLA_BASE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FIN As DateTime, ByVal FECHA_PAGO As DateTime, ByVal NO_ANTICIPO As Int32, ByVal NO_ANTICIPO_LETRAS As String, ByVal VALOR_UNIT_PAGO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CONCEPTO As String) As Integer
        Try
            Dim lEntidad As New PLANILLA_BASE
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FIN = FECHA_FIN
            lEntidad.FECHA_PAGO = FECHA_PAGO
            lEntidad.NO_ANTICIPO = NO_ANTICIPO
            lEntidad.NO_ANTICIPO_LETRAS = NO_ANTICIPO_LETRAS
            lEntidad.VALOR_UNIT_PAGO = VALOR_UNIT_PAGO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CONCEPTO = CONCEPTO
            Return Me.ActualizarPLANILLA_BASE(lEntidad)
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPLANILLA_BASE(ByVal ID_PLANILLA_BASE As Int32, ByVal ID_ZAFRA As Int32, ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FIN As DateTime, ByVal FECHA_PAGO As DateTime, ByVal NO_ANTICIPO As Int32, ByVal NO_ANTICIPO_LETRAS As String, ByVal VALOR_UNIT_PAGO As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal CONCEPTO As String) As Integer
        Try
            Dim lEntidad As New PLANILLA_BASE
            lEntidad.ID_PLANILLA_BASE = ID_PLANILLA_BASE
            lEntidad.ID_ZAFRA = ID_ZAFRA
            lEntidad.ID_CATORCENA = ID_CATORCENA
            lEntidad.ID_TIPO_PLANILLA = ID_TIPO_PLANILLA
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FIN = FECHA_FIN
            lEntidad.FECHA_PAGO = FECHA_PAGO
            lEntidad.NO_ANTICIPO = NO_ANTICIPO
            lEntidad.NO_ANTICIPO_LETRAS = NO_ANTICIPO_LETRAS
            lEntidad.VALOR_UNIT_PAGO = VALOR_UNIT_PAGO
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.CONCEPTO = CONCEPTO
            Return Me.ActualizarPLANILLA_BASE(lEntidad)
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
    ''' 	[GenApp]	18/10/2017	Created
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
    ''' 	[GenApp]	18/10/2017	Created
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
    ''' la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorZAFRA(ByVal ID_ZAFRA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA_BASE
        Try
            Dim mListaPLANILLA_BASE As New ListaPLANILLA_BASE
            mListaPLANILLA_BASE = mDb.ObtenerListaPorZAFRA(ID_ZAFRA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA_BASE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA_BASE
            If Not mListaPLANILLA_BASE Is Nothing Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA_BASE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_PLANILLA .
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPLANILLA_BASE
        Try
            Dim mListaPLANILLA_BASE As New ListaPLANILLA_BASE
            mListaPLANILLA_BASE = mDb.ObtenerListaPorTIPO_PLANILLA(ID_TIPO_PLANILLA, asColumnaOrden, asTipoOrden)
            If Not mListaPLANILLA_BASE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPLANILLA_BASE
            If Not mListaPLANILLA_BASE Is Nothing Then
                For Each lEntidad As PLANILLA_BASE in  mListaPLANILLA_BASE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPLANILLA_BASE
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PLANILLA_BASE )
        aEntidad.fkID_ZAFRA = (New cZAFRA).ObtenerZAFRA(aEntidad.ID_ZAFRA)
        aEntidad.fkID_TIPO_PLANILLA = (New cTIPO_PLANILLA).ObtenerTIPO_PLANILLA(aEntidad.ID_TIPO_PLANILLA)
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
    ''' 	[GenApp]	18/10/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PLANILLA_BASE )
    End Sub

#End Region

End Class
