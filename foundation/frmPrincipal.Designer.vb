<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        btnSalid = New Button()
        SuspendLayout()
        ' 
        ' btnSalid
        ' 
        btnSalid.Location = New Point(351, 116)
        btnSalid.Name = "btnSalid"
        btnSalid.Size = New Size(94, 29)
        btnSalid.TabIndex = 0
        btnSalid.Text = "Salir"
        btnSalid.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 181)
        Controls.Add(btnSalid)
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Principal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSalid As Button
End Class
