Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, i, j As Integer
        Dim bentuk As String

        n = TextBox1.Text 'untuk menginputkan tinggi 

        If RadioButton1.Checked = True Then 'jika bentuk 1 dipilih
            For i = 1 To n 'i = 1 sampai i = n
                For j = 1 To i 'j = 1 sampai j = 1
                    bentuk = bentuk & " " & "*" 'bentuk = " " dan "*"
                Next
                bentuk = bentuk & vbCrLf 'bentuk = " " dan "*" lalu ganti baris
            Next
            TextBox2.Text = bentuk 'bentuk disimpan ke textbox2
        End If

        If RadioButton2.Checked = True Then 'jika bentuk 2 dipilih
            For i = 1 To n 'i = 1 sampai i = n
                For j = i To n 'j = i sampai j = n
                    bentuk = bentuk & " *" 'bentuk = " *"
                Next
                bentuk = bentuk & vbCrLf 'bentuk = " *" lalu ganti baris
            Next
            TextBox2.Text = bentuk 'bentuk disimpan ke textbox2
        End If


        If RadioButton3.Checked = True Then 'jika bentuk 3 dipilih
            For i = 1 To n 'i = 1 sampai i = n
                bentuk = bentuk & vbCrLf 'bentuk = ganti baris
                For j = 1 To n 'j = 1 sampai j = n
                    bentuk = bentuk & " *" 'bentuk = ganti baris dan " *"
                Next
            Next
            TextBox2.Text = bentuk 'bentuk disimpan ke textbox2
        End If


        If RadioButton4.Checked = True Then 'jika bentuk 4 dipilih
            For i = 1 To n 'i = 1 sampai i = n
                For j = i To n 'j = i sampai j = n
                    bentuk = bentuk & " " 'bentuk = " "
                Next
                For j = 1 To i
                    bentuk = bentuk & " *" 'bentuk = " " dan " *"

                Next
                bentuk = bentuk & vbCrLf 'bentuk = " " dan " *" lalu ganti baris
            Next
            TextBox2.Text = bentuk 'bentuk disimpan ke textbox2
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End 'untuk keluar dari program
    End Sub
End Class