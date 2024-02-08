<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class top_up_confirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(top_up_confirmation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.TrovaPayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TrovaPayTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.TrovaPayTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrovaPayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "YOUR TOP UP HAS BEEN SUCCESSFUL"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.OMC2.My.Resources.Resources.BG1
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNext.Location = New System.Drawing.Point(610, 383)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(159, 46)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "CONTINUE"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.OMC2.My.Resources.Resources.Successful_purchase_pana
        Me.PictureBox1.Location = New System.Drawing.Point(200, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 361)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrovaPayBindingSource, "amount", True))
        Me.lblValue.ForeColor = System.Drawing.SystemColors.Control
        Me.lblValue.Location = New System.Drawing.Point(610, 213)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(48, 16)
        Me.lblValue.TabIndex = 10
        Me.lblValue.Text = "Label2"
        '
        'TrovaPayBindingSource
        '
        Me.TrovaPayBindingSource.DataMember = "TrovaPay"
        Me.TrovaPayBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.AutoSize = True
        Me.lblPhoneNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrovaPayBindingSource, "U_PhoneNumber", True))
        Me.lblPhoneNum.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPhoneNum.Location = New System.Drawing.Point(610, 249)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(48, 16)
        Me.lblPhoneNum.TabIndex = 11
        Me.lblPhoneNum.Text = "Label3"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrovaPayBindingSource, "status", True))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Location = New System.Drawing.Point(613, 179)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 16)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Label4"
        '
        'TrovaPayTableAdapter
        '
        Me.TrovaPayTableAdapter.ClearBeforeFill = True
        '
        'top_up_confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "top_up_confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT CONFIRMATION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrovaPayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblValue As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents TrovaPayBindingSource As BindingSource
    Friend WithEvents TrovaPayTableAdapter As TROVAdatabaseDataSetTableAdapters.TrovaPayTableAdapter
End Class
