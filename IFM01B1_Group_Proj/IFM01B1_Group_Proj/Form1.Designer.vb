<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmELearning
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
        Me.btnLearnMaterial = New System.Windows.Forms.Button()
        Me.btnQuiz = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLearnMaterial
        '
        Me.btnLearnMaterial.Location = New System.Drawing.Point(11, 26)
        Me.btnLearnMaterial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLearnMaterial.Name = "btnLearnMaterial"
        Me.btnLearnMaterial.Size = New System.Drawing.Size(234, 53)
        Me.btnLearnMaterial.TabIndex = 0
        Me.btnLearnMaterial.Text = "Learning Material"
        Me.btnLearnMaterial.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(11, 91)
        Me.btnQuiz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(234, 53)
        Me.btnQuiz.TabIndex = 1
        Me.btnQuiz.Text = "Take Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(285, 14)
        Me.txtdisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(401, 320)
        Me.txtdisplay.TabIndex = 2
        '
        'frmELearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnLearnMaterial)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmELearning"
        Me.Text = "E-Learning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLearnMaterial As Button
    Friend WithEvents btnQuiz As Button
    Friend WithEvents txtdisplay As TextBox
End Class
