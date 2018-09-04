<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCheck
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCheck))
        Me.lbState = New System.Windows.Forms.Label()
        Me.pbCurrent = New System.Windows.Forms.ProgressBar()
        Me.tWizet = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbState
        '
        Me.lbState.AutoSize = True
        Me.lbState.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lbState.Location = New System.Drawing.Point(6, 88)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(137, 12)
        Me.lbState.TabIndex = 5
        Me.lbState.Text = "업데이트 대기 중입니다."
        '
        'pbCurrent
        '
        Me.pbCurrent.Location = New System.Drawing.Point(0, 103)
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(500, 30)
        Me.pbCurrent.TabIndex = 4
        '
        'tWizet
        '
        '
        'fCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WizHelper.My.Resources.Resources.update
        Me.ClientSize = New System.Drawing.Size(500, 133)
        Me.Controls.Add(Me.lbState)
        Me.Controls.Add(Me.pbCurrent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WizHelper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbState As System.Windows.Forms.Label
    Friend WithEvents pbCurrent As System.Windows.Forms.ProgressBar
    Friend WithEvents tWizet As System.Windows.Forms.Timer

End Class
