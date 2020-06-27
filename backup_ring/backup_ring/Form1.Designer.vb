<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.label_test = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textbox_internalDiameter
        '
        Me.textbox_internalDiameter.Location = New System.Drawing.Point(15, 79)
        Me.textbox_internalDiameter.Name = "textbox_internalDiameter"
        Me.textbox_internalDiameter.Size = New System.Drawing.Size(111, 22)
        Me.textbox_internalDiameter.TabIndex = 0
        '
        'label_internalDiameter
        '
        Me.label_internalDiameter.AutoSize = True
        Me.label_internalDiameter.Location = New System.Drawing.Point(12, 59)
        Me.label_internalDiameter.Name = "label_internalDiameter"
        Me.label_internalDiameter.Size = New System.Drawing.Size(114, 17)
        Me.label_internalDiameter.TabIndex = 1
        Me.label_internalDiameter.Text = "Internal diameter"
        '
        'label_first
        '
        Me.label_first.AutoSize = True
        Me.label_first.Location = New System.Drawing.Point(12, 20)
        Me.label_first.Name = "label_first"
        Me.label_first.Size = New System.Drawing.Size(261, 17)
        Me.label_first.TabIndex = 2
        Me.label_first.Text = "Please fill the below form and click ""OK""."
        '
        'label_externalDiameter
        '
        Me.label_externalDiameter.AutoSize = True
        Me.label_externalDiameter.Location = New System.Drawing.Point(144, 59)
        Me.label_externalDiameter.Name = "label_externalDiameter"
        Me.label_externalDiameter.Size = New System.Drawing.Size(118, 17)
        Me.label_externalDiameter.TabIndex = 3
        Me.label_externalDiameter.Text = "External diameter"
        '
        'textbox_externalDiameter
        '
        Me.textbox_externalDiameter.Location = New System.Drawing.Point(147, 79)
        Me.textbox_externalDiameter.Name = "textbox_externalDiameter"
        Me.textbox_externalDiameter.Size = New System.Drawing.Size(112, 22)
        Me.textbox_externalDiameter.TabIndex = 4
        '
        'label_slash
        '
        Me.label_slash.AutoSize = True
        Me.label_slash.Location = New System.Drawing.Point(131, 82)
        Me.label_slash.Name = "label_slash"
        Me.label_slash.Size = New System.Drawing.Size(12, 17)
        Me.label_slash.TabIndex = 5
        Me.label_slash.Text = "/"
        '
        'label_per
        '
        Me.label_per.AutoSize = True
        Me.label_per.Location = New System.Drawing.Point(265, 84)
        Me.label_per.Name = "label_per"
        Me.label_per.Size = New System.Drawing.Size(13, 17)
        Me.label_per.TabIndex = 6
        Me.label_per.Text = "*"
        '
        'label_height
        '
        Me.label_height.AutoSize = True
        Me.label_height.Location = New System.Drawing.Point(282, 59)
        Me.label_height.Name = "label_height"
        Me.label_height.Size = New System.Drawing.Size(49, 17)
        Me.label_height.TabIndex = 7
        Me.label_height.Text = "Height"
        '
        'textbox_height
        '
        Me.textbox_height.Location = New System.Drawing.Point(284, 79)
        Me.textbox_height.Name = "textbox_height"
        Me.textbox_height.Size = New System.Drawing.Size(98, 22)
        Me.textbox_height.TabIndex = 8
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(307, 123)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 9
        Me.button_ok.Text = "OK"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'label_test
        '
        Me.label_test.AutoSize = True
        Me.label_test.Location = New System.Drawing.Point(16, 131)
        Me.label_test.Name = "label_test"
        Me.label_test.Size = New System.Drawing.Size(0, 17)
        Me.label_test.TabIndex = 10
        Me.label_test.Tag = ""
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(407, 168)
        Me.Controls.Add(Me.label_test)
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
    Friend WithEvents label_test As Label
End Class
