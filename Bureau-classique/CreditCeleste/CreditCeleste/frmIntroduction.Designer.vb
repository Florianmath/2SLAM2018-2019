﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.txtNouvVeh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.cmdVoiture = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAncVeh = New System.Windows.Forms.TextBox()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(129, 60)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Je m'appelle"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(132, 112)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(29, 13)
        Me.Label.TabIndex = 3
        Me.Label.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vendeur"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(132, 128)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(132, 209)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 9
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(129, 315)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(121, 21)
        Me.cboVendeur.TabIndex = 6
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(366, 199)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(197, 110)
        Me.gpbAge.TabIndex = 10
        Me.gpbAge.TabStop = False
        Me.gpbAge.Text = "Age du véhicule"
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(6, 90)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(120, 17)
        Me.rdbOcc5.TabIndex = 3
        Me.rdbOcc5.Text = "Occasion 5 ans et +"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(6, 67)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(132, 17)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Occasion de 3 à 5 ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(7, 44)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(120, 17)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Occasion  de -3 ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(7, 20)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'txtNouvVeh
        '
        Me.txtNouvVeh.Location = New System.Drawing.Point(366, 164)
        Me.txtNouvVeh.Name = "txtNouvVeh"
        Me.txtNouvVeh.Size = New System.Drawing.Size(100, 20)
        Me.txtNouvVeh.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mon Nouveau Véhicule"
        '
        'cmdEnr
        '
        Me.cmdEnr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEnr.Location = New System.Drawing.Point(129, 394)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 13
        Me.cmdEnr.Text = "Enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = False
        '
        'cmdVoiture
        '
        Me.cmdVoiture.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdVoiture.Location = New System.Drawing.Point(274, 394)
        Me.cmdVoiture.Name = "cmdVoiture"
        Me.cmdVoiture.Size = New System.Drawing.Size(75, 23)
        Me.cmdVoiture.TabIndex = 14
        Me.cmdVoiture.Text = "Voiture"
        Me.cmdVoiture.UseVisualStyleBackColor = False
        '
        'cmdCredit
        '
        Me.cmdCredit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCredit.Location = New System.Drawing.Point(417, 394)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 15
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = False
        '
        'cmdPlus
        '
        Me.cmdPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdPlus.Location = New System.Drawing.Point(620, 394)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlus.TabIndex = 16
        Me.cmdPlus.Text = "Plus"
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Mon Ancien Véhicule"
        '
        'txtAncVeh
        '
        Me.txtAncVeh.Location = New System.Drawing.Point(561, 57)
        Me.txtAncVeh.Name = "txtAncVeh"
        Me.txtAncVeh.Size = New System.Drawing.Size(100, 20)
        Me.txtAncVeh.TabIndex = 17
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAncVeh)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdVoiture)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNouvVeh)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboVendeur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents cboVendeur As ComboBox
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents txtNouvVeh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdEnr As Button
    Friend WithEvents cmdVoiture As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAncVeh As TextBox
End Class
