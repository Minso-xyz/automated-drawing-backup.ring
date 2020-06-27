Public Class Form1
    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        Dim internalDiameter As Double
        Dim externalDiameter As Double
        Dim height As Double

        internalDiameter = textbox_internalDiameter.Text
        externalDiameter = textbox_externalDiameter.Text
        height = textbox_height.Text

        label_test.Text = "ID is " & internalDiameter & ", OD is " & externalDiameter & ", and H is " & height & "."

    End Sub
End Class
