Public Class Globals

    Public Enum ALERTE As Integer
        NOIRE = -1
        ROUGE = 0
        ORANGE = 1
        JAUNE = 2
        NONE = 3
    End Enum
    Public Enum DiagMode As Integer
        CTRL_COMPLET = 0
        CTRL_CV = 1
        CTRL_VISU = 2
    End Enum
    Public Enum enumConclusionDiag
        OK
        OK_AVECMINEEUR
        NOK
        NOK_PRELIM
    End Enum


    Public Const GLOB_DIAG_NUMAGR As String = "E001"
    Public Const GLOB_DIAG_NOMAGR As String = "CRODIP/Indigo"


#Region " Environnement "

    '############ Mode ############
#If DEBUG Then
    '## Dev
    Public Shared GLOB_ENV_DEBUG As Boolean = True
    Public Const GLOB_ENV_DIAGDEBUG As Boolean = True
    Public Const GLOB_ENV_DEBUGTYPE As String = "file" ' "none" ; "console" ; "msgbox" ; "file"
    'Public GLOB_ENV_WS As String = "dev" ' dev / preprod / prod
    Public Const GLOB_ENV_DEBUGLVL As Integer = 3 ' 0:none  ;  1:error  ;  2:error/warning  ;  3:error/warning/infos
#Else
    '## Prod
    Public Shared GLOB_ENV_DEBUG As Boolean = False
    Public Const GLOB_ENV_DIAGDEBUG As Boolean = False
    Public Const GLOB_ENV_DEBUGTYPE As String = "file" ' "none" ; "console" ; "msgbox" ; "file"
    Public Shared GLOB_ENV_WS As String = "prod" ' dev / preprod / prod
    Public Const GLOB_ENV_DEBUGLVL As Integer = 1 ' 0:none  ;  1:error  ;  2:error/warning  ;  3:error/warning/infos
#End If
    '############ FIN -- Mode ############

    ' Debug
    Public Const GLOB_ENV_DEBUGLOGFILE As String = "." & "\tmp\crodipAgent.log" ' Fichier contenant les logs de debug si GLOB_ENV_DEBUGTYPE = "file"
    Public Const GLOB_ENV_SYNCHROLOGFILE As String = "." & "\tmp\LogSynchro.xml"  ' Fichier contenant les logs dxml de la synchro

    ' Comportement
    Public Shared GLOB_ENV_AUTOSYNC As Boolean = My.Settings.AutoSync
    Public Shared GLOB_ENV_SHOWSPLASH As Boolean = True

    ' Conf
    Public Shared GLOB_XML_CONFIG As CSXml
    Public Shared GLOB_PID_FILE As String = "." & "\crodip_agent.pid"

    ' Version
    Public Shared GLOB_APPLI_VERSION As String = My.Settings.NumVersion
    Public Shared GLOB_APPLI_BUILD As String = My.Settings.NumBuild
    Public Shared GLOB_ParamDiagRampe As String = My.Settings.ParamDiagRampe
    Public Shared GLOB_ParamDiagArboViti As String = My.Settings.ParamDiagArboviti
    Public Shared GLOB_BLUE_CROPDIP As Color = Color.FromArgb(2, 129, 198)

#End Region

#Region " Marques / Mod�les "

    ' Bancs
    Public Shared GLOB_XML_MARQUES_BANC As CSXml
    ' Buses
    Private Shared _GLOB_XML_MARQUES_BUSES As CSXml
    Public Shared Property GLOB_XML_MARQUES_BUSES() As CSXml
        Get
            Return _GLOB_XML_MARQUES_BUSES
        End Get
        Set(ByVal value As CSXml)
            _GLOB_XML_MARQUES_BUSES = value
        End Set
    End Property
    Public Shared GLOB_XML_MODELES_BUSES As CSXml
    Public Shared GLOB_XML_GENRES_BUSES As CSXml
    Public Shared GLOB_XML_COULEURS_BUSES As CSXml
    Public Shared GLOB_XML_TYPES_BUSES As CSXml
    Public Shared GLOB_XML_ANGLES_BUSES As CSXml
    Public Shared GLOB_XML_REFER_BUSES As CSXml
    Public Shared GLOB_XML_FONCTIONNEMENTBUSES_BUSES As CSXml
    Public Shared GLOB_ARR_MARQUES_BUSES() As String
    Public Shared GLOB_ARR_MODELES_BUSES() As String
    Public Shared GLOB_ARR_TYPES_BUSES() As String

    ' Manometres
    Public Shared GLOB_XML_MARQUES_MANO As CSXml
    Public Shared GLOB_XML_MODELES_MANO As CSXml
    Public Shared GLOB_XML_CLASSES_MANO As CSXml
    Public Shared GLOB_XML_FONDECHELLE_MANO As CSXml
    Public Shared GLOB_ARR_MARQUES_MANO() As String
    Public Shared GLOB_ARR_MODELES_MANO() As String

    ' Manometres de contr�le
    Public Shared GLOB_XML_MARQUES_MANOCONT As CSXml
    Public Shared GLOB_XML_MODELES_MANOCONT As CSXml
    Public Shared GLOB_XML_CLASSES_MANOCONT As CSXml
    Public Shared GLOB_XML_FONDECHELLE_MANOCONT As CSXml
    Public Shared GLOB_ARR_MARQUES_MANOCONT() As String
    Public Shared GLOB_ARR_MODELES_MANOCONT() As String
    ' Manometres �talon
    Public Shared GLOB_XML_MARQUES_MANOETA As CSXml
    Public Shared GLOB_XML_MODELES_MANOETA As CSXml
    Public Shared GLOB_XML_CLASSES_MANOETA As CSXml
    Public Shared GLOB_XML_FONDECHELLE_MANOETA As CSXml
    Public Shared GLOB_ARR_MARQUES_MANOETA() As String
    Public Shared GLOB_ARR_MODELES_MANOETA() As String

    ' Pulv�risateurs
    Public Shared GLOB_XML_MARQUES_MODELES_PULVE As CSXml
    Public Shared GLOB_XML_TYPES_CATEGORIES_PULVE As CSXml
    Public Shared GLOB_XML_ATTELAGE_PULVE As CSXml
    Public Shared GLOB_XML_PULVERISATION_PULVE As CSXml
    Public Shared GLOB_XML_REGULATION_PULVE As CSXml
    Public Shared GLOB_XML_EMPLACEMENTIDENTIFICATION As CSXml
    Public Shared GLOB_XML_MODEUTILISATION As CSXml

    Public Shared GLOB_ARR_MARQUES_PULVE() As String
    Public Shared GLOB_ARR_MODELES_PULVE() As String
    Public Shared GLOB_ARR_TYPES_PULVE() As String
    Public Shared GLOB_ARR_CLASSES_PULVE() As String
    Public Shared GLOB_STR_REFERENTIELBUSES_FILENAME As String = My.Settings.RepertoireParametres & "\referentiel_buse.csv"
    Public Shared GLOB_STR_COMMUNES_FILENAME As String = My.Settings.RepertoireParametres & "\base_officielle_codes_postaux.csv"

    ' Territoires
    Public Shared GLOB_XML_TERRITOIRES As CSXml
    Public Shared GLOB_XML_CODESAPE As CSXml

#End Region



#Region " PATHS "

    ' Public
    Public Shared CONST_PATH_PUBLIC As String = "." & "\public\"
    ' Documents
    Public Shared CONST_PATH_DOCS As String = CONST_PATH_PUBLIC & "docs\"
    ' Exports
    Public Shared CONST_PATH_EXP As String = CONST_PATH_PUBLIC & "exports\"

    ' Images
    Public Shared CONST_PATH_IMG As String = "." & "\img\"

    ' Temp
    Public Shared CONST_PATH_TMP As String = "." & "\tmp\"


#End Region

#Region " Nom des documents "

    ' Logo module facturation
    Public Const CR_LOGO_DEFAULT_NAME As String = "nologo.jpg"
    Public Const CR_LOGO_DEFAULT_TN_NAME As String = "nologo_tn.jpg"
    Public Const CR_LOGO_NAME As String = "CR_logo.jpg"
    Public Const CR_LOGO_TN_NAME As String = "CR_logo_tn.jpg"
    Public Const CR_LOGO_TN2_NAME As String = "CR_logo_tn2.jpg"

    ' Template Facture
    Public CONST_DOC_FACTURE As String = "facture"
    ' Template BL
    Public Const CONST_DOC_BL As String = "bl"
    ' Template Contrat Commercial
    Public Const CONST_DOC_CONTCOM As String = "contrat_commercial"
    ' Rapports d'inspection
    'Public Globals.CONST_DOC_RAPINSP As String = "rapport_inspection"
    Public Const CONST_DOC_RAPINSP_COMPLET As String = "rapport_inspection_complet"
    Public Const CONST_DOC_RAPINSP_COMPLET_2P As String = "rapport_inspection_complet_2p"
    Public Const CONST_DOC_RAPINSP_CONTREVISITE As String = "rapport_inspection_ContreVisite"
    Public Const CONST_DOC_RAPINSP_CONTREVISITE_2P As String = "rapport_inspection_ContreVisite_2p"
    ' Rapport d'inspection 2 pages
    'Public Globals.CONST_DOC_RAPINSP2 As String = "rapport_inspection_2p"
    ' Feuille p�dagogique
    Public Const CONST_DOC_FPEDA As String = "feuille_pedagogique"
    ' Enquete satisfaction
    Public Const CONST_DOC_ENQSAT As String = "enquete_satisfaction"
    ' Template Fiche Terrain Rampe
    Public Const CONST_DOC_FICHETERRAIN_RAMPE As String = "fiche_terrain_rampe.pdf"
    ' Template Fiche Terrain Arbo/viti
    Public Const CONST_DOC_FICHETERRAIN_ARBOVITI As String = "fiche_terrain_arbo-viti.pdf"
    ' Template Fiche de vie mano controle
    Public Const CONST_DOC_FV_MANOCTRL As String = "ficheVie_mano"
    ' Template Fiche de vie banc
    Public Const CONST_DOC_FV_BANC As String = "ficheVie_banc"
    ''' <summary>
    ''' Symbole decimal utilis� par l'application
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared CONST_DECIMAL_SYMBOL As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

#End Region


#Region " constantes (Messages d'info.) "

#Region " Messages d'information "

    '###########################################
    '#####     Messages d'information      #####
    '###########################################
    ' Contr�le d'un banc de mesure
    '###########################################
    Public Const CONST_INFO_CTRLBANC_ERR_NOTEMP As String = "        Vous devez renseigner les temp�ratures de l'air et de l'eau."
    Public Const CONST_INFO_CTRLBANC_ERR_5BUSES As String = "        Vous devez s�lectionner 5 buses minimum."
    Public Const CONST_INFO_CTRLBANC_ERR_NOVERIFNUM As String = "        Vous devez renseigner un num�ro de v�rification."
    Public Const CONST_INFO_CTRLBANC_ERR_NOBANCNUM As String = "        Vous devez renseigner un num�ro de banc � contr�ler."
    Public Const CONST_INFO_CTRLBANC_MSG_CONTROLOK As String = "        Contr�le OK"
    Public Const CONST_INFO_CTRLBANC_MSG_CONTROLNOK As String = "        Contr�le NOK"

#End Region

#Region " Messages barre de statut "

    '###########################################
    '#####    Messages barre de statut     #####
    '###########################################
    ' Alertes en page d'accueil
    '###########################################
    Public Const CONST_STATUTMSG_ALERTES_MANOETALON_LOAD As String = "        V�rification des alertes sur les manom�tres �talons..."
    Public Const CONST_STATUTMSG_ALERTES_MANOCONTROLE_LOAD As String = "        V�rification des alertes sur les manom�tres de contr�le..."
    Public Const CONST_STATUTMSG_ALERTES_BUSESETALON_LOAD As String = "        V�rification des alertes sur les buses �talons..."
    Public Const CONST_STATUTMSG_ALERTES_BANC_LOAD As String = "        V�rification des alertes sur les bancs de mesure..."
    Public Const CONST_STATUTMSG_ALERTES_CLIENTS_LOAD As String = "        V�rification des alertes sur les clients..."
    Public Const CONST_STATUTMSG_ALERTES_SYNCHRO_LOAD As String = "        V�rification des alertes sur la synchronisation..."
    '###########################################

    '###########################################
    ' Login
    '###########################################
    Public Const CONST_STATUTMSG_LOGIN_ENCOURS As String = "        Connexion en cours..."
    Public Const CONST_STATUTMSG_LOGIN_OK As String = "        Connexion r�ussie."
    Public Const CONST_STATUTMSG_LOGIN_FAILED As String = "        [Erreur] - Echec de la connexion � votre profil."
    '###########################################

    '###########################################
    ' Ajout d'un Agent
    '###########################################
    Public Const CONST_STATUTMSG_ADDAGENT_ENCOURS As String = "        Ajout d'un nouveau profil en cours..."
    Public Const CONST_STATUTMSG_ADDAGENT_LINK_ENCOURS As String = "        Connexion au serveur en cours..."
    Public Const CONST_STATUTMSG_ADDAGENT_LOAD_ENCOURS As String = "        Chargement du profil en cours..."
    Public Const CONST_STATUTMSG_ADDAGENT_VERIF_ENCOURS As String = "        V�rifications en cours..."
    Public Const CONST_STATUTMSG_ADDAGENT_ERROR_EXISTS As String = "        [Erreur] - Echec de r�cup�ration du profil : Cet inspecteur est d�j� pr�sent en base."
    Public Const CONST_STATUTMSG_ADDAGENT_ERROR_PASSNOTMATCH As String = "        [Erreur] - Echec de r�cup�ration du profil : Les mots de passe ne correspondent pas."
    Public Const CONST_STATUTMSG_ADDAGENT_ERROR_NOPROFIL As String = "        [Erreur] - Echec de r�cup�ration du profil : Ce profil n'existe pas."
    Public Const CONST_STATUTMSG_ADDAGENT_ERROR_NOTCONNECT As String = "        [Erreur] - Echec de r�cup�ration du profil : Connection introuvable."
    Public Const CONST_STATUTMSG_ADDAGENT_OK As String = "        Sauvegarde r�ussie."
    '###########################################

    '###########################################
    ' Parametrage Agent
    '###########################################
    Public Const CONST_STATUTMSG_FICHEAGENT_ENCOURS As String = "        Sauvegarde de vos donn�es en cours..."
    Public Const CONST_STATUTMSG_FICHEAGENT_OK As String = "        Sauvegarde r�ussie."
    Public Const CONST_STATUTMSG_FICHEAGENT_FAILED As String = "        [Erreur] - Echec de la sauvegarde de vos donn�es."
    '###########################################

    '###########################################
    ' Listing clients
    '###########################################
    Public Const CONST_STATUTMSG_LISTCLIENT_ENCOURS As String = "        Chargement des clients en cours..."
    Public Const CONST_STATUTMSG_LISTCLIENT_OK As String = " clients correctement charg�s."
    '###########################################

    '###########################################
    ' Parametrage Client
    '###########################################
    Public Const CONST_STATUTMSG_FICHECLIENT_ENCOURS As String = "        Sauvegarde de vos donn�es client en cours..."
    Public Const CONST_STATUTMSG_FICHECLIENT_OK As String = "        Sauvegarde du client r�ussie."
    Public Const CONST_STATUTMSG_FICHECLIENT_FAILED As String = "        [Erreur] - Echec de la sauvegarde de vos donn�es client."
    '###########################################

    '###########################################
    ' Supression Client
    '###########################################
    Public Const CONST_STATUTMSG_DELETECLIENT_ENCOURS As String = "        Suppression du client en cours..."
    Public Const CONST_STATUTMSG_DELETECLIENT_OK As String = "        Suppression du client r�ussie."
    Public Const CONST_STATUTMSG_DELETECLIENT_FAILED As String = "        [Erreur] - Echec de la suppression du client."
    Public Const CONST_STATUTMSG_DELETECLIENT_CANCEL As String = "        Suppression du client annul�e par l'utilisateur."
    Public Const CONST_STATUTMSG_DELETECLIENT_NOSELECTED As String = "        Vous devez d'abord s�lectionner un client dans la liste."
    '###########################################

    '###########################################
    ' Listing pulv�risateurs
    '###########################################
    Public Const CONST_STATUTMSG_LISTPULVE_ENCOURS As String = "        Chargement des pulv�risateurs en cours..."
    Public Const CONST_STATUTMSG_LISTPULVE_OK As String = " pulv�risateurs correctement charg�s."
    '###########################################

    '###########################################
    ' Parametrage pulv�risateur
    '###########################################
    Public Const CONST_STATUTMSG_EDITPULVE_ENCOURS As String = "        Sauvegarde du pulv�risateur en cours..."
    Public Const CONST_STATUTMSG_EDITPULVE_OK As String = "        Sauvegarde du pulv�risateur r�ussie."
    Public Const CONST_STATUTMSG_EDITPULVE_FAILED As String = "        [Erreur] - Echec de la sauvegarde du pulv�risateur."
    '###########################################

    '###########################################
    ' Supression pulv�risateur
    '###########################################
    Public Const CONST_STATUTMSG_DELETEPULVE_ENCOURS As String = "        Suppression du pulv�risateur en cours..."
    Public Const CONST_STATUTMSG_DELETEPULVE_OK As String = "        Suppression du pulv�risateur r�ussie."
    Public Const CONST_STATUTMSG_DELETEPULVE_FAILED As String = "        [Erreur] - Suppression du pulv�risateur impossible, pr�sence de contr�les."
    Public Const CONST_STATUTMSG_DELETEPULVE_CANCEL As String = "        Suppression du pulv�risateur annul�e par l'utilisateur."
    Public Const CONST_STATUTMSG_DELETEPULVE_NOSELECTED As String = "        Vous devez d'abord s�lectionner un pulv�risateur dans la liste."
    '###########################################

    '###########################################
    ' Parametrage Structure
    '###########################################
    Public Const CONST_STATUTMSG_FICHESTRUCTURE_ENCOURS As String = "        Sauvegarde de vos donn�es en cours..."
    Public Const CONST_STATUTMSG_FICHESTRUCTURE_OK As String = "        Sauvegarde r�ussie."
    Public Const CONST_STATUTMSG_FICHESTRUCTURE_FAILED As String = "        [Erreur] - Echec de la Sauvegarde de vos donn�es."
    '###########################################

    '###########################################
    ' Synchronisation
    '###########################################
    Public Const CONST_STATUTMSG_SYNCHRO_ENCOURS As String = "        Synchronisation avec le Crodip en cours..."
    Public Const CONST_STATUTMSG_SYNCHRO_OK As String = " �l�ments ont �t� synchronis�s."
    Public Const CONST_STATUTMSG_SYNCHRO_EMPTY As String = "        Aucun �l�ment � synchroniser."
    Public Const CONST_STATUTMSG_SYNCHRO_FAILED As String = "        [Erreur] - Echec de la synchronisation avec le Crodip."
    Public Const CONST_STATUTMSG_SYNCHRO_UNAVAILABLE As String = "        Synchronisation impossible, serveur Crodip momentan�ment indisponible."
    '###########################################

    '###########################################
    ' Contr�le
    '###########################################
    Public Const CONST_STATUTMSG_DIAG_VERIFCLI As String = "V�rification des informations du client."
    Public Const CONST_STATUTMSG_DIAG_TARIFS As String = "Saisie des tarifs."
    Public Const CONST_STATUTMSG_DIAG_CONTROLEPRE As String = "Contr�le pr�liminaire."
    Public Const CONST_STATUTMSG_DIAG_ENCOURS As String = "Contr�le pulv� en cours..."
    Public Const CONST_STATUTMSG_DIAG_SAVING As String = "Enregistrement en cours..."
    Public Const CONST_STATUTMSG_DIAG_SAVED As String = "Contr�le correctement enregistr�."
    '###########################################

#End Region

#End Region

    Public Shared Sub Init()
        My.Settings.Reload()
        GLOB_ENV_AUTOSYNC = My.Settings.AutoSync
        GLOB_APPLI_VERSION = My.Settings.NumVersion
        GLOB_APPLI_BUILD = My.Settings.NumBuild
        CSDebug.dispInfo("Globals.Init user LocalUserAppDataPath :" & Application.LocalUserAppDataPath)
        CSDebug.dispInfo("Globals.Init App My.Settings.NumVersion:" & My.Settings.NumVersion)
        CSDebug.dispInfo("Globals.Init App My.Settings.NumVersion:" & My.Settings.NumBuild)
    End Sub
    Public Shared Function StringToDouble(pInputString As String) As Double
        Dim dReturn As Double
        Dim ciClone As System.Globalization.CultureInfo = CType(System.Globalization.CultureInfo.InvariantCulture.Clone(), System.Globalization.CultureInfo)
        ciClone.NumberFormat.NumberDecimalSeparator = ","
        If String.IsNullOrEmpty(pInputString) Then
            Return 0.0
        End If
        pInputString = pInputString.Replace("�", "")

        Try
            'on convertit en rempla�ant le . par la virgule
            dReturn = Convert.ToDouble(pInputString.Replace(".", ","), ciClone)
        Catch ex As Exception
            CSDebug.dispInfo("StringToDouble: Erreur Conversion 1 :" & pInputString)
            ex = Nothing
            Try
                'si �a ne fonctionne pas on convertit sans remplacement
                dReturn = Convert.ToDouble(pInputString, ciClone)
            Catch ex2 As Exception
                CSDebug.dispInfo("StringToDouble: Erreur Conversion 2 :" & pInputString)
                ex2 = Nothing
                Try
                    'si �a ne fonctionne pas on convertit sans prendre en compte la culture
                    dReturn = Convert.ToDouble(pInputString)
                Catch ex3 As Exception
                    CSDebug.dispError("StringToDouble: Erreur Conversion 3 :" & pInputString)
                    ex3 = Nothing
                    dReturn = 0
                End Try
            End Try
        End Try
        Return dReturn

    End Function

    Public Function FormatStringDecimal(pInputString As String, pndec As Decimal) As String
        Dim dValue As Double
        Dim sReturn As String
        Dim strFormat As String
        sReturn = ""
        Try

            dValue = Globals.StringToDouble(pInputString)
            strFormat = "#####0."
            For i As Integer = 1 To pndec
                strFormat = strFormat & "0"
            Next
            sReturn = dValue.ToString(strFormat)

        Catch ex As Exception
            CSDebug.dispWarn("FormatStringDecimal ERR : " & ex.Message)
            sReturn = ""
        End Try
        Return sReturn
    End Function
End Class
