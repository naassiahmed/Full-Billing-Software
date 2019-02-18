<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPrix = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtQnt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoRdre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RechNumero = New System.Windows.Forms.RadioButton
        Me.RechTypeF = New System.Windows.Forms.RadioButton
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.NC = New System.Windows.Forms.TextBox
        Me.NRC = New System.Windows.Forms.TextBox
        Me.NCF = New System.Windows.Forms.TextBox
        Me.NIS = New System.Windows.Forms.TextBox
        Me.NumeroFactureRapport = New System.Windows.Forms.TextBox
        Me.Wilaya = New System.Windows.Forms.TextBox
        Me.Adresse = New System.Windows.Forms.TextBox
        Me.TypeFacture = New System.Windows.Forms.TextBox
        Me.Nom = New System.Windows.Forms.TextBox
        Me.DateBL = New System.Windows.Forms.TextBox
        Me.NumeroBL = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SousTotal = New System.Windows.Forms.TextBox
        Me.tva = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TotalTTC = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TotalLettre = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPrix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQnt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoRdre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'txtType
        '
        Me.txtType.FormattingEnabled = True
        Me.txtType.Items.AddRange(New Object() {"U", "M"})
        Me.txtType.Location = New System.Drawing.Point(615, 24)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(75, 21)
        Me.txtType.TabIndex = 9
        Me.txtType.Text = "U"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(575, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type "
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(615, 55)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(75, 20)
        Me.txtPrix.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(565, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prix U"
        '
        'txtQnt
        '
        Me.txtQnt.Location = New System.Drawing.Point(401, 55)
        Me.txtQnt.Name = "txtQnt"
        Me.txtQnt.Size = New System.Drawing.Size(69, 20)
        Me.txtQnt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Qunatité"
        '
        'txtNom
        '
        Me.txtNom.FormattingEnabled = True
        Me.txtNom.Location = New System.Drawing.Point(78, 55)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(197, 21)
        Me.txtNom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Désignation"
        '
        'txtNoRdre
        '
        Me.txtNoRdre.Location = New System.Drawing.Point(401, 25)
        Me.txtNoRdre.Name = "txtNoRdre"
        Me.txtNoRdre.Size = New System.Drawing.Size(69, 20)
        Me.txtNoRdre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Ordre"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(78, 25)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumero.Size = New System.Drawing.Size(169, 20)
        Me.txtNumero.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facture"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(756, 200)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 153)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(416, 119)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(103, 17)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Bon de Livraison"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(416, 89)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "La facture"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Fournisseur.My.Resources.Resources.Log_Out_48x48
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(706, 83)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 55)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "      Sortir"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.Image = Global.Fournisseur.My.Resources.Resources.print_48
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(536, 83)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(164, 55)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "     Imprimer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RechNumero)
        Me.GroupBox3.Controls.Add(Me.RechTypeF)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 62)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche"
        '
        'RechNumero
        '
        Me.RechNumero.AutoSize = True
        Me.RechNumero.Checked = True
        Me.RechNumero.Location = New System.Drawing.Point(14, 24)
        Me.RechNumero.Name = "RechNumero"
        Me.RechNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RechNumero.Size = New System.Drawing.Size(117, 17)
        Me.RechNumero.TabIndex = 1
        Me.RechNumero.TabStop = True
        Me.RechNumero.Text = "Numéro de Facture"
        Me.RechNumero.UseVisualStyleBackColor = True
        '
        'RechTypeF
        '
        Me.RechTypeF.AutoSize = True
        Me.RechTypeF.Location = New System.Drawing.Point(141, 24)
        Me.RechTypeF.Name = "RechTypeF"
        Me.RechTypeF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RechTypeF.Size = New System.Drawing.Size(104, 17)
        Me.RechTypeF.TabIndex = 0
        Me.RechTypeF.Text = "Type de Facture"
        Me.RechTypeF.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Fournisseur.My.Resources.Resources.Preview_48x48
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(287, 83)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "      Chercher"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = Global.Fournisseur.My.Resources.Resources.Close1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(541, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 59)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "        Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Fournisseur.My.Resources.Resources.Edit1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(371, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 59)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "      Modifier "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Fournisseur.My.Resources.Resources.Save_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(201, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 59)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "        Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Fournisseur.My.Resources.Resources.Paste
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(31, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "          Nouveau  "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(356, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Visible = False
        '
        'NC
        '
        Me.NC.Location = New System.Drawing.Point(70, 230)
        Me.NC.Name = "NC"
        Me.NC.Size = New System.Drawing.Size(19, 20)
        Me.NC.TabIndex = 15
        Me.NC.Visible = False
        '
        'NRC
        '
        Me.NRC.Location = New System.Drawing.Point(57, 178)
        Me.NRC.Name = "NRC"
        Me.NRC.Size = New System.Drawing.Size(37, 20)
        Me.NRC.TabIndex = 16
        Me.NRC.Visible = False
        '
        'NCF
        '
        Me.NCF.Location = New System.Drawing.Point(70, 204)
        Me.NCF.Name = "NCF"
        Me.NCF.Size = New System.Drawing.Size(24, 20)
        Me.NCF.TabIndex = 17
        Me.NCF.Visible = False
        '
        'NIS
        '
        Me.NIS.Location = New System.Drawing.Point(73, 256)
        Me.NIS.Name = "NIS"
        Me.NIS.Size = New System.Drawing.Size(16, 20)
        Me.NIS.TabIndex = 18
        Me.NIS.Visible = False
        '
        'NumeroFactureRapport
        '
        Me.NumeroFactureRapport.Location = New System.Drawing.Point(139, 178)
        Me.NumeroFactureRapport.Name = "NumeroFactureRapport"
        Me.NumeroFactureRapport.Size = New System.Drawing.Size(16, 20)
        Me.NumeroFactureRapport.TabIndex = 19
        Me.NumeroFactureRapport.Visible = False
        '
        'Wilaya
        '
        Me.Wilaya.Location = New System.Drawing.Point(240, 230)
        Me.Wilaya.Name = "Wilaya"
        Me.Wilaya.Size = New System.Drawing.Size(16, 20)
        Me.Wilaya.TabIndex = 23
        Me.Wilaya.Visible = False
        '
        'Adresse
        '
        Me.Adresse.Location = New System.Drawing.Point(240, 204)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(16, 20)
        Me.Adresse.TabIndex = 22
        Me.Adresse.Visible = False
        '
        'TypeFacture
        '
        Me.TypeFacture.Location = New System.Drawing.Point(183, 178)
        Me.TypeFacture.Name = "TypeFacture"
        Me.TypeFacture.Size = New System.Drawing.Size(24, 20)
        Me.TypeFacture.TabIndex = 21
        Me.TypeFacture.Visible = False
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(237, 178)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(19, 20)
        Me.Nom.TabIndex = 20
        Me.Nom.Visible = False
        '
        'DateBL
        '
        Me.DateBL.Location = New System.Drawing.Point(289, 178)
        Me.DateBL.Name = "DateBL"
        Me.DateBL.Size = New System.Drawing.Size(24, 20)
        Me.DateBL.TabIndex = 25
        Me.DateBL.Visible = False
        '
        'NumeroBL
        '
        Me.NumeroBL.Location = New System.Drawing.Point(289, 204)
        Me.NumeroBL.Name = "NumeroBL"
        Me.NumeroBL.Size = New System.Drawing.Size(19, 20)
        Me.NumeroBL.TabIndex = 24
        Me.NumeroBL.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Sous-Total"
        '
        'SousTotal
        '
        Me.SousTotal.Location = New System.Drawing.Point(237, 305)
        Me.SousTotal.Name = "SousTotal"
        Me.SousTotal.Size = New System.Drawing.Size(91, 20)
        Me.SousTotal.TabIndex = 27
        '
        'tva
        '
        Me.tva.Location = New System.Drawing.Point(366, 304)
        Me.tva.Name = "tva"
        Me.tva.Size = New System.Drawing.Size(55, 20)
        Me.tva.TabIndex = 29
        Me.tva.Text = "17"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "TVA"
        '
        'TotalTTC
        '
        Me.TotalTTC.Location = New System.Drawing.Point(500, 304)
        Me.TotalTTC.Name = "TotalTTC"
        Me.TotalTTC.Size = New System.Drawing.Size(91, 20)
        Me.TotalTTC.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(433, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Total T.T.C"
        '
        'TotalLettre
        '
        Me.TotalLettre.Location = New System.Drawing.Point(116, 338)
        Me.TotalLettre.Name = "TotalLettre"
        Me.TotalLettre.Size = New System.Drawing.Size(652, 20)
        Me.TotalLettre.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Somme en lettres "
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 517)
        Me.Controls.Add(Me.TotalLettre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TotalTTC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SousTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateBL)
        Me.Controls.Add(Me.NumeroBL)
        Me.Controls.Add(Me.Wilaya)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.TypeFacture)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.NumeroFactureRapport)
        Me.Controls.Add(Me.NIS)
        Me.Controls.Add(Me.NCF)
        Me.Controls.Add(Me.NRC)
        Me.Controls.Add(Me.NC)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Les produits Commandés"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoRdre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RechNumero As System.Windows.Forms.RadioButton
    Friend WithEvents RechTypeF As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NC As System.Windows.Forms.TextBox
    Friend WithEvents NRC As System.Windows.Forms.TextBox
    Friend WithEvents NCF As System.Windows.Forms.TextBox
    Friend WithEvents NIS As System.Windows.Forms.TextBox
    Friend WithEvents NumeroFactureRapport As System.Windows.Forms.TextBox
    Friend WithEvents Wilaya As System.Windows.Forms.TextBox
    Friend WithEvents Adresse As System.Windows.Forms.TextBox
    Friend WithEvents TypeFacture As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.TextBox
    Friend WithEvents DateBL As System.Windows.Forms.TextBox
    Friend WithEvents NumeroBL As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SousTotal As System.Windows.Forms.TextBox
    Friend WithEvents tva As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TotalTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotalLettre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
