﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PAHANG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAHANG))
        Me.pcbBook = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.pcbBooking = New System.Windows.Forms.PictureBox()
        Me.pcbPlaces = New System.Windows.Forms.PictureBox()
        Me.pcbTopUp = New System.Windows.Forms.PictureBox()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbSettings = New System.Windows.Forms.PictureBox()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        Me.pcbPrevious = New System.Windows.Forms.PictureBox()
        CType(Me.pcbBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbBook
        '
        Me.pcbBook.BackColor = System.Drawing.Color.Transparent
        Me.pcbBook.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.pcbBook.Image = Global.OMC2.My.Resources.Resources.book_now
        Me.pcbBook.Location = New System.Drawing.Point(941, 536)
        Me.pcbBook.Name = "pcbBook"
        Me.pcbBook.Size = New System.Drawing.Size(38, 41)
        Me.pcbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBook.TabIndex = 7
        Me.pcbBook.TabStop = False
        '
        'btnBook
        '
        Me.btnBook.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBook.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(909, 530)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(173, 55)
        Me.btnBook.TabIndex = 5
        Me.btnBook.Text = "       BOOK"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'pcbBooking
        '
        Me.pcbBooking.BackColor = System.Drawing.Color.Transparent
        Me.pcbBooking.Image = Global.OMC2.My.Resources.Resources.logo_booking
        Me.pcbBooking.Location = New System.Drawing.Point(22, 229)
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
        Me.pcbPlaces.Location = New System.Drawing.Point(22, 303)
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
        Me.pcbTopUp.Location = New System.Drawing.Point(22, 378)
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
        Me.pcbProfile.Location = New System.Drawing.Point(22, 459)
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
        Me.pcbSettings.Location = New System.Drawing.Point(22, 541)
        Me.pcbSettings.Name = "pcbSettings"
        Me.pcbSettings.Size = New System.Drawing.Size(49, 36)
        Me.pcbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSettings.TabIndex = 59
        Me.pcbSettings.TabStop = False
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(22, 155)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 58
        Me.pcbHome.TabStop = False
        '
        'pcbPrevious
        '
        Me.pcbPrevious.BackColor = System.Drawing.Color.Transparent
        Me.pcbPrevious.Image = Global.OMC2.My.Resources.Resources.previous
        Me.pcbPrevious.Location = New System.Drawing.Point(94, 29)
        Me.pcbPrevious.Name = "pcbPrevious"
        Me.pcbPrevious.Size = New System.Drawing.Size(100, 50)
        Me.pcbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbPrevious.TabIndex = 73
        Me.pcbPrevious.TabStop = False
        '
        'PAHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.pahang_new
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.pcbPrevious)
        Me.Controls.Add(Me.pcbBooking)
        Me.Controls.Add(Me.pcbPlaces)
        Me.Controls.Add(Me.pcbTopUp)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.pcbSettings)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.pcbBook)
        Me.Controls.Add(Me.btnBook)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PAHANG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAHANG"
        CType(Me.pcbBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbBook As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents pcbBooking As PictureBox
    Friend WithEvents pcbPlaces As PictureBox
    Friend WithEvents pcbTopUp As PictureBox
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbSettings As PictureBox
    Friend WithEvents pcbHome As PictureBox
    Friend WithEvents pcbPrevious As PictureBox
End Class
