Imports System.Collections.Generic
Public Class AutoTestManager


#Region "Methodes Locales"

    Public Shared Function getById(ByVal pAgent As Agent, ByVal idControle As Integer) As AutoTest
        Debug.Assert(idControle <> 0)
        Dim oReturn As AutoTest
        Dim dbLink As CSDb
        dbLink = New CSDb(True)
        Try
            '## Pr�paration de la connexion
            '## Execution de la requete
            Dim tmpResults As System.Data.OleDb.OleDbDataReader
            tmpResults = dbLink.getResults("SELECT * FROM `Controle_Regulier` WHERE ctrg_id=" & idControle & "")
            '################################################################
            Dim i As Integer = 0
            If tmpResults.HasRows Then
                While tmpResults.Read()
                    oReturn = New AutoTest(pAgent)
                    '# Construction de l'objet
                    Dim tmpColId As Integer = 0
                    While tmpColId < tmpResults.FieldCount()
                        If Not tmpResults.IsDBNull(tmpColId) Then
                            oReturn.Fill(tmpResults.GetName(tmpColId), tmpResults.Item(tmpColId))
                        End If
                        tmpColId = tmpColId + 1
                    End While
                    '###############################
                End While
            End If

            '################################################################
            dbLink.free()
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager::getById(" & idControle & ") : " & ex.Message)
            oReturn = Nothing
        End Try
        If Not dbLink Is Nothing Then
            dbLink.free()
        End If
        Return oReturn
    End Function
    Private Shared Function create(ByVal pAgent As Agent) As AutoTest
        Dim oCSDB As CSDb
        Dim bddCommande As OleDb.OleDbCommand
        Dim oCtrlRegulier As New AutoTest(pAgent)
        Try
            oCSDB = New CSDb(True)
            bddCommande = oCSDB.getConnection().CreateCommand()

            ' Cr�ation
            bddCommande.CommandText = "INSERT INTO Controle_Regulier (CTRG_date) VALUES(NULL)"
            bddCommande.ExecuteNonQuery()

            '## Execution de la requete
            Dim oDBReader As System.Data.OleDb.OleDbDataReader
            Dim sqlQuery As String
            sqlQuery = "SELECT MAX(CTRG_ID) as ctrg_id FROM CONTROLE_REGULIER "
            oDBReader = oCSDB.getResults(sqlQuery)

            '################################################################
            Dim i As Integer = 0
            oDBReader.Read()
            If oDBReader.HasRows Then
                Dim tmpColId As Integer = 0
                If Not oDBReader.IsDBNull(tmpColId) Then
                    oCtrlRegulier.setId(oDBReader.GetInt32(tmpColId))
                End If
            End If

        Catch ex As Exception
            CSDebug.dispFatal("ControleregulierManager - create : " & ex.Message)
        End Try

        If Not oCSDB Is Nothing Then
            oCSDB.free()
        End If

        Return oCtrlRegulier
    End Function
    Public Shared Function save(ByVal pCtrlRegulier As AutoTest, Optional bSyncro As Boolean = False) As Boolean
        Dim bReturn As Boolean
        Dim oCSDB As CSDb

        Try
            bReturn = True
            'Si l'ID n'est pas initialis� => le controle n'a pas �t� cr��
            If pCtrlRegulier.Id = -1 Then
                Dim oTemp As AutoTest
                Dim oAgent As Agent
                oAgent = AgentManager.getAgentById(pCtrlRegulier.NumAgent)
                oTemp = create(oAgent)
                If oTemp.Id = -1 Then
                    CSDebug.dispError("ControleRegulierManager.save ERROR : Impossible de cr�er un nouveau controle")
                    bReturn = False
                Else
                    pCtrlRegulier.setId(oTemp.Id)
                    bReturn = True
                End If
            End If
            If bReturn Then

                If Not bSyncro Then
                    pCtrlRegulier.dateModificationAgent = CSDate.ToCRODIPString(Date.Now).ToString
                End If

                Dim paramsQuery As String
                paramsQuery = ""
                paramsQuery = paramsQuery & " CTRG_date='" & CSDate.ToCRODIPString(pCtrlRegulier.DateControle).Substring(0, 10) & "'  "
                paramsQuery = paramsQuery & " , CTRG_STRUCTUREID=" & pCtrlRegulier.IdStructure & "  "
                paramsQuery = paramsQuery & " , CTRG_TYPE='" & pCtrlRegulier.Type & "'  "
                paramsQuery = paramsQuery & " , CTRG_MATID='" & pCtrlRegulier.IdMateriel & "'  "
                paramsQuery = paramsQuery & " , CTRG_ETAT=" & pCtrlRegulier.Etat & " "
                paramsQuery = paramsQuery & " , CTRG_NUMAGENT='" & pCtrlRegulier.NumAgent & "' "
                paramsQuery = paramsQuery & " , dateModificationAgent='" & CSDate.mysql2access(pCtrlRegulier.dateModificationAgent) & "'"
                paramsQuery = paramsQuery & " , dateModificationCrodip='" & CSDate.mysql2access(pCtrlRegulier.dateModificationCrodip) & "'"

                ' On finalise la requete et en l'execute
                oCSDB = New CSDb(True)
                Dim bddCommande As OleDb.OleDbCommand
                bddCommande = oCSDB.getConnection().CreateCommand

                bddCommande.CommandText = "Update CONTROLE_REGULIER set " & paramsQuery & " WHERE CTRG_ID=" & pCtrlRegulier.Id & ""
                bddCommande.ExecuteNonQuery()
                oCSDB.free()
            End If
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager.save ERROR" & ex.Message)
            bReturn = False
        End Try
        If Not oCSDB Is Nothing Then
            oCSDB.free()
        End If
        Return bReturn
    End Function

    Public Shared Function saveSynchro(ByVal pCtrlRegulier As AutoTest) As Boolean
        Dim bReturn As Boolean
        Dim oCSDB As CSDb

        Try
            bReturn = True
            'Si l'ID n'est pas initialis� => le controle n'a pas �t� cr��
            If pCtrlRegulier.Id = -1 Then
                bReturn = False
            End If
            If bReturn Then


                Dim paramsQuery As String
                paramsQuery = ""
                paramsQuery = paramsQuery & " dateModificationCrodip='" & CSDate.mysql2access(pCtrlRegulier.dateModificationCrodip) & "'"

                ' On finalise la requete et en l'execute
                oCSDB = New CSDb(True)
                Dim bddCommande As OleDb.OleDbCommand
                bddCommande = oCSDB.getConnection().CreateCommand

                bddCommande.CommandText = "Update CONTROLE_REGULIER set " & paramsQuery & " WHERE CTRG_ID=" & pCtrlRegulier.Id & ""
                bddCommande.ExecuteNonQuery()
                oCSDB.free()
            End If
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager.saveSynchro ERROR" & ex.Message)
            bReturn = False
        End Try
        If Not oCSDB Is Nothing Then
            oCSDB.free()
        End If
        Return bReturn
    End Function
    Public Shared Function delete(ByVal curObject As AutoTest) As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = AutoTestManager.delete(curObject.Id)
        Catch ex As Exception
            CSDebug.dispFatal("ControleManoManager::delete() : " & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Shared Function delete(ByVal pIdControle As Integer) As Boolean
        Dim bReturn As Boolean

        Try
            Dim bdd As New CSDb(True)
            bdd.getResults("DELETE FROM `Controle_Regulier` WHERE `ctrg_id`=" & pIdControle & "")
            bdd.free()
            bReturn = True
        Catch ex As Exception
            CSDebug.dispFatal("ControleManoManager::delete() : " & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    ''' <summary>
    ''' Rend une collection contenant les controle reguliers effectu�s
    ''' </summary>
    ''' <param name="idStructure"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getcolControlesReguliers(ByVal pAgent As Agent, Optional ByVal pTypeMateriels As String = "TOUS", Optional ByVal pDateDeb As String = "JJ/MM/AAAA", Optional ByVal pDateFin As String = "JJ/MM/AAAA", Optional ByVal pSynchro As Boolean = False) As Collection
        Dim ocolReturn As New Collection
        Try
            If Not pAgent Is Nothing Then
                '## Pr�paration de la connexion
                Dim dbLink As New CSDb(True)
                '## Execution de la requete
                Dim oDBReader As System.Data.OleDb.OleDbDataReader
                Dim sqlQuery As String
                sqlQuery = "SELECT * FROM CONTROLE_REGULIER WHERE CTRG_NUMAGENT='" & pAgent.id & "' "
                If Not (pTypeMateriels = "TOUS" Or String.IsNullOrEmpty(pTypeMateriels)) Then
                    sqlQuery = sqlQuery & " AND CTRG_TYPE = '" & pTypeMateriels & "' "
                End If
                If pDateDeb <> "JJ/MM/AAAA" Then
                    sqlQuery = sqlQuery & " AND CTRG_date >=#" & CSDate.ToCRODIPString(pDateDeb).Substring(0, 10) & "#"
                End If
                If pDateFin <> "JJ/MM/AAAA" Then
                    sqlQuery = sqlQuery & " AND CTRG_date <=#" & CSDate.ToCRODIPString(pDateFin).Substring(0, 10) & "#"
                End If
                If pSynchro Then
                    sqlQuery = sqlQuery & " AND dateModificationAgent > dateModificationCrodip "
                End If
                oDBReader = dbLink.getResults(sqlQuery & " ORDER BY CTRG_ID")

                '################################################################
                Dim i As Integer = 0
                While oDBReader.Read()
                    '# Construction de l'objet
                    Dim tmpObject As New ControleMano(pAgent)
                    Dim tmpColId As Integer = 0
                    Dim oDBCtrl As New AutoTest(pAgent)
                    oDBCtrl.Fill(oDBReader)
                    ocolReturn.Add(oDBCtrl)
                End While
                dbLink.free()
            End If
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager::getcolControlesReguliers(" & pAgent.numeroNational & ") : " & ex.Message)
            ocolReturn = Nothing
        End Try
        Return ocolReturn
    End Function
    ''' <summary>
    ''' Cr�ation des controles
    ''' </summary>
    ''' <param name="pTypeMateriels"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateControlesReguliers(ByVal pAgent As Agent, ByVal pDateControle As Date, Optional ByVal pTypeMateriels As String = "TOUS") As Collection
        Dim bReturn As Boolean
        Dim oCtrlRegulier As AutoTest
        Dim oColReturn As Collection = New Collection()
        Try
            If pTypeMateriels.ToUpper() = "BANC" Or pTypeMateriels.ToUpper() = "TOUS" Then
                Dim arrBanc As System.Collections.Generic.List(Of Banc)
                ' On r�cup�re les bancs de l'agent
                arrBanc = BancManager.getBancByStructureId(pAgent.idStructure, True)
                For Each oBanc As Banc In arrBanc
                    oCtrlRegulier = New AutoTest(pAgent, oBanc)
                    oCtrlRegulier.DateControle = pDateControle
                    oColReturn.Add(oCtrlRegulier)
                Next
            End If
            If pTypeMateriels.ToUpper() = "MANOC" Or pTypeMateriels.ToUpper() = "TOUS" Then
                Dim arrManoC As List(Of ManometreControle)
                ' On r�cup�re les Mano de Controle  de la structure
                arrManoC = ManometreControleManager.getManoControleByStructureId(pAgent.idStructure, True)
                For Each oManoC As ManometreControle In arrManoC
                    oCtrlRegulier = New AutoTest(pAgent, oManoC)
                    oCtrlRegulier.DateControle = pDateControle
                    oColReturn.Add(oCtrlRegulier)
                Next
            End If
            'If pTypeMateriels = "MANOE" Or pTypeMateriels.ToUpper() = "TOUS" Then
            '    Dim arrManoE As ManometreEtalon()
            '    ' On r�cup�re les Mano de Etalons  de l'agent
            '    arrManoE = AgentManager.getManoEtalon(pIdStructure, True)
            '    For Each oManoE As ManometreEtalon In arrManoE
            '        oCtrlRegulier = New ControleRegulier(oManoE)
            '        oCtrlRegulier.DateControle = pDateControle
            '        oColReturn.Add(oCtrlRegulier)
            '    Next
            'End If
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager.CreateControlesReguliers Error " & ex.Message)
            bReturn = False
        End Try

        Return oColReturn
    End Function

    ''' <summary>
    ''' Export des controlesReguliers au format CSV
    ''' </summary>
    ''' <param name="pTypeMateriels"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExportAsCSV(ByVal dDeb As String, ByVal dFin As String, ByVal pAgent As Agent, ByVal pCSVFile As String, Optional ByVal pTypeMateriels As String = "TOUS") As Boolean
        Dim bReturn As Boolean
        Dim oCtrlRegulier As AutoTest
        Dim oCol As Collection
        Try
            If System.IO.File.Exists(pCSVFile) Then
                System.IO.File.Delete(pCSVFile)
            End If
            Dim oFile As System.IO.StreamWriter
            oFile = System.IO.File.CreateText(pCSVFile)

            oCol = AutoTestManager.getcolControlesReguliers(pAgent, pTypeMateriels, dDeb, dFin)
            oFile.WriteLine("ID;DateControle;IDStructure;NumAgent;type;IdMateriel;etat;dateModifAgent;dateModifCrodip")
            Dim strLine As String
            For Each oCtrlRegulier In oCol
                strLine = oCtrlRegulier.Id & ";" & oCtrlRegulier.DateControle.ToString("d") & ";" & oCtrlRegulier.IdStructure & ";" & oCtrlRegulier.NumAgent & ";" & oCtrlRegulier.TypeLibelle & ";" & oCtrlRegulier.IdMateriel & ";" & oCtrlRegulier.Etat & ";" & oCtrlRegulier.dateModificationAgent & ";" & oCtrlRegulier.dateModificationCrodip
                oFile.WriteLine(strLine)
            Next
            oFile.Close()
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("ControleRegulierManager.ExportAsCSV Error " & ex.Message)
            bReturn = False
        End Try

        Return bReturn
    End Function
#End Region

    Public Shared Function sendWSControlesReguliers(ByVal pAgent As Agent) As Boolean
        Dim bReturn As Boolean

        Try
            Dim oCol As Collection
            oCol = getcolControlesReguliers(pAgent, , , , True)
            If Not oCol Is Nothing Then
                If oCol.Count > 0 Then
                    Dim ArrObject(oCol.Count) As AutoTest
                    Dim objWSCrodip As WSCrodip_prod.CrodipServer = WSCrodip.getWS()
                    Dim i As Integer
                    i = 0
                    For Each obj As AutoTest In oCol
                        ArrObject(i) = obj
                        i = i + 1
                    Next
                    Dim response As Integer = objWSCrodip.SendAutoTest(ArrObject)
                    If response = 0 Or response = 2 Or (GLOB_ENV_DEBUG And response = 9) Then
                        'Mise � jour de la date de synchro (date Modification CRODIP)
                        For Each obj As AutoTest In oCol
                            obj.dateModificationCrodip = CSDate.ToCRODIPString(Now())
                            saveSynchro(obj)
                        Next

                    End If
                End If
            End If
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("sendWSManometreControle : " & ex.Message & ex.InnerException.InnerException.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    'Public Shared Function sendWS2ControlesReguliers(ByVal pAgent As Agent) As Boolean
    '    Dim bReturn As Boolean

    '    Try
    '        Dim oCol As Collection
    '        oCol = getcolControlesReguliers(pAgent, , , , True)
    '        If Not oCol Is Nothing Then
    '            Dim ArrObject(oCol.Count) As AutoTest
    '            Dim objWSCrodip As WSCrodip2.CrodipServerClient = WSCrodip.getWS2()
    '            Dim i As Integer
    '            i = 0
    '            For Each obj As AutoTest In oCol
    '                ArrObject(i) = obj
    '                i = i + 1
    '            Next
    '            objWSCrodip.SendAutoTest(ArrObject)
    '        End If
    '        bReturn = True
    '    Catch ex As Exception
    '        CSDebug.dispError("sendWSManometreControle : " & ex.Message & ex.InnerException.InnerException.Message)
    '        bReturn = False
    '    End Try
    '    Return bReturn
    'End Function

End Class
