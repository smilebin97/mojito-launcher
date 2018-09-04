<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.tPopup = New System.Windows.Forms.Timer(Me.components)
        Me.tProcess = New System.Windows.Forms.Timer(Me.components)
        Me.btAdmin = New System.Windows.Forms.PictureBox()
        Me.btWeb = New System.Windows.Forms.PictureBox()
        Me.btPf = New System.Windows.Forms.PictureBox()
        Me.btChat = New System.Windows.Forms.PictureBox()
        Me.btStart = New System.Windows.Forms.PictureBox()
        Me.btDc = New System.Windows.Forms.PictureBox()
        Me.btLink2 = New System.Windows.Forms.PictureBox()
        Me.btLink1 = New System.Windows.Forms.PictureBox()
        Me.btMin = New System.Windows.Forms.PictureBox()
        Me.btEnd = New System.Windows.Forms.PictureBox()
        CType(Me.btAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btPf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btDc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btLink1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tPopup
        '
        Me.tPopup.Enabled = True
        '
        'tProcess
        '
        Me.tProcess.Enabled = True
        '
        'btAdmin
        '
        Me.btAdmin.BackColor = System.Drawing.Color.White
        Me.btAdmin.Location = New System.Drawing.Point(522, 310)
        Me.btAdmin.Name = "btAdmin"
        Me.btAdmin.Size = New System.Drawing.Size(33, 30)
        Me.btAdmin.TabIndex = 9
        Me.btAdmin.TabStop = False
        Me.btAdmin.Visible = False
        '
        'btWeb
        '
        Me.btWeb.BackColor = System.Drawing.Color.White
        Me.btWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btWeb.Location = New System.Drawing.Point(564, 77)
        Me.btWeb.Name = "btWeb"
        Me.btWeb.Size = New System.Drawing.Size(90, 45)
        Me.btWeb.TabIndex = 8
        Me.btWeb.TabStop = False
        Me.btWeb.Visible = False
        '
        'btPf
        '
        Me.btPf.BackColor = System.Drawing.Color.White
        Me.btPf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPf.Location = New System.Drawing.Point(47, 77)
        Me.btPf.Name = "btPf"
        Me.btPf.Size = New System.Drawing.Size(90, 45)
        Me.btPf.TabIndex = 7
        Me.btPf.TabStop = False
        Me.btPf.Visible = False
        '
        'btChat
        '
        Me.btChat.BackColor = System.Drawing.Color.White
        Me.btChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btChat.Location = New System.Drawing.Point(220, 76)
        Me.btChat.Name = "btChat"
        Me.btChat.Size = New System.Drawing.Size(90, 45)
        Me.btChat.TabIndex = 6
        Me.btChat.TabStop = False
        Me.btChat.Visible = False
        '
        'btStart
        '
        Me.btStart.BackColor = System.Drawing.Color.White
        Me.btStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btStart.Location = New System.Drawing.Point(421, 140)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(257, 120)
        Me.btStart.TabIndex = 5
        Me.btStart.TabStop = False
        Me.btStart.Visible = False
        '
        'btDc
        '
        Me.btDc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDc.Location = New System.Drawing.Point(389, 77)
        Me.btDc.Name = "btDc"
        Me.btDc.Size = New System.Drawing.Size(90, 45)
        Me.btDc.TabIndex = 10
        Me.btDc.TabStop = False
        Me.btDc.Visible = False
        '
        'btLink2
        '
        Me.btLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLink2.Location = New System.Drawing.Point(21, 272)
        Me.btLink2.Name = "btLink2"
        Me.btLink2.Size = New System.Drawing.Size(294, 105)
        Me.btLink2.TabIndex = 11
        Me.btLink2.TabStop = False
        Me.btLink2.Visible = False
        '
        'btLink1
        '
        Me.btLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLink1.Location = New System.Drawing.Point(21, 140)
        Me.btLink1.Name = "btLink1"
        Me.btLink1.Size = New System.Drawing.Size(385, 120)
        Me.btLink1.TabIndex = 12
        Me.btLink1.TabStop = False
        Me.btLink1.Visible = False
        '
        'btMin
        '
        Me.btMin.Location = New System.Drawing.Point(629, 13)
        Me.btMin.Name = "btMin"
        Me.btMin.Size = New System.Drawing.Size(16, 16)
        Me.btMin.TabIndex = 13
        Me.btMin.TabStop = False
        Me.btMin.Visible = False
        '
        'btEnd
        '
        Me.btEnd.Location = New System.Drawing.Point(662, 13)
        Me.btEnd.Name = "btEnd"
        Me.btEnd.Size = New System.Drawing.Size(16, 16)
        Me.btEnd.TabIndex = 14
        Me.btEnd.TabStop = False
        Me.btEnd.Visible = False
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WizHelper.My.Resources.Resources.main
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.btEnd)
        Me.Controls.Add(Me.btMin)
        Me.Controls.Add(Me.btLink1)
        Me.Controls.Add(Me.btLink2)
        Me.Controls.Add(Me.btDc)
        Me.Controls.Add(Me.btAdmin)
        Me.Controls.Add(Me.btWeb)
        Me.Controls.Add(Me.btPf)
        Me.Controls.Add(Me.btChat)
        Me.Controls.Add(Me.btStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hwaryeon Launcher"
        CType(Me.btAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btPf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btDc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btLink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btLink1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tPopup As System.Windows.Forms.Timer
    Friend WithEvents tProcess As System.Windows.Forms.Timer
    Friend WithEvents btAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents btWeb As System.Windows.Forms.PictureBox
    Friend WithEvents btPf As System.Windows.Forms.PictureBox
    Friend WithEvents btChat As System.Windows.Forms.PictureBox
    Friend WithEvents btStart As System.Windows.Forms.PictureBox
    Friend WithEvents btDc As System.Windows.Forms.PictureBox
    Friend WithEvents btLink2 As System.Windows.Forms.PictureBox
    Friend WithEvents btLink1 As System.Windows.Forms.PictureBox
    Friend WithEvents btMin As System.Windows.Forms.PictureBox
    Friend WithEvents btEnd As System.Windows.Forms.PictureBox
End Class
