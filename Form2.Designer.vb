<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAdresse = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtWilaya = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RechQnt = New System.Windows.Forms.RadioButton
        Me.RechPrix = New System.Windows.Forms.RadioButton
        Me.RechNom = New System.Windows.Forms.RadioButton
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Count = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNote)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtWilaya)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(302, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات العميل"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(33, 189)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(194, 68)
        Me.txtNote.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ملاحظات"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(33, 103)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(194, 68)
        Me.txtAdresse.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "العنوان"
        '
        'txtWilaya
        '
        Me.txtWilaya.Location = New System.Drawing.Point(33, 63)
        Me.txtWilaya.Name = "txtWilaya"
        Me.txtWilaya.Size = New System.Drawing.Size(194, 20)
        Me.txtWilaya.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الولاية"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(33, 23)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(194, 20)
        Me.txtNom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "إسم العميل"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(285, 288)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RechQnt)
        Me.GroupBox3.Controls.Add(Me.RechPrix)
        Me.GroupBox3.Controls.Add(Me.RechNom)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(245, 67)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "بحث عن"
        '
        'RechQnt
        '
        Me.RechQnt.AutoSize = True
        Me.RechQnt.Location = New System.Drawing.Point(86, 40)
        Me.RechQnt.Name = "RechQnt"
        Me.RechQnt.Size = New System.Drawing.Size(56, 17)
        Me.RechQnt.TabIndex = 2
        Me.RechQnt.TabStop = True
        Me.RechQnt.Text = "العنوان"
        Me.RechQnt.UseVisualStyleBackColor = True
        '
        'RechPrix
        '
        Me.RechPrix.AutoSize = True
        Me.RechPrix.Location = New System.Drawing.Point(32, 19)
        Me.RechPrix.Name = "RechPrix"
        Me.RechPrix.Size = New System.Drawing.Size(52, 17)
        Me.RechPrix.TabIndex = 1
        Me.RechPrix.TabStop = True
        Me.RechPrix.Text = "الولاية"
        Me.RechPrix.UseVisualStyleBackColor = True
        '
        'RechNom
        '
        Me.RechNom.AutoSize = True
        Me.RechNom.Checked = True
        Me.RechNom.Location = New System.Drawing.Point(149, 19)
        Me.RechNom.Name = "RechNom"
        Me.RechNom.Size = New System.Drawing.Size(81, 17)
        Me.RechNom.TabIndex = 0
        Me.RechNom.TabStop = True
        Me.RechNom.Text = "إسم العميل"
        Me.RechNom.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Fournisseur.My.Resources.Resources.Preview_48x48
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(71, 224)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 55)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "       بحث "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = Global.Fournisseur.My.Resources.Resources.Close1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(17, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 59)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "       حذف    "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Image = Global.Fournisseur.My.Resources.Resources.Edit1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(145, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 59)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "         تعديل     "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Fournisseur.My.Resources.Resources.Save_48x48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(17, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 59)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "         إضافة  "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Fournisseur.My.Resources.Resources.Paste
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(145, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 59)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "        جديد  "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(184, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(428, 146)
        Me.DataGridView1.TabIndex = 2
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(244, 456)
        Me.Count.Name = "Count"
        Me.Count.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Count.Size = New System.Drawing.Size(41, 13)
        Me.Count.TabIndex = 13
        Me.Count.Text = "الثمن :"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(294, 332)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(64, 20)
        Me.txtNumero.TabIndex = 14
        Me.txtNumero.Visible = False
        '
        'Button7
        '
        Me.Button7.Image = Global.Fournisseur.My.Resources.Resources.Log_Out_48x48
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.Location = New System.Drawing.Point(11, 395)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(166, 55)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "خروج        "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Fournisseur.My.Resources.Resources.Modify
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(12, 332)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(166, 55)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "الفاتورة        "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(634, 478)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des clients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWilaya As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RechQnt As System.Windows.Forms.RadioButton
    Friend WithEvents RechPrix As System.Windows.Forms.RadioButton
    Friend WithEvents RechNom As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
End Class
