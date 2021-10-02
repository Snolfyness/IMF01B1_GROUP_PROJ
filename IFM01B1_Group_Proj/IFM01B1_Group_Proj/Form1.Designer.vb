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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLearnMaterial
        '
        Me.btnLearnMaterial.Location = New System.Drawing.Point(12, 33)
        Me.btnLearnMaterial.Name = "btnLearnMaterial"
        Me.btnLearnMaterial.Size = New System.Drawing.Size(263, 66)
        Me.btnLearnMaterial.TabIndex = 0
        Me.btnLearnMaterial.Text = "Learning Material"
        Me.btnLearnMaterial.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(12, 114)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(263, 66)
        Me.btnQuiz.TabIndex = 1
        Me.btnQuiz.Text = "Take Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(321, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(451, 399)
        Me.TextBox1.TabIndex = 2
        '
        'frmELearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnQuiz)
        Me.Controls.Add(Me.btnLearnMaterial)
        Me.Name = "frmELearning"
        Me.Text = "E-Learning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLearnMaterial As Button
    Friend WithEvents btnQuiz As Button
    Friend WithEvents TextBox1 As TextBox
End Class
