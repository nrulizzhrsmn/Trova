<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class driverProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(driverProfile))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnChangePhone = New System.Windows.Forms.Button()
        Me.btnChangeIC = New System.Windows.Forms.Button()
        Me.btnChangeEmail = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        Me.mskNewPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.mskNewICnum = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewEmail = New System.Windows.Forms.TextBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.DriverTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.DriverTableAdapter()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(184, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NAME                   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(183, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 27)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "PASSWORD          :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(184, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "EMAIL                   :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(184, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 27)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "IC NUMBER          :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(184, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 27)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "PHONE NUMBER :"
        '
        'btnChangePhone
        '
        Me.btnChangePhone.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnChangePhone.BackgroundImage = CType(resources.GetObject("btnChangePhone.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangePhone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePhone.ForeColor = System.Drawing.Color.White
        Me.btnChangePhone.Location = New System.Drawing.Point(828, 244)
        Me.btnChangePhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangePhone.Name = "btnChangePhone"
        Me.btnChangePhone.Size = New System.Drawing.Size(120, 39)
        Me.btnChangePhone.TabIndex = 34
        Me.btnChangePhone.Text = "Change"
        Me.btnChangePhone.UseVisualStyleBackColor = False
        '
        'btnChangeIC
        '
        Me.btnChangeIC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnChangeIC.BackgroundImage = CType(resources.GetObject("btnChangeIC.BackgroundImage"), System.Drawing.Image)
        Me.btnChangeIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeIC.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeIC.ForeColor = System.Drawing.Color.White
        Me.btnChangeIC.Location = New System.Drawing.Point(828, 313)
        Me.btnChangeIC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangeIC.Name = "btnChangeIC"
        Me.btnChangeIC.Size = New System.Drawing.Size(120, 38)
        Me.btnChangeIC.TabIndex = 33
        Me.btnChangeIC.Text = "Change"
        Me.btnChangeIC.UseVisualStyleBackColor = False
        '
        'btnChangeEmail
        '
        Me.btnChangeEmail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnChangeEmail.BackgroundImage = CType(resources.GetObject("btnChangeEmail.BackgroundImage"), System.Drawing.Image)
        Me.btnChangeEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeEmail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeEmail.ForeColor = System.Drawing.Color.White
        Me.btnChangeEmail.Location = New System.Drawing.Point(828, 387)
        Me.btnChangeEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangeEmail.Name = "btnChangeEmail"
        Me.btnChangeEmail.Size = New System.Drawing.Size(120, 38)
        Me.btnChangeEmail.TabIndex = 32
        Me.btnChangeEmail.Text = "Change"
        Me.btnChangeEmail.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnChangePassword.BackgroundImage = CType(resources.GetObject("btnChangePassword.BackgroundImage"), System.Drawing.Image)
        Me.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(830, 459)
        Me.btnChangePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(118, 38)
        Me.btnChangePassword.TabIndex = 31
        Me.btnChangePassword.Text = "Change"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnChangeName
        '
        Me.btnChangeName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnChangeName.BackgroundImage = CType(resources.GetObject("btnChangeName.BackgroundImage"), System.Drawing.Image)
        Me.btnChangeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeName.ForeColor = System.Drawing.Color.White
        Me.btnChangeName.Location = New System.Drawing.Point(828, 169)
        Me.btnChangeName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(120, 39)
        Me.btnChangeName.TabIndex = 30
        Me.btnChangeName.Text = "Change"
        Me.btnChangeName.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(965, 541)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(151, 46)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "BACK"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(178, 45)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(847, 102)
        Me.Label73.TabIndex = 110
        Me.Label73.Text = "DRIVER PROFILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(22, 313)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 116
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_history
        Me.pcbPlaces.Location = New System.Drawing.Point(22, 449)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 115
        Me.pcbPlaces.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(22, 554)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 113
        Me.pcbProfile.TabStop = False
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(22, 167)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 111
        Me.pcbHome.TabStop = False
        '
        'mskNewPhoneNum
        '
        Me.mskNewPhoneNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Phone", True))
        Me.mskNewPhoneNum.Enabled = False
        Me.mskNewPhoneNum.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNewPhoneNum.Location = New System.Drawing.Point(400, 243)
        Me.mskNewPhoneNum.Mask = "000-0000-0000"
        Me.mskNewPhoneNum.Name = "mskNewPhoneNum"
        Me.mskNewPhoneNum.Size = New System.Drawing.Size(390, 34)
        Me.mskNewPhoneNum.TabIndex = 123
        '
        'DriverBindingSource
        '
        Me.DriverBindingSource.DataMember = "Driver"
        Me.DriverBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mskNewICnum
        '
        Me.mskNewICnum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_IC", True))
        Me.mskNewICnum.Enabled = False
        Me.mskNewICnum.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskNewICnum.Location = New System.Drawing.Point(400, 310)
        Me.mskNewICnum.Mask = "000000-00-0000"
        Me.mskNewICnum.Name = "mskNewICnum"
        Me.mskNewICnum.Size = New System.Drawing.Size(390, 34)
        Me.mskNewICnum.TabIndex = 122
        '
        'txtNewPassword
        '
        Me.txtNewPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Password", True))
        Me.txtNewPassword.Enabled = False
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(400, 462)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(390, 34)
        Me.txtNewPassword.TabIndex = 121
        '
        'txtNewEmail
        '
        Me.txtNewEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Email", True))
        Me.txtNewEmail.Enabled = False
        Me.txtNewEmail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewEmail.Location = New System.Drawing.Point(400, 378)
        Me.txtNewEmail.Name = "txtNewEmail"
        Me.txtNewEmail.Size = New System.Drawing.Size(390, 34)
        Me.txtNewEmail.TabIndex = 120
        '
        'txtNewName
        '
        Me.txtNewName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Name", True))
        Me.txtNewName.Enabled = False
        Me.txtNewName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewName.Location = New System.Drawing.Point(400, 175)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(390, 34)
        Me.txtNewName.TabIndex = 119
        '
        'DriverTableAdapter
        '
        Me.DriverTableAdapter.ClearBeforeFill = True
        '
        'driverProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.driver_bg_profile
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.mskNewPhoneNum)
        Me.Controls.Add(Me.mskNewICnum)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewEmail)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangePhone)
        Me.Controls.Add(Me.btnChangeIC)
        Me.Controls.Add(Me.btnChangeEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "driverProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "driverProfile"
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChangePhone As Button
    Friend WithEvents btnChangeIC As Button
    Friend WithEvents btnChangeEmail As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnChangeName As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbHome As PictureBox
    Friend WithEvents mskNewPhoneNum As MaskedTextBox
    Friend WithEvents mskNewICnum As MaskedTextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewEmail As TextBox
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents DriverBindingSource As BindingSource
    Friend WithEvents DriverTableAdapter As TROVAdatabaseDataSetTableAdapters.DriverTableAdapter
End Class
