Public Class frm_gestion
    Private Sub btm_ajouter_Click(sender As Object, e As EventArgs) Handles btm_ajouter.Click
        If txt_quantite.Text = "" Then
            MsgBox("remplir le quantite")



        Else

            If txt_quantite.Text < 0 Then
                MsgBox("quantite doit etre nombre positive")
            Else
                If lst_produit.SelectedItem = "" Then
                    MsgBox("remplir le produit")
                Else

                    Dim i As Integer
                    i = txt_prixunitaire.Text * txt_quantite.Text
                    txt_montantht.Text = i
                    lst_affichequantite.Items.Add(txt_quantite.Text)
                    lst_afficheproduit.Items.Add(lst_produit.SelectedItem)
                    lst_afficheprixunitaire.Items.Add(txt_prixunitaire.Text)
                    lst_affichemontantht.Items.Add(i)
                End If
            End If
        End If
        txt_prixunitaire.Clear()
        txt_montantht.Clear()
        txt_quantite.Clear()

    End Sub
    Private Sub btm_calculer_Click(sender As Object, e As EventArgs) Handles btm_calculer.Click

        Dim S_mht As Integer = 0
        For Each item As Object In lst_affichemontantht.Items
            S_mht += CSng(item)
        Next
        txt_totalmontantht.Text = S_mht

        Dim S_mht1 As Integer = 0
        For Each item1 As Object In lst_affichequantite.Items
            S_mht1 += CSng(item1)
        Next
        txt_totalquantite.Text = S_mht1

        Dim S_mht2 As Integer = 0
        For Each item2 As Object In lst_afficheprixunitaire.Items
            S_mht2 += CSng(item2)
        Next
        txt_totalprixunitaire.Text = S_mht2

        Dim tva As Integer = 0
        tva = txt_totalmontantht.Text * 20 / 100
        txt_tva.Text = tva

        If txt_totalmontantht.Text > 1000 Then
            Dim remise As Integer = 0
            remise = txt_totalmontantht.Text * 1 / 100
            txt_remise.Text = remise
        Else
            txt_remise.Text = ""

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btm_vider2.Click

        lst_affichemontantht.Items.Clear()
        lst_afficheprixunitaire.Items.Clear()
        lst_afficheproduit.Items.Clear()
        lst_affichequantite.Items.Clear()
        txt_remise.Text = ""
        txt_tva.Text = ""
        txt_totalmontantht.Text = ""
        txt_totalprixunitaire.Text = ""
        txt_totalquantite.Text = ""



    End Sub

    Private Sub lst_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_produit.SelectedIndexChanged
        If lst_produit.SelectedIndex = -1 Then
            MsgBox("erreur")
        ElseIf (lst_produit.SelectedIndex = 0) Then
            txt_prixunitaire.Text = 30
        ElseIf (lst_produit.SelectedIndex = 1) Then
            txt_prixunitaire.Text = 15
        ElseIf (lst_produit.SelectedIndex = 2) Then
            txt_prixunitaire.Text = 500
        Else
            txt_prixunitaire.Text = 1000
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btm_vider.Click
        txt_prixunitaire.Text = ""
        txt_quantite.Text = ""
        txt_montantht.Text = ""
    End Sub

    Private Sub btm_modifier_Click(sender As Object, e As EventArgs) Handles btm_modifier.Click
        If lst_affichequantite.SelectedIndex = -1 Then
            MsgBox("choisissez la quantité que vous souhaite modifier")
        Else

            lst_affichequantite.Items(lst_affichequantite.SelectedIndex) = txt_modifier.Text.Trim
            lst_affichemontantht.Items(lst_affichequantite.SelectedIndex) =
                lst_afficheprixunitaire.Items(lst_affichequantite.SelectedIndex) * lst_affichequantite.Items(lst_affichequantite.SelectedIndex)
        End If



    End Sub

    Private Sub lst_affichequantite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_affichequantite.SelectedIndexChanged
        txt_modifier.Text = lst_affichequantite.GetItemText(lst_affichequantite.SelectedItem)
    End Sub

    Private Sub btm_supprimer_Click(sender As Object, e As EventArgs) Handles btm_supprimer.Click
        If lst_affichequantite.SelectedIndex = -1 And lst_afficheproduit.SelectedIndex = -1 And
            lst_afficheprixunitaire.SelectedIndex = -1 And
           lst_affichemontantht.SelectedIndex = -1 Then
            MsgBox("Que veut-tu supprimer? ")
        Else

            lst_affichequantite.Items.Remove(lst_affichequantite.SelectedItem)
            lst_affichemontantht.Items.Remove(lst_affichemontantht.SelectedItem)
            lst_afficheprixunitaire.Items.Remove(lst_afficheprixunitaire.SelectedItem)
            lst_afficheproduit.Items.Remove(lst_afficheproduit.SelectedItem)
        End If
    End Sub

    Private Sub txt_quantite_TextChanged(sender As Object, e As EventArgs) Handles txt_quantite.TextChanged

    End Sub

    Private Sub txt_prixunitaire_TextChanged(sender As Object, e As EventArgs) Handles txt_prixunitaire.TextChanged

    End Sub
End Class