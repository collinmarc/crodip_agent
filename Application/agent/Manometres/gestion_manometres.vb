Imports System.Collections.Generic
Public Class gestion_manometres
    Inherits frmCRODIP

#Region " Code g�n�r� par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()

    End Sub

    'La m�thode substitu�e Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE�: la proc�dure suivante est requise par le Concepteur Windows Form
    'Elle peut �tre modifi�e en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'�diteur de code.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolTipShowFichevie As System.Windows.Forms.ToolTip
    Friend WithEvents imagesEtatMateriel As System.Windows.Forms.ImageList
    Friend WithEvents imagesPictos As System.Windows.Forms.ImageList
    Friend WithEvents btn_gestionManometresEtalon_valider As System.Windows.Forms.Label
    Friend WithEvents tpManoControle As TabPage
    Friend WithEvents m_bsManoControle As BindingSource
    Friend WithEvents Label13 As Label
    Friend WithEvents tpManoEtalon As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvManoEtalon As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowCol As DataGridViewImageColumn
    Friend WithEvents idCrodip As DataGridViewTextBoxColumn
    Friend WithEvents MarqueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FondEchelleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClasseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EtatColumn As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents IdCrodipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarqueDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ClasseDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FondEchelleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dateDernierControle As DataGridViewTextBoxColumn
    Friend WithEvents EtatMECol As DataGridViewImageColumn
    Friend WithEvents m_bsMAnoEtalon As BindingSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestion_manometres))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpManoControle = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ShowCol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.idCrodip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FondEchelleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.m_bsManoControle = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tpManoEtalon = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvManoEtalon = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdCrodipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarqueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClasseDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FondEchelleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateDernierControle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatMECol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.m_bsMAnoEtalon = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolTipShowFichevie = New System.Windows.Forms.ToolTip(Me.components)
        Me.imagesEtatMateriel = New System.Windows.Forms.ImageList(Me.components)
        Me.imagesPictos = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_gestionManometresEtalon_valider = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tpManoControle.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsManoControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpManoEtalon.SuspendLayout()
        CType(Me.dgvManoEtalon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsMAnoEtalon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpManoControle)
        Me.TabControl1.Controls.Add(Me.tpManoEtalon)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1014, 637)
        Me.TabControl1.TabIndex = 0
        '
        'tpManoControle
        '
        Me.tpManoControle.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tpManoControle.Controls.Add(Me.DataGridView1)
        Me.tpManoControle.Controls.Add(Me.Label13)
        Me.tpManoControle.Location = New System.Drawing.Point(4, 22)
        Me.tpManoControle.Name = "tpManoControle"
        Me.tpManoControle.Size = New System.Drawing.Size(1006, 611)
        Me.tpManoControle.TabIndex = 2
        Me.tpManoControle.Text = "Manom�tres de contr�le"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShowCol, Me.idCrodip, Me.MarqueDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.FondEchelleDataGridViewTextBoxColumn, Me.ClasseDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.EtatColumn})
        Me.DataGridView1.DataSource = Me.m_bsManoControle
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.Location = New System.Drawing.Point(8, 38)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(984, 558)
        Me.DataGridView1.TabIndex = 39
        Me.DataGridView1.VirtualMode = True
        '
        'ShowCol
        '
        Me.ShowCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ShowCol.Frozen = True
        Me.ShowCol.HeaderText = ""
        Me.ShowCol.Image = Global.Crodip_agent.Resources.oeil16x16
        Me.ShowCol.Name = "ShowCol"
        Me.ShowCol.ReadOnly = True
        Me.ShowCol.ToolTipText = "Voir la fiche manom�tre"
        Me.ShowCol.Width = 30
        '
        'idCrodip
        '
        Me.idCrodip.DataPropertyName = "idCrodip"
        Me.idCrodip.HeaderText = "Identifiant Manom�tre"
        Me.idCrodip.Name = "idCrodip"
        Me.idCrodip.ReadOnly = True
        '
        'MarqueDataGridViewTextBoxColumn
        '
        Me.MarqueDataGridViewTextBoxColumn.DataPropertyName = "marque"
        Me.MarqueDataGridViewTextBoxColumn.HeaderText = "Marque"
        Me.MarqueDataGridViewTextBoxColumn.Name = "MarqueDataGridViewTextBoxColumn"
        Me.MarqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FondEchelleDataGridViewTextBoxColumn
        '
        Me.FondEchelleDataGridViewTextBoxColumn.DataPropertyName = "fondEchelle"
        Me.FondEchelleDataGridViewTextBoxColumn.HeaderText = "Fond d'�chelle"
        Me.FondEchelleDataGridViewTextBoxColumn.Name = "FondEchelleDataGridViewTextBoxColumn"
        Me.FondEchelleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClasseDataGridViewTextBoxColumn
        '
        Me.ClasseDataGridViewTextBoxColumn.DataPropertyName = "classe"
        Me.ClasseDataGridViewTextBoxColumn.HeaderText = "Classe"
        Me.ClasseDataGridViewTextBoxColumn.Name = "ClasseDataGridViewTextBoxColumn"
        Me.ClasseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dateDernierControle"
        DataGridViewCellStyle12.Format = "dd/MM/yyyy"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date dernier controle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'EtatColumn
        '
        Me.EtatColumn.HeaderText = "Etat"
        Me.EtatColumn.Name = "EtatColumn"
        Me.EtatColumn.ReadOnly = True
        Me.EtatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'm_bsManoControle
        '
        Me.m_bsManoControle.DataSource = GetType(Crodip_agent.ManometreControle)
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Location = New System.Drawing.Point(17, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(480, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "     Gestion des manom�tres de contr�le/calibrateur"
        '
        'tpManoEtalon
        '
        Me.tpManoEtalon.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.tpManoEtalon.Controls.Add(Me.Label1)
        Me.tpManoEtalon.Controls.Add(Me.dgvManoEtalon)
        Me.tpManoEtalon.Controls.Add(Me.Label14)
        Me.tpManoEtalon.Location = New System.Drawing.Point(4, 22)
        Me.tpManoEtalon.Name = "tpManoEtalon"
        Me.tpManoEtalon.Padding = New System.Windows.Forms.Padding(3)
        Me.tpManoEtalon.Size = New System.Drawing.Size(1006, 611)
        Me.tpManoEtalon.TabIndex = 3
        Me.tpManoEtalon.Text = "Manom�tres r�f�rence"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(634, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 56)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Attention! un manom�tre de r�f�rence ne doit pas �tre utilis� sur le ""terrain"". I" &
    "l doit rester dans un endroit s�curis�, afin de garantir sa fiablit�"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvManoEtalon
        '
        Me.dgvManoEtalon.AllowUserToAddRows = False
        Me.dgvManoEtalon.AllowUserToDeleteRows = False
        Me.dgvManoEtalon.AllowUserToOrderColumns = True
        Me.dgvManoEtalon.AllowUserToResizeRows = False
        Me.dgvManoEtalon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvManoEtalon.AutoGenerateColumns = False
        Me.dgvManoEtalon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvManoEtalon.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManoEtalon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvManoEtalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManoEtalon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.IdCrodipDataGridViewTextBoxColumn, Me.MarqueDataGridViewTextBoxColumn1, Me.ClasseDataGridViewTextBoxColumn1, Me.TypeDataGridViewTextBoxColumn1, Me.FondEchelleDataGridViewTextBoxColumn1, Me.dateDernierControle, Me.EtatMECol})
        Me.dgvManoEtalon.DataSource = Me.m_bsMAnoEtalon
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManoEtalon.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvManoEtalon.Location = New System.Drawing.Point(8, 38)
        Me.dgvManoEtalon.MultiSelect = False
        Me.dgvManoEtalon.Name = "dgvManoEtalon"
        Me.dgvManoEtalon.ReadOnly = True
        Me.dgvManoEtalon.RowHeadersVisible = False
        Me.dgvManoEtalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvManoEtalon.Size = New System.Drawing.Size(984, 558)
        Me.dgvManoEtalon.TabIndex = 42
        Me.dgvManoEtalon.VirtualMode = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = ""
        Me.Column1.Image = Global.Crodip_agent.Resources.oeil16x16
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 30
        '
        'IdCrodipDataGridViewTextBoxColumn
        '
        Me.IdCrodipDataGridViewTextBoxColumn.DataPropertyName = "idCrodip"
        Me.IdCrodipDataGridViewTextBoxColumn.HeaderText = "N� Identifiant manom�tre"
        Me.IdCrodipDataGridViewTextBoxColumn.Name = "IdCrodipDataGridViewTextBoxColumn"
        Me.IdCrodipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarqueDataGridViewTextBoxColumn1
        '
        Me.MarqueDataGridViewTextBoxColumn1.DataPropertyName = "marque"
        Me.MarqueDataGridViewTextBoxColumn1.HeaderText = "Marque"
        Me.MarqueDataGridViewTextBoxColumn1.Name = "MarqueDataGridViewTextBoxColumn1"
        Me.MarqueDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ClasseDataGridViewTextBoxColumn1
        '
        Me.ClasseDataGridViewTextBoxColumn1.DataPropertyName = "classe"
        Me.ClasseDataGridViewTextBoxColumn1.HeaderText = "Classe"
        Me.ClasseDataGridViewTextBoxColumn1.Name = "ClasseDataGridViewTextBoxColumn1"
        Me.ClasseDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn1
        '
        Me.TypeDataGridViewTextBoxColumn1.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn1.Name = "TypeDataGridViewTextBoxColumn1"
        Me.TypeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FondEchelleDataGridViewTextBoxColumn1
        '
        Me.FondEchelleDataGridViewTextBoxColumn1.DataPropertyName = "fondEchelle"
        Me.FondEchelleDataGridViewTextBoxColumn1.HeaderText = "Fond d'�chelle"
        Me.FondEchelleDataGridViewTextBoxColumn1.Name = "FondEchelleDataGridViewTextBoxColumn1"
        Me.FondEchelleDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dateDernierControle
        '
        Me.dateDernierControle.DataPropertyName = "dateDernierControle"
        DataGridViewCellStyle9.Format = "dd/MM/yyyy"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.dateDernierControle.DefaultCellStyle = DataGridViewCellStyle9
        Me.dateDernierControle.HeaderText = "date dernier controle"
        Me.dateDernierControle.Name = "dateDernierControle"
        Me.dateDernierControle.ReadOnly = True
        '
        'EtatMECol
        '
        Me.EtatMECol.HeaderText = "Etat apr�s v�rification"
        Me.EtatMECol.Name = "EtatMECol"
        Me.EtatMECol.ReadOnly = True
        '
        'm_bsMAnoEtalon
        '
        Me.m_bsMAnoEtalon.DataSource = GetType(Crodip_agent.ManometreEtalon)
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Location = New System.Drawing.Point(17, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(383, 25)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "     Gestion des manom�tres de r�f�rence"
        '
        'imagesEtatMateriel
        '
        Me.imagesEtatMateriel.ImageStream = CType(resources.GetObject("imagesEtatMateriel.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesEtatMateriel.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesEtatMateriel.Images.SetKeyName(0, "")
        Me.imagesEtatMateriel.Images.SetKeyName(1, "")
        Me.imagesEtatMateriel.Images.SetKeyName(2, "g.jpg")
        '
        'imagesPictos
        '
        Me.imagesPictos.ImageStream = CType(resources.GetObject("imagesPictos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesPictos.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesPictos.Images.SetKeyName(0, "")
        Me.imagesPictos.Images.SetKeyName(1, "")
        '
        'btn_gestionManometresEtalon_valider
        '
        Me.btn_gestionManometresEtalon_valider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_gestionManometresEtalon_valider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gestionManometresEtalon_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gestionManometresEtalon_valider.ForeColor = System.Drawing.Color.White
        Me.btn_gestionManometresEtalon_valider.Image = CType(resources.GetObject("btn_gestionManometresEtalon_valider.Image"), System.Drawing.Image)
        Me.btn_gestionManometresEtalon_valider.Location = New System.Drawing.Point(868, 646)
        Me.btn_gestionManometresEtalon_valider.Name = "btn_gestionManometresEtalon_valider"
        Me.btn_gestionManometresEtalon_valider.Size = New System.Drawing.Size(128, 24)
        Me.btn_gestionManometresEtalon_valider.TabIndex = 40
        Me.btn_gestionManometresEtalon_valider.Text = "    Valider / Quitter"
        Me.btn_gestionManometresEtalon_valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gestion_manometres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.Controls.Add(Me.btn_gestionManometresEtalon_valider)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "gestion_manometres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gestion_manometres"
        Me.TabControl1.ResumeLayout(False)
        Me.tpManoControle.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsManoControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpManoEtalon.ResumeLayout(False)
        CType(Me.dgvManoEtalon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsMAnoEtalon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub gestion_manometres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'globFormGestionMano = Me

        'Dim arrMarquesControls(0) As ComboBox
        'Dim arrTypesControls(0) As ComboBox

        '#################################################################################
        '########                    Manom�tres de contr�le                       ########
        '#################################################################################
        '        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(gestion_manometres))
        ' On r�cup�re les mano de controle de l'agent
        displaylisteManoControle()
        '#################################################################################
        '########                       Manom�tres �talons                        ########
        '#################################################################################
        ' On r�cup�re les mano de controle de l'agent
        displayListeManoEtalon()
        '#################################################################################
        '########                   Chargement des marques,etc...                 ########
        '#################################################################################
        'MarquesManager.populateCombobox(Globals.GLOB_XML_MARQUES_MANO, arrMarquesControls)
        'MarquesManager.populateCombobox(Globals.GLOB_XML_MODELES_MANO, arrTypesControls)
    End Sub
    Private Function displayListeManoEtalon() As Boolean
        Dim bReturn As Boolean
        Try
            Dim arrManoEtalon As List(Of ManometreEtalon) = ManometreEtalonManager.getManometreEtalonByStructureId(agentCourant.idStructure, True)
            m_bsMAnoEtalon.Clear()
            For Each oMano As ManometreEtalon In arrManoEtalon
                m_bsMAnoEtalon.Add(oMano)
            Next
        Catch ex As Exception
            CSDebug.dispError("Gestion_Manometre.DisplayListeManoEtalon Error" + ex.Message)
            bReturn = False
        End Try
        Return bReturn

    End Function
    Private Function displaylisteManoControle() As Boolean
        Dim bReturn As Boolean
        Try

            Dim arrManoControle As List(Of ManometreControle) = ManometreControleManager.getManoControleByStructureId(agentCourant.idStructure, True)
            'Ajout des Mano JamaisServi
            arrManoControle.AddRange(ManometreControleManager.getManoControleByStructureIdJamaisServi(agentCourant.idStructure))
            For Each oMano As ManometreControle In arrManoControle
                m_bsManoControle.Add(oMano)
            Next

        Catch ex As Exception
            CSDebug.dispError("Gestion_Manometre.DisplayListeControle Error" + ex.Message)
            bReturn = False
        End Try
        Return bReturn

    End Function



    Private Sub DataGridView1_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles DataGridView1.CellValueNeeded
        If e.RowIndex >= 0 And e.ColumnIndex = EtatColumn.Index Then
            Dim index As Integer = e.RowIndex
            Dim oMano As ManometreControle = m_bsManoControle(index)
            e.Value = Crodip_agent.Resources.PuceGriseT
            If oMano.etat Then
                e.Value = Crodip_agent.Resources.PuceVerteT
            Else
                e.Value = Crodip_agent.Resources.PuceRougeT
            End If
        End If
    End Sub
    Private Sub dgvManoEtalon_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles dgvManoEtalon.CellValueNeeded
        If e.RowIndex >= 0 And e.ColumnIndex = EtatMECol.Index Then
            Dim index As Integer = e.RowIndex
            Dim oMano As ManometreEtalon = m_bsMAnoEtalon(index)
            e.Value = Crodip_agent.Resources.PuceGriseT
            If oMano.etat Then
                e.Value = Crodip_agent.Resources.PuceVerteT
            Else
                e.Value = Crodip_agent.Resources.PuceRougeT
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then
            Dim oMano As Manometre
            oMano = m_bsManoControle(e.RowIndex)
            Dim formFicheMano As fiche_manometre
            formFicheMano = New fiche_manometre(oMano)
            If formFicheMano.ShowDialog(Me) <> Windows.Forms.DialogResult.Cancel Then
                m_bsManoControle.ResetBindings(False)
            End If

        End If
    End Sub

    Private Sub dgvManoEtalon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManoEtalon.CellClick
        If e.ColumnIndex = 0 Then
            Dim oMano As Manometre
            oMano = m_bsMAnoEtalon(e.RowIndex)
            Dim formFicheMano As fiche_manometre
            formFicheMano = New fiche_manometre(oMano)
            If formFicheMano.ShowDialog(Me) <> Windows.Forms.DialogResult.Cancel Then
                m_bsMAnoEtalon.ResetBindings(False)
            End If

        End If

    End Sub

    Private Sub btn_gestionManometresEtalon_valider_Click(sender As Object, e As EventArgs) Handles btn_gestionManometresEtalon_valider.Click
        TryCast(MdiParent, parentContener).ReturnToAccueil()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class
