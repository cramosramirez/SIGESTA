''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaOPCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'OPCION',
''' es una representación en memoria de los registros de la tabla OPCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	31/08/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaOPCION
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaOPCION )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As OPCION)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As OPCION
        Get
            Return CType((List(index)), OPCION)
        End Get
        Set(ByVal Value As OPCION)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As OPCION) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As OPCION = CType(List(i), OPCION)
            If s.ID_OPCION = value.ID_OPCION Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_OPCION As Int32) As OPCION
        Dim i As Integer = 0
        While i < List.Count
            Dim s As OPCION = CType(List(i), OPCION)
            If s.ID_OPCION = ID_OPCION Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As OPCIONEnumerator
        Return New OPCIONEnumerator(Me)
    End Function

    Public Class OPCIONEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaOPCION)
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
