<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProject
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Pr_ListView = New System.Windows.Forms.ListView()
        Me.Processes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GetPrButton1 = New System.Windows.Forms.Button()
        Me.GPI_Icon = New System.Windows.Forms.PictureBox()
        Me.VerText = New System.Windows.Forms.Label()
        Me.InfoText1 = New System.Windows.Forms.Label()
        Me.PrInfo1 = New System.Windows.Forms.Label()
        Me.KillPrButton = New System.Windows.Forms.Button()
        Me.ofd_path = New System.Windows.Forms.OpenFileDialog()
        Me.PrInfo3 = New System.Windows.Forms.Label()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.PrInfo2 = New System.Windows.Forms.Label()
        Me.PrInfo4 = New System.Windows.Forms.Label()
        Me.PrInfo5 = New System.Windows.Forms.Button()
        CType(Me.GPI_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pr_ListView
        '
        Me.Pr_ListView.AllowDrop = True
        Me.Pr_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Processes})
        Me.Pr_ListView.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Pr_ListView.FullRowSelect = True
        Me.Pr_ListView.Location = New System.Drawing.Point(22, 12)
        Me.Pr_ListView.MultiSelect = False
        Me.Pr_ListView.Name = "Pr_ListView"
        Me.Pr_ListView.Size = New System.Drawing.Size(234, 426)
        Me.Pr_ListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Pr_ListView.TabIndex = 24
        Me.Pr_ListView.UseCompatibleStateImageBehavior = False
        Me.Pr_ListView.View = System.Windows.Forms.View.Details
        '
        'Processes
        '
        Me.Processes.Text = "Processes"
        Me.Processes.Width = 229
        '
        'GetPrButton1
        '
        Me.GetPrButton1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetPrButton1.Location = New System.Drawing.Point(452, 353)
        Me.GetPrButton1.Name = "GetPrButton1"
        Me.GetPrButton1.Size = New System.Drawing.Size(163, 85)
        Me.GetPrButton1.TabIndex = 25
        Me.GetPrButton1.Text = "Get Processes from Background"
        Me.GetPrButton1.UseVisualStyleBackColor = True
        '
        'GPI_Icon
        '
        Me.GPI_Icon.Image = Global.GetProcessesInfo.My.Resources.Resources.GPI
        Me.GPI_Icon.Location = New System.Drawing.Point(646, 288)
        Me.GPI_Icon.Name = "GPI_Icon"
        Me.GPI_Icon.Size = New System.Drawing.Size(159, 150)
        Me.GPI_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GPI_Icon.TabIndex = 27
        Me.GPI_Icon.TabStop = False
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerText.Location = New System.Drawing.Point(642, 414)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(162, 24)
        Me.VerText.TabIndex = 29
        Me.VerText.Text = "     Version. 1.0.0.0"
        '
        'InfoText1
        '
        Me.InfoText1.AutoSize = True
        Me.InfoText1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoText1.Location = New System.Drawing.Point(637, 394)
        Me.InfoText1.Name = "InfoText1"
        Me.InfoText1.Size = New System.Drawing.Size(167, 20)
        Me.InfoText1.TabIndex = 28
        Me.InfoText1.Text = "By MineEric64 (최에릭)"
        '
        'PrInfo1
        '
        Me.PrInfo1.AutoSize = True
        Me.PrInfo1.Font = New System.Drawing.Font("-윤디자인웹돋움", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PrInfo1.Location = New System.Drawing.Point(286, 33)
        Me.PrInfo1.Name = "PrInfo1"
        Me.PrInfo1.Size = New System.Drawing.Size(143, 19)
        Me.PrInfo1.TabIndex = 37
        Me.PrInfo1.Text = "File Name: N/A"
        '
        'KillPrButton
        '
        Me.KillPrButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillPrButton.Location = New System.Drawing.Point(272, 353)
        Me.KillPrButton.Name = "KillPrButton"
        Me.KillPrButton.Size = New System.Drawing.Size(174, 85)
        Me.KillPrButton.TabIndex = 38
        Me.KillPrButton.Text = "Kill Process"
        Me.KillPrButton.UseVisualStyleBackColor = True
        '
        'ofd_path
        '
        Me.ofd_path.Filter = "Executable Files|*.exe"
        Me.ofd_path.Title = "Select Executable Files"
        '
        'PrInfo3
        '
        Me.PrInfo3.AutoSize = True
        Me.PrInfo3.Font = New System.Drawing.Font("-윤디자인웹돋움", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PrInfo3.Location = New System.Drawing.Point(286, 103)
        Me.PrInfo3.Name = "PrInfo3"
        Me.PrInfo3.Size = New System.Drawing.Size(150, 19)
        Me.PrInfo3.TabIndex = 41
        Me.PrInfo3.Text = "Process ID: N/A"
        '
        'CopyButton
        '
        Me.CopyButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyButton.Location = New System.Drawing.Point(452, 288)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(163, 51)
        Me.CopyButton.TabIndex = 42
        Me.CopyButton.Text = "Copy to Clipboard!!"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'PrInfo2
        '
        Me.PrInfo2.AutoSize = True
        Me.PrInfo2.Font = New System.Drawing.Font("-윤디자인웹돋움", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PrInfo2.Location = New System.Drawing.Point(286, 67)
        Me.PrInfo2.Name = "PrInfo2"
        Me.PrInfo2.Size = New System.Drawing.Size(185, 19)
        Me.PrInfo2.TabIndex = 43
        Me.PrInfo2.Text = "Process Name: N/A"
        '
        'PrInfo4
        '
        Me.PrInfo4.AutoSize = True
        Me.PrInfo4.Font = New System.Drawing.Font("-윤디자인웹돋움", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PrInfo4.Location = New System.Drawing.Point(286, 138)
        Me.PrInfo4.Name = "PrInfo4"
        Me.PrInfo4.Size = New System.Drawing.Size(224, 19)
        Me.PrInfo4.TabIndex = 45
        Me.PrInfo4.Text = "Process Start Time: N/A"
        '
        'PrInfo5
        '
        Me.PrInfo5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrInfo5.Location = New System.Drawing.Point(273, 288)
        Me.PrInfo5.Name = "PrInfo5"
        Me.PrInfo5.Size = New System.Drawing.Size(173, 51)
        Me.PrInfo5.TabIndex = 46
        Me.PrInfo5.Text = "Process Version Info"
        Me.PrInfo5.UseVisualStyleBackColor = True
        '
        'MainProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 450)
        Me.Controls.Add(Me.PrInfo5)
        Me.Controls.Add(Me.PrInfo4)
        Me.Controls.Add(Me.PrInfo2)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.PrInfo3)
        Me.Controls.Add(Me.KillPrButton)
        Me.Controls.Add(Me.PrInfo1)
        Me.Controls.Add(Me.VerText)
        Me.Controls.Add(Me.InfoText1)
        Me.Controls.Add(Me.GPI_Icon)
        Me.Controls.Add(Me.GetPrButton1)
        Me.Controls.Add(Me.Pr_ListView)
        Me.Name = "MainProject"
        Me.Text = "Get Processes Info"
        CType(Me.GPI_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pr_ListView As ListView
    Friend WithEvents Processes As ColumnHeader
    Friend WithEvents GetPrButton1 As Button
    Friend WithEvents GPI_Icon As PictureBox
    Friend WithEvents VerText As Label
    Friend WithEvents InfoText1 As Label
    Friend WithEvents PrInfo1 As Label
    Friend WithEvents KillPrButton As Button
    Friend WithEvents ofd_path As OpenFileDialog
    Friend WithEvents PrInfo3 As Label
    Friend WithEvents CopyButton As Button
    Friend WithEvents PrInfo2 As Label
    Friend WithEvents PrInfo4 As Label
    Friend WithEvents PrInfo5 As Button
End Class
