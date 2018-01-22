Imports System.IO
Imports System.Threading

Module CSSoftwareUpdate


    Public Function runUpdater()
        CSSoftwareUpdate.runUpdater(False)
    End Function
    Public Function runUpdater(ByVal withThread As Boolean)
        If withThread Then
            CSSoftwareUpdate.thr_majSoftware()
        Else
            CSSoftwareUpdate.majSoftware()
        End If
        config_vars.Init()
    End Function

    Private _thread_majSoftware As Thread
    Private Sub majSoftware()

        'Lancement du programme de mise a jour
        Dim Processus As New System.Diagnostics.Process
        Processus.StartInfo.FileName = "Crodip_updater.exe"
        Processus.Start()
        Processus.WaitForExit()
        'retourne un bool�en confirmant le d�marage du process

    End Sub
    Function thr_majSoftware()
        _thread_majSoftware = New Thread(AddressOf CSSoftwareUpdate.thr_majSoftware) 'ThrFunc est la fonction ex�cut�e par le thread.
        _thread_majSoftware.Name = "CSSoftwareUpdate_majSoftware" 'Il est parfois pratique de nommer les threads surtout si on en cr�� plusieurs.
        _thread_majSoftware.Start() ' D�marrage du thread.
    End Function

    Public Function checkMAJ()

        Try

            Dim objWSCrodip As WSCrodip_prod.CrodipServer = WSCrodip.getWS()

            Dim wsResponse As Object
            ' Appel au WS
            Dim codeResponse As Integer = objWSCrodip.GetSoftwareUpdate(GLOB_APPLI_BUILD, wsResponse)

            If codeResponse = 2 Then
                Return True
            End If

        Catch ex As Exception
            CSDebug.dispError("CSSoftwareUpdate.checkMAJ() : " & ex.Message)
        End Try

        Return False

    End Function

 
End Module
