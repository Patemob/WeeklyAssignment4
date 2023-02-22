<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirBnB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnB))
        Me.Displaybtn = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Headerlbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NumNightslbl = New System.Windows.Forms.Label()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Displaybtn
        '
        Me.Displaybtn.Location = New System.Drawing.Point(421, 343)
        Me.Displaybtn.Name = "Displaybtn"
        Me.Displaybtn.Size = New System.Drawing.Size(103, 43)
        Me.Displaybtn.TabIndex = 0
        Me.Displaybtn.Text = "Display Cost"
        Me.Displaybtn.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.Location = New System.Drawing.Point(555, 343)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(103, 43)
        Me.Clearbtn.TabIndex = 1
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(686, 343)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(103, 43)
        Me.Exitbtn.TabIndex = 2
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Headerlbl
        '
        Me.Headerlbl.AutoSize = True
        Me.Headerlbl.Font = New System.Drawing.Font("Comic Sans MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Headerlbl.Location = New System.Drawing.Point(409, 33)
        Me.Headerlbl.Name = "Headerlbl"
        Me.Headerlbl.Size = New System.Drawing.Size(385, 67)
        Me.Headerlbl.TabIndex = 3
        Me.Headerlbl.Text = "Orlando AirBnB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 439)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'NumNightslbl
        '
        Me.NumNightslbl.AutoSize = True
        Me.NumNightslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumNightslbl.Location = New System.Drawing.Point(416, 179)
        Me.NumNightslbl.Name = "NumNightslbl"
        Me.NumNightslbl.Size = New System.Drawing.Size(185, 25)
        Me.NumNightslbl.TabIndex = 6
        Me.NumNightslbl.Text = "Number of Nights:"
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(416, 247)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(138, 25)
        Me.lblCostOfStay.TabIndex = 7
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(650, 183)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(68, 22)
        Me.txtNights.TabIndex = 8
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(645, 247)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalCost.TabIndex = 9
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(524, 100)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(139, 25)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "Orlando AirBnB"
        '
        'frmAirBnB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.NumNightslbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Headerlbl)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Displaybtn)
        Me.Name = "frmAirBnB"
        Me.Text = "AirBnB Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Displaybtn As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Headerlbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumNightslbl As Label
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCost As Label
End Class
