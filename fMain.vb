'Imports System.Diagnostics
'Imports CefSharp.WinForms
'Imports CefSharp

Public Class fMain
    Dim aa = 7, bb = 4, cc = 1, dd = "w", ee = 8, ff = 5, gg = 2, hh = "z", ii = 9, jj = 6, kk = 3, ll = "l", mm = 0, nn = "."
    Dim oo, pp
    Dim wc As New Net.WebClient

    'Private WithEvents browser As ChromiumWebBrowser

    'Public Sub New()

    ' 이 호출은 디자이너에 필요합니다.
    'InitializeComponent()

    'Dim settings As New CefSettings()
    'CefSharp.Cef.Initialize(settings)

    'browser = New ChromiumWebBrowser("http://wizcmnt.dothome.co.kr/mojito/twitter.php") With {
    '.Dock = DockStyle.Fill
    '}
    'panBrowser.Controls.Add(browser)

    ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    'End Sub
    Private Sub fMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Pr() As Process = Process.GetProcesses
        Dim Prc As Process

        If tProcess.Enabled = False Then
            If MsgBox("관리자 모드로 로그인 중입니다. 정말 종료하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                End
            Else : e.Cancel = True
            End If
        Else
            For i As Integer = 0 To UBound(Pr)
                If StrConv(Pr(i).ProcessName, VbStrConv.Lowercase) = "maplestory" Then
                    If MsgBox("지금 현재 게임이 실행 중입니다." & vbCr & "스타터를 종료하면 게임도 강제 종료되며," & vbCr & "이에 따른 데이터 손실은 책임지지 않습니다." & vbCr & vbCr & "정말 종료하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        Try
                            For j As Integer = 0 To UBound(Pr)
                                'if StrConv(Pr(j).ProcessName, VbStrConv.Lowercase) = "maplestory" Then
                                If InStr("maplestory", StrConv(Pr(j).ProcessName, VbStrConv.Lowercase)) Then
                                    Prc = Process.GetProcessById(Pr(j).Id)
                                    Prc.CloseMainWindow()
                                    Prc.Kill()
                                End If
                            Next j
                            'Prc = Process.GetProcessById(Pr(i).Id)
                            'Prc.CloseMainWindow()
                            End
                        Catch
                            MsgBox(Err.Description, MsgBoxStyle.Critical)
                            MsgBox("게임 실행 중에는 접속 프로그램을 종료할 수 없습니다." & vbCrLf & "게임 종료 후 프로그램을 종료하시기 바랍니다.", MsgBoxStyle.Critical)
                            e.Cancel = True
                            Exit Sub
                        End Try
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            Next i
            If MsgBox("정말 종료하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                End
            Else : e.Cancel = True
            End If
        End If

    End Sub
    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btStart.BackColor = Color.Transparent
        btPf.BackColor = Color.Transparent
        btChat.BackColor = Color.Transparent
        btDc.BackColor = Color.Transparent
        btWeb.BackColor = Color.Transparent
        btLink1.BackColor = Color.Transparent
        btLink2.BackColor = Color.Transparent
        btMin.BackColor = Color.Transparent
        btEnd.BackColor = Color.Transparent
        btAdmin.BackColor = Color.Transparent
        btStart.Visible = True
        btPf.Visible = True
        btChat.Visible = True
        btDc.Visible = True
        btWeb.Visible = True
        btLink1.Visible = True
        btLink2.Visible = True
        btMin.Visible = True
        btEnd.Visible = True
        btAdmin.Visible = True

    End Sub


    Private Sub tPopup_Tick(sender As Object, e As EventArgs) Handles tPopup.Tick
        tPopup.Enabled = False

        On Error GoTo Err
        oo = wc.DownloadString("http://wizcmnt.dothome.co.kr/mojito/popup.txt")
        If InStr(oo, "1,") Then
            MsgBox(Replace(oo, "1,", ""), MsgBoxStyle.Information)
        End If
        Exit Sub

Err:
        MsgBox("공지사항을 불러오지 못했습니다.", MsgBoxStyle.Exclamation)
        Exit Sub

    End Sub
    Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click
        btStart.Enabled = False

        On Error GoTo Err
        pp = wc.DownloadString("http://wizcmnt.dothome.co.kr/mojito/checking.txt")
        If tProcess.Enabled = True Then
            If pp = 0 Then '서버 정상운용 여부 확인
                GoTo Run
            ElseIf pp = 1 Then '서버 점검 직전 접속 제한 여부 확인
                MsgBox("곧 서버 점검이 예정되어 있어 서버에 접속할 수 없습니다." & vbCrLf & "자세한 점검 내용은 홈페이지를 참고하시기 바랍니다.", MsgBoxStyle.Critical)
                If MsgBox("지금 바로 홈페이지로 이동하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")
                Else
                End If
            ElseIf pp = 2 Then '서버 점검 진행 중 여부 확인
                MsgBox("지금은 더 나은 서비스를 위한 서버 점검 중입니다." & vbCrLf & "자세한 점검 내용은 홈페이지를 참고하시기 바랍니다.", MsgBoxStyle.Critical)
                If MsgBox("지금 바로 홈페이지로 이동하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")
                Else
                End If
            Else
                MsgBox("서버 상태를 불러오지 못했습니다." & vbCrLf & "잠시 후 다시 시도하시기 바랍니다.", MsgBoxStyle.Critical)
            End If
        Else : GoTo Run
        End If

        btStart.Enabled = True
        Exit Sub

Run:
        fAd.ShowDialog()
        btStart.Enabled = True
        Exit Sub

Err:

    End Sub
    Private Sub btMin_Click(sender As Object, e As EventArgs) Handles btMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        Me.Close()

    End Sub
    Private Sub btPf_Click(sender As Object, e As EventArgs) Handles btPf.Click
        System.Diagnostics.Process.Start("http://pf.kakao.com/_tEPzj")

    End Sub
    Private Sub btChat_Click(sender As Object, e As EventArgs) Handles btChat.Click
        System.Diagnostics.Process.Start("https://open.kakao.com/o/geIgMqN")

    End Sub
    Private Sub btDc_Click(sender As Object, e As EventArgs) Handles btDc.Click
        System.Diagnostics.Process.Start("https://discord.gg/hrB5Q27")

    End Sub
    Private Sub btWeb_Click(sender As Object, e As EventArgs) Handles btWeb.Click
        System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")

    End Sub
    Private Sub btLink1_Click(sender As Object, e As EventArgs) Handles btLink1.Click
        System.Diagnostics.Process.Start("http://cafe.daum.net/HOTSUMMER/kB1N/1")

    End Sub
    Private Sub btLink2_Click(sender As Object, e As EventArgs) Handles btLink2.Click
        System.Diagnostics.Process.Start("http://cafe.daum.net/HOTSUMMER/kB1O/1")

    End Sub
    Private Sub btAdmin_DoubleClick(sender As Object, e As EventArgs) Handles btAdmin.DoubleClick
        If MsgBox("관리자 모드로 전환하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If InputBox(vbCrLf & "모히또온라인 관리자를 위한 전용 모드로 진입합니다." & vbCrLf & vbCrLf & "일반 유저는 모든 접속시도 기록이 저장되오니" & vbCrLf & "이 창을 닫고 메인 화면으로 돌아가시기 바랍니다." & vbCrLf & vbCrLf & "관리자 고유인증번호를 정확하게 입력하세요.") = "hwa#ryeon" Then
                tProcess.Enabled = False
                MsgBox("관리자 모드로 전환되었습니다." & vbCrLf & "보안프로그램 기능이 해제되었습니다.", MsgBoxStyle.Information)
                btAdmin.Enabled = False
            Else
                MsgBox("고유인증번호가 일치하지 않습니다." & vbCrLf & "연속 3회 이상 틀릴 경우 해당 IP 접근이 차단됩니다.", MsgBoxStyle.Exclamation)
            End If
        Else
        End If
    End Sub
    Private Sub tProcess_Tick(sender As Object, e As EventArgs) Handles tProcess.Tick
        Dim Prclist As String = "cmd powershell taskkill taskmgr perfmon repacker slfcg stredit sniff packet wireshark hxd clean"
        Dim Pr() As Process = Process.GetProcesses
        Dim Prc As Process

        For i As Integer = 0 To UBound(Pr)
            If InStr(Prclist, StrConv(Pr(i).ProcessName, VbStrConv.Lowercase)) Then
                Try
                    Prc = Process.GetProcessById(Pr(i).Id)
                    Prc.Kill()
                Catch
                    For j As Integer = 0 To UBound(Pr)
                        'if StrConv(Pr(j).ProcessName, VbStrConv.Lowercase) = "maplestory" Then
                        If InStr("maplestory", StrConv(Pr(j).ProcessName, VbStrConv.Lowercase)) Then
                            Prc = Process.GetProcessById(Pr(j).Id)
                            Prc.CloseMainWindow()
                        End If
                    Next j
                    MsgBox("해킹 시도가 감지되어 프로그램을 종료합니다." & vbCrLf & "자세한 사항은 관리자에게 문의바랍니다.", MsgBoxStyle.Critical)
                    End
                End Try
            End If
        Next i

    End Sub

End Class
