
Imports System.Text.Encoding
Imports System.IO
Imports System.Text



Public Class Form2
    Public voci(16) As String
    Public voci2(16) As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






        Form1.RadioButton1.Text = Form1.voci(1)
        Form1.RadioButton2.Text = Form1.voci(2)
        Form1.RadioButton4.Text = Form1.voci(3)
        Form1.RadioButton3.Text = Form1.voci(4)
        Form1.RadioButton8.Text = Form1.voci(5)
        Form1.RadioButton7.Text = Form1.voci(6)
        Form1.RadioButton6.Text = Form1.voci(7)
        Form1.RadioButton5.Text = Form1.voci(8)
        Form1.RadioButton24.Text = Form1.voci(9)
        Form1.RadioButton23.Text = Form1.voci(10)
        Form1.RadioButton22.Text = Form1.voci(11)
        Form1.RadioButton21.Text = Form1.voci(12)
        Form1.RadioButton20.Text = Form1.voci(13)
        Form1.RadioButton19.Text = Form1.voci(14)
        Form1.RadioButton18.Text = Form1.voci(15)
        Form1.RadioButton17.Text = Form1.voci(16)














    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs)




    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged




        Form1.voci(1) = TB1.Text


    End Sub

    Private Sub TB2_TextChanged(sender As Object, e As EventArgs) Handles TB2.TextChanged

        Form1.voci(2) = TB2.Text



    End Sub

    Private Sub TB3_TextChanged(sender As Object, e As EventArgs) Handles TB3.TextChanged
        Form1.voci(3) = TB3.Text
    End Sub

    Private Sub TB4_TextChanged(sender As Object, e As EventArgs) Handles TB4.TextChanged
        Form1.voci(4) = TB4.Text
    End Sub

    Private Sub TB5_TextChanged(sender As Object, e As EventArgs) Handles TB5.TextChanged
        Form1.voci(5) = TB5.Text
    End Sub

    Private Sub TB6_TextChanged(sender As Object, e As EventArgs) Handles TB6.TextChanged
        Form1.voci(6) = TB6.Text
    End Sub

    Private Sub TB7_TextChanged(sender As Object, e As EventArgs) Handles TB7.TextChanged
        Form1.voci(7) = TB7.Text
    End Sub

    Private Sub TB8_TextChanged(sender As Object, e As EventArgs) Handles TB8.TextChanged
        Form1.voci(8) = TB8.Text
    End Sub

    Private Sub TB9_TextChanged(sender As Object, e As EventArgs) Handles TB9.TextChanged
        Form1.voci(9) = TB9.Text
    End Sub

    Private Sub TB10_TextChanged(sender As Object, e As EventArgs) Handles TB10.TextChanged
        Form1.voci(10) = TB10.Text
    End Sub

    Private Sub TB11_TextChanged(sender As Object, e As EventArgs) Handles TB11.TextChanged
        Form1.voci(11) = TB11.Text
    End Sub

    Private Sub TB12_TextChanged(sender As Object, e As EventArgs) Handles TB12.TextChanged
        Form1.voci(12) = TB12.Text
    End Sub

    Private Sub TB13_TextChanged(sender As Object, e As EventArgs) Handles TB13.TextChanged
        Form1.voci(13) = TB13.Text
    End Sub

    Private Sub TB14_TextChanged(sender As Object, e As EventArgs) Handles TB14.TextChanged
        Form1.voci(14) = TB14.Text
    End Sub

    Private Sub TB15_TextChanged(sender As Object, e As EventArgs) Handles TB15.TextChanged
        Form1.voci(15) = TB15.Text
    End Sub

    Private Sub TB16_TextChanged(sender As Object, e As EventArgs) Handles TB16.TextChanged
        Form1.voci(16) = TB16.Text
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub
End Class