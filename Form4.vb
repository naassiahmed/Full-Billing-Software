Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class Form4
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\BDD.mdb"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim SQLstr As String = "select * from ProduitFacture "
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter("select * from Produit", Conn)
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataAdapter1 = New OleDbDataAdapter("select * from ProduitFacture where NumeroFacture=" & Val(txtNumero.Text), Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        DataAdapter2.Fill(dt1)
        txtNom.DataSource = dt1
        txtNom.DisplayMember = "Désignation"

        Dim somme As Double = 0
        Dim sommeTVA As Double = 0
        Dim Total As Double = 0
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            somme += DataGridView1.Item(6, i).Value
        Next
        SousTotal.Text = (somme * Val(tva.Text)) / 100
        TotalTTC.Text = somme + sommeTVA
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Me.Close()
        Dim Param(11) As ReportParameter
        Param(0) = New ReportParameter("Nom", Nom.Text)
        Param(1) = New ReportParameter("Adresse", Adresse.Text)
        Param(2) = New ReportParameter("Wilaya", Wilaya.Text)
        Param(3) = New ReportParameter("NRC", "N°R.C : " & NRC.Text)
        Param(4) = New ReportParameter("NCF", "N°C.F : " & NCF.Text)
        Param(5) = New ReportParameter("NC", "N° Compte : " & NC.Text)
        Param(6) = New ReportParameter("NIS", "N.I.S : " & NIS.Text)
        Param(7) = New ReportParameter("NumeroFacture", "N° : " & NumeroFactureRapport.Text)
        Param(8) = New ReportParameter("TypeFacture", "BON DE LIVRAISON")
        Param(9) = New ReportParameter("DateBl", "")
        Param(10) = New ReportParameter("NumBl", "")
        Dim aa
        aa = MsgBox("Voulez-vous Imprimer la date ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If aa = vbYes Then

            Param(11) = New ReportParameter("DateFacture", "Djelfa Le : " & Now.Date)
        Else
            Param(11) = New ReportParameter("DateFacture", "Djelfa Le : ")
        End If

        Form7.ReportViewer1.LocalReport.SetParameters(Param)
        Form7.NumeroFacture.Text = txtNumero.Text

        Form7.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RefreshDataGrid()
        txtNom.Text = ""
        txtNoRdre.Text = DataGridView1.RowCount
        txtPrix.Text = ""
        txtQnt.Text = ""
        txtType.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        txtNom.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(txtNom.Text) = "" Or Trim(txtPrix.Text) = "" Or Trim(txtQnt.Text) = "" Or Trim(txtType.Text) = "" Then
            MsgBox("Veuillez saisir les informations nécessaires ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Not IsNumeric(txtQnt.Text) Then
            MsgBox("La quantité doit être de type numérique!", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If Not IsNumeric(txtPrix.Text) Then
            MsgBox("Le prix doit être de type numérique!", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into ProduitFacture(NumeroFacture,nOrdre,Designation,UM,Qnt,PrixU,Total) values(" & Val(txtNumero.Text) & "," & Val(txtNoRdre.Text) & ",'" & Trim(txtNom.Text) & "','" & Trim(txtType.Text) & "'," & Val(txtQnt.Text) & "," & Val(txtPrix.Text) & "," & Val(Val(txtPrix.Text) * Val(txtQnt.Text)) & ")"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Ajout réussi !", MsgBoxStyle.Information, "")
            RefreshDataGrid()
        Catch ex As Exception
            MsgBox("Erreur ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading)
        End Try

    End Sub
    Sub RefreshDataGrid()
        dt.Clear()
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Dim somme As Double = 0
        Dim sommeTVA As Double = 0
        Dim Total As Double = 0
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            somme += DataGridView1.Item(6, i).Value
        Next
        SousTotal.Text = (somme * Val(tva.Text)) / 100
        TotalTTC.Text = somme + sommeTVA
        TotalLettre.Text = EnTexte(Val(TotalTTC.Text)) & " D.A"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(txtNom.Text) = "" Or Trim(txtPrix.Text) = "" Or Trim(txtQnt.Text) = "" Or Trim(txtType.Text) = "" Then
            MsgBox("Veuillez saisir les informations nécessaires ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Not IsNumeric(txtQnt.Text) Then
            MsgBox("La quantité doit être de type numérique!", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If Not IsNumeric(txtPrix.Text) Then
            MsgBox("Le prix doit être de type numérique!", MsgBoxStyle.Critical, "")
            Exit Sub
        End If


        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text



            SavInto.CommandText = "update ProduitFacture set NumeroFacture=" & Val(txtNumero.Text) & ",UM='" & Trim(txtType.Text) & "',nOrdre=" & Val(txtNoRdre.Text) & ",Designation='" & Trim(txtNom.Text) & "',Qnt=" & Val(txtQnt.Text) & ",PrixU=" & Val(txtPrix.Text) & ",Total=" & Val(Val(txtPrix.Text) * Val(txtQnt.Text)) & "  where NumeroFacture=" & Val(TextBox1.Text)

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Modification réussie", MsgBoxStyle.Information)
            Call RefreshDataGrid()
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        Dim aa
        Button3.Enabled = True
        Button4.Enabled = True

        Button2.Enabled = False

        aa = (DataGridView1.CurrentCell.RowIndex)
        txtNumero.Text = DataGridView1.Item(0, aa).Value
        txtNoRdre.Text = DataGridView1.Item(1, aa).Value
        txtNom.Text = DataGridView1.Item(2, aa).Value
        txtType.Text = DataGridView1.Item(3, aa).Value
        txtQnt.Text = DataGridView1.Item(4, aa).Value
        txtPrix.Text = DataGridView1.Item(5, aa).Value
        TextBox1.Text = txtNumero.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim aa
            aa = MsgBox("Voulez-vous vraiment supprimer ce produit ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete  from ProduitFacture where NumeroFacture=" & Val(TextBox1.Text)
                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDataGrid()
                Button1_Click(sender, e)
                MsgBox("Suppression réussie", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try




            Dim A As String
            A = InputBox("Veuillez introduire une valeur ", "")
            dt.Clear()
            If RechNumero.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from ProduitFacture where NumeroFacture like '%" & Val(A) & "%'", Conn)
            End If
            If RechTypeF.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from ProduitFacture where UM like '%" & Trim(A) & "%'", Conn)
            End If

            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt



        Catch ex As Exception
            MsgBox("erreur", MsgBoxStyle.Critical, "")
        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If RadioButton1.Checked = True Then
            ' La somme totale
            Dim somme As Double = 0
            Dim sommeTVA As Double = 0
            Dim Total As Double = 0
            Dim i As Integer
            For i = 0 To DataGridView1.RowCount - 1
                somme += DataGridView1.Item(6, i).Value
            Next
            sommeTVA = (somme * 17) / 100
            Total = somme + sommeTVA
            'On Error Resume Next
            Dim Param(15) As ReportParameter
            Param(0) = New ReportParameter("Nom", Nom.Text)
            Param(1) = New ReportParameter("Adresse", Adresse.Text)
            Param(2) = New ReportParameter("Wilaya", Wilaya.Text)
            Param(3) = New ReportParameter("NRC", "N°R.C : " & NRC.Text)
            Param(4) = New ReportParameter("NCF", "N°C.F : " & NCF.Text)
            Param(5) = New ReportParameter("NC", "N° Compte : " & NC.Text)
            Param(6) = New ReportParameter("NIS", "N.I.S : " & NIS.Text)
            Param(7) = New ReportParameter("NumeroFacture", "N° : " & NumeroFactureRapport.Text)
            Param(8) = New ReportParameter("TypeFacture", TypeFacture.Text)
            If TypeFacture.Text.ToUpper = "FACTURE PROFORMAT" Then


                Param(9) = New ReportParameter("DateBl", "")
                Param(10) = New ReportParameter("NumBl", "")
            Else

                Param(9) = New ReportParameter("DateBl", "Date : " & DateBL.Text)
                Param(10) = New ReportParameter("NumBl", "BCN° : " & NumeroBL.Text)
            End If
            
            Param(11) = New ReportParameter("Total1", somme.ToString)
            Param(12) = New ReportParameter("Total2", sommeTVA.ToString)
            Param(13) = New ReportParameter("Total3", Total.ToString)
            Param(14) = New ReportParameter("TotalLettre", TotalLettre.Text)

            Dim aa
            aa = MsgBox("Voulez-vous Imprimer la date ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then

                Param(15) = New ReportParameter("DateFacture", "Djelfa Le : " & Now.Date)
            Else
                Param(15) = New ReportParameter("DateFacture", "Djelfa Le : ")
            End If


            Form5.ReportViewer1.LocalReport.SetParameters(Param)
            Form5.NumeroFacture.Text = txtNumero.Text

            Form5.Show()
        Else
            Button7_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class