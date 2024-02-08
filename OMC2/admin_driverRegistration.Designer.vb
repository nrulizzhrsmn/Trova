<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_driverRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_driverRegistration))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DriverIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DLicenseDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.DriverTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.DriverTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(992, 501)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 56)
        Me.btnClose.TabIndex = 70
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
        Me.btnNext.Location = New System.Drawing.Point(546, 501)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(119, 56)
        Me.btnNext.TabIndex = 69
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
        Me.btnSave.Location = New System.Drawing.Point(846, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 56)
        Me.btnSave.TabIndex = 68
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
        Me.btnDelete.Location = New System.Drawing.Point(692, 501)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 56)
        Me.btnDelete.TabIndex = 67
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
        Me.btnPrevious.Location = New System.Drawing.Point(402, 501)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(119, 56)
        Me.btnPrevious.TabIndex = 66
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DriverIDDataGridViewTextBoxColumn, Me.DNameDataGridViewTextBoxColumn, Me.DICDataGridViewTextBoxColumn, Me.DPhoneDataGridViewTextBoxColumn, Me.DGenderDataGridViewTextBoxColumn, Me.DEmailDataGridViewTextBoxColumn, Me.DPasswordDataGridViewTextBoxColumn, Me.DPhotoDataGridViewImageColumn, Me.DLicenseDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.DriverBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(156, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(895, 311)
        Me.DataGridView1.TabIndex = 71
        '
        'DriverIDDataGridViewTextBoxColumn
        '
        Me.DriverIDDataGridViewTextBoxColumn.DataPropertyName = "driverID"
        Me.DriverIDDataGridViewTextBoxColumn.HeaderText = "driverID"
        Me.DriverIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DriverIDDataGridViewTextBoxColumn.Name = "DriverIDDataGridViewTextBoxColumn"
        Me.DriverIDDataGridViewTextBoxColumn.Width = 125
        '
        'DNameDataGridViewTextBoxColumn
        '
        Me.DNameDataGridViewTextBoxColumn.DataPropertyName = "D_Name"
        Me.DNameDataGridViewTextBoxColumn.HeaderText = "D_Name"
        Me.DNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DNameDataGridViewTextBoxColumn.Name = "DNameDataGridViewTextBoxColumn"
        Me.DNameDataGridViewTextBoxColumn.Width = 125
        '
        'DICDataGridViewTextBoxColumn
        '
        Me.DICDataGridViewTextBoxColumn.DataPropertyName = "D_IC"
        Me.DICDataGridViewTextBoxColumn.HeaderText = "D_IC"
        Me.DICDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DICDataGridViewTextBoxColumn.Name = "DICDataGridViewTextBoxColumn"
        Me.DICDataGridViewTextBoxColumn.Width = 125
        '
        'DPhoneDataGridViewTextBoxColumn
        '
        Me.DPhoneDataGridViewTextBoxColumn.DataPropertyName = "D_Phone"
        Me.DPhoneDataGridViewTextBoxColumn.HeaderText = "D_Phone"
        Me.DPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DPhoneDataGridViewTextBoxColumn.Name = "DPhoneDataGridViewTextBoxColumn"
        Me.DPhoneDataGridViewTextBoxColumn.Width = 125
        '
        'DGenderDataGridViewTextBoxColumn
        '
        Me.DGenderDataGridViewTextBoxColumn.DataPropertyName = "D_Gender"
        Me.DGenderDataGridViewTextBoxColumn.HeaderText = "D_Gender"
        Me.DGenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DGenderDataGridViewTextBoxColumn.Name = "DGenderDataGridViewTextBoxColumn"
        Me.DGenderDataGridViewTextBoxColumn.Width = 125
        '
        'DEmailDataGridViewTextBoxColumn
        '
        Me.DEmailDataGridViewTextBoxColumn.DataPropertyName = "D_Email"
        Me.DEmailDataGridViewTextBoxColumn.HeaderText = "D_Email"
        Me.DEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DEmailDataGridViewTextBoxColumn.Name = "DEmailDataGridViewTextBoxColumn"
        Me.DEmailDataGridViewTextBoxColumn.Width = 125
        '
        'DPasswordDataGridViewTextBoxColumn
        '
        Me.DPasswordDataGridViewTextBoxColumn.DataPropertyName = "D_Password"
        Me.DPasswordDataGridViewTextBoxColumn.HeaderText = "D_Password"
        Me.DPasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DPasswordDataGridViewTextBoxColumn.Name = "DPasswordDataGridViewTextBoxColumn"
        Me.DPasswordDataGridViewTextBoxColumn.Width = 125
        '
        'DPhotoDataGridViewImageColumn
        '
        Me.DPhotoDataGridViewImageColumn.DataPropertyName = "D_Photo"
        Me.DPhotoDataGridViewImageColumn.HeaderText = "D_Photo"
        Me.DPhotoDataGridViewImageColumn.MinimumWidth = 6
        Me.DPhotoDataGridViewImageColumn.Name = "DPhotoDataGridViewImageColumn"
        Me.DPhotoDataGridViewImageColumn.Width = 125
        '
        'DLicenseDataGridViewImageColumn
        '
        Me.DLicenseDataGridViewImageColumn.DataPropertyName = "D_License"
        Me.DLicenseDataGridViewImageColumn.HeaderText = "D_License"
        Me.DLicenseDataGridViewImageColumn.MinimumWidth = 6
        Me.DLicenseDataGridViewImageColumn.Name = "DLicenseDataGridViewImageColumn"
        Me.DLicenseDataGridViewImageColumn.Width = 125
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
        'DriverTableAdapter
        '
        Me.DriverTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(116, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(727, 52)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "DRIVER REGISTRATION DATABASE"
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(30, 325)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 96
        Me.pcbHome.TabStop = False
        '
        'admin_driverRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.driver_history1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_driverRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_driverRegistration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents DriverBindingSource As BindingSource
    Friend WithEvents DriverTableAdapter As TROVAdatabaseDataSetTableAdapters.DriverTableAdapter
    Friend WithEvents DriverIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DPhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DLicenseDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents pcbHome As PictureBox
End Class
