<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnLogin = New Button()
        TxtUsername = New TextBox()
        TxtPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLogin.Location = New Point(333, 284)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(132, 36)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Log in"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtUsername.Location = New Point(292, 168)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(271, 25)
        TxtUsername.TabIndex = 1
        ' 
        ' TxtPass
        ' 
        TxtPass.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPass.Location = New Point(292, 212)
        TxtPass.Name = "TxtPass"
        TxtPass.PasswordChar = "❧"c
        TxtPass.Size = New Size(271, 25)
        TxtPass.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Cornsilk
        Label1.Location = New Point(188, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 18)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Cornsilk
        Label2.Location = New Point(188, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 18)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(352, -6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(494, 471)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Pixelify Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Cornsilk
        Label3.Location = New Point(55, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 360)
        Label3.TabIndex = 7
        Label3.Text = "H" & vbCrLf & "E" & vbCrLf & "L" & vbCrLf & "L" & vbCrLf & "O"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtPass)
        Controls.Add(TxtUsername)
        Controls.Add(BtnLogin)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
