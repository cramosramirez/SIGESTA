''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_EL
''' Class	 : EL.listaPRODUCTO_TIPO_TRANS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase que permite manejar una Colección de Clases del tipo 'PRODUCTO_TIPO_TRANS',
''' es una representación en memoria de los registros de la tabla PRODUCTO_TIPO_TRANS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/10/2018	Created
''' </history>
''' -----------------------------------------------------------------------------
<Serializable()> Public Class listaPRODUCTO_TIPO_TRANS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPRODUCTO_TIPO_TRANS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PRODUCTO_TIPO_TRANS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PRODUCTO_TIPO_TRANS
        Get
            Return CType((List(index)), PRODUCTO_TIPO_TRANS)
        End Get
        Set(ByVal Value As PRODUCTO_TIPO_TRANS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PRODUCTO_TIPO_TRANS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO_TIPO_TRANS = CType(List(i), PRODUCTO_TIPO_TRANS)
            If s.ID_PRODTT = value.ID_PRODTT Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ID_PRODTT As Int32) As PRODUCTO_TIPO_TRANS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PRODUCTO_TIPO_TRANS = CType(List(i), PRODUCTO_TIPO_TRANS)
            If s.ID_PRODTT = ID_PRODTT Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PRODUCTO_TIPO_TRANSEnumerator
        Return New PRODUCTO_TIPO_TRANSEnumerator(Me)
    End Function

    Public Class PRODUCTO_TIPO_TRANSEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPRODUCTO_TIPO_TRANS)
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
