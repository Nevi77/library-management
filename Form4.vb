Imports System.Data.OleDb
Public Class Form4
    Dim con As OleDbConnection
    Dim dAdapt As OleDbDataAdapter
    Dim dSet As DataSet
    Dim a As Integer = 0
    Dim dBind As New BindingSource

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Book ID" Then
            Label2.Text = "Book ID"
            Dim con As New OleDbConnection
            Dim ddt As New OleDbDataAdapter
            Dim dat As New DataSet
            Dim i As Integer = 0
            Dim cmd As New OleDbCommand
            con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\library.mdb")
            cmd.CommandText = "SELECT * from issue where bid='" & TextBox1.Text & "'"
            con.Open()
            cmd.Connection = con
            ddt.SelectCommand = cmd
            ddt.Fill(dat, "issue")
            Dim dv As New DataView(dat.Tables("issue"))
            dv.RowFilter = "bid = " & "'" & TextBox1.Text & "'"
            DataGridView1.DataSource = dv
        ElseIf ComboBox1.Text = "Student/Staff ID" Then
            Label2.Text = "Student/Staff ID"
            Dim con As New OleDbConnection
            Dim ddt As New OleDbDataAdapter
            Dim dat As New DataSet
            Dim i As Integer = 0
            Dim cmd1 As New OleDbCommand
            con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\library.mdb")
            cmd1.CommandText = "SELECT * from issue where sid='" & TextBox1.Text & "'"
            con.Open()
            cmd1.Connection = con
            ddt.SelectCommand = cmd1
            ddt.Fill(dat, "issue")
            Dim dv As New DataView(dat.Tables("issue"))
            dv.RowFilter = "sid = " & "'" & TextBox1.Text & "'"
            DataGridView1.DataSource = dv
        End If
        If ComboBox1.SelectedText = "Student/Staff ID" Then
            Label2.Text = "Student/Staff ID"
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.Text = "Book ID" Then
            Label2.Text = "Book ID"
        Else
            Label2.Text = "Student/Staff ID"
        End If

    End Sub
End Class