<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.MainMenuTitle = New System.Windows.Forms.Label()
        Me.WelcomeUserLbl = New System.Windows.Forms.Label()
        Me.BtnFlashcards = New System.Windows.Forms.Button()
        Me.BtnNotes = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainMenuTitle
        '
        Me.MainMenuTitle.AutoSize = True
        Me.MainMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuTitle.Location = New System.Drawing.Point(13, 24)
        Me.MainMenuTitle.Name = "MainMenuTitle"
        Me.MainMenuTitle.Size = New System.Drawing.Size(235, 26)
        Me.MainMenuTitle.TabIndex = 0
        Me.MainMenuTitle.Text = "Main Menu, Welcome: "
        '
        'WelcomeUserLbl
        '
        Me.WelcomeUserLbl.AutoSize = True
        Me.WelcomeUserLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeUserLbl.Location = New System.Drawing.Point(244, 24)
        Me.WelcomeUserLbl.Name = "WelcomeUserLbl"
        Me.WelcomeUserLbl.Size = New System.Drawing.Size(30, 26)
        Me.WelcomeUserLbl.TabIndex = 2
        Me.WelcomeUserLbl.Text = "..."
        '
        'BtnFlashcards
        '
        Me.BtnFlashcards.Location = New System.Drawing.Point(10, 92)
        Me.BtnFlashcards.Name = "BtnFlashcards"
        Me.BtnFlashcards.Size = New System.Drawing.Size(192, 48)
        Me.BtnFlashcards.TabIndex = 3
        Me.BtnFlashcards.Text = "FlashCards"
        Me.BtnFlashcards.UseVisualStyleBackColor = True
        '
        'BtnNotes
        '
        Me.BtnNotes.Location = New System.Drawing.Point(10, 171)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(192, 48)
        Me.BtnNotes.TabIndex = 4
        Me.BtnNotes.Text = "Notes"
        Me.BtnNotes.UseVisualStyleBackColor = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Location = New System.Drawing.Point(10, 264)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(192, 48)
        Me.BtnLogOut.TabIndex = 5
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnNotes)
        Me.Controls.Add(Me.BtnFlashcards)
        Me.Controls.Add(Me.WelcomeUserLbl)
        Me.Controls.Add(Me.MainMenuTitle)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenuTitle As Label
    Friend WithEvents WelcomeUserLbl As Label
    Friend WithEvents BtnFlashcards As Button
    Friend WithEvents BtnNotes As Button
    Friend WithEvents BtnLogOut As Button
End Class
