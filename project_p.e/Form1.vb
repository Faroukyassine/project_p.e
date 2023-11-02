Public Class frm_authentifier
    Private Sub init()
        txt_login.Clear()
        txt_pw.Clear()
    End Sub
    Private Sub btm_valider_Click(sender As Object, e As EventArgs) Handles btm_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_login.Text
        pw = txt_pw.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_gestion.show()
        Else
            init()
        End If

    End Sub
    Private Sub btm_annuler_Click(sender As Object, e As EventArgs) Handles btm_annuler.Click
        init()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_authentifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txt_pw_TextChanged(sender As Object, e As EventArgs) Handles txt_pw.TextChanged
        txt_pw.UseSystemPasswordChar = True
    End Sub
End Class


