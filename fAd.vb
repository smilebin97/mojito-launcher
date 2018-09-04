Imports System.Net.Sockets
Public Class fAd
    Dim aa = 7, bb = 4, cc = 1, dd = "c", ee = 8, ff = 5, gg = 2, hh = "u", ii = 9, jj = 6, kk = 3, ll = "h", mm = 0, nn = "."
    Dim qq = cc & aa & ff & nn & gg & mm & aa & nn & mm & nn & kk & kk
    Dim rr = ee & bb & ee & bb, ss = qq & " " & rr
    '175.207.0.33 8484
    Public Function CheckStatus()
        Dim ChkSocket As New TcpClient
        Try
            ChkSocket.Connect(qq, rr)
            Return True
        Catch Excep As Exception
            Return False
        End Try
    End Function
    Private Sub fAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTime.BackColor = Color.Transparent
        GoStart()

        'If CheckStatus() = True Then
        'GoStart()
        'Else
        'MsgBox("지금은 더 나은 서비스를 위한 서버 점검 중입니다." & vbCrLf & "자세한 점검 내용은 홈페이지를 참고하시기 바랍니다.", MsgBoxStyle.Critical)
        'If MsgBox("지금 바로 홈페이지로 이동하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        'System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")
        'Else
        'End If
        'Me.Close()
        'End If

    End Sub
    Private Sub GoStart()
        tDelay5s.Enabled = True

        'If Len(Dir(My.Application.Info.DirectoryPath & "\MapleStory.exe")) Then
        'mStart.Start(ss)
        'Me.Close()
        'Else
        'MsgBox("게임 클라이언트가 손상된 것 같습니다." & vbCrLf & "홈페이지에서 새로운 클라이언트를 설치하시기 바랍니다.", MsgBoxStyle.Critical)
        'If MsgBox("지금 바로 홈페이지로 이동하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        'System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")
        'Me.Close()
        'Else
        'Me.Close()
        'End If
        'End If

    End Sub
    Private Sub tDelay5s_Tick(sender As Object, e As EventArgs) Handles tDelay5s.Tick '사용
        If lbTime.Text = "1초 후 게임이 실행됩니다." Then
            tDelay5s.Enabled = False
            If Len(Dir(My.Application.Info.DirectoryPath & "\MapleStory.exe")) Then
                mStart.Start(ss)
                Me.Close()
            Else
                MsgBox("게임 클라이언트가 손상된 것 같습니다." & vbCrLf & "홈페이지에서 새로운 클라이언트를 설치하시기 바랍니다.", MsgBoxStyle.Critical)
                If MsgBox("지금 바로 홈페이지로 이동하시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("http://모히또.커뮤니티.한국/")
                    Me.Close()
                Else
                    Me.Close()
                End If
            End If
            lbTime.Text = "3초 후 게임이 실행됩니다."
        Else
            lbTime.Text = Mid(lbTime.Text, 1, 1) - 1 & "초 후 게임이 실행됩니다."
        End If

    End Sub
    Private Sub fAd_Click(sender As Object, e As EventArgs) Handles Me.Click
        System.Diagnostics.Process.Start("http://cafe.daum.net/HOTSUMMER/kB1N/1")

    End Sub
End Class