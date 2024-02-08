<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rentCarDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentCarDetails))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStates = New System.Windows.Forms.Label()
        Me.cbxStates = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCarSeat = New System.Windows.Forms.ComboBox()
        Me.dtpPickUp = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPoint = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(760, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 71)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "PICK UP DATE"
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.BackColor = System.Drawing.Color.Transparent
        Me.lblStates.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStates.ForeColor = System.Drawing.Color.White
        Me.lblStates.Location = New System.Drawing.Point(412, 188)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(88, 27)
        Me.lblStates.TabIndex = 60
        Me.lblStates.Text = "STATES"
        '
        'cbxStates
        '
        Me.cbxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStates.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxStates.FormattingEnabled = True
        Me.cbxStates.Items.AddRange(New Object() {"JOHOR", "MELAKA", "NEGERI SEMBILAN", "SELANGOR", "KELANTAN", "KEDAH", "TERENGGANU", "PERAK", "PAHANG", "PERLIS", "PENANG", "SABAH", "SARAWAK"})
        Me.cbxStates.Location = New System.Drawing.Point(417, 234)
        Me.cbxStates.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxStates.Name = "cbxStates"
        Me.cbxStates.Size = New System.Drawing.Size(280, 31)
        Me.cbxStates.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(760, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 32)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "RETURN DATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OMC2.My.Resources.Resources.Front_car_pana
        Me.PictureBox1.Location = New System.Drawing.Point(87, 83)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(315, 528)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNext.Location = New System.Drawing.Point(943, 493)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(117, 57)
        Me.btnNext.TabIndex = 79
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(25, 227)
        Me.pcbBooking.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(42, 34)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 86
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_places
        Me.pcbPlaces.Location = New System.Drawing.Point(26, 298)
        Me.pcbPlaces.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(42, 35)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 85
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = Global.OMC2.My.Resources.Resources.logo_top_up
        Me.pcbTopUp.Location = New System.Drawing.Point(24, 366)
        Me.pcbTopUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(43, 49)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 84
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(26, 450)
        Me.pcbProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(42, 30)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 83
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = Global.OMC2.My.Resources.Resources.logo_setting
        Me.pcbSettings.Location = New System.Drawing.Point(25, 522)
        Me.pcbSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(43, 43)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 82
        Me.pcbSettings.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.PictureBox3.Location = New System.Drawing.Point(25, 137)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(412, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 27)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "CAR SEAT"
        '
        'cbxCarSeat
        '
        Me.cbxCarSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCarSeat.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCarSeat.FormattingEnabled = True
        Me.cbxCarSeat.Items.AddRange(New Object() {"4-seated car", "6-seated cars"})
        Me.cbxCarSeat.Location = New System.Drawing.Point(417, 331)
        Me.cbxCarSeat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxCarSeat.Name = "cbxCarSeat"
        Me.cbxCarSeat.Size = New System.Drawing.Size(280, 31)
        Me.cbxCarSeat.TabIndex = 88
        '
        'dtpPickUp
        '
        Me.dtpPickUp.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPickUp.Location = New System.Drawing.Point(765, 233)
        Me.dtpPickUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpPickUp.Name = "dtpPickUp"
        Me.dtpPickUp.Size = New System.Drawing.Size(295, 30)
        Me.dtpPickUp.TabIndex = 90
        '
        'dtpReturn
        '
        Me.dtpReturn.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturn.Location = New System.Drawing.Point(765, 332)
        Me.dtpReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(295, 30)
        Me.dtpReturn.TabIndex = 91
        '
        'btnDone
        '
        Me.btnDone.BackgroundImage = Global.OMC2.My.Resources.Resources.orange_gradient
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(765, 378)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(131, 53)
        Me.btnDone.TabIndex = 92
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(961, 435)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(99, 37)
        Me.lblDays.TabIndex = 93
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(760, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 69)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "NUMBER OF DAYS"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(417, 120)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(616, 51)
        Me.Label41.TabIndex = 95
        Me.Label41.Text = "FILL IN THE INFORMATION REQUIRED: "
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(412, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 27)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "PICK UP AND RETURN POINT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(408, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 20)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "*please specify the address"
        '
        'txtPoint
        '
        Me.txtPoint.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoint.Location = New System.Drawing.Point(412, 454)
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.Size = New System.Drawing.Size(285, 30)
        Me.txtPoint.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(115, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(935, 71)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "BOOKING DETAILS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rentCarDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.bg_driver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1167, 624)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPoint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.dtpReturn)
        Me.Controls.Add(Me.dtpPickUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCarSeat)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStates)
        Me.Controls.Add(Me.cbxStates)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft YaHei Light", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "rentCarDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rentCarDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStates As Label
    Friend WithEvents cbxStates As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxCarSeat As ComboBox
    Friend WithEvents dtpPickUp As DateTimePicker
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents btnDone As Button
    Friend WithEvents lblDays As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPoint As TextBox
    Friend WithEvents Label6 As Label
End Class
