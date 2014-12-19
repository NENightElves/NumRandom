Public Class Form1

    'a数组为主数组，b数组为去重数组，c数组为后台主数组
    'na,nb,nc指向各自数组的最后一个元素
    're代表结果
    Public ff, fff As Boolean
    Dim obj(100) As locastru

    Private Sub iobj(ByVal n As Integer, ByVal x As Object)
        obj(n).x = x.Location.X / Me.Width
        obj(n).y = x.Location.Y / Me.Height
        obj(n).a = x.Width / Me.Width
        obj(n).b = x.Height / Me.Height
    End Sub

    Private Sub robj(ByVal n As Integer, ByVal x As Object)
        x.Location = New Point(obj(n).x * Me.Location.X, obj(n).y * Me.Location.Y)
        x.Width = obj(n).a * Me.Width
        x.Height = obj(n).b * Me.Height
    End Sub

    Private Sub rrobj(ByVal r As Object, ByVal x As Single, ByVal y As Single, ByVal a As Single, ByVal b As Single)
        r.Location = New Point(Me.Width * x, Me.Height * y)
        r.Width = a * Me.Width
        r.Height = b * Me.Height
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        On Error Resume Next
        Dim i As Integer
        Dim a(5000), b(5000), c(5000) As Integer
        Dim na, nb, nc As Integer
        Dim l, r As Integer
        Dim re, s, ts As String
        Dim num As Integer
        Dim abc, abcd As Integer
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

        'cheat
        'abc = True
        'abcd = True
        'If (TextBox4.Text <> Chr(81) & Chr(83) & Chr(72) & " is " & Chr(83) & Chr(66) & Chr(33)) And (abcd = True) Then
        '    abc = False
        'End If
        'If abc = False Then
        '    TextBox4.Text = "7   24"
        '    Exit Sub
        'End If
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
        'iobj(1, Label1)
        'iobj(2, TextBox1)
        fff = True
        ff = False

        'rrobj(Label1, 1 / 5, 1 / 10, 1 / 3, 1 / 10)

        If My.Computer.FileSystem.FileExists("random.txt") Then
            FileOpen(1, "random.txt", OpenMode.Input)
            If LineInput(1) = "force" Then ff = True
            FileClose()
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If ff = False Then ff = True Else ff = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If fff = True Then
            'robj(1, Label1)
            'robj(2, TextBox1)
            'Label1.Location = New Point(obj(1).x * Me.Location.X, obj(1).y * Me.Location.Y)
            'Label1.Width = obj(1).a * Me.Width
            'Label1.Height = obj(1).b * Me.Height
            Label1.Font = New Font("微软雅黑", Me.Width / 20)
            Label1.Location = New Point(Label1.Location.X, Me.Width / 20 * 2)
            Label2.Font = New Font("微软雅黑", Me.Width / 20)
            Label2.Location = New Point(Label2.Location.X, Me.Width / 20 * 5)
            Label3.Font = New Font("微软雅黑", Me.Width / 20)
            Label3.Location = New Point(Label3.Location.X, Me.Width / 20 * 8)

            TextBox1.Font = New Font("微软雅黑", Me.Width / 20)
            TextBox1.Width = Me.Width - TextBox1.Location.X - TextBox1.Width / 5 - 3
            TextBox1.Location = New Point(Label1.Location.X + Label1.Width + 3, Label1.Location.Y)
            TextBox2.Font = New Font("微软雅黑", Me.Width / 20)
            TextBox2.Width = Me.Width - TextBox2.Location.X - TextBox2.Width / 5 - 3
            TextBox2.Location = New Point(Label2.Location.X + Label2.Width + 3, Label2.Location.Y)
            TextBox3.Font = New Font("微软雅黑", Me.Width / 20)
            TextBox3.Width = Me.Width - TextBox3.Location.X - TextBox3.Width / 5 - 3
            TextBox3.Location = New Point(Label3.Location.X + Label3.Width + 3, Label3.Location.Y)
            TextBox4.Location = New Point(Label3.Location.X + 50, Label3.Location.Y + Label3.Height + 50)
            TextBox4.Width = TextBox3.Location.X + TextBox3.Width - Label3.Location.X - 90
            TextBox4.Height = TextBox3.Height
            TextBox4.Font = New Font("微软雅黑", Me.Width / 20)

            Button1.Location = New Point(Me.Width / 2 - 50, TextBox4.Location.Y + 20 + TextBox4.Height)

            If (Me.Height < (Button1.Location.Y + 70)) Then Me.Height = Button1.Location.Y + 100


        End If
        'rrobj(Label1, 1 / 5, 1 / 10, 1 / 3, 1 / 10)
    End Sub
End Class
