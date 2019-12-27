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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Usernamefield = New System.Windows.Forms.TextBox()
        Me.PasswordField = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REGISTER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(255, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USER:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(200, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD:"
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Red
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(329, 352)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(148, 36)
        Me.Save.TabIndex = 7
        Me.Save.Text = "REGISTER"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Usernamefield
        '
        Me.Usernamefield.Location = New System.Drawing.Point(329, 210)
        Me.Usernamefield.Name = "Usernamefield"
        Me.Usernamefield.Size = New System.Drawing.Size(148, 20)
        Me.Usernamefield.TabIndex = 8
        '
        'PasswordField
        '
        Me.PasswordField.Location = New System.Drawing.Point(329, 298)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordField.Size = New System.Drawing.Size(148, 20)
        Me.PasswordField.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(329, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "LOGIN PAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vox_sNotepadLockdown.My.Resources.Resources._5n2e747mgT2dDfUyc5aPCi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PasswordField)
        Me.Controls.Add(Me.Usernamefield)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "VOX'S NOTEPAD LOCKDOWN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Usernamefield As TextBox
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents Button1 As Button
End Class
