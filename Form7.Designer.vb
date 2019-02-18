<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ProduitFactureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Facture = New Fournisseur.Facture
        Me.NumeroFacture = New System.Windows.Forms.TextBox
        Me.ProduitFactureTableAdapter = New Fournisseur.FactureTableAdapters.ProduitFactureTableAdapter
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.ProduitFactureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProduitFactureBindingSource
        '
        Me.ProduitFactureBindingSource.DataMember = "ProduitFacture"
        Me.ProduitFactureBindingSource.DataSource = Me.Facture
        '
        'Facture
        '
        Me.Facture.DataSetName = "Facture"
        Me.Facture.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumeroFacture
        '
        Me.NumeroFacture.Location = New System.Drawing.Point(8, 8)
        Me.NumeroFacture.Name = "NumeroFacture"
        Me.NumeroFacture.Size = New System.Drawing.Size(100, 20)
        Me.NumeroFacture.TabIndex = 1
        '
        'ProduitFactureTableAdapter
        '
        Me.ProduitFactureTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Facture_ProduitFacture"
        ReportDataSource1.Value = Me.ProduitFactureBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fournisseur.BonDeLivraison.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(870, 568)
        Me.ReportViewer1.TabIndex = 2
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 568)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.NumeroFacture)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bon de Livraison"
        CType(Me.ProduitFactureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumeroFacture As System.Windows.Forms.TextBox
    Friend WithEvents ProduitFactureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Facture As Fournisseur.Facture
    Friend WithEvents ProduitFactureTableAdapter As Fournisseur.FactureTableAdapters.ProduitFactureTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
