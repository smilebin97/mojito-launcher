<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAd))
        Me.tDelay5s = New System.Windows.Forms.Timer(Me.components)
        Me.lbTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tDelay5s
        '
        Me.tDelay5s.Interval = 1000
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.White
        Me.lbTime.Location = New System.Drawing.Point(405, 4)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(136, 11)
        Me.lbTime.TabIndex = 1
        Me.lbTime.Text = "5초 후 게임이 실행됩니다."
        '
        'fAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WizHelper.My.Resources.Resources.sentence_type
        Me.ClientSize = New System.Drawing.Size(548, 65)
        Me.Controls.Add(Me.lbTime)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fAd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WizHelper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tDelay5s As System.Windows.Forms.Timer
    Friend WithEvents lbTime As System.Windows.Forms.Label
End Class
