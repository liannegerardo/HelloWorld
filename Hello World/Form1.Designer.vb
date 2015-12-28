<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Ok = New System.Windows.Forms.Button()
        Me.PressOk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ok
        '
        Me.Ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ok.Location = New System.Drawing.Point(104, 155)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(75, 34)
        Me.Ok.TabIndex = 0
        Me.Ok.Text = "OK"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'PressOk
        '
        Me.PressOk.AutoSize = True
        Me.PressOk.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressOk.ForeColor = System.Drawing.Color.Gold
        Me.PressOk.Location = New System.Drawing.Point(95, 74)
        Me.PressOk.Name = "PressOk"
        Me.PressOk.Size = New System.Drawing.Size(94, 22)
        Me.PressOk.TabIndex = 1
        Me.PressOk.Text = "Press OK"
        Me.PressOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PressOk)
        Me.Controls.Add(Me.Ok)
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ok As System.Windows.Forms.Button
    Friend WithEvents PressOk As System.Windows.Forms.Label

End Class
