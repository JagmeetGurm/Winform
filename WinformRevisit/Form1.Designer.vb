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
        Me.lbManagement = New System.Windows.Forms.Label()
        Me.lbFirst = New System.Windows.Forms.Label()
        Me.lbSecond = New System.Windows.Forms.Label()
        Me.lbThird = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbManagement
        '
        Me.lbManagement.AutoSize = True
        Me.lbManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbManagement.Location = New System.Drawing.Point(50, 336)
        Me.lbManagement.Name = "lbManagement"
        Me.lbManagement.Size = New System.Drawing.Size(215, 39)
        Me.lbManagement.TabIndex = 0
        Me.lbManagement.Text = "Management"
        '
        'lbFirst
        '
        Me.lbFirst.AutoSize = True
        Me.lbFirst.Location = New System.Drawing.Point(54, 405)
        Me.lbFirst.Name = "lbFirst"
        Me.lbFirst.Size = New System.Drawing.Size(35, 17)
        Me.lbFirst.TabIndex = 1
        Me.lbFirst.Text = "First"
        '
        'lbSecond
        '
        Me.lbSecond.AutoSize = True
        Me.lbSecond.Location = New System.Drawing.Point(54, 434)
        Me.lbSecond.Name = "lbSecond"
        Me.lbSecond.Size = New System.Drawing.Size(56, 17)
        Me.lbSecond.TabIndex = 2
        Me.lbSecond.Text = "Second"
        '
        'lbThird
        '
        Me.lbThird.AutoSize = True
        Me.lbThird.Location = New System.Drawing.Point(54, 512)
        Me.lbThird.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lbThird.Name = "lbThird"
        Me.lbThird.Size = New System.Drawing.Size(41, 17)
        Me.lbThird.TabIndex = 3
        Me.lbThird.Text = "Third"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 558)
        Me.Controls.Add(Me.lbThird)
        Me.Controls.Add(Me.lbSecond)
        Me.Controls.Add(Me.lbFirst)
        Me.Controls.Add(Me.lbManagement)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbManagement As System.Windows.Forms.Label
    Friend WithEvents lbFirst As System.Windows.Forms.Label
    Friend WithEvents lbSecond As System.Windows.Forms.Label
    Friend WithEvents lbThird As System.Windows.Forms.Label

End Class
