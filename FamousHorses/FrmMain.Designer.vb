<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim HorseLabel As System.Windows.Forms.Label
        Dim RiderLabel As System.Windows.Forms.Label
        Dim SeriesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim LblLookup As System.Windows.Forms.Label
        Me.LblMain = New System.Windows.Forms.Label()
        Me.HorsesDataSet = New FamousHorses.horsesDataSet()
        Me.TblHorsesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblHorsesTableAdapter = New FamousHorses.horsesDataSetTableAdapters.tblHorsesTableAdapter()
        Me.TableAdapterManager = New FamousHorses.horsesDataSetTableAdapters.TableAdapterManager()
        Me.HorseTextBox = New System.Windows.Forms.TextBox()
        Me.RiderTextBox = New System.Windows.Forms.TextBox()
        Me.SeriesTextBox = New System.Windows.Forms.TextBox()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.PrtDocument = New System.Drawing.Printing.PrintDocument()
        Me.PpdPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.BtnDeleteAll = New System.Windows.Forms.Button()
        Me.TxtLookup = New System.Windows.Forms.TextBox()
        Me.BtnLookup = New System.Windows.Forms.Button()
        HorseLabel = New System.Windows.Forms.Label()
        RiderLabel = New System.Windows.Forms.Label()
        SeriesLabel = New System.Windows.Forms.Label()
        LblLookup = New System.Windows.Forms.Label()
        CType(Me.HorsesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblHorsesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HorseLabel
        '
        HorseLabel.AutoSize = True
        HorseLabel.Location = New System.Drawing.Point(371, 180)
        HorseLabel.Name = "HorseLabel"
        HorseLabel.Size = New System.Drawing.Size(38, 13)
        HorseLabel.TabIndex = 10
        HorseLabel.Text = "Horse:"
        '
        'RiderLabel
        '
        RiderLabel.AutoSize = True
        RiderLabel.Location = New System.Drawing.Point(371, 206)
        RiderLabel.Name = "RiderLabel"
        RiderLabel.Size = New System.Drawing.Size(35, 13)
        RiderLabel.TabIndex = 12
        RiderLabel.Text = "Rider:"
        '
        'SeriesLabel
        '
        SeriesLabel.AutoSize = True
        SeriesLabel.Location = New System.Drawing.Point(371, 232)
        SeriesLabel.Name = "SeriesLabel"
        SeriesLabel.Size = New System.Drawing.Size(39, 13)
        SeriesLabel.TabIndex = 14
        SeriesLabel.Text = "Series:"
        '
        'LblMain
        '
        Me.LblMain.BackColor = System.Drawing.Color.PaleGreen
        Me.LblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMain.Location = New System.Drawing.Point(266, 75)
        Me.LblMain.Name = "LblMain"
        Me.LblMain.Size = New System.Drawing.Size(345, 53)
        Me.LblMain.TabIndex = 9
        Me.LblMain.Text = "Famous Horses"
        Me.LblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HorsesDataSet
        '
        Me.HorsesDataSet.DataSetName = "horsesDataSet"
        Me.HorsesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblHorsesBindingSource
        '
        Me.TblHorsesBindingSource.DataMember = "tblHorses"
        Me.TblHorsesBindingSource.DataSource = Me.HorsesDataSet
        '
        'TblHorsesTableAdapter
        '
        Me.TblHorsesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblHorsesTableAdapter = Me.TblHorsesTableAdapter
        Me.TableAdapterManager.UpdateOrder = FamousHorses.horsesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HorseTextBox
        '
        Me.HorseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHorsesBindingSource, "Horse", True))
        Me.HorseTextBox.Location = New System.Drawing.Point(416, 177)
        Me.HorseTextBox.MaxLength = 10
        Me.HorseTextBox.Name = "HorseTextBox"
        Me.HorseTextBox.ReadOnly = True
        Me.HorseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HorseTextBox.TabIndex = 11
        '
        'RiderTextBox
        '
        Me.RiderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHorsesBindingSource, "Rider", True))
        Me.RiderTextBox.Location = New System.Drawing.Point(416, 203)
        Me.RiderTextBox.MaxLength = 20
        Me.RiderTextBox.Name = "RiderTextBox"
        Me.RiderTextBox.ReadOnly = True
        Me.RiderTextBox.Size = New System.Drawing.Size(159, 20)
        Me.RiderTextBox.TabIndex = 13
        '
        'SeriesTextBox
        '
        Me.SeriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHorsesBindingSource, "Series", True))
        Me.SeriesTextBox.Location = New System.Drawing.Point(416, 229)
        Me.SeriesTextBox.MaxLength = 25
        Me.SeriesTextBox.Name = "SeriesTextBox"
        Me.SeriesTextBox.ReadOnly = True
        Me.SeriesTextBox.Size = New System.Drawing.Size(182, 20)
        Me.SeriesTextBox.TabIndex = 15
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFirst.Image = Global.FamousHorses.My.Resources.Resources.First
        Me.BtnFirst.Location = New System.Drawing.Point(369, 267)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(43, 23)
        Me.BtnFirst.TabIndex = 19
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLast.Image = Global.FamousHorses.My.Resources.Resources.Last
        Me.BtnLast.Location = New System.Drawing.Point(558, 267)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(43, 23)
        Me.BtnLast.TabIndex = 18
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrevious.Image = Global.FamousHorses.My.Resources.Resources.Previous
        Me.BtnPrevious.Location = New System.Drawing.Point(432, 267)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(43, 23)
        Me.BtnPrevious.TabIndex = 17
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNext.Image = Global.FamousHorses.My.Resources.Resources._Next
        Me.BtnNext.Location = New System.Drawing.Point(495, 267)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(43, 23)
        Me.BtnNext.TabIndex = 16
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAdd.Location = New System.Drawing.Point(167, 158)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(70, 34)
        Me.BtnAdd.TabIndex = 20
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(693, 158)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(70, 34)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.Location = New System.Drawing.Point(167, 364)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(70, 34)
        Me.BtnPrint.TabIndex = 22
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(167, 266)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(70, 34)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEdit.Location = New System.Drawing.Point(167, 212)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(70, 34)
        Me.BtnEdit.TabIndex = 24
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'PrtDocument
        '
        '
        'PpdPreview
        '
        Me.PpdPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PpdPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PpdPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.PpdPreview.Enabled = True
        Me.PpdPreview.Icon = CType(resources.GetObject("PpdPreview.Icon"), System.Drawing.Icon)
        Me.PpdPreview.Name = "PpdPreview"
        Me.PpdPreview.Visible = False
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDeleteAll.Location = New System.Drawing.Point(693, 221)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(70, 34)
        Me.BtnDeleteAll.TabIndex = 25
        Me.BtnDeleteAll.Text = "Delete All"
        Me.BtnDeleteAll.UseVisualStyleBackColor = False
        '
        'TxtLookup
        '
        Me.TxtLookup.Location = New System.Drawing.Point(416, 326)
        Me.TxtLookup.Name = "TxtLookup"
        Me.TxtLookup.Size = New System.Drawing.Size(100, 20)
        Me.TxtLookup.TabIndex = 26
        '
        'BtnLookup
        '
        Me.BtnLookup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLookup.Location = New System.Drawing.Point(541, 318)
        Me.BtnLookup.Name = "BtnLookup"
        Me.BtnLookup.Size = New System.Drawing.Size(70, 34)
        Me.BtnLookup.TabIndex = 27
        Me.BtnLookup.Text = "Lookup"
        Me.BtnLookup.UseVisualStyleBackColor = False
        '
        'LblLookup
        '
        LblLookup.AutoSize = True
        LblLookup.Location = New System.Drawing.Point(299, 329)
        LblLookup.Name = "LblLookup"
        LblLookup.Size = New System.Drawing.Size(107, 13)
        LblLookup.TabIndex = 28
        LblLookup.Text = "Enter A Horse Name:"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 528)
        Me.Controls.Add(LblLookup)
        Me.Controls.Add(Me.BtnLookup)
        Me.Controls.Add(Me.TxtLookup)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(HorseLabel)
        Me.Controls.Add(Me.HorseTextBox)
        Me.Controls.Add(RiderLabel)
        Me.Controls.Add(Me.RiderTextBox)
        Me.Controls.Add(SeriesLabel)
        Me.Controls.Add(Me.SeriesTextBox)
        Me.Controls.Add(Me.LblMain)
        Me.Name = "FrmMain"
        Me.Text = "Famours Horses"
        CType(Me.HorsesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblHorsesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMain As Label
    Friend WithEvents HorsesDataSet As horsesDataSet
    Friend WithEvents TblHorsesBindingSource As BindingSource
    Friend WithEvents TblHorsesTableAdapter As horsesDataSetTableAdapters.tblHorsesTableAdapter
    Friend WithEvents TableAdapterManager As horsesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HorseTextBox As TextBox
    Friend WithEvents RiderTextBox As TextBox
    Friend WithEvents SeriesTextBox As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents PrtDocument As Printing.PrintDocument
    Friend WithEvents PpdPreview As PrintPreviewDialog
    Friend WithEvents BtnDeleteAll As Button
    Friend WithEvents TxtLookup As TextBox
    Friend WithEvents BtnLookup As Button
End Class
