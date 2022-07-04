<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.CreatePassword = New System.Windows.Forms.TextBox()
        Me.RetypePassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnConfirmSignUp = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign Up"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(13, 83)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(331, 20)
        Me.Username.TabIndex = 1
        '
        'CreatePassword
        '
        Me.CreatePassword.Location = New System.Drawing.Point(13, 148)
        Me.CreatePassword.Name = "CreatePassword"
        Me.CreatePassword.Size = New System.Drawing.Size(331, 20)
        Me.CreatePassword.TabIndex = 2
        '
        'RetypePassword
        '
        Me.RetypePassword.Location = New System.Drawing.Point(13, 222)
        Me.RetypePassword.Name = "RetypePassword"
        Me.RetypePassword.Size = New System.Drawing.Size(331, 20)
        Me.RetypePassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Create Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Retype Password:"
        '
        'BtnConfirmSignUp
        '
        Me.BtnConfirmSignUp.Location = New System.Drawing.Point(24, 277)
        Me.BtnConfirmSignUp.Name = "BtnConfirmSignUp"
        Me.BtnConfirmSignUp.Size = New System.Drawing.Size(298, 38)
        Me.BtnConfirmSignUp.TabIndex = 7
        Me.BtnConfirmSignUp.Text = "Confirm Sign Up"
        Me.BtnConfirmSignUp.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(11, 339)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(63, 34)
        Me.BtnBack.TabIndex = 8
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 378)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnConfirmSignUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RetypePassword)
        Me.Controls.Add(Me.CreatePassword)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents CreatePassword As TextBox
    Friend WithEvents RetypePassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnConfirmSignUp As Button
    Friend WithEvents BtnBack As Button
End Class
