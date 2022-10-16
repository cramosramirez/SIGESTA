Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlLABFAB_CATEGORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla LABFAB_CATEGORIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CATEG"), ToolboxData("<{0}:ddlLABFAB_CATEGORIA runat=server></{0}:ddlLABFAB_CATEGORIA>")> _
Public Class ddlLABFAB_CATEGORIA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cLABFAB_CATEGORIA
        Dim Lista As New ListaLABFAB_CATEGORIA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOM_CATEG"
        Me.DataValueField = "ID_CATEG"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla LABFAB_CATEGORIA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
