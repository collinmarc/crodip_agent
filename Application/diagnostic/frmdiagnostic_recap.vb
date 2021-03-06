'Imports iTextSharp
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
'Imports iTextSharp.text.xml
Imports System.IO
Imports System.Globalization

Public Class frmdiagnostic_recap
    Inherits frmCRODIP
#Region " Variables "
    Private bTest As Boolean = False
    Private m_DiagMode As Globals.DiagMode
    Private m_diagnostic As Diagnostic
    Private m_Exploit As Exploitation
    Private m_Pulverisateur As Pulverisateur
    Dim isValider As Boolean = False
    Dim conclusionDiagnostique As Globals.enumConclusionDiag
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grpOrganisme As System.Windows.Forms.GroupBox
    Friend WithEvents diagnosticRecap_organisme_dateControle As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents diagnosticRecap_organisme_heureDebut As System.Windows.Forms.TextBox
    Friend WithEvents diagnosticRecap_organisme_heureFin As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents grpProprio As System.Windows.Forms.GroupBox
    Friend WithEvents btn_voirFicheExploitant As System.Windows.Forms.Label
    Friend WithEvents grpMateriel As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_diagnosticRecap_materiel_EmplacementIdentification As System.Windows.Forms.ComboBox
    Friend WithEvents btn_voirFiche_Pulve As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents rtbCommentaire As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAppercu As System.Windows.Forms.Label
    Friend WithEvents rbEtatSM As System.Windows.Forms.RadioButton
    Friend WithEvents rbEtatRI As System.Windows.Forms.RadioButton
    Friend WithEvents m_bsDiag As System.Windows.Forms.BindingSource
    Friend WithEvents btn_finalisationDiag_imprimerSynthese As System.Windows.Forms.Label
    'Private objInfos(15) As Object

#End Region

#Region " Code g�n�r� par le Concepteur Windows Form "

    Private Sub New()
        MyBase.New()

        'objInfos = _objInfos

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()

    End Sub

    Public Sub New(pDiagMode As Globals.DiagMode, pDiag As Diagnostic, pPulve As Pulverisateur, pExploit As Exploitation)
        MyBase.New()
        m_DiagMode = pDiagMode

        m_diagnostic = pDiag
        m_Pulverisateur = pPulve
        m_Exploit = pExploit

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()
        m_bsDiag.Add(m_diagnostic)
    End Sub
    Public Sub setbTest(Optional pTest As Boolean = True)
        bTest = pTest
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList_Etat As System.Windows.Forms.ImageList
    Private WithEvents btn_finalisationDiag_valider As System.Windows.Forms.Label
    Friend WithEvents btn_finalisationDiag_imprimerRapport As System.Windows.Forms.Label
    Friend WithEvents btn_finalisationDiag_modifierDiag As System.Windows.Forms.Label
    Friend WithEvents label_pulveBonEtat As System.Windows.Forms.Label
    Friend WithEvents conclusion_pictoEtat As System.Windows.Forms.PictureBox
    '    Friend WithEvents cr_debitBuses As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdiagnostic_recap))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.conclusion_pictoEtat = New System.Windows.Forms.PictureBox()
        Me.label_pulveBonEtat = New System.Windows.Forms.Label()
        Me.ImageList_Etat = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_finalisationDiag_valider = New System.Windows.Forms.Label()
        Me.btn_finalisationDiag_imprimerRapport = New System.Windows.Forms.Label()
        Me.btn_finalisationDiag_modifierDiag = New System.Windows.Forms.Label()
        Me.btn_finalisationDiag_imprimerSynthese = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rbEtatSM = New System.Windows.Forms.RadioButton()
        Me.rbEtatRI = New System.Windows.Forms.RadioButton()
        Me.btnAppercu = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rtbCommentaire = New System.Windows.Forms.RichTextBox()
        Me.m_bsDiag = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpMateriel = New System.Windows.Forms.GroupBox()
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification = New System.Windows.Forms.ComboBox()
        Me.btn_voirFiche_Pulve = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.grpProprio = New System.Windows.Forms.GroupBox()
        Me.btn_voirFicheExploitant = New System.Windows.Forms.Label()
        Me.grpOrganisme = New System.Windows.Forms.GroupBox()
        Me.diagnosticRecap_organisme_dateControle = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.diagnosticRecap_organisme_heureDebut = New System.Windows.Forms.TextBox()
        Me.diagnosticRecap_organisme_heureFin = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.conclusion_pictoEtat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.m_bsDiag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMateriel.SuspendLayout()
        Me.grpProprio.SuspendLayout()
        Me.grpOrganisme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "     Visualisation du contr�le"
        '
        'conclusion_pictoEtat
        '
        Me.conclusion_pictoEtat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conclusion_pictoEtat.Image = CType(resources.GetObject("conclusion_pictoEtat.Image"), System.Drawing.Image)
        Me.conclusion_pictoEtat.Location = New System.Drawing.Point(571, 632)
        Me.conclusion_pictoEtat.Name = "conclusion_pictoEtat"
        Me.conclusion_pictoEtat.Size = New System.Drawing.Size(16, 16)
        Me.conclusion_pictoEtat.TabIndex = 13
        Me.conclusion_pictoEtat.TabStop = False
        '
        'label_pulveBonEtat
        '
        Me.label_pulveBonEtat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_pulveBonEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_pulveBonEtat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label_pulveBonEtat.Location = New System.Drawing.Point(587, 629)
        Me.label_pulveBonEtat.Name = "label_pulveBonEtat"
        Me.label_pulveBonEtat.Size = New System.Drawing.Size(311, 24)
        Me.label_pulveBonEtat.TabIndex = 12
        Me.label_pulveBonEtat.Text = "Pulv�risateur en bon �tat"
        Me.label_pulveBonEtat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList_Etat
        '
        Me.ImageList_Etat.ImageStream = CType(resources.GetObject("ImageList_Etat.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Etat.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Etat.Images.SetKeyName(0, "")
        Me.ImageList_Etat.Images.SetKeyName(1, "")
        '
        'btn_finalisationDiag_valider
        '
        Me.btn_finalisationDiag_valider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_finalisationDiag_valider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalisationDiag_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalisationDiag_valider.ForeColor = System.Drawing.Color.White
        Me.btn_finalisationDiag_valider.Image = CType(resources.GetObject("btn_finalisationDiag_valider.Image"), System.Drawing.Image)
        Me.btn_finalisationDiag_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_finalisationDiag_valider.Location = New System.Drawing.Point(862, 629)
        Me.btn_finalisationDiag_valider.Name = "btn_finalisationDiag_valider"
        Me.btn_finalisationDiag_valider.Size = New System.Drawing.Size(134, 24)
        Me.btn_finalisationDiag_valider.TabIndex = 9
        Me.btn_finalisationDiag_valider.Text = "    Valider"
        Me.btn_finalisationDiag_valider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_finalisationDiag_imprimerRapport
        '
        Me.btn_finalisationDiag_imprimerRapport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_finalisationDiag_imprimerRapport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalisationDiag_imprimerRapport.Enabled = False
        Me.btn_finalisationDiag_imprimerRapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalisationDiag_imprimerRapport.ForeColor = System.Drawing.Color.White
        Me.btn_finalisationDiag_imprimerRapport.Image = CType(resources.GetObject("btn_finalisationDiag_imprimerRapport.Image"), System.Drawing.Image)
        Me.btn_finalisationDiag_imprimerRapport.Location = New System.Drawing.Point(194, 629)
        Me.btn_finalisationDiag_imprimerRapport.Name = "btn_finalisationDiag_imprimerRapport"
        Me.btn_finalisationDiag_imprimerRapport.Size = New System.Drawing.Size(184, 24)
        Me.btn_finalisationDiag_imprimerRapport.TabIndex = 7
        Me.btn_finalisationDiag_imprimerRapport.Text = "      Imprimer le rapport"
        Me.btn_finalisationDiag_imprimerRapport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_finalisationDiag_modifierDiag
        '
        Me.btn_finalisationDiag_modifierDiag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_finalisationDiag_modifierDiag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalisationDiag_modifierDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalisationDiag_modifierDiag.ForeColor = System.Drawing.Color.White
        Me.btn_finalisationDiag_modifierDiag.Image = CType(resources.GetObject("btn_finalisationDiag_modifierDiag.Image"), System.Drawing.Image)
        Me.btn_finalisationDiag_modifierDiag.Location = New System.Drawing.Point(5, 629)
        Me.btn_finalisationDiag_modifierDiag.Name = "btn_finalisationDiag_modifierDiag"
        Me.btn_finalisationDiag_modifierDiag.Size = New System.Drawing.Size(184, 24)
        Me.btn_finalisationDiag_modifierDiag.TabIndex = 6
        Me.btn_finalisationDiag_modifierDiag.Text = "       Modifier le contr�le"
        Me.btn_finalisationDiag_modifierDiag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_finalisationDiag_imprimerSynthese
        '
        Me.btn_finalisationDiag_imprimerSynthese.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_finalisationDiag_imprimerSynthese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalisationDiag_imprimerSynthese.Enabled = False
        Me.btn_finalisationDiag_imprimerSynthese.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalisationDiag_imprimerSynthese.ForeColor = System.Drawing.Color.White
        Me.btn_finalisationDiag_imprimerSynthese.Image = CType(resources.GetObject("btn_finalisationDiag_imprimerSynthese.Image"), System.Drawing.Image)
        Me.btn_finalisationDiag_imprimerSynthese.Location = New System.Drawing.Point(381, 629)
        Me.btn_finalisationDiag_imprimerSynthese.Name = "btn_finalisationDiag_imprimerSynthese"
        Me.btn_finalisationDiag_imprimerSynthese.Size = New System.Drawing.Size(184, 24)
        Me.btn_finalisationDiag_imprimerSynthese.TabIndex = 8
        Me.btn_finalisationDiag_imprimerSynthese.Text = "      Synth�se des mesures"
        Me.btn_finalisationDiag_imprimerSynthese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbEtatSM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbEtatRI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAppercu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rtbCommentaire)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpMateriel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpProprio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpOrganisme)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer1.Size = New System.Drawing.Size(986, 571)
        Me.SplitContainer1.SplitterDistance = 626
        Me.SplitContainer1.TabIndex = 14
        '
        'rbEtatSM
        '
        Me.rbEtatSM.AutoSize = True
        Me.rbEtatSM.Location = New System.Drawing.Point(175, 12)
        Me.rbEtatSM.Name = "rbEtatSM"
        Me.rbEtatSM.Size = New System.Drawing.Size(131, 17)
        Me.rbEtatSM.TabIndex = 2
        Me.rbEtatSM.Text = "Synth�se des mesures"
        Me.rbEtatSM.UseVisualStyleBackColor = True
        '
        'rbEtatRI
        '
        Me.rbEtatRI.AutoSize = True
        Me.rbEtatRI.Checked = True
        Me.rbEtatRI.Location = New System.Drawing.Point(24, 12)
        Me.rbEtatRI.Name = "rbEtatRI"
        Me.rbEtatRI.Size = New System.Drawing.Size(122, 17)
        Me.rbEtatRI.TabIndex = 1
        Me.rbEtatRI.TabStop = True
        Me.rbEtatRI.Text = "Rapport d'inspection"
        Me.rbEtatRI.UseVisualStyleBackColor = True
        '
        'btnAppercu
        '
        Me.btnAppercu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAppercu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppercu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppercu.ForeColor = System.Drawing.Color.White
        Me.btnAppercu.Image = Global.Crodip_agent.Resources.btn_refresh
        Me.btnAppercu.Location = New System.Drawing.Point(423, 8)
        Me.btnAppercu.Name = "btnAppercu"
        Me.btnAppercu.Size = New System.Drawing.Size(200, 24)
        Me.btnAppercu.TabIndex = 5
        Me.btnAppercu.Text = "    Aper�u"
        Me.btnAppercu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 42)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        ' Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(626, 529)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rtbCommentaire
        '
        Me.rtbCommentaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCommentaire.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsDiag, "Commentaire", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rtbCommentaire.Location = New System.Drawing.Point(6, 307)
        Me.rtbCommentaire.Name = "rtbCommentaire"
        Me.rtbCommentaire.Size = New System.Drawing.Size(341, 226)
        Me.rtbCommentaire.TabIndex = 63
        Me.rtbCommentaire.Text = ""
        '
        'm_bsDiag
        '
        Me.m_bsDiag.DataSource = GetType(Crodip_agent.Diagnostic)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Commentaire :"
        '
        'grpMateriel
        '
        Me.grpMateriel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMateriel.Controls.Add(Me.cbx_diagnosticRecap_materiel_EmplacementIdentification)
        Me.grpMateriel.Controls.Add(Me.btn_voirFiche_Pulve)
        Me.grpMateriel.Controls.Add(Me.Label38)
        Me.grpMateriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMateriel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpMateriel.Location = New System.Drawing.Point(6, 156)
        Me.grpMateriel.Name = "grpMateriel"
        Me.grpMateriel.Size = New System.Drawing.Size(347, 106)
        Me.grpMateriel.TabIndex = 4
        Me.grpMateriel.TabStop = False
        Me.grpMateriel.Text = "Mat�riel"
        '
        'cbx_diagnosticRecap_materiel_EmplacementIdentification
        '
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.FormattingEnabled = True
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.Location = New System.Drawing.Point(6, 40)
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.Name = "cbx_diagnosticRecap_materiel_EmplacementIdentification"
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.Size = New System.Drawing.Size(335, 21)
        Me.cbx_diagnosticRecap_materiel_EmplacementIdentification.TabIndex = 68
        '
        'btn_voirFiche_Pulve
        '
        Me.btn_voirFiche_Pulve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_voirFiche_Pulve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voirFiche_Pulve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voirFiche_Pulve.ForeColor = System.Drawing.Color.White
        Me.btn_voirFiche_Pulve.Image = CType(resources.GetObject("btn_voirFiche_Pulve.Image"), System.Drawing.Image)
        Me.btn_voirFiche_Pulve.Location = New System.Drawing.Point(211, 79)
        Me.btn_voirFiche_Pulve.Name = "btn_voirFiche_Pulve"
        Me.btn_voirFiche_Pulve.Size = New System.Drawing.Size(128, 24)
        Me.btn_voirFiche_Pulve.TabIndex = 1
        Me.btn_voirFiche_Pulve.Text = "    Voir la fiche"
        Me.btn_voirFiche_Pulve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(8, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(195, 13)
        Me.Label38.TabIndex = 60
        Me.Label38.Text = "Emplacement de l'identification : "
        '
        'grpProprio
        '
        Me.grpProprio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProprio.Controls.Add(Me.btn_voirFicheExploitant)
        Me.grpProprio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProprio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpProprio.Location = New System.Drawing.Point(6, 100)
        Me.grpProprio.Name = "grpProprio"
        Me.grpProprio.Size = New System.Drawing.Size(345, 50)
        Me.grpProprio.TabIndex = 3
        Me.grpProprio.TabStop = False
        Me.grpProprio.Text = "Propri�taire du mat�riel"
        '
        'btn_voirFicheExploitant
        '
        Me.btn_voirFicheExploitant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_voirFicheExploitant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voirFicheExploitant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voirFicheExploitant.ForeColor = System.Drawing.Color.White
        Me.btn_voirFicheExploitant.Image = CType(resources.GetObject("btn_voirFicheExploitant.Image"), System.Drawing.Image)
        Me.btn_voirFicheExploitant.Location = New System.Drawing.Point(211, 16)
        Me.btn_voirFicheExploitant.Name = "btn_voirFicheExploitant"
        Me.btn_voirFicheExploitant.Size = New System.Drawing.Size(128, 24)
        Me.btn_voirFicheExploitant.TabIndex = 0
        Me.btn_voirFicheExploitant.Text = "    Voir la fiche"
        Me.btn_voirFicheExploitant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpOrganisme
        '
        Me.grpOrganisme.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrganisme.Controls.Add(Me.diagnosticRecap_organisme_dateControle)
        Me.grpOrganisme.Controls.Add(Me.Label16)
        Me.grpOrganisme.Controls.Add(Me.Label17)
        Me.grpOrganisme.Controls.Add(Me.diagnosticRecap_organisme_heureDebut)
        Me.grpOrganisme.Controls.Add(Me.diagnosticRecap_organisme_heureFin)
        Me.grpOrganisme.Controls.Add(Me.Label19)
        Me.grpOrganisme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrganisme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpOrganisme.Location = New System.Drawing.Point(2, 19)
        Me.grpOrganisme.Name = "grpOrganisme"
        Me.grpOrganisme.Size = New System.Drawing.Size(345, 75)
        Me.grpOrganisme.TabIndex = 2
        Me.grpOrganisme.TabStop = False
        Me.grpOrganisme.Text = "Organisme d'inspection"
        '
        'diagnosticRecap_organisme_dateControle
        '
        Me.diagnosticRecap_organisme_dateControle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagnosticRecap_organisme_dateControle.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.diagnosticRecap_organisme_dateControle.Location = New System.Drawing.Point(139, 23)
        Me.diagnosticRecap_organisme_dateControle.Name = "diagnosticRecap_organisme_dateControle"
        Me.diagnosticRecap_organisme_dateControle.Size = New System.Drawing.Size(129, 20)
        Me.diagnosticRecap_organisme_dateControle.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(11, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Date du contr�le : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(1, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 16)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Heure d�but / fin : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'diagnosticRecap_organisme_heureDebut
        '
        Me.diagnosticRecap_organisme_heureDebut.Location = New System.Drawing.Point(139, 49)
        Me.diagnosticRecap_organisme_heureDebut.Name = "diagnosticRecap_organisme_heureDebut"
        Me.diagnosticRecap_organisme_heureDebut.Size = New System.Drawing.Size(56, 20)
        Me.diagnosticRecap_organisme_heureDebut.TabIndex = 1
        '
        'diagnosticRecap_organisme_heureFin
        '
        Me.diagnosticRecap_organisme_heureFin.Location = New System.Drawing.Point(211, 49)
        Me.diagnosticRecap_organisme_heureFin.Name = "diagnosticRecap_organisme_heureFin"
        Me.diagnosticRecap_organisme_heureFin.Size = New System.Drawing.Size(56, 20)
        Me.diagnosticRecap_organisme_heureFin.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(196, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 16)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "/"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmdiagnostic_recapV6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1008, 679)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btn_finalisationDiag_valider)
        Me.Controls.Add(Me.btn_finalisationDiag_imprimerSynthese)
        Me.Controls.Add(Me.label_pulveBonEtat)
        Me.Controls.Add(Me.btn_finalisationDiag_modifierDiag)
        Me.Controls.Add(Me.btn_finalisationDiag_imprimerRapport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.conclusion_pictoEtat)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdiagnostic_recapV6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "diagnostic_recap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.conclusion_pictoEtat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.m_bsDiag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMateriel.ResumeLayout(False)
        Me.grpMateriel.PerformLayout()
        Me.grpProprio.ResumeLayout(False)
        Me.grpOrganisme.ResumeLayout(False)
        Me.grpOrganisme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub diagnostic_recap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Propri�t� a mettre obligatoirement par programme
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        CSEnvironnement.checkDateTimePicker(diagnosticRecap_organisme_dateControle)

        '###########################################################################
        '########               Chargement Organisme d'inspection           ########
        '###########################################################################
        Try
            diagnosticRecap_organisme_dateControle.Text = CDate(m_diagnostic.controleDateDebut).ToShortDateString()
            diagnosticRecap_organisme_heureDebut.Text = CDate(m_diagnostic.controleDateDebut).ToShortTimeString
            m_diagnostic.controleDateFin = CSDate.mysql2access(Date.Now)
            diagnosticRecap_organisme_heureFin.Text = CDate(m_diagnostic.controleDateFin).ToShortTimeString
        Catch ex As Exception
            CSDebug.dispError("Contr�le R�cap - Chargement Organisme d'inspection : " & ex.Message.ToString)
        End Try

        '###########################################################################
        '########             Chargement Propri�taire du materiel           ########
        '###########################################################################
        AfficheProprietaire()
        '###########################################################################
        '########                   Chargement contexte controle            ########
        '###########################################################################

        '###########################################################################
        '########                     Chargement Materiel                   ########
        '###########################################################################
        AffichePulverisateur()

        For Each tmpDiagnosticItem As DiagnosticItem In m_diagnostic.diagnosticItemsLst.items
            If Not tmpDiagnosticItem Is Nothing Then
                If Not tmpDiagnosticItem.itemCodeEtat Is Nothing Then
                    ' Si on a un code �tat diff�rent de OK, on l'affiche dans le bilan
                    If tmpDiagnosticItem.itemCodeEtat <> DiagnosticItem.EtatDiagItemOK Then

                        If tmpDiagnosticItem.itemCodeEtat = DiagnosticItem.EtatDiagItemMINEUR Then
                            'Mineur
                            If conclusionDiagnostique = Globals.enumConclusionDiag.OK Then
                                conclusionDiagnostique = Globals.enumConclusionDiag.OK_AVECMINEEUR
                            End If
                        End If
                        If tmpDiagnosticItem.itemCodeEtat = DiagnosticItem.EtatDiagItemMAJEUR Then
                            'Majeur
                            conclusionDiagnostique = Globals.enumConclusionDiag.NOK
                        End If
                        If tmpDiagnosticItem.itemCodeEtat = DiagnosticItem.EtatDiagItemMAJPRELIM Then
                            'Majeur Prelim
                            conclusionDiagnostique = Globals.enumConclusionDiag.NOK_PRELIM
                        End If
                    End If

                End If
            End If
        Next


        ' Conclusion sur l'etat du controle
        Select Case conclusionDiagnostique
            Case Globals.enumConclusionDiag.OK
                m_diagnostic.controleEtat = Diagnostic.controleEtatOK
                conclusion_pictoEtat.Image = ImageList_Etat.Images.Item(1)
                label_pulveBonEtat.Text = "Pulv�risateur en bon �tat"
            Case Globals.enumConclusionDiag.OK_AVECMINEEUR
                conclusion_pictoEtat.Image = ImageList_Etat.Images.Item(1)
                m_diagnostic.controleEtat = Diagnostic.controleEtatOK
                label_pulveBonEtat.Text = "Pulv�risateur en bon �tat"
            Case Globals.enumConclusionDiag.NOK
                conclusion_pictoEtat.Image = ImageList_Etat.Images.Item(0)
                m_diagnostic.controleEtat = Diagnostic.controleEtatNOKCV
                label_pulveBonEtat.Text = "D�faut(s) sur le pulv�risateur"
            Case Globals.enumConclusionDiag.NOK_PRELIM
                conclusion_pictoEtat.Image = ImageList_Etat.Images.Item(0)
                m_diagnostic.controleEtat = Diagnostic.controleEtatNOKCC
                label_pulveBonEtat.Text = "D�faut(s) sur le pulv�risateur"
            Case Else
                conclusion_pictoEtat.Image = ImageList_Etat.Images.Item(0)
                m_diagnostic.controleEtat = Diagnostic.controleEtatNOKCV
                label_pulveBonEtat.Text = "D�faut(s) sur le pulv�risateur"

        End Select
        'Me.SelectNextControl(diagnosticRecap_organisme_lieuControle, True, True, True, True)
        btn_finalisationDiag_modifierDiag.Focus()
        btn_finalisationDiag_modifierDiag.Select()
        If m_DiagMode = Globals.DiagMode.CTRL_VISU Then
            grpOrganisme.Enabled = False
            grpProprio.Enabled = False
            grpMateriel.Enabled = False
            btn_finalisationDiag_modifierDiag.Enabled = False
            btn_finalisationDiag_valider.Text = "Retour"
        End If
        btn_finalisationDiag_modifierDiag.Enabled = m_DiagMode <> Globals.DiagMode.CTRL_VISU

        '##################
        'Generation de l'apper�u du rapport
        '###################

        createRapportInspection_cr(False)


    End Sub

    Private Sub AffichePulverisateur()
        Try
            MarquesManager.populateCombobox(Globals.GLOB_XML_EMPLACEMENTIDENTIFICATION, cbx_diagnosticRecap_materiel_EmplacementIdentification, "/root", True)
            'diagnosticRecap_materiel_identifiant.Text = m_Pulverisateur.numeroNational
            'diagnosticRecap_materiel_marque.Text = m_diagnostic.pulverisateurMarque
            'diagnosticRecap_materiel_modele.Text = m_diagnostic.pulverisateurModele
            'Categorie
            'diagnosticRecap_materiel_type.Text = m_diagnostic.pulverisateurType
            'diagnosticRecap_materiel_categorie.Text = m_diagnostic.pulverisateurCategorie
            'Emplacement Identification
            cbx_diagnosticRecap_materiel_EmplacementIdentification.Text = m_diagnostic.pulverisateurEmplacementIdentification



        Catch ex As Exception
            CSDebug.dispError("Contr�le R�cap.AffichePulveristeur ERR : " & ex.Message.ToString)
        End Try


    End Sub
    ' Modifier le diag
    Private Sub btn_finalisationDiag_modifierDiag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalisationDiag_modifierDiag.Click
        If MdiParent Is Nothing Then
            'En cas de tests
            Close()
            Exit Sub
        End If
        'R�cup�ration des infos de la fen�tre
        GetInfos()
        Dim ofrmDiag As Form = Nothing
        If m_diagnostic.controleEtat <> Diagnostic.controleEtatNOKCC Then
            'Activation de la fen�tre
            For Each oForm As Form In MdiParent.MdiChildren
                If TypeOf oForm Is frmDiagnostique Then
                    ofrmDiag = oForm
                    Exit For
                End If
            Next
        Else
            For Each oForm As Form In MdiParent.MdiChildren
                If TypeOf oForm Is controle_preliminaire Then
                    ofrmDiag = oForm
                    Exit For
                End If
            Next
        End If
        If ofrmDiag IsNot Nothing Then
            ofrmDiag.WindowState = FormWindowState.Maximized
            ofrmDiag.Activate()
            Me.Close()
        End If
    End Sub

    ' Validation
    Private Sub btn_finalisationDiag_valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalisationDiag_valider.Click
        sender.Enabled = False
        If m_DiagMode = Globals.DiagMode.CTRL_VISU Then
            CloseDiagnostic()
            Exit Sub
        End If
        If isValider Then

            Try

                ' On rempli l'objet d'infos
                'objInfos(7) = diagnosticCourant.pulverisateurLargeur
                'objInfos(8) = diagnosticCourant.buseNbBuses

                ' On ouvre le form
                Dim ofrm As New diagnostic_satisfaction(m_diagnostic)
                TryCast(Me.MdiParent, parentContener).DisplayForm(ofrm)

                Statusbar.clear()
            Catch ex As Exception
                CSDebug.dispError("diag_recap::btn_finalisationDiag_valider_Click 1 : " & ex.Message)
            End Try
            Try
                If Not globFormDiagnostic Is Nothing Then
                    CSDebug.dispInfo("Closing globFormDiagnostic")
                    globFormDiagnostic.Close()
                End If
                If Not globFormControlePreliminaire Is Nothing Then
                    globFormControlePreliminaire.Close()
                End If
            Catch ex As Exception
                CSDebug.dispError("diag_recap::btn_finalisationDiag_valider_Click 2 : " & ex.Message)
            End Try
            Try
                globFormAccueil.loadListPulveExploitation(False)
            Catch ex As Exception
                CSDebug.dispError("Diag. Recap - Reloading list pulv� : Error")
            End Try
            Me.Close()
        Else
            If checkForm() Then
                If MsgBox("Attention, la validation du contr�le est d�finitive, vous ne pourrez plus revenir en arri�re. Etes-vous s�r ?", MsgBoxStyle.YesNo, "Validation du contr�le") = MsgBoxResult.Yes Then
                    diagnosticRecap_organisme_heureDebut.Enabled = False
                    diagnosticRecap_organisme_heureFin.Enabled = False
                    cbx_diagnosticRecap_materiel_EmplacementIdentification.Enabled = False
                    diagnosticRecap_organisme_dateControle.Enabled = False
                    SauvegarderDiagnostic()
                    MsgBox("Vous pouvez maintenant imprimer le rapport.", MsgBoxStyle.Information)
                End If
            End If


            sender.Enabled = True
        End If
    End Sub
    Private Function SauvegarderDiagnostic() As Boolean
        Dim bReturn As Boolean
        Try
            Try
                Statusbar.display(Globals.CONST_STATUTMSG_DIAG_SAVING, True)
                'Lecture de la fen�tre
                GetInfos()
                '
                'Calcul de la date de prochain controle
                m_diagnostic.CalculDateProchainControle()

                Statusbar.display("Mise � jour de l'exploitant", True)
                m_Exploit.numeroSiren = m_diagnostic.proprietaireNumeroSiren
                m_Exploit.dateDernierControle = m_diagnostic.controleDateDebut
                ExploitationManager.save(m_Exploit, agentCourant)

                Statusbar.display("Mise � jour du pulv�risateur", True)
                'Calcul de la date de prochain controle
                m_Pulverisateur.dateProchainControle = m_diagnostic.pulverisateurDateProchainControle
                m_Pulverisateur.emplacementIdentification = m_diagnostic.pulverisateurEmplacementIdentification
                m_Pulverisateur.SetControleEtat(m_diagnostic)
                m_Pulverisateur.DecodageAutomatiqueDefauts(m_diagnostic.diagnosticItemsLst.Values)
                PulverisateurManager.save(m_Pulverisateur, m_Exploit.id, agentCourant)


                ' Enregistrement du diag
                Statusbar.display("R�cup�ration d'un nouvel ID", True)
                Dim tmpNewDiagId As String
                'tmpNewDiagId = InputBox("DiagID", "Entrez le num�ro du diag", agentCourant.idStructure & "-" & agentCourant.id & "-")
                tmpNewDiagId = DiagnosticManager.getNewId(agentCourant)
                m_diagnostic.id = tmpNewDiagId

                Statusbar.display("G�n�ration du rapport d'inspection", True)
                If createRapportInspection_cr(True) Then
                    Statusbar.display("G�n�ration du rapport de synth�se des mesures", True)
                    If Not createEtatSyntheseDesMesures(True) Then
                        CSDebug.dispError("Erreur en g�n�ration de l'�tat de synth�se des mesures")
                    End If

                    'diagnosticCourant.controleTarif = diagnosticCourantTarif.ToString
                    m_diagnostic.dateModificationAgent = CSDate.mysql2access(Date.Now)
                    m_diagnostic.dateModificationCrodip = "01/01/1900"
                    Statusbar.display("Sauvegarde du diagnostic" & m_diagnostic.id, True)
                    'on remet les Id � "" pour forcer la cr�ation d'un nouvel ID
                    m_diagnostic.diagnosticHelp551.id = ""
                    m_diagnostic.diagnosticHelp5621.id = ""
                    m_diagnostic.diagnosticHelp552.id = ""
                    m_diagnostic.diagnosticHelp5622.id = ""
                    m_diagnostic.diagnosticHelp811.id = ""
                    m_diagnostic.diagnosticHelp8312.id = ""
                    m_diagnostic.diagnosticInfosComplementaires.id = ""
                    Dim bSave As Boolean
                    bSave = DiagnosticManager.save(m_diagnostic)
                    If Not bSave Then
                        CSDebug.dispFatal("Diagnostic-recap.btn_finalisationDiag_valider_Click ERR : ERREUR EN SAUVEGARDE DE DIAGNOSTIQUE=> FERMERTURE DE l'APPLICATION, CONTACTER LE CRODIP")
                        MsgBox("ERREUR EN SAUVEGARDE DE DIAGNOSTIQUE => FERMERTURE DE l'APPLICATION, CONTACTER LE CRODIP")
                        Application.Exit()
                    End If

                    Statusbar.display("Mise � jour du manom�tre et banc de mesures", True)
                    m_diagnostic.setUtiliseBancEtMano(agentCourant)


                    ' On met en place les boutons
                    btn_finalisationDiag_valider.Text = "Poursuivre"
                    btn_finalisationDiag_imprimerRapport.Enabled = True
                    btn_finalisationDiag_modifierDiag.Enabled = False
                    btn_finalisationDiag_imprimerSynthese.Enabled = True

                    'D�sactivation de l'apper�u
                    btnAppercu.Enabled = False
                    rbEtatRI.Enabled = False
                    rbEtatSM.Enabled = False
                    CrystalReportViewer1.Enabled = False
                    isValider = True


                    'Incr�ment du nombre de diag r�alis�
                    My.Settings.nbControlesAvantAlerte = My.Settings.nbControlesAvantAlerte + 1
                    My.Settings.Save()

                    Statusbar.display("", False)
                    bReturn = True
                Else
                    CSDebug.dispFatal("Erreur en g�n�ration de rapport, recommencez. En cas de r�cidive, prevenez le CRODIP")
                End If
            Catch ex As Exception
                CSDebug.dispFatal("Erreur lors de l'enregistrement du diag : " & ex.Message.ToString)
                Statusbar.display("Erreur lors de l'enregistrement du contr�le.", False)
                bReturn = False
            End Try

        Catch ex As Exception
            CSDebug.dispFatal("Diagnostic_recap.SauvegarderDiagnostic ERR : " & ex.Message.ToString)
            bReturn = False

        End Try
    End Function
    Private Function GetInfos() As Boolean
        Dim bReturn As Boolean
        Try
            'Dates de Controles
            m_diagnostic.controleDateDebut = CDate(diagnosticRecap_organisme_dateControle.Text).ToShortDateString()
            m_diagnostic.controleDateFin = CDate(diagnosticRecap_organisme_dateControle.Text).ToShortDateString()
            If m_diagnostic.controleEtat = "" Then
                m_diagnostic.controleEtat = Diagnostic.controleEtatNOKCV
            End If
            Dim szH As String = diagnosticRecap_organisme_heureDebut.Text
            If Not String.IsNullOrEmpty(szH) Then
                Dim dDiag, dH As Date
                dH = CDate(szH)
                dDiag = CDate(m_diagnostic.controleDateDebut)
                m_diagnostic.controleDateDebut = dDiag.ToShortDateString() & " " & dH.ToShortTimeString()
            End If
            szH = diagnosticRecap_organisme_heureFin.Text
            If Not String.IsNullOrEmpty(szH) Then
                Dim dDiag, dH As Date
                dH = CDate(szH)
                dDiag = CDate(m_diagnostic.controleDateFin)
                m_diagnostic.controleDateFin = dDiag.ToShortDateString() & " " & dH.ToShortTimeString()
            End If
            'Emplacemement identification
            m_diagnostic.pulverisateurEmplacementIdentification = CSDb.secureString(cbx_diagnosticRecap_materiel_EmplacementIdentification.Text)
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("Diagnostic_recap.GetInfos ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    ''' <summary>
    ''' g�n�ration du rapport de synth�ses des mesures
    ''' </summary>
    ''' <remarks></remarks>
    Private Function createEtatSyntheseDesMesures(pExportPDF As Boolean) As Boolean
        Dim _PathToSynthesePDF As String
        Dim bReturn As Boolean = False
        Try
            Dim oEtat As New EtatSyntheseMesures(m_diagnostic)
            oEtat.GenereEtat(pExportPDF)
            If pExportPDF Then
                _PathToSynthesePDF = oEtat.getFileName()
                m_diagnostic.SMFileName = _PathToSynthesePDF
            Else
                CrystalReportViewer1.ReportSource = oEtat.getReportdocument
            End If
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("createEtatSyntheseDesMesures ERR : " & ex.Message.ToString)
            bReturn = False
        End Try
        Return bReturn
    End Function
    ' rapport D'inspection
    Private Function createRapportInspection_cr(pExportDPF As Boolean) As Boolean
        Dim bReturn As Boolean
        Dim pathRapport As String
        Try
            Dim oEtat As New EtatRapportInspection(m_diagnostic)
            oEtat.GenereEtat(pExportDPF)
            If pExportDPF Then
                pathRapport = oEtat.getFileName()
                m_diagnostic.RIFileName = pathRapport
                bReturn = File.Exists(Globals.CONST_PATH_EXP & pathRapport)
            Else
                CrystalReportViewer1.ReportSource = oEtat.getReportdocument
            End If
        Catch ex As Exception
            CSDebug.dispError("createRapportInspection_cr ERR : " & ex.Message.ToString)
            bReturn = False
        End Try
        Return bReturn
    End Function 'createRapportInspection_cr
    Private Sub btn_finalisationDiag_imprimerRapport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalisationDiag_imprimerRapport.Click
        Try
            ' On affiche le PDF rempli
            CSFile.open(Globals.CONST_PATH_EXP & m_diagnostic.RIFileName)
        Catch ex As Exception
            Console.Write("[Erreur] - G�n�ration Rapport d'Inspection : " & ex.Message.ToString & vbNewLine)
        End Try
    End Sub


    Private Sub btn_finalisationDiag_imprimerSynthese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finalisationDiag_imprimerSynthese.Click


        Try
            Statusbar.display("Affichage du rapport de synth�se", True)
            ' On affiche le PDF rempli
            CSFile.open(Globals.CONST_PATH_EXP & m_diagnostic.SMFileName)
            Statusbar.display("", True)
        Catch ex As Exception
            CSDebug.dispError("Erreur lors de la g�n�ration de l'�tat des Debit de buses : " & ex.Message.ToString)
        End Try

    End Sub
    Private Function checkForm() As Boolean
        Dim bReturn As Boolean
        bReturn = True
        If cbx_diagnosticRecap_materiel_EmplacementIdentification.Text = "" Then
            MsgBox("Vous devez renseigner l'emplacement de l'identification")
            cbx_diagnosticRecap_materiel_EmplacementIdentification.Focus()
            bReturn = False
        End If
        'If diagnosticRecap_proprietaire_numSiren.Text = "" Then
        '    MsgBox("Vous devez renseigner le num�ro de SIREN du propri�taire")
        '    diagnosticRecap_proprietaire_numSiren.Focus()
        '    bReturn = False
        'Else
        '    If Not CSCheck.numSIREN(diagnosticRecap_proprietaire_numSiren.Text) Then
        '        MsgBox("Vous devez entrer un num�ro de SIREN valide.")
        '        diagnosticRecap_proprietaire_numSiren.Focus()
        '        bReturn = False

        '    End If

        'End If
        'V�rification des heures de controle
        If Not CSDate.CheckHours(diagnosticRecap_organisme_heureDebut.Text) Then

            MsgBox("Format heure d�but incorrect : HH:MM")
            bReturn = False
        End If
        If Not CSDate.CheckHours(diagnosticRecap_organisme_heureFin.Text) Then

            MsgBox("Format heure fin incorrect : HH:MM")
            bReturn = False
        End If
        If bReturn Then
            If DateDiff(DateInterval.Minute, CDate(diagnosticRecap_organisme_heureDebut.Text), CDate(diagnosticRecap_organisme_heureFin.Text)) < 0 Then
                MsgBox("L'heure de fin doit �tre sup�rieure � l'heure de d�but")
                bReturn = False

            End If
        End If

        Return bReturn
    End Function

    Private Sub diagnosticRecap_proprietaire_numSiren_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        CSForm.typeAllowed(e, "integer")
        If e.Handled = False Then
            CSForm.maxSize(e, sender, 9)
        End If

    End Sub

    Private Sub diagnosticRecap_materiel_EmplacementIdentification_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        CSForm.typeAllowed(e, "Alphanumerique")
    End Sub

    Private Sub btn_FichePulve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fichePulve_isPneumatique_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fichePulve_isJetPorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fichePulve_isJetProjete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_voirFiche_Pulve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        displayFichePulve()
    End Sub
    Private Sub displayFichePulve()
        ' Mise � jour de la barre de status
        Statusbar.display("Chargement du pulv�risateur n�" & m_diagnostic.pulverisateurId)

        'Recup�ration de l'emplacement de l'identification 
        m_Pulverisateur.emplacementIdentification = cbx_diagnosticRecap_materiel_EmplacementIdentification.Text
        ' Affichage de la fiche du pulv�risateur

        Dim formEdition_fiche_pulve As New ajout_pulve2()
        formEdition_fiche_pulve.setContexte(ajout_pulve2.MODE.VERIF, agentCourant, m_Pulverisateur, m_Exploit, m_diagnostic)
        formEdition_fiche_pulve.ShowDialog(Me.MdiParent)
        m_diagnostic.setPulverisateur(m_Pulverisateur)
        'AffichePulverisateur()
    End Sub



    Private Sub btn_voirFicheExploitant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Mise � jour de la barre de status
        Statusbar.display("Chargement de l'exploitant n�" & m_diagnostic.proprietaireId)

        ' Affichage de la fiche du pulv�risateur
        'R�cup�ratino du num�ri de SIREN
        'm_Exploit.numeroSiren = diagnosticRecap_proprietaire_numSiren.Text
        Dim formEdition_fiche_pulve As New fiche_exploitant()
        formEdition_fiche_pulve.setContexte(True, m_Exploit)
        formEdition_fiche_pulve.DisplayNomEtPrenomduRepresentant(True)
        '        formEdition_fiche_pulve.SetFormRecapDiag(True)
        formEdition_fiche_pulve.ShowDialog(Me.MdiParent)
        m_diagnostic.SetProprietaire(m_Exploit)
        'AfficheProprietaire()

    End Sub

    Private Sub AfficheProprietaire()
        Try
            'diagnosticRecap_proprietaire_raisonSociale.Text = m_diagnostic.proprietaireRaisonSociale
            'diagnosticRecap_proprietaire_nom.Text = m_diagnostic.proprietaireNom & " " & m_diagnostic.proprietairePrenom
            'diagnosticRecap_proprietaire_numSiren.Text = m_diagnostic.proprietaireNumeroSiren
            If String.IsNullOrEmpty(m_diagnostic.proprietaireNumeroSiren) Then
                '   diagnosticRecap_proprietaire_numSiren.Enabled = True
                '  diagnosticRecap_proprietaire_numSiren.ReadOnly = False
            End If
            'diagnosticRecap_proprietaire_ville.Text = m_diagnostic.proprietaireCommune
        Catch ex As Exception
            CSDebug.dispError("Contr�le R�cap - Chargement Propri�taire du materiel : " & ex.Message.ToString)
        End Try

    End Sub
    Private Sub CloseDiagnostic()
        ' On vide les infos de session
        m_diagnostic = Nothing
        m_Pulverisateur = Nothing
        'Fermeture de fenpetres Filles de diag
        Dim ofrm As Form
        Dim ofrmAccueil As accueil
        For Each ofrm In MdiParent.MdiChildren
            If Not TypeOf ofrm Is accueil Then
                ofrm.Close()
            Else
                ofrmAccueil = ofrm
                ofrmAccueil.LoadListeExploitation()
                ofrmAccueil.loadListPulveExploitation(False)
                ofrmAccueil.WindowState = FormWindowState.Maximized
            End If
        Next

        ' On ferme le contr�le
        Statusbar.clear()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnAppercu_Click(sender As Object, e As EventArgs) Handles btnAppercu.Click
        If rbEtatRI.Checked Then
            createRapportInspection_cr(False)
        Else
            createEtatSyntheseDesMesures(False)
        End If
    End Sub

    Private Sub btn_voirFicheExploitant_Click_1(sender As Object, e As EventArgs) Handles btn_voirFicheExploitant.Click
        Dim formEdition_fiche_pulve As New fiche_exploitant()
        formEdition_fiche_pulve.setContexte(True, m_Exploit)
        formEdition_fiche_pulve.DisplayNomEtPrenomduRepresentant(True)
        '        formEdition_fiche_pulve.SetFormRecapDiag(True)
        formEdition_fiche_pulve.ShowDialog(Me.MdiParent)
        m_diagnostic.SetProprietaire(m_Exploit)

    End Sub

    Private Sub btn_voirFiche_Pulve_Click_1(sender As Object, e As EventArgs) Handles btn_voirFiche_Pulve.Click
        displayFichePulve()

    End Sub
End Class
