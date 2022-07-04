<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usernamelabel = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.btnConfirmLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(527, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Not got an account yet?"
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(516, 362)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(136, 36)
        Me.BtnSignUp.TabIndex = 12
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(10, 220)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(327, 20)
        Me.TxtPassword.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Password:"
        '
        'Usernamelabel
        '
        Me.Usernamelabel.AutoSize = True
        Me.Usernamelabel.Location = New System.Drawing.Point(17, 118)
        Me.Usernamelabel.Name = "Usernamelabel"
        Me.Usernamelabel.Size = New System.Drawing.Size(58, 13)
        Me.Usernamelabel.TabIndex = 9
        Me.Usernamelabel.Text = "Username:"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(10, 134)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(327, 20)
        Me.TxtUsername.TabIndex = 8
        '
        'LoginLbl
        '
        Me.LoginLbl.AutoSize = True
        Me.LoginLbl.Location = New System.Drawing.Point(17, 54)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(33, 13)
        Me.LoginLbl.TabIndex = 7
        Me.LoginLbl.Text = "Login"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(18, 362)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(52, 29)
        Me.BtnBack.TabIndex = 14
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'btnConfirmLogin
        '
        Me.btnConfirmLogin.Location = New System.Drawing.Point(9, 292)
        Me.btnConfirmLogin.Name = "btnConfirmLogin"
        Me.btnConfirmLogin.Size = New System.Drawing.Size(327, 36)
        Me.btnConfirmLogin.TabIndex = 15
        Me.btnConfirmLogin.Text = "Confirm Login"
        Me.btnConfirmLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.btnConfirmLogin)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usernamelabel)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LoginLbl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LoginLbl As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents btnConfirmLogin As Button
End Class
