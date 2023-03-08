<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(242, 154)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 0
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 209)
        Controls.Add(btnSalir)
        Name = "frmUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuarios"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSalir As Button
End Class
