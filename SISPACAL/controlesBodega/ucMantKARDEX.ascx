﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantKARDEX.ascx.vb" Inherits="controles_ucMantKARDEX" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaKARDEX" Src="~/controlesBodega/ucListaKARDEX.ascx" %>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server" Visible="false" ></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Kardex Productos en Consignación</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaKARDEX id="ucListaKARDEX1" PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false" PermitirEliminarInline="false" runat="server"></uc1:ucListaKARDEX></TD>
        </TR>
    </TBODY>
</TABLE>
