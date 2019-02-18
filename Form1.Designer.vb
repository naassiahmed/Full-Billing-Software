<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtQnt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPrix = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RechQnt = New System.Windows.Forms.RadioButton
        Me.RechPrix = New System.Windows.Forms.RadioButton
        Me.RechNom = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Count = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPourcen = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtVente = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtVente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtQnt)
        Me.GroupBox1.Controls.Add(Me.txtPourcen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPrix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(656, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المنتوج"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "الكمية :"
        '
        'txtQnt
        '
        Me.txtQnt.Location = New System.Drawing.Point(209, 17)
        Me.txtQnt.Name = "txtQnt"
        Me.txtQnt.Size = New System.Drawing.Size(45, 20)
        Me.txtQnt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "الثمن :"
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(304, 17)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(48, 20)
        Me.txtPrix.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(575, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "إسم المنتوج :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(399, 17)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(172, 20)
        Me.txtNom.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RechQnt)
        Me.GroupBox3.Controls.Add(Me.RechPrix)
        Me.GroupBox3.Controls.Add(Me.RechNom)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(245, 67)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بحث عن"
        '
        'RechQnt
        '
        Me.RechQnt.AutoSize = True
        Me.RechQnt.Location = New System.Drawing.Point(77, 42)
        Me.RechQnt.Name = "RechQnt"
        Me.RechQnt.Size = New System.Drawing.Size(76, 17)
        Me.RechQnt.TabIndex = 2
        Me.RechQnt.TabStop = True
        Me.RechQnt.Text = "كمية منتوج"
        Me.RechQnt.UseVisualStyleBackColor = True
        '
        'RechPrix
        '
        Me.RechPrix.AutoSize = True
        Me.RechPrix.Location = New System.Drawing.Point(32, 19)
        Me.RechPrix.Name = "RechPrix"
        Me.RechPrix.Size = New System.Drawing.Size(72, 17)
        Me.RechPrix.TabIndex = 1
        Me.RechPrix.TabStop = True
        Me.RechPrix.Text = "ثمن منتوج"
        Me.RechPrix.UseVisualStyleBackColor = True
        '
        'RechNom
        '
        Me.RechNom.AutoSize = True
        Me.RechNom.Checked = True
        Me.RechNom.Location = New System.Drawing.Point(149, 19)
        Me.RechNom.Name = "RechNom"
        Me.RechNom.Size = New System.Drawing.Size(76, 17)
        Me.RechNom.TabIndex = 0
        Me.RechNom.TabStop = True
        Me.RechNom.Text = "إسم منتوج"
        Me.RechNom.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(289, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(656, 187)
        Me.DataGridView1.TabIndex = 2
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(502, 222)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(64, 20)
        Me.txtNumero.TabIndex = 7
        Me.txtNumero.Visible = False
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(331, 267)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(41, 13)
        Me.Count.TabIndex = 7
        Me.Count.Text = "الثمن :"
        '
        'Button5
        '
        Me.Button5.Image = Global.Fournisseur.My.Resources.Resources.Preview_48x48
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(64, 223)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "بحث        "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = Global.Fournisseur.My.Resources.Resources.Close1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(10, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 59)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "حذف        "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Fournisseur.My.Resources.Resources.Edit1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(138, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 59)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "تعديل        "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Fournisseur.My.Resources.Resources.Save_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(10, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 59)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "إضافة        "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Fournisseur.My.Resources.Resources.Paste
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(138, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "جديد         "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "الكمية :"
        '
        'txtPourcen
        '
        Me.txtPourcen.Location = New System.Drawing.Point(6, 17)
        Me.txtPourcen.Name = "txtPourcen"
        Me.txtPourcen.Size = New System.Drawing.Size(45, 20)
        Me.txtPourcen.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ثمن البيع"
        '
        'txtVente
        '
        Me.txtVente.Location = New System.Drawing.Point(98, 18)
        Me.txtVente.Name = "txtVente"
        Me.txtVente.Size = New System.Drawing.Size(45, 20)
        Me.txtVente.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "النسبة"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(949, 305)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des produits"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQnt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RechNom As System.Windows.Forms.RadioButton
    Friend WithEvents RechQnt As System.Windows.Forms.RadioButton
    Friend WithEvents RechPrix As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVente As System.Windows.Forms.TextBox
    Friend WithEvents txtPourcen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
