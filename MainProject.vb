Imports System.IO

Public Class MainProject
    Dim CuStr(2) As String 'Items of Custom Mode.
    Dim PrName As String
    Dim CMInt As Integer '(0 = Not Enabled, 1 = Enabled)
    Dim GPTrue As Boolean
    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GPTrue = False
        PrName = Nothing

        '-Load Settings
        VerText.Text = "     Version. " + My.Application.Info.Version.ToString



        'Custom Mode Items (BETA)
        CuStr(0) = "Hello, World!"
        CuStr(1) = "Launchpad MK2"
        CuStr(2) = "UniConverter V1.1.0.3"

        For Each q As String In CuStr
            Dim itm As New ListViewItem(New String() {q})
            CM_ComboBox.Items.Add(itm.Text)
        Next
    End Sub

    Private Sub GetPrButton1_Click(sender As Object, e As EventArgs) Handles GetPrButton1.Click
        For Each p As Process In Process.GetProcesses()
            Pr_ListView.Items.Add(p.ProcessName)
        Next
        GPTrue = True
    End Sub

    Private Sub Pr_ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Pr_ListView.SelectedIndexChanged
        Try
            If GPTrue = True Then
                If Pr_ListView.SelectedItems.Count > 0 Then
                    Dim PrFile = Pr_ListView.SelectedItems(0).Text 'Selected Item's Text (ex: UniConverter)

                    PrName = PrFile
                    Dim p As Process() = Process.GetProcessesByName(PrFile) 'Get Process' Name.

                    If p.Length > 0 Then
                        For i As Integer = 0 To p.Length - 1
                            Dim pr As Process = Process.GetProcessById(p(i).Id) 'Get Process' ID.
                            PrInfo1.Text = "File Name: " + Path.GetFileName(pr.Modules(0).FileName) 'Get Process' File Name with PID.
                            PrInfo2.Text = "Full Path: " + pr.Modules(0).FileName
                            PrInfo3.Text = "Process ID: " + p(i).Id.ToString
                        Next
                    End If
                End If
            Else
                MessageBox.Show("Error! - You didn't get any process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            'Reset Text to Default. 기능 추가시 추가 바람.
            PrInfo1.Text = "File Name: N/A"
            PrInfo2.Text = "File Name: N/A"
            PrInfo3.Text = "File Name: N/A"
            MessageBox.Show("Error! (" & ex.HResult & ")" + vbNewLine + "Error Message: " & ex.Message + vbNewLine +
                            ex.StackTrace + vbNewLine + vbNewLine + ex.TargetSite.ToString & " + " & ex.Source,
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CM_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CM_CheckBox.CheckedChanged
        If CM_CheckBox.Checked = True Then
            CMInt = 1 'Check Value
            CM_ComboBox.Enabled = True
            EDITCModeButton.Enabled = True
        ElseIf CMInt = 1 Then
            CM_ComboBox.Enabled = False
            EDITCModeButton.Enabled = True
            CMInt = 0
        End If
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        'Copy to Clipboard Function!
        '기능 추가 바람.
    End Sub
End Class
