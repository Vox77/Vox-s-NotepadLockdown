<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginpage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Usernametextfield = New System.Windows.Forms.TextBox()
        Me.Passwordtextfield = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(251, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USER:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(196, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD:"
        '
        'Usernametextfield
        '
        Me.Usernametextfield.Location = New System.Drawing.Point(325, 196)
        Me.Usernametextfield.Name = "Usernametextfield"
        Me.Usernametextfield.Size = New System.Drawing.Size(148, 20)
        Me.Usernametextfield.TabIndex = 5
        '
        'Passwordtextfield
        '
        Me.Passwordtextfield.Location = New System.Drawing.Point(325, 280)
        Me.Passwordtextfield.Name = "Passwordtextfield"
        Me.Passwordtextfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passwordtextfield.Size = New System.Drawing.Size(148, 20)
        Me.Passwordtextfield.TabIndex = 6
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.Red
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(325, 382)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(148, 36)
        Me.Save.TabIndex = 8
        Me.Save.Text = "LOGIN"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 45)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LOGIN"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(302, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "REGISTER PAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Loginpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vox_sNotepadLockdown.My.Resources.Resources._5n2e747mgT2dDfUyc5aPCi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Passwordtextfield)
        Me.Controls.Add(Me.Usernametextfield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loginpage"
        Me.Text = "VOX'S NOTEPAD LOCKDOWN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Usernametextfield As TextBox
    Friend WithEvents Passwordtextfield As TextBox
    Friend WithEvents Save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
