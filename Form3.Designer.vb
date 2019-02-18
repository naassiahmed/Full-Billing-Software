<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RechNumBL = New System.Windows.Forms.RadioButton
        Me.RechDate = New System.Windows.Forms.RadioButton
        Me.RechNumero = New System.Windows.Forms.RadioButton
        Me.RechTypeF = New System.Windows.Forms.RadioButton
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtC = New System.Windows.Forms.ComboBox
        Me.txtNIS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCF = New System.Windows.Forms.TextBox
        Me.txtTypeF = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNumeroBL = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Count = New System.Windows.Forms.Label
        Me.txtNumroClient = New System.Windows.Forms.TextBox
        Me.txtNumeroFacture = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Wilaya = New System.Windows.Forms.TextBox
        Me.Adresse = New System.Windows.Forms.TextBox
        Me.Nom = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Facture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numéro Facture"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(402, 15)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(161, 20)
        Me.txtNumero.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom Client"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(89, 19)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(210, 20)
        Me.txtNom.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numéro de registre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 290)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RechNumBL)
        Me.GroupBox3.Controls.Add(Me.RechDate)
        Me.GroupBox3.Controls.Add(Me.RechNumero)
        Me.GroupBox3.Controls.Add(Me.RechTypeF)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 67)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche"
        '
        'RechNumBL
        '
        Me.RechNumBL.AutoSize = True
        Me.RechNumBL.Location = New System.Drawing.Point(133, 38)
        Me.RechNumBL.Name = "RechNumBL"
        Me.RechNumBL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RechNumBL.Size = New System.Drawing.Size(91, 17)
        Me.RechNumBL.TabIndex = 3
        Me.RechNumBL.Text = "Numéro de BL"
        Me.RechNumBL.UseVisualStyleBackColor = True
        '
        'RechDate
        '
        Me.RechDate.AutoSize = True
        Me.RechDate.Location = New System.Drawing.Point(6, 38)
        Me.RechDate.Name = "RechDate"
        Me.RechDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RechDate.Size = New System.Drawing.Size(121, 17)
        Me.RechDate.TabIndex = 2
        Me.RechDate.Text = "Date de Facturation"
        Me.RechDate.UseVisualStyleBackColor = True
        '
        'RechNumero
        '
        Me.RechNumero.AutoSize = True
        Me.RechNumero.Checked = True
        Me.RechNumero.Location = New System.Drawing.Point(6, 15)
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
        Me.RechTypeF.Location = New System.Drawing.Point(133, 15)
        Me.RechTypeF.Name = "RechTypeF"
        Me.RechTypeF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RechTypeF.Size = New System.Drawing.Size(104, 17)
        Me.RechTypeF.TabIndex = 0
        Me.RechTypeF.Text = "Type de Facture"
        Me.RechTypeF.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(279, 245)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(18, 20)
        Me.TextBox3.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Image = Global.Fournisseur.My.Resources.Resources.Preview_48x48
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(64, 223)
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
        Me.Button4.Location = New System.Drawing.Point(138, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 59)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Supprimer   "
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Fournisseur.My.Resources.Resources.Edit1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(10, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 59)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modifier        "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Fournisseur.My.Resources.Resources.Save_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(138, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 59)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ajouter        "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Fournisseur.My.Resources.Resources.Paste
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(10, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nouveau     "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.FormattingEnabled = True
        Me.txtC.Location = New System.Drawing.Point(117, 148)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(210, 21)
        Me.txtC.TabIndex = 8
        '
        'txtNIS
        '
        Me.txtNIS.Location = New System.Drawing.Point(117, 184)
        Me.txtNIS.Name = "txtNIS"
        Me.txtNIS.Size = New System.Drawing.Size(210, 20)
        Me.txtNIS.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Numéro de compte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "N I S"
        '
        'txtNR
        '
        Me.txtNR.FormattingEnabled = True
        Me.txtNR.Location = New System.Drawing.Point(117, 81)
        Me.txtNR.Name = "txtNR"
        Me.txtNR.Size = New System.Drawing.Size(210, 21)
        Me.txtNR.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Type de Facture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numéro Catre Fiscale"
        '
        'txtCF
        '
        Me.txtCF.Location = New System.Drawing.Point(117, 113)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(210, 20)
        Me.txtCF.TabIndex = 3
        '
        'txtTypeF
        '
        Me.txtTypeF.FormattingEnabled = True
        Me.txtTypeF.Items.AddRange(New Object() {"FACTURE PROFORMAT", "FACTURE"})
        Me.txtTypeF.Location = New System.Drawing.Point(117, 220)
        Me.txtTypeF.Name = "txtTypeF"
        Me.txtTypeF.Size = New System.Drawing.Size(210, 21)
        Me.txtTypeF.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(333, 290)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Informations"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtNumeroBL)
        Me.GroupBox5.Controls.Add(Me.txtDate)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 188)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(312, 89)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Information à saisir plus tard"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Numéro BL"
        '
        'txtNumeroBL
        '
        Me.txtNumeroBL.Location = New System.Drawing.Point(77, 53)
        Me.txtNumeroBL.Name = "txtNumeroBL"
        Me.txtNumeroBL.Size = New System.Drawing.Size(210, 20)
        Me.txtNumeroBL.TabIndex = 11
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(65, 19)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(241, 20)
        Me.txtDate.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 137)
        Me.DataGridView1.TabIndex = 15
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(339, 495)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(41, 13)
        Me.Count.TabIndex = 16
        Me.Count.Text = "الثمن :"
        '
        'txtNumroClient
        '
        Me.txtNumroClient.Location = New System.Drawing.Point(92, 45)
        Me.txtNumroClient.Name = "txtNumroClient"
        Me.txtNumroClient.Size = New System.Drawing.Size(210, 20)
        Me.txtNumroClient.TabIndex = 5
        Me.txtNumroClient.Visible = False
        '
        'txtNumeroFacture
        '
        Me.txtNumeroFacture.Location = New System.Drawing.Point(366, 41)
        Me.txtNumeroFacture.Name = "txtNumeroFacture"
        Me.txtNumeroFacture.Size = New System.Drawing.Size(210, 20)
        Me.txtNumeroFacture.TabIndex = 19
        Me.txtNumeroFacture.Visible = False
        '
        'Button7
        '
        Me.Button7.Image = Global.Fournisseur.My.Resources.Resources.Log_Out_48x48
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(480, 426)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 55)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "      Sortir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Fournisseur.My.Resources.Resources.buy_48
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(480, 365)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 55)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "     Ajouter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Produits"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Wilaya
        '
        Me.Wilaya.Location = New System.Drawing.Point(660, 282)
        Me.Wilaya.Name = "Wilaya"
        Me.Wilaya.Size = New System.Drawing.Size(18, 20)
        Me.Wilaya.TabIndex = 21
        '
        'Adresse
        '
        Me.Adresse.Location = New System.Drawing.Point(657, 256)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(18, 20)
        Me.Adresse.TabIndex = 20
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(657, 230)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(18, 20)
        Me.Nom.TabIndex = 22
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(629, 522)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Wilaya)
        Me.Controls.Add(Me.txtNumeroFacture)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.txtNumroClient)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTypeF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNIS)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des factures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RechDate As System.Windows.Forms.RadioButton
    Friend WithEvents RechNumero As System.Windows.Forms.RadioButton
    Friend WithEvents RechTypeF As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtC As System.Windows.Forms.ComboBox
    Friend WithEvents txtNIS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCF As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeF As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBL As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RechNumBL As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtNumroClient As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroFacture As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Wilaya As System.Windows.Forms.TextBox
    Friend WithEvents Adresse As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.TextBox
End Class
