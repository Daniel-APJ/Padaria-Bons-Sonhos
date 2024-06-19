<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_caixa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_atendente = New System.Windows.Forms.Button()
        Me.btn_relat = New System.Windows.Forms.Button()
        Me.btn_contas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_caixa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_atendente)
        Me.GroupBox1.Controls.Add(Me.btn_relat)
        Me.GroupBox1.Controls.Add(Me.btn_contas)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 253)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'btn_caixa
        '
        Me.btn_caixa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_caixa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_caixa.Location = New System.Drawing.Point(194, 190)
        Me.btn_caixa.Name = "btn_caixa"
        Me.btn_caixa.Size = New System.Drawing.Size(134, 50)
        Me.btn_caixa.TabIndex = 6
        Me.btn_caixa.Text = "Caixa"
        Me.btn_caixa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Acessar Perfis:"
        '
        'btn_atendente
        '
        Me.btn_atendente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_atendente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atendente.Location = New System.Drawing.Point(22, 190)
        Me.btn_atendente.Name = "btn_atendente"
        Me.btn_atendente.Size = New System.Drawing.Size(134, 50)
        Me.btn_atendente.TabIndex = 4
        Me.btn_atendente.Text = "Atendente"
        Me.btn_atendente.UseVisualStyleBackColor = False
        '
        'btn_relat
        '
        Me.btn_relat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_relat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relat.Location = New System.Drawing.Point(194, 42)
        Me.btn_relat.Name = "btn_relat"
        Me.btn_relat.Size = New System.Drawing.Size(134, 77)
        Me.btn_relat.TabIndex = 3
        Me.btn_relat.Text = "Relatórios"
        Me.btn_relat.UseVisualStyleBackColor = False
        '
        'btn_contas
        '
        Me.btn_contas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_contas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_contas.Location = New System.Drawing.Point(22, 42)
        Me.btn_contas.Name = "btn_contas"
        Me.btn_contas.Size = New System.Drawing.Size(134, 77)
        Me.btn_contas.TabIndex = 2
        Me.btn_contas.Text = "Gerenciar Contas"
        Me.btn_contas.UseVisualStyleBackColor = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de Opções"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_contas As Button
    Friend WithEvents btn_caixa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_atendente As Button
    Friend WithEvents btn_relat As Button
End Class
