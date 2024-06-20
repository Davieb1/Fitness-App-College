<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.btnDiary = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnFoodCounter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDiary
        '
        Me.btnDiary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiary.Location = New System.Drawing.Point(412, 419)
        Me.btnDiary.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDiary.Name = "btnDiary"
        Me.btnDiary.Size = New System.Drawing.Size(102, 103)
        Me.btnDiary.TabIndex = 23
        Me.btnDiary.Text = "Diary"
        Me.btnDiary.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(296, 419)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(102, 103)
        Me.btnReport.TabIndex = 22
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMI.Location = New System.Drawing.Point(63, 419)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(102, 103)
        Me.btnBMI.TabIndex = 21
        Me.btnBMI.Text = "BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnFoodCounter
        '
        Me.btnFoodCounter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFoodCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoodCounter.Location = New System.Drawing.Point(186, 419)
        Me.btnFoodCounter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFoodCounter.Name = "btnFoodCounter"
        Me.btnFoodCounter.Size = New System.Drawing.Size(90, 103)
        Me.btnFoodCounter.TabIndex = 20
        Me.btnFoodCounter.Text = "Food Counter"
        Me.btnFoodCounter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(534, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(724, 552)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDiary)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnFoodCounter)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDiary As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnFoodCounter As Button
    Friend WithEvents Button2 As Button
End Class
