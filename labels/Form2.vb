Imports CrystalDecisions.Shared
'Imports MySql.Data.MySqlClient
Public Class Form2
    Dim pfields As New ParameterFields
    Dim pfield1, pfield2 As New ParameterField
    Dim pdiscrete1, pdiscrete2 As New ParameterDiscreteValue
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.choice = 0 Then
            pfield1.Name = "epwnparam"
            pdiscrete1.Value = Form1.epwnparam
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            'MessageBox.Show(AscW(form1.TextBox1.Text))
            pfield2.Name = "epwnparam2"
            pdiscrete2.Value = Form1.epwnparam2
            pfield2.CurrentValues.Add(pdiscrete2)
            pfields.Add(pfield2)
            Dim rpt As New CrystalReport1
            rpt.Load(Application.StartupPath & "\CrystalReport1.rpt")
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.ParameterFieldInfo = pfields

            ' CrystalReportViewer1.Refresh()
            'rpt.PrintToPrinter(1, False, 1, 1)
        End If
        If Form1.choice = 1 Then
            print()
        End If
    End Sub
    Public Sub print()

        'Dim pfields As New ParameterFields
        'Dim pfield1, pfield2 As New ParameterField
        'Dim pdiscrete1, pdiscrete2 As New ParameterDiscreteValue
        pfield1.Name = "epwnparam"
        pdiscrete1.Value = Form1.epwnparam
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        pfield2.Name = "epwnparam2"
        pdiscrete2.Value = Form1.epwnparam2
        pfield2.CurrentValues.Add(pdiscrete2)
        pfields.Add(pfield2)

        Dim rpt As New CrystalReport1
        rpt.Load(Application.StartupPath & "\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields

        CrystalReportViewer1.Refresh()
        rpt.PrintOptions.PrinterName = Form1.PrintDialog1.PrinterSettings.PrinterName

        rpt.PrintToPrinter(1, False, 0, 0)
    End Sub
End Class