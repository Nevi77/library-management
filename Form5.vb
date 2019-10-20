Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim ds As New DataTable
    Dim ddt As New OleDbDataAdapter
    Dim dmt As New OleDbDataAdapter
    Dim i As Integer = 0
    Sub dis()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
        con.Open()
        ddt = New Data.OleDb.OleDbDataAdapter("select * from std", con)
        dt = New DataTable
        ddt.Fill(dt)
    End Sub
    Sub control()
        Try
            TextBox1.Text = dt.Rows(i)(0)
            TextBox2.Text = dt.Rows(i)(1)
            ComboBox1.Text = dt.Rows(i)(2)
            TextBox4.Text = dt.Rows(i)(3)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub clr()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dis()
        TextBox5.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd1 As New OleDbCommand
            cmd1.Connection = con
            If Label1.Text = "Add New User" Then
                cmd1.CommandText = "INSERT INTO std VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            Else
                cmd1.CommandText = "INSERT INTO books VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "')"
            End If
            cmd1.ExecuteNonQuery()
            dis()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If Label1.Text = "Add New User" Then
            MessageBox.Show("User Created", "Create New User")
        Else
            TextBox3.Text = "Book Added"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Label1.Text = "Update User" Then
                Dim cmd1 As New OleDbCommand("update std set snam=@p1,dept=@p2,yr=@p3,emal=@p4 where sid= @sid", con)
                cmd1.Parameters.AddWithValue("@p1", TextBox2.Text)
                cmd1.Parameters.AddWithValue("@p2", ComboBox1.Text)
                cmd1.Parameters.AddWithValue("@p3", TextBox4.Text)
                cmd1.Parameters.AddWithValue("@p4", TextBox3.Text)
                cmd1.Parameters.AddWithValue("@bid", TextBox1.Text)
                cmd1.ExecuteNonQuery()
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Label2.Text = "User Name" Then
            Dim t1 As String
            Dim i1 As Integer
            t1 = Trim(TextBox1.Text)
            i1 = t1.Length
            If i1 = 7 Then
                Dim con As New OleDbConnection
                Dim cmd As New OleDbCommand
                Dim ddt As New OleDbDataAdapter
                Dim dtd As New DataSet
                Dim i As Integer
                con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
                cmd.CommandText = "SELECT * from std where sid='" & TextBox1.Text & "' "
                cmd.Connection = con
                ddt.SelectCommand = cmd
                ddt.Fill(dtd, "0")
                Dim cnt = dtd.Tables(0).Rows.Count
                If cnt > 0 Then
                    TextBox1.Text = dtd.Tables(0).Rows(i)(0)
                    TextBox2.Text = dtd.Tables(0).Rows(i)(1)
                    ComboBox1.Text = dtd.Tables(0).Rows(i)(2)
                    TextBox4.Text = dtd.Tables(0).Rows(i)(4).ToString
                    TextBox3.Text = dtd.Tables(0).Rows(i)(3).ToString
                End If
            End If
        End If
        If Label2.Text = "Book Name" Then
            Dim t1 As String
            Dim i1 As Integer
            t1 = Trim(TextBox1.Text)
            i1 = t1.Length
            If i1 = 5 Then
                Dim con As New OleDbConnection
                Dim cmd As New OleDbCommand
                Dim ddt As New OleDbDataAdapter
                Dim dtd As New DataSet
                Dim i As Integer
                con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
                cmd.CommandText = "SELECT * from books where bid='" & TextBox1.Text & "' "
                cmd.Connection = con
                ddt.SelectCommand = cmd
                ddt.Fill(dtd, "0")
                Dim cnt = dtd.Tables(0).Rows.Count
                If cnt > 0 Then
                    TextBox1.Text = dtd.Tables(0).Rows(i)(0)
                    TextBox2.Text = dtd.Tables(0).Rows(i)(1)
                    TextBox5.Text = dtd.Tables(0).Rows(i)(2).ToString
                    TextBox4.Text = dtd.Tables(0).Rows(i)(3).ToString
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim cmd1 As New OleDbCommand
            cmd1.Connection = con
            If Label2.Text = "Book Name" Then
                cmd1.CommandText = "delete from books where bid='" & TextBox1.Text & "'"
            Else
                cmd1.CommandText = "delete from std where sid='" & TextBox1.Text & "'"
            End If
            cmd1.ExecuteNonQuery()
            dis()
        Catch ex As Exception
            TextBox5.Text = ex.ToString
        End Try
        If Label2.Text = "Book Name" Then
            MessageBox.Show("Book is removed from Library", "Remove Book", MessageBoxButtons.OK)
        Else
            MessageBox.Show("User is removed from Library", "Remove User", MessageBoxButtons.OK)
        End If
    End Sub
End Class