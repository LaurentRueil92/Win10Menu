<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonWin11 = New System.Windows.Forms.Button()
        Me.ButtonWin10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonWin11
        '
        Me.ButtonWin11.Location = New System.Drawing.Point(22, 19)
        Me.ButtonWin11.Name = "ButtonWin11"
        Me.ButtonWin11.Size = New System.Drawing.Size(404, 74)
        Me.ButtonWin11.TabIndex = 0
        Me.ButtonWin11.Text = "Button1"
        Me.ButtonWin11.UseVisualStyleBackColor = True
        '
        'ButtonWin10
        '
        Me.ButtonWin10.Location = New System.Drawing.Point(22, 19)
        Me.ButtonWin10.Name = "ButtonWin10"
        Me.ButtonWin10.Size = New System.Drawing.Size(404, 74)
        Me.ButtonWin10.TabIndex = 1
        Me.ButtonWin10.Text = "Button1"
        Me.ButtonWin10.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 109)
        Me.Controls.Add(Me.ButtonWin10)
        Me.Controls.Add(Me.ButtonWin11)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Menu Contextuel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonWin11 As Button
    Friend WithEvents ButtonWin10 As Button
End Class
