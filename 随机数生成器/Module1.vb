Module Module1

    Public Sub swap(ByRef a As Integer, ByRef b As Integer)
        '交换数据
        Dim t As Integer
        t = a
        a = b
        b = t
    End Sub

    Public Sub ex(ByRef a() As Integer, ByRef na As Integer, ByRef b() As Integer, ByRef nb As Integer)
        '排除b数组
        'a为待排除数组，b为排除数据
        Dim i, j, t As Integer
        t = na
        For i = 1 To na
            For j = 1 To nb
                If a(i) = b(j) Then del(a, i, t)
            Next
        Next
        na = t
    End Sub

    Public Sub del(ByRef a() As Integer, ByVal n As Integer, ByRef t As Integer)
        '删除数组元素
        'a为待删除数组，n为待删除的元素，t为数组总长度
        Dim i As Integer
        For i = n + 1 To t
            a(i - 1) = a(i)
        Next
        a(t) = 0
        t = t - 1
    End Sub

    Public Sub mix(ByRef a() As Integer, ByVal n As Integer)
        '打乱数组
        'a为待打乱数组，n为数组元素个数
        Randomize()
        Dim i, j, t As Integer
        j = n
        For i = 1 To n
            t = Int(Rnd() * j + 1)
            swap(a(i), a(j))
        Next
    End Sub

    Public Function ran(ByRef a() As Integer, ByRef n As Integer)
        '随机并且排除元素
        Randomize()
        Dim t As Integer
        t = Int(Rnd() * n + 1)
        ran = a(t)
        del(a, t, n)
    End Function



End Module
