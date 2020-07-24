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
        'label_test.Text = "ID is " & internalDiameter & ", OD is " & externalDiameter & ", and H is " & height & "."
        'label_test2.Text = "Split type is " & splitType & "."
        'label_temp.Text = "Fascia is " & fascia & ". Medio is " & medio & ". Drawing N° is " + drawingNumber + "."

        '##### Get the Inventor Application object
        Dim invApp As Inventor.Application
         invApp = GetObject(, "Inventor.Application")

        '##### Open the part.'
        invApp.Documents.Open("\\dataserver2019\Tecnici\CARCO\EngineeringTEAM\AUTOMATIC_CREATOR\automated-drawing-backup.ring\backup_ring\backup_ring\backup_ring.ipt")

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

        '##### Calculation Fascia
        If textbox_externalDiameter.Text < 300 Then
            fascia = fascia - 0.4
        Else If textbox_externalDiameter.Text >= 300 AND textbox_externalDiameter.Text < 900 Then
            fascia = fascia - 0.6
        Else
            fascia = fascia - 0.8
        End If

        '##### Calculation External diameter
        externalDiameter = medio + fascia

        '##### Assign extra 1mm on diameter in case of double split.'
        If split = True Then
            externalDiameter = externalDiameter + 1
            End If

        ' ##### Tolerance setting
        Call oFasciaParam.Tolerance.SetToSymmetric("0.2 mm")

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
        oDoc = invApp.Documents.Open("\\dataserver2019\Tecnici\CARCO\EngineeringTEAM\AUTOMATIC_CREATOR\automated-drawing-backup.ring\backup_ring\backup_ring\backup_ring.idw")
        oDoc.File.ReferencedFileDescriptors(1).ReplaceReference("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".ipt")

        '##### Scale the drawing views according to the external diameter.'
        ' ##### View A'
        Dim oViewA As DrawingView
        oViewA = oDoc.ActiveSheet.DrawingViews.Item(1)
        If textbox_externalDiameter.Text < 100 Then
            oViewA.[Scale] = 0.8
        ElseIf textbox_externalDiameter.Text >= 100 And textbox_externalDiameter.Text < 150 Then   ' #Verified
            oViewA.[Scale] = 0.7
        ElseIf textbox_externalDiameter.Text >= 150 And textbox_externalDiameter.Text < 200 Then   ' #Verified
            oViewA.[Scale] = 0.65
        ElseIf textbox_externalDiameter.Text >= 200 And textbox_externalDiameter.Text < 250 Then   ' #Verified
            oViewA.[Scale] = 0.6
        ElseIf textbox_externalDiameter.Text >= 250 And textbox_externalDiameter.Text < 300 Then   ' #Verified
            oViewA.[Scale] = 0.55
        ElseIf textbox_externalDiameter.Text >= 300 And textbox_externalDiameter.Text < 350 Then   ' #Verified
            oViewA.[Scale] = 0.5
        ElseIf textbox_externalDiameter.Text >= 350 And textbox_externalDiameter.Text < 400 Then   ' #Verified
            oViewA.[Scale] = 0.45
        ElseIf textbox_externalDiameter.Text >= 400 And textbox_externalDiameter.Text < 450 Then   ' #Verified
            oViewA.[Scale] = 0.4
        ElseIf textbox_externalDiameter.Text >= 450 And textbox_externalDiameter.Text < 500 Then   ' 
            oViewA.[Scale] = 0.3
        ElseIf textbox_externalDiameter.Text >= 500 And textbox_externalDiameter.Text < 550 Then
            oViewA.[Scale] = 0.25
        ElseIf textbox_externalDiameter.Text >= 550 And textbox_externalDiameter.Text < 600 Then
            oViewA.[Scale] = 0.4
        ElseIf textbox_externalDiameter.Text >= 600 And textbox_externalDiameter.Text < 650 Then
            oViewA.[Scale] = 0.35
        ElseIf textbox_externalDiameter.Text >= 650 And textbox_externalDiameter.Text < 700 Then
            oViewA.[Scale] = 0.3
        ElseIf textbox_externalDiameter.Text >= 700 And textbox_externalDiameter.Text < 750 Then
            oViewA.[Scale] = 0.25
        ElseIf textbox_externalDiameter.Text >= 750 And textbox_externalDiameter.Text < 800 Then
            oViewA.[Scale] = 0.2
        ElseIf textbox_externalDiameter.Text >= 800 And textbox_externalDiameter.Text < 850 Then
            oViewA.[Scale] = 0.15
        ElseIf textbox_externalDiameter.Text >= 850 And textbox_externalDiameter.Text < 900 Then
            oViewA.[Scale] = 0.1
        ElseIf textbox_externalDiameter.Text >= 900 And textbox_externalDiameter.Text < 950 Then
            oViewA.[Scale] = 0.45
        ElseIf textbox_externalDiameter.Text >= 950 And textbox_externalDiameter.Text < 1000 Then
            oViewA.[Scale] = 0.4
        ElseIf textbox_externalDiameter.Text >= 1000 And textbox_externalDiameter.Text < 1050 Then
            oViewA.[Scale] = 0.35
        ElseIf textbox_externalDiameter.Text >= 1050 And textbox_externalDiameter.Text < 1100 Then
            oViewA.[Scale] = 0.3
        ElseIf textbox_externalDiameter.Text >= 1100 And textbox_externalDiameter.Text < 1150 Then
            oViewA.[Scale] = 0.25
        ElseIf textbox_externalDiameter.Text >= 1150 And textbox_externalDiameter.Text < 1200 Then
            oViewA.[Scale] = 0.2
        ElseIf textbox_externalDiameter.Text >= 1200 And textbox_externalDiameter.Text < 1250 Then
            oViewA.[Scale] = 0.15
        ElseIf textbox_externalDiameter.Text >= 1250 And textbox_externalDiameter.Text < 1300 Then
            oViewA.[Scale] = 0.1
        Else
            oViewA.[Scale] = 0.05
        End If

        ' ##### Detail view "B".'
        Dim oViewB As DetailDrawingView
        For Each oSheet As Sheet In oDoc.Sheets
            For Each oView As DrawingView In oSheet.DrawingViews
                If oView.ViewType = DrawingViewTypeEnum.kDetailDrawingViewType Then
                    oViewB = oView
                End If
            Next
        Next

        'Set the scale of Detail View B depending on the size
        'Scale the detail drawing view according to the height.
        If textbox_height.Text < 5 Then
            oViewB.[Scale] = 5
        ElseIf textbox_height.Text >= 5 And textbox_height.Text < 20 Then
            oViewB.[Scale] = 4
        ElseIf textbox_height.Text >= 20 And textbox_height.Text < 35 Then
            oViewB.[Scale] = 3
        Else
            oViewB.[Scale] = 2
        End If

        '##### Save the drawing-document with the assigned name (drawingNumber).'
        invApp.ActiveDocument.SaveAs("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".idw", False)

        '##### Update the document.'
        invApp.ActiveDocument.Update

        ' ##### Export to PDF.'
        ' Get the active docuement.
        oDoc = invApp.activeDocument

        ' Save a copy as a PDF file.
        Call oDoc.SaveAs("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".pdf", True)

        ' Save a copy as a jpeg file.
        'Call oDoc.SaveAs("\\dataserver2019\Tecnici\CARCO\DISEGNI\TORNITURA+MODIFICHE\" + drawingNumber + ".jpg", True)

    End Sub
End Class
