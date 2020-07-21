Imports Inventor

Public Class Form1
    Dim internalDiameter As Double
    Dim externalDiameter As Double
    Dim height As Double
    Dim endless As Boolean
    Dim split As Boolean
    Dim splitType As String

    Dim drawingNumber As String

    Dim partDoc As Inventor.PartDocument
    Dim param As Inventor.Parameter


    '##### Endless/Split Boolean'
    Public Sub radiobutton_endless_Click(sender As Object, e As EventArgs) Handles radiobutton_endless.Click
        If radiobutton_endless.Checked = True Then
            endless = True
            splitType = "Endless"
        End If
    End Sub
    Public Sub radiobutton_split_Click(sender As Object, e As EventArgs) Handles radiobutton_split.Click
        If radiobutton_split.Checked = True Then
            split = True
            splitType = "Double Splits"
        End If
    End Sub

    Public Sub button_ok_Click(sender As Object, e As EventArgs) Handles button_ok.Click
        '##### Get the values from textbox and store as variable (Double)'
        internalDiameter = textbox_internalDiameter.Text
        externalDiameter = textbox_externalDiameter.Text
        height = textbox_height.Text
        drawingNumber = textbox_drawingNumber.Text

        Dim fascia As Double = (externalDiameter - internalDiameter) * 0.5
        Dim medio As Double = (externalDiameter + internalDiameter) * 0.5

        '##### Print the values'
        label_test.Text = "ID is " & internalDiameter & ", OD is " & externalDiameter & ", and H is " & height & "."
        label_test2.Text = "Split type is " & splitType & "."
        label_temp.Text = "Fascia is " & fascia & ". Medio is " & medio & ". Drawing N° is " + drawingNumber + "."

        '##### Get the Inventor Application object
         Dim invApp As Inventor.Application
         invApp = GetObject(, "Inventor.Application")

        '##### Open the part.'
        invApp.Documents.Open("C:\Users\minso\Documents\automated-drawing-backup.ring\backup_ring\backup_ring\backup_ring.ipt")

        '##### Get the active document. This assums it's a part document.
        partDoc = invApp.ActiveDocument

        '##### Get the Parameters collection.
        Dim params As Inventor.Parameters
        params = partDoc.ComponentDefinition.Parameters

        '##### Get the parameter named "fasica_parameter"'
        Dim oFasciaParam As Inventor.Parameter
        oFasciaParam = params.Item("fascia_parameter")

        '##### Get the parameter named "height_parameter"'
        Dim oHeightParam As Inventor.Parameter
        oHeightParam = params.Item("height_parameter")

        '##### Get the parameter named "externalDiameter_parameter"'
        Dim oExternalDiameterParam As Inventor.Parameter
        oExternalDiameterParam = params.Item("externalDiameter_parameter")

        '##### Calculation Fascia & External diameter' - To be optimized
        fascia = fascia - 0.6
        externalDiameter = medio + fascia

        '##### Assign extra 1mm on diameter in case of double split.'
        If split = True Then
            externalDiameter = externalDiameter + 1
            End If

        '##### Change the equation of the parameter.'
        oFasciaParam.Expression = fascia
        oHeightParam.Expression = height
        oExternalDiameterParam.Expression = externalDiameter

        '##### ///Controlling iProperties part'
        '##### Get the "Design Tracking Properties" property set.'
        Dim designTrackPropSet As Inventor.PropertySet
        designTrackPropSet = partDoc.PropertySets.Item("Design Tracking Properties")

        '##### Assign "Drawing N°".'
        '##### Get the "Description" property from the property set.'
        Dim descProp As Inventor.Property
        descProp = designTrackPropSet.Item("Description")
        '##### Set the value of the property using the current value of the textbox.'
        descProp.Value = textbox_object.Text

        '##### Assign "Description (Endless/Double splits)".'
        '##### Get the "Project" property from the property set.'
        Dim splitProp As Inventor.Property
        splitProp = designTrackPropSet.Item("Project")
        '##### Set the value of the property using the current value of the textbox.'
        If endless = True Then
            splitProp.Value = "Back-up ring Endless"
        End If
        If split = True Then
            splitProp.Value = "Back-up ring double splits"
        End If

        '##### Assign "Housing dimension".'
        '##### Get the "Inventor Summary Information" property set.'
        Dim inventorSummaryInfoPropSet As Inventor.PropertySet
        inventorSummaryInfoPropSet = partDoc.PropertySets.Item("Inventor Summary Information")
        '##### Get the "Subject" property from the property set.'
        Dim housingProp As Inventor.Property
        housingProp = inventorSummaryInfoPropSet.Item("Subject")
        '##### Set the value of the property using the current value of the textbox.'
        housingProp.Value = internalDiameter.ToString() + "/" + textbox_externalDiameter.Text.ToString() + " * " + height.ToString()

        '##### Update the document.'
        invApp.ActiveDocument.Update

        '##### Save the part-document with the assigned name (drawingNumber).'
        invApp.ActiveDocument.SaveAs("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".ipt", False)

        '##### Replace the reference .ipt file on the drawing.'
        Dim oDoc As Inventor.DrawingDocument
        oDoc = invApp.Documents.Open("C:\Users\minso\Documents\automated-drawing-backup.ring\backup_ring\backup_ring\backup_ring.idw")
        oDoc.File.ReferencedFileDescriptors(1).ReplaceReference("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".ipt")

        '##### Scale the drawing views according to the external diameter.'
        ' ##### View A'
        Dim oViewA As DrawingView
        oViewA = oDoc.ActiveSheet.DrawingViews.Item(1)
        If externalDiameter < 100 Then
            oViewA.[Scale] = 1
        End If
        If externalDiameter >= 100 & externalDiameter < 200 Then
            oViewA.[Scale] = 0.8
        End If
        If externalDiameter >= 200 Then
            oViewA.[Scale] = 0.5
        End If

        ' ##### View B'
        Dim oViewB As DrawingView
        oViewB = oDoc.ActiveSheet.DrawingViews.Item(2)
        If fascia < 100 Then
            oViewA.[Scale] = 5
        End If
        If fasica >= 100 & fascia < 200 Then
            oViewA.[Scale] = 3
        End If
        If fascia >= 200 Then
            oViewA.[Scale] = 1.5
        End If


        '##### Save the drawing-document with the assigned name (drawingNumber).'
        invApp.ActiveDocument.SaveAs("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".idw", False)

        'Export drawing-document as PDF.'
        'Dim oPM As PrintManager
        'oPM = oDoc.PrintManger
        'oPM.Printer = "Adobe PDF"
        'oPM.PrinteToFile("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".pdf")

    End Sub

End Class
