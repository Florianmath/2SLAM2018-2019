<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoordonnéesClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.label58 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.aa = New System.Windows.Forms.Label()
        Me.txtNomDeJeunneFille = New System.Windows.Forms.TextBox()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRevenuAnnuel = New System.Windows.Forms.TextBox()
        Me.txtDateDeNaissnace = New System.Windows.Forms.TextBox()
        Me.label56 = New System.Windows.Forms.Label()
        Me.label45 = New System.Windows.Forms.Label()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.cmdVoiture = New System.Windows.Forms.Button()
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.gpbSituationPatri = New System.Windows.Forms.GroupBox()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.txtAdresseMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.gpbSituationPatri.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(19, 204)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 15
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(19, 139)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Prenom"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(19, 123)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(29, 13)
        Me.Label.TabIndex = 12
        Me.Label.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Je m'appelle"
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(19, 71)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 10
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(180, 139)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 20)
        Me.txtCP.TabIndex = 19
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(180, 72)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 18
        '
        'label58
        '
        Me.label58.AutoSize = True
        Me.label58.Location = New System.Drawing.Point(177, 123)
        Me.label58.Name = "label58"
        Me.label58.Size = New System.Drawing.Size(64, 13)
        Me.label58.TabIndex = 17
        Me.label58.Text = "Code Postal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Adresse"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(180, 276)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 23
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(180, 204)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 22
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(180, 260)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(58, 13)
        Me.label8.TabIndex = 21
        Me.label8.Text = "Téléphone"
        '
        'aa
        '
        Me.aa.AutoSize = True
        Me.aa.Location = New System.Drawing.Point(180, 188)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(26, 13)
        Me.aa.TabIndex = 20
        Me.aa.Text = "Ville"
        '
        'txtNomDeJeunneFille
        '
        Me.txtNomDeJeunneFille.Location = New System.Drawing.Point(330, 276)
        Me.txtNomDeJeunneFille.Name = "txtNomDeJeunneFille"
        Me.txtNomDeJeunneFille.Size = New System.Drawing.Size(100, 20)
        Me.txtNomDeJeunneFille.TabIndex = 31
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(331, 204)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nom de jeunne Fille"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Profession"
        '
        'txtRevenuAnnuel
        '
        Me.txtRevenuAnnuel.Location = New System.Drawing.Point(332, 139)
        Me.txtRevenuAnnuel.Name = "txtRevenuAnnuel"
        Me.txtRevenuAnnuel.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenuAnnuel.TabIndex = 27
        '
        'txtDateDeNaissnace
        '
        Me.txtDateDeNaissnace.Location = New System.Drawing.Point(331, 72)
        Me.txtDateDeNaissnace.Name = "txtDateDeNaissnace"
        Me.txtDateDeNaissnace.Size = New System.Drawing.Size(100, 20)
        Me.txtDateDeNaissnace.TabIndex = 26
        '
        'label56
        '
        Me.label56.AutoSize = True
        Me.label56.Location = New System.Drawing.Point(329, 123)
        Me.label56.Name = "label56"
        Me.label56.Size = New System.Drawing.Size(81, 13)
        Me.label56.TabIndex = 25
        Me.label56.Text = "Revenu Annuel"
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Location = New System.Drawing.Point(328, 56)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(98, 13)
        Me.label45.TabIndex = 24
        Me.label45.Text = "Date de Naissance"
        '
        'cmdEnr
        '
        Me.cmdEnr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEnr.Location = New System.Drawing.Point(686, 398)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 32
        Me.cmdEnr.Text = "Enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = False
        '
        'cmdVoiture
        '
        Me.cmdVoiture.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdVoiture.Location = New System.Drawing.Point(12, 415)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 33
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = False
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(104, 415)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 34
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'cmdCredit
        '
        Me.cmdCredit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCredit.Location = New System.Drawing.Point(197, 415)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 35
        Me.cmdCredit.Text = "&Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = False
        '
        'gpbSituationPatri
        '
        Me.gpbSituationPatri.Controls.Add(Me.rdbOcc3a5)
        Me.gpbSituationPatri.Controls.Add(Me.rdbOcc3)
        Me.gpbSituationPatri.Controls.Add(Me.rdbNeuf)
        Me.gpbSituationPatri.Location = New System.Drawing.Point(522, 56)
        Me.gpbSituationPatri.Name = "gpbSituationPatri"
        Me.gpbSituationPatri.Size = New System.Drawing.Size(197, 101)
        Me.gpbSituationPatri.TabIndex = 36
        Me.gpbSituationPatri.TabStop = False
        Me.gpbSituationPatri.Text = "Situation patrimoniale"
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(6, 67)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(133, 17)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Occupant à titre gratuit"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(7, 44)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(69, 17)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Locataire"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(7, 20)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(76, 17)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Proprétaire"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'txtAdresseMail
        '
        Me.txtAdresseMail.Location = New System.Drawing.Point(457, 276)
        Me.txtAdresseMail.Name = "txtAdresseMail"
        Me.txtAdresseMail.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresseMail.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Adresse Mail"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(457, 311)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(330, 17)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "J'accepte l'utilisation de mon adresse mail pour la correspondace"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(457, 335)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(288, 17)
        Me.CheckBox2.TabIndex = 40
        Me.CheckBox2.Text = "Mon adresse mail pourra être utilisée a titre commerciale"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(457, 359)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(344, 17)
        Me.CheckBox3.TabIndex = 41
        Me.CheckBox3.Text = "Mon adresse mail pourra être utilisée pour des prestataires extrenes."
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'frmCoordonnéesClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtAdresseMail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gpbSituationPatri)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.txtNomDeJeunneFille)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRevenuAnnuel)
        Me.Controls.Add(Me.txtDateDeNaissnace)
        Me.Controls.Add(Me.label56)
        Me.Controls.Add(Me.label45)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.label58)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Name = "frmCoordonnéesClient"
        Me.Text = "frmCoordonnéesClient"
        Me.gpbSituationPatri.ResumeLayout(False)
        Me.gpbSituationPatri.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents label58 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents aa As Label
    Friend WithEvents txtNomDeJeunneFille As TextBox
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRevenuAnnuel As TextBox
    Friend WithEvents txtDateDeNaissnace As TextBox
    Friend WithEvents label56 As Label
    Friend WithEvents label45 As Label
    Friend WithEvents cmdEnr As Button
    Friend WithEvents cmdVoiture As Button
    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents gpbSituationPatri As GroupBox
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents txtAdresseMail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
