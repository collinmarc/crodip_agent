﻿Imports System.Web.Services
Imports System.Xml.Serialization
Imports System.Collections.Generic
'''
''' Classe de stockage des infos saisie de mesures pour l'item 12123
''' Voir fichier Calcul12123
<Serializable()> _
Public Class DiagnosticHelp12123Mesures
    Implements ICloneable
    Private m_id As String
    Private m_idDiag As String
    'Capteur de vitesse
    Private m_debitMesure? As Decimal = Nothing
    Private m_PressionMesure? As Decimal = Nothing
    Private m_PressionMoyenne? As Decimal = Nothing
    Private m_NbBuses? As Decimal = Nothing
    Private m_DebitReel? As Decimal = Nothing
    Private m_DebitTotal? As Decimal = Nothing
    Private m_ReglageDispositif? As Decimal = Nothing
    Private m_DebitTheorique? As Decimal = Nothing
    Private m_TempsMesure? As Decimal = Nothing
    Private m_QteEauPulverisee? As Decimal = Nothing
    Private m_MasseapresAspi? As Decimal = Nothing
    Private m_MasseApresComplement? As Decimal = Nothing
    Private m_QteProduitConso? As Decimal = Nothing
    Private m_DosageReel? As Decimal = Nothing
    Private m_EcartReglage? As Decimal = Nothing
    Private m_Resultat As String
    Private m_bCalcule As Boolean = True

    Public const DIAGITEM_ID As String = "help12123"
    Public LIMITE_ECART_MAJEUR As Decimal = 5

    Public Sub New(pNum As Integer)
        m_Resultat = ""
        numero = pNum
        '''// FOR PROP ONLY
        If pNum = 1 Then
            Image = New Bitmap("img/puces/V.jpg")
            Resultat = "OK"
        End If
        If pNum = 2 Then
            Image = New Bitmap("img/puces/R.jpg")
            Resultat = "ERREUR"
        End If
        If pNum = 3 Then
            Image = New Bitmap("img/puces/G.jpg")
        End If
    End Sub
    Private _image As Bitmap
    Public Property Image() As Bitmap
        Get
            Return _image
        End Get
        Set(ByVal value As Bitmap)
            _image = value
        End Set
    End Property


    Public Sub New(ByVal pId As String, ByVal pIdDiag As String)
        m_id = pId
        m_idDiag = pIdDiag
        m_Resultat = ""
    End Sub
    Private _Numero As Integer
    Public Property numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property

    Public Property id As String
        Get
            Return m_id
        End Get
        Set(ByVal Value As String)
            m_id = Value
        End Set
    End Property
    Public Property idDiag As String
        Get
            Return m_idDiag
        End Get
        Set(ByVal Value As String)
            m_idDiag = Value
        End Set
    End Property
    Public Property bCalcule As Boolean
        Get
            Return m_bCalcule
        End Get
        Set(ByVal Value As Boolean)
            m_bCalcule = Value
        End Set
    End Property
    Public Property debitMesure As Decimal?
        Get
            Return m_debitMesure
        End Get
        Set(value As Decimal?)
            m_debitMesure = value
            calcule()
        End Set
    End Property
    Public Property PressionMesure As Decimal?
        Get
            Return m_PressionMesure
        End Get
        Set(value As Decimal?)
            m_PressionMesure = value
            calcule()
        End Set
    End Property
    Public Property PressionMoyenne As Decimal?
        Get
            Return m_PressionMoyenne
        End Get
        Set(value As Decimal?)
            m_PressionMoyenne = value
            calcule()
        End Set
    End Property
    Public Property NbBuses As Decimal?
        Get
            Return m_NbBuses
        End Get
        Set(value As Decimal?)
            m_NbBuses = value
            calcule()

        End Set
    End Property
    Public Property DebitReel As Decimal?
        Get
            Return m_DebitReel
        End Get
        Set(value As Decimal?)
            m_DebitReel = value
        End Set
    End Property
    Public Property DebitReelRND As Decimal?
        Get
            If m_DebitReel.HasValue Then
                Return Math.Round(DebitReel.Value, 2)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_DebitReel = value
        End Set
    End Property
    Public Property DebitTotal As Decimal?
        Get
            Return m_DebitTotal
        End Get
        Set(value As Decimal?)
            m_DebitTotal = value
        End Set
    End Property
    Public Property DebitTotalRND As Decimal?
        Get
            If m_DebitTotal.HasValue Then
                Return Math.Round(m_DebitTotal.Value, 2)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_DebitTotal = value
        End Set
    End Property
    Public Property ReglageDispositif As Decimal?
        Get
            Return m_ReglageDispositif
        End Get
        Set(value As Decimal?)
            m_ReglageDispositif = value
            calcule()
        End Set
    End Property
    Public Property DebitTheorique As Decimal?
        Get
            Return m_DebitTheorique
        End Get
        Set(value As Decimal?)
            m_DebitTheorique = value
        End Set
    End Property
    Public Property DebitTheoriqueRND As Decimal?
        Get
            If m_DebitTheorique.HasValue Then
                Return Math.Round(m_DebitTheorique.Value, 3)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_DebitTheorique = value
        End Set
    End Property
    Public Property TempsMesure As Decimal?
        Get
            Return m_TempsMesure
        End Get
        Set(value As Decimal?)
            m_TempsMesure = value
            calcule()
        End Set
    End Property
    Public Property QteEauPulverisee As Decimal?
        Get
            Return m_QteEauPulverisee
        End Get
        Set(value As Decimal?)
            m_QteEauPulverisee = value
        End Set
    End Property
    Public Property QteEauPulveriseeRND As Decimal?
        Get
            If m_QteEauPulverisee.HasValue Then
                Return Math.Round(m_QteEauPulverisee.Value, 5)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_QteEauPulverisee = value
        End Set
    End Property
    Public Property MasseApresAspi As Integer?
        Get
            Return m_MasseapresAspi
        End Get
        Set(value As Integer?)
            m_MasseapresAspi = value
            calcule()
        End Set
    End Property
    Public Property MasseApresComplement As Integer?
        Get
            Return m_MasseApresComplement
        End Get
        Set(value As Integer?)
            m_MasseApresComplement = value
            calcule()
        End Set
    End Property
    Public Property QteProduitConso As Integer?
        Get
            Return m_QteProduitConso
        End Get
        Set(value As Integer?)
            m_QteProduitConso = value
        End Set
    End Property
    Public Property DosageReel As Decimal?
        Get
            Return m_DosageReel
        End Get
        Set(value As Decimal?)
            m_DosageReel = value
        End Set
    End Property
    Public Property DosageReelRND As Decimal?
        Get
            If m_DosageReel.HasValue Then
                Return Math.Round(m_DosageReel.Value, 7)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_DosageReel = value
        End Set
    End Property
    Public Property EcartReglage As Decimal?
        Get
            Return m_EcartReglage
        End Get
        Set(value As Decimal?)
            m_EcartReglage = value
        End Set
    End Property
    Public Property EcartReglageRND As Decimal?
        Get
            If m_EcartReglage.HasValue Then
                Return Math.Round(m_EcartReglage.Value, 7)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Decimal?)
            m_EcartReglage = value
        End Set
    End Property
    Public Property Resultat As String

        Get
            Return m_Resultat
        End Get
        Set(value As String)
            m_Resultat = value
        End Set
    End Property
    Public Function Load() As Boolean
        Debug.Assert(Not String.IsNullOrEmpty(id), "Id must be set")
        Debug.Assert(Not String.IsNullOrEmpty(idDiag), "IdDiag must be set")
        Dim bReturn As Boolean
        Try

            Dim oDiagItem As DiagnosticItem
            oDiagItem = DiagnosticItemManager.getDiagnosticItemById(id, idDiag)
            If oDiagItem.idItem = "help12123" Then
                Try
                    bCalcule = False 'Au rechargement on désactive le calcul
                    Dim tabValues As String()
                    tabValues = oDiagItem.itemValue.Split("|")
                    debitMesure = ConvertStringToAtt(tabValues(0))  '0
                    PressionMesure = ConvertStringToAtt(tabValues(1))  '1
                    PressionMoyenne = ConvertStringToAtt(tabValues(2))  '2
                    NbBuses = ConvertStringToAtt(tabValues(3))  '3
                    DebitReel = ConvertStringToAtt(tabValues(4))  '4
                    DebitTotal = ConvertStringToAtt(tabValues(5))  '5
                    ReglageDispositif = ConvertStringToAtt(tabValues(6))  '6
                    DebitTheorique = ConvertStringToAtt(tabValues(7))  '7
                    TempsMesure = ConvertStringToAtt(tabValues(8))  '8
                    QteEauPulverisee = ConvertStringToAtt(tabValues(9))  '9
                    MasseApresAspi = ConvertStringToAtt(tabValues(10))  '10
                    MasseApresComplement = ConvertStringToAtt(tabValues(11))  '11
                    QteProduitConso = ConvertStringToAtt(tabValues(12))  '12
                    DosageReel = ConvertStringToAtt(tabValues(13))  '13
                    EcartReglage = ConvertStringToAtt(tabValues(14))  '14
                    Me.Resultat = Trim(tabValues(15))  '15
                    bCalcule = True
                Catch ex As Exception
                    CSDebug.dispError("DiagnosticHelp12123.load ERR conversion (" & oDiagItem.itemValue & ") ERR " & ex.Message)
                End Try
            End If
            bReturn = True

        Catch ex As Exception
            CSDebug.dispError("DiagnosticHelp12123.Load ERR: " & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Function Save(ByVal pStructureId As String, ByVal pAgentId As String) As Boolean
        '        Debug.Assert(Not String.IsNullOrEmpty(id), "Id must be set")
        Debug.Assert(Not String.IsNullOrEmpty(idDiag), "IdDiag must be set")
        Debug.Assert(Not String.IsNullOrEmpty(pStructureId), "pStructureId must be set")
        Debug.Assert(Not String.IsNullOrEmpty(pAgentId), "pAgentId must be set")

        Dim bReturn As Boolean
        Try
            'Cet Object est transformé en DiagItem pour le Stockage
            Dim oDiagItem As DiagnosticItem
            Dim oDiagItemLu As DiagnosticItem
            oDiagItem = ConvertToDiagnosticItem()
            If Not String.IsNullOrEmpty(id) Then
                oDiagItemLu = DiagnosticItemManager.getDiagnosticItemById(id, idDiag)
                If Not String.IsNullOrEmpty(oDiagItemLu.id) Then
                    oDiagItem.id = oDiagItemLu.id
                    oDiagItem.idDiagnostic = oDiagItemLu.idDiagnostic
                    'oDiagItem.idItem
                    'oDiagItem.itemValue
                    oDiagItem.cause = oDiagItemLu.cause
                    oDiagItem.dateModificationAgent = oDiagItemLu.dateModificationAgent
                    oDiagItem.dateModificationCrodip = oDiagItemLu.dateModificationCrodip
                End If
            End If
            If String.IsNullOrEmpty(oDiagItem.id) Then
                id = DiagnosticItemManager.getNewId(pStructureId, pAgentId)
                oDiagItem.id = id
            End If
            Dim oCSDB As New CSDb(True)
            bReturn = DiagnosticItemManager.save(oCSDB, oDiagItem)
            oCSDB.free()
        Catch ex As Exception
            CSDebug.dispError("DiagnosticHelp12123.Save ERR :" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Function ConvertToDiagnosticItem() As DiagnosticItem

        Dim oDiagItem As DiagnosticItem
        oDiagItem = New DiagnosticItem
        oDiagItem.id = id
        oDiagItem.idDiagnostic = idDiag
        oDiagItem.idItem = "help12123"

        oDiagItem.itemValue = ConvertAttToString(debitMesure) & "|" '0
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(PressionMesure) & "|" '1
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(PressionMoyenne) & "|" '2
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(NbBuses) & "|" '3
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(DebitReel) & "|" '4
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(DebitTotal) & "|" '5
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(ReglageDispositif) & "|" '6
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(DebitTheorique) & "|" '7
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(TempsMesure) & "|" '8
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(QteEauPulverisee) & "|" '9
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(MasseApresAspi) & "|" '10
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(MasseApresComplement) & "|" '11
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(QteProduitConso) & "|" '12
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(DosageReel) & "|" '13
        oDiagItem.itemValue = oDiagItem.itemValue & ConvertAttToString(EcartReglage) & "|" '14
        oDiagItem.itemValue = oDiagItem.itemValue & Trim(Me.Resultat) & "|" '15

        Return oDiagItem
    End Function

    Private Function ConvertAttToString(pValue? As Decimal) As String
        If pValue.HasValue Then
            Return Trim(pValue.ToString())
        Else
            Return ""
        End If
    End Function
    Private Function ConvertStringToAtt(pValue As String) As Decimal
        If String.IsNullOrEmpty(pValue) Then
            Return Nothing
        Else
            Try
                Return CDec(pValue)
            Catch
                Return Nothing
            End Try
        End If
    End Function
    Public Function Delete() As Boolean
        Debug.Assert(Not String.IsNullOrEmpty(id), "Id must be set")
        Debug.Assert(Not String.IsNullOrEmpty(idDiag), "IdDiag must be set")
        Dim bReturn As Boolean
        Try
            bReturn = DiagnosticItemManager.delete(id, idDiag)
        Catch ex As Exception
            CSDebug.dispError("DiagnosticHelp12123.Delete ERR :" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Function hasValue() As Boolean
        Dim bReturn As Boolean
        bReturn = True
        Return bReturn

    End Function

    Public Function calcule() As Boolean
        Dim bReturn As Boolean
        Try
            If bCalcule Then
                If m_debitMesure.HasValue And m_PressionMesure.HasValue And m_PressionMoyenne.HasValue And NbBuses.HasValue Then
                    'debitReel = DebitMesure*(Racine(PressionMoyenne/PressionMesure))
                    DebitReel = debitMesure * (Math.Sqrt(PressionMoyenne / PressionMesure))
                    'Debittotal = DebitReel*NbBuses
                    DebitTotal = DebitReel * NbBuses
                Else
                    DebitReel = Nothing
                    'Debittotal = DebitReel*NbBuses
                    DebitTotal = Nothing

                End If
                If m_ReglageDispositif.HasValue And m_debitMesure.HasValue And NbBuses.HasValue Then
                    ' DebitTheorique = (ReglageDisistif/100)*(DebitMesure*NbBuses)
                    DebitTheorique = (ReglageDispositif / 100) * (debitMesure * NbBuses)
                Else
                    DebitTheorique = Nothing
                End If
                If m_TempsMesure.HasValue And m_DebitTotal.HasValue Then
                    'QteEauPulverisee = TempMesure*(DebitTotal/60)
                    QteEauPulverisee = TempsMesure * (DebitTotal / 60)
                Else
                    QteEauPulverisee = Nothing
                End If
                If m_MasseapresAspi.HasValue And m_MasseApresComplement.HasValue Then
                    'QteProduitConso = MasseInitiale-MasseFinal
                    '                    QteProduitConso = MasseInitiale - MasseFinale
                    QteProduitConso = MasseApresComplement - MasseApresAspi
                Else
                    QteProduitConso = Nothing

                End If
                If m_QteProduitConso.HasValue And m_QteEauPulverisee.HasValue Then
                    'DosageReel = QteProduitConso en kg / qteEauPulverisee
                    DosageReel = ((QteProduitConso / 1000) / QteEauPulverisee) * 100
                Else
                    DosageReel = Nothing
                End If
                If m_ReglageDispositif.HasValue And m_DosageReel.HasValue Then
                    'EcartDeReglage = (ReglageDispositif-DosageReel)/DosageReel)*100
                    EcartReglage = ((ReglageDispositif - DosageReel) / DosageReel) * 100
                Else
                    EcartReglage = Nothing

                End If
                If m_EcartReglage.HasValue Then
                    'EcartReglage > 5% => Majeur, sinon OK
                    Resultat = DiagnosticItem.EtatDiagItemOK
                    If Math.Abs(EcartReglage.Value) > LIMITE_ECART_MAJEUR Then
                        Resultat = DiagnosticItem.EtatDiagItemMAJEUR
                    End If
                Else
                    Resultat = String.Empty

                End If
            End If
            bReturn = True
        Catch ex As Exception
            bReturn = False
            CSDebug.dispError("DiagnosticHelp12123 ERR : " & ex.Message)


        End Try
        Return bReturn
    End Function

    Public Overridable Function Clone() As Object Implements ICloneable.Clone
        Dim oXS As New XmlSerializer(Me.GetType())
        Dim oStream As New System.IO.MemoryStream()
        Dim oReturn As DiagnosticHelp12123

        Try


            ' Create a memory stream and a formatter.
            Dim ms As New System.IO.MemoryStream(1000)
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter(Nothing, _
                New System.Runtime.Serialization.StreamingContext(System.Runtime.Serialization.StreamingContextStates.Clone))
            ' Serialize the object into the stream.
            bf.Serialize(ms, Me)
            ' Position streem pointer back to first byte.
            ms.Seek(0, System.IO.SeekOrigin.Begin)
            ' Deserialize into another object.
            oReturn = bf.Deserialize(ms)
            ' release memory.
            ms.Close()
        Catch ex As Exception
            CSDebug.dispError("Diagnostic12123.Clone ERR : " & ex.Message)
            oReturn = Nothing
        End Try
        Return oReturn
    End Function


End Class
