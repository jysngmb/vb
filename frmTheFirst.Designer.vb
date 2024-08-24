<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTheFirst
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstudname = New System.Windows.Forms.Label()
        Me.lblstudcourse = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtstudcourse = New System.Windows.Forms.TextBox()
        Me.txtstudname = New System.Windows.Forms.TextBox()
        Me.rdbm = New System.Windows.Forms.RadioButton()
        Me.rdbf = New System.Windows.Forms.RadioButton()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MY GUI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'lblstudname
        '
        Me.lblstudname.AutoSize = True
        Me.lblstudname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudname.Location = New System.Drawing.Point(13, 72)
        Me.lblstudname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstudname.Name = "lblstudname"
        Me.lblstudname.Size = New System.Drawing.Size(101, 20)
        Me.lblstudname.TabIndex = 2
        Me.lblstudname.Text = "Student Name:"
        Me.lblstudname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblstudname.UseCompatibleTextRendering = True
        '
        'lblstudcourse
        '
        Me.lblstudcourse.AutoSize = True
        Me.lblstudcourse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudcourse.Location = New System.Drawing.Point(13, 115)
        Me.lblstudcourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstudcourse.Name = "lblstudcourse"
        Me.lblstudcourse.Size = New System.Drawing.Size(110, 20)
        Me.lblstudcourse.TabIndex = 3
        Me.lblstudcourse.Text = "Student Course:"
        Me.lblstudcourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblstudcourse.UseCompatibleTextRendering = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(143, 293)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 7
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtstudcourse
        '
        Me.txtstudcourse.Location = New System.Drawing.Point(143, 115)
        Me.txtstudcourse.Name = "txtstudcourse"
        Me.txtstudcourse.Size = New System.Drawing.Size(350, 22)
        Me.txtstudcourse.TabIndex = 8
        '
        'txtstudname
        '
        Me.txtstudname.Location = New System.Drawing.Point(143, 72)
        Me.txtstudname.Name = "txtstudname"
        Me.txtstudname.Size = New System.Drawing.Size(350, 22)
        Me.txtstudname.TabIndex = 9
        '
        'rdbm
        '
        Me.rdbm.AutoSize = True
        Me.rdbm.Location = New System.Drawing.Point(143, 154)
        Me.rdbm.Name = "rdbm"
        Me.rdbm.Size = New System.Drawing.Size(56, 20)
        Me.rdbm.TabIndex = 10
        Me.rdbm.TabStop = True
        Me.rdbm.Text = "Male"
        Me.rdbm.UseVisualStyleBackColor = True
        '
        'rdbf
        '
        Me.rdbf.AutoSize = True
        Me.rdbf.Location = New System.Drawing.Point(243, 154)
        Me.rdbf.Name = "rdbf"
        Me.rdbf.Size = New System.Drawing.Size(72, 20)
        Me.rdbf.TabIndex = 11
        Me.rdbf.TabStop = True
        Me.rdbf.Text = "Female"
        Me.rdbf.UseVisualStyleBackColor = True
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(13, 154)
        Me.lblgender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(58, 20)
        Me.lblgender.TabIndex = 12
        Me.lblgender.Text = "Gender:"
        Me.lblgender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblgender.UseCompatibleTextRendering = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(28, 190)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "English"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(105, 190)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(45, 20)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "PE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(182, 190)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(66, 20)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "MATH"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(259, 190)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(63, 20)
        Me.CheckBox4.TabIndex = 16
        Me.CheckBox4.Text = "ALGO"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'frmTheFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(543, 328)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.rdbf)
        Me.Controls.Add(Me.rdbm)
        Me.Controls.Add(Me.txtstudname)
        Me.Controls.Add(Me.txtstudcourse)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.lblstudcourse)
        Me.Controls.Add(Me.lblstudname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheFirst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My First Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblstudname As Label
    Friend WithEvents lblstudcourse As Label
    Friend WithEvents btnsubmit As Button
    Public WithEvents txtstudcourse As TextBox
    Public WithEvents txtstudname As TextBox
    Friend WithEvents lblgender As Label
    Public WithEvents rdbm As RadioButton
    Public WithEvents rdbf As RadioButton
    Public WithEvents CheckBox1 As CheckBox
    Public WithEvents CheckBox2 As CheckBox
    Public WithEvents CheckBox3 As CheckBox
    Public WithEvents CheckBox4 As CheckBox
End Class
