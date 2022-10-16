<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleTRANSPORTISTA.ascx.vb" Inherits="controles_ucVistaDetalleTRANSPORTISTA" %>
<%@ Register assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaTRANSPORTE" Src="~/controles/ucListaTRANSPORTE.ascx" %>


<script type="text/javascript">
    function Validacion_NIT(s, e) {
        var nit = e.value;
        if (nit == null)
            e.isValid = false;
        else if (nit.length > 0 && nit.length < 14)
            e.isValid = false;
    }

    function Validacion_DUI(s, e) {
        var dui = e.value;
        if (dui == null)
            e.isValid = true;
        else if (dui.length > 0 && dui.length < 9)
            e.isValid = false;
    }
               
</script>
<table>
    <tr>
        <td>
        <dx:ASPxFormLayout ID="ucVistaDetalleTRANSPORTISTALayout" runat="server">
        <Items>
            <dx:LayoutGroup ColCount="3" Caption="Creando/Editando Transportista" 
                Name="lgVistaDetalleTRANSPORTISTA" GroupBoxDecoration="HeadingLine">
                <Items>
                    <dx:LayoutItem Caption="Código:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxSpinEdit ID="speCODTRANSPORT" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCODTRANSPORT" >
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="Codigo obligatorio" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxSpinEdit>                             
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Nombre Completo:" ColSpan="2">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtNOMBRE_COMPLETO" AutoPostBack="true" Width="100%" MaxLength="60" runat="server">
                                <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="Nombre Completo es obligatorio" IsRequired="True" />
                                    </ValidationSettings>
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>  
                    <dx:LayoutItem Caption="Dirección:" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtDIRECCION" runat="server" ClientInstanceName="txtDIRECCION" MaxLength="250" Width="100%">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="Dirección obligatoria">
                                        <RequiredField ErrorText="Dirección obligatoria" IsRequired="True" />
                                    </ValidationSettings>    
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem> 
                    <dx:LayoutItem Caption="DUI:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtDUI" ClientInstanceName="txtDUI" runat="server" >
                                    <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                        Mask="99999999-9" />                               
                                    <ClientSideEvents Validation="Validacion_DUI" /> 
                                </dx:ASPxTextBox>                            
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="NIT:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtNIT" runat="server" ClientInstanceName="txtNIT">
                                     <MaskSettings AllowMouseWheel="False" IncludeLiterals="None" 
                                         Mask="9999-999999-999-9" ErrorText="NIT no valido"  />
                                     <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="NIT no valido">
                                        <RequiredField ErrorText="NIT obligatorio" IsRequired="True" />
                                    </ValidationSettings>
                                    <ClientSideEvents Validation="Validacion_NIT" /> 
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem> 
                    <dx:LayoutItem Caption="NRC:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtCREDITO_FISCAL" ClientInstanceName="txtCREDITO_FISCAL" MaxLength="10" runat="server">                               
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem> 
                    <dx:LayoutItem Caption="Profesión/Oficio:" ColSpan="2" >
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2"  runat="server">
                                <dx:ASPxTextBox ID="txtPROFESION" MaxLength="150" Width="100%"  runat="server"> 
                                     <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="true" ErrorText="Profesion obligatoria">
                                        <RequiredField ErrorText="Profesion obligatoria" IsRequired="True" />
                                    </ValidationSettings>                              
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>                             
                    <dx:EmptyLayoutItem></dx:EmptyLayoutItem>
                    <dx:LayoutItem Caption="Nombre en Cheque:" ColSpan="2">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtNOMBRE_CH" runat="server" MaxLength="100" Width="600px">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="Nombre segun NIT obligatorio" IsRequired="True" />                                    
                                    </ValidationSettings>                                
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>   
                    <dx:LayoutItem Caption="Telefono:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtTELEFONO" runat="server">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="N° de Cuenta Contable">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxTextBox ID="txtNOCUENTA" runat="server" MaxLength="20">
                                    <ValidationSettings Display="Dynamic" ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField ErrorText="N° de Cuenta Contable obligatorio" IsRequired="True" />                                    
                                    </ValidationSettings> 
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>                             
                    <dx:LayoutItem Caption="Código SIGASI:" Name="libCOD_SIGASI">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer  runat="server">
                                <dx:ASPxSpinEdit ID="speCOD_SIGASI" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCOD_SIGASI" >                                
                                </dx:ASPxSpinEdit>                             
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Código Combustible:" Name="libCOD_COMBUST">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxSpinEdit ID="speCOD_COMBUST" runat="server" HorizontalAlign="Right" AllowNull="true" AllowUserInput="true" ClientInstanceName="speCOD_COMBUST" >                                
                                </dx:ASPxSpinEdit>                             
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem> 
                    <dx:LayoutItem Caption="Banco pago a cuenta:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                                <dx:ASPxComboBox ID="cbxBANCO_PAGO_CTA" runat="server" DataSourceID="odsBancos" TextField="NOMBRE_BANCO" ValueField="CODIBANCO" ValueType="System.Int32"  >
                                </dx:ASPxComboBox>  
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="N° de Cuenta bancaria:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                                <dx:ASPxTextBox ID="txtNUM_CUENTA" runat="server" ClientInstanceName="txtNUM_CUENTA_v" MaxLength="30">
                                </dx:ASPxTextBox> 
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Es Cuenta Corriente:">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                                <dx:ASPxCheckBox ID="chkES_CTA_CORRIENTE" runat="server" />  
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Codiproveedor" ClientVisible="false">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                <dx:ASPxTextBox ID="txtCODIPROVEEDOR_V" runat="server">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>         
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
        </td>
    </tr>
    <tr>
        <td>
            <hr />
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="aspxLabel18" runat="server" Text="Vehículos del Transportista" Font-Bold="true" />
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%">
                <tr>
                    <td width="200px"><dx:ASPxLabel ID="aspxLabel1" runat="server" Text="Placa" /></td>
                    <td width="270px"><dx:ASPxLabel ID="aspxLabel2" runat="server" Text="Tipo Transporte" /></td>
                    <td width="170px"><dx:ASPxLabel ID="aspxLabel3" runat="server" Text="Remolque" /></td>
                    <td width="220px"><dx:ASPxLabel ID="aspxLabel4" runat="server" Text="Marca" /></td>
                    <td width="160px" style="text-align:right"><dx:ASPxLabel ID="aspxLabel5" runat="server" Text="Capacidad" /></td>
                    <td width="100px"><dx:ASPxLabel ID="aspxLabel6" runat="server" Text="Año" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxTextBox ID="txtPLACA" runat="server" MaxLength="100" Width="100%" >
                        </dx:ASPxTextBox> 
                    </td>
                    <td>
                        <dx:ASPxComboBox ID="cbxTIPO_TRANSPORTE" runat="server"  DataSourceID="odsTipoTransporte" ValueField="ID_TIPOTRANS" TextField="NOMBRE" ValueType="System.Int32" Width="100%">
                        <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxComboBox> 
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtREMOLQUE" runat="server" MaxLength="100" Width="100%" >
                        </dx:ASPxTextBox> 
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtMARCA" runat="server" MaxLength="50" Width="100%" >
                        </dx:ASPxTextBox>
                    </td>
                    <td><dx:ASPxSpinEdit ID="speCAPACIDAD" HorizontalAlign="Right" runat="server" DecimalPlaces="2" Number="0" DisplayFormatString="#,###0.00"  SpinButtons-ShowIncrementButtons="false" Width="100%" >
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td>
                        <dx:ASPxSpinEdit ID="speANIO" HorizontalAlign="Right" runat="server" DisplayFormatString="#,###" Width="100px" >
                            <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>
                        </dx:ASPxSpinEdit>
                    </td>
                    <td><dx:ASPxButton ID="btnAgregarTransporte" CausesValidation="false" ToolTip="Agregar Transporte" Width="20px" Theme="RedWine" runat="server" Text="+"></dx:ASPxButton></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <uc1:ucListaTRANSPORTE id="ucListaTRANSPORTE1" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false" PermitirEditarInline="true" PermitirEliminarInline="true" PermitirEliminar="true"  runat="server"></uc1:ucListaTRANSPORTE>                                                                                        
        </td>
    </tr>
</table>

<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />

<asp:ObjectDataSource ID="odsBancos" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cBANCOS">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_BANCO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTipoTransporte" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SISPACAL.BL.cTIPO_TRANSPORTE">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />       
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
