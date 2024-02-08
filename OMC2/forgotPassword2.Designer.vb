<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPassword2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotPassword2))
        Me.txtPasswordConfirmation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.TROVAdatabaseDataSet = New OMC2.TROVAdatabaseDataSet()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfileTableAdapter = New OMC2.TROVAdatabaseDataSetTableAdapters.profileTableAdapter()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnPress = New System.Windows.Forms.Button()
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPasswordConfirmation
        '
        Me.txtPasswordConfirmation.Enabled = False
        Me.txtPasswordConfirmation.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordConfirmation.Location = New System.Drawing.Point(48, 151)
        Me.txtPasswordConfirmation.Name = "txtPasswordConfirmation"
        Me.txtPasswordConfirmation.Size = New System.Drawing.Size(241, 25)
        Me.txtPasswordConfirmation.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 27)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Password confirmation"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.SystemColors.Control
        Me.btnDone.BackgroundImage = Global.OMC2.My.Resources.Resources.bg_pink
        Me.btnDone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(245, 189)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(98, 45)
        Me.btnDone.TabIndex = 77
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'TROVAdatabaseDataSet
        '
        Me.TROVAdatabaseDataSet.DataSetName = "TROVAdatabaseDataSet"
        Me.TROVAdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "profile"
        Me.ProfileBindingSource.DataSource = Me.TROVAdatabaseDataSet
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "U_Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(167, 68)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(29, 22)
        Me.txtPassword.TabIndex = 81
        '
        'btnPress
        '
        Me.btnPress.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnPress.BackgroundImage = CType(resources.GetObject("btnPress.BackgroundImage"), System.Drawing.Image)
        Me.btnPress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPress.ForeColor = System.Drawing.Color.White
        Me.btnPress.Location = New System.Drawing.Point(48, 33)
        Me.btnPress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(248, 69)
        Me.btnPress.TabIndex = 82
        Me.btnPress.Text = "Click to Change Password"
        Me.btnPress.UseVisualStyleBackColor = False
        '
        'forgotPassword2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 243)
        Me.Controls.Add(Me.btnPress)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPasswordConfirmation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDone)
        Me.Name = "forgotPassword2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgotPassword2"
        CType(Me.TROVAdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPasswordConfirmation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents TROVAdatabaseDataSet As TROVAdatabaseDataSet
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As TROVAdatabaseDataSetTableAdapters.profileTableAdapter
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnPress As Button
End Class
