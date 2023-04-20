Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Integer
        For f = 0 To 255
            ComboBox1.Items.Add(f)
            ComboBox2.Items.Add(f)
            ComboBox3.Items.Add(f)
        Next
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Text = ""
        If CheckBox1.Checked = True Then
            Text = Text + "(Pantalones)"
        End If
        If CheckBox2.Checked = True Then
            Text = Text + "(Camisas)"
        End If
        If CheckBox3.Checked = True Then
            Text = Text + "(Chamarras)"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Width = 780
            Height = 690
        Else
            If RadioButton2.Checked = True Then
                Width = 820
                Height = 710
            Else
                If RadioButton3.Checked = True Then
                    Width = 1080
                    Height = 820
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rojo As Integer = ComboBox1.Text
        Dim verde As Integer = ComboBox2.Text
        Dim azul As Integer = ComboBox3.Text
        BackColor = Color.FromArgb(rojo, verde, azul)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub
End Class


