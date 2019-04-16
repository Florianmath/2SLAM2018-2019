<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieBien
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
        Me.txt1erDate = New System.Windows.Forms.TextBox()
        Me.txtAnneeModele = New System.Windows.Forms.TextBox()
        Me.txtNumImmat = New System.Windows.Forms.TextBox()
        Me.txtNumSerie = New System.Windows.Forms.TextBox()
        Me.txtPuissance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEnregistre = New System.Windows.Forms.Button()
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.lblConnexion = New System.Windows.Forms.Label()
        Me.cmdConnexion = New System.Windows.Forms.Button()
        Me.cmdClient = New System.Windows.Forms.Button()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt1erDate
        '
        Me.txt1erDate.Location = New System.Drawing.Point(31, 280)
        Me.txt1erDate.Name = "txt1erDate"
        Me.txt1erDate.Size = New System.Drawing.Size(132, 20)
        Me.txt1erDate.TabIndex = 0
        '
        'txtAnneeModele
        '
        Me.txtAnneeModele.Location = New System.Drawing.Point(192, 280)
        Me.txtAnneeModele.Name = "txtAnneeModele"
        Me.txtAnneeModele.Size = New System.Drawing.Size(100, 20)
        Me.txtAnneeModele.TabIndex = 1
        '
        'txtNumImmat
        '
        Me.txtNumImmat.Location = New System.Drawing.Point(329, 280)
        Me.txtNumImmat.Name = "txtNumImmat"
        Me.txtNumImmat.Size = New System.Drawing.Size(121, 20)
        Me.txtNumImmat.TabIndex = 2
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(467, 280)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Size = New System.Drawing.Size(128, 20)
        Me.txtNumSerie.TabIndex = 3
        '
        'txtPuissance
        '
        Me.txtPuissance.Location = New System.Drawing.Point(634, 280)
        Me.txtPuissance.Name = "txtPuissance"
        Me.txtPuissance.Size = New System.Drawing.Size(60, 20)
        Me.txtPuissance.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date de 1er immatriculation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Année Modéle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numéro d'immatriculation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numéro de série"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(631, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Puissance"
        '
        'cmdEnregistre
        '
        Me.cmdEnregistre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEnregistre.Location = New System.Drawing.Point(136, 393)
        Me.cmdEnregistre.Name = "cmdEnregistre"
        Me.cmdEnregistre.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnregistre.TabIndex = 10
        Me.cmdEnregistre.Text = "J'enregistre"
        Me.cmdEnregistre.UseVisualStyleBackColor = False
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(255, 393)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 11
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'cmdCredit
        '
        Me.cmdCredit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCredit.Location = New System.Drawing.Point(374, 392)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 12
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(110, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mon nouveau véhicule"
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(436, 78)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(197, 110)
        Me.gpbAge.TabIndex = 14
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
        'lblConnexion
        '
        Me.lblConnexion.AutoSize = True
        Me.lblConnexion.Location = New System.Drawing.Point(679, 376)
        Me.lblConnexion.Name = "lblConnexion"
        Me.lblConnexion.Size = New System.Drawing.Size(29, 13)
        Me.lblConnexion.TabIndex = 28
        Me.lblConnexion.Text = "Etat "
        '
        'cmdConnexion
        '
        Me.cmdConnexion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdConnexion.Location = New System.Drawing.Point(659, 392)
        Me.cmdConnexion.Name = "cmdConnexion"
        Me.cmdConnexion.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnexion.TabIndex = 27
        Me.cmdConnexion.Text = "&Connexion"
        Me.cmdConnexion.UseVisualStyleBackColor = False
        '
        'cmdClient
        '
        Me.cmdClient.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdClient.Location = New System.Drawing.Point(477, 392)
        Me.cmdClient.Name = "cmdClient"
        Me.cmdClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdClient.TabIndex = 29
        Me.cmdClient.Text = "Client"
        Me.cmdClient.UseVisualStyleBackColor = False
        '
        'frmSaisieBien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdClient)
        Me.Controls.Add(Me.lblConnexion)
        Me.Controls.Add(Me.cmdConnexion)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.cmdEnregistre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPuissance)
        Me.Controls.Add(Me.txtNumSerie)
        Me.Controls.Add(Me.txtNumImmat)
        Me.Controls.Add(Me.txtAnneeModele)
        Me.Controls.Add(Me.txt1erDate)
        Me.Name = "frmSaisieBien"
        Me.Text = "frmSaisieBien"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1erDate As TextBox
    Friend WithEvents txtAnneeModele As TextBox
    Friend WithEvents txtNumImmat As TextBox
    Friend WithEvents txtNumSerie As TextBox
    Friend WithEvents txtPuissance As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEnregistre As Button
    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents lblConnexion As Label
    Friend WithEvents cmdConnexion As Button
    Friend WithEvents cmdClient As Button
End Class
