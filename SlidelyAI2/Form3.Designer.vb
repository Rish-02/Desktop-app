<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtGitHubRepo = New System.Windows.Forms.TextBox()
        Me.TxtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightBlue
        Me.btnSubmit.Location = New System.Drawing.Point(175, 312)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(355, 43)
        Me.btnSubmit.TabIndex = 28
        Me.btnSubmit.Text = "SUBMIT (Ctrl + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtGitHubRepo
        '
        Me.txtGitHubRepo.BackColor = System.Drawing.SystemColors.Window
        Me.txtGitHubRepo.Location = New System.Drawing.Point(320, 249)
        Me.txtGitHubRepo.Multiline = True
        Me.txtGitHubRepo.Name = "txtGitHubRepo"
        Me.txtGitHubRepo.Size = New System.Drawing.Size(210, 26)
        Me.txtGitHubRepo.TabIndex = 25
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(320, 199)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(210, 22)
        Me.TxtPhoneNumber.TabIndex = 24
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Location = New System.Drawing.Point(320, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(210, 22)
        Me.txtEmail.TabIndex = 23
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Location = New System.Drawing.Point(320, 112)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 22)
        Me.txtName.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(171, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Github link Task 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(171, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Phone no"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(171, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Email"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.label.Location = New System.Drawing.Point(171, 118)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(53, 20)
        Me.label.TabIndex = 17
        Me.label.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(87, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rishita Jayant, Slidely task 2- Create Submissions"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGitHubRepo)
        Me.Controls.Add(Me.TxtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents TxtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
End Class
