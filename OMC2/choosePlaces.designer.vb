<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class choosePlaces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choosePlaces))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxStates = New System.Windows.Forms.ComboBox()
        Me.lblPlaces = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pcbPrevious = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 434)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cbxStates
        '
        Me.cbxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStates.FormattingEnabled = True
        Me.cbxStates.Items.AddRange(New Object() {"JOHOR", "MELAKA", "NEGERI SEMBILAN", "KUALA LUMPUR", "KELANTAN", "KEDAH", "SELANGOR", "TERENGGANU", "PERAK", "PAHANG", "PERLIS", "PENANG"})
        Me.cbxStates.Location = New System.Drawing.Point(274, 521)
        Me.cbxStates.Name = "cbxStates"
        Me.cbxStates.Size = New System.Drawing.Size(505, 24)
        Me.cbxStates.TabIndex = 1
        '
        'lblPlaces
        '
        Me.lblPlaces.AutoSize = True
        Me.lblPlaces.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaces.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaces.ForeColor = System.Drawing.Color.White
        Me.lblPlaces.Location = New System.Drawing.Point(269, 475)
        Me.lblPlaces.Name = "lblPlaces"
        Me.lblPlaces.Size = New System.Drawing.Size(178, 27)
        Me.lblPlaces.TabIndex = 5
        Me.lblPlaces.Text = "CHOOSE STATES"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNext.Location = New System.Drawing.Point(835, 502)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 53)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = CType(resources.GetObject("pcbBooking.Image"), System.Drawing.Image)
        Me.pcbBooking.Location = New System.Drawing.Point(24, 233)
        Me.pcbBooking.Name = "pcbBooking"
        Me.pcbBooking.Size = New System.Drawing.Size(49, 33)
        Me.pcbBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBooking.TabIndex = 57
        Me.pcbBooking.TabStop = False
        '
        'pcbPlaces
        '
        Me.pcbPlaces.BackColor = System.Drawing.Color.Transparent
        Me.pcbPlaces.Image = CType(resources.GetObject("pcbPlaces.Image"), System.Drawing.Image)
        Me.pcbPlaces.Location = New System.Drawing.Point(24, 307)
        Me.pcbPlaces.Name = "pcbPlaces"
        Me.pcbPlaces.Size = New System.Drawing.Size(49, 33)
        Me.pcbPlaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPlaces.TabIndex = 56
        Me.pcbPlaces.TabStop = False
        '
        'pcbTopUp
        '
        Me.pcbTopUp.BackColor = System.Drawing.Color.Transparent
        Me.pcbTopUp.Image = CType(resources.GetObject("pcbTopUp.Image"), System.Drawing.Image)
        Me.pcbTopUp.Location = New System.Drawing.Point(24, 382)
        Me.pcbTopUp.Name = "pcbTopUp"
        Me.pcbTopUp.Size = New System.Drawing.Size(49, 41)
        Me.pcbTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbTopUp.TabIndex = 55
        Me.pcbTopUp.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pcbProfile.Image = CType(resources.GetObject("pcbProfile.Image"), System.Drawing.Image)
        Me.pcbProfile.Location = New System.Drawing.Point(24, 463)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(49, 33)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 54
        Me.pcbProfile.TabStop = False
        '
        'pcbSettings
        '
        Me.pcbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pcbSettings.Image = CType(resources.GetObject("pcbSettings.Image"), System.Drawing.Image)
        Me.pcbSettings.Location = New System.Drawing.Point(24, 545)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 53
        Me.pcbSettings.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(24, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        '
        'pcbPrevious
        '
        Me.pcbPrevious.BackColor = System.Drawing.Color.Transparent
        Me.pcbPrevious.Image = CType(resources.GetObject("pcbPrevious.Image"), System.Drawing.Image)
        Me.pcbPrevious.Location = New System.Drawing.Point(122, 505)
        Me.pcbPrevious.Name = "pcbPrevious"
        Me.pcbPrevious.Size = New System.Drawing.Size(100, 50)
        Me.pcbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPrevious.TabIndex = 74
        Me.pcbPrevious.TabStop = False
        '
        'choosePlaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1164, 628)
        Me.Controls.Add(Me.pcbPrevious)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPlaces)
        Me.Controls.Add(Me.cbxStates)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "choosePlaces"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "choosePlaces"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbxStates As ComboBox
    Friend WithEvents lblPlaces As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pcbPrevious As PictureBox
End Class
