<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationDriver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrationDriver))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbDriver = New System.Windows.Forms.PictureBox()
        Me.pcbUser = New System.Windows.Forms.PictureBox()
        Me.btnDriver = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.pcbDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbUser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(466, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 51)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "REGISTER AS :"
        '
        'pcbDriver
        '
        Me.pcbDriver.BackColor = System.Drawing.Color.DarkGray
        Me.pcbDriver.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.pcbDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbDriver.ErrorImage = Nothing
        Me.pcbDriver.Image = Global.OMC2.My.Resources.Resources.driverrr
        Me.pcbDriver.InitialImage = Nothing
        Me.pcbDriver.Location = New System.Drawing.Point(716, 269)
        Me.pcbDriver.Name = "pcbDriver"
        Me.pcbDriver.Size = New System.Drawing.Size(179, 167)
        Me.pcbDriver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbDriver.TabIndex = 8
        Me.pcbDriver.TabStop = False
        '
        'pcbUser
        '
        Me.pcbUser.BackColor = System.Drawing.Color.DarkGray
        Me.pcbUser.BackgroundImage = CType(resources.GetObject("pcbUser.BackgroundImage"), System.Drawing.Image)
        Me.pcbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbUser.Image = Global.OMC2.My.Resources.Resources._4202848
        Me.pcbUser.Location = New System.Drawing.Point(315, 269)
        Me.pcbUser.Name = "pcbUser"
        Me.pcbUser.Size = New System.Drawing.Size(187, 167)
        Me.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbUser.TabIndex = 7
        Me.pcbUser.TabStop = False
        '
        'btnDriver
        '
        Me.btnDriver.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDriver.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnDriver.Location = New System.Drawing.Point(668, 470)
        Me.btnDriver.Name = "btnDriver"
        Me.btnDriver.Size = New System.Drawing.Size(287, 76)
        Me.btnDriver.TabIndex = 6
        Me.btnDriver.Text = "DRIVER"
        Me.btnDriver.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnUser.Location = New System.Drawing.Point(269, 470)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(288, 76)
        Me.btnUser.TabIndex = 5
        Me.btnUser.Text = "USER"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(22, 230)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 122
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_places
        Me.pcbPlaces.Location = New System.Drawing.Point(22, 304)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 121
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = Global.OMC2.My.Resources.Resources.logo_top_up
        Me.pcbTopUp.Location = New System.Drawing.Point(22, 379)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(49, 41)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 120
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(22, 460)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 119
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = Global.OMC2.My.Resources.Resources.logo_setting
        Me.pcbSettings.Location = New System.Drawing.Point(22, 528)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 118
        Me.pcbSettings.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.PictureBox9.Location = New System.Drawing.Point(22, 156)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 117
        Me.PictureBox9.TabStop = False
        '
        'registrationDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.bg_home_no_logo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1167, 621)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbDriver)
        Me.Controls.Add(Me.pcbUser)
        Me.Controls.Add(Me.btnDriver)
        Me.Controls.Add(Me.btnUser)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registrationDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrationDriver"
        CType(Me.pcbDriver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pcbDriver As PictureBox
    Friend WithEvents pcbUser As PictureBox
    Friend WithEvents btnDriver As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
