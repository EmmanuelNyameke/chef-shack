<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        lblTitle = New Label()
        picTruck = New PictureBox()
        lstDisplay = New ListBox()
        btnReturn = New Button()
        CType(picTruck, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.OrangeRed
        lblTitle.Location = New Point(122, 43)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Chef Shack Inventory"
        ' 
        ' picTruck
        ' 
        picTruck.Image = My.Resources.Resources.truck
        picTruck.Location = New Point(24, 29)
        picTruck.Name = "picTruck"
        picTruck.Size = New Size(79, 59)
        picTruck.SizeMode = PictureBoxSizeMode.StretchImage
        picTruck.TabIndex = 1
        picTruck.TabStop = False
        ' 
        ' lstDisplay
        ' 
        lstDisplay.BackColor = Color.WhiteSmoke
        lstDisplay.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstDisplay.ForeColor = Color.Gray
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 20
        lstDisplay.Location = New Point(72, 112)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(226, 184)
        lstDisplay.TabIndex = 2
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.OrangeRed
        btnReturn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(83, 324)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(204, 44)
        btnReturn.TabIndex = 3
        btnReturn.Text = "Return to Application"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' frmDisplayInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(371, 380)
        Controls.Add(btnReturn)
        Controls.Add(lstDisplay)
        Controls.Add(picTruck)
        Controls.Add(lblTitle)
        Name = "frmDisplayInventory"
        Text = "Sorted Inventory Listing"
        CType(picTruck, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picTruck As PictureBox
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnReturn As Button
End Class
