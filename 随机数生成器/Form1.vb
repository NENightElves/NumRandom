Public Class Form1

    'a数组为主数组，b数组为去重数组，c数组为后台主数组
    'na,nb,nc指向各自数组的最后一个元素
    're代表结果
    Public ff As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        On Error Resume Next
        Dim i As Integer
        Dim a(5000), b(5000), c(5000) As Integer
        Dim na, nb, nc As Integer
        Dim l, r As Integer
        Dim re, s, ts As String
        Dim num As Integer
        ''测试数据
        'a(1) = 2
        'a(2) = 50
        'a(3) = 213
        'a(4) = 45
        'a(5) = 20
        'na = 5

        'b(1) = 2
        'nb = 1

        'ex(a, na, b, nb)

        're = a(1) & "   " & a(2) & "   " & a(3) & "   " & a(4) & "   " & a(5) & "        " & na

        'mix(a, na)

        're = a(1) & "   " & a(2) & "   " & a(3) & "   " & a(4) & "   " & a(5) & "        " & na
        ''测试结束

        'TODO:文件读取，打乱后的数组随机输出，c数组

        '初始化
        For i = 1 To 5000
            a(i) = 0
            b(i) = 0
            c(i) = 0
        Next

        l = 0 : r = 0 : num = 0
        na = 1 : nb = 1 : nc = 1
        re = ""

        '读取窗体数据
        If (TextBox1.Text <> "") And (TextBox2.Text <> "") And (TextBox3.Text <> "") Then
            l = Val(TextBox1.Text)
            r = Val(TextBox2.Text)
            num = Val(TextBox3.Text)
        End If

        '读取文件
        'l为左指针。r为右指针。e为排除的数字。s为实际随机池。m为主随机池新增数字。n为随机数量。
        If (My.Computer.FileSystem.FileExists("random.txt")) And (ff = True) Then
            FileOpen(1, "random.txt", OpenMode.Input)
            While Not EOF(1)
                s = LineInput(1)
                ts = Mid(s, 1, 1)
                Select Case ts
                    Case "l"
                        l = Val(Mid(s, 2, Len(s) - 1))
                    Case "r"
                        r = Val(Mid(s, 2, Len(s) - 1))
                    Case "e"
                        b(nb) = Val(Mid(s, 2, Len(s) - 1))
                        nb = nb + 1
                    Case "s"
                        c(nc) = Val(Mid(s, 2, Len(s) - 1))
                        nc = nc + 1
                    Case "m"
                        a(na) = Val(Mid(s, 2, Len(s) - 1))
                        na = na + 1
                    Case "n"
                        num = Val(Mid(s, 2, Len(s) - 1))
                    Case "B"
                        MsgBox("Happy Birthday for QSH!" & vbCrLf & "                                    9.26", , "Happy Birthday")
                End Select
            End While
            FileClose()
        End If

        '注入数组
        For i = l To r
            a(na) = i
            na = na + 1
        Next
        na = na - 1 : nb = nb - 1 : nc = nc - 1


        If nc = 0 Then
            ex(a, na, b, nb)
            mix(a, na)
            For i = 1 To num
                re = re & ran(a, na) & "   "
            Next
        Else
            ex(c, nc, b, nb)
            mix(c, nc)
            For i = 1 To num
                re = re & ran(c, nc) & "   "
            Next
        End If
        re = Mid(re, 1, Len(re) - 3)
        TextBox4.Text = re
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '213
        ff = False
        If My.Computer.FileSystem.FileExists("random.txt") Then
            FileOpen(1, "random.txt", OpenMode.Input)
            If LineInput(1) = "force" Then ff = True
            FileClose()
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If ff = False Then ff = True Else ff = False
    End Sub
End Class
