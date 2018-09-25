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
        Me.SuspendLayout()
        '
        'txtDuree
        '
        Me.txtDuree.Location = New System.Drawing.Point(137, 103)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Size = New System.Drawing.Size(100, 20)
        Me.txtDuree.TabIndex = 18
        '
        'txtMensualite
        '
        Me.txtMensualite.Location = New System.Drawing.Point(137, 282)
        Me.txtMensualite.Name = "txtMensualite"
        Me.txtMensualite.Size = New System.Drawing.Size(100, 20)
        Me.txtMensualite.TabIndex = 17
        '
        'lblMensualite
        '
        Me.lblMensualite.AutoSize = True
        Me.lblMensualite.Location = New System.Drawing.Point(61, 282)
        Me.lblMensualite.Name = "lblMensualite"
        Me.lblMensualite.Size = New System.Drawing.Size(58, 13)
        Me.lblMensualite.TabIndex = 16
        Me.lblMensualite.Text = "Mensualité"
        '
        'cmdValide
        '
        Me.cmdValide.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdValide.Location = New System.Drawing.Point(162, 242)
        Me.cmdValide.Name = "cmdValide"
        Me.cmdValide.Size = New System.Drawing.Size(75, 22)
        Me.cmdValide.TabIndex = 15
        Me.cmdValide.Text = "Validé"
        Me.cmdValide.UseVisualStyleBackColor = False
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(61, 67)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(39, 13)
        Me.lblCapital.TabIndex = 14
        Me.lblCapital.Text = "Capital"
        '
        'lblDure
        '
        Me.lblDure.AutoSize = True
        Me.lblDure.Location = New System.Drawing.Point(61, 103)
        Me.lblDure.Name = "lblDure"
        Me.lblDure.Size = New System.Drawing.Size(36, 13)
        Me.lblDure.TabIndex = 13
        Me.lblDure.Text = "Durée"
        '
        'lblTaux
        '
        Me.lblTaux.AutoSize = True
        Me.lblTaux.Location = New System.Drawing.Point(61, 200)
        Me.lblTaux.Name = "lblTaux"
        Me.lblTaux.Size = New System.Drawing.Size(31, 13)
        Me.lblTaux.TabIndex = 12
        Me.lblTaux.Text = "Taux"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(137, 64)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(100, 20)
        Me.txtCapital.TabIndex = 11
        '
        'txtTaux
        '
        Me.txtTaux.Location = New System.Drawing.Point(137, 200)
        Me.txtTaux.Name = "txtTaux"
        Me.txtTaux.Size = New System.Drawing.Size(100, 20)
        Me.txtTaux.TabIndex = 10
        '
        'cmdIntroduction
        '
        Me.cmdIntroduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdIntroduction.Location = New System.Drawing.Point(162, 370)
        Me.cmdIntroduction.Name = "cmdIntroduction"
        Me.cmdIntroduction.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntroduction.TabIndex = 19
        Me.cmdIntroduction.Text = "&Introduction"
        Me.cmdIntroduction.UseVisualStyleBackColor = False
        '
        'frmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
