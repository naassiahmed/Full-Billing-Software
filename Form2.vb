Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Dim ConStr As String = "Provider=Microsoft.Jet.Oledb.4.0;Data Source= " & Application.StartupPath & "\BDD.mdb"
    Dim Conn As New OleDbConnection(ConStr)
    Dim DataSet1 As New DataSet
    Dim dt As New DataTable
    Dim SQLstr As String = "select * from Client"
    Dim DataAdapter1 As New OleDbDataAdapter(SQLstr, Conn)

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "عدد المسجلين : " + dt.Rows.Count.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtNom.Text = ""
        txtAdresse.Text = ""
        txtNote.Text = ""
        txtWilaya.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        txtNom.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(txtNom.Text) = "" Or Trim(txtWilaya.Text) = "" Or Trim(txtAdresse.Text) = "" Then
            MsgBox("الرجاء إدخال كل البيانات ", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRtlReading, "")
            Exit Sub
        End If
       
        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text
            SavInto.CommandText = "insert into Client(Nom,Adresse,Wilaya,Remarque) values('" & Trim(txtNom.Text) & "','" & Trim(txtAdresse.Text) & "','" & Trim(txtWilaya.Text) & "','" & Trim(txtNote.Text) & "')"
            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("تمت إضافة عميل جديد", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading, "")
            RefreshDataGrid()
        Catch ex As Exception

            MsgBox("خطأ خلال عملية الإضافة", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRtlReading)

        End Try

    End Sub
    Sub RefreshDataGrid()
        dt.Clear()
        DataAdapter1.Fill(dt)
        DataGridView1.DataSource = dt
        Count.Text = "عدد المسجلين : " + dt.Rows.Count.ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim aa
            aa = MsgBox("هل تريد فعلا حذف هذا المنتوج؟", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo, "")
            If aa = vbYes Then


                Dim SavInto As New OleDb.OleDbCommand
                SavInto.Connection = Conn
                SavInto.CommandType = CommandType.Text

                SavInto.CommandText = "delete  from Client where N°=" & Val(txtNumero.Text) & ""
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim SavInto As New OleDb.OleDbCommand
            SavInto.Connection = Conn
            SavInto.CommandType = CommandType.Text

            SavInto.CommandText = "update Client set Nom='" & Trim(txtNom.Text) & "',Adresse='" & Trim(txtAdresse.Text) & "',Wilaya='" & Trim(txtWilaya.Text) & "',Remarque='" & Trim(txtNote.Text) & "'  where N°=" & Val(txtNumero.Text)

            Conn.Open()
            SavInto.ExecuteNonQuery()
            Conn.Close()

            MsgBox("تم تعديل 1 منتوج", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading)
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
        txtNom.Text = DataGridView1.Item(1, aa).Value
        txtAdresse.Text = DataGridView1.Item(2, aa).Value
        txtWilaya.Text = DataGridView1.Item(3, aa).Value
        txtNote.Text = DataGridView1.Item(4, aa).Value

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try




            Dim A As String
            A = InputBox("أدخل قيمة للبحث ", "")
            dt.Clear()
            If RechNom.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Client where Nom like '%" & Trim(A) & "%'", Conn)
            End If
            If RechPrix.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Client where Wilaya like '%" & Trim(A) & "%'", Conn)
            End If
            If RechQnt.Checked = True Then
                DataAdapter1 = New OleDbDataAdapter("select * from Client where Adresse like '%" & Trim(A) & "%'", Conn)
            End If
            DataAdapter1.Fill(dt)
            DataGridView1.DataSource = dt
            Count.Text = "عدد المسجلين : " + dt.Rows.Count.ToString

        Catch ex As Exception
            MsgBox("erreur")
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form3.Nom.Text = txtNom.Text
        Form3.Adresse.Text = txtAdresse.Text
        Form3.Wilaya.Text = txtWilaya.Text
        Form3.txtNumroClient.Text = txtNumero.Text
        Form3.txtNom.Text = txtNom.Text
        Form3.Show()
    End Sub
End Class