Imports System.Diagnostics
Imports Microsoft.Win32

Public Class Form1
    Const SubKey As String = "Software\Classes\CLSID"
    Const DirKey As String = "{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}"
    Const EntryKey As String = "\InprocServer32"
    ' version sous GitHub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestion du menu Contextuel - L. Molina Dec 2023"
        Me.ButtonWin11.Text = "Passer au Menu Contextuel de type Win 11"
        Me.ButtonWin10.Text = "Passer au Menu Contextuel de type Win 10"
        GetStatus()
    End Sub

    Private Sub ButtonWin11_Click(sender As Object, e As EventArgs) Handles ButtonWin11.Click
        ActivateNewMenuWin11()
    End Sub

    Private Sub ButtonWin10_Click(sender As Object, e As EventArgs) Handles ButtonWin10.Click
        ActivateOldMenuWin10()
    End Sub
    Sub ActivateOldMenuWin10()
        Dim softwareKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
        Dim key = softwareKey?.OpenSubKey(SubKey, True)
        key = key?.CreateSubKey(DirKey & EntryKey, RegistryKeyPermissionCheck.ReadWriteSubTree)
        key?.SetValue("", "")
        MsgBox("Veuillez relancer Win 11 pour activer la modification !", vbOKOnly, "Redémarrage nécessaire")
        GetStatus()
    End Sub

    Sub ActivateNewMenuWin11()
        Dim softwareKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
        Dim keyDel = softwareKey?.OpenSubKey(SubKey, True)
        keyDel?.DeleteSubKeyTree(DirKey, RegistryKeyPermissionCheck.ReadWriteSubTree)
        MsgBox("Veuillez relancer Win 11 pour activer la modification !", vbOKOnly, "Redémarrage nécessaire")
        GetStatus()
    End Sub

    Private Function ReadRegistry()
        Dim KeyValue As Integer = 0
        Dim baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
        Dim regkey = baseKey.OpenSubKey(SubKey & "\" & DirKey)
        If regkey IsNot Nothing Then
            KeyValue = 1
        End If
        Return KeyValue
    End Function

    Sub GetStatus()
        If ReadRegistry() = 1 Then
            Me.ButtonWin10.Visible = False
            Me.ButtonWin11.Visible = True
        Else
            Me.ButtonWin10.Visible = True
            Me.ButtonWin11.Visible = False
        End If

    End Sub
End Class
