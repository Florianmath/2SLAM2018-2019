<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccueil
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
        Me.cmdIntroduction = New System.Windows.Forms.Button()
        Me.cmdEtude = New System.Windows.Forms.Button()
        Me.cmdRelance = New System.Windows.Forms.Button()
        Me.cmdVendeur = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(162, 202)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(124, 51)
        Me.cmdIntroduction.TabIndex = 0
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'cmdEtude
        '
        Me.cmdEtude.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEtude.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEtude.Location = New System.Drawing.Point(324, 202)
        Me.cmdEtude.Name = "cmdEtude"
        Me.cmdEtude.Size = New System.Drawing.Size(121, 51)
        Me.cmdEtude.TabIndex = 1
        Me.cmdEtude.Text = "&Etude"
        Me.cmdEtude.UseVisualStyleBackColor = False
        '
        'cmdRelance
        '
        Me.cmdRelance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRelance.Location = New System.Drawing.Point(485, 202)
        Me.cmdRelance.Name = "cmdRelance"
        Me.cmdRelance.Size = New System.Drawing.Size(121, 51)
        Me.cmdRelance.TabIndex = 2
        Me.cmdRelance.Text = "&Relance"
        Me.cmdRelance.UseVisualStyleBackColor = False
        '
        'cmdVendeur
        '
        Me.cmdVendeur.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdVendeur.Location = New System.Drawing.Point(324, 307)
        Me.cmdVendeur.Name = "cmdVendeur"
        Me.cmdVendeur.Size = New System.Drawing.Size(121, 51)
        Me.cmdVendeur.TabIndex = 3
        Me.cmdVendeur.Text = "&Vendeur"
        Me.cmdVendeur.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(199, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 80)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Crédit Celeste"
        '
        'FrmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVendeur)
        Me.Controls.Add(Me.cmdRelance)
        Me.Controls.Add(Me.cmdEtude)
        Me.Controls.Add(Me.cmdIntroduction)
        Me.Name = "FrmAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdIntroduction As Button
    Friend WithEvents cmdEtude As Button
    Friend WithEvents cmdRelance As Button
    Friend WithEvents cmdVendeur As Button
    Friend WithEvents Label1 As Label
End Class
