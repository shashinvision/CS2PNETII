Public Class Form1
    Private Sub btnAleatoreo_Click(sender As Object, e As EventArgs) Handles btnAleatoreo.Click
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







    Private Sub Form1_Paint(ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        RectanguloG(e)
    End Sub
    Private Sub RectanguloG(ByVal e As PaintEventArgs)
        Dim rectangulo As Rectangle = New Rectangle(New Point(300, 20), New Size(60, 50))
        Dim brochaG As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(rectangulo, Color.Green, Color.Blue, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(brochaG, rectangulo)
        brochaG.Dispose()
    End Sub


End Class
