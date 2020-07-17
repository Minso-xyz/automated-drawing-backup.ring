Imports Inventor

Public Class Form1
    Dim internalDiameter As Double
    Dim externalDiameter As Double
    Dim height As Double
    Dim endless As Boolean
    Dim split As Boolean
    Dim splitType As String

    Dim partDoc As Inventor.PartDocument
    Dim param As Inventor.Parameter


    Private Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        'Get the Inventor Application object.
        Dim invApp As Inventor.Application
        invApp = GetObject(, "Inventor.Application")

        'Get the active document.
        Dim doc As Inventor.Document
        doc = invApp.ActiveDocument

        'Get the values from textbox and store as variable (Double)'
        internalDiameter = textbox_internalDiameter.Text
        externalDiameter = textbox_externalDiameter.Text
        height = textbox_height.Text

        Dim fascia As Double = (externalDiameter - internalDiameter) * 0.5
        Dim medio As Double = (externalDiameter + internalDiameter) * 0.5

        'Print the values'
        label_test.Text = "ID is " & internalDiameter & ", OD is " & externalDiameter & ", and H is " & height & "."
        label_test2.Text = "Split type is " & splitType & "."
        label_temp.Text = "Fascia is " & fascia & ". Medio is " & medio & "."

        'Get the Parameters collection.
        Dim params As Inventor.Parameters
        params = partDoc.ComponentDefinition.Parameters

        'Assign the Parameter using its name
        params.Item("fascia_parameter") = fascia

    End Sub

    'Endless Boolean'
    Private Sub radiobutton_endless_Click(sender As Object, e As EventArgs) Handles radiobutton_endless.Click
        If radiobutton_endless.Checked = True Then
            endless = True
            splitType = "Endless"
        End If
    End Sub

    'Double splits Boolean'
    Private Sub radiobutton_split_Click(sender As Object, e As EventArgs) Handles radiobutton_split.Click
        If radiobutton_split.Checked = True Then
            split = True
            splitType = "Double Split"
        End If
    End Sub
   

End Class
