''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.CCF_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row CCF_ENCA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/09/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="CCF_ENCA")> Public Class CCF_ENCA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_CCF_ENCA As Int32, aID_ZAFRA As Int32, aID_SOLICITUD As Int32, aID_ORDEN As Int32, aID_CUENTA_FINAN As Int32, aID_TIPO_COMPROB As Int32, aNO_CCF As String, aFECHA As DateTime, aCODIPROVEEDOR As String, aSUB_TOTAL As Decimal, aDESCTO_PORC As Decimal, aDESCTO_MONTO As Decimal, aSUMAS As Decimal, aIVA As Decimal, aTOTAL As Decimal, aTOTAL_LETRAS As String, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aCONDI_COMPRA As Int32, aID_PROVEE As Int32, aCONCEPTO_CCF As Int32, aUID_REFERENCIA_CCF As Guid, aFOVIAL_COTRANS As Decimal)
        Me._ID_CCF_ENCA = aID_CCF_ENCA
        Me._ID_ZAFRA = aID_ZAFRA
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_ORDEN = aID_ORDEN
        Me._ID_CUENTA_FINAN = aID_CUENTA_FINAN
        Me._ID_TIPO_COMPROB = aID_TIPO_COMPROB
        Me._NO_CCF = aNO_CCF
        Me._FECHA = aFECHA
        Me._CODIPROVEEDOR = aCODIPROVEEDOR
        Me._SUB_TOTAL = aSUB_TOTAL
        Me._DESCTO_PORC = aDESCTO_PORC
        Me._DESCTO_MONTO = aDESCTO_MONTO
        Me._SUMAS = aSUMAS
        Me._IVA = aIVA
        Me._TOTAL = aTOTAL
        Me._TOTAL_LETRAS = aTOTAL_LETRAS
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._CONDI_COMPRA = aCONDI_COMPRA
        Me._ID_PROVEE = aID_PROVEE
        Me._CONCEPTO_CCF = aCONCEPTO_CCF
        Me._UID_REFERENCIA_CCF = aUID_REFERENCIA_CCF
        Me._FOVIAL_COTRANS = aFOVIAL_COTRANS
    End Sub

#Region " Properties "

    Private _ID_CCF_ENCA As Int32
    <Column(Name:="Id ccf enca", Storage:="ID_CCF_ENCA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CCF_ENCA() As Int32
        Get
            Return _ID_CCF_ENCA
        End Get
        Set(ByVal Value As Int32)
            _ID_CCF_ENCA = Value
            OnPropertyChanged("ID_CCF_ENCA")
        End Set
    End Property 

    Private _ID_ZAFRA As Int32
    <Column(Name:="Id zafra", Storage:="ID_ZAFRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ZAFRA() As Int32
        Get
            Return _ID_ZAFRA
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRA = Value
            OnPropertyChanged("ID_ZAFRA")
        End Set
    End Property 

    Private _ID_ZAFRAOld As Int32
    Public Property ID_ZAFRAOld() As Int32
        Get
            Return _ID_ZAFRAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ZAFRAOld = Value
        End Set
    End Property 

    Private _fkID_ZAFRA As ZAFRA
    Public Property fkID_ZAFRA() As ZAFRA
        Get
            Return _fkID_ZAFRA
        End Get
        Set(ByVal Value As ZAFRA)
            _fkID_ZAFRA = Value
        End Set
    End Property 

    Private _ID_SOLICITUD As Int32
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_SOLICITUD() As Int32
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_SOLICITUDOld As Int32
    Public Property ID_SOLICITUDOld() As Int32
        Get
            Return _ID_SOLICITUDOld
        End Get
        Set(ByVal Value As Int32)
            _ID_SOLICITUDOld = Value
        End Set
    End Property 

    Private _fkID_SOLICITUD As SOLIC_AGRICOLA
    Public Property fkID_SOLICITUD() As SOLIC_AGRICOLA
        Get
            Return _fkID_SOLICITUD
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA)
            _fkID_SOLICITUD = Value
        End Set
    End Property 

    Private _ID_ORDEN As Int32
    <Column(Name:="Id orden", Storage:="ID_ORDEN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_ORDEN() As Int32
        Get
            Return _ID_ORDEN
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDEN = Value
            OnPropertyChanged("ID_ORDEN")
        End Set
    End Property 

    Private _ID_ORDENOld As Int32
    Public Property ID_ORDENOld() As Int32
        Get
            Return _ID_ORDENOld
        End Get
        Set(ByVal Value As Int32)
            _ID_ORDENOld = Value
        End Set
    End Property 

    Private _fkID_ORDEN As ORDEN_COMPRA_AGRI
    Public Property fkID_ORDEN() As ORDEN_COMPRA_AGRI
        Get
            Return _fkID_ORDEN
        End Get
        Set(ByVal Value As ORDEN_COMPRA_AGRI)
            _fkID_ORDEN = Value
        End Set
    End Property 

    Private _ID_CUENTA_FINAN As Int32
    <Column(Name:="Id cuenta finan", Storage:="ID_CUENTA_FINAN", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_CUENTA_FINAN() As Int32
        Get
            Return _ID_CUENTA_FINAN
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINAN = Value
            OnPropertyChanged("ID_CUENTA_FINAN")
        End Set
    End Property 

    Private _ID_CUENTA_FINANOld As Int32
    Public Property ID_CUENTA_FINANOld() As Int32
        Get
            Return _ID_CUENTA_FINANOld
        End Get
        Set(ByVal Value As Int32)
            _ID_CUENTA_FINANOld = Value
        End Set
    End Property 

    Private _fkID_CUENTA_FINAN As CUENTA_FINAN
    Public Property fkID_CUENTA_FINAN() As CUENTA_FINAN
        Get
            Return _fkID_CUENTA_FINAN
        End Get
        Set(ByVal Value As CUENTA_FINAN)
            _fkID_CUENTA_FINAN = Value
        End Set
    End Property 

    Private _ID_TIPO_COMPROB As Int32
    <Column(Name:="Id tipo comprob", Storage:="ID_TIPO_COMPROB", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_COMPROB() As Int32
        Get
            Return _ID_TIPO_COMPROB
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROB = Value
            OnPropertyChanged("ID_TIPO_COMPROB")
        End Set
    End Property 

    Private _ID_TIPO_COMPROBOld As Int32
    Public Property ID_TIPO_COMPROBOld() As Int32
        Get
            Return _ID_TIPO_COMPROBOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_COMPROBOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_COMPROB As TIPO_COMPROB
    Public Property fkID_TIPO_COMPROB() As TIPO_COMPROB
        Get
            Return _fkID_TIPO_COMPROB
        End Get
        Set(ByVal Value As TIPO_COMPROB)
            _fkID_TIPO_COMPROB = Value
        End Set
    End Property 

    Private _NO_CCF As String
    <Column(Name:="No ccf", Storage:="NO_CCF", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_CCF() As String
        Get
            Return _NO_CCF
        End Get
        Set(ByVal Value As String)
            _NO_CCF = Value
            OnPropertyChanged("NO_CCF")
        End Set
    End Property 

    Private _NO_CCFOld As String
    Public Property NO_CCFOld() As String
        Get
            Return _NO_CCFOld
        End Get
        Set(ByVal Value As String)
            _NO_CCFOld = Value
        End Set
    End Property 

    Private _FECHA As DateTime
    <Column(Name:="Fecha", Storage:="FECHA", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA() As DateTime
        Get
            Return _FECHA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA = Value
            OnPropertyChanged("FECHA")
        End Set
    End Property 

    Private _FECHAOld As DateTime
    Public Property FECHAOld() As DateTime
        Get
            Return _FECHAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHAOld = Value
        End Set
    End Property 

    Private _CODIPROVEEDOR As String
    <Column(Name:="Codiproveedor", Storage:="CODIPROVEEDOR", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property CODIPROVEEDOR() As String
        Get
            Return _CODIPROVEEDOR
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOR = Value
            OnPropertyChanged("CODIPROVEEDOR")
        End Set
    End Property 

    Private _CODIPROVEEDOROld As String
    Public Property CODIPROVEEDOROld() As String
        Get
            Return _CODIPROVEEDOROld
        End Get
        Set(ByVal Value As String)
            _CODIPROVEEDOROld = Value
        End Set
    End Property 

    Private _fkCODIPROVEEDOR As PROVEEDOR
    Public Property fkCODIPROVEEDOR() As PROVEEDOR
        Get
            Return _fkCODIPROVEEDOR
        End Get
        Set(ByVal Value As PROVEEDOR)
            _fkCODIPROVEEDOR = Value
        End Set
    End Property 

    Private _SUB_TOTAL As Decimal
    <Column(Name:="Sub total", Storage:="SUB_TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SUB_TOTAL() As Decimal
        Get
            Return _SUB_TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTAL = Value
            OnPropertyChanged("SUB_TOTAL")
        End Set
    End Property 

    Private _SUB_TOTALOld As Decimal
    Public Property SUB_TOTALOld() As Decimal
        Get
            Return _SUB_TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _SUB_TOTALOld = Value
        End Set
    End Property 

    Private _DESCTO_PORC As Decimal
    <Column(Name:="Descto porc", Storage:="DESCTO_PORC", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property DESCTO_PORC() As Decimal
        Get
            Return _DESCTO_PORC
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_PORC = Value
            OnPropertyChanged("DESCTO_PORC")
        End Set
    End Property 

    Private _DESCTO_PORCOld As Decimal
    Public Property DESCTO_PORCOld() As Decimal
        Get
            Return _DESCTO_PORCOld
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_PORCOld = Value
        End Set
    End Property 

    Private _DESCTO_MONTO As Decimal
    <Column(Name:="Descto monto", Storage:="DESCTO_MONTO", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property DESCTO_MONTO() As Decimal
        Get
            Return _DESCTO_MONTO
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_MONTO = Value
            OnPropertyChanged("DESCTO_MONTO")
        End Set
    End Property 

    Private _DESCTO_MONTOOld As Decimal
    Public Property DESCTO_MONTOOld() As Decimal
        Get
            Return _DESCTO_MONTOOld
        End Get
        Set(ByVal Value As Decimal)
            _DESCTO_MONTOOld = Value
        End Set
    End Property 

    Private _SUMAS As Decimal
    <Column(Name:="Sumas", Storage:="SUMAS", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property SUMAS() As Decimal
        Get
            Return _SUMAS
        End Get
        Set(ByVal Value As Decimal)
            _SUMAS = Value
            OnPropertyChanged("SUMAS")
        End Set
    End Property 

    Private _SUMASOld As Decimal
    Public Property SUMASOld() As Decimal
        Get
            Return _SUMASOld
        End Get
        Set(ByVal Value As Decimal)
            _SUMASOld = Value
        End Set
    End Property 

    Private _IVA As Decimal
    <Column(Name:="Iva", Storage:="IVA", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property IVA() As Decimal
        Get
            Return _IVA
        End Get
        Set(ByVal Value As Decimal)
            _IVA = Value
            OnPropertyChanged("IVA")
        End Set
    End Property 

    Private _IVAOld As Decimal
    Public Property IVAOld() As Decimal
        Get
            Return _IVAOld
        End Get
        Set(ByVal Value As Decimal)
            _IVAOld = Value
        End Set
    End Property 

    Private _TOTAL As Decimal
    <Column(Name:="Total", Storage:="TOTAL", DbType:="NUMERIC(20,2)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL() As Decimal
        Get
            Return _TOTAL
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL = Value
            OnPropertyChanged("TOTAL")
        End Set
    End Property 

    Private _TOTALOld As Decimal
    Public Property TOTALOld() As Decimal
        Get
            Return _TOTALOld
        End Get
        Set(ByVal Value As Decimal)
            _TOTALOld = Value
        End Set
    End Property 

    Private _TOTAL_LETRAS As String
    <Column(Name:="Total letras", Storage:="TOTAL_LETRAS", DbType:="VARCHAR(300)", Id:=False), _
     DataObjectField(False, False, True, 300)> _
    Public Property TOTAL_LETRAS() As String
        Get
            Return _TOTAL_LETRAS
        End Get
        Set(ByVal Value As String)
            _TOTAL_LETRAS = Value
            OnPropertyChanged("TOTAL_LETRAS")
        End Set
    End Property 

    Private _TOTAL_LETRASOld As String
    Public Property TOTAL_LETRASOld() As String
        Get
            Return _TOTAL_LETRASOld
        End Get
        Set(ByVal Value As String)
            _TOTAL_LETRASOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATETIME", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _CONDI_COMPRA As Int32
    <Column(Name:="Condi compra", Storage:="CONDI_COMPRA", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CONDI_COMPRA() As Int32
        Get
            Return _CONDI_COMPRA
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRA = Value
            OnPropertyChanged("CONDI_COMPRA")
        End Set
    End Property 

    Private _CONDI_COMPRAOld As Int32
    Public Property CONDI_COMPRAOld() As Int32
        Get
            Return _CONDI_COMPRAOld
        End Get
        Set(ByVal Value As Int32)
            _CONDI_COMPRAOld = Value
        End Set
    End Property 

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _ID_PROVEEOld As Int32
    Public Property ID_PROVEEOld() As Int32
        Get
            Return _ID_PROVEEOld
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEOld = Value
        End Set
    End Property 

    Private _fkID_PROVEE As PROVEEDOR_AGRICOLA
    Public Property fkID_PROVEE() As PROVEEDOR_AGRICOLA
        Get
            Return _fkID_PROVEE
        End Get
        Set(ByVal Value As PROVEEDOR_AGRICOLA)
            _fkID_PROVEE = Value
        End Set
    End Property 

    Private _CONCEPTO_CCF As Int32
    <Column(Name:="Concepto ccf", Storage:="CONCEPTO_CCF", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property CONCEPTO_CCF() As Int32
        Get
            Return _CONCEPTO_CCF
        End Get
        Set(ByVal Value As Int32)
            _CONCEPTO_CCF = Value
            OnPropertyChanged("CONCEPTO_CCF")
        End Set
    End Property 

    Private _CONCEPTO_CCFOld As Int32
    Public Property CONCEPTO_CCFOld() As Int32
        Get
            Return _CONCEPTO_CCFOld
        End Get
        Set(ByVal Value As Int32)
            _CONCEPTO_CCFOld = Value
        End Set
    End Property 

    Private _UID_REFERENCIA_CCF As Guid
    <Column(Name:="Uid referencia ccf", Storage:="UID_REFERENCIA_CCF", DbType:="UNIQUEIDENTIFIER(36, 0) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 16)> _
    Public Property UID_REFERENCIA_CCF() As Guid
        Get
            Return _UID_REFERENCIA_CCF
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA_CCF = Value
            OnPropertyChanged("UID_REFERENCIA_CCF")
        End Set
    End Property 

    Private _UID_REFERENCIA_CCFOld As Guid
    Public Property UID_REFERENCIA_CCFOld() As Guid
        Get
            Return _UID_REFERENCIA_CCFOld
        End Get
        Set(ByVal Value As Guid)
            _UID_REFERENCIA_CCFOld = Value
        End Set
    End Property

    Private _FOVIAL_COTRANS As Decimal
    <Column(Name:="FOVIAL_COTRANS", Storage:="FOVIAL_COTRANS", DbType:="NUMERIC(20,2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property FOVIAL_COTRANS() As Decimal
        Get
            Return _FOVIAL_COTRANS
        End Get
        Set(ByVal Value As Decimal)
            _FOVIAL_COTRANS = Value
            OnPropertyChanged("FOVIAL_COTRANS")
        End Set
    End Property

    Private _FOVIAL_COTRANSOld As Decimal
    Public Property FOVIAL_COTRANSOld() As Decimal
        Get
            Return _FOVIAL_COTRANSOld
        End Get
        Set(ByVal Value As Decimal)
            _FOVIAL_COTRANSOld = Value
        End Set
    End Property

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
