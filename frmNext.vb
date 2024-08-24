Public Class frmNext
    Dim f1 As New frmTheFirst()
    Public Sub New(ByVal FrmTheFirst As frmTheFirst)

        ' This call is required by the designer.
        InitializeComponent()
        f1 = FrmTheFirst
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Function GetGender(f As frmTheFirst) As String
        If f.rdbm.Checked Then
            Return "Male"
        ElseIf f.rdbf.Checked Then
            Return "Female"
        Else
            Return "No Selected Gender!!"
        End If
    End Function

    Private Function GetSubject(l As frmTheFirst) As String
        Dim subject As String = ""
        If l.CheckBox1.Checked Then
            subject &= "English, " ' Add comma and space for separation
        End If
        If l.CheckBox2.Checked Then
            subject &= "PE, "
        End If
        If l.CheckBox3.Checked Then
            subject &= "MATH, "
        End If
        If l.CheckBox4.Checked Then
            subject &= "ALGO" ' No comma needed after the last subject
        End If

        ' Remove the trailing comma and space if any subjects were selected
        If subject.Length > 0 Then
            subject = subject.Substring(0, subject.Length - 2) ' Remove last comma and space
        End If

        Return subject

    End Function

    Public Sub frmNext_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldisplay.Text = "Your name: " + f1.txtstudname.Text + vbCrLf + " Your course: " + f1.txtstudcourse.Text + vbCrLf +
            " Your gender: " + GetGender(f1) + vbCrLf + "Your Subject: " + GetSubject(f1)

    End Sub

    Private Sub lbldisplay_Click(sender As Object, e As EventArgs) Handles lbldisplay.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class