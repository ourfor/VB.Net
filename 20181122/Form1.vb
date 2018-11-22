Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        '申明变量来存储圆的面积、周长以及半径
        Dim pi As Double = 3.141592
        Dim area As Double
        Dim circle As Double
        Dim radius As Double
        Me.Text = "本程序将计算圆的周长以及面积,其中圆周率取：3.141592"
        '调用文本输入框
        radius = InputBox("输入圆的半径:")
        area = pi * radius * radius
        circle = radius * pi * 2
        '输出圆的面积和周长
        Me.Text = "点击右上角的×关闭本程序"
        txtHello.Text = "圆的半径为:" + radius.ToString + "其面积为:" + area.ToString + "周长为:" + circle.ToString
    End Sub

End Class
