<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diary
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
        Me.btnDiary = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnFoodCounter = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lstBlogPosts = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblEntry = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDiary
        '
        Me.btnDiary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiary.Location = New System.Drawing.Point(410, 559)
        Me.btnDiary.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDiary.Name = "btnDiary"
        Me.btnDiary.Size = New System.Drawing.Size(102, 103)
        Me.btnDiary.TabIndex = 19
        Me.btnDiary.Text = "Diary"
        Me.btnDiary.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(293, 559)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(102, 103)
        Me.btnReport.TabIndex = 18
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMI.Location = New System.Drawing.Point(70, 559)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(102, 103)
        Me.btnBMI.TabIndex = 17
        Me.btnBMI.Text = "BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnFoodCounter
        '
        Me.btnFoodCounter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFoodCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoodCounter.Location = New System.Drawing.Point(184, 559)
        Me.btnFoodCounter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFoodCounter.Name = "btnFoodCounter"
        Me.btnFoodCounter.Size = New System.Drawing.Size(90, 103)
        Me.btnFoodCounter.TabIndex = 16
        Me.btnFoodCounter.Text = "Food Counter"
        Me.btnFoodCounter.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(70, 100)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(445, 405)
        Me.txtContent.TabIndex = 20
        '
        'lstBlogPosts
        '
        Me.lstBlogPosts.FormattingEnabled = True
        Me.lstBlogPosts.Location = New System.Drawing.Point(542, 100)
        Me.lstBlogPosts.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBlogPosts.Name = "lstBlogPosts"
        Me.lstBlogPosts.ScrollAlwaysVisible = True
        Me.lstBlogPosts.Size = New System.Drawing.Size(195, 43)
        Me.lstBlogPosts.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(542, 409)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(193, 35)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(542, 467)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(193, 35)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(542, 236)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(195, 39)
        Me.txtTitle.TabIndex = 24
        '
        'lblEntry
        '
        Me.lblEntry.AutoSize = True
        Me.lblEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry.Location = New System.Drawing.Point(546, 203)
        Me.lblEntry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntry.Name = "lblEntry"
        Me.lblEntry.Size = New System.Drawing.Size(138, 24)
        Me.lblEntry.TabIndex = 25
        Me.lblEntry.Text = "Enter Blog Title"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(635, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Shows Saved Blog Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(539, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Saved Blog Posts"
        '
        'Diary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(863, 685)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblEntry)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstBlogPosts)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.btnDiary)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnFoodCounter)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Diary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDiary As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnFoodCounter As Button
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lstBlogPosts As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblEntry As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
