﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSECCION.ascx.vb" Inherits="controles_ucMantSECCION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSECCION" Src="~/controlesRequisicion/ucListaSECCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSECCION" Src="~/controlesRequisicion/ucVistaDetalleSECCION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Seccion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSECCION id="ucListaSECCION1" runat="server"></uc1:ucListaSECCION>
                <uc1:ucVistaDetalleSECCION ID="ucVistaDetalleSECCION1" runat="server" Visible="false" ></uc1:ucVistaDetalleSECCION></TD>
        </TR>
    </TBODY>
</TABLE>
