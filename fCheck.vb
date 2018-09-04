Imports System.Net
Imports System.ComponentModel

Public Class fCheck
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Private WithEvents wcClient As New WebClient
    Dim wc As New WebClient

    Private ClientsCurrentNum As Integer

    Dim aClientInfo() As String = Split(wcClient.DownloadString("http://wizcmnt.dothome.co.kr/mojito/clientinfo.txt"), vbLf)
    Dim aClientList(UBound(aClientInfo)), aClientSize(UBound(aClientInfo)) As String
    Dim aReqClientName(UBound(aClientInfo)), aReqClientUri(UBound(aClientInfo)) As String

    Private Sub fCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentVersion As String = "1808292"
        Dim ReleaseVersion As String = wc.DownloadString("http://wizcmnt.dothome.co.kr/mojito/verHelper.txt")
        Dim fStarter As String = "http://wizcmnt.dothome.co.kr/mojito/Starter.exe"

        If Command() = "ByStrter" Then
            GoTo Run

        ElseIf Command() = "First" Then '업데이트 후 최초 실행 명령인수
            MsgBox("모히또온라인 런처 업데이트 내용을 알려드립니다!" & vbCr & vbCr & "[+] 오픈이벤트 및 규칙안내 배너 추가" & vbCr & "[/] 게임 실행 안정화 작업" & vbCr & "[/] 런처와 게임 간 보안성 강화" & vbCr &
                   vbCr & vbCr & "언제나 유저 여러분만을 최우선으로 생각하는" & vbCr & "모히또온라인이 되도록 하겠습니다. 감사합니다.", MsgBoxStyle.Information)
            GoTo Run

        ElseIf Command() = "StrterFce" Then '스타터 업데이트 명령인수
            If Len(Dir(My.Application.Info.DirectoryPath & "\Updater.exe")) Then
                Try
                    wc.DownloadFile(fStarter, My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")
                Catch ex As Exception
                    MsgBox("스타터 업데이트 중 오류가 발생했습니다." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical)
                    If Len(Dir(My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")) Then Kill((My.Application.Info.DirectoryPath & "\###모히또온라인###.exe"))
                    End
                End Try
                Kill((My.Application.Info.DirectoryPath & "\Updater.exe"))
                ShellExecute(0, "OPEN", My.Application.Info.DirectoryPath & "\###모히또온라인###.exe", "First", "", 5)
                End

            ElseIf Len(Dir(My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")) Then
                Try
                    Rename((My.Application.Info.DirectoryPath & "\###모히또온라인###.exe"), (My.Application.Info.DirectoryPath & "\WizStarterTmp.exe"))
                    wc.DownloadFile(fStarter, My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")
                Catch ex As Exception
                    MsgBox("스타터 업데이트 중 오류가 발생했습니다." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical)
                    If Len(Dir(My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")) Then Kill((My.Application.Info.DirectoryPath & "\###모히또온라인###.exe"))
                    Rename((My.Application.Info.DirectoryPath & "\WizStarterTmp.exe"), (My.Application.Info.DirectoryPath & "\###모히또온라인###.exe"))
                    End
                End Try
                Kill((My.Application.Info.DirectoryPath & "\WizStarterTmp.exe"))
                ShellExecute(0, "OPEN", My.Application.Info.DirectoryPath & "\###모히또온라인###.exe", "First", "", 5)
                End

            Else
                Try
                    wc.DownloadFile(fStarter, My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")
                Catch ex As Exception
                    MsgBox("스타터 업데이트 중 오류가 발생했습니다." & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical)
                    If Len(Dir(My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")) Then Kill((My.Application.Info.DirectoryPath & "\###모히또온라인###.exe"))
                    End
                End Try
                ShellExecute(0, "OPEN", My.Application.Info.DirectoryPath & "\###모히또온라인###.exe", "First", "", 5)
                End

            End If

        Else
            MsgBox("비정상적인 접근입니다. 게임 실행은 스타터로 할 수 있습니다." & vbCr & "스타터 파일 : ###모히또온라인###", MsgBoxStyle.Critical)
            End

        End If

        Exit Sub

Run:
        If CurrentVersion = ReleaseVersion Then
            tWizet.Enabled = True
        Else
            If MsgBox("헬퍼의 새로운 버전이 릴리즈되었습니다!" & vbCrLf & "지금 바로 업데이트를 진행하시겠습니까?", 32 + 4) = MsgBoxResult.Yes Then
                If MsgBox("일부 백신은 자동 업데이트를 바이러스로 오진하는 경우가 있어" & vbCrLf & "백신의 실시간 감시를 중단하시고 진행하셔야 합니다." & vbCrLf & "백신 실시간 감시를 중단하셨습니까?", 32 + 4) = MsgBoxResult.Yes Then
                    If Len(Dir(My.Application.Info.DirectoryPath & "\###모히또온라인###.exe")) Then
                        ShellExecute(0, "OPEN", My.Application.Info.DirectoryPath & "\###모히또온라인###.exe", "HlperFce", "", 5)
                        End
                    Else
                        MsgBox("스타터 파일을 찾을 수 없어 업데이트를 진행할 수 없습니다." & vbCr & "홈페이지에서 클라이언트를 다시 다운로드하여 실행해주세요.", MsgBoxStyle.Critical, "WizCommunity Corp.")
                        End
                    End If
                Else
                    MsgBox("백신에 의한 파일 손상의 우려가 있어 업데이트를 진행할 수 없습니다." & vbCrLf & "프로그램의 실제 바이러스 감염이 의심되신다면" & vbCrLf & "홈페이지를 통하여 직접 업데이트하시기 바랍니다.", MsgBoxStyle.Critical)
                    End
                End If
            Else
                MsgBox("구 버전으로는 접속 프로그램을 실행할 수 없습니다." & vbCrLf & "프로그램을 다시 실행하여 업데이트하시기 바랍니다.", MsgBoxStyle.Critical)
                End
            End If
        End If
    End Sub

    Private Sub tWizet_Tick(sender As Object, e As EventArgs) Handles tWizet.Tick
        tWizet.Enabled = False

        If Len(Dir(My.Application.Info.DirectoryPath & "\MapleStory.exe")) Then
        Else
            MsgBox("게임 클라이언트 파일을 찾을 수 없습니다." & vbCrLf & "홈페이지에서 클라이언트를 다운로드 후 실행하시기 바랍니다.", MsgBoxStyle.Critical)
            End
        End If

        For i = 0 To UBound(aClientInfo)
            aClientList(i) = Split(aClientInfo(i), "#")(0)
            aClientSize(i) = Split(aClientInfo(i), "#")(1)

        Next

        For i = 0 To UBound(aClientInfo)
            If Len(Dir(My.Application.Info.DirectoryPath & "\" & aClientList(i))) Then '파일 유무 검사
            Else
                MsgBox("게임 클라이언트 파일을 찾을 수 없습니다." & vbCrLf & "홈페이지에서 클라이언트를 다운로드 후 실행하시기 바랍니다.", MsgBoxStyle.Critical)
                End
            End If

        Next

        runUpdateClients()
    End Sub

    Private Sub runUpdateClients()
        Dim i, j As Long

        On Error GoTo Err
        SetAttr(My.Application.Info.DirectoryPath, FileAttribute.Normal) '읽기전용 해제

        For i = 0 To UBound(aClientInfo)
            If Len(Dir(My.Application.Info.DirectoryPath & "\" & aClientList(i))) Then '파일 유무 검사
                If FileLen(My.Application.Info.DirectoryPath & "\" & aClientList(i)) <> aClientSize(i) Then '파일 용량 검사
                    aReqClientName(j) = aClientList(i)
                    j += 1
                Else
                    ClientsCurrentNum += 1
                End If

            Else
                aReqClientName(j) = aClientList(i)
                j += 1
            End If

        Next

        For i = 0 To UBound(aReqClientName)
            aReqClientUri(i) = "http://wizcmnt.i234.me/files/" & aReqClientName(i)

        Next

        If j = 0 Then
            pbCurrent.Value = 100
            lbState.Text = "업데이트가 완료되었습니다."
            fMain.Show()
            Me.Close()
        Else
            MsgBox("새로운 클라이언트 업데이트가 발견되었습니다!" & vbCr & "지금부터 새로운 버전의 패치를 진행합니다.", MsgBoxStyle.Information, "WizCommunity Corp.")
            'MsgBox("많은 접속자가 이용 중이면 다운로드 속도가 느릴 수 있습니다." & vbCr & "홈페이지에서도 다운로드 가능한 링크를 공개하고 있으니" & vbCr & "업데이트 속도가 느리다면 홈페이지를 이용하시기 바랍니다.", MsgBoxStyle.Exclamation, "WizCommunity Corp.")
            DownloadClients(aReqClientUri)
        End If

        Exit Sub

Err:
        MsgBox("업데이트 중 알 수 없는 오류가 발생하였습니다." & vbCr & "오류가 지속될 경우 모히또온라인 운영팀으로 문의바랍니다." & vbCr & vbCr & Err.Description, MsgBoxStyle.Critical, "WizCommunity Corp.")
        End

    End Sub

    Private Async Sub DownloadClients(ByVal Fileuris As IEnumerable(Of String))
        Dim SavePath As String

        For Each FileUri In Fileuris
            ClientsCurrentNum += 1 '로컬에 저장된 파일 개수(총 진행사항 파악을 위한 변수)

            With FileUri '로컬에 저장될 파일명
                SavePath = Replace(My.Application.Info.DirectoryPath + .Substring(.LastIndexOf("/")), "/", "\")
            End With

            With wcClient
                AddHandler .DownloadFileCompleted, AddressOf wcClient_DownloadFileCompleted
                AddHandler .DownloadProgressChanged, AddressOf wcClient_DownloadProgressChanged
                Await .DownloadFileTaskAsync(New Uri(FileUri), SavePath)
            End With

        Next

    End Sub

    Private Sub wcClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wcClient.DownloadProgressChanged
        On Error GoTo Err

        Dim TotalPercent As Double = (ClientsCurrentNum - 1) / (UBound(aClientList) + 1) * 100

        With e
            pbCurrent.Value = .ProgressPercentage
            If pbCurrent.Value > 1 Then pbCurrent.Value = .ProgressPercentage - 1
            lbState.Text = "게임 클라이언트(" & ClientsCurrentNum & "/" & UBound(aReqClientName) + 1 & ") 설치 중... (" & Math.Round(.ProgressPercentage, 2) & "%)"
            'lblFilePregress.Text = "Downloaded " & Math.Round(.BytesReceived / 1000, 2) & " KB / " & Math.Round(.TotalBytesToReceive / 1000, 2) & " KB (" & Math.Round(.ProgressPercentage, 2) & " %)"
        End With

        'pbTotal.Value = TotalPercent
        ' lblTotalDownload.Text = "Downloaded " & FilesCurrentNum & " / " & i & " (" & Math.Round(TotalPercent, 2) & " %)"

        Exit Sub
Err:
        MsgBox("업데이트 중 알 수 없는 오류가 발생하였습니다." & vbCr & "오류가 지속될 경우 모히또온라인 운영팀으로 문의바랍니다." & vbCr & vbCr & Err.Description, MsgBoxStyle.Critical, "WizCommunity Corp.")
        End
    End Sub
    Private Sub wcClient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles wcClient.DownloadFileCompleted
        On Error GoTo Err

        If ClientsCurrentNum = (UBound(aClientList) + 1) Then
            lbState.Text = "업데이트가 완료되었습니다."
            MsgBox("업데이트에 성공했습니다.", MsgBoxStyle.Information)
            fMain.Show()
            Me.Close()
        Else
            Exit Sub
        End If
        Exit Sub
Err:
        MsgBox("업데이트 중 알 수 없는 오류가 발생하였습니다." & vbCr & "오류가 지속될 경우 모히또온라인 운영팀으로 문의바랍니다." & vbCr & vbCr & Err.Description, MsgBoxStyle.Critical, "WizCommunity Corp.")
        End
    End Sub

End Class