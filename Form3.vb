Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, rp, usd, eur, ringgit, won, yen, peso As Decimal

        rp = TextBox1.Text 'untuk menginputkan nilai mata uang rupiah

        Select Case ComboBox1.Text 'mengecek yang dipilih pada combotext1
            Case "Dolar Amerika Serikat (USD)" 'jika yang dipilih ada combotext1 adalah "Dolar Amerika Serikat (USD)"
                n = rp / 13942.99 'nilai rupiah yang diinput dibagi dengan 13942.99
            Case "Euro (EUR)" 'jika yang dipilih ada combotext1 adalah "Euro (EUR)"
                n = rp / 16720 'nilai rupiah yang diinput dibagi dengan 16720
            Case "Peso Filipina (PHP)" 'jika yang dipilih ada combotext1 adalah "Peso Filipina (PHP)"
                n = rp / 269 'nilai rupiah yang diinput dibagi dengan 269
            Case "Ringgit Malaysia (MYR)" 'jika yang dipilih ada combotext1 adalah "Ringgit Malaysia (MYR)"
                n = rp / 3546 'nilai rupiah yang diinput dibagi dengan 3546
            Case "Won Korea (KRW)" 'jika yang dipilih ada combotext1 adalah "Won Korea (KRW)"
                n = rp / 13 'nilai rupiah yang diinput dibagi dengan 13
            Case "Yen Jepang (JPY)" 'jika yang dipilih ada combotext1 adalah "Yen Jepang (JPY)"
                n = rp / 127 'nilai rupiah yang diinput dibagi dengan 127
        End Select

        TextBox2.Text = rp 'nilai rupiah disimpan ke textbox2
        TextBox3.Text = n 'hasil konversi mata uang disimpan ke textbox3
        TextBox3.Text = FormatNumber(n, 2) 'untuk mengatur angka desimal setelah koma menjadi 2 digit
        Label7.Text = ComboBox1.Text 'hasil pilihan pada combobox1 disimpan ke label7
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear() 'membersihkan textbox1
        ComboBox1.Text = "" 'mengosongkan combobox1
        TextBox2.Clear() 'membersihkan textbox2
        TextBox3.Clear() 'membersihkan textbox3
        Label7.Text = "..." 'mengosongkan label7
    End Sub
End Class