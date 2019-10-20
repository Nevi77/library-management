Imports System.Data.OleDb
Public Class Form3
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim ddt As New OleDbDataAdapter
    Dim dmt As DataSet
    Dim i As Integer = 0
    Sub dis()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
        con.Open()
        ddt = New Data.OleDb.OleDbDataAdapter("select * from books", con)
        dt = New DataTable
        ddt.Fill(dt)
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dis()
    End Sub
    Sub dis1()
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim ddt As New OleDbDataAdapter
        Dim dtd As New DataSet
        Dim i As Integer
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
        cmd.CommandText = "SELECT * from issue where bid='" & TextBox1.Text & "' "
        cmd.Connection = con
        ddt.SelectCommand = cmd
        ddt.Fill(dtd, "0")
        Dim cnt = dtd.Tables(0).Rows.Count
        If cnt > 0 Then
            TextBox1.Text = dtd.Tables(0).Rows(i)(0)
            TextBox2.Text = dtd.Tables(0).Rows(i)(1)
            TextBox3.Text = dtd.Tables(0).Rows(i)(2).ToString
            TextBox4.Text = dtd.Tables(0).Rows(i)(4).ToString
            TextBox5.Text = dtd.Tables(0).Rows(i)(5)
            DateTimePicker1.Text = dtd.Tables(0).Rows(i)(6).ToString
            DateTimePicker2.Text = dtd.Tables(0).Rows(i)(7).ToString
        End If
        Dim t1 As Date
        Dim t2 As Date
        Dim t3 As TimeSpan
        t1 = DateTimePicker2.Text
        t2 = DateTimePicker3.Text
        t3 = t2.Subtract(t1)
        TextBox6.Text = t3.Days * 2
        If TextBox6.Text < 0 Then
            TextBox6.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim com As New OleDbCommand
            com.Connection = con
            com.CommandText = "delete from issue where bid='" & TextBox1.Text & "'"
            com.ExecuteNonQuery()
            MsgBox("Book Returned")
            dis()
            clear()
        Catch exp As Exception
            MsgBox(exp.ToString())
        End Try
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DateTimePicker1.Value = Date.Now
        DateTimePicker2.Value = Date.Now
        DateTimePicker3.Value = Date.Now
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Button1.Focus()
    End Sub
End Class