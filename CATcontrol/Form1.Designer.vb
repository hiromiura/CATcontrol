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
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.TxButton = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.TxDataTextbox = New System.Windows.Forms.TextBox()
        Me.COMPortCombobox = New System.Windows.Forms.ComboBox()
        Me.BaudrateTextbox = New System.Windows.Forms.TextBox()
        Me.ParityTextbox = New System.Windows.Forms.TextBox()
        Me.StartBitTextbox = New System.Windows.Forms.TextBox()
        Me.DataBitTextbox = New System.Windows.Forms.TextBox()
        Me.StopBitTextbox = New System.Windows.Forms.TextBox()
        Me.COMPortLabel = New System.Windows.Forms.Label()
        Me.PC010Button = New System.Windows.Forms.Button()
        Me.KR0Button = New System.Windows.Forms.Button()
        Me.KR1Button = New System.Windows.Forms.Button()
        Me.PC050Button = New System.Windows.Forms.Button()
        Me.BI1Button = New System.Windows.Forms.Button()
        Me.RxDataLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(13, 13)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 0
        Me.ConnectButton.Text = "接続"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'TxButton
        '
        Me.TxButton.Location = New System.Drawing.Point(13, 43)
        Me.TxButton.Name = "TxButton"
        Me.TxButton.Size = New System.Drawing.Size(75, 23)
        Me.TxButton.TabIndex = 2
        Me.TxButton.Text = "送信"
        Me.TxButton.UseVisualStyleBackColor = True
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(13, 97)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectButton.TabIndex = 3
        Me.DisconnectButton.Text = "切断"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'TxDataTextbox
        '
        Me.TxDataTextbox.Location = New System.Drawing.Point(94, 45)
        Me.TxDataTextbox.Name = "TxDataTextbox"
        Me.TxDataTextbox.Size = New System.Drawing.Size(100, 19)
        Me.TxDataTextbox.TabIndex = 4
        '
        'COMPortCombobox
        '
        Me.COMPortCombobox.FormattingEnabled = True
        Me.COMPortCombobox.Location = New System.Drawing.Point(94, 15)
        Me.COMPortCombobox.Name = "COMPortCombobox"
        Me.COMPortCombobox.Size = New System.Drawing.Size(121, 20)
        Me.COMPortCombobox.TabIndex = 6
        '
        'BaudrateTextbox
        '
        Me.BaudrateTextbox.Location = New System.Drawing.Point(251, 15)
        Me.BaudrateTextbox.Name = "BaudrateTextbox"
        Me.BaudrateTextbox.Size = New System.Drawing.Size(100, 19)
        Me.BaudrateTextbox.TabIndex = 7
        Me.BaudrateTextbox.Text = "38400"
        '
        'ParityTextbox
        '
        Me.ParityTextbox.Location = New System.Drawing.Point(251, 45)
        Me.ParityTextbox.Name = "ParityTextbox"
        Me.ParityTextbox.Size = New System.Drawing.Size(100, 19)
        Me.ParityTextbox.TabIndex = 8
        Me.ParityTextbox.Text = "None"
        '
        'StartBitTextbox
        '
        Me.StartBitTextbox.Location = New System.Drawing.Point(251, 73)
        Me.StartBitTextbox.Name = "StartBitTextbox"
        Me.StartBitTextbox.Size = New System.Drawing.Size(100, 19)
        Me.StartBitTextbox.TabIndex = 9
        Me.StartBitTextbox.Text = "1"
        '
        'DataBitTextbox
        '
        Me.DataBitTextbox.Location = New System.Drawing.Point(251, 99)
        Me.DataBitTextbox.Name = "DataBitTextbox"
        Me.DataBitTextbox.Size = New System.Drawing.Size(100, 19)
        Me.DataBitTextbox.TabIndex = 10
        Me.DataBitTextbox.Text = "8"
        '
        'StopBitTextbox
        '
        Me.StopBitTextbox.Location = New System.Drawing.Point(251, 125)
        Me.StopBitTextbox.Name = "StopBitTextbox"
        Me.StopBitTextbox.Size = New System.Drawing.Size(100, 19)
        Me.StopBitTextbox.TabIndex = 11
        Me.StopBitTextbox.Text = "2"
        '
        'COMPortLabel
        '
        Me.COMPortLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.COMPortLabel.Location = New System.Drawing.Point(13, 213)
        Me.COMPortLabel.Name = "COMPortLabel"
        Me.COMPortLabel.Size = New System.Drawing.Size(338, 19)
        Me.COMPortLabel.TabIndex = 12
        Me.COMPortLabel.Text = "COM"
        '
        'PC010Button
        '
        Me.PC010Button.Location = New System.Drawing.Point(402, 12)
        Me.PC010Button.Name = "PC010Button"
        Me.PC010Button.Size = New System.Drawing.Size(75, 23)
        Me.PC010Button.TabIndex = 13
        Me.PC010Button.Text = "PO = 10W"
        Me.PC010Button.UseVisualStyleBackColor = True
        '
        'KR0Button
        '
        Me.KR0Button.Location = New System.Drawing.Point(402, 43)
        Me.KR0Button.Name = "KR0Button"
        Me.KR0Button.Size = New System.Drawing.Size(75, 23)
        Me.KR0Button.TabIndex = 14
        Me.KR0Button.Text = "KEYER OFF"
        Me.KR0Button.UseVisualStyleBackColor = True
        '
        'KR1Button
        '
        Me.KR1Button.Location = New System.Drawing.Point(402, 102)
        Me.KR1Button.Name = "KR1Button"
        Me.KR1Button.Size = New System.Drawing.Size(75, 23)
        Me.KR1Button.TabIndex = 15
        Me.KR1Button.Text = "KEYER ON"
        Me.KR1Button.UseVisualStyleBackColor = True
        '
        'PC050Button
        '
        Me.PC050Button.Location = New System.Drawing.Point(402, 131)
        Me.PC050Button.Name = "PC050Button"
        Me.PC050Button.Size = New System.Drawing.Size(75, 23)
        Me.PC050Button.TabIndex = 16
        Me.PC050Button.Text = "PO = 50W"
        Me.PC050Button.UseVisualStyleBackColor = True
        '
        'BI1Button
        '
        Me.BI1Button.Location = New System.Drawing.Point(402, 73)
        Me.BI1Button.Name = "BI1Button"
        Me.BI1Button.Size = New System.Drawing.Size(75, 23)
        Me.BI1Button.TabIndex = 17
        Me.BI1Button.Text = "BKIN ON"
        Me.BI1Button.UseVisualStyleBackColor = True
        '
        'RxDataLabel
        '
        Me.RxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RxDataLabel.Location = New System.Drawing.Point(94, 73)
        Me.RxDataLabel.Name = "RxDataLabel"
        Me.RxDataLabel.Size = New System.Drawing.Size(121, 19)
        Me.RxDataLabel.TabIndex = 18
        '
        'CATcontrolMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 245)
        Me.Controls.Add(Me.RxDataLabel)
        Me.Controls.Add(Me.BI1Button)
        Me.Controls.Add(Me.PC050Button)
        Me.Controls.Add(Me.KR1Button)
        Me.Controls.Add(Me.KR0Button)
        Me.Controls.Add(Me.PC010Button)
        Me.Controls.Add(Me.COMPortLabel)
        Me.Controls.Add(Me.StopBitTextbox)
        Me.Controls.Add(Me.DataBitTextbox)
        Me.Controls.Add(Me.StartBitTextbox)
        Me.Controls.Add(Me.ParityTextbox)
        Me.Controls.Add(Me.BaudrateTextbox)
        Me.Controls.Add(Me.COMPortCombobox)
        Me.Controls.Add(Me.TxDataTextbox)
        Me.Controls.Add(Me.DisconnectButton)
        Me.Controls.Add(Me.TxButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Name = "CATcontrolMainForm"
        Me.Text = "CATControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectButton As Button
    Friend WithEvents TxButton As Button
    Friend WithEvents DisconnectButton As Button
    Friend WithEvents TxDataTextbox As TextBox
    Friend WithEvents COMPortCombobox As ComboBox
    Friend WithEvents BaudrateTextbox As TextBox
    Friend WithEvents ParityTextbox As TextBox
    Friend WithEvents StartBitTextbox As TextBox
    Friend WithEvents DataBitTextbox As TextBox
    Friend WithEvents StopBitTextbox As TextBox
    Friend WithEvents COMPortLabel As Label
    Friend WithEvents PC010Button As Button
    Friend WithEvents KR0Button As Button
    Friend WithEvents KR1Button As Button
    Friend WithEvents PC050Button As Button
    Friend WithEvents BI1Button As Button
    Friend WithEvents RxDataLabel As Label
End Class
