<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MealSearchMainForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MealSearchMainForm))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FullReportTab = New System.Windows.Forms.TabPage()
        Me.FullReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchReportTab = New System.Windows.Forms.TabPage()
        Me.SearchReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.PrintGroupBox = New System.Windows.Forms.GroupBox()
        Me.printtestbut = New System.Windows.Forms.Button()
        Me.ImportGroupBox = New System.Windows.Forms.GroupBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.ExportOpGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExportCsvButton = New System.Windows.Forms.Button()
        Me.SaveAsExcelBut = New System.Windows.Forms.Button()
        Me.SearchOpGroupBox = New System.Windows.Forms.GroupBox()
        Me.MealTypeLable = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.MealTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AddUserButton = New System.Windows.Forms.Button()
        Me.UsernameListBox = New System.Windows.Forms.ListBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.RemoveUserButton = New System.Windows.Forms.Button()
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UsernameListLabel = New System.Windows.Forms.Label()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.SFDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PTD = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MainPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.FullReportTab.SuspendLayout()
        CType(Me.FullReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchReportTab.SuspendLayout()
        CType(Me.SearchReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        Me.PrintGroupBox.SuspendLayout()
        Me.ImportGroupBox.SuspendLayout()
        Me.ExportOpGroupBox.SuspendLayout()
        Me.SearchOpGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.CadetBlue
        Me.MainPanel.Controls.Add(Me.TabControl1)
        Me.MainPanel.Controls.Add(Me.MenuPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(993, 585)
        Me.MainPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.FullReportTab)
        Me.TabControl1.Controls.Add(Me.SearchReportTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 117)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(993, 431)
        Me.TabControl1.TabIndex = 2
        '
        'FullReportTab
        '
        Me.FullReportTab.Controls.Add(Me.FullReportDataGridView)
        Me.FullReportTab.Location = New System.Drawing.Point(4, 22)
        Me.FullReportTab.Name = "FullReportTab"
        Me.FullReportTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FullReportTab.Size = New System.Drawing.Size(985, 405)
        Me.FullReportTab.TabIndex = 0
        Me.FullReportTab.Text = "Full Report"
        Me.FullReportTab.UseVisualStyleBackColor = True
        '
        'FullReportDataGridView
        '
        Me.FullReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FullReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FullReportDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.FullReportDataGridView.Name = "FullReportDataGridView"
        Me.FullReportDataGridView.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.FullReportDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FullReportDataGridView.Size = New System.Drawing.Size(979, 399)
        Me.FullReportDataGridView.TabIndex = 1
        '
        'SearchReportTab
        '
        Me.SearchReportTab.Controls.Add(Me.SearchReportDataGridView)
        Me.SearchReportTab.Location = New System.Drawing.Point(4, 22)
        Me.SearchReportTab.Name = "SearchReportTab"
        Me.SearchReportTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SearchReportTab.Size = New System.Drawing.Size(985, 405)
        Me.SearchReportTab.TabIndex = 1
        Me.SearchReportTab.Text = "Search Report"
        Me.SearchReportTab.UseVisualStyleBackColor = True
        '
        'SearchReportDataGridView
        '
        Me.SearchReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchReportDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SearchReportDataGridView.Name = "SearchReportDataGridView"
        Me.SearchReportDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchReportDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.SearchReportDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.SearchReportDataGridView.Size = New System.Drawing.Size(979, 399)
        Me.SearchReportDataGridView.TabIndex = 0
        '
        'MenuPanel
        '
        Me.MenuPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuPanel.BackColor = System.Drawing.Color.White
        Me.MenuPanel.Controls.Add(Me.PrintGroupBox)
        Me.MenuPanel.Controls.Add(Me.ImportGroupBox)
        Me.MenuPanel.Controls.Add(Me.ExportOpGroupBox)
        Me.MenuPanel.Controls.Add(Me.SearchOpGroupBox)
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(993, 111)
        Me.MenuPanel.TabIndex = 0
        '
        'PrintGroupBox
        '
        Me.PrintGroupBox.Controls.Add(Me.printtestbut)
        Me.PrintGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintGroupBox.Location = New System.Drawing.Point(872, 4)
        Me.PrintGroupBox.Name = "PrintGroupBox"
        Me.PrintGroupBox.Size = New System.Drawing.Size(100, 100)
        Me.PrintGroupBox.TabIndex = 19
        Me.PrintGroupBox.TabStop = False
        Me.PrintGroupBox.Text = "Print options"
        '
        'printtestbut
        '
        Me.printtestbut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printtestbut.Location = New System.Drawing.Point(6, 19)
        Me.printtestbut.Name = "printtestbut"
        Me.printtestbut.Size = New System.Drawing.Size(88, 23)
        Me.printtestbut.TabIndex = 0
        Me.printtestbut.Text = "Print"
        Me.printtestbut.UseVisualStyleBackColor = True
        '
        'ImportGroupBox
        '
        Me.ImportGroupBox.Controls.Add(Me.LoadButton)
        Me.ImportGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportGroupBox.Location = New System.Drawing.Point(6, 4)
        Me.ImportGroupBox.Name = "ImportGroupBox"
        Me.ImportGroupBox.Size = New System.Drawing.Size(111, 100)
        Me.ImportGroupBox.TabIndex = 18
        Me.ImportGroupBox.TabStop = False
        Me.ImportGroupBox.Text = "Import options"
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.Location = New System.Drawing.Point(7, 25)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(94, 56)
        Me.LoadButton.TabIndex = 0
        Me.LoadButton.Text = "Load full report"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'ExportOpGroupBox
        '
        Me.ExportOpGroupBox.Controls.Add(Me.ExportCsvButton)
        Me.ExportOpGroupBox.Controls.Add(Me.SaveAsExcelBut)
        Me.ExportOpGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportOpGroupBox.Location = New System.Drawing.Point(766, 4)
        Me.ExportOpGroupBox.Name = "ExportOpGroupBox"
        Me.ExportOpGroupBox.Size = New System.Drawing.Size(100, 100)
        Me.ExportOpGroupBox.TabIndex = 17
        Me.ExportOpGroupBox.TabStop = False
        Me.ExportOpGroupBox.Text = "Export options"
        '
        'ExportCsvButton
        '
        Me.ExportCsvButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ExportCsvButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportCsvButton.Location = New System.Drawing.Point(7, 19)
        Me.ExportCsvButton.Name = "ExportCsvButton"
        Me.ExportCsvButton.Size = New System.Drawing.Size(87, 35)
        Me.ExportCsvButton.TabIndex = 1
        Me.ExportCsvButton.Text = "Export search report as csv"
        Me.ExportCsvButton.UseVisualStyleBackColor = False
        '
        'SaveAsExcelBut
        '
        Me.SaveAsExcelBut.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SaveAsExcelBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsExcelBut.Location = New System.Drawing.Point(7, 58)
        Me.SaveAsExcelBut.Name = "SaveAsExcelBut"
        Me.SaveAsExcelBut.Size = New System.Drawing.Size(87, 35)
        Me.SaveAsExcelBut.TabIndex = 13
        Me.SaveAsExcelBut.Text = "Export search report as xls"
        Me.SaveAsExcelBut.UseVisualStyleBackColor = False
        '
        'SearchOpGroupBox
        '
        Me.SearchOpGroupBox.Controls.Add(Me.MealTypeLable)
        Me.SearchOpGroupBox.Controls.Add(Me.UsernameLabel)
        Me.SearchOpGroupBox.Controls.Add(Me.MealTypeComboBox)
        Me.SearchOpGroupBox.Controls.Add(Me.AddUserButton)
        Me.SearchOpGroupBox.Controls.Add(Me.UsernameListBox)
        Me.SearchOpGroupBox.Controls.Add(Me.SearchButton)
        Me.SearchOpGroupBox.Controls.Add(Me.RemoveUserButton)
        Me.SearchOpGroupBox.Controls.Add(Me.EndDateLabel)
        Me.SearchOpGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.SearchOpGroupBox.Controls.Add(Me.EndDateTimePicker)
        Me.SearchOpGroupBox.Controls.Add(Me.UsernameListLabel)
        Me.SearchOpGroupBox.Controls.Add(Me.StartDateTimePicker)
        Me.SearchOpGroupBox.Controls.Add(Me.StartDateLabel)
        Me.SearchOpGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchOpGroupBox.Location = New System.Drawing.Point(123, 4)
        Me.SearchOpGroupBox.Name = "SearchOpGroupBox"
        Me.SearchOpGroupBox.Size = New System.Drawing.Size(637, 100)
        Me.SearchOpGroupBox.TabIndex = 16
        Me.SearchOpGroupBox.TabStop = False
        Me.SearchOpGroupBox.Text = "Search options"
        '
        'MealTypeLable
        '
        Me.MealTypeLable.AutoSize = True
        Me.MealTypeLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealTypeLable.Location = New System.Drawing.Point(295, 76)
        Me.MealTypeLable.Name = "MealTypeLable"
        Me.MealTypeLable.Size = New System.Drawing.Size(57, 13)
        Me.MealTypeLable.TabIndex = 15
        Me.MealTypeLable.Text = "Meal Type"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(6, 18)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Username"
        '
        'MealTypeComboBox
        '
        Me.MealTypeComboBox.AutoCompleteCustomSource.AddRange(New String() {"All", "Breakfast", "Lunch", "Dinner"})
        Me.MealTypeComboBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MealTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MealTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealTypeComboBox.FormattingEnabled = True
        Me.MealTypeComboBox.Items.AddRange(New Object() {"All", "Breakfast", "Lunch", "Dinner"})
        Me.MealTypeComboBox.Location = New System.Drawing.Point(357, 72)
        Me.MealTypeComboBox.Name = "MealTypeComboBox"
        Me.MealTypeComboBox.Size = New System.Drawing.Size(180, 21)
        Me.MealTypeComboBox.TabIndex = 14
        '
        'AddUserButton
        '
        Me.AddUserButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AddUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserButton.Location = New System.Drawing.Point(240, 13)
        Me.AddUserButton.Name = "AddUserButton"
        Me.AddUserButton.Size = New System.Drawing.Size(27, 23)
        Me.AddUserButton.TabIndex = 2
        Me.AddUserButton.Text = "+"
        Me.AddUserButton.UseVisualStyleBackColor = False
        '
        'UsernameListBox
        '
        Me.UsernameListBox.AllowDrop = True
        Me.UsernameListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameListBox.FormattingEnabled = True
        Me.UsernameListBox.Location = New System.Drawing.Point(86, 41)
        Me.UsernameListBox.Name = "UsernameListBox"
        Me.UsernameListBox.ScrollAlwaysVisible = True
        Me.UsernameListBox.Size = New System.Drawing.Size(148, 43)
        Me.UsernameListBox.TabIndex = 3
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(555, 36)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(69, 34)
        Me.SearchButton.TabIndex = 12
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'RemoveUserButton
        '
        Me.RemoveUserButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RemoveUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveUserButton.Location = New System.Drawing.Point(240, 41)
        Me.RemoveUserButton.Name = "RemoveUserButton"
        Me.RemoveUserButton.Size = New System.Drawing.Size(27, 23)
        Me.RemoveUserButton.TabIndex = 4
        Me.RemoveUserButton.Text = "-"
        Me.RemoveUserButton.UseVisualStyleBackColor = False
        '
        'EndDateLabel
        '
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLabel.Location = New System.Drawing.Point(295, 47)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(52, 13)
        Me.EndDateLabel.TabIndex = 11
        Me.EndDateLabel.Text = "End Date"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UsernameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(86, 14)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.UsernameTextBox.TabIndex = 5
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateTimePicker.Location = New System.Drawing.Point(357, 43)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(180, 20)
        Me.EndDateTimePicker.TabIndex = 10
        '
        'UsernameListLabel
        '
        Me.UsernameListLabel.AutoSize = True
        Me.UsernameListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameListLabel.Location = New System.Drawing.Point(6, 41)
        Me.UsernameListLabel.Name = "UsernameListLabel"
        Me.UsernameListLabel.Size = New System.Drawing.Size(74, 13)
        Me.UsernameListLabel.TabIndex = 7
        Me.UsernameListLabel.Text = "Username List"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateTimePicker.Location = New System.Drawing.Point(357, 14)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(180, 20)
        Me.StartDateTimePicker.TabIndex = 9
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLabel.Location = New System.Drawing.Point(295, 18)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(55, 13)
        Me.StartDateLabel.TabIndex = 8
        Me.StartDateLabel.Text = "Start Date"
        '
        'SFDialog
        '
        Me.SFDialog.DefaultExt = "csv"
        '
        'OFDialog
        '
        Me.OFDialog.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 546)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 41)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.MealsSearchAppV2.My.Resources.Resources.headerHomelogo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.MealsSearchAppV2.My.Resources.Resources.CreatedByBenC2
        Me.PictureBox1.Location = New System.Drawing.Point(787, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PTD
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MealSearchMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MealSearchMainForm"
        Me.Text = "WCS Dinninghall Search Report"
        Me.TransparencyKey = System.Drawing.Color.Tan
        Me.MainPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.FullReportTab.ResumeLayout(False)
        CType(Me.FullReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchReportTab.ResumeLayout(False)
        CType(Me.SearchReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.PrintGroupBox.ResumeLayout(False)
        Me.ImportGroupBox.ResumeLayout(False)
        Me.ExportOpGroupBox.ResumeLayout(False)
        Me.SearchOpGroupBox.ResumeLayout(False)
        Me.SearchOpGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents StartDateLabel As Label
    Friend WithEvents UsernameListLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents RemoveUserButton As Button
    Friend WithEvents UsernameListBox As ListBox
    Friend WithEvents AddUserButton As Button
    Friend WithEvents ExportCsvButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents EndDateLabel As Label
    Friend WithEvents EndDateTimePicker As DateTimePicker
    Friend WithEvents StartDateTimePicker As DateTimePicker
    Friend WithEvents SearchButton As Button
    Friend WithEvents FullReportDataGridView As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FullReportTab As TabPage
    Friend WithEvents SearchReportTab As TabPage
    Friend WithEvents SearchReportDataGridView As DataGridView
    Friend WithEvents SFDialog As SaveFileDialog
    Friend WithEvents OFDialog As OpenFileDialog
    Friend WithEvents SaveAsExcelBut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MealTypeComboBox As ComboBox
    Friend WithEvents MealTypeLable As Label
    Friend WithEvents SearchOpGroupBox As GroupBox
    Friend WithEvents ExportOpGroupBox As GroupBox
    Friend WithEvents ImportGroupBox As GroupBox
    Friend WithEvents PrintGroupBox As GroupBox
    Friend WithEvents PTD As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents printtestbut As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
