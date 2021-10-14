<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtdisplay = New System.Windows.Forms.RichTextBox()
        Me.btnquiz = New System.Windows.Forms.Button()
        Me.btnLearnmaterial = New System.Windows.Forms.Button()
        Me.btnsavetofile = New System.Windows.Forms.Button()
        Me.btnreadfromfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(254, 2)
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(599, 426)
        Me.txtdisplay.TabIndex = 0
        Me.txtdisplay.Text = ""
        '
        'btnquiz
        '
        Me.btnquiz.Location = New System.Drawing.Point(21, 99)
        Me.btnquiz.Name = "btnquiz"
        Me.btnquiz.Size = New System.Drawing.Size(138, 45)
        Me.btnquiz.TabIndex = 1
        Me.btnquiz.Text = "Take Quiz"
        Me.btnquiz.UseVisualStyleBackColor = True
        '
        'btnLearnmaterial
        '
        Me.btnLearnmaterial.Location = New System.Drawing.Point(21, 12)
        Me.btnLearnmaterial.Name = "btnLearnmaterial"
        Me.btnLearnmaterial.Size = New System.Drawing.Size(138, 50)
        Me.btnLearnmaterial.TabIndex = 2
        Me.btnLearnmaterial.Text = "Display Learning Material"
        Me.btnLearnmaterial.UseVisualStyleBackColor = True
        '
        'btnsavetofile
        '
        Me.btnsavetofile.Location = New System.Drawing.Point(21, 187)
        Me.btnsavetofile.Name = "btnsavetofile"
        Me.btnsavetofile.Size = New System.Drawing.Size(138, 44)
        Me.btnsavetofile.TabIndex = 3
        Me.btnsavetofile.Text = "Save to file"
        Me.btnsavetofile.UseVisualStyleBackColor = True
        '
        'btnreadfromfile
        '
        Me.btnreadfromfile.Location = New System.Drawing.Point(20, 272)
        Me.btnreadfromfile.Name = "btnreadfromfile"
        Me.btnreadfromfile.Size = New System.Drawing.Size(139, 40)
        Me.btnreadfromfile.TabIndex = 4
        Me.btnreadfromfile.Text = "Read From File"
        Me.btnreadfromfile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnreadfromfile)
        Me.Controls.Add(Me.btnsavetofile)
        Me.Controls.Add(Me.btnLearnmaterial)
        Me.Controls.Add(Me.btnquiz)
        Me.Controls.Add(Me.txtdisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtdisplay As RichTextBox
    Friend WithEvents btnquiz As Button
    Friend WithEvents btnLearnmaterial As Button
    Friend WithEvents btnsavetofile As Button
    Friend WithEvents btnreadfromfile As Button
End Class
