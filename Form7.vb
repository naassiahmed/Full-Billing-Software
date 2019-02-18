Imports Microsoft.Reporting.WinForms
Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Facture.ProduitFacture' table. You can move, or remove it, as needed.
        'Me.ProduitFactureTableAdapter.Fill(Me.Facture.ProduitFacture)
        Me.ProduitFactureTableAdapter.FillByFacture(Me.Facture.ProduitFacture, Val(NumeroFacture.Text))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class