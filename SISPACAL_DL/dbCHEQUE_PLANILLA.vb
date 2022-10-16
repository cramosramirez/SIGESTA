Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_DL
''' Class	 : DL.dbCHEQUE_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla CHEQUE_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbCHEQUE_PLANILLA
    Inherits dbBase

#Region " Metodos Generador "

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As CHEQUE_PLANILLA
        lEntidad = CType(aEntidad, CHEQUE_PLANILLA)

        Dim lID As Int32
        If lEntidad.ID_CHEQUE_PLANILLA =  0 _
            Or lEntidad.ID_CHEQUE_PLANILLA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Int32)

            If lID = -1 Then Return -1

            lEntidad.ID_CHEQUE_PLANILLA = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder


        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CHEQUE_PLANILLA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CHEQUE_PLANILLA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return SqlHelper.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, CType(aEntidad,CHEQUE_PLANILLA))
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As CHEQUE_PLANILLA, Optional ByVal aCHEQUERA_PLANILLA As Boolean = False, Optional ByVal aCATORCENA_ZAFRA As Boolean = False, Optional ByVal aTIPO_PLANILLA As Boolean = False, Optional ByVal aPLANILLA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As SqlParameter

        If aCHEQUERA_PLANILLA Or aCATORCENA_ZAFRA Or aTIPO_PLANILLA Or aPLANILLA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(CHEQUE_PLANILLA), GetType(SqlParameter), strCampos, strWhere, 0, "CHEQUE_PLANILLA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCHEQUERA_PLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CHEQUERA_PLANILLA, Nothing, GetType(CHEQUERA_PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CATORCENA_ZAFRA, Nothing, GetType(CATORCENA_ZAFRA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_PLANILLA, Nothing, GetType(TIPO_PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPLANILLA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PLANILLA, Nothing, GetType(PLANILLA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM CHEQUE_PLANILLA")
            numTabla = 0
            If aCHEQUERA_PLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CHEQUERA_PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CHEQUERA = CHEQUE_PLANILLA.ID_CHEQUERA")
            End If
            If aCATORCENA_ZAFRA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CATORCENA_ZAFRA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CATORCENA = CHEQUE_PLANILLA.ID_CATORCENA")
            End If
            If aTIPO_PLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_PLANILLA = CHEQUE_PLANILLA.ID_TIPO_PLANILLA")
            End If
            If aPLANILLA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PLANILLA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIPROVEEDOR_TRANSPORTISTA = CHEQUE_PLANILLA.CODIPROVEEDOR_TRANSPORTISTA")
            End If
            strSQL.Append(strWhere)
        Else
            strSQL.Append(Me.QuerySelect(aEntidad, args))
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCHEQUERA_PLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCHEQUERA_PLANILLA(dr, aEntidad.fkID_CHEQUERA, "T" + numTabla.ToString())
                End If
                If aCATORCENA_ZAFRA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCATORCENA_ZAFRA(dr, aEntidad.fkID_CATORCENA, "T" + numTabla.ToString())
                End If
                If aTIPO_PLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_PLANILLA(dr, aEntidad.fkID_TIPO_PLANILLA, "T" + numTabla.ToString())
                End If
                If aPLANILLA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPLANILLA(dr, aEntidad.fkCODIPROVEEDOR_TRANSPORTISTA, "T" + numTabla.ToString())
                End If
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT isnull(max(ID_CHEQUE_PLANILLA),0) + 1 ")
        strSQL.AppendLine(" FROM CHEQUE_PLANILLA ")

        Return SqlHelper.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim ds As DataSet

        ds = SqlHelper.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

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
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("CHEQUE_PLANILLA".ToCharArray())

        SqlHelper.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve en el StringBuilder que recibe como parámetro el Query
    ''' de la Tabla de la Clase.
    ''' </summary>
    ''' <param name="strSQL">StringBuilder donde se escribe el Query</param>
    ''' <remarks>
    ''' Obsoleto, se recomienda utilizar los métodos del ancestro para esta operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT CHEQUE_PLANILLA.ID_CHEQUE_PLANILLA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.ID_CHEQUERA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.NO_CHEQUE, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.MONTO_CHEQUE, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.CANTIDAD_LETRAS, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.TITULAR_CHEQUE, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.ESTADO, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.FECHA_EMISION, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.FECHA_ANULACION, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.MOTIVO_ANULACION, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.USUARIO_CREA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.FECHA_CREA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.USUARIO_ACT, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.FECHA_ACT, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.NO_PARTIDA_PH, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.ID_CATORCENA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.ID_TIPO_PLANILLA, ")
        strSQL.AppendLine(" CHEQUE_PLANILLA.CODIPROVEEDOR_TRANSPORTISTA ")
        strSQL.AppendLine(" FROM CHEQUE_PLANILLA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CHEQUERA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCHEQUERA_PLANILLA(ByVal ID_CHEQUERA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_CHEQUERA = @ID_CHEQUERA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CHEQUERA", SqlDbType.Int)
        args(0).Value = ID_CHEQUERA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCATORCENA_ZAFRA(ByVal ID_CATORCENA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_PLANILLA(ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(0).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CATORCENA"></param>
    ''' <param name="CODIPROVEEDOR_TRANSPORTISTA"></param>
    ''' <param name="ID_TIPO_PLANILLA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPLANILLA(ByVal ID_CATORCENA As Int32, ByVal CODIPROVEEDOR_TRANSPORTISTA As String, ByVal ID_TIPO_PLANILLA As Int32, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaCHEQUE_PLANILLA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New CHEQUE_PLANILLA))
        strSQL.Append(" WHERE ID_CATORCENA = @ID_CATORCENA ") 
        strSQL.Append(" AND CODIPROVEEDOR_TRANSPORTISTA = @CODIPROVEEDOR_TRANSPORTISTA ") 
        strSQL.Append(" AND ID_TIPO_PLANILLA = @ID_TIPO_PLANILLA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ID_CATORCENA", SqlDbType.Int)
        args(0).Value = ID_CATORCENA
        args(1) = New SqlParameter("@CODIPROVEEDOR_TRANSPORTISTA", SqlDbType.VarChar)
        args(1).Value = CODIPROVEEDOR_TRANSPORTISTA
        args(2) = New SqlParameter("@ID_TIPO_PLANILLA", SqlDbType.Int)
        args(2).Value = ID_TIPO_PLANILLA

        Dim dr As IDataReader

        dr = SqlHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaCHEQUE_PLANILLA

        Try
            Do While dr.Read()
                Dim mEntidad As New CHEQUE_PLANILLA
                dbAsignarEntidades.AsignarCHEQUE_PLANILLA(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

#End Region

#End Region

End Class
