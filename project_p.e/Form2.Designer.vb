<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gestion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_produit = New System.Windows.Forms.ComboBox()
        Me.btm_ajouter = New System.Windows.Forms.Button()
        Me.btm_vider2 = New System.Windows.Forms.Button()
        Me.btm_vider = New System.Windows.Forms.Button()
        Me.lst_afficheproduit = New System.Windows.Forms.ListBox()
        Me.lst_afficheprixunitaire = New System.Windows.Forms.ListBox()
        Me.lst_affichequantite = New System.Windows.Forms.ListBox()
        Me.lst_affichemontantht = New System.Windows.Forms.ListBox()
        Me.btm_calculer = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_prixunitaire = New System.Windows.Forms.TextBox()
        Me.txt_quantite = New System.Windows.Forms.TextBox()
        Me.txt_totalmontantht = New System.Windows.Forms.TextBox()
        Me.txt_montantht = New System.Windows.Forms.TextBox()
        Me.txt_totalquantite = New System.Windows.Forms.TextBox()
        Me.txt_totalprixunitaire = New System.Windows.Forms.TextBox()
        Me.txt_tva = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.btm_modifier = New System.Windows.Forms.Button()
        Me.txt_modifier = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btm_supprimer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix Unitaire :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantité :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Montant HT :"
        '
        'lst_produit
        '
        Me.lst_produit.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.Items.AddRange(New Object() {"clavier", "sourie", "impremante", "ordinatuer"})
        Me.lst_produit.Location = New System.Drawing.Point(176, 12)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(205, 30)
        Me.lst_produit.TabIndex = 4
        Me.lst_produit.Text = "choisir la marchandise"
        '
        'btm_ajouter
        '
        Me.btm_ajouter.Location = New System.Drawing.Point(445, 35)
        Me.btm_ajouter.Name = "btm_ajouter"
        Me.btm_ajouter.Size = New System.Drawing.Size(91, 44)
        Me.btm_ajouter.TabIndex = 8
        Me.btm_ajouter.Text = "Ajouter"
        Me.btm_ajouter.UseVisualStyleBackColor = True
        '
        'btm_vider2
        '
        Me.btm_vider2.Location = New System.Drawing.Point(906, 375)
        Me.btm_vider2.Name = "btm_vider2"
        Me.btm_vider2.Size = New System.Drawing.Size(91, 42)
        Me.btm_vider2.TabIndex = 9
        Me.btm_vider2.Text = "vider"
        Me.btm_vider2.UseVisualStyleBackColor = True
        '
        'btm_vider
        '
        Me.btm_vider.Location = New System.Drawing.Point(445, 103)
        Me.btm_vider.Name = "btm_vider"
        Me.btm_vider.Size = New System.Drawing.Size(91, 44)
        Me.btm_vider.TabIndex = 10
        Me.btm_vider.Text = "Vider"
        Me.btm_vider.UseVisualStyleBackColor = True
        '
        'lst_afficheproduit
        '
        Me.lst_afficheproduit.FormattingEnabled = True
        Me.lst_afficheproduit.ItemHeight = 16
        Me.lst_afficheproduit.Location = New System.Drawing.Point(230, 259)
        Me.lst_afficheproduit.Name = "lst_afficheproduit"
        Me.lst_afficheproduit.Size = New System.Drawing.Size(120, 212)
        Me.lst_afficheproduit.TabIndex = 11
        '
        'lst_afficheprixunitaire
        '
        Me.lst_afficheprixunitaire.FormattingEnabled = True
        Me.lst_afficheprixunitaire.ItemHeight = 16
        Me.lst_afficheprixunitaire.Location = New System.Drawing.Point(383, 259)
        Me.lst_afficheprixunitaire.Name = "lst_afficheprixunitaire"
        Me.lst_afficheprixunitaire.Size = New System.Drawing.Size(120, 212)
        Me.lst_afficheprixunitaire.TabIndex = 12
        '
        'lst_affichequantite
        '
        Me.lst_affichequantite.FormattingEnabled = True
        Me.lst_affichequantite.ItemHeight = 16
        Me.lst_affichequantite.Location = New System.Drawing.Point(539, 259)
        Me.lst_affichequantite.Name = "lst_affichequantite"
        Me.lst_affichequantite.Size = New System.Drawing.Size(120, 212)
        Me.lst_affichequantite.TabIndex = 13
        '
        'lst_affichemontantht
        '
        Me.lst_affichemontantht.FormattingEnabled = True
        Me.lst_affichemontantht.ItemHeight = 16
        Me.lst_affichemontantht.Location = New System.Drawing.Point(684, 259)
        Me.lst_affichemontantht.Name = "lst_affichemontantht"
        Me.lst_affichemontantht.Size = New System.Drawing.Size(120, 212)
        Me.lst_affichemontantht.TabIndex = 14
        '
        'btm_calculer
        '
        Me.btm_calculer.Location = New System.Drawing.Point(906, 259)
        Me.btm_calculer.Name = "btm_calculer"
        Me.btm_calculer.Size = New System.Drawing.Size(91, 42)
        Me.btm_calculer.TabIndex = 20
        Me.btm_calculer.Text = "Calculer"
        Me.btm_calculer.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(906, 439)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 42)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Quitter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Prix Unitaire"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(558, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Quantité"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(690, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Montant HT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 498)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 22)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Total :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(412, 590)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 22)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "TVA(20%):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(421, 654)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 22)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Remise :"
        '
        'txt_prixunitaire
        '
        Me.txt_prixunitaire.Location = New System.Drawing.Point(176, 57)
        Me.txt_prixunitaire.Name = "txt_prixunitaire"
        Me.txt_prixunitaire.ReadOnly = True
        Me.txt_prixunitaire.Size = New System.Drawing.Size(205, 22)
        Me.txt_prixunitaire.TabIndex = 29
        '
        'txt_quantite
        '
        Me.txt_quantite.Location = New System.Drawing.Point(176, 101)
        Me.txt_quantite.Name = "txt_quantite"
        Me.txt_quantite.Size = New System.Drawing.Size(205, 22)
        Me.txt_quantite.TabIndex = 30
        '
        'txt_totalmontantht
        '
        Me.txt_totalmontantht.Location = New System.Drawing.Point(684, 498)
        Me.txt_totalmontantht.Name = "txt_totalmontantht"
        Me.txt_totalmontantht.ReadOnly = True
        Me.txt_totalmontantht.Size = New System.Drawing.Size(120, 22)
        Me.txt_totalmontantht.TabIndex = 32
        '
        'txt_montantht
        '
        Me.txt_montantht.Location = New System.Drawing.Point(176, 140)
        Me.txt_montantht.Name = "txt_montantht"
        Me.txt_montantht.ReadOnly = True
        Me.txt_montantht.Size = New System.Drawing.Size(205, 22)
        Me.txt_montantht.TabIndex = 33
        '
        'txt_totalquantite
        '
        Me.txt_totalquantite.Location = New System.Drawing.Point(539, 498)
        Me.txt_totalquantite.Name = "txt_totalquantite"
        Me.txt_totalquantite.ReadOnly = True
        Me.txt_totalquantite.Size = New System.Drawing.Size(120, 22)
        Me.txt_totalquantite.TabIndex = 34
        '
        'txt_totalprixunitaire
        '
        Me.txt_totalprixunitaire.Location = New System.Drawing.Point(383, 498)
        Me.txt_totalprixunitaire.Name = "txt_totalprixunitaire"
        Me.txt_totalprixunitaire.ReadOnly = True
        Me.txt_totalprixunitaire.Size = New System.Drawing.Size(120, 22)
        Me.txt_totalprixunitaire.TabIndex = 35
        '
        'txt_tva
        '
        Me.txt_tva.Location = New System.Drawing.Point(522, 590)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.ReadOnly = True
        Me.txt_tva.Size = New System.Drawing.Size(175, 22)
        Me.txt_tva.TabIndex = 36
        '
        'txt_remise
        '
        Me.txt_remise.Location = New System.Drawing.Point(522, 654)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.ReadOnly = True
        Me.txt_remise.Size = New System.Drawing.Size(175, 22)
        Me.txt_remise.TabIndex = 37
        '
        'btm_modifier
        '
        Me.btm_modifier.Location = New System.Drawing.Point(939, 71)
        Me.btm_modifier.Name = "btm_modifier"
        Me.btm_modifier.Size = New System.Drawing.Size(91, 42)
        Me.btm_modifier.TabIndex = 38
        Me.btm_modifier.Text = "modifier quantité"
        Me.btm_modifier.UseVisualStyleBackColor = True
        '
        'txt_modifier
        '
        Me.txt_modifier.Location = New System.Drawing.Point(694, 81)
        Me.txt_modifier.Name = "txt_modifier"
        Me.txt_modifier.Size = New System.Drawing.Size(184, 22)
        Me.txt_modifier.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(690, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 20)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "modifier quantité :"
        '
        'btm_supprimer
        '
        Me.btm_supprimer.Location = New System.Drawing.Point(906, 315)
        Me.btm_supprimer.Name = "btm_supprimer"
        Me.btm_supprimer.Size = New System.Drawing.Size(91, 42)
        Me.btm_supprimer.TabIndex = 41
        Me.btm_supprimer.Text = "supprimer"
        Me.btm_supprimer.UseVisualStyleBackColor = True
        '
        'frm_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Violet
        Me.ClientSize = New System.Drawing.Size(1087, 734)
        Me.Controls.Add(Me.btm_supprimer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_modifier)
        Me.Controls.Add(Me.btm_modifier)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.txt_totalprixunitaire)
        Me.Controls.Add(Me.txt_totalquantite)
        Me.Controls.Add(Me.txt_montantht)
        Me.Controls.Add(Me.txt_totalmontantht)
        Me.Controls.Add(Me.txt_quantite)
        Me.Controls.Add(Me.txt_prixunitaire)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btm_calculer)
        Me.Controls.Add(Me.lst_affichemontantht)
        Me.Controls.Add(Me.lst_affichequantite)
        Me.Controls.Add(Me.lst_afficheprixunitaire)
        Me.Controls.Add(Me.lst_afficheproduit)
        Me.Controls.Add(Me.btm_vider)
        Me.Controls.Add(Me.btm_vider2)
        Me.Controls.Add(Me.btm_ajouter)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_gestion"
        Me.Text = "Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lst_produit As ComboBox
    Friend WithEvents btm_ajouter As Button
    Friend WithEvents btm_vider2 As Button
    Friend WithEvents btm_vider As Button
    Friend WithEvents lst_afficheproduit As ListBox
    Friend WithEvents lst_afficheprixunitaire As ListBox
    Friend WithEvents lst_affichequantite As ListBox
    Friend WithEvents lst_affichemontantht As ListBox
    Friend WithEvents btm_calculer As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_prixunitaire As TextBox
    Friend WithEvents txt_quantite As TextBox
    Friend WithEvents txt_totalmontantht As TextBox
    Friend WithEvents txt_montantht As TextBox
    Friend WithEvents txt_totalquantite As TextBox
    Friend WithEvents txt_totalprixunitaire As TextBox
    Friend WithEvents txt_tva As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents btm_modifier As Button
    Friend WithEvents txt_modifier As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btm_supprimer As Button
End Class
