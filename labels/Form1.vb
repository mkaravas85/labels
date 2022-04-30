Imports System.Runtime.InteropServices
Imports CrystalDecisions.Shared
Public Class Form1
    Public epwnparam, epwnparam2 As String
    Public choice As Integer = -1
    <DllImport("ODBCCP32.dll", CallingConvention:=CallingConvention.Winapi, _
                            CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Shared Function SQLConfigDataSourceW(ByVal hwndParent As Integer, _
                                                ByVal fRequest As Integer, _
                                                ByVal lpszDriver As String, _
                                                ByVal lpszAttributes As String) _
                                                As Integer
    End Function
    Private Sub setparam()
        Try

            epwnparam = TextBox1.Text.ToUpper
            epwnparam2 = TextBox2.Text.ToUpper
            If (String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text)) = False Then

                If AscW("A") <= AscW(epwnparam2) <= AscW("Z") Then
                    epwnparam2 = epwnparam2 & "ZZZ"
                End If
                If AscW("Α") <= AscW(epwnparam2) <= AscW("Ω") Then
                    epwnparam2 = epwnparam2 & "ΩΩΩ"
                End If
            End If

            Form2.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        choice = 0
        setparam()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If PrintDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            choice = 1
            setparam()
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim attributes As String
        attributes = "SERVER=192.168.1.10;UID=signet;PASSWORD=enapass;DSN=signet;PORT=33953;DATABASE=dbexagr;charset=greek" & Chr(0)
        SQLConfigDataSourceW(0, 4, "MySQL ODBC 3.51 Driver", attributes)
    End Sub
End Class
