Public Class UserControl1
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ingressi(16) As TextBoxBase

        ingressi(2) = New TextBox
        ingressi(2).Location = New Point(30, 30)

        ingressi(2).Show()
    End Sub
End Class
