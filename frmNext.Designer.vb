<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNext
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
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldisplay
        '
        Me.lbldisplay.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplay.Location = New System.Drawing.Point(13, 18)
        Me.lbldisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbldisplay.Size = New System.Drawing.Size(395, 153)
        Me.lbldisplay.TabIndex = 9
        Me.lbldisplay.Text = "Display Here"
        Me.lbldisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbldisplay.UseCompatibleTextRendering = True
        '
        'frmNext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 296)
        Me.Controls.Add(Me.lbldisplay)
        Me.Name = "frmNext"
        Me.Text = "frmNext"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldisplay As Label
End Class
