Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numAleatorio As New Random()
        tbCoordX.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        tbCoordY.Text = System.Convert.ToString(numAleatorio.Next(200, 700))
    End Sub
End Class
