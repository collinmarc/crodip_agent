﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Collections.Generic
Imports System.IO


Public Class EtatContratCommercial
    Inherits EtatCrodip
    Private m_oDiag As Diagnostic
    Private m_ods As dsContratCommercial
    Private m_ReportName As String

    Public Sub New(pDiag As Diagnostic)
        m_oDiag = pDiag
        'Récupération du nom du modème Crystal pour un chargement ultérieur
        Using r1 As New cr_ContratCommercial()
            m_ReportName = r1.ResourceName
            r1.Close()
        End Using
    End Sub

    Public Function GenereEtat() As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = genereDS()
            If (bReturn) Then
                Using objReport As New ReportDocument()

                    If System.IO.File.Exists(MySettings.Default.RepertoireParametres & "/" & m_ReportName) Then
                        objReport.Load(MySettings.Default.RepertoireParametres & "/" & m_ReportName)
                    Else
                        CSDebug.dispFatal(MySettings.Default.RepertoireParametres & "/" & m_ReportName & " n'existe pas")
                    End If

                    objReport.SetDataSource(m_ods)
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions
                    m_FileName = CSDiagPdf.makeFilename(m_oDiag.pulverisateurId, CSDiagPdf.TYPE_CONTRAT_COMMERCIAL) & ".pdf"
                    CrDiskFileDestinationOptions.DiskFileName = Globals.CONST_PATH_EXP & m_FileName
                    CrExportOptions = objReport.ExportOptions
                    With CrExportOptions
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    objReport.Export()
                    objReport.Close()
                End Using

            End If
        Catch ex As Exception
            CSDebug.dispError("EtatContratCommercial.GenereEtat ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    Private Function genereDS() As Boolean
        Dim bReturn As Boolean
        Try
            Dim rsProp As String
            rsProp = m_oDiag.proprietaireNom & "  " & m_oDiag.proprietairePrenom
            m_ods = New dsContratCommercial()


            m_ods.ContratCommercial.AddContratCommercialRow(dateControle:=m_oDiag.controleDateDebut,
                                                            adresse1Exploit:=m_oDiag.proprietaireAdresse,
                                                            cpExploit:=m_oDiag.proprietaireCodePostal,
                                                             NomPrenomInspecteur:=m_oDiag.inspecteurNom & " " & m_oDiag.inspecteurPrenom,
                                                             NomRepresentant:=m_oDiag.proprietaireRepresentant,
                                                             NumInspecteur:=m_oDiag.inspecteurNumeroNational,
                                                             numStruct:=m_oDiag.organismePresNumero,
                                                             MarquePulve:=m_oDiag.pulverisateurMarque,
                                                             NumnatPulve:=m_oDiag.pulverisateurNumNational,
                                                             MontantHT:=m_oDiag.TotalHT,
                                                             RSExploitant:=m_oDiag.proprietaireRaisonSociale,
                                                             villeExploit:=m_oDiag.proprietaireCommune,
                                                             NomPrenomExploit:=rsProp, DataColumn1:="")


            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("EtatContratCommercial.genereDS ERR : " & ex.Message)
            m_ods = New dsContratCommercial()
            bReturn = False
        End Try


        Return bReturn

    End Function
End Class
