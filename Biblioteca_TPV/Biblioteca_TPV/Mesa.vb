Namespace negocio

    Public Class Mesa

        'TODO: Habría que validar estos campos también en esta clase, no siempre donde se instancie
        Private idMesa As Integer
        Private numComensales As Integer

        Public Sub New(ByVal idMesa As Integer, ByVal numComensales As Integer)
            Me.idMesa = idMesa
            Me.numComensales = numComensales
        End Sub

        Public Function getIDMesa() As Integer
            Return Me.idMesa
        End Function

        Public Function getNumComensales() As Integer
            Return Me.numComensales
        End Function

    End Class

End Namespace