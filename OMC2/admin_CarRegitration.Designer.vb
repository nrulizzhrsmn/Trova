<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_CarRegitration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_CarRegitration))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CbrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNumberPlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRoadTaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtNumPlate = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CarRegistrationTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.carRegistrationTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.mskRoadTax = New System.Windows.Forms.MaskedTextBox()
        Me.pcbHome = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnClose.Location = New System.Drawing.Point(981, 523)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 56)
        Me.btnClose.TabIndex = 49
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
        Me.btnNext.Location = New System.Drawing.Point(535, 523)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(119, 56)
        Me.btnNext.TabIndex = 48
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
        Me.btnSave.Location = New System.Drawing.Point(835, 523)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 56)
        Me.btnSave.TabIndex = 47
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
        Me.btnDelete.Location = New System.Drawing.Point(681, 523)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 56)
        Me.btnDelete.TabIndex = 46
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
        Me.btnPrevious.Location = New System.Drawing.Point(391, 523)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(119, 56)
        Me.btnPrevious.TabIndex = 45
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.CbrandDataGridViewTextBoxColumn, Me.CNumberPlateDataGridViewTextBoxColumn, Me.CColourDataGridViewTextBoxColumn, Me.CRoadTaxDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarRegistrationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(485, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(613, 305)
        Me.DataGridView1.TabIndex = 44
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "carID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "carID"
        Me.CarIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        Me.CarIDDataGridViewTextBoxColumn.Width = 125
        '
        'CbrandDataGridViewTextBoxColumn
        '
        Me.CbrandDataGridViewTextBoxColumn.DataPropertyName = "C_brand"
        Me.CbrandDataGridViewTextBoxColumn.HeaderText = "C_brand"
        Me.CbrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CbrandDataGridViewTextBoxColumn.Name = "CbrandDataGridViewTextBoxColumn"
        Me.CbrandDataGridViewTextBoxColumn.Width = 125
        '
        'CNumberPlateDataGridViewTextBoxColumn
        '
        Me.CNumberPlateDataGridViewTextBoxColumn.DataPropertyName = "C_NumberPlate"
        Me.CNumberPlateDataGridViewTextBoxColumn.HeaderText = "C_NumberPlate"
        Me.CNumberPlateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CNumberPlateDataGridViewTextBoxColumn.Name = "CNumberPlateDataGridViewTextBoxColumn"
        Me.CNumberPlateDataGridViewTextBoxColumn.Width = 125
        '
        'CColourDataGridViewTextBoxColumn
        '
        Me.CColourDataGridViewTextBoxColumn.DataPropertyName = "C_Colour"
        Me.CColourDataGridViewTextBoxColumn.HeaderText = "C_Colour"
        Me.CColourDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CColourDataGridViewTextBoxColumn.Name = "CColourDataGridViewTextBoxColumn"
        Me.CColourDataGridViewTextBoxColumn.Width = 125
        '
        'CRoadTaxDataGridViewTextBoxColumn
        '
        Me.CRoadTaxDataGridViewTextBoxColumn.DataPropertyName = "C_RoadTax"
        Me.CRoadTaxDataGridViewTextBoxColumn.HeaderText = "C_RoadTax"
        Me.CRoadTaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CRoadTaxDataGridViewTextBoxColumn.Name = "CRoadTaxDataGridViewTextBoxColumn"
        Me.CRoadTaxDataGridViewTextBoxColumn.Width = 125
        '
        'CarRegistrationBindingSource
        '
        Me.CarRegistrationBindingSource.DataMember = "carRegistration"
        Me.CarRegistrationBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(136, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 27)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "CAR BRAND"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(136, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 27)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "NUMBER PLATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(136, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "COLOUR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(136, 430)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 27)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "ROAD TAX DATE"
        '
        'txtBrand
        '
        Me.txtBrand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarRegistrationBindingSource, "C_brand", True))
        Me.txtBrand.Enabled = False
        Me.txtBrand.Location = New System.Drawing.Point(324, 263)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(100, 22)
        Me.txtBrand.TabIndex = 1
        '
        'txtNumPlate
        '
        Me.txtNumPlate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarRegistrationBindingSource, "C_NumberPlate", True))
        Me.txtNumPlate.Enabled = False
        Me.txtNumPlate.Location = New System.Drawing.Point(324, 314)
        Me.txtNumPlate.Name = "txtNumPlate"
        Me.txtNumPlate.Size = New System.Drawing.Size(100, 22)
        Me.txtNumPlate.TabIndex = 2
        '
        'txtColour
        '
        Me.txtColour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarRegistrationBindingSource, "C_Colour", True))
        Me.txtColour.Enabled = False
        Me.txtColour.Location = New System.Drawing.Point(324, 376)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(100, 22)
        Me.txtColour.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(141, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(659, 52)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "CAR REGISTRATION DATABASE"
        '
        'CarRegistrationTableAdapter
        '
        Me.CarRegistrationTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(252, 523)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 56)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'mskRoadTax
        '
        Me.mskRoadTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarRegistrationBindingSource, "C_RoadTax", True))
        Me.mskRoadTax.Location = New System.Drawing.Point(324, 430)
        Me.mskRoadTax.Mask = "00/00/0000"
        Me.mskRoadTax.Name = "mskRoadTax"
        Me.mskRoadTax.Size = New System.Drawing.Size(100, 22)
        Me.mskRoadTax.TabIndex = 4
        Me.mskRoadTax.ValidatingType = GetType(Date)
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.Transparent
        Me.pcbHome.Image = Global.OMC2.My.Resources.Resources.logo_home
        Me.pcbHome.Location = New System.Drawing.Point(32, 324)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(49, 33)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 97
        Me.pcbHome.TabStop = False
        '
        'admin_CarRegitration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC2.My.Resources.Resources.driver_history1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 624)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.mskRoadTax)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtNumPlate)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin_CarRegitration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_CarRegitration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtNumPlate As TextBox
    Friend WithEvents txtColour As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents CarRegistrationBindingSource As BindingSource
    Friend WithEvents CarRegistrationTableAdapter As TROVAdatabaseDataSetTableAdapters.carRegistrationTableAdapter
    Friend WithEvents CarIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CbrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CNumberPlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CRoadTaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents mskRoadTax As MaskedTextBox
    Friend WithEvents pcbHome As PictureBox
End Class
