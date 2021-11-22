Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAleatoreo.Click
        Dim numAleatorio As New Random()
        destino1x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino1y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))

        destino2x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino2y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))

        destino3x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino3y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))

        destino4x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino4y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))

        destino5x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino5y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))

        destino6x.Text = System.Convert.ToString(numAleatorio.Next(200, 1000))
        destino6y.Text = System.Convert.ToString(numAleatorio.Next(200, 700))
    End Sub
End Class
