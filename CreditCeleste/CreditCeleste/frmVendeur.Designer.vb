<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendeur
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTaux = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMensualite = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Vendeur"
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(12, 119)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(121, 21)
        Me.cboVendeur.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Part Vendeur (en %)"
        '
        'lblTaux
        '
        Me.lblTaux.AutoSize = True
        Me.lblTaux.Location = New System.Drawing.Point(277, 101)
        Me.lblTaux.Name = "lblTaux"
        Me.lblTaux.Size = New System.Drawing.Size(76, 13)
        Me.lblTaux.TabIndex = 23
        Me.lblTaux.Text = "Taux du Crédit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(597, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Part Concession (en %)"
        '
        'lblMensualite
        '
        Me.lblMensualite.AutoSize = True
        Me.lblMensualite.Location = New System.Drawing.Point(381, 100)
        Me.lblMensualite.Name = "lblMensualite"
        Me.lblMensualite.Size = New System.Drawing.Size(81, 13)
        Me.lblMensualite.TabIndex = 18
        Me.lblMensualite.Text = "Montant Gagné"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Palier"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(199, 143)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(525, 173)
        Me.ListBox1.TabIndex = 44
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(116, 334)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(124, 51)
        Me.cmdIntroduction.TabIndex = 45
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'frmVendeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTaux)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMensualite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboVendeur)
        Me.Name = "frmVendeur"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cboVendeur As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTaux As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMensualite As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cmdIntroduction As Button
End Class
