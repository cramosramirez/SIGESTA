﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantUSUARIO.ascx.vb" Inherits="controles_ucMantUSUARIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaUSUARIO" Src="~/controles/ucListaUSUARIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleUSUARIO" Src="~/controles/ucVistaDetalleUSUARIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Usuario</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaUSUARIO PermitirEditar="true" PermitirEliminar="true" PermitirFiltroEnEncabezado="true" PermitirFocoEnFilas="true" id="ucListaUSUARIO1" runat="server"></uc1:ucListaUSUARIO>
                <uc1:ucVistaDetalleUSUARIO ID="ucVistaDetalleUSUARIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleUSUARIO></TD>
        </TR>
    </TBODY>
</TABLE>
