Module Module1


    Public Pjugos = 8.5
    Public pfrituras = 11.2
    Public Pgalletas = 4.25
    Public pbaterias = 15

    Public nombre(6) As String
    Public Cantidad(6) As Byte
    Public Pack(6) As String
    Public preciounitario(6)
    Public pagoparcial(6)
    Public descuento(6)
    Public pagototal(6)



    Public vector As Byte = 0


    Sub MostrarV()

        Form1.DataGridView1.Rows.Add(nombre(vector), Cantidad(vector), preciounitario(vector), pagoparcial(vector), descuento(vector), pagototal(vector))

    End Sub











    Sub limpiardatos()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.SelectedIndex = -1


    End Sub

    Sub limpiargrid()
        Form1.DataGridView1.Rows.Clear()
    End Sub

    Sub salir()
        If (MsgBox("Esta seguro que desea salir ", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiardatos()
            limpiargrid()
        End If
    End Sub


End Module
