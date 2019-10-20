<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.isdt = New System.Windows.Forms.Label
        Me.dudt = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Det2 = New Library_Management_System.det
        Me.Det1 = New Library_Management_System.det
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 409)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(555, 409)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'isdt
        '
        Me.isdt.AutoSize = True
        Me.isdt.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isdt.Location = New System.Drawing.Point(12, 412)
        Me.isdt.Name = "isdt"
        Me.isdt.Size = New System.Drawing.Size(85, 18)
        Me.isdt.TabIndex = 6
        Me.isdt.Text = "Issue Date"
        '
        'dudt
        '
        Me.dudt.AutoSize = True
        Me.dudt.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudt.Location = New System.Drawing.Point(441, 412)
        Me.dudt.Name = "dudt"
        Me.dudt.Size = New System.Drawing.Size(74, 18)
        Me.dudt.TabIndex = 7
        Me.dudt.Text = "Due Date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(389, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 60)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Issue Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Det2
        '
        Me.Det2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Det2.BackColor = System.Drawing.Color.White
        Me.Det2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Det2.Location = New System.Drawing.Point(528, 0)
        Me.Det2.Name = "Det2"
        Me.Det2.Size = New System.Drawing.Size(397, 379)
        Me.Det2.TabIndex = 5
        '
        'Det1
        '
        Me.Det1.BackColor = System.Drawing.Color.White
        Me.Det1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Det1.Location = New System.Drawing.Point(1, 0)
        Me.Det1.Name = "Det1"
        Me.Det1.Size = New System.Drawing.Size(419, 366)
        Me.Det1.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dudt)
        Me.Controls.Add(Me.isdt)
        Me.Controls.Add(Me.Det2)
        Me.Controls.Add(Me.Det1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form2"
        Me.Text = "Issue Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Det1 As Library_Management_System.det
    Friend WithEvents Det2 As Library_Management_System.det
    Friend WithEvents isdt As System.Windows.Forms.Label
    Friend WithEvents dudt As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
