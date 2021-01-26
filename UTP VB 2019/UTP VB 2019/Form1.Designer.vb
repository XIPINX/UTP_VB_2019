<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtiterasi = New System.Windows.Forms.TextBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnjalankan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(228, 139)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(314, 147)
        Me.ListBox1.TabIndex = 0
        '
        'txtiterasi
        '
        Me.txtiterasi.Location = New System.Drawing.Point(290, 106)
        Me.txtiterasi.Name = "txtiterasi"
        Me.txtiterasi.Size = New System.Drawing.Size(145, 20)
        Me.txtiterasi.TabIndex = 1
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(290, 76)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(145, 20)
        Me.txtjudul.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(225, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "JUDUL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(225, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ITERASI"
        '
        'btnjalankan
        '
        Me.btnjalankan.Location = New System.Drawing.Point(441, 76)
        Me.btnjalankan.Name = "btnjalankan"
        Me.btnjalankan.Size = New System.Drawing.Size(101, 50)
        Me.btnjalankan.TabIndex = 5
        Me.btnjalankan.Text = "JALANKAN"
        Me.btnjalankan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(290, 292)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(97, 28)
        Me.btnhapus.TabIndex = 6
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(441, 292)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(101, 28)
        Me.btnkeluar.TabIndex = 7
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(267, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 41)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ILMU KANURAGAN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnjalankan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.txtiterasi)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtiterasi As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnjalankan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents Label3 As Label
End Class
