Public Class Form1

    Dim provincia As String
    Dim habitantes As String
    Dim codigo As String
    Dim mayor As Double
    Dim menor As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provincia = TextBox1.Text & TextBox2.Text & TextBox3.Text
        habitantes = TextBox4.Text & TextBox5.Text & TextBox6.Text
        codigo = TextBox7.Text & TextBox8.Text & TextBox9.Text

        'If TextBox4.Text < TextBox5.Text Then

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then
            MsgBox("Debe llenar las provincias")
        ElseIf TextBox7.Text = Nothing Or TextBox8.Text = Nothing Or TextBox9.Text = Nothing Then
            MsgBox("Debe llenar las el código de la provincia")
        Else
            ' MsgBox("Debe llenar los habitantes")
            ListBox1.Items.Add(provincia)
            ListBox1.Items.Add(habitantes)
            ListBox1.Items.Add(codigo)
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = TextBox4.Text
        Dim b As Integer = TextBox5.Text
        Dim c As Integer = TextBox6.Text

        If a > b And a > c Then
            Label4.Text = a
        Else
            If b > a And b > c Then
                Label4.Text = b
            Else
                If c > a And c > b Then
                    Label4.Text = c
                End If
            End If
        End If


        If a < b And a < c Then
            Label3.Text = a
        Else
            If b < a And b < c Then
                Label3.Text = b
            Else
                If c < a And c < b Then
                    Label3.Text = c
                End If
            End If
        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
