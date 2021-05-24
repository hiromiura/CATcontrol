<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATcontrolMainForm
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
        Me.TxButton = New System.Windows.Forms.Button()
        Me.TxDataTextbox = New System.Windows.Forms.TextBox()
        Me.COMPortCombobox = New System.Windows.Forms.ComboBox()
        Me.COMPortLabel = New System.Windows.Forms.Label()
        Me.PC010Button = New System.Windows.Forms.Button()
        Me.BI1Button = New System.Windows.Forms.Button()
        Me.RxDataLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxButton
        '
        Me.TxButton.Location = New System.Drawing.Point(15, 43)
        Me.TxButton.Name = "TxButton"
        Me.TxButton.Size = New System.Drawing.Size(75, 23)
        Me.TxButton.TabIndex = 2
        Me.TxButton.Text = "送信"
        Me.TxButton.UseVisualStyleBackColor = True
        '
        'TxDataTextbox
        '
        Me.TxDataTextbox.Location = New System.Drawing.Point(94, 45)
        Me.TxDataTextbox.Name = "TxDataTextbox"
        Me.TxDataTextbox.Size = New System.Drawing.Size(168, 19)
        Me.TxDataTextbox.TabIndex = 4
        '
        'COMPortCombobox
        '
        Me.COMPortCombobox.FormattingEnabled = True
        Me.COMPortCombobox.Location = New System.Drawing.Point(94, 15)
        Me.COMPortCombobox.Name = "COMPortCombobox"
        Me.COMPortCombobox.Size = New System.Drawing.Size(63, 20)
        Me.COMPortCombobox.TabIndex = 6
        Me.COMPortCombobox.Text = "COM8"
        '
        'COMPortLabel
        '
        Me.COMPortLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.COMPortLabel.Location = New System.Drawing.Point(15, 182)
        Me.COMPortLabel.Name = "COMPortLabel"
        Me.COMPortLabel.Size = New System.Drawing.Size(247, 19)
        Me.COMPortLabel.TabIndex = 12
        Me.COMPortLabel.Text = "COM"
        '
        'PC010Button
        '
        Me.PC010Button.Location = New System.Drawing.Point(15, 73)
        Me.PC010Button.Name = "PC010Button"
        Me.PC010Button.Size = New System.Drawing.Size(121, 79)
        Me.PC010Button.TabIndex = 13
        Me.PC010Button.Text = "チューニング設定"
        Me.PC010Button.UseVisualStyleBackColor = True
        '
        'BI1Button
        '
        Me.BI1Button.Location = New System.Drawing.Point(142, 73)
        Me.BI1Button.Name = "BI1Button"
        Me.BI1Button.Size = New System.Drawing.Size(121, 79)
        Me.BI1Button.TabIndex = 17
        Me.BI1Button.Text = "運用設定"
        Me.BI1Button.UseVisualStyleBackColor = True
        '
        'RxDataLabel
        '
        Me.RxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RxDataLabel.Location = New System.Drawing.Point(15, 155)
        Me.RxDataLabel.Name = "RxDataLabel"
        Me.RxDataLabel.Size = New System.Drawing.Size(247, 21)
        Me.RxDataLabel.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "COM Port"
        '
        'CATcontrolMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 216)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RxDataLabel)
        Me.Controls.Add(Me.BI1Button)
        Me.Controls.Add(Me.PC010Button)
        Me.Controls.Add(Me.COMPortLabel)
        Me.Controls.Add(Me.COMPortCombobox)
        Me.Controls.Add(Me.TxDataTextbox)
        Me.Controls.Add(Me.TxButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CATcontrolMainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CATControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxButton As Button
    Friend WithEvents TxDataTextbox As TextBox
    Friend WithEvents COMPortCombobox As ComboBox
    Friend WithEvents COMPortLabel As Label
    Friend WithEvents PC010Button As Button
    Friend WithEvents BI1Button As Button
    Friend WithEvents RxDataLabel As Label
    Friend WithEvents Label1 As Label
End Class
