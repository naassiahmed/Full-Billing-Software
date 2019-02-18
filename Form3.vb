Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\BDD.mdb"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    'Dim SQLstr As String = "select * from Facture where NumeroClient=" & Val(txtNumroClient.Text)
    Dim SQLstr As String = "select * from Facture "
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)
    Dim DataAdapter2 As New OleDbDataAdapter(SQLstr, Conn)
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataAdapter1 = New OleDbDataAdapter("select * from Facture where NumeroClient=" & Val(txtNumroClient.Text), Conn)
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "Nombre de Factures " + dt.Rows.Count.ToString
        dt1.Clear()
        DataAdapter2 = New OleDbDataAdapter("select * from Facture where  txtYear=" & Now.Date.Year, Conn)
        DataAdapter2.Fill(dt1)
        txtNumero.Text = (dt1.Rows.Count + 1).ToString & "/" & Now.Year
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form4.Nom.Text = Nom.Text
        Form4.Adresse.Text = Adresse.Text
        Form4.Wilaya.Text = Wilaya.Text
        Form4.NRC.Text = txtNR.Text
        Form4.NCF.Text = txtCF.Text
        Form4.NIS.Text = txtNIS.Text
        Form4.NC.Text = txtC.Text
        Form4.DateBL.Text = txtDate.Value.Date
        Form4.NumeroBL.Text = txtNumeroBL.Text
        Form4.NumeroFactureRapport.Text = txtNumero.Text
        Form4.TypeFacture.Text = txtTypeF.Text
        Form4.txtNumero.Text = txtNumeroFacture.Text
        Form4.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dt1.Clear()
        DataAdapter2 = New OleDbDataAdapter("select * from Facture where  txtYear=" & Now.Date.Year, Conn)
        DataAdapter2.Fill(dt1)
        txtNumero.Text = (dt1.Rows.Count + 1).ToString & "/" & Now.Year

        txtCF.Text = ""
        txtDate.Text = Now
        txtNIS.Text = ""
        txtNumeroBL.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        txtNom.Focus()
        txtNR.Focus()
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(txtC.Text) = "" Or Trim(txtCF.Text) = "" Or Trim(txtNIS.Text) = "" Or Trim(txtNR.Text) = "" Or Trim(txtNumero.Text) = "" Then
            MsgBox("Veuillez saisir les informations nécessaires ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Facture(NumeroFacture,NumeroClient,TypeFacture,NRC,NCF,NIS,DateF,NumeroBL,txtYear) values('" & Trim(txtNumero.Text) & "'," & Val(txtNumroClient.Text) & ",'" & Trim(txtTypeF.Text) & "','" & Trim(txtNR.Text) & "','" & Trim(txtCF.Text) & "','" & Trim(txtNIS.Text) & "','" & txtDate.Value.Date & "','" & Trim(txtNumeroBL.Text) & "'," & Now.Date.Year & ")"
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
        Count.Text = "Nombre de Factures " + dt.Rows.Count.ToString
        dt1.Clear()
        DataAdapter2 = New OleDbDataAdapter("select * from Facture where  txtYear=" & Now.Date.Year, Conn)
        DataAdapter2.Fill(dt1)
        txtNumero.Text = (dt1.Rows.Count + 1).ToString & "/" & Now.Year
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Facture set NumeroFacture='" & Trim(txtNumero.Text) & "',TypeFacture='" & Trim(txtTypeF.Text) & "',NRC='" & Trim(txtNR.Text) & "',NCF='" & Trim(txtCF.Text) & "',NIS='" & Trim(txtNIS.Text) & "',DateF='" & txtDate.Value.Date & "',NumeroBL='" & Trim(txtNumeroBL.Text) & "',NC='" & Trim(txtC.Text) & "'  where N°=" & Val(txtNumeroFacture.Text)

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("تم تعديل 1 منتوج", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading)
            Call RefreshDataGrid()
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim aa
            aa = MsgBox("Voulez-vous vraiment supprimer cette facture ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete  from Facture where N°=" & Val(txtNumeroFacture.Text) & ""
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        Dim aa
        Button3.Enabled = True
        Button4.Enabled = True

        Button2.Enabled = False

        aa = (DataGridView1.CurrentCell.RowIndex)
        txtNumeroFacture.Text = DataGridView1.Item(0, aa).Value
        txtNumroClient.Text = DataGridView1.Item(2, aa).Value

        txtC.Text = DataGridView1.Item(3, aa).Value


        txtTypeF.Text = DataGridView1.Item(4, aa).Value

        txtNR.Text = DataGridView1.Item(5, aa).Value
        txtCF.Text = DataGridView1.Item(6, aa).Value
        txtNIS.Text = DataGridView1.Item(7, aa).Value
        txtDate.Text = DataGridView1.Item(8, aa).Value
        txtNumeroBL.Text = DataGridView1.Item(9, aa).Value
        txtNumero.Text = DataGridView1.Item(1, aa).Value
        txtNom.Text = txtNumroClient.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try




            Dim A As String
            A = InputBox("Veuillez introduire une valeur ", "")
            dt.Clear()
            If RechNumero.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Facture where NumeroFacture like '%" & Trim(A) & "%'", Conn)
            End If
            If RechTypeF.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Facture where TypeFacture like '%" & Trim(A) & "%'", Conn)
            End If
            If RechDate.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Facture where DateF like '%" & Trim(A) & "%'", Conn)
            End If
            If RechNumBL.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Facture where NumeroBL like '%" & Trim(A) & "%'", Conn)
            End If
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
            Count.Text = "Nombre de factures : " + dt.Rows.Count.ToString


        Catch ex As Exception
            MsgBox("erreur")
        End Try

    End Sub

    Private Sub txtNIS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNIS.GotFocus
        txtNIS.Text = txtCF.Text
    End Sub

    Private Sub txtNIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIS.TextChanged

    End Sub
End Class