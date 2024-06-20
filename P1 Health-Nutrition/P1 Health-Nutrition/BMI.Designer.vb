<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMI
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
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtBMI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDiary = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnCalorieCounter = New System.Windows.Forms.Button()
        Me.btnBMIPage = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rbtnMetric = New System.Windows.Forms.RadioButton()
        Me.rbtnImperial = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnBMI
        '
        Me.btnBMI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMI.Location = New System.Drawing.Point(364, 588)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(232, 85)
        Me.btnBMI.TabIndex = 0
        Me.btnBMI.Text = "Check BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(616, 588)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(232, 85)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1228, 852)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 85)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 337)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 442)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 42)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Calculate BMI"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(680, 208)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(448, 94)
        Me.txtWeight.TabIndex = 8
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(680, 327)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(448, 94)
        Me.txtHeight.TabIndex = 9
        '
        'txtBMI
        '
        Me.txtBMI.BackColor = System.Drawing.Color.White
        Me.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.Location = New System.Drawing.Point(680, 438)
        Me.txtBMI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(448, 92)
        Me.txtBMI.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(778, 108)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Body Mass Index"
        '
        'btnDiary
        '
        Me.btnDiary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiary.Location = New System.Drawing.Point(988, 852)
        Me.btnDiary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDiary.Name = "btnDiary"
        Me.btnDiary.Size = New System.Drawing.Size(204, 198)
        Me.btnDiary.TabIndex = 15
        Me.btnDiary.Text = "Diary"
        Me.btnDiary.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(752, 852)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(204, 198)
        Me.btnReport.TabIndex = 14
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnCalorieCounter
        '
        Me.btnCalorieCounter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalorieCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalorieCounter.Location = New System.Drawing.Point(516, 852)
        Me.btnCalorieCounter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalorieCounter.Name = "btnCalorieCounter"
        Me.btnCalorieCounter.Size = New System.Drawing.Size(204, 198)
        Me.btnCalorieCounter.TabIndex = 13
        Me.btnCalorieCounter.Text = "Food Counter"
        Me.btnCalorieCounter.UseVisualStyleBackColor = True
        '
        'btnBMIPage
        '
        Me.btnBMIPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBMIPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMIPage.Location = New System.Drawing.Point(306, 852)
        Me.btnBMIPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBMIPage.Name = "btnBMIPage"
        Me.btnBMIPage.Size = New System.Drawing.Size(180, 198)
        Me.btnBMIPage.TabIndex = 12
        Me.btnBMIPage.Text = "BMI"
        Me.btnBMIPage.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1228, 963)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 83)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'rbtnMetric
        '
        Me.rbtnMetric.AutoSize = True
        Me.rbtnMetric.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMetric.Location = New System.Drawing.Point(920, 579)
        Me.rbtnMetric.Name = "rbtnMetric"
        Me.rbtnMetric.Size = New System.Drawing.Size(347, 59)
        Me.rbtnMetric.TabIndex = 17
        Me.rbtnMetric.TabStop = True
        Me.rbtnMetric.Text = "Metric Weight"
        Me.rbtnMetric.UseVisualStyleBackColor = True
        '
        'rbtnImperial
        '
        Me.rbtnImperial.AutoSize = True
        Me.rbtnImperial.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnImperial.Location = New System.Drawing.Point(920, 644)
        Me.rbtnImperial.Name = "rbtnImperial"
        Me.rbtnImperial.Size = New System.Drawing.Size(387, 59)
        Me.rbtnImperial.TabIndex = 18
        Me.rbtnImperial.TabStop = True
        Me.rbtnImperial.Text = "Imperial Weight"
        Me.rbtnImperial.UseVisualStyleBackColor = True
        '
        'BMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1526, 1080)
        Me.Controls.Add(Me.rbtnImperial)
        Me.Controls.Add(Me.rbtnMetric)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDiary)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnCalorieCounter)
        Me.Controls.Add(Me.btnBMIPage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBMI)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBMI As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtBMI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDiary As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnCalorieCounter As Button
    Friend WithEvents btnBMIPage As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rbtnMetric As RadioButton
    Friend WithEvents rbtnImperial As RadioButton
End Class
