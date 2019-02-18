Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\BDD.mdb"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim dt As New DataTable
    Dim SQLstr As String = "select * from Produit"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtNom.Text = ""
        txtPrix.Text = ""
        txtQnt.Text = ""
        txtPourcen.Text = ""
        txtVente.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        txtNom.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "عدد المنتوجات : " + dt.Rows.Count.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(txtNom.Text) = "" Or Trim(txtPrix.Text) = "" Or Trim(txtQnt.Text) = "" Then
            MsgBox("الرجاء إدخال كل البيانات ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "")
            Exit Sub
        End If
        If Not IsNumeric(txtPrix.Text) Then
            MsgBox("خطأ! الثمن غير صحيح ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "")
            txtPrix.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtQnt.Text) Then
            MsgBox("خطأ! الكمية غير صحيحة ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "")
            txtQnt.Focus()
            Exit Sub
        End If
        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Produit(Désignation,PrixU,Qnt,PrixVente,Pourcentage)" & " values('" & Trim(txtNom.Text) & "'," & Val(txtPrix.Text) & "," & Val(txtQnt.Text) & "," & Val(txtVente.Text) & ",'" & Trim(txtPourcen.Text) & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("تمت إضافة منتوج جديد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "")
            RefreshDataGrid()
        Catch ex As Exception

            MsgBox("خطأ خلال عملية الإضافة", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading)

        End Try


    End Sub
    Sub RefreshDataGrid()
        dt.Clear()
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "عدد المنتوجات : " + dt.Rows.Count.ToString
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        'On Error Resume Next
        Dim aa
        Button3.Enabled = True
        Button4.Enabled = True

        Button2.Enabled = False

        aa = (DataGridView1.CurrentCell.RowIndex)
        txtNumero.Text = DataGridView1.Item(0, aa).Value
        txtNom.Text = DataGridView1.Item(1, aa).Value
        txtPrix.Text = DataGridView1.Item(2, aa).Value
        txtQnt.Text = DataGridView1.Item(3, aa).Value
        txtVente.Text = DataGridView1.Item(4, aa).Value
        txtPourcen.Text = DataGridView1.Item(5, aa).Value

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Produit set Désignation='" & Trim(txtNom.Text) & "',PrixU=" & Val(txtPrix.Text) & ",Qnt=" & Val(txtQnt.Text) & ",PrixVente=" & Val(txtVente.Text) & ",Pourcentage='" & Trim(txtPourcen.Text) & "' where N°=" & Val(txtNumero.Text)

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
            aa = MsgBox("هل تريد فعلا حذف هذا المنتوج؟", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete  from Produit where N°=" & Val(txtNumero.Text) & ""
                Conn.Open()
                SavInto.ExecuteNonQuery()
                Conn.Close()
                Call RefreshDataGrid()
                Button1_Click(sender, e)
                MsgBox("تم الحذف بنجاح !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading)
            End If
        Catch ex As Exception

            MsgBox("Une erreur !", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try




            Dim A As String
            A = InputBox("أدخل قيمة للبحث ", "")
            dt.Clear()
            If RechNom.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Produit where Désignation like '%" & Trim(A) & "%'", Conn)
            End If
            If RechPrix.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Produit where PrixU like '%" & Val(A) & "%'", Conn)
            End If
            If RechQnt.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Produit where Qnt like '%" & Val(A) & "%'", Conn)
            End If
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
            Count.Text = "عدد المنتوجات : " + dt.Rows.Count.ToString

        Catch ex As Exception
            MsgBox("erreur")
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtPourcen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPourcen.GotFocus
        txtPourcen.Text = 100 - (Int(Val(txtVente.Text) * 100 / Val(txtPrix.Text)))

    End Sub

    Private Sub txtPourcen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPourcen.TextChanged

    End Sub
End Class
