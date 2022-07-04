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
        Me.DiaryLbl = New System.Windows.Forms.Label()
        Me.DiaryTxt = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiaryLbl
        '
        Me.DiaryLbl.AutoSize = True
        Me.DiaryLbl.Location = New System.Drawing.Point(12, 23)
        Me.DiaryLbl.Name = "DiaryLbl"
        Me.DiaryLbl.Size = New System.Drawing.Size(31, 13)
        Me.DiaryLbl.TabIndex = 0
        Me.DiaryLbl.Text = "Diary"
        '
        'DiaryTxt
        '
        Me.DiaryTxt.Location = New System.Drawing.Point(15, 44)
        Me.DiaryTxt.Multiline = True
        Me.DiaryTxt.Name = "DiaryTxt"
        Me.DiaryTxt.Size = New System.Drawing.Size(403, 309)
        Me.DiaryTxt.TabIndex = 1
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(12, 377)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(65, 20)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(341, 377)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(65, 20)
        Me.SaveBtn.TabIndex = 3
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Diary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.DiaryTxt)
        Me.Controls.Add(Me.DiaryLbl)
        Me.Name = "Diary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DiaryLbl As Label
    Friend WithEvents DiaryTxt As TextBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents SaveBtn As Button
End Class
