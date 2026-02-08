<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        BtnCompute = New Button()
        TxtStud = New TextBox()
        TxtMidterm = New TextBox()
        LblStud = New Label()
        LblMidterm = New Label()
        TxtID = New TextBox()
        LblID = New Label()
        LblD1 = New Label()
        TxtQ1 = New TextBox()
        TxtQ2 = New TextBox()
        TxtQ3 = New TextBox()
        TxtME = New TextBox()
        TxtL1 = New TextBox()
        TxtL2 = New TextBox()
        TxtL3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TxtPointGrade = New TextBox()
        LblPointGrade = New Label()
        TxtRemark = New TextBox()
        LblRemark = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnCompute
        ' 
        BtnCompute.BackColor = SystemColors.Menu
        BtnCompute.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCompute.ForeColor = Color.LightSlateGray
        BtnCompute.Location = New Point(639, 387)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(149, 51)
        BtnCompute.TabIndex = 0
        BtnCompute.Text = "Tap this Button!" & vbCrLf & "Enter Data Here" & vbCrLf & vbCrLf
        BtnCompute.UseVisualStyleBackColor = False
        ' 
        ' TxtStud
        ' 
        TxtStud.Location = New Point(276, 128)
        TxtStud.Name = "TxtStud"
        TxtStud.Size = New Size(198, 27)
        TxtStud.TabIndex = 1
        TxtStud.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtMidterm
        ' 
        TxtMidterm.Location = New Point(276, 200)
        TxtMidterm.Name = "TxtMidterm"
        TxtMidterm.Size = New Size(120, 27)
        TxtMidterm.TabIndex = 2
        TxtMidterm.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblStud
        ' 
        LblStud.AutoSize = True
        LblStud.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStud.ForeColor = Color.LightPink
        LblStud.Location = New Point(342, 96)
        LblStud.Name = "LblStud"
        LblStud.Size = New Size(71, 18)
        LblStud.TabIndex = 3
        LblStud.Text = "Student"
        ' 
        ' LblMidterm
        ' 
        LblMidterm.AutoSize = True
        LblMidterm.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblMidterm.ForeColor = Color.LightPink
        LblMidterm.Location = New Point(276, 169)
        LblMidterm.Name = "LblMidterm"
        LblMidterm.Size = New Size(120, 18)
        LblMidterm.TabIndex = 4
        LblMidterm.Text = "Midterm Grade"
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(480, 128)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(125, 27)
        TxtID.TabIndex = 5
        TxtID.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblID.ForeColor = Color.LightPink
        LblID.Location = New Point(522, 96)
        LblID.Name = "LblID"
        LblID.Size = New Size(23, 18)
        LblID.TabIndex = 6
        LblID.Text = "ID"
        ' 
        ' LblD1
        ' 
        LblD1.AutoSize = True
        LblD1.BackColor = Color.RebeccaPurple
        LblD1.Font = New Font("Pixelify Sans", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD1.ForeColor = Color.LightSteelBlue
        LblD1.Location = New Point(12, 18)
        LblD1.Name = "LblD1"
        LblD1.Size = New Size(546, 49)
        LblD1.TabIndex = 10
        LblD1.Text = "MIDTERM GRADE CALCULATOR"
        ' 
        ' TxtQ1
        ' 
        TxtQ1.Location = New Point(22, 128)
        TxtQ1.Name = "TxtQ1"
        TxtQ1.Size = New Size(61, 27)
        TxtQ1.TabIndex = 11
        TxtQ1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtQ2
        ' 
        TxtQ2.Location = New Point(22, 200)
        TxtQ2.Name = "TxtQ2"
        TxtQ2.Size = New Size(61, 27)
        TxtQ2.TabIndex = 12
        TxtQ2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtQ3
        ' 
        TxtQ3.Location = New Point(22, 271)
        TxtQ3.Name = "TxtQ3"
        TxtQ3.Size = New Size(61, 27)
        TxtQ3.TabIndex = 13
        TxtQ3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtME
        ' 
        TxtME.Location = New Point(68, 341)
        TxtME.Name = "TxtME"
        TxtME.Size = New Size(61, 27)
        TxtME.TabIndex = 15
        TxtME.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtL1
        ' 
        TxtL1.Location = New Point(112, 128)
        TxtL1.Name = "TxtL1"
        TxtL1.Size = New Size(61, 27)
        TxtL1.TabIndex = 17
        TxtL1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtL2
        ' 
        TxtL2.Location = New Point(112, 200)
        TxtL2.Name = "TxtL2"
        TxtL2.Size = New Size(61, 27)
        TxtL2.TabIndex = 18
        TxtL2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtL3
        ' 
        TxtL3.Location = New Point(112, 271)
        TxtL3.Name = "TxtL3"
        TxtL3.Size = New Size(61, 27)
        TxtL3.TabIndex = 19
        TxtL3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pixelify Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightPink
        Label1.Location = New Point(58, 314)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 21)
        Label1.TabIndex = 20
        Label1.Text = "Mid Exam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.LightPink
        Label2.Location = New Point(38, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 18)
        Label2.TabIndex = 21
        Label2.Text = "Q1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Pixelify Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.LightPink
        Label3.Location = New Point(34, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 21)
        Label3.TabIndex = 22
        Label3.Text = "Q2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.LightPink
        Label4.Location = New Point(38, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 18)
        Label4.TabIndex = 23
        Label4.Text = "Q3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.LightPink
        Label5.Location = New Point(129, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(21, 18)
        Label5.TabIndex = 24
        Label5.Text = "L1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Pixelify Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.LightPink
        Label6.Location = New Point(129, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 21)
        Label6.TabIndex = 25
        Label6.Text = "L2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.LightPink
        Label7.Location = New Point(129, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 18)
        Label7.TabIndex = 26
        Label7.Text = "L3"
        ' 
        ' TxtPointGrade
        ' 
        TxtPointGrade.Location = New Point(412, 200)
        TxtPointGrade.Name = "TxtPointGrade"
        TxtPointGrade.Size = New Size(61, 27)
        TxtPointGrade.TabIndex = 27
        TxtPointGrade.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblPointGrade
        ' 
        LblPointGrade.AutoSize = True
        LblPointGrade.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPointGrade.ForeColor = Color.LightPink
        LblPointGrade.Location = New Point(412, 169)
        LblPointGrade.Name = "LblPointGrade"
        LblPointGrade.Size = New Size(48, 18)
        LblPointGrade.TabIndex = 28
        LblPointGrade.Text = "Point"
        ' 
        ' TxtRemark
        ' 
        TxtRemark.Location = New Point(492, 200)
        TxtRemark.Name = "TxtRemark"
        TxtRemark.Size = New Size(61, 27)
        TxtRemark.TabIndex = 29
        TxtRemark.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblRemark
        ' 
        LblRemark.AutoSize = True
        LblRemark.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblRemark.ForeColor = Color.LightPink
        LblRemark.Location = New Point(492, 167)
        LblRemark.Name = "LblRemark"
        LblRemark.Size = New Size(66, 18)
        LblRemark.TabIndex = 30
        LblRemark.Text = "Remark"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(480, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(356, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-75, 200)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(356, 341)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(800, 450)
        Controls.Add(LblRemark)
        Controls.Add(TxtRemark)
        Controls.Add(LblPointGrade)
        Controls.Add(TxtPointGrade)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtL3)
        Controls.Add(TxtL2)
        Controls.Add(TxtL1)
        Controls.Add(TxtME)
        Controls.Add(TxtQ3)
        Controls.Add(TxtQ2)
        Controls.Add(TxtQ1)
        Controls.Add(LblD1)
        Controls.Add(LblID)
        Controls.Add(TxtID)
        Controls.Add(LblMidterm)
        Controls.Add(LblStud)
        Controls.Add(TxtMidterm)
        Controls.Add(TxtStud)
        Controls.Add(BtnCompute)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        ForeColor = Color.LightPink
        Name = "Form1"
        Text = "Midterm Grade Calculator"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCompute As Button
    Friend WithEvents TxtStud As TextBox
    Friend WithEvents TxtMidterm As TextBox
    Friend WithEvents LblStud As Label
    Friend WithEvents LblMidterm As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents LblD1 As Label
    Friend WithEvents TxtQ1 As TextBox
    Friend WithEvents TxtQ2 As TextBox
    Friend WithEvents TxtQ3 As TextBox
    Friend WithEvents TxtME As TextBox
    Friend WithEvents TxtL1 As TextBox
    Friend WithEvents TxtL2 As TextBox
    Friend WithEvents TxtL3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

    ' --- NEW FRIENDS DECLARED HERE ---
    Friend WithEvents TxtPointGrade As TextBox
    Friend WithEvents LblPointGrade As Label
    Friend WithEvents TxtRemark As TextBox
    Friend WithEvents LblRemark As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    ' ---------------------------------

End Class
