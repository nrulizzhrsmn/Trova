<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPage))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboReport = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.grbREPORT = New System.Windows.Forms.GroupBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblReportCategory = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.pcb2 = New System.Windows.Forms.PictureBox()
        Me.pcb3 = New System.Windows.Forms.PictureBox()
        Me.pcb4 = New System.Windows.Forms.PictureBox()
        Me.pcb5 = New System.Windows.Forms.PictureBox()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.grbREPORT.SuspendLayout()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(180, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Report category:"
        '
        'cboReport
        '
        Me.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReport.ForeColor = System.Drawing.Color.Black
        Me.cboReport.FormattingEnabled = True
        Me.cboReport.Items.AddRange(New Object() {"DRIVER     ", "CAR               ", "APPLICATION"})
        Me.cboReport.Location = New System.Drawing.Point(185, 224)
        Me.cboReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboReport.Name = "cboReport"
        Me.cboReport.Size = New System.Drawing.Size(289, 30)
        Me.cboReport.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(180, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Rating:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(180, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Please write the details: "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(185, 381)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(289, 83)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'grbREPORT
        '
        Me.grbREPORT.BackColor = System.Drawing.Color.Transparent
        Me.grbREPORT.Controls.Add(Me.lblRating)
        Me.grbREPORT.Controls.Add(Me.Label7)
        Me.grbREPORT.Controls.Add(Me.lblDetails)
        Me.grbREPORT.Controls.Add(Me.lblName)
        Me.grbREPORT.Controls.Add(Me.lblReportCategory)
        Me.grbREPORT.Controls.Add(Me.Label6)
        Me.grbREPORT.Controls.Add(Me.Label5)
        Me.grbREPORT.Controls.Add(Me.Label4)
        Me.grbREPORT.Controls.Add(Me.Label3)
        Me.grbREPORT.ForeColor = System.Drawing.Color.White
        Me.grbREPORT.Location = New System.Drawing.Point(516, 198)
        Me.grbREPORT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbREPORT.Name = "grbREPORT"
        Me.grbREPORT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbREPORT.Size = New System.Drawing.Size(495, 275)
        Me.grbREPORT.TabIndex = 4
        Me.grbREPORT.TabStop = False
        '
        'lblRating
        '
        Me.lblRating.BackColor = System.Drawing.Color.Transparent
        Me.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Location = New System.Drawing.Point(242, 142)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(229, 28)
        Me.lblRating.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "RATING                     :"
        '
        'lblDetails
        '
        Me.lblDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(242, 183)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(229, 70)
        Me.lblDetails.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(243, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(228, 25)
        Me.lblName.TabIndex = 5
        '
        'lblReportCategory
        '
        Me.lblReportCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblReportCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReportCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportCategory.Location = New System.Drawing.Point(242, 104)
        Me.lblReportCategory.Name = "lblReportCategory"
        Me.lblReportCategory.Size = New System.Drawing.Size(228, 25)
        Me.lblReportCategory.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "REPORT DETAILS   :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "CATEGORY              :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NAME                        :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "REPORT INFORMATION"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnDone.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(914, 512)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(150, 52)
        Me.btnDone.TabIndex = 15
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'pcb2
        '
        Me.pcb2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcb2.Location = New System.Drawing.Point(249, 295)
        Me.pcb2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb2.Name = "pcb2"
        Me.pcb2.Size = New System.Drawing.Size(25, 25)
        Me.pcb2.TabIndex = 14
        Me.pcb2.TabStop = False
        '
        'pcb3
        '
        Me.pcb3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcb3.Location = New System.Drawing.Point(296, 295)
        Me.pcb3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb3.Name = "pcb3"
        Me.pcb3.Size = New System.Drawing.Size(25, 25)
        Me.pcb3.TabIndex = 13
        Me.pcb3.TabStop = False
        '
        'pcb4
        '
        Me.pcb4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcb4.Location = New System.Drawing.Point(345, 295)
        Me.pcb4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb4.Name = "pcb4"
        Me.pcb4.Size = New System.Drawing.Size(25, 25)
        Me.pcb4.TabIndex = 12
        Me.pcb4.TabStop = False
        '
        'pcb5
        '
        Me.pcb5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcb5.Location = New System.Drawing.Point(396, 295)
        Me.pcb5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb5.Name = "pcb5"
        Me.pcb5.Size = New System.Drawing.Size(25, 25)
        Me.pcb5.TabIndex = 11
        Me.pcb5.TabStop = False
        '
        'pcb1
        '
        Me.pcb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pcb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcb1.Location = New System.Drawing.Point(199, 295)
        Me.pcb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(25, 25)
        Me.pcb1.TabIndex = 9
        Me.pcb1.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BackgroundImage = Global.OMC2.My.Resources.Resources.icon_tick
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(432, 475)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(42, 37)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(23, 229)
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
        Me.pcbPlaces.Location = New System.Drawing.Point(23, 303)
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
        Me.pcbTopUp.Location = New System.Drawing.Point(23, 378)
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
        Me.pcbProfile.Location = New System.Drawing.Point(23, 459)
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
        Me.pcbSettings.Location = New System.Drawing.Point(23, 537)
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
        Me.PictureBox9.Location = New System.Drawing.Point(23, 155)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 105
        Me.PictureBox9.TabStop = False
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(113, 55)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(559, 113)
        Me.Label73.TabIndex = 111
        Me.Label73.Text = "USER REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.setting_no_title
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.pcb2)
        Me.Controls.Add(Me.pcb3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pcb4)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.pcb5)
        Me.Controls.Add(Me.grbREPORT)
        Me.Controls.Add(Me.pcb1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ReportPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportPage"
        Me.grbREPORT.ResumeLayout(False)
        Me.grbREPORT.PerformLayout()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cboReport As ComboBox
    Friend WithEvents grbREPORT As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblReportCategory As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblRating As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pcb2 As PictureBox
    Friend WithEvents pcb3 As PictureBox
    Friend WithEvents pcb4 As PictureBox
    Friend WithEvents pcb5 As PictureBox
    Friend WithEvents pcb1 As PictureBox
    Friend WithEvents btnDone As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label73 As Label
End Class
