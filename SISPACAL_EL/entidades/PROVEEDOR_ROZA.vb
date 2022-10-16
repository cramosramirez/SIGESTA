''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.PROVEEDOR_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row PROVEEDOR_ROZA en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/11/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="PROVEEDOR_ROZA")> Public Class PROVEEDOR_ROZA
    Inherits entidadBase

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_PROVEEDOR_ROZA As Int32, aNOMBRE_PROVEEDOR_ROZA As String, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime, aNIT As String, aDUI As String, aCREDITO_FISCAL As String, aES_CONTRIBUYENTE As Boolean, aFACTOR_PAGO As Decimal, aID_TIPO_ROZA As Int32, aACTIVO As Boolean)
        Me._ID_PROVEEDOR_ROZA = aID_PROVEEDOR_ROZA
        Me._NOMBRE_PROVEEDOR_ROZA = aNOMBRE_PROVEEDOR_ROZA
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
        Me._NIT = aNIT
        Me._DUI = aDUI
        Me._CREDITO_FISCAL = aCREDITO_FISCAL
        Me._ES_CONTRIBUYENTE = aES_CONTRIBUYENTE
        Me._FACTOR_PAGO = aFACTOR_PAGO
        Me._ID_TIPO_ROZA = aID_TIPO_ROZA
        Me._ACTIVO = aACTIVO
    End Sub

#Region " Properties "

    Private _ID_PROVEEDOR_ROZA As Int32
    <Column(Name:="Id proveedor roza", Storage:="ID_PROVEEDOR_ROZA", DbType:="INT NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_PROVEEDOR_ROZA() As Int32
        Get
            Return _ID_PROVEEDOR_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_PROVEEDOR_ROZA = Value
            OnPropertyChanged("ID_PROVEEDOR_ROZA")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_ROZA As String
    <Column(Name:="Nombre proveedor roza", Storage:="NOMBRE_PROVEEDOR_ROZA", DbType:="VARCHAR(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property NOMBRE_PROVEEDOR_ROZA() As String
        Get
            Return _NOMBRE_PROVEEDOR_ROZA
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_ROZA = Value
            OnPropertyChanged("NOMBRE_PROVEEDOR_ROZA")
        End Set
    End Property 

    Private _NOMBRE_PROVEEDOR_ROZAOld As String
    Public Property NOMBRE_PROVEEDOR_ROZAOld() As String
        Get
            Return _NOMBRE_PROVEEDOR_ROZAOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_PROVEEDOR_ROZAOld = Value
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

    Private _NIT As String
    <Column(Name:="Nit", Storage:="NIT", DbType:="CHAR(14)", Id:=False), _
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

    Private _DUI As String
    <Column(Name:="Dui", Storage:="DUI", DbType:="CHAR(9)", Id:=False), _
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

    Private _CREDITO_FISCAL As String
    <Column(Name:="Credito fiscal", Storage:="CREDITO_FISCAL", DbType:="VARCHAR(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property CREDITO_FISCAL() As String
        Get
            Return _CREDITO_FISCAL
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCAL = Value
            OnPropertyChanged("CREDITO_FISCAL")
        End Set
    End Property 

    Private _CREDITO_FISCALOld As String
    Public Property CREDITO_FISCALOld() As String
        Get
            Return _CREDITO_FISCALOld
        End Get
        Set(ByVal Value As String)
            _CREDITO_FISCALOld = Value
        End Set
    End Property 

    Private _ES_CONTRIBUYENTE As Boolean
    <Column(Name:="Es contribuyente", Storage:="ES_CONTRIBUYENTE", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ES_CONTRIBUYENTE() As Boolean
        Get
            Return _ES_CONTRIBUYENTE
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTE = Value
            OnPropertyChanged("ES_CONTRIBUYENTE")
        End Set
    End Property 

    Private _ES_CONTRIBUYENTEOld As Boolean
    Public Property ES_CONTRIBUYENTEOld() As Boolean
        Get
            Return _ES_CONTRIBUYENTEOld
        End Get
        Set(ByVal Value As Boolean)
            _ES_CONTRIBUYENTEOld = Value
        End Set
    End Property 

    Private _FACTOR_PAGO As Decimal
    <Column(Name:="Factor pago", Storage:="FACTOR_PAGO", DbType:="NUMERIC(10,3)", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=3)> _
    Public Property FACTOR_PAGO() As Decimal
        Get
            Return _FACTOR_PAGO
        End Get
        Set(ByVal Value As Decimal)
            _FACTOR_PAGO = Value
            OnPropertyChanged("FACTOR_PAGO")
        End Set
    End Property 

    Private _FACTOR_PAGOOld As Decimal
    Public Property FACTOR_PAGOOld() As Decimal
        Get
            Return _FACTOR_PAGOOld
        End Get
        Set(ByVal Value As Decimal)
            _FACTOR_PAGOOld = Value
        End Set
    End Property 

    Private _ID_TIPO_ROZA As Int32
    <Column(Name:="Id tipo roza", Storage:="ID_TIPO_ROZA", DbType:="INT NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=10, Scale:=255)> _
    Public Property ID_TIPO_ROZA() As Int32
        Get
            Return _ID_TIPO_ROZA
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZA = Value
            OnPropertyChanged("ID_TIPO_ROZA")
        End Set
    End Property 

    Private _ID_TIPO_ROZAOld As Int32
    Public Property ID_TIPO_ROZAOld() As Int32
        Get
            Return _ID_TIPO_ROZAOld
        End Get
        Set(ByVal Value As Int32)
            _ID_TIPO_ROZAOld = Value
        End Set
    End Property 

    Private _fkID_TIPO_ROZA As TIPOS_GENERALES
    Public Property fkID_TIPO_ROZA() As TIPOS_GENERALES
        Get
            Return _fkID_TIPO_ROZA
        End Get
        Set(ByVal Value As TIPOS_GENERALES)
            _fkID_TIPO_ROZA = Value
        End Set
    End Property 

    Private _ACTIVO As Boolean
    <Column(Name:="Activo", Storage:="ACTIVO", DbType:="BIT NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 1)> _
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
            OnPropertyChanged("ACTIVO")
        End Set
    End Property 

    Private _ACTIVOOld As Boolean
    Public Property ACTIVOOld() As Boolean
        Get
            Return _ACTIVOOld
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVOOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class
