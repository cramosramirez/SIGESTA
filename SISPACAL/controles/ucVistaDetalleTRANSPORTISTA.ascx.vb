Imports SISPACAL.BL
Imports SISPACAL.EL
Imports DevExpress.Web

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleTRANSPORTISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla TRANSPORTISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	15/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleTRANSPORTISTA
    Inherits ucBase

    Public Property CODTRANSPORT() As Int32
        Get
            If Me.ViewState("CODTRANSPORT") IsNot Nothing Then
                Return CInt(Me.ViewState("CODTRANSPORT"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Int32)
            Me.ViewState("CODTRANSPORT") = Value
            Me.lblREFERENCIA.Text = Guid.NewGuid.ToString
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property


    Public Sub LimpiarSesion()
        If lblREFERENCIA.Text <> "" Then
            If Session(lblREFERENCIA.Text) IsNot Nothing Then
                Session.Remove(lblREFERENCIA.Text)
            End If
        End If
    End Sub

    Public Property LISTA_TRANSPORTE As listaTRANSPORTE
        Set(value As listaTRANSPORTE)
            Session(Me.lblREFERENCIA.Text) = value
        End Set
        Get
            If Session(Me.lblREFERENCIA.Text) IsNot Nothing Then Return TryCast(Session(Me.lblREFERENCIA.Text), listaTRANSPORTE) Else Return New listaTRANSPORTE
        End Get
    End Property

#Region "Propiedades"




    Public Property NOMBRE_COMPLETO() As String
        Get
            Return Me.txtNOMBRE_COMPLETO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_COMPLETO.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property CREDITO_FISCAL() As String
        Get
            Return Me.txtCREDITO_FISCAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtCREDITO_FISCAL.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO() As String
        Get
            Return Me.txtTELEFONO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO.Text = value.ToString()
        End Set
    End Property

    Public Property NOMBRE_CH() As String
        Get
            Return Me.txtNOMBRE_CH.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_CH.Text = value.ToString()
        End Set
    End Property

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION.Text = value.ToString()
        End Set
    End Property


    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property NOCUENTA() As String
        Get
            Return Me.txtNOCUENTA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOCUENTA.Text = value.ToString()
        End Set
    End Property

    Public Property COD_SIGASI() As Int32
        Get
            If Me.speCOD_SIGASI.Value Is Nothing Then Return -1
            Return Me.speCOD_SIGASI.Value
        End Get
        Set(ByVal value As Int32)
            Me.speCOD_SIGASI.Value = value
        End Set
    End Property

    Public Property COD_COMBUST() As Int32
        Get
            If Me.speCOD_COMBUST.Value Is Nothing Then Return -1
            Return Me.speCOD_COMBUST.Value
        End Get
        Set(ByVal value As Int32)
            Me.speCOD_COMBUST.Value = value
        End Set
    End Property




    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cTRANSPORTISTA
    Private mEntidad As TRANSPORTISTA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Public Sub CargarDetalleTransporte()
        If Me.lblREFERENCIA.Text <> "" Then
            Me.ucListaTRANSPORTE1.CargarDatosCache(Me.lblREFERENCIA.Text)
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla TRANSPORTISTA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New TRANSPORTISTA
        mEntidad.CODTRANSPORT = CODTRANSPORT

        If mComponente.ObtenerTRANSPORTISTA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.speCODTRANSPORT.Text = mEntidad.CODTRANSPORT.ToString()
        Me.txtNOMBRE_COMPLETO.Text = mEntidad.NOMBRES
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtCREDITO_FISCAL.Text = mEntidad.CREDITO_FISCAL
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtNOMBRE_CH.Text = mEntidad.NOMBRE_CH
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtNOCUENTA.Text = mEntidad.NOCUENTA
        If mEntidad.COD_SIGASI = -1 Then Me.speCOD_SIGASI.Value = Nothing Else Me.speCOD_SIGASI.Value = mEntidad.COD_SIGASI
        If mEntidad.COD_COMBUST = -1 Then Me.speCOD_COMBUST.Value = Nothing Else Me.speCOD_COMBUST.Value = mEntidad.COD_COMBUST
        If mEntidad.CODIBANCO = -1 Then
            Me.cbxBANCO_PAGO_CTA.SelectedIndex = -1
        Else
            Me.cbxBANCO_PAGO_CTA.Value = mEntidad.CODIBANCO
        End If
        Me.txtNUM_CUENTA.Text = mEntidad.NUM_CUENTA
        Me.chkES_CTA_CORRIENTE.Checked = mEntidad.ES_CTA_CORRIENTE
        Me.txtPROFESION.Text = mEntidad.PROFESION

        Me.LISTA_TRANSPORTE = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(Me.CODTRANSPORT)
        If Me.LISTA_TRANSPORTE IsNot Nothing AndAlso Me.LISTA_TRANSPORTE.Count > 0 Then
            For Each lEntidad As TRANSPORTE In Me.LISTA_TRANSPORTE
                If lEntidad.CAPACIDAD = -1 Then lEntidad.CAPACIDAD = 0
            Next
        End If
        Me.CargarDetalleTransporte()

        Me.txtPLACA.Text = ""
        Me.cbxTIPO_TRANSPORTE.Value = Nothing
        Me.txtREMOLQUE.Text = ""
        Me.txtMARCA.Text = ""
        Me.speCAPACIDAD.Value = Nothing
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        'Dim layout As LayoutItemBase
        Me.speCODTRANSPORT.ClientEnabled = Me._nuevo
        Me.txtNOMBRE_COMPLETO.ClientEnabled = edicion
        Me.txtNIT.ClientEnabled = edicion
        Me.txtCREDITO_FISCAL.Enabled = edicion
        Me.txtTELEFONO.ClientEnabled = edicion
        Me.txtNOMBRE_CH.ClientEnabled = edicion
        Me.txtDIRECCION.ClientEnabled = edicion
        Me.txtDUI.ClientEnabled = edicion
        Me.txtNOCUENTA.ClientEnabled = edicion
        Me.speCOD_SIGASI.ClientEnabled = edicion
        Me.speCOD_COMBUST.ClientEnabled = edicion
        Me.cbxBANCO_PAGO_CTA.ClientEnabled = edicion
        Me.txtNUM_CUENTA.ClientEnabled = edicion
        Me.chkES_CTA_CORRIENTE.ClientEnabled = edicion
        Me.txtPROFESION.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.speCODTRANSPORT.Text = ""
        Me.txtNOMBRE_COMPLETO.Text = ""
        Me.txtNIT.Text = ""
        Me.txtCREDITO_FISCAL.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtNOMBRE_CH.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtDUI.Text = ""
        Me.txtNOCUENTA.Text = (New cTRANSPORTISTA).ObtenerCorrelativoCtaContable
        Me.speCOD_COMBUST.Value = Nothing
        Me.speCOD_SIGASI.Value = Nothing
        Me.cbxBANCO_PAGO_CTA.Value = Nothing
        Me.txtNUM_CUENTA.Text = ""
        Me.chkES_CTA_CORRIENTE.Checked = False
        Me.txtPLACA.Text = ""
        Me.cbxTIPO_TRANSPORTE.Value = Nothing
        Me.txtREMOLQUE.Text = ""
        Me.txtMARCA.Text = ""
        Me.speCAPACIDAD.Value = Nothing
        Me.txtPROFESION.Text = ""
        Me.LISTA_TRANSPORTE = New listaTRANSPORTE
        Me.CargarDetalleTransporte()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla TRANSPORTISTA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	15/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New TRANSPORTISTA

        If Me.speCODTRANSPORT.Value Is Nothing OrElse Me.speCODTRANSPORT.Value = 0 Then
            Return "Error al Guardar registro. Ingrese un codigo valido para el transportista."
        End If
        If Me._nuevo Then
            Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CInt(Me.speCODTRANSPORT.Value))
            If lTransportista IsNot Nothing Then
                Return "Error al Guardar registro. El codigo " + CStr(Me.speCODTRANSPORT.Value) + " ya esta asignado a otro transportista. Asigne otro codigo."
            End If
            mEntidad.CODTRANSPORT = Me.speCODTRANSPORT.Value
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.NOCUENTA = (New cTRANSPORTISTA).ObtenerCorrelativoCtaContable
        Else
            mEntidad = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(Me.speCODTRANSPORT.Value)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
            mEntidad.NOCUENTA = Me.txtNOCUENTA.Text
        End If

        If Me.txtDIRECCION.Text.Trim = "" Then
            Return "Ingrese la direccion de residencia"
        End If
        If Me.txtPROFESION.Text.Trim = "" Then
            Return "Ingrese la Profesion/oficio"
        End If
        If Me.cbxBANCO_PAGO_CTA.Value IsNot Nothing AndAlso Me.txtNUM_CUENTA.Text.Trim = "" Then
            Return "Ingrese el No de Cuenta bancaria"
        End If
        If Me.cbxBANCO_PAGO_CTA.Value Is Nothing AndAlso Me.txtNUM_CUENTA.Text.Trim <> "" Then
            Return "Seleccione el Banco del pago a cuenta"
        End If

        mEntidad.ACTIVO = True
        mEntidad.NOMBRES = Me.txtNOMBRE_COMPLETO.Text.ToUpper
        mEntidad.APELLIDOS = Nothing
        mEntidad.NIT = Me.txtNIT.Text
        If Me.txtCREDITO_FISCAL.Text.Trim = "" Then mEntidad.CREDITO_FISCAL = Nothing Else mEntidad.CREDITO_FISCAL = Me.txtCREDITO_FISCAL.Text
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.NOMBRE_CH = Me.txtNOMBRE_CH.Text.ToUpper
        mEntidad.DIRECCION = Me.txtDIRECCION.Text.ToUpper
        mEntidad.DUI = Me.txtDUI.Text
        If Me.speCOD_SIGASI.Value Is Nothing Then mEntidad.COD_SIGASI = -1 Else mEntidad.COD_SIGASI = Me.speCOD_SIGASI.Value
        If Me.speCOD_COMBUST.Value Is Nothing Then mEntidad.COD_COMBUST = -1 Else mEntidad.COD_COMBUST = Me.speCOD_COMBUST.Value

        If Me.cbxBANCO_PAGO_CTA.Value IsNot Nothing Then
            mEntidad.CODIBANCO = Me.cbxBANCO_PAGO_CTA.Value
        Else
            mEntidad.CODIBANCO = -1
        End If
        mEntidad.NUM_CUENTA = Me.txtNUM_CUENTA.Text.Trim
        mEntidad.ES_CTA_CORRIENTE = Me.chkES_CTA_CORRIENTE.Checked
        mEntidad.PROFESION = Me.txtPROFESION.Text.Trim.ToUpper

        If mComponente.ActualizarTRANSPORTISTA(mEntidad) < 0 Then
            Return "Error al Guardar registro. " + mComponente.sError
        End If


        'Actualizar transporte
        Dim listaOld As listaTRANSPORTE = (New cTRANSPORTE).ObtenerListaPorTRANSPORTISTA(Me.CODTRANSPORT)
        Dim listaNew As listaTRANSPORTE = Me.LISTA_TRANSPORTE
        Dim bTransporte As New cTRANSPORTE

        'Eliminar el transporte que ya no está
        If listaOld IsNot Nothing AndAlso listaOld.Count > 0 Then
            For Each lEntidadOld As TRANSPORTE In listaOld
                If listaNew IsNot Nothing AndAlso listaOld.Count > 0 Then
                    Dim existe As Boolean = False
                    For Each lEntidadNew As TRANSPORTE In listaNew
                        If lEntidadNew.PLACA = lEntidadOld.PLACA Then
                            existe = True
                        End If
                    Next
                    If Not existe Then bTransporte.EliminarTRANSPORTE(lEntidadOld.ID_TRANSPORTE)
                Else
                    bTransporte.EliminarTRANSPORTE(lEntidadOld.ID_TRANSPORTE)
                End If
            Next
        End If

        'Agregar o actualizar
        If listaNew IsNot Nothing AndAlso listaNew.Count > 0 Then
            For Each lEntidadNew As TRANSPORTE In listaNew
                Dim lVerificar As TRANSPORTE = bTransporte.ObtenerTRANSPORTEPorTRANSPORTISTA_PLACA(mEntidad.CODTRANSPORT, lEntidadNew.PLACA)
                If lVerificar IsNot Nothing AndAlso lVerificar.PLACA <> Nothing Then
                    lEntidadNew.ID_TRANSPORTE = lVerificar.ID_TRANSPORTE
                    lEntidadNew.CODTRANSPORT = mEntidad.CODTRANSPORT
                    lEntidadNew.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidadNew.FECHA_ACT = cFechaHora.ObtenerFechaHora
                Else
                    lEntidadNew.ID_TRANSPORTE = 0
                    lEntidadNew.CODTRANSPORT = mEntidad.CODTRANSPORT
                    lEntidadNew.USUARIO_CREA = Me.ObtenerUsuario
                    lEntidadNew.FECHA_CREA = cFechaHora.ObtenerFechaHora
                    lEntidadNew.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidadNew.FECHA_ACT = cFechaHora.ObtenerFechaHora
                End If
                bTransporte.ActualizarTRANSPORTE(lEntidadNew)
            Next
        End If

        Me.speCODTRANSPORT.Text = mEntidad.CODTRANSPORT
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub txtNOMBRE_COMPLETO_ValueChanged(sender As Object, e As System.EventArgs) Handles txtNOMBRE_COMPLETO.ValueChanged
        Me.txtNOMBRE_COMPLETO.Text = Me.txtNOMBRE_COMPLETO.Text.ToUpper
        Me.txtNOMBRE_CH.Text = Me.txtNOMBRE_COMPLETO.Text
        Me.txtDIRECCION.Focus()
    End Sub

    Protected Sub btnAgregarTransporte_Click(sender As Object, e As EventArgs) Handles btnAgregarTransporte.Click
        If Me.txtPLACA.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese la placa del vehiculo", False, True, True)
            Return
        End If
        If Me.cbxTIPO_TRANSPORTE.Value Is Nothing Then
            Me.AsignarMensaje("Seleccione el tipo de transporte", False, True, True)
            Return
        End If
        If Me.txtMARCA.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese la marca del vehiculo", False, True, True)
            Return
        End If
        If Me.speCAPACIDAD.Value Is Nothing Then
            Me.AsignarMensaje("Ingrese la capacidad del vehiculo", False, True, True)
            Return
        End If
        If Me.speANIO.Value Is Nothing Then
            Me.AsignarMensaje("Ingrese el anio del vehiculo", False, True, True)
            Return
        End If

        If Me.LISTA_TRANSPORTE Is Nothing Then Me.LISTA_TRANSPORTE = New listaTRANSPORTE
        If Me.LISTA_TRANSPORTE IsNot Nothing AndAlso LISTA_TRANSPORTE.Count > 0 Then
            For Each lEntidadNew As TRANSPORTE In LISTA_TRANSPORTE
                If lEntidadNew.PLACA = Me.txtPLACA.Text.Trim.ToUpper Then
                    Me.AsignarMensaje("La placa ya esta asignada", False, True, True)
                    Return
                End If
            Next
        End If

        Dim lEntidad As New TRANSPORTE
        lEntidad.ID_TRANSPORTE = ObtenerIdTrans(Me.LISTA_TRANSPORTE)
        lEntidad.PLACA = Me.txtPLACA.Text.Trim.ToUpper
        lEntidad.REMOLQUE = Me.txtREMOLQUE.Text.Trim.ToUpper
        lEntidad.MARCA = Me.txtMARCA.Text.Trim.ToUpper
        lEntidad.ID_TIPOTRANS = Me.cbxTIPO_TRANSPORTE.Value
        lEntidad.CODTRANSPORT = Me.CODTRANSPORT
        lEntidad.CAPACIDAD = Me.speCAPACIDAD.Value
        lEntidad.ANIO = IIf(Me.speANIO.Value = Nothing, -1, Me.speANIO.Value.ToString)

        Me.LISTA_TRANSPORTE.Add(lEntidad)
        Me.CargarDetalleTransporte()

        Me.txtPLACA.Text = ""
        Me.cbxTIPO_TRANSPORTE.Value = Nothing
        Me.txtREMOLQUE.Text = ""
        Me.txtMARCA.Text = ""
        Me.speCAPACIDAD.Value = Nothing
    End Sub

    Private Function ObtenerIdTrans(ByVal lista As listaTRANSPORTE) As Int32
        Dim Id As Int32 = 0
        For i As Integer = 0 To lista.Count - 1
            If lista(i).ID_TRANSPORTE > Id Then
                Id = lista(i).ID_TRANSPORTE
            End If
        Next
        Return (Id + 1)
    End Function
End Class
