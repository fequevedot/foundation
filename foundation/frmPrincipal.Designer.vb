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
        btnMensaje = New Button()
        Label1 = New Label()
        btnAbrir = New Button()
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
        ' btnMensaje
        ' 
        btnMensaje.Location = New Point(251, 116)
        btnMensaje.Name = "btnMensaje"
        btnMensaje.Size = New Size(94, 29)
        btnMensaje.TabIndex = 1
        btnMensaje.Text = "Mensaje"
        btnMensaje.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 20)
        Label1.TabIndex = 2
        Label1.Text = "Esta es una etiqueta nueva"' 
        ' btnAbrir
        ' 
        btnAbrir.Location = New Point(151, 116)
        btnAbrir.Name = "btnAbrir"
        btnAbrir.Size = New Size(94, 29)
        btnAbrir.TabIndex = 3
        btnAbrir.Text = "Abrir"
        btnAbrir.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 181)
        Controls.Add(btnAbrir)
        Controls.Add(Label1)
        Controls.Add(btnMensaje)
        Controls.Add(btnSalid)
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSalid As Button
    Friend WithEvents btnMensaje As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAbrir As Button
End Class
