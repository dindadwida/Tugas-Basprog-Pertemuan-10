Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, i, faktorial, fibo, kuadrat, x, y As Integer
        n = TextBox1.Text 'untuk menginputkan bilangan
        faktorial = 1 'inisialisasi variabel faktorial = 1
        x = 1 'inisialisasi variabel x = 1
        y = 1 'inisialisasi variabel y = 1

        kuadrat = n * n 'rumus kuadrat yaitu bilangan dikali dengan bilangan itu sendiri

        'perulangan
        For i = 1 To n 'untuk i = 1 sampai i = nilai a(bilangan yang diinput)
            faktorial = faktorial * i 'pengubah nilai faktorial yang dikali dengan nilai i
            If i = 1 Or i = 2 Then 'jika i = 1 atau i = 2
                fibo = 1 'maka fibonacci = 1
            Else 'selain dari itu
                fibo = x + y 'fibonacci = nilai x + nilai y
                x = y 'nilai x menjadi nilai y
                y = fibo 'nilai y sama dengan nilai fibonacci
            End If
        Next

        TextBox2.Text = faktorial 'nilai faktorial disimpan di textbox2
        TextBox3.Text = fibo 'nilai fibonacci disimpan di textbox3
        TextBox4.Text = kuadrat 'nilai kuadrat disimpan di textbox4
    End Sub
End Class
