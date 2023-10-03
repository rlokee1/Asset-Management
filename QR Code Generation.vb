Public Class QRCodeGeneration

Private Sub QRGen_btn_Click(sender As Object, e As EventArgs) Handles QRGen_btn.Click
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = QRcode_txtbox.Text

        Try
            QR_picbox.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, QRcode_txtbox.Text))
        Catch ex As Exception
            QR_picbox.Image = Nothing
        End Try
End Sub

Private Sub QRSave_btn_Click(sender As Object, e As EventArgs) Handles QRSave_btn.Click
        Dim SD As New SaveFileDialog
        SD.FileName = "Visual Qr Code Generator"
        SD.Filter = "PNG Files Only(*.png)|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            QR_picbox.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png)
            MsgBox("Image Has been Save", MsgBoxStyle.Information)
        End If
End Sub

Private Sub QRClear_btn_Click(sender As Object, e As EventArgs) Handles QRClear_btn.Click
        QRcode_txtbox.Text = ""
        QR_picbox.Image = Nothing
End Sub

Private Sub QR_Backbtn_Click(sender As Object, e As EventArgs) Handles QR_Backbtn.Click
        Me.Close()
End Sub
End Class

