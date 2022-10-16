''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaORDEN_ROZA_ENCA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'ORDEN_ROZA_ENCA',
''' es una representación en memoria de los registros de la tabla ORDEN_ROZA_ENCA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaORDEN_ROZA_ENCA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaORDEN_ROZA_ENCA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ORDEN_ROZA_ENCA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ORDEN_ROZA_ENCA
        Get
            Return CType((List(index)), ORDEN_ROZA_ENCA)
        End Get
        Set(ByVal Value As ORDEN_ROZA_ENCA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ORDEN_ROZA_ENCA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_ROZA_ENCA = CType(List(i), ORDEN_ROZA_ENCA)
            If s.ID_ORDEN = value.ID_ORDEN Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_ORDEN As Int32) As ORDEN_ROZA_ENCA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ORDEN_ROZA_ENCA = CType(List(i), ORDEN_ROZA_ENCA)
            If s.ID_ORDEN = ID_ORDEN Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ORDEN_ROZA_ENCAEnumerator
        Return New ORDEN_ROZA_ENCAEnumerator(Me)
    End Function

    Public Class ORDEN_ROZA_ENCAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaORDEN_ROZA_ENCA)
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
