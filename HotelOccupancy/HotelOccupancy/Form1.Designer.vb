<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOccupiedRooms = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFloorNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOccupancyRate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalRoomsOccupied = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOccupiedRooms)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboFloorNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the occupancy rate for each floor"
        '
        'txtOccupiedRooms
        '
        Me.txtOccupiedRooms.Location = New System.Drawing.Point(507, 42)
        Me.txtOccupiedRooms.Name = "txtOccupiedRooms"
        Me.txtOccupiedRooms.Size = New System.Drawing.Size(71, 27)
        Me.txtOccupiedRooms.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(435, 118)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 27)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(65, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of rooms per floor = 30"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(326, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of occupied rooms:"
        '
        'cboFloorNumber
        '
        Me.cboFloorNumber.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboFloorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFloorNumber.FormattingEnabled = True
        Me.cboFloorNumber.Location = New System.Drawing.Point(223, 47)
        Me.cboFloorNumber.Name = "cboFloorNumber"
        Me.cboFloorNumber.Size = New System.Drawing.Size(44, 27)
        Me.cboFloorNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the floor:"
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstData.Location = New System.Drawing.Point(26, 26)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(604, 183)
        Me.lstData.TabIndex = 2
        Me.lstData.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOccupancyRate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblTotalRoomsOccupied)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lstData)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(657, 286)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Floor Occupancy Data"
        '
        'lblOccupancyRate
        '
        Me.lblOccupancyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOccupancyRate.Location = New System.Drawing.Point(507, 244)
        Me.lblOccupancyRate.Name = "lblOccupancyRate"
        Me.lblOccupancyRate.Size = New System.Drawing.Size(69, 22)
        Me.lblOccupancyRate.TabIndex = 8
        Me.lblOccupancyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(298, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Overall Occupancy Rate"
        '
        'lblTotalRoomsOccupied
        '
        Me.lblTotalRoomsOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRoomsOccupied.Location = New System.Drawing.Point(198, 246)
        Me.lblTotalRoomsOccupied.Name = "lblTotalRoomsOccupied"
        Me.lblTotalRoomsOccupied.Size = New System.Drawing.Size(69, 22)
        Me.lblTotalRoomsOccupied.TabIndex = 6
        Me.lblTotalRoomsOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total Rooms Occupied"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(223, 490)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(69, 27)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(381, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(65, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 521)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Hotel Occupancy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstData As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFloorNumber As ComboBox
    Friend WithEvents txtOccupiedRooms As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblOccupancyRate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalRoomsOccupied As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
End Class
