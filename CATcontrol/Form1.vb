Imports System.IO.Ports
Imports System.Text
Public Class CATcontrolMainForm

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles Me.Load    'フォームを起動したら
        GetSerialPortNames()    '使用可能なシリアルポート番号を取得する
    End Sub

    Sub GetSerialPortNames()    '使用可能なシリアルポート番号をコンボボックスにセットする
        For Each portName In My.Computer.Ports.SerialPortNames
            COMPortCombobox.Items.Add(portName)
        Next
        COMPortCombobox.SelectedItem = "COM8" 'デフォルト値
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs)
        'テキストボックスの値を適切な型に変換する


        'シリアルポートを開く
        My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem, 38400, Parity.None, 8, 2)
        COMPortLabel.Text = COMPortCombobox.SelectedItem

        '例外処理
        'ポートが開けないか、既に開いている
    End Sub

    Private Sub TxButton_Click(sender As Object, e As EventArgs) Handles TxButton.Click

        'コマンドが空欄の場合は何もしない
        If TxDataTextbox.Text = "" Then
            '   MsgBox("何も送信しません")
            Exit Sub
        End If

        'シリアルポートを開き、コマンドを送信する
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
            COMPortLabel.Text = COMPortCombobox.SelectedItem
            com.WriteLine(TxDataTextbox.Text)
            com.NewLine = ";"
            'End Using

            '送信後受信データを待って表示する
            Dim buffer As String = ""
            'Using com As IO.Ports.SerialPort =
            '   My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
            com.ReadTimeout = 10000
            Do
                buffer = com.ReadLine()
                If buffer Is Nothing Then
                    Exit Do
                Else
                    RxDataLabel.Text = buffer
                    Exit Do
                End If
            Loop
        End Using


        '例外処理
        'ポートが開けない
        '受信タイムアウト

    End Sub

    Private Sub DisconnectButton_Click(sender As Object, e As EventArgs)
        '開いているシリアルポートを閉じる
        My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem).Close()
        COMPortLabel.Text = ""
        '例外処理
        'ポートを開いていない

    End Sub

    Private Sub PC010Button_Click(sender As Object, e As EventArgs) Handles PC010Button.Click
        'シリアルポートを開き、コマンドを送信する
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
            COMPortLabel.Text = COMPortCombobox.SelectedItem
            com.Write("PC010;" & "KR0;" & "BI1;")
        End Using
    End Sub

    Private Sub BI1Button_Click(sender As Object, e As EventArgs) Handles BI1Button.Click
        'シリアルポートを開き、コマンドを送信する
        Using com As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
            COMPortLabel.Text = COMPortCombobox.SelectedItem
            com.Write("PC050;" & "KR1;")
        End Using
    End Sub

    Private Sub RxDataLabel_Click(sender As Object, e As EventArgs) Handles RxDataLabel.Click

    End Sub
End Class
