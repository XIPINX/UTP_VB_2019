Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnjalankan.Click
        Dim judul As String
        Dim iterasi As Integer
        judul = txtjudul.Text
        iterasi = txtiterasi.Text
        For i = 1 To iterasi
            ListBox1.Items.Add(txtjudul.Text)
        Next (i)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtiterasi.TextChanged

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        txtjudul.Text = ""
        txtiterasi.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class
