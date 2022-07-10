<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlashcardMenu
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
        Me.LblFlashcards = New System.Windows.Forms.Label()
        Me.SetListbox = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DeleteFlashcardBtn = New System.Windows.Forms.Button()
        Me.cardCount = New System.Windows.Forms.Label()
        Me.FrontBack = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.addCardBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.flipBtn = New System.Windows.Forms.Button()
        Me.flashCardWindow = New System.Windows.Forms.TextBox()
        Me.addSetBtn = New System.Windows.Forms.Button()
        Me.DeleteSetBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFlashcards
        '
        Me.LblFlashcards.AutoSize = True
        Me.LblFlashcards.Location = New System.Drawing.Point(12, 9)
        Me.LblFlashcards.Name = "LblFlashcards"
        Me.LblFlashcards.Size = New System.Drawing.Size(58, 13)
        Me.LblFlashcards.TabIndex = 1
        Me.LblFlashcards.Text = "Flashcards"
        '
        'SetListbox
        '
        Me.SetListbox.FormattingEnabled = True
        Me.SetListbox.Location = New System.Drawing.Point(12, 25)
        Me.SetListbox.Name = "SetListbox"
        Me.SetListbox.Size = New System.Drawing.Size(120, 407)
        Me.SetListbox.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DeleteFlashcardBtn)
        Me.Panel1.Controls.Add(Me.cardCount)
        Me.Panel1.Controls.Add(Me.FrontBack)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.addCardBtn)
        Me.Panel1.Controls.Add(Me.nextBtn)
        Me.Panel1.Controls.Add(Me.previousBtn)
        Me.Panel1.Controls.Add(Me.flipBtn)
        Me.Panel1.Controls.Add(Me.flashCardWindow)
        Me.Panel1.Location = New System.Drawing.Point(141, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 407)
        Me.Panel1.TabIndex = 3
        '
        'DeleteFlashcardBtn
        '
        Me.DeleteFlashcardBtn.Enabled = False
        Me.DeleteFlashcardBtn.Location = New System.Drawing.Point(388, 318)
        Me.DeleteFlashcardBtn.Name = "DeleteFlashcardBtn"
        Me.DeleteFlashcardBtn.Size = New System.Drawing.Size(98, 23)
        Me.DeleteFlashcardBtn.TabIndex = 9
        Me.DeleteFlashcardBtn.Text = "Delete"
        Me.DeleteFlashcardBtn.UseVisualStyleBackColor = True
        '
        'cardCount
        '
        Me.cardCount.AutoSize = True
        Me.cardCount.Location = New System.Drawing.Point(3, 0)
        Me.cardCount.Name = "cardCount"
        Me.cardCount.Size = New System.Drawing.Size(24, 13)
        Me.cardCount.TabIndex = 8
        Me.cardCount.Text = "0/0"
        '
        'FrontBack
        '
        Me.FrontBack.AutoSize = True
        Me.FrontBack.Location = New System.Drawing.Point(140, 54)
        Me.FrontBack.Name = "FrontBack"
        Me.FrontBack.Size = New System.Drawing.Size(28, 13)
        Me.FrontBack.TabIndex = 7
        Me.FrontBack.Text = "front"
        '
        'SaveBtn
        '
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Location = New System.Drawing.Point(284, 318)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(98, 23)
        Me.SaveBtn.TabIndex = 6
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'addCardBtn
        '
        Me.addCardBtn.Enabled = False
        Me.addCardBtn.Location = New System.Drawing.Point(175, 318)
        Me.addCardBtn.Name = "addCardBtn"
        Me.addCardBtn.Size = New System.Drawing.Size(103, 23)
        Me.addCardBtn.TabIndex = 5
        Me.addCardBtn.Text = "Add Card"
        Me.addCardBtn.UseVisualStyleBackColor = True
        '
        'nextBtn
        '
        Me.nextBtn.Enabled = False
        Me.nextBtn.Location = New System.Drawing.Point(567, 376)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(75, 23)
        Me.nextBtn.TabIndex = 2
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Enabled = False
        Me.previousBtn.Location = New System.Drawing.Point(3, 376)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(75, 23)
        Me.previousBtn.TabIndex = 1
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'flipBtn
        '
        Me.flipBtn.Enabled = False
        Me.flipBtn.Location = New System.Drawing.Point(84, 376)
        Me.flipBtn.Name = "flipBtn"
        Me.flipBtn.Size = New System.Drawing.Size(477, 23)
        Me.flipBtn.TabIndex = 0
        Me.flipBtn.Text = "Flip Card"
        Me.flipBtn.UseVisualStyleBackColor = True
        '
        'flashCardWindow
        '
        Me.flashCardWindow.Enabled = False
        Me.flashCardWindow.Location = New System.Drawing.Point(131, 70)
        Me.flashCardWindow.Multiline = True
        Me.flashCardWindow.Name = "flashCardWindow"
        Me.flashCardWindow.Size = New System.Drawing.Size(402, 218)
        Me.flashCardWindow.TabIndex = 3
        '
        'addSetBtn
        '
        Me.addSetBtn.Location = New System.Drawing.Point(24, 344)
        Me.addSetBtn.Name = "addSetBtn"
        Me.addSetBtn.Size = New System.Drawing.Size(97, 23)
        Me.addSetBtn.TabIndex = 4
        Me.addSetBtn.Text = "Add Set"
        Me.addSetBtn.UseVisualStyleBackColor = True
        '
        'DeleteSetBtn
        '
        Me.DeleteSetBtn.Enabled = False
        Me.DeleteSetBtn.Location = New System.Drawing.Point(24, 373)
        Me.DeleteSetBtn.Name = "DeleteSetBtn"
        Me.DeleteSetBtn.Size = New System.Drawing.Size(97, 23)
        Me.DeleteSetBtn.TabIndex = 5
        Me.DeleteSetBtn.Text = "Delete Set"
        Me.DeleteSetBtn.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(24, 402)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(97, 23)
        Me.BackBtn.TabIndex = 6
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'FlashcardMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.addSetBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DeleteSetBtn)
        Me.Controls.Add(Me.SetListbox)
        Me.Controls.Add(Me.LblFlashcards)
        Me.Name = "FlashcardMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlashcardMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFlashcards As Label
    Friend WithEvents SetListbox As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents flipBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents flashCardWindow As TextBox
    Friend WithEvents addCardBtn As Button
    Friend WithEvents addSetBtn As Button
    Friend WithEvents DeleteSetBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents FrontBack As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents cardCount As Label
    Friend WithEvents DeleteFlashcardBtn As Button
End Class
