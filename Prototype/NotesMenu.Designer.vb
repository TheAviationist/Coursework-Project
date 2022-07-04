<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotesMenu
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
        Me.CreateNoteBtn = New System.Windows.Forms.Button()
        Me.ViewNotesBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Noteslbl = New System.Windows.Forms.Label()
        Me.Diarybtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateNoteBtn
        '
        Me.CreateNoteBtn.Location = New System.Drawing.Point(9, 165)
        Me.CreateNoteBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateNoteBtn.Name = "CreateNoteBtn"
        Me.CreateNoteBtn.Size = New System.Drawing.Size(278, 35)
        Me.CreateNoteBtn.TabIndex = 0
        Me.CreateNoteBtn.Text = "Create New Note (coming soon)"
        Me.CreateNoteBtn.UseVisualStyleBackColor = True
        '
        'ViewNotesBtn
        '
        Me.ViewNotesBtn.Location = New System.Drawing.Point(9, 235)
        Me.ViewNotesBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewNotesBtn.Name = "ViewNotesBtn"
        Me.ViewNotesBtn.Size = New System.Drawing.Size(278, 35)
        Me.ViewNotesBtn.TabIndex = 1
        Me.ViewNotesBtn.Text = "View Notes (coming soon)"
        Me.ViewNotesBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(9, 371)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(79, 28)
        Me.BackBtn.TabIndex = 2
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Noteslbl
        '
        Me.Noteslbl.AutoSize = True
        Me.Noteslbl.Location = New System.Drawing.Point(22, 31)
        Me.Noteslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Noteslbl.Name = "Noteslbl"
        Me.Noteslbl.Size = New System.Drawing.Size(52, 13)
        Me.Noteslbl.TabIndex = 3
        Me.Noteslbl.Text = "My Notes"
        '
        'Diarybtn
        '
        Me.Diarybtn.Location = New System.Drawing.Point(9, 93)
        Me.Diarybtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Diarybtn.Name = "Diarybtn"
        Me.Diarybtn.Size = New System.Drawing.Size(278, 35)
        Me.Diarybtn.TabIndex = 4
        Me.Diarybtn.Text = "View Diary"
        Me.Diarybtn.UseVisualStyleBackColor = True
        '
        'NotesMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.Diarybtn)
        Me.Controls.Add(Me.Noteslbl)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.ViewNotesBtn)
        Me.Controls.Add(Me.CreateNoteBtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NotesMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotesMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateNoteBtn As Button
    Friend WithEvents ViewNotesBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents Noteslbl As Label
    Friend WithEvents Diarybtn As Button
End Class
