<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.NumeroFacture = New System.Windows.Forms.TextBox
        Me.ProduitFactureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Facture = New Fournisseur.Facture
        Me.ProduitFactureTableAdapter = New Fournisseur.FactureTableAdapters.ProduitFactureTableAdapter
        CType(Me.ProduitFactureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Facture_ProduitFacture"
        ReportDataSource2.Value = Me.ProduitFactureBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Fournisseur.FactureReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(840, 329)
        Me.ReportViewer1.TabIndex = 0
        '
        'NumeroFacture
        '
        Me.NumeroFacture.Location = New System.Drawing.Point(0, 0)
        Me.NumeroFacture.Name = "NumeroFacture"
        Me.NumeroFacture.Size = New System.Drawing.Size(100, 20)
        Me.NumeroFacture.TabIndex = 1
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
        'ProduitFactureTableAdapter
        '
        Me.ProduitFactureTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 329)
        Me.Controls.Add(Me.NumeroFacture)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapport"
        CType(Me.ProduitFactureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProduitFactureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Facture As Fournisseur.Facture
    Friend WithEvents ProduitFactureTableAdapter As Fournisseur.FactureTableAdapters.ProduitFactureTableAdapter
    Friend WithEvents NumeroFacture As System.Windows.Forms.TextBox
End Class
