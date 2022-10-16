<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfMantPROVEEDOR_ROZA.aspx.vb" Inherits="wfMantPROVEEDOR_ROZA" title="Mantenimiento de Proveedor roza" %>
<%@ Register Src="~/controles/ucMantPROVEEDOR_ROZA.ascx" TagName="ucMantPROVEEDOR_ROZA" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    <ContentTemplate>    
    <uc1:ucMantPROVEEDOR_ROZA id="ucMantPROVEEDOR_ROZA1" runat="server"></uc1:ucMantPROVEEDOR_ROZA>
    </ContentTemplate>                 
    </asp:UpdatePanel>  
</asp:Content>
