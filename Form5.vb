Imports Microsoft.Reporting.WinForms

Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Facture.ProduitFacture' table. You can move, or remove it, as needed.
        'Me.ProduitFactureTableAdapter.Fill(Me.Facture.ProduitFacture)
        Me.ProduitFactureTableAdapter.FillByFacture(Me.Facture.ProduitFacture, Val(NumeroFacture.Text))
        'Dim Param(14) As ReportParameter
        'Param(0) = New ReportParameter("Nom", "Nom")
        'Param(1) = New ReportParameter("Adresse", "Adresse.Text")
        'Param(2) = New ReportParameter("Wilaya", " Wilaya.Text")
        'Param(3) = New ReportParameter("NRC", "NRC.Text")
        'Param(4) = New ReportParameter("NCF", "NCF.Text")
        'Param(5) = New ReportParameter("NC", "NC.Text")
        'Param(6) = New ReportParameter("NIS", "NIS.Text")
        'Param(7) = New ReportParameter("NumeroFacture", "NumeroFactureRapport.Text")
        'Param(8) = New ReportParameter("TypeFacture", "TypeFacture.Text")
        'Param(9) = New ReportParameter("DateBl", "DateBL.Text")
        'Param(10) = New ReportParameter("NumBl", "NumeroBL.Text")
        'Param(11) = New ReportParameter("Total1", "sommeTVA.ToString")
        'Param(12) = New ReportParameter("Total2", "somme.ToString")
        'Param(13) = New ReportParameter("Total3", "Total.ToString")
        'Param(14) = New ReportParameter("TotalLettre", "Ok")
        'Me.ReportViewer1.LocalReport.SetParameters(Param)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class