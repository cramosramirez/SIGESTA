﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_COMBUSTIBLE_AUTORIZACION.ascx.vb" Inherits="controles_ucListaORDEN_COMBUSTIBLE_AUTORIZACION" %>
<%@ Register TagPrefix="cc1" Namespace="SISPACAL.WebUC" Assembly="SISPACAL_WebUC" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
	   <FooterStyle CssClass="GridListFooter" />
	   <HeaderStyle CssClass="GridListHead" />
	   <RowStyle CssClass="GridListItem" />
	   <SelectedRowStyle CssClass="GridSelectedItem" />
	   <AlternatingRowStyle CssClass="GridListItemAlt" />
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id orden combus auto" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_AUTO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_AUTO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS_AUTO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_AUTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="CODIGO" HeaderText="Codigo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
           <asp:TemplateField HeaderText="Nombre">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_NOMBRE_PROVEEDOR" runat="server" />	   	   	   
	   	   	   </ItemTemplate>	   	   	  
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Tipo proveedor">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PROVEEDOR1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PROVEEDOR id="ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_PROVEEDOR></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_PROVEEDOR2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_PROVEEDOR") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_PROVEEDOR id="ddlTIPO_PROVEEDORID_TIPO_PROVEEDOR2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_PROVEEDOR></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="N° Orden combustible">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUS1" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS") %>' />	   	   	   
	   	   	   </ItemTemplate>	   	   	  
	   	   </asp:TemplateField>
           <asp:TemplateField HeaderText="Autorización Aplicada" ItemStyle-HorizontalAlign="Center">
	   	   	   <ItemTemplate>
                   <asp:CheckBox ID="chkAutorizacionAplicada" runat="server" Enabled="false" Checked='<%# DataBinder.Eval(Container, "DataItem.AUTORIZACION_APLICADA") %>' />	   	   	   	   
	   	   	   </ItemTemplate>	   	   	   
	   	   </asp:TemplateField>	   	   
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUS_AUTO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
