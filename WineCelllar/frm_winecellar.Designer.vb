<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_winecellar
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim CellarLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim CellarAreaLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim WineLabel As System.Windows.Forms.Label
        Dim VintageLabel As System.Windows.Forms.Label
        Dim Ws_priceLabel As System.Windows.Forms.Label
        Dim Purchase_avgLabel As System.Windows.Forms.Label
        Dim UrlLabel As System.Windows.Forms.Label
        Dim WineVintageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_winecellar))
        Me.Ds_winecellar = New WineCelllar.ds_winecellar()
        Me.Tb_winecellarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_winecellarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_winecellarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_winecellarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tb_wineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_wine = New WineCelllar.ds_wine()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tb_cellarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_cellar = New WineCelllar.ds_cellar()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wine = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.CellarTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.CellarAreaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.WineTextBox = New System.Windows.Forms.TextBox()
        Me.VintageTextBox = New System.Windows.Forms.TextBox()
        Me.Ws_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_avgTextBox = New System.Windows.Forms.TextBox()
        Me.UrlTextBox = New System.Windows.Forms.TextBox()
        Me.WineVintageTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_wineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.Tb_cellarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        CellarLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        CellarAreaLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        WineLabel = New System.Windows.Forms.Label()
        VintageLabel = New System.Windows.Forms.Label()
        Ws_priceLabel = New System.Windows.Forms.Label()
        Purchase_avgLabel = New System.Windows.Forms.Label()
        UrlLabel = New System.Windows.Forms.Label()
        WineVintageLabel = New System.Windows.Forms.Label()
        CType(Me.Ds_winecellar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_winecellarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_winecellarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_winecellarBindingNavigator.SuspendLayout()
        CType(Me.Tb_winecellarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_wineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_wine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_cellarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_cellar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Wine.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Tb_wineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_wineBindingNavigator.SuspendLayout()
        CType(Me.Tb_cellarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_cellarBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(35, 13)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 12)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'CellarLabel
        '
        CellarLabel.AutoSize = True
        CellarLabel.Location = New System.Drawing.Point(35, 40)
        CellarLabel.Name = "CellarLabel"
        CellarLabel.Size = New System.Drawing.Size(47, 12)
        CellarLabel.TabIndex = 2
        CellarLabel.Text = "cellar:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(35, 67)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(35, 12)
        AreaLabel.TabIndex = 4
        AreaLabel.Text = "area:"
        '
        'CellarAreaLabel
        '
        CellarAreaLabel.AutoSize = True
        CellarAreaLabel.Location = New System.Drawing.Point(35, 94)
        CellarAreaLabel.Name = "CellarAreaLabel"
        CellarAreaLabel.Size = New System.Drawing.Size(77, 12)
        CellarAreaLabel.TabIndex = 6
        CellarAreaLabel.Text = "cellar Area:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(35, 7)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(23, 12)
        IdLabel1.TabIndex = 0
        IdLabel1.Text = "id:"
        IdLabel1.Visible = False
        '
        'WineLabel
        '
        WineLabel.AutoSize = True
        WineLabel.Location = New System.Drawing.Point(35, 34)
        WineLabel.Name = "WineLabel"
        WineLabel.Size = New System.Drawing.Size(35, 12)
        WineLabel.TabIndex = 2
        WineLabel.Text = "wine:"
        '
        'VintageLabel
        '
        VintageLabel.AutoSize = True
        VintageLabel.Location = New System.Drawing.Point(35, 61)
        VintageLabel.Name = "VintageLabel"
        VintageLabel.Size = New System.Drawing.Size(53, 12)
        VintageLabel.TabIndex = 4
        VintageLabel.Text = "vintage:"
        '
        'Ws_priceLabel
        '
        Ws_priceLabel.AutoSize = True
        Ws_priceLabel.Location = New System.Drawing.Point(35, 88)
        Ws_priceLabel.Name = "Ws_priceLabel"
        Ws_priceLabel.Size = New System.Drawing.Size(59, 12)
        Ws_priceLabel.TabIndex = 6
        Ws_priceLabel.Text = "ws price:"
        '
        'Purchase_avgLabel
        '
        Purchase_avgLabel.AutoSize = True
        Purchase_avgLabel.Location = New System.Drawing.Point(35, 115)
        Purchase_avgLabel.Name = "Purchase_avgLabel"
        Purchase_avgLabel.Size = New System.Drawing.Size(83, 12)
        Purchase_avgLabel.TabIndex = 8
        Purchase_avgLabel.Text = "purchase avg:"
        '
        'UrlLabel
        '
        UrlLabel.AutoSize = True
        UrlLabel.Location = New System.Drawing.Point(35, 142)
        UrlLabel.Name = "UrlLabel"
        UrlLabel.Size = New System.Drawing.Size(29, 12)
        UrlLabel.TabIndex = 10
        UrlLabel.Text = "url:"
        '
        'WineVintageLabel
        '
        WineVintageLabel.AutoSize = True
        WineVintageLabel.Location = New System.Drawing.Point(35, 169)
        WineVintageLabel.Name = "WineVintageLabel"
        WineVintageLabel.Size = New System.Drawing.Size(83, 12)
        WineVintageLabel.TabIndex = 12
        WineVintageLabel.Text = "wine Vintage:"
        '
        'Ds_winecellar
        '
        Me.Ds_winecellar.DataSetName = "ds_winecellar"
        Me.Ds_winecellar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_winecellarBindingSource
        '
        Me.Tb_winecellarBindingSource.DataMember = "tb_winecellar"
        Me.Tb_winecellarBindingSource.DataSource = Me.Ds_winecellar
        '
        'Tb_winecellarBindingNavigator
        '
        Me.Tb_winecellarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_winecellarBindingNavigator.BindingSource = Me.Tb_winecellarBindingSource
        Me.Tb_winecellarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_winecellarBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_winecellarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_winecellarBindingNavigatorSaveItem})
        Me.Tb_winecellarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_winecellarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_winecellarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_winecellarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_winecellarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_winecellarBindingNavigator.Name = "Tb_winecellarBindingNavigator"
        Me.Tb_winecellarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_winecellarBindingNavigator.Size = New System.Drawing.Size(1098, 25)
        Me.Tb_winecellarBindingNavigator.TabIndex = 2
        Me.Tb_winecellarBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(39, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_winecellarBindingNavigatorSaveItem
        '
        Me.Tb_winecellarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_winecellarBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_winecellarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_winecellarBindingNavigatorSaveItem.Name = "Tb_winecellarBindingNavigatorSaveItem"
        Me.Tb_winecellarBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_winecellarBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_winecellarDataGridView
        '
        Me.Tb_winecellarDataGridView.AutoGenerateColumns = False
        Me.Tb_winecellarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_winecellarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Tb_winecellarDataGridView.DataSource = Me.Tb_winecellarBindingSource
        Me.Tb_winecellarDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Tb_winecellarDataGridView.Name = "Tb_winecellarDataGridView"
        Me.Tb_winecellarDataGridView.RowTemplate.Height = 23
        Me.Tb_winecellarDataGridView.Size = New System.Drawing.Size(841, 470)
        Me.Tb_winecellarDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "wine_id"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.Tb_wineBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "wineVintage"
        Me.DataGridViewTextBoxColumn2.HeaderText = "wine_id"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "id"
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'Tb_wineBindingSource
        '
        Me.Tb_wineBindingSource.DataMember = "tb_wine"
        Me.Tb_wineBindingSource.DataSource = Me.Ds_wine
        '
        'Ds_wine
        '
        Me.Ds_wine.DataSetName = "ds_wine"
        Me.Ds_wine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cellar_id"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tb_cellarBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "cellarArea"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cellar_id"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'Tb_cellarBindingSource
        '
        Me.Tb_cellarBindingSource.DataMember = "tb_cellar"
        Me.Tb_cellarBindingSource.DataSource = Me.Ds_cellar
        '
        'Ds_cellar
        '
        Me.Ds_cellar.DataSetName = "ds_cellar"
        Me.Ds_cellar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Wine
        '
        Me.Wine.Controls.Add(Me.TabPage2)
        Me.Wine.Controls.Add(Me.TabPage3)
        Me.Wine.ItemSize = New System.Drawing.Size(48, 16)
        Me.Wine.Location = New System.Drawing.Point(13, 500)
        Me.Wine.Name = "Wine"
        Me.Wine.SelectedIndex = 0
        Me.Wine.Size = New System.Drawing.Size(850, 230)
        Me.Wine.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Tb_cellarBindingNavigator)
        Me.TabPage2.Controls.Add(IdLabel)
        Me.TabPage2.Controls.Add(Me.IdTextBox)
        Me.TabPage2.Controls.Add(CellarLabel)
        Me.TabPage2.Controls.Add(Me.CellarTextBox)
        Me.TabPage2.Controls.Add(AreaLabel)
        Me.TabPage2.Controls.Add(Me.AreaTextBox)
        Me.TabPage2.Controls.Add(CellarAreaLabel)
        Me.TabPage2.Controls.Add(Me.CellarAreaTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 20)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cellar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cellarBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(124, 10)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(500, 21)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.Visible = False
        '
        'CellarTextBox
        '
        Me.CellarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cellarBindingSource, "cellar", True))
        Me.CellarTextBox.Location = New System.Drawing.Point(124, 37)
        Me.CellarTextBox.Name = "CellarTextBox"
        Me.CellarTextBox.Size = New System.Drawing.Size(500, 21)
        Me.CellarTextBox.TabIndex = 3
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cellarBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(124, 64)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(500, 21)
        Me.AreaTextBox.TabIndex = 5
        '
        'CellarAreaTextBox
        '
        Me.CellarAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_cellarBindingSource, "cellarArea", True))
        Me.CellarAreaTextBox.Enabled = False
        Me.CellarAreaTextBox.Location = New System.Drawing.Point(124, 91)
        Me.CellarAreaTextBox.Name = "CellarAreaTextBox"
        Me.CellarAreaTextBox.Size = New System.Drawing.Size(500, 21)
        Me.CellarAreaTextBox.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Tb_wineBindingNavigator)
        Me.TabPage3.Controls.Add(IdLabel1)
        Me.TabPage3.Controls.Add(Me.IdTextBox1)
        Me.TabPage3.Controls.Add(WineLabel)
        Me.TabPage3.Controls.Add(Me.WineTextBox)
        Me.TabPage3.Controls.Add(VintageLabel)
        Me.TabPage3.Controls.Add(Me.VintageTextBox)
        Me.TabPage3.Controls.Add(Ws_priceLabel)
        Me.TabPage3.Controls.Add(Me.Ws_priceTextBox)
        Me.TabPage3.Controls.Add(Purchase_avgLabel)
        Me.TabPage3.Controls.Add(Me.Purchase_avgTextBox)
        Me.TabPage3.Controls.Add(UrlLabel)
        Me.TabPage3.Controls.Add(Me.UrlTextBox)
        Me.TabPage3.Controls.Add(WineVintageLabel)
        Me.TabPage3.Controls.Add(Me.WineVintageTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 20)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(842, 206)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Wine"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(124, 4)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(500, 21)
        Me.IdTextBox1.TabIndex = 1
        Me.IdTextBox1.Visible = False
        '
        'WineTextBox
        '
        Me.WineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "wine", True))
        Me.WineTextBox.Location = New System.Drawing.Point(124, 31)
        Me.WineTextBox.Name = "WineTextBox"
        Me.WineTextBox.Size = New System.Drawing.Size(500, 21)
        Me.WineTextBox.TabIndex = 3
        '
        'VintageTextBox
        '
        Me.VintageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "vintage", True))
        Me.VintageTextBox.Location = New System.Drawing.Point(124, 58)
        Me.VintageTextBox.Name = "VintageTextBox"
        Me.VintageTextBox.Size = New System.Drawing.Size(500, 21)
        Me.VintageTextBox.TabIndex = 5
        '
        'Ws_priceTextBox
        '
        Me.Ws_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "ws price", True))
        Me.Ws_priceTextBox.Location = New System.Drawing.Point(124, 85)
        Me.Ws_priceTextBox.Name = "Ws_priceTextBox"
        Me.Ws_priceTextBox.Size = New System.Drawing.Size(500, 21)
        Me.Ws_priceTextBox.TabIndex = 7
        '
        'Purchase_avgTextBox
        '
        Me.Purchase_avgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "purchase avg", True))
        Me.Purchase_avgTextBox.Location = New System.Drawing.Point(124, 112)
        Me.Purchase_avgTextBox.Name = "Purchase_avgTextBox"
        Me.Purchase_avgTextBox.Size = New System.Drawing.Size(500, 21)
        Me.Purchase_avgTextBox.TabIndex = 9
        '
        'UrlTextBox
        '
        Me.UrlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "url", True))
        Me.UrlTextBox.Location = New System.Drawing.Point(124, 139)
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(500, 21)
        Me.UrlTextBox.TabIndex = 11
        '
        'WineVintageTextBox
        '
        Me.WineVintageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_wineBindingSource, "wineVintage", True))
        Me.WineVintageTextBox.Enabled = False
        Me.WineVintageTextBox.Location = New System.Drawing.Point(124, 166)
        Me.WineVintageTextBox.Name = "WineVintageTextBox"
        Me.WineVintageTextBox.Size = New System.Drawing.Size(500, 21)
        Me.WineVintageTextBox.TabIndex = 13
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "url"
        Me.DataGridViewTextBoxColumn10.HeaderText = "url"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "purchase avg"
        Me.DataGridViewTextBoxColumn9.HeaderText = "purchase avg"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ws price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ws price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vintage"
        Me.DataGridViewTextBoxColumn7.HeaderText = "vintage"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "wine"
        Me.DataGridViewTextBoxColumn6.HeaderText = "wine"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Tb_wineBindingNavigator
        '
        Me.Tb_wineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.Tb_wineBindingNavigator.BindingSource = Me.Tb_wineBindingSource
        Me.Tb_wineBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.Tb_wineBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.Tb_wineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.Tb_wineBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.Tb_wineBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.Tb_wineBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.Tb_wineBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.Tb_wineBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.Tb_wineBindingNavigator.Name = "Tb_wineBindingNavigator"
        Me.Tb_wineBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.Tb_wineBindingNavigator.Size = New System.Drawing.Size(836, 25)
        Me.Tb_wineBindingNavigator.TabIndex = 14
        Me.Tb_wineBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(39, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'Tb_cellarBindingNavigator
        '
        Me.Tb_cellarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.Tb_cellarBindingNavigator.BindingSource = Me.Tb_cellarBindingSource
        Me.Tb_cellarBindingNavigator.CountItem = Me.BindingNavigatorCountItem2
        Me.Tb_cellarBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.Tb_cellarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2})
        Me.Tb_cellarBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.Tb_cellarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.Tb_cellarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.Tb_cellarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.Tb_cellarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.Tb_cellarBindingNavigator.Name = "Tb_cellarBindingNavigator"
        Me.Tb_cellarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem2
        Me.Tb_cellarBindingNavigator.Size = New System.Drawing.Size(836, 25)
        Me.Tb_cellarBindingNavigator.TabIndex = 8
        Me.Tb_cellarBindingNavigator.Text = "BindingNavigator2"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(39, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'frm_winecellar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1098, 741)
        Me.Controls.Add(Me.Wine)
        Me.Controls.Add(Me.Tb_winecellarDataGridView)
        Me.Controls.Add(Me.Tb_winecellarBindingNavigator)
        Me.Name = "frm_winecellar"
        Me.Text = "frm_winecella"
        CType(Me.Ds_winecellar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_winecellarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_winecellarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_winecellarBindingNavigator.ResumeLayout(False)
        Me.Tb_winecellarBindingNavigator.PerformLayout()
        CType(Me.Tb_winecellarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_wineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_wine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_cellarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_cellar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Wine.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Tb_wineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_wineBindingNavigator.ResumeLayout(False)
        Me.Tb_wineBindingNavigator.PerformLayout()
        CType(Me.Tb_cellarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_cellarBindingNavigator.ResumeLayout(False)
        Me.Tb_cellarBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ds_winecellar As ds_winecellar
    Friend WithEvents Tb_winecellarBindingSource As BindingSource
    Friend WithEvents Tb_winecellarBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tb_winecellarBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tb_winecellarDataGridView As DataGridView
    Friend WithEvents Ds_wine As ds_wine
    Friend WithEvents Tb_wineBindingSource As BindingSource
    Friend WithEvents Ds_cellar As ds_cellar
    Friend WithEvents Tb_cellarBindingSource As BindingSource
    Friend WithEvents Wine As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CellarTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents CellarAreaTextBox As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents WineTextBox As TextBox
    Friend WithEvents VintageTextBox As TextBox
    Friend WithEvents Ws_priceTextBox As TextBox
    Friend WithEvents Purchase_avgTextBox As TextBox
    Friend WithEvents UrlTextBox As TextBox
    Friend WithEvents WineVintageTextBox As TextBox
    Friend WithEvents Tb_cellarBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents Tb_wineBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
End Class
