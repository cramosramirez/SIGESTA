''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_BL
''' Class	 : BL.cTIPO_TEXTURA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla TIPO_TEXTURA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/05/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cTIPO_TEXTURA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbTIPO_TEXTURA()
    Private mEntidad as New TIPO_TEXTURA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTIPO_TEXTURA
        Try
            Dim mListaTIPO_TEXTURA As New ListaTIPO_TEXTURA
            mListaTIPO_TEXTURA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaTIPO_TEXTURA
            If Not mListaTIPO_TEXTURA Is Nothing Then
                For Each lEntidad As TIPO_TEXTURA in  mListaTIPO_TEXTURA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaTIPO_TEXTURA
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerTIPO_TEXTURA(ByRef aEntidad As TIPO_TEXTURA, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla TIPO_TEXTURA.
    ''' </summary>
    ''' <param name="CODI_TEXTURA"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerTIPO_TEXTURA(ByVal CODI_TEXTURA As String, ByVal Optional recuperarHijas As Boolean = False) As TIPO_TEXTURA
        Try
            Dim lEntidad As New TIPO_TEXTURA
            lEntidad.CODI_TEXTURA = CODI_TEXTURA
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
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
    ''' Función que Elimina un Registro de la Tabla TIPO_TEXTURA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="CODI_TEXTURA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTIPO_TEXTURA(ByVal CODI_TEXTURA As String) As Integer
        Try
            mEntidad.CODI_TEXTURA = CODI_TEXTURA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TIPO_TEXTURA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTIPO_TEXTURA(ByVal aEntidad As TIPO_TEXTURA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarTIPO_TEXTURA(ByVal CODI_TEXTURA As String, ByVal NOMBRE_TEXTURA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New TIPO_TEXTURA
            lEntidad.CODI_TEXTURA = CODI_TEXTURA
            lEntidad.NOMBRE_TEXTURA = NOMBRE_TEXTURA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.AgregarTIPO_TEXTURA(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarTIPO_TEXTURA(ByVal aEntidad As TIPO_TEXTURA) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTIPO_TEXTURA(ByVal aEntidad As TIPO_TEXTURA) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTIPO_TEXTURA(ByVal aEntidad As TIPO_TEXTURA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTIPO_TEXTURA(ByVal CODI_TEXTURA As String, ByVal NOMBRE_TEXTURA As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New TIPO_TEXTURA
            lEntidad.CODI_TEXTURA = CODI_TEXTURA
            lEntidad.NOMBRE_TEXTURA = NOMBRE_TEXTURA
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarTIPO_TEXTURA(lEntidad)
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
    ''' 	[GenApp]	26/05/2014	Created
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
    ''' 	[GenApp]	26/05/2014	Created
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
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/05/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As TIPO_TEXTURA )
    End Sub

#End Region

End Class
