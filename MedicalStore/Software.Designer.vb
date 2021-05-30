<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Software
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
        Dim Item_QtyLabel As System.Windows.Forms.Label
        Dim Item_TypeLabel As System.Windows.Forms.Label
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim ID_Proof_NoLabel As System.Windows.Forms.Label
        Dim Mobile_NoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Item_DescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Software))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillDataDataSet = New WindowsApplication1.BillDataDataSet()
        Me.VendorPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Table1TableAdapter = New WindowsApplication1.BillDataDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BillDataDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.VendorPaymentTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.vendorPaymentTableAdapter()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDProofNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Proof_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Item_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Item_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_QtyTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BillDataDataSet1 = New WindowsApplication1.BillDataDataSet()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Item_QtyLabel = New System.Windows.Forms.Label()
        Item_TypeLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        ID_Proof_NoLabel = New System.Windows.Forms.Label()
        Mobile_NoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Item_DescriptionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.BillDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_QtyLabel
        '
        Item_QtyLabel.AutoSize = True
        Item_QtyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Item_QtyLabel.Location = New System.Drawing.Point(20, 213)
        Item_QtyLabel.Name = "Item_QtyLabel"
        Item_QtyLabel.Size = New System.Drawing.Size(94, 23)
        Item_QtyLabel.TabIndex = 8
        Item_QtyLabel.Text = "Item Qty:"
        '
        'Item_TypeLabel
        '
        Item_TypeLabel.AutoSize = True
        Item_TypeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Item_TypeLabel.Location = New System.Drawing.Point(20, 162)
        Item_TypeLabel.Name = "Item_TypeLabel"
        Item_TypeLabel.Size = New System.Drawing.Size(103, 23)
        Item_TypeLabel.TabIndex = 6
        Item_TypeLabel.Text = "Item Type:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Item_NameLabel.Location = New System.Drawing.Point(20, 120)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(110, 23)
        Item_NameLabel.TabIndex = 4
        Item_NameLabel.Text = "Item Name:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DateLabel.Location = New System.Drawing.Point(20, 68)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(58, 23)
        DateLabel.TabIndex = 2
        DateLabel.Text = "Date:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        IDLabel.Location = New System.Drawing.Point(20, 19)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 23)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'ID_Proof_NoLabel
        '
        ID_Proof_NoLabel.AutoSize = True
        ID_Proof_NoLabel.Location = New System.Drawing.Point(48, 79)
        ID_Proof_NoLabel.Name = "ID_Proof_NoLabel"
        ID_Proof_NoLabel.Size = New System.Drawing.Size(85, 17)
        ID_Proof_NoLabel.TabIndex = 11
        ID_Proof_NoLabel.Text = "ID Proof No:"
        '
        'Mobile_NoLabel
        '
        Mobile_NoLabel.AutoSize = True
        Mobile_NoLabel.Location = New System.Drawing.Point(48, 125)
        Mobile_NoLabel.Name = "Mobile_NoLabel"
        Mobile_NoLabel.Size = New System.Drawing.Size(75, 17)
        Mobile_NoLabel.TabIndex = 13
        Mobile_NoLabel.Text = "Mobile No:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(420, 81)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'Item_DescriptionLabel
        '
        Item_DescriptionLabel.AutoSize = True
        Item_DescriptionLabel.Location = New System.Drawing.Point(420, 163)
        Item_DescriptionLabel.Name = "Item_DescriptionLabel"
        Item_DescriptionLabel.Size = New System.Drawing.Size(113, 17)
        Item_DescriptionLabel.TabIndex = 17
        Item_DescriptionLabel.Text = "Item Description:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 75)
        Me.Panel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(474, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 53)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Medi"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.BillDataDataSet
        '
        'BillDataDataSet
        '
        Me.BillDataDataSet.DataSetName = "BillDataDataSet"
        Me.BillDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorPaymentBindingSource
        '
        Me.VendorPaymentBindingSource.DataMember = "vendorPayment"
        Me.VendorPaymentBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.BillDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.itemMasterTableAdapter = Nothing
        Me.TableAdapterManager1.purchaseMasterTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.vendorPaymentTableAdapter = Me.VendorPaymentTableAdapter
        '
        'VendorPaymentTableAdapter
        '
        Me.VendorPaymentTableAdapter.ClearBeforeFill = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(ID_Proof_NoLabel)
        Me.TabPage2.Controls.Add(Me.ID_Proof_NoTextBox)
        Me.TabPage2.Controls.Add(Mobile_NoLabel)
        Me.TabPage2.Controls.Add(Me.Mobile_NoTextBox)
        Me.TabPage2.Controls.Add(AddressLabel)
        Me.TabPage2.Controls.Add(Me.AddressTextBox)
        Me.TabPage2.Controls.Add(Item_DescriptionLabel)
        Me.TabPage2.Controls.Add(Me.Item_DescriptionTextBox)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(971, 463)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vendor payment master"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProofNoDataGridViewTextBoxColumn, Me.MobileNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.VendorPaymentBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(90, 257)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(640, 200)
        Me.DataGridView2.TabIndex = 19
        '
        'IDProofNoDataGridViewTextBoxColumn
        '
        Me.IDProofNoDataGridViewTextBoxColumn.DataPropertyName = "ID Proof No"
        Me.IDProofNoDataGridViewTextBoxColumn.HeaderText = "ID Proof No"
        Me.IDProofNoDataGridViewTextBoxColumn.Name = "IDProofNoDataGridViewTextBoxColumn"
        '
        'MobileNoDataGridViewTextBoxColumn
        '
        Me.MobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile No"
        Me.MobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No"
        Me.MobileNoDataGridViewTextBoxColumn.Name = "MobileNoDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        '
        'ID_Proof_NoTextBox
        '
        Me.ID_Proof_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorPaymentBindingSource, "ID Proof No", True))
        Me.ID_Proof_NoTextBox.Location = New System.Drawing.Point(167, 76)
        Me.ID_Proof_NoTextBox.Name = "ID_Proof_NoTextBox"
        Me.ID_Proof_NoTextBox.Size = New System.Drawing.Size(175, 22)
        Me.ID_Proof_NoTextBox.TabIndex = 12
        '
        'Mobile_NoTextBox
        '
        Me.Mobile_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorPaymentBindingSource, "Mobile No", True))
        Me.Mobile_NoTextBox.Location = New System.Drawing.Point(167, 120)
        Me.Mobile_NoTextBox.Name = "Mobile_NoTextBox"
        Me.Mobile_NoTextBox.Size = New System.Drawing.Size(175, 22)
        Me.Mobile_NoTextBox.TabIndex = 14
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorPaymentBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(539, 78)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(202, 48)
        Me.AddressTextBox.TabIndex = 16
        '
        'Item_DescriptionTextBox
        '
        Me.Item_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorPaymentBindingSource, "Item Description", True))
        Me.Item_DescriptionTextBox.Location = New System.Drawing.Point(539, 158)
        Me.Item_DescriptionTextBox.Multiline = True
        Me.Item_DescriptionTextBox.Name = "Item_DescriptionTextBox"
        Me.Item_DescriptionTextBox.Size = New System.Drawing.Size(202, 65)
        Me.Item_DescriptionTextBox.TabIndex = 18
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Cyan
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(826, 413)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(139, 44)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "LOG OUT"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(315, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 35)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vendor Payment Master"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(IDLabel)
        Me.TabPage1.Controls.Add(Me.IDTextBox)
        Me.TabPage1.Controls.Add(Me.Item_NameTextBox)
        Me.TabPage1.Controls.Add(Me.Item_TypeTextBox)
        Me.TabPage1.Controls.Add(Me.Item_QtyTextBox)
        Me.TabPage1.Controls.Add(DateLabel)
        Me.TabPage1.Controls.Add(Me.DateDateTimePicker)
        Me.TabPage1.Controls.Add(Item_NameLabel)
        Me.TabPage1.Controls.Add(Item_TypeLabel)
        Me.TabPage1.Controls.Add(Item_QtyLabel)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 463)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Billing Software"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Cyan
        Me.Button4.Location = New System.Drawing.Point(845, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 46)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "LOG OUT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(132, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(275, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 37)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.Location = New System.Drawing.Point(145, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 37)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(17, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemTypeDataGridViewTextBoxColumn, Me.ItemQtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(355, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(620, 265)
        Me.DataGridView1.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'ItemTypeDataGridViewTextBoxColumn
        '
        Me.ItemTypeDataGridViewTextBoxColumn.DataPropertyName = "Item Type"
        Me.ItemTypeDataGridViewTextBoxColumn.HeaderText = "Item Type"
        Me.ItemTypeDataGridViewTextBoxColumn.Name = "ItemTypeDataGridViewTextBoxColumn"
        '
        'ItemQtyDataGridViewTextBoxColumn
        '
        Me.ItemQtyDataGridViewTextBoxColumn.DataPropertyName = "Item Qty"
        Me.ItemQtyDataGridViewTextBoxColumn.HeaderText = "Item Qty"
        Me.ItemQtyDataGridViewTextBoxColumn.Name = "ItemQtyDataGridViewTextBoxColumn"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(136, 19)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 30)
        Me.IDTextBox.TabIndex = 1
        '
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Item Name", True))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(136, 117)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.Size = New System.Drawing.Size(200, 30)
        Me.Item_NameTextBox.TabIndex = 5
        '
        'Item_TypeTextBox
        '
        Me.Item_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Item Type", True))
        Me.Item_TypeTextBox.Location = New System.Drawing.Point(136, 159)
        Me.Item_TypeTextBox.Name = "Item_TypeTextBox"
        Me.Item_TypeTextBox.Size = New System.Drawing.Size(200, 30)
        Me.Item_TypeTextBox.TabIndex = 7
        '
        'Item_QtyTextBox
        '
        Me.Item_QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Item Qty", True))
        Me.Item_QtyTextBox.Location = New System.Drawing.Point(136, 210)
        Me.Item_QtyTextBox.Name = "Item_QtyTextBox"
        Me.Item_QtyTextBox.Size = New System.Drawing.Size(200, 30)
        Me.Item_QtyTextBox.TabIndex = 9
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(136, 64)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 30)
        Me.DateDateTimePicker.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(979, 492)
        Me.TabControl1.TabIndex = 16
        '
        'BillDataDataSet1
        '
        Me.BillDataDataSet1.DataSetName = "BillDataDataSet"
        Me.BillDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(802, 81)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(132, 45)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "ADD NEW"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(802, 156)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 50)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "SAVE"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(802, 233)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 48)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "DELTE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Software
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Software"
        Me.Text = "Software"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.BillDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BillDataDataSet As WindowsApplication1.BillDataDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1.BillDataDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BillDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DatabaseDataSet As WindowsApplication1.DatabaseDataSet
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorPaymentTableAdapter As WindowsApplication1.DatabaseDataSetTableAdapters.vendorPaymentTableAdapter
    Friend WithEvents VendorPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ID_Proof_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IDProofNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDataDataSet1 As WindowsApplication1.BillDataDataSet
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
