<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClickThis = New System.Windows.Forms.Button()
        Me.LblHelloWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnClickThis
        '
        Me.BtnClickThis.Location = New System.Drawing.Point(389, 173)
        Me.BtnClickThis.Name = "BtnClickThis"
        Me.BtnClickThis.Size = New System.Drawing.Size(75, 23)
        Me.BtnClickThis.TabIndex = 0
        Me.BtnClickThis.Text = "clickthis"
        Me.BtnClickThis.UseVisualStyleBackColor = True
        '
        'LblHelloWorld
        '
        Me.LblHelloWorld.AutoSize = True
        Me.LblHelloWorld.Location = New System.Drawing.Point(395, 244)
        Me.LblHelloWorld.Name = "LblHelloWorld"
        Me.LblHelloWorld.Size = New System.Drawing.Size(58, 18)
        Me.LblHelloWorld.TabIndex = 1
        Me.LblHelloWorld.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblHelloWorld)
        Me.Controls.Add(Me.BtnClickThis)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClickThis As Button
    Friend WithEvents LblHelloWorld As Label
End Class
