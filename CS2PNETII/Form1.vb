﻿Public Class Form1

    Private Sub btnAleatoreo_Click(sender As Object, e As EventArgs) Handles btnAleatoreo.Click

        ' Para los números Aleatoreos 
        Dim numAleatorio As New Random()
        destino1x.Text = numAleatorio.Next(300, 900)
        destino1y.Text = numAleatorio.Next(20, 600)

        destino2x.Text = numAleatorio.Next(300, 900)
        destino2y.Text = numAleatorio.Next(20, 600)

        destino3x.Text = numAleatorio.Next(300, 900)
        destino3y.Text = numAleatorio.Next(20, 600)

        destino4x.Text = numAleatorio.Next(300, 900)
        destino4y.Text = numAleatorio.Next(20, 600)

        destino5x.Text = numAleatorio.Next(300, 900)
        destino5y.Text = numAleatorio.Next(20, 600)

        destino6x.Text = numAleatorio.Next(300, 900)
        destino6y.Text = numAleatorio.Next(20, 600)

        ' Para los pictureBox

        PictureBox1.Location = New Point(destino1x.Text, destino1y.Text)
        PictureBox1.Image = Image.FromFile("C:\Images\0_apple.bmp")

        PictureBox2.Location = New Point(destino2x.Text, destino2y.Text)
        PictureBox2.Image = Image.FromFile("C:\Images\1_google.bmp")

        PictureBox3.Location = New Point(destino3x.Text, destino3y.Text)
        PictureBox3.Image = Image.FromFile("C:\Images\2_huawei.bmp")

        PictureBox4.Location = New Point(destino4x.Text, destino4y.Text)
        PictureBox4.Image = Image.FromFile("C:\Images\3_microsoft.bmp")

        PictureBox5.Location = New Point(destino5x.Text, destino5y.Text)
        PictureBox5.Image = Image.FromFile("C:\Images\4_samsung.bmp")

        PictureBox6.Location = New Point(destino6x.Text, destino6y.Text)
        PictureBox6.Image = Image.FromFile("C:\Images\5_xiaomi.bmp")


        'Curva 


        Dim g As Graphics = CreateGraphics()


        Dim miLapiz As New Pen(Brushes.Black)

        Dim punto0 As New Point(274, 50)
        Dim punto1 As New Point(CInt(destino1x.Text), CInt(destino1y.Text))
        Dim punto2 As New Point(CInt(destino2x.Text), CInt(destino2y.Text))
        Dim punto3 As New Point(CInt(destino3x.Text), CInt(destino3y.Text))
        Dim punto4 As New Point(CInt(destino4x.Text), CInt(destino4y.Text))
        Dim punto5 As New Point(CInt(destino5x.Text), CInt(destino5y.Text))
        Dim punto6 As New Point(CInt(destino6x.Text), CInt(destino6y.Text))

        Dim curva As Point() = {punto0, punto1, punto2, punto3, punto4, punto5, punto6}
        miLapiz.Width = 5
        g.DrawCurve(miLapiz, curva)
        miLapiz.Dispose()

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True



    End Sub


    Private Sub Form1_Paint(ByVal sender As System.Object,
        ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        RectanguloG(e)

    End Sub

    Private Sub RectanguloG(ByVal e As PaintEventArgs)
        Dim rectangulo As Rectangle = New Rectangle(New Point(260, 20), New Size(900, 600))
        Dim brochaG As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(rectangulo, Color.Green, Color.White, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(brochaG, rectangulo)
        brochaG.Dispose()
    End Sub

    Private Sub GuardarImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarImagenToolStripMenuItem.Click

        If (PictureBox6.Image Is Nothing) Then
            MessageBox.Show("No se a encontrado la imagen")
        Else

            SaveFileDialog1.Filter = "Archivos BMP|*.bmp" & "|Archivos GIF|*.gif" &
            "|Archivos JPG|*.jpg;*.jpeg" & "|Archivos PNG|*.png" &
            "|Archivos TIFF|*.tif"
            SaveFileDialog1.FilterIndex = 3
            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                If SaveFileDialog1.FileName <> "" Then
                    Dim fs As System.IO.FileStream = CType(SaveFileDialog1.OpenFile(),
                   System.IO.FileStream)
                    Try
                        Select Case SaveFileDialog1.FilterIndex
                            Case 1
                                PictureBox6.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp)
                            Case 2
                                PictureBox6.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif)
                            Case 3
                                PictureBox6.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg)
                            Case 4
                                PictureBox6.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png)
                            Case 5
                                PictureBox6.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Tiff)
                        End Select
                        MessageBox.Show("La imagen se guardó correctamente")
                        fs.Close()
                    Catch ex As Exception
                        MessageBox.Show("Se produjo el siguiente error: " &
                       ex.Message)
                        fs.Close()
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub CambiarLogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarLogoToolStripMenuItem.Click
        With OpenFileDialog1
            .Filter = "Archivo BMP|*.bmp" & "|Archivo GIF|*.gif" & "|Archivo JPG |*.jpg;*.jpeg" & "|Archivo PNG|*.png" & "|Archivo TIFF|*.tif"
            .FilterIndex = 3
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                PictureBox6.Image = Image.FromFile(.FileName)
                PictureBox6.Size = PictureBox1.Image.Size
            End If
        End With
    End Sub
End Class
