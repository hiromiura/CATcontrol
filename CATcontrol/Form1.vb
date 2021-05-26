Imports System.IO.Ports
Imports System.Text
Public Class CATcontrolMainForm

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles Me.Load    'フォームを起動したら

        GetSerialPortNames()    '使用可能なシリアルポート番号をコンボボックスにセットする

    End Sub

    Sub GetSerialPortNames()    '使用可能なシリアルポート番号をコンボボックスにセットする

        For Each portName In My.Computer.Ports.SerialPortNames
            COMPortCombobox.Items.Add(portName)
        Next

        'COMPortCombobox.SelectedIndex = 0 '最初のアイテムを選択状態にしておく
        COMPortCombobox.SelectedItem = "COM8" '自分の環境でのデフォルト値

    End Sub

    Private Sub TxButton_Click(sender As Object, e As EventArgs) Handles TxButton.Click

        'コマンドが空欄の場合は何もしない
        If TxDataTextbox.Text = "" Then Exit Sub

        Try

            'シリアルポートを開き、コマンドを送信する
            Using com As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)

                COMPortLabel.Text = COMPortCombobox.SelectedItem
                com.NewLine = ";"
                com.WriteLine(TxDataTextbox.Text)

                '送信後受信データを待って表示する
                Dim buffer As String = ""
                com.ReadTimeout = 100
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

        Catch ex As Exception
            MsgBox("err")
        End Try

    End Sub

    Private Sub PC010Button_Click(sender As Object, e As EventArgs) Handles PC010Button.Click

        'シリアルポートを開き、コマンドを送信する
        Try

            Using com As IO.Ports.SerialPort =
                My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
                COMPortLabel.Text = COMPortCombobox.SelectedItem
                com.Write("PC010;" & "KR0;" & "BI1;")
            End Using

        Catch ex As Exception
            MsgBox("err")
        End Try

    End Sub

    Private Sub BI1Button_Click(sender As Object, e As EventArgs) Handles BI1Button.Click

        'シリアルポートを開き、コマンドを送信する
        Try

            Using com As IO.Ports.SerialPort =
                My.Computer.Ports.OpenSerialPort(COMPortCombobox.SelectedItem)
                COMPortLabel.Text = COMPortCombobox.SelectedItem
                com.Write("PC050;" & "KR1;")
            End Using

        Catch ex As Exception
            MsgBox("err")
        End Try

    End Sub

End Class
