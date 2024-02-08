<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Total_Price
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Total_Price))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblTotal_Cost = New System.Windows.Forms.Label()
        Me.UserLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.lblEstimated_Distance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblEstimated_hours = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.UserLocationTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.UserLocationTableAdapter()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblCurrentPlace = New System.Windows.Forms.Label()
        Me.lblTravel = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.UserLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(124, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(124, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(124, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estimated Distance"
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.White
        Me.lblLocation.Location = New System.Drawing.Point(345, 265)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(443, 58)
        Me.lblLocation.TabIndex = 4
        '
        'lblTotal_Cost
        '
        Me.lblTotal_Cost.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal_Cost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "Price", True))
        Me.lblTotal_Cost.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_Cost.ForeColor = System.Drawing.Color.White
        Me.lblTotal_Cost.Location = New System.Drawing.Point(948, 265)
        Me.lblTotal_Cost.Name = "lblTotal_Cost"
        Me.lblTotal_Cost.Size = New System.Drawing.Size(160, 34)
        Me.lblTotal_Cost.TabIndex = 5
        '
        'UserLocationBindingSource
        '
        Me.UserLocationBindingSource.DataMember = "UserLocation"
        Me.UserLocationBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblEstimated_Distance
        '
        Me.lblEstimated_Distance.BackColor = System.Drawing.Color.Transparent
        Me.lblEstimated_Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstimated_Distance.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimated_Distance.ForeColor = System.Drawing.Color.White
        Me.lblEstimated_Distance.Location = New System.Drawing.Point(345, 429)
        Me.lblEstimated_Distance.Name = "lblEstimated_Distance"
        Me.lblEstimated_Distance.Size = New System.Drawing.Size(443, 55)
        Me.lblEstimated_Distance.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(811, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Cost"
        '
        'lblRemarks
        '
        Me.lblRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(345, 347)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(443, 61)
        Me.lblRemarks.TabIndex = 8
        '
        'lblEstimated_hours
        '
        Me.lblEstimated_hours.BackColor = System.Drawing.Color.Transparent
        Me.lblEstimated_hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstimated_hours.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimated_hours.ForeColor = System.Drawing.Color.White
        Me.lblEstimated_hours.Location = New System.Drawing.Point(345, 500)
        Me.lblEstimated_hours.Name = "lblEstimated_hours"
        Me.lblEstimated_hours.Size = New System.Drawing.Size(443, 51)
        Me.lblEstimated_hours.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(124, 503)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 27)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estimated Hours"
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.Transparent
        Me.btnPayment.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_payment2
        Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayment.Enabled = False
        Me.btnPayment.Location = New System.Drawing.Point(891, 360)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(182, 142)
        Me.btnPayment.TabIndex = 11
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(544, 575)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(244, 54)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(886, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Proceed to payment:"
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(27, 239)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 110
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_places
        Me.pcbPlaces.Location = New System.Drawing.Point(27, 313)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 109
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = Global.OMC2.My.Resources.Resources.logo_top_up
        Me.pcbTopUp.Location = New System.Drawing.Point(27, 388)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(49, 41)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 108
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(27, 469)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 107
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = Global.OMC2.My.Resources.Resources.logo_setting
        Me.pcbSettings.Location = New System.Drawing.Point(27, 551)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 106
        Me.pcbSettings.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.PictureBox9.Location = New System.Drawing.Point(27, 165)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 105
        Me.PictureBox9.TabStop = False
        '
        'lblDriver
        '
        Me.lblDriver.BackColor = System.Drawing.Color.Transparent
        Me.lblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDriver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "DriverName", True))
        Me.lblDriver.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.ForeColor = System.Drawing.Color.White
        Me.lblDriver.Location = New System.Drawing.Point(129, 165)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(979, 85)
        Me.lblDriver.TabIndex = 111
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(171, 54)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(936, 96)
        Me.Label73.TabIndex = 112
        Me.Label73.Text = "DRIVER BOOKING CONFIRMATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserLocationTableAdapter
        '
        Me.UserLocationTableAdapter.ClearBeforeFill = True
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "U_PhoneNumber", True))
        Me.lblPhoneNum.Location = New System.Drawing.Point(816, 534)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(48, 16)
        Me.lblPhoneNum.TabIndex = 113
        Me.lblPhoneNum.Text = "Label7"
        '
        'lblCurrentPlace
        '
        Me.lblCurrentPlace.AutoSize = True
        Me.lblCurrentPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "CurrentPlace", True))
        Me.lblCurrentPlace.Location = New System.Drawing.Point(816, 570)
        Me.lblCurrentPlace.Name = "lblCurrentPlace"
        Me.lblCurrentPlace.Size = New System.Drawing.Size(48, 16)
        Me.lblCurrentPlace.TabIndex = 114
        Me.lblCurrentPlace.Text = "Label8"
        '
        'lblTravel
        '
        Me.lblTravel.AutoSize = True
        Me.lblTravel.BackColor = System.Drawing.Color.Transparent
        Me.lblTravel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "TravelPlace", True))
        Me.lblTravel.Location = New System.Drawing.Point(928, 534)
        Me.lblTravel.Name = "lblTravel"
        Me.lblTravel.Size = New System.Drawing.Size(48, 16)
        Me.lblTravel.TabIndex = 115
        Me.lblTravel.Text = "Label9"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserLocationBindingSource, "Status", True))
        Me.lblStatus.Location = New System.Drawing.Point(945, 570)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(55, 16)
        Me.lblStatus.TabIndex = 116
        Me.lblStatus.Text = "Label10"
        '
        'Total_Price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.PLACES_NO_TITLE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1206, 640)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTravel)
        Me.Controls.Add(Me.lblCurrentPlace)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblEstimated_hours)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEstimated_Distance)
        Me.Controls.Add(Me.lblTotal_Cost)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Total_Price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total_Price"
        CType(Me.UserLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblTotal_Cost As Label
    Friend WithEvents lblEstimated_Distance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblEstimated_hours As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents lblDriver As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents UserLocationBindingSource As BindingSource
    Friend WithEvents UserLocationTableAdapter As TROVAdatabaseDataSetTableAdapters.UserLocationTableAdapter
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblCurrentPlace As Label
    Friend WithEvents lblTravel As Label
    Friend WithEvents lblStatus As Label
End Class
