<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_user))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.ProfileTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.profileTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UNameDataGridViewTextBoxColumn, Me.UICDataGridViewTextBoxColumn, Me.UPhoneDataGridViewTextBoxColumn, Me.UGenderDataGridViewTextBoxColumn, Me.UEmailDataGridViewTextBoxColumn, Me.UPasswordDataGridViewTextBoxColumn, Me.UPhotoDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.ProfileBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(134, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(940, 346)
        Me.DataGridView1.TabIndex = 0
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.Width = 125
        '
        'UNameDataGridViewTextBoxColumn
        '
        Me.UNameDataGridViewTextBoxColumn.DataPropertyName = "U_Name"
        Me.UNameDataGridViewTextBoxColumn.HeaderText = "U_Name"
        Me.UNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UNameDataGridViewTextBoxColumn.Name = "UNameDataGridViewTextBoxColumn"
        Me.UNameDataGridViewTextBoxColumn.Width = 125
        '
        'UICDataGridViewTextBoxColumn
        '
        Me.UICDataGridViewTextBoxColumn.DataPropertyName = "U_IC"
        Me.UICDataGridViewTextBoxColumn.HeaderText = "U_IC"
        Me.UICDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UICDataGridViewTextBoxColumn.Name = "UICDataGridViewTextBoxColumn"
        Me.UICDataGridViewTextBoxColumn.Width = 125
        '
        'UPhoneDataGridViewTextBoxColumn
        '
        Me.UPhoneDataGridViewTextBoxColumn.DataPropertyName = "U_Phone"
        Me.UPhoneDataGridViewTextBoxColumn.HeaderText = "U_Phone"
        Me.UPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UPhoneDataGridViewTextBoxColumn.Name = "UPhoneDataGridViewTextBoxColumn"
        Me.UPhoneDataGridViewTextBoxColumn.Width = 125
        '
        'UGenderDataGridViewTextBoxColumn
        '
        Me.UGenderDataGridViewTextBoxColumn.DataPropertyName = "U_Gender"
        Me.UGenderDataGridViewTextBoxColumn.HeaderText = "U_Gender"
        Me.UGenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UGenderDataGridViewTextBoxColumn.Name = "UGenderDataGridViewTextBoxColumn"
        Me.UGenderDataGridViewTextBoxColumn.Width = 125
        '
        'UEmailDataGridViewTextBoxColumn
        '
        Me.UEmailDataGridViewTextBoxColumn.DataPropertyName = "U_Email"
        Me.UEmailDataGridViewTextBoxColumn.HeaderText = "U_Email"
        Me.UEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UEmailDataGridViewTextBoxColumn.Name = "UEmailDataGridViewTextBoxColumn"
        Me.UEmailDataGridViewTextBoxColumn.Width = 125
        '
        'UPasswordDataGridViewTextBoxColumn
        '
        Me.UPasswordDataGridViewTextBoxColumn.DataPropertyName = "U_Password"
        Me.UPasswordDataGridViewTextBoxColumn.HeaderText = "U_Password"
        Me.UPasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UPasswordDataGridViewTextBoxColumn.Name = "UPasswordDataGridViewTextBoxColumn"
        Me.UPasswordDataGridViewTextBoxColumn.Width = 125
        '
        'UPhotoDataGridViewImageColumn
        '
        Me.UPhotoDataGridViewImageColumn.DataPropertyName = "U_Photo"
        Me.UPhotoDataGridViewImageColumn.HeaderText = "U_Photo"
        Me.UPhotoDataGridViewImageColumn.MinimumWidth = 6
        Me.UPhotoDataGridViewImageColumn.Name = "UPhotoDataGridViewImageColumn"
        Me.UPhotoDataGridViewImageColumn.Width = 125
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
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(957, 528)
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
        Me.btnNext.Location = New System.Drawing.Point(511, 528)
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
        Me.btnSave.Location = New System.Drawing.Point(811, 528)
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
        Me.btnDelete.Location = New System.Drawing.Point(657, 528)
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
        Me.btnPrevious.Location = New System.Drawing.Point(367, 528)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(119, 56)
        Me.btnPrevious.TabIndex = 66
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(169, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(361, 52)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "USER DATABASE"
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(28, 324)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 97
        Me.pcbHome.TabStop = False
        '
        'admin_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.driver_history1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1168, 624)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_user"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As TROVAdatabaseDataSetTableAdapters.profileTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UGenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pcbHome As PictureBox
End Class
