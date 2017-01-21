<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTurtleGraphics
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
        Me.buttonDraw = New System.Windows.Forms.Button()
        Me.buttonReset = New System.Windows.Forms.Button()
        Me.buttonHide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonDraw
        '
        Me.buttonDraw.Location = New System.Drawing.Point(12, 53)
        Me.buttonDraw.Name = "buttonDraw"
        Me.buttonDraw.Size = New System.Drawing.Size(97, 50)
        Me.buttonDraw.TabIndex = 0
        Me.buttonDraw.Text = "Draw"
        Me.buttonDraw.UseVisualStyleBackColor = True
        '
        'buttonReset
        '
        Me.buttonReset.Location = New System.Drawing.Point(12, 147)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(97, 50)
        Me.buttonReset.TabIndex = 1
        Me.buttonReset.Text = "Reset"
        Me.buttonReset.UseVisualStyleBackColor = True
        '
        'buttonHide
        '
        Me.buttonHide.Location = New System.Drawing.Point(12, 238)
        Me.buttonHide.Name = "buttonHide"
        Me.buttonHide.Size = New System.Drawing.Size(97, 50)
        Me.buttonHide.TabIndex = 2
        Me.buttonHide.Text = "Button3"
        Me.buttonHide.UseVisualStyleBackColor = True
        '
        'FormTurtleGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 394)
        Me.Controls.Add(Me.buttonHide)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.buttonDraw)
        Me.Name = "FormTurtleGraphics"
        Me.Text = "TurtleGraphics-Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonDraw As System.Windows.Forms.Button
    Friend WithEvents buttonReset As System.Windows.Forms.Button
    Friend WithEvents buttonHide As System.Windows.Forms.Button

End Class
