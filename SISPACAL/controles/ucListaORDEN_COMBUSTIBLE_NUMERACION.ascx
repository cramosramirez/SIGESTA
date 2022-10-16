﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaORDEN_COMBUSTIBLE_NUMERACION.ascx.vb" Inherits="controles_ucListaORDEN_COMBUSTIBLE_NUMERACION" %>
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
	   	   <asp:TemplateField HeaderText="Id orden combustible num" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUSTIBLE_NUM") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUSTIBLE_NUM") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ORDEN_COMBUSTIBLE_NUM" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUSTIBLE_NUM") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Zafra">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlZAFRA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ZAFRA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ZAFRA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlZAFRA id="ddlZAFRAID_ZAFRA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlZAFRA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="SERIE_ORDEN_COMBUSTIBLE" HeaderText="Serie orden combustible"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_INICIAL" HeaderText="No inicial"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_FINAL" HeaderText="No final"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ULT_NUM_ASIGNADO" HeaderText="Ult num asignado"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ES_INGENIO" HeaderText="Es ingenio"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_CREA" HeaderText="Usuario crea"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_CREA" HeaderText="Fecha crea"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_ACT" HeaderText="Usuario act"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACT" HeaderText="Fecha act"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ORDEN_COMBUSTIBLE_NUM") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.png" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
	   <PagerStyle CssClass="GridListPager" />
</asp:GridView>
