﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "Fonctionnalité Enregistrement automatique My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("http://admin.crodip.fr/server")>  _
    Public ReadOnly Property WSCrodipURL() As String
        Get
            Return CType(Me("WSCrodipURL"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("http://admin-pp.crodip.fr/server")>  _
    Public ReadOnly Property WSCrodipURLTEST() As String
        Get
            Return CType(Me("WSCrodipURLTEST"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("public/Exports/AutoTest.csv")>  _
    Public ReadOnly Property AutoTestDefaultFileName() As String
        Get
            Return CType(Me("AutoTestDefaultFileName"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public ReadOnly Property Expect100Continue() As Boolean
        Get
            Return CType(Me("Expect100Continue"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("moduledocumentaire")>  _
    Public ReadOnly Property ModuleDocumentaire() As String
        Get
            Return CType(Me("ModuleDocumentaire"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("moduleDocumentaire/_parametres/ParamdiagRampe.xml")>  _
    Public ReadOnly Property ParamDiagRampe() As String
        Get
            Return CType(Me("ParamDiagRampe"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("moduleDocumentaire/_parametres/ParamdiagArboViti.xml")>  _
    Public ReadOnly Property ParamDiagArboviti() As String
        Get
            Return CType(Me("ParamDiagArboviti"),String)
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleCodePostal() As String
        Get
            Return CType(Me("DernierControleCodePostal"),String)
        End Get
        Set
            Me("DernierControleCodePostal") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleCommune() As String
        Get
            Return CType(Me("DernierControleCommune"),String)
        End Get
        Set
            Me("DernierControleCommune") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleSite() As String
        Get
            Return CType(Me("DernierControleSite"),String)
        End Get
        Set
            Me("DernierControleSite") = value
        End Set
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public ReadOnly Property AutoSync() As Boolean
        Get
            Return CType(Me("AutoSync"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("moduledocumentaire/_parametres")>  _
    Public ReadOnly Property RepertoireParametres() As String
        Get
            Return CType(Me("RepertoireParametres"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public ReadOnly Property CVgratuite() As Boolean
        Get
            Return CType(Me("CVgratuite"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleNomDuSite() As String
        Get
            Return CType(Me("DernierControleNomDuSite"),String)
        End Get
        Set
            Me("DernierControleNomDuSite") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleTerritoire() As String
        Get
            Return CType(Me("DernierControleTerritoire"),String)
        End Get
        Set
            Me("DernierControleTerritoire") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property DernierControleNomRepresentant() As String
        Get
            Return CType(Me("DernierControleNomRepresentant"),String)
        End Get
        Set
            Me("DernierControleNomRepresentant") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property DernierControleSiteSecurise() As Boolean
        Get
            Return CType(Me("DernierControleSiteSecurise"),Boolean)
        End Get
        Set
            Me("DernierControleSiteSecurise") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property DernierControleRecupResidus() As Boolean
        Get
            Return CType(Me("DernierControleRecupResidus"),Boolean)
        End Get
        Set
            Me("DernierControleRecupResidus") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property DernierControleInfosChezProp() As Boolean
        Get
            Return CType(Me("DernierControleInfosChezProp"),Boolean)
        End Get
        Set
            Me("DernierControleInfosChezProp") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property nbControlesAvantAlerte() As Integer
        Get
            Return CType(Me("nbControlesAvantAlerte"),Integer)
        End Get
        Set
            Me("nbControlesAvantAlerte") = value
        End Set
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
    Public ReadOnly Property nbControlesAvantAlerteMax() As Integer
        Get
            Return CType(Me("nbControlesAvantAlerteMax"),Integer)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
    Public ReadOnly Property TxTVADefaut() As Double
        Get
            Return CType(Me("TxTVADefaut"),Double)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("ourea.cognix-systems.net")>  _
    Public ReadOnly Property FTPHost() As String
        Get
            Return CType(Me("FTPHost"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("crodip-pdf")>  _
    Public ReadOnly Property FTPuser() As String
        Get
            Return CType(Me("FTPuser"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("bvdkEn5xnQx")>  _
    Public ReadOnly Property FTPPassword() As String
        Get
            Return CType(Me("FTPPassword"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("ourea.cognix-systems.net")>  _
    Public ReadOnly Property FTPHostTest() As String
        Get
            Return CType(Me("FTPHostTest"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("crodip-pp-pdf")>  _
    Public ReadOnly Property FTPUserTest() As String
        Get
            Return CType(Me("FTPUserTest"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("3xnF9fTxWqL")>  _
    Public ReadOnly Property FTPPasswordTest() As String
        Get
            Return CType(Me("FTPPasswordTest"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
    Public ReadOnly Property NbIdentifiantPulveMini() As Integer
        Get
            Return CType(Me("NbIdentifiantPulveMini"),Integer)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public ReadOnly Property FTPUsePassiveMode() As Boolean
        Get
            Return CType(Me("FTPUsePassiveMode"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public ReadOnly Property WSCrodipProduction() As Boolean
        Get
            Return CType(Me("WSCrodipProduction"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public ReadOnly Property DesacMat() As Boolean
        Get
            Return CType(Me("DesacMat"),Boolean)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("2.6")>  _
    Public ReadOnly Property NumVersion() As String
        Get
            Return CType(Me("NumVersion"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("V2.6")>  _
    Public ReadOnly Property DBVersionExpected() As String
        Get
            Return CType(Me("DBVersionExpected"),String)
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("20180816160000")>  _
    Public ReadOnly Property NumBuild() As String
        Get
            Return CType(Me("NumBuild"),String)
        End Get
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Crodip_agent.MySettings
            Get
                Return Global.Crodip_agent.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
