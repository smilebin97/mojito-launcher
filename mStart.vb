Option Strict Off
Option Explicit On
Imports System.Net

Module mStart
    Dim wc As New WebClient
    Dim CheckNum As Integer
    Dim aClientInfo() As String = Split(wc.DownloadString("http://wizcmnt.dothome.co.kr/mojito/clientinfo.txt"), vbLf)
    Dim aClientList(UBound(aClientInfo)), aClientSize(UBound(aClientInfo)) As String

    'Private Declare Function mStart Lib "user32" Alias "mStart" (ByVal info As String) As Integer
    Public Base = 6709
    Public Character = 1373167204
    Public Effect = 386808366
    Public Etc = 100405170
    Public Item = 189113899
    Public Map = 1986846320
    Public Mob = 2060739517
    Public Morph = 36042930
    Public Npc = 413813651
    Public Quest = 16857018
    Public Reactor = 151211213
    Public Skill = 1628828615
    Public Sound = 1182720160
    Public Strings = 9360334
    Public TamingMob = 2134
    Public UI = 265386011
    Public Sub Start(ByVal ss As String)
        On Error GoTo err
        CheckNum = 0

        For i = 0 To UBound(aClientInfo)
            aClientList(i) = Split(aClientInfo(i), "#")(0)
            aClientSize(i) = Split(aClientInfo(i), "#")(1)

        Next


        For i = 0 To UBound(aClientInfo)
            If Len(Dir(My.Application.Info.DirectoryPath & "\" & aClientList(i))) Then '파일 유무 검사
                If FileLen(My.Application.Info.DirectoryPath & "\" & aClientList(i)) <> aClientSize(i) Then '파일 용량 검사
                    MsgBox("데이터 임의 조작 등의 이유로 클라이언트가 손상되었습니다." & vbCr & "스타터를 다시 실행하여 업데이트를 진행하세요.", MsgBoxStyle.Critical)
                    End
                Else
                    CheckNum += 1
                End If

            Else
                MsgBox("데이터 임의 조작 등의 이유로 클라이언트가 손상되었습니다." & vbCr & "스타터를 다시 실행하여 업데이트를 진행하세요.", MsgBoxStyle.Critical)
                End
            End If
        Next

        If CheckNum = UBound(aClientInfo) + 1 Then
            Shell(My.Application.Info.DirectoryPath & "\MapleStory.exe " & ss)
            fMain.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Else
            MsgBox("클라이언트 변조 검사가 제대로 이루어지지 않았습니다." & vbCr & "스타터를 다시 실행하여 업데이트를 진행하세요.", MsgBoxStyle.Critical)
            End
        End If
        Exit Sub
err:
        MsgBox(aClientList(0))
        End

    End Sub
End Module