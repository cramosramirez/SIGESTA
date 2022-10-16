''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_AGRICOLA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/10/2017	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_AGRICOLA")> Public Class PROVEEDOR_AGRICOLA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEE As Int32, aNOMBRE As String, aDUI As String, aNIT As String, aNRC As String, aTIPO_CONTRIBUYENTE As Int32, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aZAFRA As String, aES_PROVEE_VUELO As Boolean, aES_CASA_COMER As Boolean, aNOMBRE_LEGAL As String)
        Me._ID_PROVEE = aID_PROVEE
        Me._NOMBRE = aNOMBRE
        Me._DUI = aDUI
        Me._NIT = aNIT
        Me._NRC = aNRC
        Me._TIPO_CONTRIBUYENTE = aTIPO_CONTRIBUYENTE
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._ZAFRA = aZAFRA
        Me._ES_PROVEE_VUELO = aES_PROVEE_VUELO
        Me._ES_CASA_COMER = aES_CASA_COMER
        Me._NOMBRE_LEGAL = aNOMBRE_LEGAL
    End Sub

#Region " Properties "

    Private _ID_PROVEE As Int32
    <Column(Name:="Id provee", Storage:="ID_PROVEE", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEE() As Int32
        Get
            Return _ID_PROVEE
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEE = Value
            OnPropertyChanged("ID_PROVEE")
        End Set
    End Property 

    Private _NOMBRE As String
    <Column(Name:="Nombre", Storage:="NOMBRE", DbType:="VARCHAR(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal Value As String)
            _NOMBRE = Value
            OnPropertyChanged("NOMBRE")
        End Set
    End Property 

    Private _NOMBREOld As String
    Public Property NOMBREOld() As String
        Get
            Return _NOMBREOld
        End Get
        Set(ByVal Value As String)
            _NOMBREOld = Value
        End Set
    End Property 

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="VARCHAR(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property DUI() As String
        Get
            Return _DUI
        End Get
        Set(ByVal Value As String)
            _DUI = Value
            OnPropertyChanged("DUI")
        End Set
    End Property 

    Private _DUIOld As String
    Public Property DUIOld() As String
        Get
            Return _DUIOld
        End Get
        Set(ByVal Value As String)
            _DUIOld = Value
        End Set
    End Property 

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="VARCHAR(14)", Id:=False), _
     DataObjectField(False, False, True, 14)> _
    Public Property NIT() As String
        Get
            Return _NIT
        End Get
        Set(ByVal Value As String)
            _NIT = Value
            OnPropertyChanged("NIT")
        End Set
    End Property 

    Private _NITOld As String
    Public Property NITOld() As String
        Get
            Return _NITOld
        End Get
        Set(ByVal Value As String)
            _NITOld = Value
        End Set
    End Property 

    Private _NRC As String
    <Column(Name:="Nrc", Storage:="NRC", DbType:="CHAR(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property NRC() As String
        Get
            Return _NRC
        End Get
        Set(ByVal Value As String)
            _NRC = Value
            OnPropertyChanged("NRC")
        End Set
    End Property 

    Private _NRCOld As String
    Public Property NRCOld() As String
        Get
            Return _NRCOld
        End Get
        Set(ByVal Value As String)
            _NRCOld = Value
        End Set
    End Property 

    Private _TIPO_CONTRIBUYENTE As Int32
    <Column(Name:="Tipo contribuyente", Storage:="TIPO_CONTRIBUYENTE", DbType:="INT", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=255)> _
    Public Property TIPO_CONTRIBUYENTE() As Int32
        Get
            Return _TIPO_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTE = Value
            OnPropertyChanged("TIPO_CONTRIBUYENTE")
        End Set
    End Property 

    Private _TIPO_CONTRIBUYENTEOld As Int32
    Public Property TIPO_CONTRIBUYENTEOld() As Int32
        Get
            Return _TIPO_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Int32)
            _TIPO_CONTRIBUYENTEOld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATETIME NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

    Private _ZAFRA As String
    <Column(Name:="Zafra", Storage:="ZAFRA", DbType:="VARCHAR(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
    Public Property ZAFRA() As String
        Get
            Return _ZAFRA
        End Get
        Set(ByVal Value As String)
            _ZAFRA = Value
            OnPropertyChanged("ZAFRA")
        End Set
    End Property 

    Private _ZAFRAOld As String
    Public Property ZAFRAOld() As String
        Get
            Return _ZAFRAOld
        End Get
        Set(ByVal Value As String)
            _ZAFRAOld = Value
        End Set
    End Property 

    Private _ES_PROVEE_VUELO As Boolean
    <Column(Name:="Es provee vuelo", Storage:="ES_PROVEE_VUELO", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_PROVEE_VUELO() As Boolean
        Get
            Return _ES_PROVEE_VUELO
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROVEE_VUELO = Value
            OnPropertyChanged("ES_PROVEE_VUELO")
        End Set
    End Property 

    Private _ES_PROVEE_VUELOOld As Boolean
    Public Property ES_PROVEE_VUELOOld() As Boolean
        Get
            Return _ES_PROVEE_VUELOOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_PROVEE_VUELOOld = Value
        End Set
    End Property 

    Private _ES_CASA_COMER As Boolean
    <Column(Name:="Es casa comer", Storage:="ES_CASA_COMER", DbType:="BIT", Id:=False), _
     DataObjectField(False, False, True, 1)> _
    Public Property ES_CASA_COMER() As Boolean
        Get
            Return _ES_CASA_COMER
        End Get
        Set(ByVal Value As Boolean)
            _ES_CASA_COMER = Value
            OnPropertyChanged("ES_CASA_COMER")
        End Set
    End Property 

    Private _ES_CASA_COMEROld As Boolean
    Public Property ES_CASA_COMEROld() As Boolean
        Get
            Return _ES_CASA_COMEROld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CASA_COMEROld = Value
        End Set
    End Property 

    Private _NOMBRE_LEGAL As String
    <Column(Name:="Nombre legal", Storage:="NOMBRE_LEGAL", DbType:="VARCHAR(200)", Id:=False), _
     DataObjectField(False, False, True, 200)> _
    Public Property NOMBRE_LEGAL() As String
        Get
            Return _NOMBRE_LEGAL
        End Get
        Set(ByVal Value As String)
            _NOMBRE_LEGAL = Value
            OnPropertyChanged("NOMBRE_LEGAL")
        End Set
    End Property 

    Private _NOMBRE_LEGALOld As String
    Public Property NOMBRE_LEGALOld() As String
        Get
            Return _NOMBRE_LEGALOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_LEGALOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
