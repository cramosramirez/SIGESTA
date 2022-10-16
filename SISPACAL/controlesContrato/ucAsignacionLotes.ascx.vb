Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Partial Class controlesContrato_ucAsignacionLotes
    Inherits ucBase

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Asignar", "Asignar lotes", False, IconoBarra.Generar, "onclick", "e.processOnServer=false;MostrarPopup(true)", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub
    
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
                Dim idZafra As Int32 = 0

                If lZafra IsNot Nothing Then idZafra = lZafra.ID_ZAFRA
                Me.ucListaLOTES1.ID_ZAFRA = idZafra
                Me.ucListaLOTES1.CargarDatosPorCriterios2(idZafra, _
                                                        Me.ucCriteriosLotes1.ZONA, _
                                                        Me.ucCriteriosLotes1.SUB_ZONA, _
                                                        Me.ucCriteriosLotes1.CODI_DETO, _
                                                        Me.ucCriteriosLotes1.CODI_MUNI, _
                                                        Me.ucCriteriosLotes1.CODI_CANTON, _
                                                        Me.ucCriteriosLotes1.CODIPROVEE, _
                                                        Me.ucCriteriosLotes1.CODISOCIO, _
                                                        Me.ucCriteriosLotes1.NOMBRE_PROVEEDOR)
        End Select
    End Sub

    Protected Sub cpAsignacionLotes_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cpAsignacionLotes.Callback
        cpAsignacionLotes.JSProperties.Clear()
        cpAsignacionLotes.JSProperties.Add("cpResultado", "")
        If cbxAGRONOMO.Value = Nothing Then
            cpAsignacionLotes.JSProperties("cpResultado") = "Seleccione un Tecnico Agricola"
            Return
        End If
        Dim lstLotes As listaLOTES = ucListaLOTES1.DevolverSeleccionados
        Dim bLotes As New cLOTES
        Dim bLotecosecha As New cLOTES_COSECHA
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva

        If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 Then
            For i As Integer = 0 To lstLotes.Count - 1
                bLotes.AsignarAgronomo(lstLotes(i).ACCESLOTE, cbxAGRONOMO.Value)

                Dim lLoteCosecha As LOTES_COSECHA = (New cLOTES_COSECHA).ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lstLotes(i).ACCESLOTE, lZafraActiva.ID_ZAFRA)
                If lLoteCosecha IsNot Nothing Then
                    lLoteCosecha.CODIAGRON = cbxAGRONOMO.Value
                    bLotecosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                End If
            Next
            Me.ucListaLOTES1.DataBind()
            cpAsignacionLotes.JSProperties("cpResultado") = "OK"
        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
        If cbxAGRONOMO.Value Is Nothing OrElse cbxAGRONOMO.Text.Trim.ToUpper.Contains("seleccio") Then
            AsignarMensaje("Seleccione un Tecnico Agricola", False, True, True)
            Return
        End If
        Dim lstLotes As listaLOTES = ucListaLOTES1.DevolverSeleccionados
        Dim lZafraActiva As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Dim bLotesCosecha As New cLOTES_COSECHA
        If lstLotes IsNot Nothing AndAlso lstLotes.Count > 0 AndAlso lZafraActiva IsNot Nothing Then
            For i As Integer = 0 To lstLotes.Count - 1
                Dim lLoteCosecha As LOTES_COSECHA = bLotesCosecha.ObtenerLOTES_COSECHAPorLOTE_ZAFRA(lstLotes(i).ACCESLOTE, lZafraActiva.ID_ZAFRA)
                If lLoteCosecha IsNot Nothing Then
                    lLoteCosecha.CODIAGRON = cbxAGRONOMO.Value
                    lLoteCosecha.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    lLoteCosecha.USUARIO_ACT = Me.ObtenerUsuario
                    bLotesCosecha.ActualizarLOTES_COSECHA(lLoteCosecha)
                End If
            Next
            Me.pcAsignarTecnico.ShowOnPageLoad = False
            Me.ucListaLOTES1.QuitarSeleccion()
            AsignarMensaje("Asignacion realizada.", False, True, True)
            Me.ucListaLOTES1.DataBind()
        End If
    End Sub
End Class

