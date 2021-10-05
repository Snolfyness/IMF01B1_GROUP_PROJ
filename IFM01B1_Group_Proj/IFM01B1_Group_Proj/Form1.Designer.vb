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
        Me.btnSaveMarks = New System.Windows.Forms.Button()
        Me.btnViewMarks = New System.Windows.Forms.Button()
        Me.btnBestMark = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLearnMaterial
        '
        Me.btnLearnMaterial.Location = New System.Drawing.Point(12, 32)
        Me.btnLearnMaterial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLearnMaterial.Name = "btnLearnMaterial"
        Me.btnLearnMaterial.Size = New System.Drawing.Size(263, 66)
        Me.btnLearnMaterial.TabIndex = 0
        Me.btnLearnMaterial.Text = "Learning Material"
        Me.btnLearnMaterial.UseVisualStyleBackColor = True
        '
        'btnQuiz
        '
        Me.btnQuiz.Location = New System.Drawing.Point(12, 114)
        Me.btnQuiz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuiz.Name = "btnQuiz"
        Me.btnQuiz.Size = New System.Drawing.Size(263, 66)
        Me.btnQuiz.TabIndex = 1
        Me.btnQuiz.Text = "Take Quiz"
        Me.btnQuiz.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(321, 18)
        Me.txtdisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(451, 399)
        Me.txtdisplay.TabIndex = 2
        '
        'btnSaveMarks
        '
        Me.btnSaveMarks.Location = New System.Drawing.Point(12, 195)
        Me.btnSaveMarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveMarks.Name = "btnSaveMarks"
        Me.btnSaveMarks.Size = New System.Drawing.Size(263, 66)
        Me.btnSaveMarks.TabIndex = 3
        Me.btnSaveMarks.Text = "Save Marks"
        Me.btnSaveMarks.UseVisualStyleBackColor = True
        '
        'btnViewMarks
        '
        Me.btnViewMarks.Location = New System.Drawing.Point(12, 274)
        Me.btnViewMarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewMarks.Name = "btnViewMarks"
        Me.btnViewMarks.Size = New System.Drawing.Size(263, 66)
        Me.btnViewMarks.TabIndex = 4
        Me.btnViewMarks.Text = "View Marks"
        Me.btnViewMarks.UseVisualStyleBackColor = True
        '
        'btnBestMark
        '
        Me.btnBestMark.Location = New System.Drawing.Point(12, 351)
        Me.btnBestMark.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBestMark.Name = "btnBestMark"
        Me.btnBestMark.Size = New System.Drawing.Size(263, 66)
        Me.btnBestMark.TabIndex = 5
        Me.btnBestMark.Text = "Best Mark"
        Me.btnBestMark.UseVisualStyleBackColor = True
        '
        'frmELearning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBestMark)
        Me.Controls.Add(Me.btnViewMarks)
        Me.Controls.Add(Me.btnSaveMarks)
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
    Friend WithEvents btnSaveMarks As Button
    Friend WithEvents btnViewMarks As Button
    Friend WithEvents btnBestMark As Button
End Class
