<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredit
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
        Me.txtDuree = New System.Windows.Forms.TextBox()
        Me.txtMensualite = New System.Windows.Forms.TextBox()
        Me.lblMensualite = New System.Windows.Forms.Label()
        Me.cmdValide = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblDure = New System.Windows.Forms.Label()
        Me.lblTaux = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.txtTaux = New System.Windows.Forms.TextBox()
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.cmdVoiture = New System.Windows.Forms.Button()
        Me.cmdConnexion = New System.Windows.Forms.Button()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConnexion = New System.Windows.Forms.Label()
        Me.cmdClient = New System.Windows.Forms.Button()
        Me.lblVendeur = New System.Windows.Forms.Label()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDuree
        '
        Me.txtDuree.Location = New System.Drawing.Point(129, 118)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Size = New System.Drawing.Size(100, 20)
        Me.txtDuree.TabIndex = 18
        '
        'txtMensualite
        '
        Me.txtMensualite.Location = New System.Drawing.Point(129, 297)
        Me.txtMensualite.Name = "txtMensualite"
        Me.txtMensualite.Size = New System.Drawing.Size(100, 20)
        Me.txtMensualite.TabIndex = 17
        '
        'lblMensualite
        '
        Me.lblMensualite.AutoSize = True
        Me.lblMensualite.Location = New System.Drawing.Point(53, 297)
        Me.lblMensualite.Name = "lblMensualite"
        Me.lblMensualite.Size = New System.Drawing.Size(58, 13)
        Me.lblMensualite.TabIndex = 16
        Me.lblMensualite.Text = "Mensualité"
        '
        'cmdValide
        '
        Me.cmdValide.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdValide.Location = New System.Drawing.Point(154, 257)
        Me.cmdValide.Name = "cmdValide"
        Me.cmdValide.Size = New System.Drawing.Size(75, 22)
        Me.cmdValide.TabIndex = 15
        Me.cmdValide.Text = "Valider"
        Me.cmdValide.UseVisualStyleBackColor = False
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(53, 82)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 14
        Me.lblCapital.Text = "Capital"
        '
        'lblDure
        '
        Me.lblDure.AutoSize = True
        Me.lblDure.Location = New System.Drawing.Point(53, 118)
        Me.lblDure.Name = "lblDure"
        Me.lblDure.Size = New System.Drawing.Size(36, 13)
        Me.lblDure.TabIndex = 13
        Me.lblDure.Text = "Durée"
        '
        'lblTaux
        '
        Me.lblTaux.AutoSize = True
        Me.lblTaux.Location = New System.Drawing.Point(53, 215)
        Me.lblTaux.Name = "lblTaux"
        Me.lblTaux.Size = New System.Drawing.Size(31, 13)
        Me.lblTaux.TabIndex = 12
        Me.lblTaux.Text = "Taux"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(129, 79)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 11
        '
        'txtTaux
        '
        Me.txtTaux.Location = New System.Drawing.Point(129, 215)
        Me.txtTaux.Name = "txtTaux"
        Me.txtTaux.Size = New System.Drawing.Size(100, 20)
        Me.txtTaux.TabIndex = 10
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(154, 385)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 19
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'cmdEnr
        '
        Me.cmdEnr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEnr.Location = New System.Drawing.Point(39, 385)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 20
        Me.cmdEnr.Text = "Enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = False
        '
        'cmdVoiture
        '
        Me.cmdVoiture.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdVoiture.Location = New System.Drawing.Point(270, 385)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 21
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = False
        '
        'cmdConnexion
        '
        Me.cmdConnexion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdConnexion.Location = New System.Drawing.Point(583, 78)
        Me.cmdConnexion.Name = "cmdConnexion"
        Me.cmdConnexion.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnexion.TabIndex = 22
        Me.cmdConnexion.Text = "&Connexion"
        Me.cmdConnexion.UseVisualStyleBackColor = False
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(461, 171)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(197, 110)
        Me.gpbAge.TabIndex = 23
        Me.gpbAge.TabStop = False
        Me.gpbAge.Text = "Etat de la vente"
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(6, 67)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(81, 17)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Interrompue"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(7, 44)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(63, 17)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Terminé"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(7, 20)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(67, 17)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "En cours"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nom du Vendeur"
        '
        'lblConnexion
        '
        Me.lblConnexion.AutoSize = True
        Me.lblConnexion.Location = New System.Drawing.Point(603, 62)
        Me.lblConnexion.Name = "lblConnexion"
        Me.lblConnexion.Size = New System.Drawing.Size(29, 13)
        Me.lblConnexion.TabIndex = 26
        Me.lblConnexion.Text = "Etat "
        '
        'cmdClient
        '
        Me.cmdClient.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdClient.Location = New System.Drawing.Point(379, 385)
        Me.cmdClient.Name = "cmdClient"
        Me.cmdClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdClient.TabIndex = 31
        Me.cmdClient.Text = "Client"
        Me.cmdClient.UseVisualStyleBackColor = False
        '
        'lblVendeur
        '
        Me.lblVendeur.AutoSize = True
        Me.lblVendeur.Location = New System.Drawing.Point(160, 36)
        Me.lblVendeur.Name = "lblVendeur"
        Me.lblVendeur.Size = New System.Drawing.Size(31, 13)
        Me.lblVendeur.TabIndex = 32
        Me.lblVendeur.Text = "........"
        '
        'frmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVendeur)
        Me.Controls.Add(Me.cmdClient)
        Me.Controls.Add(Me.lblConnexion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.cmdConnexion)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.txtDuree)
        Me.Controls.Add(Me.txtMensualite)
        Me.Controls.Add(Me.lblMensualite)
        Me.Controls.Add(Me.cmdValide)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblDure)
        Me.Controls.Add(Me.lblTaux)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.txtTaux)
        Me.Name = "frmCredit"
        Me.Text = "frmCredit"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDuree As TextBox
    Friend WithEvents txtMensualite As TextBox
    Friend WithEvents lblMensualite As Label
    Friend WithEvents cmdValide As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents lblDure As Label
    Friend WithEvents lblTaux As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents txtTaux As TextBox
    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents cmdEnr As Button
    Friend WithEvents cmdVoiture As Button
    Friend WithEvents cmdConnexion As Button
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConnexion As Label
    Friend WithEvents cmdClient As Button
    Friend WithEvents lblVendeur As Label
End Class
