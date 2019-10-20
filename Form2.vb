Imports System.Data.OleDb
Public Class Form2
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim ds As New DataTable
    Dim ddt As New OleDbDataAdapter
    Dim dmt As New OleDbDataAdapter
    Sub dis()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
        con.Open()
        ddt = New Data.OleDb.OleDbDataAdapter("select * from issue", con)
        dt = New DataTable
        ddt.Fill(dt)
    End Sub
    Sub dis1()
        Det1.TextBox1.Enabled = False
        Det1.TextBox2.Enabled = False
        Det1.TextBox3.Enabled = False
        Det1.TextBox4.Enabled = False
        Det2.TextBox1.Enabled = False
        Det2.TextBox2.Enabled = False
        Det2.TextBox3.Enabled = False
        Det2.TextBox4.Enabled = False
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Det2.Label1.Text = "Book Details:"
        Det2.RadioButton1.Visible = False
        Det2.RadioButton2.Visible = False
        Det2.id.Text = "Book ID"
        Det2.Nam.Text = "Book Name"
        Det2.yr.Text = "Book Author"
        Det2.dept.Text = "Publisher"
        DateTimePicker2.Enabled = False
        dis()
        dis1()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd1 As New OleDbCommand
            cmd1.Connection = con
            cmd1.CommandText = "INSERT INTO issue VALUES('" & Det2.TextBox1.Text & "','" & Det2.TextBox2.Text & "','" & Det2.TextBox3.Text & "','" & Det2.TextBox4.Text & "','" & Det1.TextBox1.Text & "','" & Det1.TextBox2.Text & "','" & DateTimePicker1.Text & "', '" & DateTimePicker2.Text & "' )"
            cmd1.ExecuteNonQuery()
            dis()
            MsgBox("Book Issued to " & Det1.TextBox2.Text & " and must be returned on or before " & DateTimePicker2.Text, MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Book Already Issued")
        End Try

    End Sub
    Sub fcs()
        If Det2.TextBox2.Text <> "" Then
            Button1.Focus()
        End If

    End Sub
End Class