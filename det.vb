Imports System.Data.OleDb
Public Class det
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim ddt As New OleDbDataAdapter
    Dim dmt As DataSet
    Dim i As Integer = 0
    Sub dis()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\library.mdb")
        con.Open()
        ddt = New Data.OleDb.OleDbDataAdapter("select * from books", con)
        'ds = New DataTable
        dt = New DataTable
        'dmt.Fill(ds)
        ddt.Fill(dt)
    End Sub
    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        TextBox1.Enabled = True
        Form2.Det2.TextBox1.Enabled = True
        Dim d1 As Date
        d1 = Form2.DateTimePicker1.Value
        id.Visible = True
        Nam.Visible = True
        yr.Visible = True
        dept.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        Form2.DateTimePicker2.Value = d1.AddDays(10)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        TextBox1.Enabled = True
        Form2.Det2.TextBox1.Enabled = True
        Dim d1 As Date
        d1 = Form2.DateTimePicker1.Value
        yr.Visible = False
        dept.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox1.Visible = True
        TextBox2.Visible = True
        id.Visible = True
        Nam.Visible = True
        Form2.DateTimePicker2.Value = d1.AddDays(20)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If id.Text = "ID. No." Then
            Dim t1 As String
            Dim i1 As Integer
            t1 = Trim(TextBox1.Text)
            i1 = t1.Length
            If i1 = 7 Then
                Call main()
            End If
        End If
        If id.Text = "Book ID" Then
            Dim t1 As String
            Dim i1 As Integer
            t1 = Trim(TextBox1.Text)
            i1 = t1.Length
            If i1 = 5 Then
                Call main()
            End If
        End If
    End Sub
    Sub main()
        If id.Text = "ID. No." Then
            Form2.DateTimePicker1.Value = Date.Now
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
                TextBox3.Text = dtd.Tables(0).Rows(i)(3).ToString
                TextBox4.Text = dtd.Tables(0).Rows(i)(2).ToString
            Else
                MsgBox("No book found")
            End If
        End If
        If id.Text = "Book ID" Then
            Form2.DateTimePicker1.Value = Date.Now
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
                TextBox3.Text = dtd.Tables(0).Rows(i)(2).ToString
                TextBox4.Text = dtd.Tables(0).Rows(i)(3).ToString
            End If
        End If

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Form2.Det2.TextBox1.Focus()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Call Form2.fcs()
    End Sub
End Class
