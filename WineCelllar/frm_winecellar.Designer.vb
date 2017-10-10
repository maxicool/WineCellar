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
        Me.Tb_wineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_wine = New WineCelllar.ds_wine()
        Me.Tb_cellarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_cellar = New WineCelllar.ds_cellar()
        Me.Wine = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tb_wineDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tb_cellarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPage1.SuspendLayout()
        CType(Me.Tb_wineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Tb_cellarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Tb_winecellarBindingNavigator.Size = New System.Drawing.Size(391, 25)
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
        Me.Tb_winecellarDataGridView.Size = New System.Drawing.Size(362, 169)
        Me.Tb_winecellarDataGridView.TabIndex = 3
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
        'Wine
        '
        Me.Wine.Controls.Add(Me.TabPage1)
        Me.Wine.Controls.Add(Me.TabPage2)
        Me.Wine.Location = New System.Drawing.Point(13, 204)
        Me.Wine.Name = "Wine"
        Me.Wine.SelectedIndex = 0
        Me.Wine.Size = New System.Drawing.Size(361, 163)
        Me.Wine.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Tb_wineDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(353, 137)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Wine"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Tb_wineDataGridView
        '
        Me.Tb_wineDataGridView.AutoGenerateColumns = False
        Me.Tb_wineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_wineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Tb_wineDataGridView.DataSource = Me.Tb_wineBindingSource
        Me.Tb_wineDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.Tb_wineDataGridView.Name = "Tb_wineDataGridView"
        Me.Tb_wineDataGridView.RowTemplate.Height = 23
        Me.Tb_wineDataGridView.Size = New System.Drawing.Size(330, 220)
        Me.Tb_wineDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "wine"
        Me.DataGridViewTextBoxColumn6.HeaderText = "wine"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vintage"
        Me.DataGridViewTextBoxColumn7.HeaderText = "vintage"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ws price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ws price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "purchase avg"
        Me.DataGridViewTextBoxColumn9.HeaderText = "purchase avg"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "url"
        Me.DataGridViewTextBoxColumn10.HeaderText = "url"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Tb_cellarDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(353, 137)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cellar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tb_cellarDataGridView
        '
        Me.Tb_cellarDataGridView.AutoGenerateColumns = False
        Me.Tb_cellarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_cellarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Tb_cellarDataGridView.DataSource = Me.Tb_cellarBindingSource
        Me.Tb_cellarDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Tb_cellarDataGridView.Name = "Tb_cellarDataGridView"
        Me.Tb_cellarDataGridView.RowTemplate.Height = 23
        Me.Tb_cellarDataGridView.Size = New System.Drawing.Size(330, 220)
        Me.Tb_cellarDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cellar"
        Me.DataGridViewTextBoxColumn12.HeaderText = "cellar"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn13.HeaderText = "area"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
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
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "id"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cellar_id"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tb_cellarBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cellar_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frm_winecellar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 408)
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
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Tb_wineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Tb_cellarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Tb_wineDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Tb_cellarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
