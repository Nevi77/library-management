Imports System.Drawing.Drawing2D
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitProgramToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Form5.Show()
        Form5.Label1.Text = "Add New User"
        Form5.Button1.Text = "Add User"
        Form5.ComboBox1.Visible = True
        Form5.TextBox5.Visible = False
        Form5.Text = "Add New User"
        Form5.Button2.Visible = False
        Form5.Button3.Visible = False
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Form5.Show()
        Form5.Text = "Add New Book"
        Form5.Label1.Text = "Add New Book"
        Form5.Button1.Text = "Add Book"
        Form5.Label2.Text = "Book Name"
        Form5.Label3.Text = "Book ID"
        Form5.Label4.Text = "Book Author"
        Form5.Label5.Text = "Book Publisher"
        Form5.Label6.Text = "Status"
        Form5.TextBox3.Enabled = False
        Form5.ComboBox1.Visible = False
        Form5.TextBox5.Visible = True
        Form5.Button2.Visible = False
        Form5.Button3.Visible = False
    End Sub

    Private Sub UpdateUserStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUserStatusToolStripMenuItem.Click
        Form5.Show()
        Form5.Text = "Update User"
        Form5.Label1.Text = "Update User"
        Form5.Button2.Text = "Update"
        Form5.Button1.Visible = False
        Form5.Button3.Visible = False
        Form5.Label2.Text = "User Name"
        Form5.Label3.Text = "User ID"
        Form5.Label4.Text = "Department"
        Form5.Label5.Text = "Year"
    End Sub

    Private Sub UpdateBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBookToolStripMenuItem.Click
        Form5.Show()
        Form5.TextBox5.Visible = True
        Form5.Text = "Update Book"
        Form5.Label1.Text = "Update Book"
        Form5.ComboBox1.Visible = False
        Form5.Label2.Text = "Book Name"
        Form5.Label3.Text = "Book ID"
        Form5.Label4.Text = "Book Author"
        Form5.Label5.Text = "Publisher"
        Form5.Label6.Visible = False
        Form5.TextBox3.Visible = False
        Form5.TextBox1.Focus()
        Form5.Button2.Text = "Update Book"
        Form5.Button1.Visible = False
        Form5.Button3.Visible = False
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Form5.Show()
        Form5.Text = "Delete User"
        Form5.TextBox5.Visible = False
        Form5.Label1.Text = "Delete User"
        Form5.ComboBox1.Visible = True
        Form5.Label2.Text = "User Name"
        Form5.Label3.Text = "User ID"
        Form5.Label4.Text = "Department"
        Form5.Label5.Text = "Email"
        Form5.Label6.Visible = False
        Form5.TextBox3.Visible = False
        Form5.TextBox1.Focus()
        Form5.Button3.Text = "Delete User"
        Form5.Button1.Visible = False
        Form5.Button2.Visible = False
    End Sub

    Private Sub DeleteBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBookToolStripMenuItem.Click
        Form5.Show()
        Form5.Text = "Delete Book"
        Form5.TextBox5.Visible = True
        Form5.Label1.Text = "Delete Book"
        Form5.ComboBox1.Visible = False
        Form5.Label2.Text = "Book Name"
        Form5.Label3.Text = "Book ID"
        Form5.Label4.Text = "Author"
        Form5.Label5.Text = "Publsiher"
        Form5.Label6.Visible = False
        Form5.TextBox3.Visible = False
        Form5.TextBox1.Focus()
        Form5.Button3.Text = "Delete User"
        Form5.Button1.Visible = False
        Form5.Button2.Visible = False
    End Sub

    Private Sub ShutDownComputerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDownComputerToolStripMenuItem.Click
        If MessageBox.Show("Are you sure to Shutdown Computer?", "ShutDown Computer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            Dim t As Single
            Dim objWMIService, objComputer As Object
            'Now get some privileges
            objWMIService = GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}")

            For Each objComputer In objWMIService.InstancesOf("Win32_OperatingSystem")
                t = objComputer.Win32Shutdown(2 + 4, 0)
                If t <> 0 Then
                    MsgBox("Error occurred!!!")
                Else
                    'LogOff your system
                End If
            Next
        Else
            MsgBox("Computer will not Turn Off Now")
        End If

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Form6.Show()
        Form6.Text = "About"
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now
    End Sub
End Class
