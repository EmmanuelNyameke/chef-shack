<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepreciation
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
        lblFoodTruck = New Label()
        mnuFile = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuDisplay = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        picTruck = New PictureBox()
        lblSelectItem = New Label()
        lstInventoryId = New ListBox()
        btnCalculateDepreciation = New Button()
        grpDepreciationType = New GroupBox()
        radDoubleDeclining = New RadioButton()
        radStraightLine = New RadioButton()
        lblItem = New Label()
        lblYear = New Label()
        lblPresentValue = New Label()
        lblYearDepreciation = New Label()
        lblTotalDepreciation = New Label()
        lstYear = New ListBox()
        lstPresentValue = New ListBox()
        lstYearDepreciation = New ListBox()
        lstTotalDepreciation = New ListBox()
        lblQuantity = New Label()
        mnuFile.SuspendLayout()
        CType(picTruck, ComponentModel.ISupportInitialize).BeginInit()
        grpDepreciationType.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFoodTruck
        ' 
        lblFoodTruck.AutoSize = True
        lblFoodTruck.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFoodTruck.ForeColor = Color.OrangeRed
        lblFoodTruck.Location = New Point(247, 29)
        lblFoodTruck.Margin = New Padding(4, 0, 4, 0)
        lblFoodTruck.Name = "lblFoodTruck"
        lblFoodTruck.Size = New Size(416, 31)
        lblFoodTruck.TabIndex = 0
        lblFoodTruck.Text = "Chef Shack Burger Food Truck"
        ' 
        ' mnuFile
        ' 
        mnuFile.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        mnuFile.Location = New Point(0, 0)
        mnuFile.Name = "mnuFile"
        mnuFile.Padding = New Padding(8, 2, 0, 2)
        mnuFile.Size = New Size(684, 24)
        mnuFile.TabIndex = 1
        mnuFile.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDisplay, mnuClear, mnuExit})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuDisplay
        ' 
        mnuDisplay.Name = "mnuDisplay"
        mnuDisplay.Size = New Size(180, 22)
        mnuDisplay.Text = "Display Inventory"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(180, 22)
        mnuClear.Text = "Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "Exit"
        ' 
        ' picTruck
        ' 
        picTruck.Image = My.Resources.Resources.truck
        picTruck.Location = New Point(0, 29)
        picTruck.Margin = New Padding(4, 3, 4, 3)
        picTruck.Name = "picTruck"
        picTruck.Size = New Size(193, 223)
        picTruck.SizeMode = PictureBoxSizeMode.StretchImage
        picTruck.TabIndex = 2
        picTruck.TabStop = False
        ' 
        ' lblSelectItem
        ' 
        lblSelectItem.AutoSize = True
        lblSelectItem.ForeColor = Color.Gray
        lblSelectItem.Location = New Point(232, 72)
        lblSelectItem.Margin = New Padding(4, 0, 4, 0)
        lblSelectItem.Name = "lblSelectItem"
        lblSelectItem.Size = New Size(151, 16)
        lblSelectItem.TabIndex = 3
        lblSelectItem.Text = "Select Inventory Item"
        ' 
        ' lstInventoryId
        ' 
        lstInventoryId.BackColor = Color.WhiteSmoke
        lstInventoryId.ForeColor = Color.Gray
        lstInventoryId.FormattingEnabled = True
        lstInventoryId.Location = New Point(218, 95)
        lstInventoryId.Margin = New Padding(4, 3, 4, 3)
        lstInventoryId.Name = "lstInventoryId"
        lstInventoryId.Size = New Size(183, 84)
        lstInventoryId.TabIndex = 4
        ' 
        ' btnCalculateDepreciation
        ' 
        btnCalculateDepreciation.BackColor = Color.OrangeRed
        btnCalculateDepreciation.ForeColor = Color.White
        btnCalculateDepreciation.Location = New Point(317, 201)
        btnCalculateDepreciation.Margin = New Padding(4, 3, 4, 3)
        btnCalculateDepreciation.Name = "btnCalculateDepreciation"
        btnCalculateDepreciation.Size = New Size(207, 42)
        btnCalculateDepreciation.TabIndex = 5
        btnCalculateDepreciation.Text = "Calculate Depreciation"
        btnCalculateDepreciation.UseVisualStyleBackColor = False
        ' 
        ' grpDepreciationType
        ' 
        grpDepreciationType.Controls.Add(radDoubleDeclining)
        grpDepreciationType.Controls.Add(radStraightLine)
        grpDepreciationType.ForeColor = Color.Gray
        grpDepreciationType.Location = New Point(409, 72)
        grpDepreciationType.Margin = New Padding(4, 3, 4, 3)
        grpDepreciationType.Name = "grpDepreciationType"
        grpDepreciationType.Padding = New Padding(4, 3, 4, 3)
        grpDepreciationType.Size = New Size(257, 107)
        grpDepreciationType.TabIndex = 6
        grpDepreciationType.TabStop = False
        grpDepreciationType.Text = "Select Depreciation Method"
        ' 
        ' radDoubleDeclining
        ' 
        radDoubleDeclining.AutoSize = True
        radDoubleDeclining.Location = New Point(35, 80)
        radDoubleDeclining.Margin = New Padding(4, 3, 4, 3)
        radDoubleDeclining.Name = "radDoubleDeclining"
        radDoubleDeclining.Size = New Size(206, 20)
        radDoubleDeclining.TabIndex = 1
        radDoubleDeclining.TabStop = True
        radDoubleDeclining.Text = "Double-Declining Balance"
        radDoubleDeclining.UseVisualStyleBackColor = True
        ' 
        ' radStraightLine
        ' 
        radStraightLine.AutoSize = True
        radStraightLine.Location = New Point(35, 32)
        radStraightLine.Margin = New Padding(4, 3, 4, 3)
        radStraightLine.Name = "radStraightLine"
        radStraightLine.Size = New Size(112, 20)
        radStraightLine.TabIndex = 0
        radStraightLine.TabStop = True
        radStraightLine.Text = "Straight-Line"
        radStraightLine.UseVisualStyleBackColor = True
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.ForeColor = Color.Gray
        lblItem.Location = New Point(218, 260)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(277, 16)
        lblItem.TabIndex = 7
        lblItem.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        lblItem.Visible = False
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.ForeColor = Color.Gray
        lblYear.Location = New Point(70, 311)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(64, 32)
        lblYear.TabIndex = 8
        lblYear.Text = "Present " & vbCrLf & "Year"
        lblYear.Visible = False
        ' 
        ' lblPresentValue
        ' 
        lblPresentValue.AutoSize = True
        lblPresentValue.ForeColor = Color.Gray
        lblPresentValue.Location = New Point(235, 311)
        lblPresentValue.Name = "lblPresentValue"
        lblPresentValue.Size = New Size(60, 32)
        lblPresentValue.TabIndex = 9
        lblPresentValue.Text = "Present" & vbCrLf & "Value"
        lblPresentValue.Visible = False
        ' 
        ' lblYearDepreciation
        ' 
        lblYearDepreciation.AutoSize = True
        lblYearDepreciation.ForeColor = Color.Gray
        lblYearDepreciation.Location = New Point(382, 311)
        lblYearDepreciation.Name = "lblYearDepreciation"
        lblYearDepreciation.Size = New Size(96, 32)
        lblYearDepreciation.TabIndex = 10
        lblYearDepreciation.Text = "Year" & vbCrLf & "Depreciation"
        lblYearDepreciation.Visible = False
        ' 
        ' lblTotalDepreciation
        ' 
        lblTotalDepreciation.AutoSize = True
        lblTotalDepreciation.ForeColor = Color.Gray
        lblTotalDepreciation.Location = New Point(518, 311)
        lblTotalDepreciation.Name = "lblTotalDepreciation"
        lblTotalDepreciation.Size = New Size(96, 32)
        lblTotalDepreciation.TabIndex = 11
        lblTotalDepreciation.Text = "Total" & vbCrLf & "Depreciation"
        lblTotalDepreciation.Visible = False
        ' 
        ' lstYear
        ' 
        lstYear.ForeColor = Color.Gray
        lstYear.FormattingEnabled = True
        lstYear.Location = New Point(70, 347)
        lstYear.Name = "lstYear"
        lstYear.Size = New Size(88, 84)
        lstYear.TabIndex = 12
        lstYear.Visible = False
        ' 
        ' lstPresentValue
        ' 
        lstPresentValue.ForeColor = Color.Gray
        lstPresentValue.FormattingEnabled = True
        lstPresentValue.Location = New Point(235, 347)
        lstPresentValue.Name = "lstPresentValue"
        lstPresentValue.Size = New Size(88, 84)
        lstPresentValue.TabIndex = 13
        lstPresentValue.Visible = False
        ' 
        ' lstYearDepreciation
        ' 
        lstYearDepreciation.ForeColor = Color.Gray
        lstYearDepreciation.FormattingEnabled = True
        lstYearDepreciation.Location = New Point(382, 347)
        lstYearDepreciation.Name = "lstYearDepreciation"
        lstYearDepreciation.Size = New Size(88, 84)
        lstYearDepreciation.TabIndex = 14
        lstYearDepreciation.Visible = False
        ' 
        ' lstTotalDepreciation
        ' 
        lstTotalDepreciation.ForeColor = Color.Gray
        lstTotalDepreciation.FormattingEnabled = True
        lstTotalDepreciation.Location = New Point(518, 347)
        lstTotalDepreciation.Name = "lstTotalDepreciation"
        lstTotalDepreciation.Size = New Size(88, 84)
        lstTotalDepreciation.TabIndex = 15
        lstTotalDepreciation.Visible = False
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.ForeColor = Color.Gray
        lblQuantity.Location = New Point(379, 285)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(88, 16)
        lblQuantity.TabIndex = 16
        lblQuantity.Text = "XXXXXXXXX"
        lblQuantity.Visible = False
        ' 
        ' frmDepreciation
        ' 
        AcceptButton = btnCalculateDepreciation
        AutoScaleDimensions = New SizeF(9F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(684, 431)
        Controls.Add(lblQuantity)
        Controls.Add(lstTotalDepreciation)
        Controls.Add(lstYearDepreciation)
        Controls.Add(lstPresentValue)
        Controls.Add(lstYear)
        Controls.Add(lblTotalDepreciation)
        Controls.Add(lblYearDepreciation)
        Controls.Add(lblPresentValue)
        Controls.Add(lblYear)
        Controls.Add(lblItem)
        Controls.Add(grpDepreciationType)
        Controls.Add(btnCalculateDepreciation)
        Controls.Add(lstInventoryId)
        Controls.Add(lblSelectItem)
        Controls.Add(picTruck)
        Controls.Add(lblFoodTruck)
        Controls.Add(mnuFile)
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = mnuFile
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmDepreciation"
        Text = "Compute Depreciation By Method "
        mnuFile.ResumeLayout(False)
        mnuFile.PerformLayout()
        CType(picTruck, ComponentModel.ISupportInitialize).EndInit()
        grpDepreciationType.ResumeLayout(False)
        grpDepreciationType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFoodTruck As Label
    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lblSelectItem As Label
    Friend WithEvents lstInventoryId As ListBox
    Friend WithEvents btnCalculateDepreciation As Button
    Friend WithEvents grpDepreciationType As GroupBox
    Friend WithEvents radDoubleDeclining As RadioButton
    Friend WithEvents radStraightLine As RadioButton
    Friend WithEvents lblItem As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPresentValue As Label
    Friend WithEvents lblYearDepreciation As Label
    Friend WithEvents lblTotalDepreciation As Label
    Friend WithEvents lstYear As ListBox
    Friend WithEvents lstPresentValue As ListBox
    Friend WithEvents lstYearDepreciation As ListBox
    Friend WithEvents lstTotalDepreciation As ListBox
    Friend WithEvents lblQuantity As Label

End Class
