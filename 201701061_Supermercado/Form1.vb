Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vector < 5 Then


            If TextBox1.Text <> "" Then
                nombre(vector) = TextBox1.Text
            Else
                MsgBox("Por favor ingrese el nombre del pack ")
                TextBox1.Focus() : Exit Sub
            End If



            If Val(TextBox2.Text <> "") Then
                Cantidad(vector) = TextBox2.Text
            Else
                MsgBox("Por favor ingrese la cantidad  ")
                TextBox2.Focus() : Exit Sub
            End If



            Select Case ComboBox1.SelectedIndex
                Case 0
                    preciounitario(vector) = Pjugos
                    Pack(vector) = Math.Round(Val(Pjugos * Cantidad(vector)), 2)
                Case 1
                    preciounitario(vector) = pfrituras
                    Pack(vector) = Math.Round(Val(pfrituras * Cantidad(vector)), 2)
                Case 2
                    preciounitario(vector) = Pgalletas
                    Pack(vector) = Math.Round(Val(Pgalletas * Cantidad(vector)), 2)
                Case 3
                    preciounitario(vector) = pbaterias
                    Pack(vector) = Math.Round(Val(pbaterias * Cantidad(vector)), 2)
                Case Else
                    MsgBox("Por favor selecciones un pack")
                    TextBox1.Focus()
            End Select

            If Cantidad(vector) > 10 Then
                descuento(vector) = Pack(vector) * 0.1
            ElseIf Cantidad(vector) <= 3 Then
                descuento(vector) = Pack(vector) * 0.03
            Else
                descuento(vector) = Pack(vector) * 0.05
            End If
            pagototal(vector) = Math.Round(Val(Pack(vector) - descuento(vector)), 2)
            pagoparcial(vector) = Pack(vector)

            MostrarV()
            vector = vector + 1
        End If

        If vector = 6 Then
            MsgBox("Se llego al limite del almacenamiento")
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiargrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiardatos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        salir()
    End Sub
End Class
