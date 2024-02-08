<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carRentConfirmation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carRentConfirmation))
        Me.lblStates = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.lblPlateNumber = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.lblPickUpDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblUserPhone = New System.Windows.Forms.Label()
        Me.RentalCarTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.rentalCarTableAdapter()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStates
        '
        Me.lblStates.AutoSize = True
        Me.lblStates.BackColor = System.Drawing.Color.Transparent
        Me.lblStates.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStates.ForeColor = System.Drawing.Color.White
        Me.lblStates.Location = New System.Drawing.Point(265, 112)
        Me.lblStates.Name = "lblStates"
        Me.lblStates.Size = New System.Drawing.Size(136, 27)
        Me.lblStates.TabIndex = 61
        Me.lblStates.Text = "CAR BRAND"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(663, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 27)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "TOTAL PRICE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(258, 484)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 27)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "RETURN DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(256, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 27)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "PICK UP DATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(256, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 27)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "PLATE NUMBER"
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_Brand", True))
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(263, 150)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(296, 52)
        Me.lblBrand.TabIndex = 67
        '
        'RentalCarBindingSource
        '
        Me.RentalCarBindingSource.DataMember = "rentalCar"
        Me.RentalCarBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPlateNumber
        '
        Me.lblPlateNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlateNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_PlateNumber", True))
        Me.lblPlateNumber.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNumber.ForeColor = System.Drawing.Color.White
        Me.lblPlateNumber.Location = New System.Drawing.Point(261, 283)
        Me.lblPlateNumber.Name = "lblPlateNumber"
        Me.lblPlateNumber.Size = New System.Drawing.Size(296, 52)
        Me.lblPlateNumber.TabIndex = 68
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_Price", True))
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(668, 283)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(296, 52)
        Me.lblPrice.TabIndex = 69
        '
        'lblReturn
        '
        Me.lblReturn.BackColor = System.Drawing.Color.Transparent
        Me.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReturn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_EndDate", True))
        Me.lblReturn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.ForeColor = System.Drawing.Color.White
        Me.lblReturn.Location = New System.Drawing.Point(263, 524)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(296, 52)
        Me.lblReturn.TabIndex = 70
        '
        'lblPickUpDate
        '
        Me.lblPickUpDate.BackColor = System.Drawing.Color.Transparent
        Me.lblPickUpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPickUpDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_StartDate", True))
        Me.lblPickUpDate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickUpDate.ForeColor = System.Drawing.Color.White
        Me.lblPickUpDate.Location = New System.Drawing.Point(261, 408)
        Me.lblPickUpDate.Name = "lblPickUpDate"
        Me.lblPickUpDate.Size = New System.Drawing.Size(296, 52)
        Me.lblPickUpDate.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(663, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 27)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "PICK UP AND RETURN POINT"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BackgroundImage = CType(resources.GetObject("btnConfirm.BackgroundImage"), System.Drawing.Image)
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnConfirm.Location = New System.Drawing.Point(973, 536)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(150, 55)
        Me.btnConfirm.TabIndex = 80
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(184, 36)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(926, 76)
        Me.Label73.TabIndex = 81
        Me.Label73.Text = "RENTAL CAR CONFIRMATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(23, 254)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 98
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_places
        Me.pcbPlaces.Location = New System.Drawing.Point(23, 328)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 97
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = Global.OMC2.My.Resources.Resources.logo_top_up
        Me.pcbTopUp.Location = New System.Drawing.Point(23, 403)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(49, 41)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 96
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(23, 484)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 95
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = Global.OMC2.My.Resources.Resources.logo_setting
        Me.pcbSettings.Location = New System.Drawing.Point(23, 566)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 94
        Me.pcbSettings.TabStop = False
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(23, 180)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 93
        Me.pcbHome.TabStop = False
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_PickUp", True))
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(668, 416)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(296, 87)
        Me.lblAddress.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(663, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 27)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "CAR COLOUR"
        '
        'lblColour
        '
        Me.lblColour.BackColor = System.Drawing.Color.Transparent
        Me.lblColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_Colour", True))
        Me.lblColour.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColour.ForeColor = System.Drawing.Color.White
        Me.lblColour.Location = New System.Drawing.Point(668, 150)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(296, 52)
        Me.lblColour.TabIndex = 101
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_Status", True))
        Me.lblStatus.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStatus.Location = New System.Drawing.Point(860, 547)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(19, 18)
        Me.lblStatus.TabIndex = 102
        Me.lblStatus.Text = "Label2"
        '
        'lblUserPhone
        '
        Me.lblUserPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblUserPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalCarBindingSource, "C_PhoneUser", True))
        Me.lblUserPhone.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblUserPhone.Location = New System.Drawing.Point(860, 559)
        Me.lblUserPhone.Name = "lblUserPhone"
        Me.lblUserPhone.Size = New System.Drawing.Size(34, 10)
        Me.lblUserPhone.TabIndex = 103
        Me.lblUserPhone.Text = "Label3"
        '
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.BackgroundImage = CType(resources.GetObject("btnShow.BackgroundImage"), System.Drawing.Image)
        Me.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShow.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnShow.Location = New System.Drawing.Point(800, 536)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(150, 55)
        Me.btnShow.TabIndex = 104
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'carRentConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.bg_booking_no_logo_21
        Me.ClientSize = New System.Drawing.Size(1165, 625)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblUserPhone)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPickUpDate)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPlateNumber)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblStates)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "carRentConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "carRentConfirmation"
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStates As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblPlateNumber As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblReturn As Label
    Friend WithEvents lblPickUpDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label73 As Label
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents pcbHome As PictureBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblUserPhone As Label
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As TROVAdatabaseDataSetTableAdapters.rentalCarTableAdapter
    Friend WithEvents btnShow As Button
End Class
