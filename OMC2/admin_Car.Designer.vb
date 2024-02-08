<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_Car
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_Car))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPhoneUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPlateNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPickUpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.RentalCarTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.rentalCarTableAdapter()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(147, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(514, 52)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "RENTAL CAR DATABASE"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(965, 520)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 56)
        Me.btnClose.TabIndex = 65
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(519, 520)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(119, 56)
        Me.btnNext.TabIndex = 64
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(819, 520)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 56)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(665, 520)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 56)
        Me.btnDelete.TabIndex = 62
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.AutoSize = True
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.BackgroundImage = CType(resources.GetObject("btnPrevious.BackgroundImage"), System.Drawing.Image)
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(375, 520)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(119, 56)
        Me.btnPrevious.TabIndex = 61
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.CPhoneUserDataGridViewTextBoxColumn, Me.CBrandDataGridViewTextBoxColumn, Me.CPlateNumberDataGridViewTextBoxColumn, Me.CColourDataGridViewTextBoxColumn, Me.CStartDateDataGridViewTextBoxColumn, Me.CEndDateDataGridViewTextBoxColumn, Me.CPriceDataGridViewTextBoxColumn, Me.CPickUpDataGridViewTextBoxColumn, Me.CStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RentalCarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(156, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(926, 305)
        Me.DataGridView1.TabIndex = 60
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "carID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "carID"
        Me.CarIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        Me.CarIDDataGridViewTextBoxColumn.Width = 125
        '
        'CPhoneUserDataGridViewTextBoxColumn
        '
        Me.CPhoneUserDataGridViewTextBoxColumn.DataPropertyName = "C_PhoneUser"
        Me.CPhoneUserDataGridViewTextBoxColumn.HeaderText = "C_PhoneUser"
        Me.CPhoneUserDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CPhoneUserDataGridViewTextBoxColumn.Name = "CPhoneUserDataGridViewTextBoxColumn"
        Me.CPhoneUserDataGridViewTextBoxColumn.Width = 125
        '
        'CBrandDataGridViewTextBoxColumn
        '
        Me.CBrandDataGridViewTextBoxColumn.DataPropertyName = "C_Brand"
        Me.CBrandDataGridViewTextBoxColumn.HeaderText = "C_Brand"
        Me.CBrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CBrandDataGridViewTextBoxColumn.Name = "CBrandDataGridViewTextBoxColumn"
        Me.CBrandDataGridViewTextBoxColumn.Width = 125
        '
        'CPlateNumberDataGridViewTextBoxColumn
        '
        Me.CPlateNumberDataGridViewTextBoxColumn.DataPropertyName = "C_PlateNumber"
        Me.CPlateNumberDataGridViewTextBoxColumn.HeaderText = "C_PlateNumber"
        Me.CPlateNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CPlateNumberDataGridViewTextBoxColumn.Name = "CPlateNumberDataGridViewTextBoxColumn"
        Me.CPlateNumberDataGridViewTextBoxColumn.Width = 125
        '
        'CColourDataGridViewTextBoxColumn
        '
        Me.CColourDataGridViewTextBoxColumn.DataPropertyName = "C_Colour"
        Me.CColourDataGridViewTextBoxColumn.HeaderText = "C_Colour"
        Me.CColourDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CColourDataGridViewTextBoxColumn.Name = "CColourDataGridViewTextBoxColumn"
        Me.CColourDataGridViewTextBoxColumn.Width = 125
        '
        'CStartDateDataGridViewTextBoxColumn
        '
        Me.CStartDateDataGridViewTextBoxColumn.DataPropertyName = "C_StartDate"
        Me.CStartDateDataGridViewTextBoxColumn.HeaderText = "C_StartDate"
        Me.CStartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CStartDateDataGridViewTextBoxColumn.Name = "CStartDateDataGridViewTextBoxColumn"
        Me.CStartDateDataGridViewTextBoxColumn.Width = 125
        '
        'CEndDateDataGridViewTextBoxColumn
        '
        Me.CEndDateDataGridViewTextBoxColumn.DataPropertyName = "C_EndDate"
        Me.CEndDateDataGridViewTextBoxColumn.HeaderText = "C_EndDate"
        Me.CEndDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CEndDateDataGridViewTextBoxColumn.Name = "CEndDateDataGridViewTextBoxColumn"
        Me.CEndDateDataGridViewTextBoxColumn.Width = 125
        '
        'CPriceDataGridViewTextBoxColumn
        '
        Me.CPriceDataGridViewTextBoxColumn.DataPropertyName = "C_Price"
        Me.CPriceDataGridViewTextBoxColumn.HeaderText = "C_Price"
        Me.CPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CPriceDataGridViewTextBoxColumn.Name = "CPriceDataGridViewTextBoxColumn"
        Me.CPriceDataGridViewTextBoxColumn.Width = 125
        '
        'CPickUpDataGridViewTextBoxColumn
        '
        Me.CPickUpDataGridViewTextBoxColumn.DataPropertyName = "C_PickUp"
        Me.CPickUpDataGridViewTextBoxColumn.HeaderText = "C_PickUp"
        Me.CPickUpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CPickUpDataGridViewTextBoxColumn.Name = "CPickUpDataGridViewTextBoxColumn"
        Me.CPickUpDataGridViewTextBoxColumn.Width = 125
        '
        'CStatusDataGridViewTextBoxColumn
        '
        Me.CStatusDataGridViewTextBoxColumn.DataPropertyName = "C_Status"
        Me.CStatusDataGridViewTextBoxColumn.HeaderText = "C_Status"
        Me.CStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CStatusDataGridViewTextBoxColumn.Name = "CStatusDataGridViewTextBoxColumn"
        Me.CStatusDataGridViewTextBoxColumn.Width = 125
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
        'RentalCarTableAdapter
        '
        Me.RentalCarTableAdapter.ClearBeforeFill = True
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(33, 324)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 97
        Me.pcbHome.TabStop = False
        '
        'admin_Car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.driver_history
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1169, 624)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_Car"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_Car"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents RentalCarBindingSource As BindingSource
    Friend WithEvents RentalCarTableAdapter As TROVAdatabaseDataSetTableAdapters.rentalCarTableAdapter
    Friend WithEvents CarIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPhoneUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPlateNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPickUpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pcbHome As PictureBox
End Class
