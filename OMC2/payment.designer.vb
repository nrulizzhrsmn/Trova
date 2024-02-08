<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
        Me.rbtCreditDebit = New System.Windows.Forms.RadioButton()
        Me.rbtTrovaPay = New System.Windows.Forms.RadioButton()
        Me.rbtCashCOD = New System.Windows.Forms.RadioButton()
        Me.rbtOnline_Banking = New System.Windows.Forms.RadioButton()
        Me.cboBank_Name = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cboAccount_Type = New System.Windows.Forms.ComboBox()
        Me.txtAccount_Username = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtAccount_Number = New System.Windows.Forms.TextBox()
        Me.mskExpired_Card = New System.Windows.Forms.MaskedTextBox()
        Me.cboTypes_Card = New System.Windows.Forms.ComboBox()
        Me.txtPhone_Number = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum_COD = New System.Windows.Forms.TextBox()
        Me.txtCW2_CVC2 = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.pcbTrova = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label73 = New System.Windows.Forms.Label()
        CType(Me.pcbTrova, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtCreditDebit
        '
        Me.rbtCreditDebit.AutoSize = True
        Me.rbtCreditDebit.BackColor = System.Drawing.Color.Transparent
        Me.rbtCreditDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCreditDebit.ForeColor = System.Drawing.Color.White
        Me.rbtCreditDebit.Location = New System.Drawing.Point(444, 285)
        Me.rbtCreditDebit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtCreditDebit.Name = "rbtCreditDebit"
        Me.rbtCreditDebit.Size = New System.Drawing.Size(184, 29)
        Me.rbtCreditDebit.TabIndex = 9
        Me.rbtCreditDebit.TabStop = True
        Me.rbtCreditDebit.Text = "Debit/Credit Card"
        Me.rbtCreditDebit.UseVisualStyleBackColor = False
        '
        'rbtTrovaPay
        '
        Me.rbtTrovaPay.AutoSize = True
        Me.rbtTrovaPay.BackColor = System.Drawing.Color.Transparent
        Me.rbtTrovaPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTrovaPay.ForeColor = System.Drawing.Color.White
        Me.rbtTrovaPay.Location = New System.Drawing.Point(690, 285)
        Me.rbtTrovaPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtTrovaPay.Name = "rbtTrovaPay"
        Me.rbtTrovaPay.Size = New System.Drawing.Size(118, 29)
        Me.rbtTrovaPay.TabIndex = 10
        Me.rbtTrovaPay.TabStop = True
        Me.rbtTrovaPay.Text = "TrovaPay"
        Me.rbtTrovaPay.UseVisualStyleBackColor = False
        '
        'rbtCashCOD
        '
        Me.rbtCashCOD.AutoSize = True
        Me.rbtCashCOD.BackColor = System.Drawing.Color.Transparent
        Me.rbtCashCOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCashCOD.ForeColor = System.Drawing.Color.White
        Me.rbtCashCOD.Location = New System.Drawing.Point(864, 285)
        Me.rbtCashCOD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtCashCOD.Name = "rbtCashCOD"
        Me.rbtCashCOD.Size = New System.Drawing.Size(178, 29)
        Me.rbtCashCOD.TabIndex = 11
        Me.rbtCashCOD.TabStop = True
        Me.rbtCashCOD.Text = "Cash / Cashless"
        Me.rbtCashCOD.UseVisualStyleBackColor = False
        '
        'rbtOnline_Banking
        '
        Me.rbtOnline_Banking.AutoSize = True
        Me.rbtOnline_Banking.BackColor = System.Drawing.Color.Transparent
        Me.rbtOnline_Banking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtOnline_Banking.ForeColor = System.Drawing.Color.White
        Me.rbtOnline_Banking.Location = New System.Drawing.Point(180, 285)
        Me.rbtOnline_Banking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtOnline_Banking.Name = "rbtOnline_Banking"
        Me.rbtOnline_Banking.Size = New System.Drawing.Size(221, 29)
        Me.rbtOnline_Banking.TabIndex = 12
        Me.rbtOnline_Banking.TabStop = True
        Me.rbtOnline_Banking.Text = "Online Banking / FPX"
        Me.rbtOnline_Banking.UseVisualStyleBackColor = False
        '
        'cboBank_Name
        '
        Me.cboBank_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBank_Name.ForeColor = System.Drawing.Color.Black
        Me.cboBank_Name.FormattingEnabled = True
        Me.cboBank_Name.Items.AddRange(New Object() {"CIMB Bank", "Maybank ", "AmBank", "Alliance Bank", "RHB Bank", "Affin Bank", "HSBC Malaysia", "Hong Leong Bank", "Citi Bank", "Bank Rakyat", "BSN ", "Muamalat", "Bank Islam", "UOB Malaysia", "Agro Bank"})
        Me.cboBank_Name.Location = New System.Drawing.Point(318, 353)
        Me.cboBank_Name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBank_Name.MinimumSize = New System.Drawing.Size(224, 0)
        Me.cboBank_Name.Name = "cboBank_Name"
        Me.cboBank_Name.Size = New System.Drawing.Size(224, 33)
        Me.cboBank_Name.TabIndex = 1
        Me.cboBank_Name.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(142, 353)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(120, 25)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Bank Name:"
        Me.lbl1.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(593, 355)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(164, 25)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "Account Number:"
        Me.lbl3.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(142, 435)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(161, 25)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Type of Account:"
        Me.lbl2.Visible = False
        '
        'cboAccount_Type
        '
        Me.cboAccount_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccount_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccount_Type.ForeColor = System.Drawing.Color.Black
        Me.cboAccount_Type.FormattingEnabled = True
        Me.cboAccount_Type.Items.AddRange(New Object() {"Savings Account", "Current Account", ""})
        Me.cboAccount_Type.Location = New System.Drawing.Point(318, 429)
        Me.cboAccount_Type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAccount_Type.Name = "cboAccount_Type"
        Me.cboAccount_Type.Size = New System.Drawing.Size(224, 33)
        Me.cboAccount_Type.TabIndex = 5
        Me.cboAccount_Type.Visible = False
        '
        'txtAccount_Username
        '
        Me.txtAccount_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount_Username.ForeColor = System.Drawing.Color.Black
        Me.txtAccount_Username.Location = New System.Drawing.Point(811, 426)
        Me.txtAccount_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccount_Username.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtAccount_Username.Name = "txtAccount_Username"
        Me.txtAccount_Username.Size = New System.Drawing.Size(224, 28)
        Me.txtAccount_Username.TabIndex = 6
        Me.txtAccount_Username.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(593, 431)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(185, 25)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "Account Username:"
        Me.lbl4.Visible = False
        '
        'txtAccount_Number
        '
        Me.txtAccount_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount_Number.ForeColor = System.Drawing.Color.Black
        Me.txtAccount_Number.Location = New System.Drawing.Point(811, 353)
        Me.txtAccount_Number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccount_Number.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtAccount_Number.Name = "txtAccount_Number"
        Me.txtAccount_Number.Size = New System.Drawing.Size(224, 28)
        Me.txtAccount_Number.TabIndex = 8
        Me.txtAccount_Number.Visible = False
        '
        'mskExpired_Card
        '
        Me.mskExpired_Card.Location = New System.Drawing.Point(811, 353)
        Me.mskExpired_Card.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskExpired_Card.Mask = "##/####"
        Me.mskExpired_Card.MinimumSize = New System.Drawing.Size(224, 37)
        Me.mskExpired_Card.Name = "mskExpired_Card"
        Me.mskExpired_Card.Size = New System.Drawing.Size(224, 22)
        Me.mskExpired_Card.TabIndex = 17
        Me.mskExpired_Card.Visible = False
        '
        'cboTypes_Card
        '
        Me.cboTypes_Card.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypes_Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTypes_Card.ForeColor = System.Drawing.Color.Black
        Me.cboTypes_Card.FormattingEnabled = True
        Me.cboTypes_Card.Items.AddRange(New Object() {"VISA", "MASTERCARD"})
        Me.cboTypes_Card.Location = New System.Drawing.Point(318, 353)
        Me.cboTypes_Card.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTypes_Card.MinimumSize = New System.Drawing.Size(224, 0)
        Me.cboTypes_Card.Name = "cboTypes_Card"
        Me.cboTypes_Card.Size = New System.Drawing.Size(224, 33)
        Me.cboTypes_Card.TabIndex = 19
        Me.cboTypes_Card.Visible = False
        '
        'txtPhone_Number
        '
        Me.txtPhone_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone_Number.ForeColor = System.Drawing.Color.Black
        Me.txtPhone_Number.Location = New System.Drawing.Point(811, 353)
        Me.txtPhone_Number.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone_Number.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtPhone_Number.Name = "txtPhone_Number"
        Me.txtPhone_Number.Size = New System.Drawing.Size(224, 28)
        Me.txtPhone_Number.TabIndex = 20
        Me.txtPhone_Number.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(811, 422)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 28)
        Me.txtUsername.TabIndex = 21
        Me.txtUsername.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(811, 422)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(224, 28)
        Me.txtAddress.TabIndex = 24
        Me.txtAddress.Visible = False
        '
        'txtPhoneNum_COD
        '
        Me.txtPhoneNum_COD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNum_COD.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneNum_COD.Location = New System.Drawing.Point(811, 352)
        Me.txtPhoneNum_COD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhoneNum_COD.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtPhoneNum_COD.Name = "txtPhoneNum_COD"
        Me.txtPhoneNum_COD.Size = New System.Drawing.Size(224, 28)
        Me.txtPhoneNum_COD.TabIndex = 25
        Me.txtPhoneNum_COD.Visible = False
        '
        'txtCW2_CVC2
        '
        Me.txtCW2_CVC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW2_CVC2.ForeColor = System.Drawing.Color.Black
        Me.txtCW2_CVC2.Location = New System.Drawing.Point(811, 422)
        Me.txtCW2_CVC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCW2_CVC2.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtCW2_CVC2.Name = "txtCW2_CVC2"
        Me.txtCW2_CVC2.Size = New System.Drawing.Size(224, 28)
        Me.txtCW2_CVC2.TabIndex = 26
        Me.txtCW2_CVC2.Visible = False
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCardNumber.Location = New System.Drawing.Point(318, 429)
        Me.txtCardNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCardNumber.MinimumSize = New System.Drawing.Size(224, 37)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(224, 28)
        Me.txtCardNumber.TabIndex = 27
        Me.txtCardNumber.Visible = False
        '
        'pcbTrova
        '
        Me.pcbTrova.BackColor = System.Drawing.Color.Transparent
        Me.pcbTrova.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_trovapay
        Me.pcbTrova.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbTrova.Location = New System.Drawing.Point(318, 335)
        Me.pcbTrova.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbTrova.Name = "pcbTrova"
        Me.pcbTrova.Size = New System.Drawing.Size(156, 135)
        Me.pcbTrova.TabIndex = 22
        Me.pcbTrova.TabStop = False
        Me.pcbTrova.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(477, 515)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(235, 59)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "CONFIRM "
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_payment
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(514, 153)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 114)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(24, 222)
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
        Me.pcbPlaces.Location = New System.Drawing.Point(24, 296)
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
        Me.pcbTopUp.Location = New System.Drawing.Point(24, 371)
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
        Me.pcbProfile.Location = New System.Drawing.Point(24, 452)
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
        Me.pcbSettings.Location = New System.Drawing.Point(24, 534)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 94
        Me.pcbSettings.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.PictureBox9.Location = New System.Drawing.Point(24, 148)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 93
        Me.PictureBox9.TabStop = False
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(137, 64)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(847, 76)
        Me.Label73.TabIndex = 99
        Me.Label73.Text = "PAYMENT METHOD"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.top_up_no_title
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1163, 624)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtCW2_CVC2)
        Me.Controls.Add(Me.txtPhoneNum_COD)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.pcbTrova)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhone_Number)
        Me.Controls.Add(Me.cboTypes_Card)
        Me.Controls.Add(Me.mskExpired_Card)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtOnline_Banking)
        Me.Controls.Add(Me.rbtCashCOD)
        Me.Controls.Add(Me.rbtTrovaPay)
        Me.Controls.Add(Me.rbtCreditDebit)
        Me.Controls.Add(Me.txtAccount_Number)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtAccount_Username)
        Me.Controls.Add(Me.cboAccount_Type)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cboBank_Name)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payment"
        CType(Me.pcbTrova, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rbtCreditDebit As RadioButton
    Friend WithEvents rbtTrovaPay As RadioButton
    Friend WithEvents rbtCashCOD As RadioButton
    Friend WithEvents rbtOnline_Banking As RadioButton
    Friend WithEvents cboBank_Name As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents cboAccount_Type As ComboBox
    Friend WithEvents txtAccount_Username As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtAccount_Number As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents mskExpired_Card As MaskedTextBox
    Friend WithEvents cboTypes_Card As ComboBox
    Friend WithEvents txtPhone_Number As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNum_COD As TextBox
    Friend WithEvents txtCW2_CVC2 As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents pcbTrova As PictureBox
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label73 As Label
End Class
