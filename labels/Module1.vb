Imports CrystalDecisions.Shared
Module Module1
    Public Sub getreport()
        Dim pfields As New ParameterFields
        Dim pfield1, pfield2 As New ParameterField
        Dim pdiscrete1, pdiscrete2 As New ParameterDiscreteValue
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
        Form2.CrystalReportViewer1.ReportSource = rpt
        Form2.CrystalReportViewer1.ParameterFieldInfo = pfields
        rpt.PrintToPrinter(1, True, 1, 1)
    End Sub
End Module
