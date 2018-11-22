<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(287, 303)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(242, 79)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Run"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'txtHello
        '
        Me.txtHello.Font = New System.Drawing.Font("宋体", 15.73109!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtHello.Location = New System.Drawing.Point(190, 97)
        Me.txtHello.Multiline = True
        Me.txtHello.Name = "txtHello"
        Me.txtHello.Size = New System.Drawing.Size(441, 112)
        Me.txtHello.TabIndex = 1
        Me.txtHello.Text = "本程序将输出圆的面积和周长"
        Me.txtHello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHello)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "Form1"
        Me.Text = "Hi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnHello As Button
    Friend WithEvents txtHello As TextBox
    Friend WithEvents Label1 As Label
End Class
