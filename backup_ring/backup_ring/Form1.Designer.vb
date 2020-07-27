<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textbox_internalDiameter = New System.Windows.Forms.TextBox()
        Me.label_internalDiameter = New System.Windows.Forms.Label()
        Me.label_first = New System.Windows.Forms.Label()
        Me.label_externalDiameter = New System.Windows.Forms.Label()
        Me.textbox_externalDiameter = New System.Windows.Forms.TextBox()
        Me.label_slash = New System.Windows.Forms.Label()
        Me.label_per = New System.Windows.Forms.Label()
        Me.label_height = New System.Windows.Forms.Label()
        Me.textbox_height = New System.Windows.Forms.TextBox()
        Me.button_ok = New System.Windows.Forms.Button()
        Me.radiobutton_endless = New System.Windows.Forms.RadioButton()
        Me.radiobutton_split = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_drawingNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textbox_object = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textbox_signature = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboBox_materialType = New System.Windows.Forms.ComboBox()
        Me.checkBox_thirdParty = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'textbox_internalDiameter
        '
        Me.textbox_internalDiameter.Location = New System.Drawing.Point(11, 64)
        Me.textbox_internalDiameter.Margin = New System.Windows.Forms.Padding(2)
        Me.textbox_internalDiameter.Name = "textbox_internalDiameter"
        Me.textbox_internalDiameter.Size = New System.Drawing.Size(84, 20)
        Me.textbox_internalDiameter.TabIndex = 0
        '
        'label_internalDiameter
        '
        Me.label_internalDiameter.AutoSize = True
        Me.label_internalDiameter.Location = New System.Drawing.Point(9, 48)
        Me.label_internalDiameter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_internalDiameter.Name = "label_internalDiameter"
        Me.label_internalDiameter.Size = New System.Drawing.Size(85, 13)
        Me.label_internalDiameter.TabIndex = 1
        Me.label_internalDiameter.Text = "Internal diameter"
        '
        'label_first
        '
        Me.label_first.AutoSize = True
        Me.label_first.Location = New System.Drawing.Point(9, 16)
        Me.label_first.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_first.Name = "label_first"
        Me.label_first.Size = New System.Drawing.Size(200, 13)
        Me.label_first.TabIndex = 2
        Me.label_first.Text = "Please fill the below form and click ""OK""."
        '
        'label_externalDiameter
        '
        Me.label_externalDiameter.AutoSize = True
        Me.label_externalDiameter.Location = New System.Drawing.Point(108, 48)
        Me.label_externalDiameter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_externalDiameter.Name = "label_externalDiameter"
        Me.label_externalDiameter.Size = New System.Drawing.Size(88, 13)
        Me.label_externalDiameter.TabIndex = 3
        Me.label_externalDiameter.Text = "External diameter"
        '
        'textbox_externalDiameter
        '
        Me.textbox_externalDiameter.Location = New System.Drawing.Point(110, 64)
        Me.textbox_externalDiameter.Margin = New System.Windows.Forms.Padding(2)
        Me.textbox_externalDiameter.Name = "textbox_externalDiameter"
        Me.textbox_externalDiameter.Size = New System.Drawing.Size(85, 20)
        Me.textbox_externalDiameter.TabIndex = 4
        '
        'label_slash
        '
        Me.label_slash.AutoSize = True
        Me.label_slash.Location = New System.Drawing.Point(98, 67)
        Me.label_slash.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_slash.Name = "label_slash"
        Me.label_slash.Size = New System.Drawing.Size(12, 13)
        Me.label_slash.TabIndex = 5
        Me.label_slash.Text = "/"
        '
        'label_per
        '
        Me.label_per.AutoSize = True
        Me.label_per.Location = New System.Drawing.Point(199, 68)
        Me.label_per.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_per.Name = "label_per"
        Me.label_per.Size = New System.Drawing.Size(11, 13)
        Me.label_per.TabIndex = 6
        Me.label_per.Text = "*"
        '
        'label_height
        '
        Me.label_height.AutoSize = True
        Me.label_height.Location = New System.Drawing.Point(212, 48)
        Me.label_height.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_height.Name = "label_height"
        Me.label_height.Size = New System.Drawing.Size(38, 13)
        Me.label_height.TabIndex = 7
        Me.label_height.Text = "Height"
        '
        'textbox_height
        '
        Me.textbox_height.Location = New System.Drawing.Point(213, 64)
        Me.textbox_height.Margin = New System.Windows.Forms.Padding(2)
        Me.textbox_height.Name = "textbox_height"
        Me.textbox_height.Size = New System.Drawing.Size(74, 20)
        Me.textbox_height.TabIndex = 8
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(215, 287)
        Me.button_ok.Margin = New System.Windows.Forms.Padding(2)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(79, 35)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'radiobutton_endless
        '
        Me.radiobutton_endless.AutoSize = True
        Me.radiobutton_endless.Location = New System.Drawing.Point(11, 101)
        Me.radiobutton_endless.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobutton_endless.Name = "radiobutton_endless"
        Me.radiobutton_endless.Size = New System.Drawing.Size(62, 17)
        Me.radiobutton_endless.TabIndex = 11
        Me.radiobutton_endless.TabStop = True
        Me.radiobutton_endless.Text = "Endless"
        Me.radiobutton_endless.UseVisualStyleBackColor = True
        '
        'radiobutton_split
        '
        Me.radiobutton_split.AutoSize = True
        Me.radiobutton_split.Location = New System.Drawing.Point(11, 123)
        Me.radiobutton_split.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobutton_split.Name = "radiobutton_split"
        Me.radiobutton_split.Size = New System.Drawing.Size(85, 17)
        Me.radiobutton_split.TabIndex = 12
        Me.radiobutton_split.TabStop = True
        Me.radiobutton_split.Text = "Double splits"
        Me.radiobutton_split.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Drawing N° :"
        '
        'textbox_drawingNumber
        '
        Me.textbox_drawingNumber.AcceptsReturn = True
        Me.textbox_drawingNumber.Location = New System.Drawing.Point(83, 158)
        Me.textbox_drawingNumber.Name = "textbox_drawingNumber"
        Me.textbox_drawingNumber.Size = New System.Drawing.Size(141, 20)
        Me.textbox_drawingNumber.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Object :"
        '
        'textbox_object
        '
        Me.textbox_object.Location = New System.Drawing.Point(83, 185)
        Me.textbox_object.Name = "textbox_object"
        Me.textbox_object.Size = New System.Drawing.Size(141, 20)
        Me.textbox_object.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Signature :"
        '
        'textbox_signature
        '
        Me.textbox_signature.Location = New System.Drawing.Point(83, 239)
        Me.textbox_signature.Name = "textbox_signature"
        Me.textbox_signature.Size = New System.Drawing.Size(53, 20)
        Me.textbox_signature.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Material :"
        '
        'comboBox_materialType
        '
        Me.comboBox_materialType.FormattingEnabled = True
        Me.comboBox_materialType.Items.AddRange(New Object() {"Nylon 6/6", "PTFE"})
        Me.comboBox_materialType.Location = New System.Drawing.Point(83, 211)
        Me.comboBox_materialType.Name = "comboBox_materialType"
        Me.comboBox_materialType.Size = New System.Drawing.Size(141, 21)
        Me.comboBox_materialType.TabIndex = 23
        '
        'checkBox_thirdParty
        '
        Me.checkBox_thirdParty.AutoSize = True
        Me.checkBox_thirdParty.Location = New System.Drawing.Point(15, 297)
        Me.checkBox_thirdParty.Name = "checkBox_thirdParty"
        Me.checkBox_thirdParty.Size = New System.Drawing.Size(129, 17)
        Me.checkBox_thirdParty.TabIndex = 25
        Me.checkBox_thirdParty.Text = "Drawing for third party"
        Me.checkBox_thirdParty.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(305, 335)
        Me.Controls.Add(Me.checkBox_thirdParty)
        Me.Controls.Add(Me.comboBox_materialType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textbox_signature)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textbox_object)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textbox_drawingNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radiobutton_split)
        Me.Controls.Add(Me.radiobutton_endless)
        Me.Controls.Add(Me.button_ok)
        Me.Controls.Add(Me.textbox_height)
        Me.Controls.Add(Me.label_height)
        Me.Controls.Add(Me.label_per)
        Me.Controls.Add(Me.label_slash)
        Me.Controls.Add(Me.textbox_externalDiameter)
        Me.Controls.Add(Me.label_externalDiameter)
        Me.Controls.Add(Me.label_first)
        Me.Controls.Add(Me.label_internalDiameter)
        Me.Controls.Add(Me.textbox_internalDiameter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Back-up ring creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox_internalDiameter As TextBox
    Friend WithEvents label_internalDiameter As Label
    Friend WithEvents label_first As Label
    Friend WithEvents label_externalDiameter As Label
    Friend WithEvents textbox_externalDiameter As TextBox
    Friend WithEvents label_slash As Label
    Friend WithEvents label_per As Label
    Friend WithEvents label_height As Label
    Friend WithEvents textbox_height As TextBox
    Friend WithEvents button_ok As Button
    Friend WithEvents radiobutton_endless As RadioButton
    Friend WithEvents radiobutton_split As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_drawingNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_object As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_signature As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBox_materialType As ComboBox
    Friend WithEvents checkBox_thirdParty As CheckBox
End Class
