<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(status))
        Me.rbtAvailable = New System.Windows.Forms.RadioButton()
        Me.rbtNotAvailble = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDone = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtAvailable
        '
        Me.rbtAvailable.AutoSize = True
        Me.rbtAvailable.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAvailable.Location = New System.Drawing.Point(410, 169)
        Me.rbtAvailable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtAvailable.Name = "rbtAvailable"
        Me.rbtAvailable.Size = New System.Drawing.Size(127, 31)
        Me.rbtAvailable.TabIndex = 0
        Me.rbtAvailable.TabStop = True
        Me.rbtAvailable.Text = "Available"
        Me.rbtAvailable.UseVisualStyleBackColor = True
        '
        'rbtNotAvailble
        '
        Me.rbtNotAvailble.AutoSize = True
        Me.rbtNotAvailble.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNotAvailble.Location = New System.Drawing.Point(410, 243)
        Me.rbtNotAvailble.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtNotAvailble.Name = "rbtNotAvailble"
        Me.rbtNotAvailble.Size = New System.Drawing.Size(171, 31)
        Me.rbtNotAvailble.TabIndex = 1
        Me.rbtNotAvailble.TabStop = True
        Me.rbtNotAvailble.Text = "Not Available"
        Me.rbtNotAvailble.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CHOOSE YOUR AVAILABILITY AS DRIVER TODAY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnDone
        '
        Me.btnDone.BackgroundImage = Global.OMC2.My.Resources.Resources.button_bg
        Me.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(476, 324)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(158, 61)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(656, 419)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbtNotAvailble)
        Me.Controls.Add(Me.rbtAvailable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "status"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtAvailable As RadioButton
    Friend WithEvents rbtNotAvailble As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
End Class
