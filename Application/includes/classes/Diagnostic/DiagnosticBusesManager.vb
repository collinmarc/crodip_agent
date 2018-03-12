Public Class DiagnosticBusesManager

#Region "Methodes Web Service"

    Public Shared Function getWSDiagnosticBusesById(ByVal diag_id As String) As DiagnosticBusesList
        Dim objDiagnosticBusesList As New DiagnosticBusesList
        Dim objDiagnosticBuses As New DiagnosticBuses
        Try

            ' d�clarations
            Dim objWSCrodip As WSCrodip_prod.CrodipServer = WSCrodip.getWS()
            Dim objWSCrodip_response As Object
            ' Appel au WS
            Dim codeResponse As Integer = objWSCrodip.GetDiagnosticBuses(agentCourant.id, diag_id, objWSCrodip_response)
            Select Case codeResponse
                Case 0 ' OK
                    ' construction de l'objet
                    Dim objWSCrodip_responseItem1 As System.Xml.XmlNode()
                    Dim objWSCrodip_responseItem As System.Xml.XmlNode
                    For Each objWSCrodip_responseItem1 In objWSCrodip_response
                        objDiagnosticBuses = New DiagnosticBuses()
                        For Each objWSCrodip_responseItem In objWSCrodip_responseItem1
                            Select Case objWSCrodip_responseItem.Name()
                                Case "id"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.id = CType(objWSCrodip_responseItem.InnerText(), Integer)
                                    End If
                                Case "idDiagnostic"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.idDiagnostic = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "idLot"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.idLot = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "marque"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.marque = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "nombre"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.nombre = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "genre"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.genre = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "calibre"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.calibre = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "ecartTolere"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.ecartTolere = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "couleur"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.couleur = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "debitMoyen"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.debitMoyen = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "debitNominal"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.debitNominal = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                                Case "dateModificationAgent"
                                    If objWSCrodip_responseItem.InnerText() <> "" Then
                                        objDiagnosticBuses.dateModificationAgent = CType(objWSCrodip_responseItem.InnerText(), String)
                                    End If
                            End Select
                        Next
                        objDiagnosticBusesList.Liste.Add(objDiagnosticBuses)
                    Next
                Case 1 ' NOK
                    'CSDebug.dispError("Erreur - DiagnosticBusesManager - Code 1 : Non-Trouv�e [" & diagnosticbuses_id & "]")
                Case 9 ' BADREQUEST
                    'CSDebug.dispError("Erreur - DiagnosticBusesManager - Code 9 : Bad Request")
            End Select
        Catch ex As Exception
            CSDebug.dispError("DiagnosticBusesManager.getWSDiagnosticBusesById ERR : " & ex.Message)
        End Try
        Return objDiagnosticBusesList

    End Function

    Public Shared Function sendWSDiagnosticBuses(pAgent As Agent, ByVal objDiagnosticBuses As DiagnosticBusesList, ByRef updatedObject As Object) As Integer
        Dim tmpArr(1)() As DiagnosticBuses
        tmpArr(0) = objDiagnosticBuses.Liste.ToArray()
        Try
            ' Appel au WS
            Dim objWSCrodip As WSCrodip_prod.CrodipServer = WSCrodip.getWS()
            Return objWSCrodip.SendDiagnosticBuses(pAgent.id, tmpArr, updatedObject)
        Catch ex As Exception
            CSDebug.dispFatal("DiagnosticBusesManager.SendWSDiagnosticBuses ERR" & ex.Message & ":" & ex.InnerException.Message)
            Return -1
        End Try
    End Function

    Public Shared Function xml2object(ByVal arrXml As Object) As DiagnosticBuses
        Dim objDiagnosticBuses As New DiagnosticBuses

        For Each tmpSerializeItem As System.Xml.XmlElement In arrXml
            Select Case Trim(tmpSerializeItem.LocalName()).ToUpper
                Case "id".ToUpper()
                    objDiagnosticBuses.id = CType(tmpSerializeItem.InnerText, Integer)
                Case "idDiagnostic".ToUpper()
                    objDiagnosticBuses.idDiagnostic = CType(tmpSerializeItem.InnerText, String)
                Case "idLot".ToUpper()
                    objDiagnosticBuses.idLot = CType(tmpSerializeItem.InnerText, String)
                Case "marque".ToUpper()
                    objDiagnosticBuses.marque = CType(tmpSerializeItem.InnerText, String)
                Case "nombre".ToUpper()
                    objDiagnosticBuses.nombre = CType(tmpSerializeItem.InnerText, String)
                Case "genre".ToUpper()
                    objDiagnosticBuses.genre = CType(tmpSerializeItem.InnerText, String)
                Case "calibre".ToUpper()
                    objDiagnosticBuses.calibre = CType(tmpSerializeItem.InnerText, String)
                Case "ecartTolere".ToUpper()
                    objDiagnosticBuses.ecartTolere = CType(tmpSerializeItem.InnerText, String)
                Case "couleur".ToUpper()
                    objDiagnosticBuses.couleur = CType(tmpSerializeItem.InnerText, String)
                Case "debitMoyen".ToUpper()
                    objDiagnosticBuses.debitMoyen = CType(tmpSerializeItem.InnerText, String)
                Case "debitNominal".ToUpper()
                    objDiagnosticBuses.debitNominal = CType(tmpSerializeItem.InnerText, String)
                Case "dateModificationAgent".ToUpper()
                    objDiagnosticBuses.dateModificationAgent = CSDate.ToCRODIPString(CType(tmpSerializeItem.InnerText, String))
            End Select
        Next

        Return objDiagnosticBuses
    End Function

#End Region

#Region "Methodes Locales"

    'Public Function getNewId(ByVal structure_id As String)
    '    ' d�clarations
    '    Dim tmpDiagnosticId As String = structure_id & "-" & agentCourant.id & "-1"
    '    If structure_id <> "" And structure_id <> "0" Then

    '        Dim bddCommande As New OleDb.OleDbCommand
    '        ' On test si la connexion est d�j� ouverte ou non
    '        If bddConnection.State() = 0 Then
    '            ' Si non, on la configure et on l'ouvre
    '            bddConnection.ConnectionString = bddConnectString
    '            bddConnection.Open()
    '        End If
    '        bddCommande.Connection = bddConnection
    '        bddCommande.CommandText = "SELECT `DiagnosticItem`.`id` FROM `DiagnosticItem` WHERE `DiagnosticItem`.`id` LIKE '" & structure_id & "-" & agentCourant.id & "-%' ORDER BY `DiagnosticItem`.`id` DESC"
    '        Try
    '            ' On r�cup�re les r�sultats
    '            Dim tmpListProfils As System.Data.OleDb.OleDbDataReader = bddCommande.ExecuteReader
    '            ' Puis on les parcours
    '            Dim newId As Integer = 0
    '            While tmpListProfils.Read()
    '                ' On r�cup�re le dernier ID
    '                Dim tmpId As Integer = 0
    '                tmpDiagnosticId = tmpListProfils.Item(0).ToString
    '                tmpId = CInt(tmpDiagnosticId.Replace(structure_id & "-" & agentCourant.id & "-", ""))
    '                If tmpId > newId Then
    '                    newId = tmpId
    '                End If
    '            End While
    '            tmpDiagnosticId = structure_id & "-" & agentCourant.id & "-" & (newId + 1)
    '        Catch ex As Exception ' On intercepte l'erreur
    '            Console.Write("DiagnosticManager - newId : " & ex.Message)
    '        End Try

    '        ' Test pour fermeture de connection BDD
    '        If bddConnection.State() <> 0 Then
    '            ' On ferme la connexion
    '            bddConnection.Close()
    '        End If

    '    End If
    '    'on retourne le nouvel id
    '    Return tmpDiagnosticId
    'End Function

    Public Shared Sub save(ByVal objDiagnosticBuses As DiagnosticBuses, Optional bSyncro As Boolean = False)

        Dim oCSDb As New CSDb(True)
        Try
            Dim bddCommande As OleDb.OleDbCommand
            Dim oDR As OleDb.OleDbDataReader
            Dim nEnr As Integer
            bddCommande = oCSDb.getConnection().CreateCommand()

            'Test de l'existence de l'�lement
            bddCommande.CommandText = "SELECT count(*) FROM DiagnosticBuses WHERE id = " & objDiagnosticBuses.id & " and idDiagnostic = '" & objDiagnosticBuses.idDiagnostic & "'"
            oDR = bddCommande.ExecuteReader()
            If oDR.HasRows Then
                oDR.Read()
                Try
                    nEnr = CType(oDR.GetValue(0), Integer)
                Catch ex As Exception
                    nEnr = 0
                End Try
            End If
            oDR.Close()

            If Not bSyncro Then
                objDiagnosticBuses.dateModificationAgent = CSDate.ToCRODIPString(Date.Now).ToString
            End If

            If nEnr = 0 Then
                'Cr�ation de l'enregistrement
                ' Initialisation de la requete
                Dim paramsQueryColomuns As String = "`idDiagnostic`,`idLot`"
                Dim paramsQuery As String = "'" & objDiagnosticBuses.idDiagnostic & "','" & objDiagnosticBuses.idLot & "'"

                ' Mise a jour de la date de derniere modification

                If Not objDiagnosticBuses.marque Is Nothing And objDiagnosticBuses.marque <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `marque`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.marque & "'"
                End If
                If Not objDiagnosticBuses.nombre Is Nothing And objDiagnosticBuses.nombre <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `nombre`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.nombre & "'"
                End If
                If Not objDiagnosticBuses.genre Is Nothing And objDiagnosticBuses.genre <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `genre`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.genre & "'"
                End If
                If Not objDiagnosticBuses.calibre Is Nothing And objDiagnosticBuses.calibre <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `calibre`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.calibre & "'"
                End If
                If Not objDiagnosticBuses.ecartTolere Is Nothing And objDiagnosticBuses.ecartTolere <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `ecartTolere`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.ecartTolere & "'"
                End If
                If Not objDiagnosticBuses.couleur Is Nothing And objDiagnosticBuses.couleur <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `couleur`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.couleur & "'"
                End If
                If Not objDiagnosticBuses.debitMoyen Is Nothing And objDiagnosticBuses.debitMoyen <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `debitMoyen`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.debitMoyen & "'"
                End If
                If Not objDiagnosticBuses.debitNominal Is Nothing And objDiagnosticBuses.debitNominal <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `debitNominal`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.debitNominal & "'"
                End If
                If Not objDiagnosticBuses.dateModificationAgent Is Nothing And objDiagnosticBuses.dateModificationAgent <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `dateModificationAgent`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.dateModificationAgent & "'"
                End If
                If Not objDiagnosticBuses.dateModificationCrodip Is Nothing And objDiagnosticBuses.dateModificationCrodip <> "" Then
                    paramsQueryColomuns = paramsQueryColomuns & " , `dateModificationCrodip`"
                    paramsQuery = paramsQuery & " , '" & objDiagnosticBuses.dateModificationCrodip & "'"
                End If

                ' On finalise la requete et en l'execute
                bddCommande.CommandText = "INSERT INTO `DiagnosticBuses` (" & paramsQueryColomuns & ") VALUES (" & paramsQuery & ")"
                bddCommande.ExecuteNonQuery()
                'oCSDb.free()
                'oCSDb = New CSDb(True)
                bddCommande = oCSDb.getConnection().CreateCommand()
                bddCommande.CommandText = "SELECT MAX(id) from DiagnosticBuses"
                oDR = bddCommande.ExecuteReader()
                If oDR.HasRows() Then
                    oDR.Read()
                    objDiagnosticBuses.id = oDR.GetValue(0)
                End If
                oDR.Close()
                oCSDb.free()
            Else
                'Mise � jour de l'enregistrement
                Dim paramQuery As String

                paramQuery = "id=" & objDiagnosticBuses.id
                paramQuery = paramQuery & ",idDiagnostic = '" & objDiagnosticBuses.idDiagnostic & "'"
                paramQuery = paramQuery & ",marque = '" & objDiagnosticBuses.marque & "'"
                paramQuery = paramQuery & ",nombre = '" & objDiagnosticBuses.nombre & "'"
                paramQuery = paramQuery & ",genre = '" & objDiagnosticBuses.genre & "'"
                paramQuery = paramQuery & ",calibre = '" & objDiagnosticBuses.calibre & "'"
                paramQuery = paramQuery & ",couleur = '" & objDiagnosticBuses.couleur & "'"
                paramQuery = paramQuery & ",debitMoyen = '" & objDiagnosticBuses.debitMoyen & "'"
                paramQuery = paramQuery & ",debitNominal = '" & objDiagnosticBuses.debitNominal & "'"
                paramQuery = paramQuery & ",dateModificationAgent = '" & objDiagnosticBuses.dateModificationAgent & "'"
                If Not String.IsNullOrEmpty(objDiagnosticBuses.dateModificationCrodip) Then
                    paramQuery = paramQuery & ",dateModificationCrodip = '" & objDiagnosticBuses.dateModificationCrodip & "'"
                End If
                paramQuery = paramQuery & ",idLot = '" & objDiagnosticBuses.idLot & "'"
                paramQuery = paramQuery & ",ecartTolere = '" & objDiagnosticBuses.ecartTolere & "'"

                bddCommande.CommandText = "UPDATE DiagnosticBuses SET " & paramQuery & " WHERE id = " & objDiagnosticBuses.id & " and idDiagnostic = '" & objDiagnosticBuses.idDiagnostic & "'"
                bddCommande.ExecuteNonQuery()

            End If
            ' Test pour fermeture de connection BDD
            oCSDb.free()

            ' On enregistre le d�tail des buses
            If Not objDiagnosticBuses.diagnosticBusesDetail Is Nothing Then
                If Not objDiagnosticBuses.diagnosticBusesDetail.Liste Is Nothing Then
                    Dim i As Integer = 0
                    For Each tmpItemCheck As DiagnosticBusesDetail In objDiagnosticBuses.diagnosticBusesDetail.Liste
                        If Not tmpItemCheck Is Nothing Then
                            tmpItemCheck.idDiagnostic = objDiagnosticBuses.idDiagnostic
                            tmpItemCheck.idLot = objDiagnosticBuses.idLot
                            DiagnosticBusesDetailManager.save(tmpItemCheck)
                        End If
                        i = i + 1
                    Next
                End If
            End If

        Catch ex As Exception
            CSDebug.dispFatal("DiagBusesManager.save : " & ex.Message.ToString)
        End Try

        If oCSDb IsNot Nothing Then
            oCSDb.free()
        End If
    End Sub

    Public Shared Sub setSynchro(ByVal objDiagnosticBuses As DiagnosticBuses)
        Try
            Dim dbLink As New CSDb(True)
            Dim newDate As String = Date.Now.ToString
            dbLink.queryString = "UPDATE `DiagnosticBuses` SET `DiagnosticBuses`.`dateModificationCrodip`='" & newDate & "',`DiagnosticBuses`.`dateModificationAgent`='" & newDate & "' WHERE `DiagnosticBuses`.`id`='" & objDiagnosticBuses.id & "'"
            dbLink.getResults()
            dbLink.free()
        Catch ex As Exception
            CSDebug.dispFatal("DiagnosticBusesManager::setSynchro : " & ex.Message)
        End Try
    End Sub
    Public Shared Function setDiagnosticNbreLotsBuses(pDiagnostic As Diagnostic) As Boolean
        Dim bReturn As Boolean
        Dim oCSDB As New CSDb(True)
        Try
            Dim nColId As Integer
            Dim bddCommande3 As OleDb.OleDbCommand = oCSDB.getConnection().CreateCommand()
            bddCommande3.CommandText = "SELECT MAX(IDLOT) FROM DiagnosticBuses WHERE DiagnosticBuses.idDiagnostic='" & pDiagnostic.id & "'"
            ' On r�cup�re les r�sultats
            Dim oDR As System.Data.OleDb.OleDbDataReader = bddCommande3.ExecuteReader
            If oDR.HasRows Then
                oDR.Read()
                If oDR.IsDBNull(0) Then
                    pDiagnostic.NbreLotsBuses = 0
                Else

                    pDiagnostic.NbreLotsBuses = CInt(oDR.item(0))
                End If
            Else
                pDiagnostic.NbreLotsBuses = 1
            End If
            oDR.Close()
        Catch ex As Exception
            CSDebug.dispError("DiagnosticBusesManager.setDiagnosticNbreLotsBuses ERR" & ex.Message.ToString())
            bReturn = False
        End Try
        oCSDB.free()
        Return bReturn


    End Function

    Public Shared Function getDiagnosticBusesByDiagnostic(pDiagnostic As Diagnostic) As Boolean
        Dim bReturn As Boolean
        Dim oCSDB As New CSDb(True)
        Try
            pDiagnostic.diagnosticBusesList.Liste.Clear()
            'R�cup�ration du nbre de Lots de Buses
            setDiagnosticNbreLotsBuses(pDiagnostic)

            'Pour Chaqun des lots 
            For nLot As Integer = 1 To pDiagnostic.NbreLotsBuses
                'Recup�ration des infos de Buses
                Dim nColId As Integer
                Dim bddCommande3 As OleDb.OleDbCommand = oCSDB.getConnection().CreateCommand()
                bddCommande3.CommandText = "SELECT * FROM DiagnosticBuses WHERE DiagnosticBuses.idDiagnostic='" & pDiagnostic.id & "' AND IDLOT = '" & nLot & "'"
                Dim oDRDiagnosticBuses As System.Data.OleDb.OleDbDataReader = bddCommande3.ExecuteReader
                'Normalement on en a qu'un type de buse / Lot mais suite � un bug (synchro) il se peut qu'on en ait plusieurs
                '=> on cumule les infos dans le m�me objet
                Dim oDiagnosticBuses As New DiagnosticBuses
                While oDRDiagnosticBuses.Read()
                    nColId = 0
                    While nColId < oDRDiagnosticBuses.FieldCount()
                        If Not oDRDiagnosticBuses.IsDBNull(nColId) Then
                            oDiagnosticBuses.Fill(oDRDiagnosticBuses.GetName(nColId), oDRDiagnosticBuses.GetValue(nColId))
                        End If
                        nColId = nColId + 1
                    End While
                End While
                oDRDiagnosticBuses.Close()

                'On ajoute la buse dans la liste 
                pDiagnostic.diagnosticBusesList.Liste.Add(oDiagnosticBuses)

                'On va ensuite chercher les infos de mesure de ce Lot
                Dim bddCommande4 As OleDb.OleDbCommand = oCSDB.getConnection().CreateCommand()
                bddCommande4.CommandText = "SELECT * FROM DiagnosticBusesDetail WHERE idDiagnostic='" & pDiagnostic.id & "' AND IDLOT = " & nLot & ""
                Dim oDRDiagBusesDetail As System.Data.OleDb.OleDbDataReader = bddCommande4.ExecuteReader
                Dim tmpBuseDetail As DiagnosticBusesDetail
                While oDRDiagBusesDetail.Read()
                    'Creation de l'objet BuseDetail pour recevoir la mesure
                    tmpBuseDetail = New DiagnosticBusesDetail()
                    ' On remplit L'object
                    nColId = 0
                    While nColId < oDRDiagBusesDetail.FieldCount()
                        If Not oDRDiagBusesDetail.IsDBNull(nColId) Then
                            tmpBuseDetail.Fill(oDRDiagBusesDetail.GetName(nColId), oDRDiagBusesDetail.GetValue(nColId))
                        End If
                        nColId = nColId + 1
                    End While
                    'On l'ajoute � la collection de mesures de la buse
                    oDiagnosticBuses.diagnosticBusesDetail.Liste.Add(tmpBuseDetail)
                End While
                oDRDiagBusesDetail.Close()

            Next nLot


            oCSDB.free()
        Catch ex As Exception
            CSDebug.dispError("DiagnosticBusesManager.getDiagnosticBusesByDiagnosticId ERR" & ex.Message.ToString())
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Shared Function getDiagnosticBusesById(ByVal diagnosticbuses_id As String, ByVal pidDiagnostic As String) As DiagnosticBuses
        Debug.Assert(Not String.IsNullOrEmpty(diagnosticbuses_id))
        Debug.Assert(Not String.IsNullOrEmpty(pidDiagnostic))
        ' d�clarations
        Dim oCSDB As New CSDb(True)
        Dim tmpDiagnosticBuses As New DiagnosticBuses
        If diagnosticbuses_id <> "" Then

            Dim bddCommande As OleDb.OleDbCommand
            bddCommande = oCSDB.getConnection().CreateCommand()
            bddCommande.CommandText = "SELECT * FROM DiagnosticBuses WHERE DiagnosticBuses.id=" & diagnosticbuses_id & " and idDiagnostic = '" & pidDiagnostic & "'"
            Try
                ' On r�cup�re les r�sultats
                Dim tmpListProfils As System.Data.OleDb.OleDbDataReader = bddCommande.ExecuteReader
                ' Puis on les parcours
                While tmpListProfils.Read()
                    ' On rempli notre tableau
                    Dim tmpColId As Integer = 0
                    While tmpColId < tmpListProfils.FieldCount()
                        Select Case tmpListProfils.GetName(tmpColId)
                            Case "id"
                                tmpDiagnosticBuses.id = tmpListProfils.Item(tmpColId)
                            Case "idDiagnostic"
                                tmpDiagnosticBuses.idDiagnostic = tmpListProfils.Item(tmpColId).ToString()
                            Case "idLot"
                                tmpDiagnosticBuses.idLot = tmpListProfils.Item(tmpColId).ToString()
                            Case "marque"
                                tmpDiagnosticBuses.marque = tmpListProfils.Item(tmpColId).ToString()
                            Case "nombre"
                                tmpDiagnosticBuses.nombre = tmpListProfils.Item(tmpColId).ToString()
                            Case "genre"
                                tmpDiagnosticBuses.genre = tmpListProfils.Item(tmpColId).ToString()
                            Case "calibre"
                                tmpDiagnosticBuses.calibre = tmpListProfils.Item(tmpColId).ToString()
                            Case "ecartTolere"
                                tmpDiagnosticBuses.ecartTolere = tmpListProfils.Item(tmpColId).ToString()
                            Case "couleur"
                                tmpDiagnosticBuses.couleur = tmpListProfils.Item(tmpColId).ToString()
                            Case "debitMoyen"
                                tmpDiagnosticBuses.debitMoyen = tmpListProfils.Item(tmpColId).ToString()
                            Case "debitNominal"
                                tmpDiagnosticBuses.debitNominal = tmpListProfils.Item(tmpColId).ToString()
                            Case "dateModificationAgent"
                                tmpDiagnosticBuses.dateModificationAgent = CSDate.ToCRODIPString(tmpListProfils.Item(tmpColId).ToString())
                        End Select
                        tmpColId = tmpColId + 1
                    End While
                End While
            Catch ex As Exception ' On intercepte l'erreur
                MsgBox("DiagnosticBusesManager Error: " & ex.Message)
            End Try
            oCSDB.free()

            'Cette m�thode ne charge pas les BusesDetail, 
            'il faut passer par GetDiagnosticBusesByDiagnostic qui met � jour le diag
        End If
        'on retourne le diagnosticbuses ou un objet vide en cas d'erreur
        Return tmpDiagnosticBuses
    End Function

    Public Shared Function delete(ByVal diagnosticbuses_id As String, ByVal pidDiagnostic As String) As Boolean
        Debug.Assert(Not String.IsNullOrEmpty(diagnosticbuses_id))
        Debug.Assert(Not String.IsNullOrEmpty(pidDiagnostic))
        ' d�clarations
        Dim bReturn As Boolean
        Dim oDiagBuses As DiagnosticBuses
        Try

            oDiagBuses = DiagnosticBusesManager.getDiagnosticBusesById(diagnosticbuses_id, pidDiagnostic)
            If oDiagBuses IsNot Nothing Then
                Dim oCSDB As New CSDb(True)
                Dim bddCommande As OleDb.OleDbCommand
                bddCommande = oCSDB.getConnection().CreateCommand()
                bddCommande.CommandText = "DELETE FROM DiagnosticBusesDetail WHERE idLot=" & oDiagBuses.idLot & " and idDiagnostic = '" & pidDiagnostic & "'"
                bddCommande.ExecuteNonQuery()
                bddCommande.CommandText = "DELETE FROM DiagnosticBuses WHERE id=" & diagnosticbuses_id & " and idDiagnostic = '" & pidDiagnostic & "'"
                bddCommande.ExecuteNonQuery()
                oCSDB.free()
            End If
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("DiagnosticBusesManager.delete ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Shared Function deleteByDiagnosticId(ByVal pidDiagnostic As String) As Boolean
        Debug.Assert(Not String.IsNullOrEmpty(pidDiagnostic))
        ' d�clarations
        Dim bReturn As Boolean
        Dim oDiagBuses As DiagnosticBuses
        Try

            Dim oCSDB As New CSDb(True)
            Dim bddCommande As OleDb.OleDbCommand
            bddCommande = oCSDB.getConnection().CreateCommand()
            bddCommande.CommandText = "DELETE FROM DiagnosticBusesDetail WHERE  idDiagnostic = '" & pidDiagnostic & "'"
            bddCommande.ExecuteNonQuery()
            bddCommande.CommandText = "DELETE FROM DiagnosticBuses WHERE idDiagnostic = '" & pidDiagnostic & "'"
            bddCommande.ExecuteNonQuery()
            oCSDB.free()
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("DiagnosticBusesManager.delete ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Shared Function getUpdates() As DiagnosticBuses()
        ' d�clarations
        Dim arrItems(0) As DiagnosticBuses
        Dim bddCommande As OleDb.OleDbCommand
        Dim oCSDB As New CSDb(True)
        bddCommande = oCSDB.getConnection.CreateCommand()
        bddCommande.CommandText = "SELECT * FROM `DiagnosticBuses` WHERE `DiagnosticBuses`.`dateModificationAgent`<>`DiagnosticBuses`.`dateModificationCrodip`"

        Try
            ' On r�cup�re les r�sultats
            Dim tmpListProfils As System.Data.OleDb.OleDbDataReader = bddCommande.ExecuteReader
            Dim i As Integer = 0
            ' Puis on les parcours
            While tmpListProfils.Read()
                ' On rempli notre tableau
                Dim tmpDiagnosticBuses As New DiagnosticBuses
                Dim tmpColId As Integer = 0
                While tmpColId < tmpListProfils.FieldCount()
                    Select Case tmpListProfils.GetName(tmpColId)
                        Case "id"
                            tmpDiagnosticBuses.id = tmpListProfils.Item(tmpColId)
                        Case "idDiagnostic"
                            tmpDiagnosticBuses.idDiagnostic = tmpListProfils.Item(tmpColId).ToString()
                        Case "idLot"
                            tmpDiagnosticBuses.idLot = tmpListProfils.Item(tmpColId).ToString()
                        Case "marque"
                            tmpDiagnosticBuses.marque = tmpListProfils.Item(tmpColId).ToString()
                        Case "nombre"
                            tmpDiagnosticBuses.nombre = tmpListProfils.Item(tmpColId).ToString()
                        Case "genre"
                            tmpDiagnosticBuses.genre = tmpListProfils.Item(tmpColId).ToString()
                        Case "calibre"
                            tmpDiagnosticBuses.calibre = tmpListProfils.Item(tmpColId).ToString()
                        Case "ecartTolere"
                            tmpDiagnosticBuses.ecartTolere = tmpListProfils.Item(tmpColId).ToString()
                        Case "couleur"
                            tmpDiagnosticBuses.couleur = tmpListProfils.Item(tmpColId).ToString()
                        Case "debitMoyen"
                            tmpDiagnosticBuses.debitMoyen = tmpListProfils.Item(tmpColId).ToString()
                        Case "debitNominal"
                            tmpDiagnosticBuses.debitNominal = tmpListProfils.Item(tmpColId).ToString()
                        Case "dateModificationAgent"
                            tmpDiagnosticBuses.dateModificationAgent = CSDate.ToCRODIPString(tmpListProfils.Item(tmpColId).ToString())
                    End Select
                    tmpColId = tmpColId + 1
                End While
                arrItems(i) = tmpDiagnosticBuses
                i = i + 1
                ReDim Preserve arrItems(i)
            End While
            ReDim Preserve arrItems(i - 1)

        Catch ex As Exception ' On intercepte l'erreur
            CSDebug.dispError("DiagnosticBuseManager.getUpdates ERR: " & ex.Message)
        End Try

        oCSDB.free()


        'on retourne les objet non synchro
        Return arrItems
    End Function

#End Region

End Class