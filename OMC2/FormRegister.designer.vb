<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.mskICNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.chkConfirmPassword = New System.Windows.Forms.CheckBox()
        Me.pcbPhoto_User = New System.Windows.Forms.PictureBox()
        Me.btnEditPicture = New System.Windows.Forms.Button()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ProfileTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.profileTableAdapter()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPhoto_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_Name", True))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(374, 172)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(405, 30)
        Me.txtName.TabIndex = 1
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "profile"
        Me.ProfileBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_Email", True))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(374, 429)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(405, 30)
        Me.txtUsername.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_Password", True))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(374, 488)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(405, 30)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(373, 544)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(405, 30)
        Me.txtConfirmPassword.TabIndex = 7
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(125, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "IC NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(126, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PHONE NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(125, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(126, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "USERNAME (EMAIL)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(126, 488)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(125, 544)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "CONFIRM PASSWORD"
        '
        'cboGender
        '
        Me.cboGender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ProfileBindingSource, "U_Gender", True))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cboGender.Location = New System.Drawing.Point(373, 362)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(405, 33)
        Me.cboGender.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Window
        Me.btnNext.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(994, 524)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(151, 57)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(786, 496)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 20)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(397, 589)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(0, 20)
        Me.lblPassword.TabIndex = 22
        '
        'mskICNumber
        '
        Me.mskICNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_IC", True))
        Me.mskICNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskICNumber.Location = New System.Drawing.Point(375, 234)
        Me.mskICNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskICNumber.Mask = "######-##-####"
        Me.mskICNumber.Name = "mskICNumber"
        Me.mskICNumber.Size = New System.Drawing.Size(403, 30)
        Me.mskICNumber.TabIndex = 2
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_Phone", True))
        Me.mskPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPhoneNumber.Location = New System.Drawing.Point(374, 297)
        Me.mskPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskPhoneNumber.Mask = "###-####-####"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(405, 30)
        Me.mskPhoneNumber.TabIndex = 3
        '
        'chkConfirmPassword
        '
        Me.chkConfirmPassword.AutoSize = True
        Me.chkConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.chkConfirmPassword.Location = New System.Drawing.Point(786, 552)
        Me.chkConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkConfirmPassword.Name = "chkConfirmPassword"
        Me.chkConfirmPassword.Size = New System.Drawing.Size(62, 20)
        Me.chkConfirmPassword.TabIndex = 23
        Me.chkConfirmPassword.Text = "Show"
        Me.chkConfirmPassword.UseVisualStyleBackColor = False
        '
        'pcbPhoto_User
        '
        Me.pcbPhoto_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbPhoto_User.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProfileBindingSource, "U_Photo", True))
        Me.pcbPhoto_User.Location = New System.Drawing.Point(856, 202)
        Me.pcbPhoto_User.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbPhoto_User.Name = "pcbPhoto_User"
        Me.pcbPhoto_User.Size = New System.Drawing.Size(166, 169)
        Me.pcbPhoto_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPhoto_User.TabIndex = 24
        Me.pcbPhoto_User.TabStop = False
        '
        'btnEditPicture
        '
        Me.btnEditPicture.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPicture.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_edit
        Me.btnEditPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditPicture.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditPicture.Location = New System.Drawing.Point(1037, 336)
        Me.btnEditPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditPicture.Name = "btnEditPicture"
        Me.btnEditPicture.Size = New System.Drawing.Size(37, 35)
        Me.btnEditPicture.TabIndex = 26
        Me.btnEditPicture.UseVisualStyleBackColor = False
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(21, 233)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 63
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = Global.OMC2.My.Resources.Resources.logo_places
        Me.pcbPlaces.Location = New System.Drawing.Point(21, 307)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 62
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = Global.OMC2.My.Resources.Resources.logo_top_up
        Me.pcbTopUp.Location = New System.Drawing.Point(21, 381)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(49, 41)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 61
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = Global.OMC2.My.Resources.Resources.logo_profile
        Me.pcbProfile.Location = New System.Drawing.Point(21, 463)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 60
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = Global.OMC2.My.Resources.Resources.logo_setting
        Me.pcbSettings.Location = New System.Drawing.Point(21, 545)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 59
        Me.pcbSettings.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.PictureBox3.Location = New System.Drawing.Point(21, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 58
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(851, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 27)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "your picture :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(653, 100)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "USER REGISTRATION"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(994, 441)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 55)
        Me.btnReset.TabIndex = 71
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.HOME_NO_TITLE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1170, 624)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnEditPicture)
        Me.Controls.Add(Me.pcbPhoto_User)
        Me.Controls.Add(Me.chkConfirmPassword)
        Me.Controls.Add(Me.mskPhoneNumber)
        Me.Controls.Add(Me.mskICNumber)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Register"
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPhoto_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents mskICNumber As MaskedTextBox
    Friend WithEvents mskPhoneNumber As MaskedTextBox
    Friend WithEvents chkConfirmPassword As CheckBox
    Friend WithEvents pcbPhoto_User As PictureBox
    Friend WithEvents btnEditPicture As Button
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As TROVAdatabaseDataSetTableAdapters.profileTableAdapter
End Class
