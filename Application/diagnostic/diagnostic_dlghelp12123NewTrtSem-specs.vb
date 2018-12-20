﻿Imports System.Windows.Forms

Public Class diagnostic_dlghelp12123newTrtSemSpecs
    Implements IfrmCRODIP, IdlgHelp12123
    Private m_DiagHelp12123 As DiagnosticHelp12123
    Private m_bModeVisu As Boolean

    ''' <summary>
    ''' </summary>
    ''' <param name="pMode"></param>
    ''' <param name="pDiag"></param>
    ''' <remarks></remarks>
    ''' 
    Public Sub setContexte(pDiagH12123 As DiagnosticHelp12123, pbModeVisu As Boolean) Implements IdlgHelp12123.setContexte
        m_bModeVisu = pbModeVisu
        If m_bModeVisu Then
            'pnlPrinc.Enabled = False
            btnValider.Enabled = False
        End If
        m_bsrcH12123.Clear()
        m_DiagHelp12123 = pDiagH12123.Clone()
        m_bsrcH12123.Add(m_DiagHelp12123)


    End Sub
    Public Function getContexte() As DiagnosticHelp12123 Implements IdlgHelp12123.getContexte
        Return m_DiagHelp12123
    End Function
    Public Overloads Function ShowDialog() As DialogResult Implements IdlgHelp12123.ShowDialog
        Return MyBase.ShowDialog
    End Function


    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        Valider()
    End Sub
    Protected Overridable Function Valider() As Boolean Implements IfrmCRODIP.Valider
    End Function

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Annuler()
    End Sub
    Protected Overridable Sub Annuler() Implements IfrmCRODIP.Annuler
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
    Private Sub diagnostic_dlghelp551_Load(sender As Object, e As EventArgs) Handles Me.Load
        formload()
    End Sub
    Protected Overridable Sub formload() Implements IfrmCRODIP.formLoad
        nupNbPompes.Value = m_DiagHelp12123.lstPompes.Count
        DisplayPompes()

    End Sub

    Private Sub DisplayPompes()
        Dim ImageIndex As Integer = 1
        Dim oOldNode As Integer = -1
        If TreeView1.SelectedNode IsNot Nothing Then
            oOldNode = TreeView1.SelectedNode.Index
        End If

        TreeView1.Nodes.Clear()

        For Each oPompe As DiagnosticHelp12123PompeTrtSem In m_DiagHelp12123.lstPompesTrtSem
            Select Case oPompe.Resultat
                Case ""
                    ImageIndex = 2
                Case DiagnosticItem.EtatDiagItemOK
                    ImageIndex = 1
                Case DiagnosticItem.EtatDiagItemMAJEUR
                    ImageIndex = 0
            End Select
            Dim oNode As TreeNode
            oNode = TreeView1.Nodes.Add(oPompe.Nom, ImageIndex)
            oNode.Text = oPompe.Nom
            oNode.SelectedImageIndex = ImageIndex
            oNode.ImageIndex = ImageIndex
        Next
        Try

            If oOldNode <> -1 Then
                TreeView1.SelectedNode = TreeView1.Nodes(oOldNode)
            Else
                TreeView1.SelectedNode = TreeView1.Nodes(0)
            End If
            m_bsrcH12123.Position = TreeView1.SelectedNode.Index
        Catch ex As Exception
            TreeView1.SelectedNode = TreeView1.Nodes(0)
            m_bsrcH12123.Position = 0
        End Try
    End Sub


    Private Sub BindingSource1_CurrentItemChanged(sender As Object, e As EventArgs) Handles m_bsrcH12123.CurrentItemChanged
        If Not String.IsNullOrEmpty(m_DiagHelp12123.Resultat) Then
            Select Case m_DiagHelp12123.Resultat
                Case DiagnosticItem.EtatDiagItemOK
                    'laResultMesure.Text = "OK"
                    'laResultMesure.ForeColor = CRODIP_ControlLibrary.CtrlDiag2.ITEMCOLOROK
                Case DiagnosticItem.EtatDiagItemMINEUR
                    'laResultMesure.Text = "FAIBLE"
                    'laResultMesure.ForeColor = CRODIP_ControlLibrary.CtrlDiag2.ITEMCOLORMINEUR
                Case DiagnosticItem.EtatDiagItemMAJEUR
                    'laResultMesure.ForeColor = CRODIP_ControlLibrary.CtrlDiag2.ITEMCOLORMAJEUR
                    'laResultMesure.Text = "MAJEURE"
            End Select
        End If
    End Sub

    Private Sub TbNumeric11_Validated(sender As Object, e As EventArgs)
        m_bsrcH12123.ResetBindings(False)
    End Sub

    Private Sub TbNumeric3_Validated(sender As Object, e As EventArgs)
        m_bsrcH12123.ResetBindings(False)

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TbNumeric11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnvaliderNbPompes_Click(sender As Object, e As EventArgs) Handles btnvaliderNbPompes.Click
        If nupNbPompes.Value > m_DiagHelp12123.lstPompesTrtSem.Count Then
            While m_DiagHelp12123.lstPompesTrtSem.Count < nupNbPompes.Value
                m_DiagHelp12123.AjoutePompeTrtSem()
            End While
        End If
        If nupNbPompes.Value < m_DiagHelp12123.lstPompesTrtSem.Count Then
            While m_DiagHelp12123.lstPompesTrtSem.Count > nupNbPompes.Value
                m_DiagHelp12123.lstPompesTrtSem.RemoveAt(m_DiagHelp12123.lstPompesTrtSem.Count - 1)
            End While
        End If
        m_DiagHelp12123.calcule()
        DisplayPompes()
        Refresh()

    End Sub
End Class
