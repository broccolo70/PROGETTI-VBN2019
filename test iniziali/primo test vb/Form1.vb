
Imports System.Net.Sockets
Imports System.Text.Encoding
Imports System.IO
Imports System.Text



Public Class Form1
    Dim variabile As String
    Dim ingressi_matrice As Integer
    Dim uscite_matrice As Integer
    Public voci(16) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connessione As New TcpClient
        Dim trasmissione As NetworkStream
        Dim colore As Integer




        TextBox1.Text = " ** Y" + uscite_matrice.ToString() + "," + ingressi_matrice.ToString() + "!!"
        Dim messaggio() As Byte = ASCII.GetBytes(TextBox1.Text)

        Try
            connessione.Connect("192.168.50.200", 10001)
            If connessione.Connected Then

                trasmissione = connessione.GetStream()
                trasmissione.Write(messaggio, 0, messaggio.Length)
                Dim messaggio_in_ricezione(connessione.ReceiveBufferSize) As Byte
                trasmissione.Read(messaggio_in_ricezione, 0, messaggio_in_ricezione.Length)
                TextBox2.Text = ASCII.GetString(messaggio_in_ricezione)

                Button1.BackColor = Color.Green

            End If
        Catch a As Exception

            Button1.BackColor = Color.Red
            MsgBox(a.Message)



        End Try

        connessione.Close()
        Button1.BackColor = Color.Gray



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


        If (RadioButton1.Checked = True) Then
            ingressi_matrice = 1


        End If
        If (RadioButton2.Checked = True) Then
            ingressi_matrice = 2

        End If

        If (RadioButton4.Checked = True) Then
            ingressi_matrice = 3

        End If
        If (RadioButton3.Checked = True) Then
            ingressi_matrice = 4

        End If

        If (RadioButton8.Checked = True) Then
            ingressi_matrice = 5

        End If
        If (RadioButton7.Checked = True) Then
            ingressi_matrice = 6

        End If

        If (RadioButton6.Checked = True) Then
            ingressi_matrice = 7

        End If
        If (RadioButton5.Checked = True) Then
            ingressi_matrice = 8



        End If


        TextBox1.Text = " ** Y" + "3" + "," + ingressi_matrice.ToString() + "!!"











    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ingressi_matrice = 1
        If RadioButton1.BackColor <> Color.Orchid Then
            RadioButton1.BackColor = Color.Orchid
        Else
            RadioButton1.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        uscite_matrice = 1
        If RadioButton32.BackColor <> Color.Orchid Then
            RadioButton32.BackColor = Color.Orchid
        Else
            RadioButton32.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        uscite_matrice = 15
        If RadioButton10.BackColor <> Color.Orchid Then
            RadioButton10.BackColor = Color.Orchid
        Else
            RadioButton10.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        uscite_matrice = 14
        If RadioButton11.BackColor <> Color.Orchid Then
            RadioButton11.BackColor = Color.Orchid
        Else
            RadioButton11.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        uscite_matrice = 13
        If RadioButton12.BackColor <> Color.Orchid Then
            RadioButton12.BackColor = Color.Orchid
        Else
            RadioButton12.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        uscite_matrice = 12
        If RadioButton13.BackColor <> Color.Orchid Then
            RadioButton13.BackColor = Color.Orchid
        Else
            RadioButton13.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        uscite_matrice = 11
        If RadioButton14.BackColor <> Color.Orchid Then
            RadioButton14.BackColor = Color.Orchid
        Else
            RadioButton14.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        uscite_matrice = 10
        If RadioButton15.BackColor <> Color.Orchid Then
            RadioButton15.BackColor = Color.Orchid
        Else
            RadioButton15.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        uscite_matrice = 9
        If RadioButton16.BackColor <> Color.Orchid Then
            RadioButton16.BackColor = Color.Orchid
        Else
            RadioButton16.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        uscite_matrice = 8
        If RadioButton25.BackColor <> Color.Orchid Then
            RadioButton25.BackColor = Color.Orchid
        Else
            RadioButton25.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        uscite_matrice = 7
        If RadioButton26.BackColor <> Color.Orchid Then
            RadioButton26.BackColor = Color.Orchid
        Else
            RadioButton26.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        uscite_matrice = 6
        If RadioButton27.BackColor <> Color.Orchid Then
            RadioButton27.BackColor = Color.Orchid
        Else
            RadioButton27.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        uscite_matrice = 5
        If RadioButton28.BackColor <> Color.Orchid Then
            RadioButton28.BackColor = Color.Orchid
        Else
            RadioButton28.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        uscite_matrice = 4
        If RadioButton29.BackColor <> Color.Orchid Then
            RadioButton29.BackColor = Color.Orchid
        Else
            RadioButton29.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        uscite_matrice = 16
        If RadioButton9.BackColor <> Color.Orchid Then
            RadioButton9.BackColor = Color.Orchid
        Else
            RadioButton9.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        uscite_matrice = 2
        If RadioButton31.BackColor <> Color.Orchid Then
            RadioButton31.BackColor = Color.Orchid
        Else
            RadioButton31.BackColor = Color.Teal
        End If



    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        uscite_matrice = 3
        If RadioButton30.BackColor <> Color.Orchid Then
            RadioButton30.BackColor = Color.Orchid
        Else
            RadioButton30.BackColor = Color.Teal
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SendToBack()


        LoginForm1.Show()
        Form2.Hide()


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ingressi_matrice = 2
        If RadioButton2.BackColor <> Color.Orchid Then
            RadioButton2.BackColor = Color.Orchid
        Else
            RadioButton2.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ingressi_matrice = 3
        If RadioButton4.BackColor <> Color.Orchid Then
            RadioButton4.BackColor = Color.Orchid
        Else
            RadioButton4.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ingressi_matrice = 4
        If RadioButton3.BackColor <> Color.Orchid Then
            RadioButton3.BackColor = Color.Orchid
        Else
            RadioButton3.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        ingressi_matrice = 5
        If RadioButton8.BackColor <> Color.Orchid Then
            RadioButton8.BackColor = Color.Orchid
        Else
            RadioButton8.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        ingressi_matrice = 6
        If RadioButton7.BackColor <> Color.Orchid Then
            RadioButton7.BackColor = Color.Orchid
        Else
            RadioButton7.BackColor = Color.Teal
        End If


    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ingressi_matrice = 7
        If RadioButton6.BackColor <> Color.Orchid Then
            RadioButton6.BackColor = Color.Orchid
        Else
            RadioButton6.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ingressi_matrice = 8
        If RadioButton5.BackColor <> Color.Orchid Then
            RadioButton5.BackColor = Color.Orchid
        Else
            RadioButton5.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        ingressi_matrice = 9
        If RadioButton24.BackColor <> Color.Orchid Then
            RadioButton24.BackColor = Color.Orchid
        Else
            RadioButton24.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        ingressi_matrice = 10
        If RadioButton23.BackColor <> Color.Orchid Then
            RadioButton23.BackColor = Color.Orchid
        Else
            RadioButton23.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        ingressi_matrice = 11
        If RadioButton22.BackColor <> Color.Orchid Then
            RadioButton22.BackColor = Color.Orchid
        Else
            RadioButton22.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        ingressi_matrice = 12
        If RadioButton21.BackColor <> Color.Orchid Then
            RadioButton21.BackColor = Color.Orchid
        Else
            RadioButton21.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        ingressi_matrice = 13
        If RadioButton20.BackColor <> Color.Orchid Then
            RadioButton20.BackColor = Color.Orchid
        Else
            RadioButton20.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        ingressi_matrice = 14
        If RadioButton19.BackColor <> Color.Orchid Then
            RadioButton19.BackColor = Color.Orchid
        Else
            RadioButton19.BackColor = Color.Teal
        End If

    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        ingressi_matrice = 15
        If RadioButton18.BackColor <> Color.Orchid Then
            RadioButton18.BackColor = Color.Orchid
        Else
            RadioButton18.BackColor = Color.Teal
        End If


    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        ingressi_matrice = 16
        If RadioButton17.BackColor <> Color.Orchid Then
            RadioButton17.BackColor = Color.Orchid
        Else
            RadioButton17.BackColor = Color.Teal
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim elemento_selezionato As ToolStripItem
        elemento_selezionato = e.ClickedItem


        If (elemento_selezionato.Text = "NOMINA SEGNALI") Then

            Form2.Show()
        End If
        If (elemento_selezionato.Text = "CARICA PRESET") Then
            Dim testo As String()
            Dim scambio As String()
            Dim numero_sottostringhe As Integer

            OpenFileDialog1.ShowDialog()


            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            TextBox2.Text = fileReader.ReadToEnd()
            testo = Split(TextBox2.Text, "X")

            For x As Integer = 1 To 16
                scambio = Split(testo(x), ",")
                TextBox4.Text = testo(x)
                TextBox5.Text = scambio(0)



                ingressi_matrice = Integer.Parse(scambio(1))
                uscite_matrice = Integer.Parse(scambio(0))
                commutazione()
                '  Threading.Thread.Sleep(3000)
            Next
        End If

        If (elemento_selezionato.Text = "SALVA PRESET") Then

            Dim connessione As New TcpClient
            Dim trasmissione As NetworkStream
            Dim colore As Integer
            SaveFileDialog1.ShowDialog()
            Dim path As String = SaveFileDialog1.FileName + ".txt"

            Dim fs As FileStream = File.Create(path)
            Dim info As Byte()






            Dim messaggio() As Byte = ASCII.GetBytes("**S!!")

            Try
                connessione.Connect("192.168.50.200", 10001)
                If connessione.Connected Then

                    trasmissione = connessione.GetStream()
                    trasmissione.Write(messaggio, 0, messaggio.Length)
                    Dim messaggio_in_ricezione(connessione.ReceiveBufferSize) As Byte
                    trasmissione.Read(messaggio_in_ricezione, 0, messaggio_in_ricezione.Length)
                    TextBox2.Text = ASCII.GetString(messaggio_in_ricezione)
                    info = New UTF8Encoding(True).GetBytes(TextBox2.Text)
                    fs.Write(info, 0, info.Length)
                    info = New UTF8Encoding(True).GetBytes("  &&  " + RadioButton1.Text + "  &&  " + RadioButton32.Text + "  &&  " +
                                                           RadioButton2.Text + "  &&  " + RadioButton31.Text + "  &&  " +
                                                           RadioButton4.Text + "  &&  " + RadioButton30.Text + "  &&  " +
                                                           RadioButton3.Text + "  &&  " + RadioButton29.Text + "  &&  " +
                                                           RadioButton8.Text + "  &&  " + RadioButton28.Text + "  &&  " +
                                                           RadioButton7.Text + "  &&  " + RadioButton27.Text + "  &&  " +
                                                           RadioButton6.Text + "  &&  " + RadioButton26.Text + "  &&  " +
                                                           RadioButton5.Text + "  &&  " + RadioButton25.Text + "  &&  " +
                                                           RadioButton24.Text + "  &&  " + RadioButton16.Text + "  &&  " +
                                                           RadioButton23.Text + "  &&  " + RadioButton15.Text + "  &&  " +
                                                           RadioButton22.Text + "  &&  " + RadioButton14.Text + "  &&  " +
                                                           RadioButton21.Text + "  &&  " + RadioButton13.Text + "  &&  " +
                                                           RadioButton20.Text + "  &&  " + RadioButton12.Text + "  &&  " +
                                                           RadioButton19.Text + "  &&  " + RadioButton11.Text + "  &&  " +
                                                           RadioButton18.Text + "  &&  " + RadioButton10.Text + "  &&  " +
                                                           RadioButton17.Text + "  &&  " + RadioButton9.Text)
                    fs.Write(info, 0, info.Length)

                    fs.Close()

                    Button1.BackColor = Color.Green

                End If
            Catch a As Exception

                Button1.BackColor = Color.Red
                MsgBox(a.Message)



            End Try

            connessione.Close()
            Button1.BackColor = Color.Gray
        End If



    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        Form2.Show()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Public Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connessione As New TcpClient
        Dim trasmissione As NetworkStream
        Dim colore As Integer

        Dim path As String = "c:\MEMORIA\" + TextBox3.Text + ".txt"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte()






        Dim messaggio() As Byte = ASCII.GetBytes("**S!!")

        Try
            connessione.Connect("192.168.50.200", 10001)
            If connessione.Connected Then

                trasmissione = connessione.GetStream()
                trasmissione.Write(messaggio, 0, messaggio.Length)
                Dim messaggio_in_ricezione(connessione.ReceiveBufferSize) As Byte
                trasmissione.Read(messaggio_in_ricezione, 0, messaggio_in_ricezione.Length)
                TextBox2.Text = ASCII.GetString(messaggio_in_ricezione)
                info = New UTF8Encoding(True).GetBytes(TextBox2.Text)
                fs.Write(info, 0, info.Length)
                info = New UTF8Encoding(True).GetBytes("  &&  " + RadioButton1.Text + "  &&  " + RadioButton32.Text + "  &&  " +
                                                       RadioButton2.Text + "  &&  " + RadioButton31.Text + "  &&  " +
                                                       RadioButton4.Text + "  &&  " + RadioButton30.Text + "  &&  " +
                                                       RadioButton3.Text + "  &&  " + RadioButton29.Text + "  &&  " +
                                                       RadioButton8.Text + "  &&  " + RadioButton28.Text + "  &&  " +
                                                       RadioButton7.Text + "  &&  " + RadioButton27.Text + "  &&  " +
                                                       RadioButton6.Text + "  &&  " + RadioButton26.Text + "  &&  " +
                                                       RadioButton5.Text + "  &&  " + RadioButton25.Text + "  &&  " +
                                                       RadioButton24.Text + "  &&  " + RadioButton16.Text + "  &&  " +
                                                       RadioButton23.Text + "  &&  " + RadioButton15.Text + "  &&  " +
                                                       RadioButton22.Text + "  &&  " + RadioButton14.Text + "  &&  " +
                                                       RadioButton21.Text + "  &&  " + RadioButton13.Text + "  &&  " +
                                                       RadioButton20.Text + "  &&  " + RadioButton12.Text + "  &&  " +
                                                       RadioButton19.Text + "  &&  " + RadioButton11.Text + "  &&  " +
                                                       RadioButton18.Text + "  &&  " + RadioButton10.Text + "  &&  " +
                                                       RadioButton17.Text + "  &&  " + RadioButton9.Text)
                fs.Write(info, 0, info.Length)

                fs.Close()

                Button1.BackColor = Color.Green

            End If
        Catch a As Exception

            Button1.BackColor = Color.Red
            MsgBox(a.Message)



        End Try

        connessione.Close()
        Button1.BackColor = Color.Gray
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim testo As String()
        Dim scambio As String()
        Dim numero_sottostringhe As Integer

        OpenFileDialog1.ShowDialog()


        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
        TextBox2.Text = fileReader.ReadToEnd()
        testo = Split(TextBox2.Text, "X")

        For x As Integer = 1 To 16
            scambio = Split(testo(x), ",")
            TextBox4.Text = testo(x)
            TextBox5.Text = scambio(0)



            ingressi_matrice = Integer.Parse(scambio(1))
            uscite_matrice = Integer.Parse(scambio(0))
            commutazione()
            '  Threading.Thread.Sleep(3000)
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub commutazione()
        Dim connessione As New TcpClient
        Dim trasmissione As NetworkStream


        TextBox1.Text = " ** Y" + uscite_matrice.ToString() + "," + ingressi_matrice.ToString() + "!!"
        Dim messaggio() As Byte = ASCII.GetBytes(TextBox1.Text)

        Try
            connessione.Connect("192.168.50.200", 10001)
            If connessione.Connected Then

                trasmissione = connessione.GetStream()
                trasmissione.Write(messaggio, 0, messaggio.Length)




            End If
        Catch a As Exception

            MsgBox(a.Message)



        End Try

        connessione.Close()
        Threading.Thread.Sleep(50)



    End Sub

End Class





