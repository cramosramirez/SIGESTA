''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaSOLIC_AGRICOLA_PRODUCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'SOLIC_AGRICOLA_PRODUCTO',
''' es una representación en memoria de los registros de la tabla SOLIC_AGRICOLA_PRODUCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/06/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaSOLIC_AGRICOLA_PRODUCTO
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaSOLIC_AGRICOLA_PRODUCTO )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As SOLIC_AGRICOLA_PRODUCTO)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As SOLIC_AGRICOLA_PRODUCTO
        Get
            Return CType((List(index)), SOLIC_AGRICOLA_PRODUCTO)
        End Get
        Set(ByVal Value As SOLIC_AGRICOLA_PRODUCTO)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As SOLIC_AGRICOLA_PRODUCTO) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_AGRICOLA_PRODUCTO = CType(List(i), SOLIC_AGRICOLA_PRODUCTO)
            If s.ID_SOLIC_AGRI_PROD = value.ID_SOLIC_AGRI_PROD Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_SOLIC_AGRI_PROD As Int32) As SOLIC_AGRICOLA_PRODUCTO
        Dim i As Integer = 0
        While i < List.Count
            Dim s As SOLIC_AGRICOLA_PRODUCTO = CType(List(i), SOLIC_AGRICOLA_PRODUCTO)
            If s.ID_SOLIC_AGRI_PROD = ID_SOLIC_AGRI_PROD Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As SOLIC_AGRICOLA_PRODUCTOEnumerator
        Return New SOLIC_AGRICOLA_PRODUCTOEnumerator(Me)
    End Function

    Public Class SOLIC_AGRICOLA_PRODUCTOEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaSOLIC_AGRICOLA_PRODUCTO)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class
End Class