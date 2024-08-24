Public Class frmTheFirst
    Dim gender As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblstudname.Click

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim f1 As New frmNext(Me)
        f1.ShowDialog()
    End Sub

    Private Sub txtstudname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstudname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtstudcourse.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdbm_CheckedChanged(sender As Object, e As EventArgs) Handles rdbm.CheckedChanged

    End Sub

    Public Sub rdbm_Click(sender As Object, e As EventArgs) Handles rdbm.Click
        gender = "Male"
    End Sub

    Public Sub rdbf_Click(sender As Object, e As EventArgs) Handles rdbf.Click
        gender = "Female"
    End Sub

    Private Sub frmTheFirst_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
