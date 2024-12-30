<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEjemploTemporizador
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrReloj
        '
        Me.tmrReloj.Enabled = True
        Me.tmrReloj.Interval = 1000
        '
        'lblReloj
        '
        Me.lblReloj.BackColor = System.Drawing.Color.Black
        Me.lblReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReloj.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.Olive
        Me.lblReloj.Location = New System.Drawing.Point(76, 89)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(148, 71)
        Me.lblReloj.TabIndex = 0
        Me.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEjemploTemporizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(294, 252)
        Me.Controls.Add(Me.lblReloj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmEjemploTemporizador"
        Me.Text = "Ejemplo de Temporizador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrReloj As Timer
    Friend WithEvents lblReloj As Label
End Class
