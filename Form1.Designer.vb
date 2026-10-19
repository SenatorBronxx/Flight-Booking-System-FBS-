<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtFullName = New TextBox()
        txtPhoneNumber = New TextBox()
        txtAge = New TextBox()
        txtTgA = New TextBox()
        btnIssueReceipt = New Button()
        cmbDestination = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        txtCityOfOrigin = New TextBox()
        dtpDeparture = New DateTimePicker()
        radFirstClass = New RadioButton()
        radBusinessClass = New RadioButton()
        radEconomy = New RadioButton()
        lblPickTravelClass = New Label()
        dgvTagAlongs = New DataGridView()
        ColPassengerName = New DataGridViewTextBoxColumn()
        CType(dgvTagAlongs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(272, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(392, 40)
        Label1.TabIndex = 0
        Label1.Text = "FLIGHT BOOKING SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 1
        Label2.Text = "FULL NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 21)
        Label3.TabIndex = 2
        Label3.Text = "AGE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(25, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 21)
        Label4.TabIndex = 3
        Label4.Text = "PHONE NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(25, 266)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 21)
        Label5.TabIndex = 4
        Label5.Text = "TAG-ALONG No."
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.Blue
        txtFullName.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFullName.ForeColor = SystemColors.Window
        txtFullName.Location = New Point(186, 88)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(321, 25)
        txtFullName.TabIndex = 5
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.Blue
        txtPhoneNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.ForeColor = SystemColors.Window
        txtPhoneNumber.Location = New Point(186, 176)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(321, 25)
        txtPhoneNumber.TabIndex = 6
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.Blue
        txtAge.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAge.ForeColor = SystemColors.Window
        txtAge.Location = New Point(186, 139)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(321, 25)
        txtAge.TabIndex = 7
        ' 
        ' txtTgA
        ' 
        txtTgA.BackColor = Color.Blue
        txtTgA.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTgA.ForeColor = SystemColors.Window
        txtTgA.Location = New Point(186, 264)
        txtTgA.Name = "txtTgA"
        txtTgA.Size = New Size(39, 25)
        txtTgA.TabIndex = 8
        ' 
        ' btnIssueReceipt
        ' 
        btnIssueReceipt.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnIssueReceipt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIssueReceipt.ForeColor = SystemColors.ControlLightLight
        btnIssueReceipt.Location = New Point(409, 512)
        btnIssueReceipt.Name = "btnIssueReceipt"
        btnIssueReceipt.Size = New Size(142, 34)
        btnIssueReceipt.TabIndex = 9
        btnIssueReceipt.Text = "ISSUE RECEIPT"
        btnIssueReceipt.UseVisualStyleBackColor = False
        ' 
        ' cmbDestination
        ' 
        cmbDestination.BackColor = Color.Blue
        cmbDestination.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbDestination.ForeColor = SystemColors.Window
        cmbDestination.FormattingEnabled = True
        cmbDestination.Items.AddRange(New Object() {"Rome, Italy", "Kyoto, Japan", "Cairo, Egypt", "London, UK", "Paris, France", "Cape Town, South Africa", "Lisbon, Portugal", "Sydney, Australia", "New York, USA", "California, USA", "Nairobi, Kenya", "Tel Aviv, Israel", "Mosow, Russia", "Kyiv, Ukraine", "Warsaw, Poland", "Istanbul, Turkyie", "Barcalona, Spain", "Ontario, Canada"})
        cmbDestination.Location = New Point(602, 88)
        cmbDestination.Name = "cmbDestination"
        cmbDestination.Size = New Size(241, 28)
        cmbDestination.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(651, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 21)
        Label6.TabIndex = 11
        Label6.Text = "DESTINATION"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(25, 229)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 21)
        Label7.TabIndex = 12
        Label7.Text = "CITY OF ORIGIN"
        ' 
        ' txtCityOfOrigin
        ' 
        txtCityOfOrigin.BackColor = Color.Blue
        txtCityOfOrigin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCityOfOrigin.ForeColor = SystemColors.Window
        txtCityOfOrigin.Location = New Point(186, 231)
        txtCityOfOrigin.Name = "txtCityOfOrigin"
        txtCityOfOrigin.Size = New Size(185, 25)
        txtCityOfOrigin.TabIndex = 13
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(25, 517)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(200, 23)
        dtpDeparture.TabIndex = 14
        ' 
        ' radFirstClass
        ' 
        radFirstClass.AutoSize = True
        radFirstClass.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radFirstClass.Location = New Point(602, 205)
        radFirstClass.Name = "radFirstClass"
        radFirstClass.Size = New Size(99, 25)
        radFirstClass.TabIndex = 15
        radFirstClass.TabStop = True
        radFirstClass.Text = "First Class"
        radFirstClass.UseVisualStyleBackColor = True
        ' 
        ' radBusinessClass
        ' 
        radBusinessClass.AutoSize = True
        radBusinessClass.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radBusinessClass.Location = New Point(602, 246)
        radBusinessClass.Name = "radBusinessClass"
        radBusinessClass.Size = New Size(130, 25)
        radBusinessClass.TabIndex = 16
        radBusinessClass.TabStop = True
        radBusinessClass.Text = "Business Class"
        radBusinessClass.UseVisualStyleBackColor = True
        ' 
        ' radEconomy
        ' 
        radEconomy.AutoSize = True
        radEconomy.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radEconomy.Location = New Point(602, 283)
        radEconomy.Name = "radEconomy"
        radEconomy.Size = New Size(95, 25)
        radEconomy.TabIndex = 17
        radEconomy.TabStop = True
        radEconomy.Text = "Economy"
        radEconomy.UseVisualStyleBackColor = True
        ' 
        ' lblPickTravelClass
        ' 
        lblPickTravelClass.AutoSize = True
        lblPickTravelClass.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPickTravelClass.Location = New Point(602, 164)
        lblPickTravelClass.Name = "lblPickTravelClass"
        lblPickTravelClass.Size = New Size(157, 21)
        lblPickTravelClass.TabIndex = 18
        lblPickTravelClass.Text = "PICK TRAVEL CLASS"
        ' 
        ' dgvTagAlongs
        ' 
        dgvTagAlongs.AllowUserToDeleteRows = False
        dgvTagAlongs.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgvTagAlongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTagAlongs.Columns.AddRange(New DataGridViewColumn() {ColPassengerName})
        dgvTagAlongs.Location = New Point(25, 308)
        dgvTagAlongs.Name = "dgvTagAlongs"
        dgvTagAlongs.Size = New Size(482, 150)
        dgvTagAlongs.TabIndex = 19
        ' 
        ' ColPassengerName
        ' 
        ColPassengerName.HeaderText = "Tag-Along Passenger Full Name"
        ColPassengerName.Name = "ColPassengerName"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(962, 578)
        Controls.Add(dgvTagAlongs)
        Controls.Add(lblPickTravelClass)
        Controls.Add(radEconomy)
        Controls.Add(radBusinessClass)
        Controls.Add(radFirstClass)
        Controls.Add(dtpDeparture)
        Controls.Add(txtCityOfOrigin)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(cmbDestination)
        Controls.Add(btnIssueReceipt)
        Controls.Add(txtTgA)
        Controls.Add(txtAge)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtFullName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvTagAlongs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtTgA As TextBox
    Friend WithEvents btnIssueReceipt As Button
    Friend WithEvents cmbDestination As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCityOfOrigin As TextBox
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents radFirstClass As RadioButton
    Friend WithEvents radBusinessClass As RadioButton
    Friend WithEvents radEconomy As RadioButton
    Friend WithEvents lblPickTravelClass As Label
    Friend WithEvents dgvTagAlongs As DataGridView
    Friend WithEvents ColPassengerName As DataGridViewTextBoxColumn

End Class
