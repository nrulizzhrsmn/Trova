<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverRegistration))
        Me.btnEditLicence = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pcbLicense = New System.Windows.Forms.PictureBox()
        Me.DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.btnEditPicture = New System.Windows.Forms.Button()
        Me.pcbPhoto_User = New System.Windows.Forms.PictureBox()
        Me.chkConfirmPassword = New System.Windows.Forms.CheckBox()
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mskICNumberDriver = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pcbBook = New System.Windows.Forms.PictureBox()
        Me.pcbPlacesIcon = New System.Windows.Forms.PictureBox()
        Me.pcbProfileIcon = New System.Windows.Forms.PictureBox()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DriverTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.DriverTableAdapter()
        CType(Me.pcbLicense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPhoto_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlacesIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfileIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditLicence
        '
        Me.btnEditLicence.BackColor = System.Drawing.Color.Transparent
        Me.btnEditLicence.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_edit
        Me.btnEditLicence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditLicence.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditLicence.Location = New System.Drawing.Point(1079, 497)
        Me.btnEditLicence.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditLicence.Name = "btnEditLicence"
        Me.btnEditLicence.Size = New System.Drawing.Size(37, 35)
        Me.btnEditLicence.TabIndex = 94
        Me.btnEditLicence.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(876, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 27)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "your picture :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(876, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 27)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "License Picture :"
        '
        'pcbLicense
        '
        Me.pcbLicense.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DriverBindingSource, "D_License", True))
        Me.pcbLicense.Location = New System.Drawing.Point(881, 409)
        Me.pcbLicense.Name = "pcbLicense"
        Me.pcbLicense.Size = New System.Drawing.Size(192, 123)
        Me.pcbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLicense.TabIndex = 91
        Me.pcbLicense.TabStop = False
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
        'btnEditPicture
        '
        Me.btnEditPicture.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPicture.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_edit
        Me.btnEditPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditPicture.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditPicture.Location = New System.Drawing.Point(1053, 333)
        Me.btnEditPicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditPicture.Name = "btnEditPicture"
        Me.btnEditPicture.Size = New System.Drawing.Size(37, 35)
        Me.btnEditPicture.TabIndex = 90
        Me.btnEditPicture.UseVisualStyleBackColor = False
        '
        'pcbPhoto_User
        '
        Me.pcbPhoto_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbPhoto_User.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DriverBindingSource, "D_Photo", True))
        Me.pcbPhoto_User.Location = New System.Drawing.Point(881, 198)
        Me.pcbPhoto_User.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbPhoto_User.Name = "pcbPhoto_User"
        Me.pcbPhoto_User.Size = New System.Drawing.Size(166, 169)
        Me.pcbPhoto_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPhoto_User.TabIndex = 89
        Me.pcbPhoto_User.TabStop = False
        '
        'chkConfirmPassword
        '
        Me.chkConfirmPassword.AutoSize = True
        Me.chkConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.chkConfirmPassword.Location = New System.Drawing.Point(795, 537)
        Me.chkConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkConfirmPassword.Name = "chkConfirmPassword"
        Me.chkConfirmPassword.Size = New System.Drawing.Size(62, 20)
        Me.chkConfirmPassword.TabIndex = 88
        Me.chkConfirmPassword.Text = "Show"
        Me.chkConfirmPassword.UseVisualStyleBackColor = False
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Phone", True))
        Me.mskPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPhoneNumber.Location = New System.Drawing.Point(383, 294)
        Me.mskPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskPhoneNumber.Mask = "###-####-####"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(405, 30)
        Me.mskPhoneNumber.TabIndex = 3
        '
        'mskICNumberDriver
        '
        Me.mskICNumberDriver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_IC", True))
        Me.mskICNumberDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskICNumberDriver.Location = New System.Drawing.Point(384, 231)
        Me.mskICNumberDriver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskICNumberDriver.Mask = "######-##-####"
        Me.mskICNumberDriver.Name = "mskICNumberDriver"
        Me.mskICNumberDriver.Size = New System.Drawing.Size(403, 30)
        Me.mskICNumberDriver.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Email", True))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(383, 414)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(405, 30)
        Me.txtUsername.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(406, 577)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(0, 20)
        Me.lblPassword.TabIndex = 87
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Name", True))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(381, 173)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(405, 30)
        Me.txtName.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(795, 482)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 20)
        Me.CheckBox1.TabIndex = 86
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriverBindingSource, "D_Password", True))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(383, 474)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(405, 30)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.Window
        Me.btnNext.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1009, 560)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 49)
        Me.btnNext.TabIndex = 85
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(382, 532)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(405, 30)
        Me.txtConfirmPassword.TabIndex = 7
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'cboGender
        '
        Me.cboGender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DriverBindingSource, "D_Gender", True))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cboGender.Location = New System.Drawing.Point(382, 352)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(405, 33)
        Me.cboGender.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 27)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(134, 532)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 27)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "CONFIRM PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 27)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "IC NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 27)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(135, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 27)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "PHONE NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(135, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 27)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "USERNAME (EMAIL)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(134, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 27)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "GENDER"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(128, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(728, 116)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "DRIVER REGISTRATION"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pcbBook
        '
        Me.pcbBook.BackColor = System.Drawing.Color.Transparent
        Me.pcbBook.Image = CType(resources.GetObject("pcbBook.Image"), System.Drawing.Image)
        Me.pcbBook.Location = New System.Drawing.Point(23, 260)
        Me.pcbBook.Name = "pcbBook"
        Me.pcbBook.Size = New System.Drawing.Size(49, 33)
        Me.pcbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBook.TabIndex = 101
        Me.pcbBook.TabStop = False
        '
        'pcbPlacesIcon
        '
        Me.pcbPlacesIcon.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlacesIcon.Image = Global.OMC2.My.Resources.Resources.logo_history
        Me.pcbPlacesIcon.Location = New System.Drawing.Point(23, 363)
        Me.pcbPlacesIcon.Name = "pcbPlacesIcon"
        Me.pcbPlacesIcon.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlacesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlacesIcon.TabIndex = 100
        Me.pcbPlacesIcon.TabStop = False
        '
        'pcbProfileIcon
        '
        Me.pcbProfileIcon.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfileIcon.Image = CType(resources.GetObject("pcbProfileIcon.Image"), System.Drawing.Image)
        Me.pcbProfileIcon.Location = New System.Drawing.Point(23, 464)
        Me.pcbProfileIcon.Name = "pcbProfileIcon"
        Me.pcbProfileIcon.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfileIcon.TabIndex = 99
        Me.pcbProfileIcon.TabStop = False
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = CType(resources.GetObject("pcbHome.Image"), System.Drawing.Image)
        Me.pcbHome.Location = New System.Drawing.Point(23, 160)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 98
        Me.pcbHome.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.OMC2.My.Resources.Resources.driver31
        Me.PictureBox3.Location = New System.Drawing.Point(968, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 123)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 103
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.OMC2.My.Resources.Resources.DRIVER11
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(866, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Window
        Me.btnReset.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(843, 561)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(150, 49)
        Me.btnReset.TabIndex = 104
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'DriverTableAdapter
        '
        Me.DriverTableAdapter.ClearBeforeFill = True
        '
        'DriverRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.HOME_NO_TITLE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pcbBook)
        Me.Controls.Add(Me.pcbPlacesIcon)
        Me.Controls.Add(Me.pcbProfileIcon)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnEditLicence)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pcbLicense)
        Me.Controls.Add(Me.btnEditPicture)
        Me.Controls.Add(Me.pcbPhoto_User)
        Me.Controls.Add(Me.chkConfirmPassword)
        Me.Controls.Add(Me.mskPhoneNumber)
        Me.Controls.Add(Me.mskICNumberDriver)
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
        Me.Name = "DriverRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriverRegistration"
        CType(Me.pcbLicense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPhoto_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlacesIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfileIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditLicence As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pcbLicense As PictureBox
    Friend WithEvents btnEditPicture As Button
    Friend WithEvents pcbPhoto_User As PictureBox
    Friend WithEvents chkConfirmPassword As CheckBox
    Friend WithEvents mskPhoneNumber As MaskedTextBox
    Friend WithEvents mskICNumberDriver As MaskedTextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pcbBook As PictureBox
    Friend WithEvents pcbPlacesIcon As PictureBox
    Friend WithEvents pcbProfileIcon As PictureBox
    Friend WithEvents pcbHome As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents DriverBindingSource As BindingSource
    Friend WithEvents DriverTableAdapter As TROVAdatabaseDataSetTableAdapters.DriverTableAdapter
End Class
