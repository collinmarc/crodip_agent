﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diagnostic_dlghelp12123new

    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(diagnostic_dlghelp12123new))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure1", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure2", 0, 0)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure3", 3, 3)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pompe1", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure1", 0, 0)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure2", 3, 2)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mesure3", 2, 2)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pompe2", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Me.pnl12123 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.listImg_flags = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlDetailPompe = New System.Windows.Forms.Panel()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblResultat12123 = New System.Windows.Forms.Label()
        Me.btnModele_validerNbBuses = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNumeric10 = New CRODIP_ControlLibrary.TBNumeric()
        Me.TbNumeric9 = New CRODIP_ControlLibrary.TBNumeric()
        Me.TbNumeric1 = New CRODIP_ControlLibrary.TBNumeric()
        Me.TbNumeric2 = New CRODIP_ControlLibrary.TBNumeric()
        Me.TbNumeric8 = New CRODIP_ControlLibrary.TBNumeric()
        Me.TbNumeric7 = New CRODIP_ControlLibrary.TBNumeric()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DebitReelRNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitTotalRNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReglageDispositifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitTheoriqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempsMesureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasseApresAspiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasseApresComplementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteProduitConsoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageReelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcartReglageRNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_bsrcMesures = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.pnl12123.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlDetailPompe.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsrcMesures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl12123
        '
        Me.pnl12123.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl12123.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl12123.Controls.Add(Me.SplitContainer1)
        Me.pnl12123.Controls.Add(Me.NumericUpDown1)
        Me.pnl12123.Controls.Add(Me.lblResultat12123)
        Me.pnl12123.Controls.Add(Me.btnModele_validerNbBuses)
        Me.pnl12123.Controls.Add(Me.Label18)
        Me.pnl12123.Controls.Add(Me.Label1)
        Me.pnl12123.Controls.Add(Me.btnAnnuler)
        Me.pnl12123.Controls.Add(Me.btnValider)
        Me.pnl12123.Location = New System.Drawing.Point(6, 4)
        Me.pnl12123.Name = "pnl12123"
        Me.pnl12123.Size = New System.Drawing.Size(713, 517)
        Me.pnl12123.TabIndex = 43
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 68)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlDetailPompe)
        Me.SplitContainer1.Size = New System.Drawing.Size(697, 411)
        Me.SplitContainer1.SplitterDistance = 101
        Me.SplitContainer1.TabIndex = 79
        '
        'listImg_flags
        '
        Me.listImg_flags.ImageStream = CType(resources.GetObject("listImg_flags.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listImg_flags.TransparentColor = System.Drawing.Color.Transparent
        Me.listImg_flags.Images.SetKeyName(0, "")
        Me.listImg_flags.Images.SetKeyName(1, "")
        Me.listImg_flags.Images.SetKeyName(2, "")
        Me.listImg_flags.Images.SetKeyName(3, "")
        '
        'pnlDetailPompe
        '
        Me.pnlDetailPompe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetailPompe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetailPompe.Controls.Add(Me.Label2)
        Me.pnlDetailPompe.Controls.Add(Me.DataGridView1)
        Me.pnlDetailPompe.Controls.Add(Me.Label16)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric10)
        Me.pnlDetailPompe.Controls.Add(Me.Label14)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric9)
        Me.pnlDetailPompe.Controls.Add(Me.Label13)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric1)
        Me.pnlDetailPompe.Controls.Add(Me.Label8)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric2)
        Me.pnlDetailPompe.Controls.Add(Me.Label9)
        Me.pnlDetailPompe.Controls.Add(Me.NumericUpDown2)
        Me.pnlDetailPompe.Controls.Add(Me.Label3)
        Me.pnlDetailPompe.Controls.Add(Me.Label12)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric8)
        Me.pnlDetailPompe.Controls.Add(Me.TbNumeric7)
        Me.pnlDetailPompe.Controls.Add(Me.Label11)
        Me.pnlDetailPompe.Controls.Add(Me.PictureBox1)
        Me.pnlDetailPompe.Controls.Add(Me.Label10)
        Me.pnlDetailPompe.Location = New System.Drawing.Point(6, 3)
        Me.pnlDetailPompe.Name = "pnlDetailPompe"
        Me.pnlDetailPompe.Size = New System.Drawing.Size(585, 405)
        Me.pnlDetailPompe.TabIndex = 78
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown2.Location = New System.Drawing.Point(522, 148)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown2.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(436, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Nb mesures"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(122, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Débit mesuré :"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(353, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Pression de mesure :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Crodip_agent.Resources.PuceVerteT
        Me.PictureBox1.Location = New System.Drawing.Point(410, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(4, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pompe 1 "
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(148, 42)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 75
        '
        'lblResultat12123
        '
        Me.lblResultat12123.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultat12123.AutoSize = True
        Me.lblResultat12123.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultat12123.ForeColor = System.Drawing.Color.Red
        Me.lblResultat12123.Location = New System.Drawing.Point(548, 46)
        Me.lblResultat12123.Name = "lblResultat12123"
        Me.lblResultat12123.Size = New System.Drawing.Size(113, 16)
        Me.lblResultat12123.TabIndex = 74
        Me.lblResultat12123.Text = "Résultat global"
        Me.lblResultat12123.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnModele_validerNbBuses
        '
        Me.btnModele_validerNbBuses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModele_validerNbBuses.ForeColor = System.Drawing.Color.White
        Me.btnModele_validerNbBuses.Image = CType(resources.GetObject("btnModele_validerNbBuses.Image"), System.Drawing.Image)
        Me.btnModele_validerNbBuses.Location = New System.Drawing.Point(194, 38)
        Me.btnModele_validerNbBuses.Name = "btnModele_validerNbBuses"
        Me.btnModele_validerNbBuses.Size = New System.Drawing.Size(128, 24)
        Me.btnModele_validerNbBuses.TabIndex = 48
        Me.btnModele_validerNbBuses.Text = "    Valider"
        Me.btnModele_validerNbBuses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(8, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Nb pompes doseuses"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(212, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Controle du dispositif de dosage"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAnnuler.BackgroundImage = Global.Crodip_agent.Resources.btn_annuler
        Me.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.FlatAppearance.BorderSize = 0
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(563, 485)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(134, 25)
        Me.btnAnnuler.TabIndex = 43
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnValider
        '
        Me.btnValider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnValider.BackgroundImage = Global.Crodip_agent.Resources.btn_valider
        Me.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnValider.FlatAppearance.BorderSize = 0
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.White
        Me.btnValider.Location = New System.Drawing.Point(403, 485)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(138, 25)
        Me.btnValider.TabIndex = 42
        Me.btnValider.Text = "OK"
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(390, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Nb de buse :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(44, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Pression moyenne à la rampe : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(140, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "Débit réel :"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(390, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Débit total : "
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label16.Location = New System.Drawing.Point(461, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 16)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "OK"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DebitReelRNDDataGridViewTextBoxColumn, Me.DebitTotalRNDDataGridViewTextBoxColumn, Me.ReglageDispositifDataGridViewTextBoxColumn, Me.DebitTheoriqueDataGridViewTextBoxColumn, Me.TempsMesureDataGridViewTextBoxColumn, Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn, Me.MasseApresAspiDataGridViewTextBoxColumn, Me.MasseApresComplementDataGridViewTextBoxColumn, Me.QteProduitConsoDataGridViewTextBoxColumn, Me.DosageReelDataGridViewTextBoxColumn, Me.EcartReglageRNDDataGridViewTextBoxColumn, Me.ResultatDataGridViewTextBoxColumn, Me.Image})
        Me.DataGridView1.DataSource = Me.m_bsrcMesures
        Me.DataGridView1.Location = New System.Drawing.Point(3, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(575, 227)
        Me.DataGridView1.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(256, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "MESURES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbNumeric10
        '
        Me.TbNumeric10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbNumeric10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNumeric10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "DebitTotalRND", True))
        Me.TbNumeric10.ForceBindingOnTextChanged = False
        Me.TbNumeric10.Location = New System.Drawing.Point(464, 95)
        Me.TbNumeric10.Name = "TbNumeric10"
        Me.TbNumeric10.ReadOnly = True
        Me.TbNumeric10.Size = New System.Drawing.Size(98, 20)
        Me.TbNumeric10.TabIndex = 90
        Me.TbNumeric10.TabStop = False
        '
        'TbNumeric9
        '
        Me.TbNumeric9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNumeric9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "DebitReelRND", True))
        Me.TbNumeric9.ForceBindingOnTextChanged = False
        Me.TbNumeric9.Location = New System.Drawing.Point(223, 95)
        Me.TbNumeric9.Name = "TbNumeric9"
        Me.TbNumeric9.ReadOnly = True
        Me.TbNumeric9.Size = New System.Drawing.Size(100, 20)
        Me.TbNumeric9.TabIndex = 88
        Me.TbNumeric9.TabStop = False
        '
        'TbNumeric1
        '
        Me.TbNumeric1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbNumeric1.BackColor = System.Drawing.Color.White
        Me.TbNumeric1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NbBuses", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, ""))
        Me.TbNumeric1.ForceBindingOnTextChanged = False
        Me.TbNumeric1.Location = New System.Drawing.Point(464, 69)
        Me.TbNumeric1.Name = "TbNumeric1"
        Me.TbNumeric1.Size = New System.Drawing.Size(98, 20)
        Me.TbNumeric1.TabIndex = 86
        '
        'TbNumeric2
        '
        Me.TbNumeric2.BackColor = System.Drawing.Color.White
        Me.TbNumeric2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "PressionMoyenne", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, ""))
        Me.TbNumeric2.ForceBindingOnTextChanged = False
        Me.TbNumeric2.Location = New System.Drawing.Point(223, 69)
        Me.TbNumeric2.Name = "TbNumeric2"
        Me.TbNumeric2.Size = New System.Drawing.Size(100, 20)
        Me.TbNumeric2.TabIndex = 84
        '
        'TbNumeric8
        '
        Me.TbNumeric8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbNumeric8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TbNumeric8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "debitMesure", True))
        Me.TbNumeric8.ForceBindingOnTextChanged = False
        Me.TbNumeric8.Location = New System.Drawing.Point(464, 43)
        Me.TbNumeric8.Name = "TbNumeric8"
        Me.TbNumeric8.ReadOnly = True
        Me.TbNumeric8.Size = New System.Drawing.Size(98, 20)
        Me.TbNumeric8.TabIndex = 6
        Me.TbNumeric8.TabStop = False
        '
        'TbNumeric7
        '
        Me.TbNumeric7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TbNumeric7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbNumeric7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "PressionMesure", True))
        Me.TbNumeric7.ForceBindingOnTextChanged = False
        Me.TbNumeric7.Location = New System.Drawing.Point(223, 43)
        Me.TbNumeric7.Name = "TbNumeric7"
        Me.TbNumeric7.ReadOnly = True
        Me.TbNumeric7.Size = New System.Drawing.Size(100, 20)
        Me.TbNumeric7.TabIndex = 5
        Me.TbNumeric7.TabStop = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.DataPropertyName = "numero"
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Num"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 30
        '
        'Image
        '
        Me.Image.DataPropertyName = "Image"
        Me.Image.HeaderText = ""
        Me.Image.Name = "Image"
        '
        'DebitReelRNDDataGridViewTextBoxColumn
        '
        Me.DebitReelRNDDataGridViewTextBoxColumn.DataPropertyName = "DebitReelRND"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DebitReelRNDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DebitReelRNDDataGridViewTextBoxColumn.HeaderText = "Debit réel (l/min)"
        Me.DebitReelRNDDataGridViewTextBoxColumn.Name = "DebitReelRNDDataGridViewTextBoxColumn"
        Me.DebitReelRNDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitTotalRNDDataGridViewTextBoxColumn
        '
        Me.DebitTotalRNDDataGridViewTextBoxColumn.DataPropertyName = "DebitTotalRND"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DebitTotalRNDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DebitTotalRNDDataGridViewTextBoxColumn.HeaderText = "Débit total (l/min)"
        Me.DebitTotalRNDDataGridViewTextBoxColumn.Name = "DebitTotalRNDDataGridViewTextBoxColumn"
        Me.DebitTotalRNDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReglageDispositifDataGridViewTextBoxColumn
        '
        Me.ReglageDispositifDataGridViewTextBoxColumn.DataPropertyName = "ReglageDispositif"
        Me.ReglageDispositifDataGridViewTextBoxColumn.HeaderText = "Réglage dispo. dosage (%) "
        Me.ReglageDispositifDataGridViewTextBoxColumn.Name = "ReglageDispositifDataGridViewTextBoxColumn"
        '
        'DebitTheoriqueDataGridViewTextBoxColumn
        '
        Me.DebitTheoriqueDataGridViewTextBoxColumn.DataPropertyName = "DebitTheorique"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DebitTheoriqueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DebitTheoriqueDataGridViewTextBoxColumn.HeaderText = "Debit théo (L)"
        Me.DebitTheoriqueDataGridViewTextBoxColumn.Name = "DebitTheoriqueDataGridViewTextBoxColumn"
        Me.DebitTheoriqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TempsMesureDataGridViewTextBoxColumn
        '
        Me.TempsMesureDataGridViewTextBoxColumn.DataPropertyName = "TempsMesure"
        Me.TempsMesureDataGridViewTextBoxColumn.HeaderText = "Temps mesure(s)"
        Me.TempsMesureDataGridViewTextBoxColumn.Name = "TempsMesureDataGridViewTextBoxColumn"
        '
        'QteEauPulveriseeRNDDataGridViewTextBoxColumn
        '
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn.DataPropertyName = "QteEauPulveriseeRND"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn.HeaderText = "Qte eau pulvé."
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn.Name = "QteEauPulveriseeRNDDataGridViewTextBoxColumn"
        Me.QteEauPulveriseeRNDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MasseApresAspiDataGridViewTextBoxColumn
        '
        Me.MasseApresAspiDataGridViewTextBoxColumn.DataPropertyName = "MasseApresAspi"
        Me.MasseApresAspiDataGridViewTextBoxColumn.HeaderText = "Masse init (+) (kg)"
        Me.MasseApresAspiDataGridViewTextBoxColumn.Name = "MasseApresAspiDataGridViewTextBoxColumn"
        Me.MasseApresAspiDataGridViewTextBoxColumn.ToolTipText = "Masse initiale (+) (kg)"
        '
        'MasseApresComplementDataGridViewTextBoxColumn
        '
        Me.MasseApresComplementDataGridViewTextBoxColumn.DataPropertyName = "MasseApresComplement"
        Me.MasseApresComplementDataGridViewTextBoxColumn.HeaderText = "Masse aspi. (-) (kg)"
        Me.MasseApresComplementDataGridViewTextBoxColumn.Name = "MasseApresComplementDataGridViewTextBoxColumn"
        Me.MasseApresComplementDataGridViewTextBoxColumn.ToolTipText = "Masse aspirée (-) (kg)"
        '
        'QteProduitConsoDataGridViewTextBoxColumn
        '
        Me.QteProduitConsoDataGridViewTextBoxColumn.DataPropertyName = "QteProduitConso"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.QteProduitConsoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QteProduitConsoDataGridViewTextBoxColumn.HeaderText = "Produit conso."
        Me.QteProduitConsoDataGridViewTextBoxColumn.Name = "QteProduitConsoDataGridViewTextBoxColumn"
        Me.QteProduitConsoDataGridViewTextBoxColumn.ReadOnly = True
        Me.QteProduitConsoDataGridViewTextBoxColumn.ToolTipText = "Quantité de produit consomée (kg)"
        '
        'DosageReelDataGridViewTextBoxColumn
        '
        Me.DosageReelDataGridViewTextBoxColumn.DataPropertyName = "DosageReel"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DosageReelDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DosageReelDataGridViewTextBoxColumn.HeaderText = "Dos. réel (%)"
        Me.DosageReelDataGridViewTextBoxColumn.Name = "DosageReelDataGridViewTextBoxColumn"
        Me.DosageReelDataGridViewTextBoxColumn.ReadOnly = True
        Me.DosageReelDataGridViewTextBoxColumn.ToolTipText = "Dosage réel (%)"
        '
        'EcartReglageRNDDataGridViewTextBoxColumn
        '
        Me.EcartReglageRNDDataGridViewTextBoxColumn.DataPropertyName = "EcartReglageRND"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.EcartReglageRNDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.EcartReglageRNDDataGridViewTextBoxColumn.HeaderText = "Ecart (%)"
        Me.EcartReglageRNDDataGridViewTextBoxColumn.Name = "EcartReglageRNDDataGridViewTextBoxColumn"
        Me.EcartReglageRNDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EcartReglageRNDDataGridViewTextBoxColumn.ToolTipText = "Ecart de réglage (%)"
        '
        'ResultatDataGridViewTextBoxColumn
        '
        Me.ResultatDataGridViewTextBoxColumn.DataPropertyName = "Resultat"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Olive
        Me.ResultatDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ResultatDataGridViewTextBoxColumn.HeaderText = "Resultat"
        Me.ResultatDataGridViewTextBoxColumn.Name = "ResultatDataGridViewTextBoxColumn"
        Me.ResultatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'm_bsrcMesures
        '
        Me.m_bsrcMesures.DataSource = GetType(Crodip_agent.DiagnosticHelp12123Mesures)
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(Crodip_agent.DiagnosticHelp12123)
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.listImg_flags
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "Nœud1"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "Mesure1"
        TreeNode2.ImageIndex = 0
        TreeNode2.Name = "Nœud2"
        TreeNode2.SelectedImageIndex = 0
        TreeNode2.Text = "Mesure2"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Nœud3"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Mesure3"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "Nœud0"
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Text = "Pompe1"
        TreeNode5.ImageIndex = 0
        TreeNode5.Name = "Nœud5"
        TreeNode5.SelectedImageIndex = 0
        TreeNode5.Text = "Mesure1"
        TreeNode6.ImageIndex = 3
        TreeNode6.Name = "Nœud6"
        TreeNode6.SelectedImageIndex = 2
        TreeNode6.Text = "Mesure2"
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = "Nœud7"
        TreeNode7.SelectedImageIndex = 2
        TreeNode7.Text = "Mesure3"
        TreeNode8.Name = "Nœud4"
        TreeNode8.Text = "Pompe2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowPlusMinus = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(101, 411)
        Me.TreeView1.TabIndex = 77
        '
        'diagnostic_dlghelp12123new
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 526)
        Me.Controls.Add(Me.pnl12123)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "diagnostic_dlghelp12123new"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.pnl12123.ResumeLayout(False)
        Me.pnl12123.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlDetailPompe.ResumeLayout(False)
        Me.pnlDetailPompe.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsrcMesures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents pnl12123 As System.Windows.Forms.Panel
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModele_validerNbBuses As System.Windows.Forms.Label
    Friend WithEvents listImg_flags As System.Windows.Forms.ImageList
    Friend WithEvents lblResultat12123 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlDetailPompe As System.Windows.Forms.Panel
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TbNumeric8 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents TbNumeric7 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TbNumeric10 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TbNumeric9 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TbNumeric1 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbNumeric2 As CRODIP_ControlLibrary.TBNumeric
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents m_bsrcMesures As System.Windows.Forms.BindingSource
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitReelRNDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitTotalRNDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReglageDispositifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitTheoriqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempsMesureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QteEauPulveriseeRNDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasseApresAspiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasseApresComplementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QteProduitConsoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosageReelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EcartReglageRNDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class