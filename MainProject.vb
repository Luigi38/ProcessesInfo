Imports System.IO

Public Class MainProject
    Dim CuStr(2) As String 'Items of Custom Mode.
    Dim PrVerInfo As String
    Dim PrName As String
    Dim CMInt As Integer '(0 = Not Enabled, 1 = Enabled)
    Dim GPTrue As Boolean
    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GPTrue = False
        PrName = Nothing

        '-Load Settings
        VerText.Text = "     Version. " + My.Application.Info.Version.ToString


    End Sub

    Private Sub GetPrButton1_Click(sender As Object, e As EventArgs) Handles GetPrButton1.Click
        For Each p As Process In Process.GetProcesses()
            Pr_ListView.Items.Add(p.ProcessName)
        Next
        GPTrue = True
        MessageBox.Show("Got Processes from Background!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                            PrInfo2.Text = "Process Name: " + PrFile
                            PrInfo3.Text = "Process ID: " + p(i).Id.ToString
                            PrInfo4.Text = "Process Start Time: " + pr.StartTime.ToString
                            PrVerInfo = pr.Modules(0).FileVersionInfo.ToString 'Get Process Version Info. (PerInfo5)
                        Next
                    End If
                End If
            Else
                MessageBox.Show("Error! - You didn't select any process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            'Reset Text to Default. 기능 추가시 추가 바람.
            PrInfo1.Text = "File Name: N/A"
            PrInfo2.Text = "Full Path: N/A"
            PrInfo2.Text = "Process Name: N/A"
            PrInfo3.Text = "Process ID: N/A"
            PrInfo4.Text = "Process Start Time: N/A"
            PrVerInfo = Nothing
            MessageBox.Show("Error! (" & ex.HResult & ")" + vbNewLine + "Error Message: " & ex.Message + vbNewLine +
                            ex.StackTrace + vbNewLine + vbNewLine + ex.TargetSite.ToString & " + " & ex.Source,
                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        'Copy to Clipboard Function! -기능 추가시 추가 바람.
        Clipboard.SetText(PrInfo1.Text + ", " + PrInfo2.Text + ", " + PrInfo2.Text + ", " + PrInfo3.Text + ", " + PrInfo4.Text)
        MessageBox.Show("Copied to Clipboard!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrInfo1_Click(sender As Object, e As EventArgs) Handles PrInfo1.DoubleClick
        If GPTrue = True Then 'Process Selected & Copy to Clipboard!
            Clipboard.SetText(PrInfo1.Text.Replace("File Name: ", ""))
            MessageBox.Show("File Name Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GPTrue = False Then
            MessageBox.Show("You have to select Process before copy it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PrInfo2_Click(sender As Object, e As EventArgs) Handles PrInfo2.DoubleClick
        If GPTrue = True Then
            Clipboard.SetText(PrInfo2.Text.Replace("Process Name: ", ""))
            MessageBox.Show("Process Name Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GPTrue = False Then
            MessageBox.Show("You have to select Process before copy it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub KillPrButton_Click(sender As Object, e As EventArgs) Handles KillPrButton.Click
        Try
            If GPTrue = True Then
                If Pr_ListView.SelectedItems.Count > 0 Then
                    Dim PrFile = Pr_ListView.SelectedItems(0).Text

                    PrName = PrFile
                    Dim p As Process() = Process.GetProcessesByName(PrFile)

                    If p.Length > 0 Then
                        For i As Integer = 0 To p.Length - 1
                            Dim pr As Process = Process.GetProcessById(p(i).Id)
                            pr.Kill()
                            MessageBox.Show("Killed Process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Next
                    End If
                Else
                    MessageBox.Show("Error! - You didn't select any process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Error! - You didn't select any process!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error! (" & ex.HResult & ")" + vbNewLine + "Error Message: " & ex.Message + vbNewLine +
                        ex.StackTrace + vbNewLine + vbNewLine + ex.TargetSite.ToString & " + " & ex.Source,
                        Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrInfo3_Click(sender As Object, e As EventArgs) Handles PrInfo3.DoubleClick
        If GPTrue = True Then
            Clipboard.SetText(PrInfo3.Text.Replace("Process ID: ", ""))
            MessageBox.Show("Process ID Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GPTrue = False Then
            MessageBox.Show("You have to select Process before copy it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PrInfo4_Click(sender As Object, e As EventArgs) Handles PrInfo4.DoubleClick
        If GPTrue = True Then
            Clipboard.SetText(PrInfo4.Text.Replace("Process Start Time: ", ""))
            MessageBox.Show("Process Start Time Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf GPTrue = False Then
            MessageBox.Show("You have to select Process before copy it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PrInfo5_Click(sender As Object, e As EventArgs) Handles PrInfo5.Click
        If GPTrue = True Then
            If Not PrVerInfo = Nothing Then
                MessageBox.Show(PrVerInfo, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error! - The Process doesn't have Version Info.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf GPTrue = False Then
            MessageBox.Show("You have to select Process before show it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
