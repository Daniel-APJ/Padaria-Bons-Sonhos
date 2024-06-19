<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_caixa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_caixa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.dgv_caixa = New System.Windows.Forms.DataGridView()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_dinheiro = New System.Windows.Forms.Button()
        Me.btn_vale = New System.Windows.Forms.Button()
        Me.btn_credito = New System.Windows.Forms.Button()
        Me.btn_debito = New System.Windows.Forms.Button()
        Me.btn_pix = New System.Windows.Forms.Button()
        Me.btn_cheque = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.txt_comanda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_troco = New System.Windows.Forms.TextBox()
        Me.txt_recebido = New System.Windows.Forms.TextBox()
        Me.txt_a_receber = New System.Windows.Forms.TextBox()
        Me.txt_desconto = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgv_caixa)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(576, 439)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produtos Vendidos"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MediumPurple
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 21)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'dgv_caixa
        '
        Me.dgv_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_caixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produto, Me.Preço, Me.Qtdd, Me.Subtotal})
        Me.dgv_caixa.Location = New System.Drawing.Point(4, 42)
        Me.dgv_caixa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_caixa.Name = "dgv_caixa"
        Me.dgv_caixa.RowHeadersWidth = 51
        Me.dgv_caixa.RowTemplate.Height = 24
        Me.dgv_caixa.Size = New System.Drawing.Size(567, 392)
        Me.dgv_caixa.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(647, 216)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(116, 20)
        Me.Label.TabIndex = 9
        Me.Label.Text = "Total da Compra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(700, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Método de Pagamento:"
        '
        'btn_dinheiro
        '
        Me.btn_dinheiro.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_dinheiro.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dinheiro.Location = New System.Drawing.Point(616, 84)
        Me.btn_dinheiro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_dinheiro.Name = "btn_dinheiro"
        Me.btn_dinheiro.Size = New System.Drawing.Size(100, 50)
        Me.btn_dinheiro.TabIndex = 11
        Me.btn_dinheiro.Text = "Dinheiro"
        Me.btn_dinheiro.UseVisualStyleBackColor = False
        '
        'btn_vale
        '
        Me.btn_vale.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_vale.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vale.Location = New System.Drawing.Point(616, 139)
        Me.btn_vale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_vale.Name = "btn_vale"
        Me.btn_vale.Size = New System.Drawing.Size(100, 50)
        Me.btn_vale.TabIndex = 12
        Me.btn_vale.Text = "Vale-Refeição"
        Me.btn_vale.UseVisualStyleBackColor = False
        '
        'btn_credito
        '
        Me.btn_credito.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_credito.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_credito.Location = New System.Drawing.Point(737, 139)
        Me.btn_credito.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_credito.Name = "btn_credito"
        Me.btn_credito.Size = New System.Drawing.Size(100, 50)
        Me.btn_credito.TabIndex = 14
        Me.btn_credito.Text = "C. Crédito"
        Me.btn_credito.UseVisualStyleBackColor = False
        '
        'btn_debito
        '
        Me.btn_debito.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_debito.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_debito.Location = New System.Drawing.Point(737, 84)
        Me.btn_debito.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_debito.Name = "btn_debito"
        Me.btn_debito.Size = New System.Drawing.Size(100, 50)
        Me.btn_debito.TabIndex = 13
        Me.btn_debito.Text = "C. Débito"
        Me.btn_debito.UseVisualStyleBackColor = False
        '
        'btn_pix
        '
        Me.btn_pix.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_pix.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pix.Location = New System.Drawing.Point(854, 139)
        Me.btn_pix.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_pix.Name = "btn_pix"
        Me.btn_pix.Size = New System.Drawing.Size(100, 50)
        Me.btn_pix.TabIndex = 16
        Me.btn_pix.Text = "PIX"
        Me.btn_pix.UseVisualStyleBackColor = False
        '
        'btn_cheque
        '
        Me.btn_cheque.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_cheque.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cheque.Location = New System.Drawing.Point(854, 84)
        Me.btn_cheque.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cheque.Name = "btn_cheque"
        Me.btn_cheque.Size = New System.Drawing.Size(100, 50)
        Me.btn_cheque.TabIndex = 15
        Me.btn_cheque.Text = "Cheque"
        Me.btn_cheque.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(647, 246)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Descontos Obtidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(646, 306)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Valor Recebido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(646, 332)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Troco:"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_finalizar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar.Location = New System.Drawing.Point(650, 387)
        Me.btn_finalizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(280, 42)
        Me.btn_finalizar.TabIndex = 23
        Me.btn_finalizar.Text = "Finalizar Pedido"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'txt_comanda
        '
        Me.txt_comanda.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comanda.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_comanda.Location = New System.Drawing.Point(704, 23)
        Me.txt_comanda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_comanda.Name = "txt_comanda"
        Me.txt_comanda.Size = New System.Drawing.Size(43, 26)
        Me.txt_comanda.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(620, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nº Comanda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(647, 276)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Valor a Receber:"
        '
        'txt_troco
        '
        Me.txt_troco.Enabled = False
        Me.txt_troco.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_troco.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_troco.Location = New System.Drawing.Point(803, 330)
        Me.txt_troco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_troco.Size = New System.Drawing.Size(97, 26)
        Me.txt_troco.TabIndex = 22
        '
        'txt_recebido
        '
        Me.txt_recebido.Enabled = False
        Me.txt_recebido.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recebido.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_recebido.Location = New System.Drawing.Point(803, 301)
        Me.txt_recebido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_recebido.Name = "txt_recebido"
        Me.txt_recebido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_recebido.Size = New System.Drawing.Size(97, 26)
        Me.txt_recebido.TabIndex = 21
        '
        'txt_a_receber
        '
        Me.txt_a_receber.Enabled = False
        Me.txt_a_receber.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_a_receber.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_a_receber.Location = New System.Drawing.Point(803, 271)
        Me.txt_a_receber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_a_receber.Name = "txt_a_receber"
        Me.txt_a_receber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_a_receber.Size = New System.Drawing.Size(97, 26)
        Me.txt_a_receber.TabIndex = 29
        '
        'txt_desconto
        '
        Me.txt_desconto.Enabled = False
        Me.txt_desconto.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desconto.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_desconto.Location = New System.Drawing.Point(803, 241)
        Me.txt_desconto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_desconto.Size = New System.Drawing.Size(97, 26)
        Me.txt_desconto.TabIndex = 20
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Black
        Me.txt_total.Location = New System.Drawing.Point(803, 211)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_total.Size = New System.Drawing.Size(97, 26)
        Me.txt_total.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(777, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "R$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(777, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "R$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(777, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "R$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(777, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "R$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(777, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "R$"
        '
        'Produto
        '
        Me.Produto.HeaderText = "Produto"
        Me.Produto.MinimumWidth = 6
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        Me.Produto.Width = 160
        '
        'Preço
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Preço.DefaultCellStyle = DataGridViewCellStyle1
        Me.Preço.HeaderText = "Preço"
        Me.Preço.MinimumWidth = 6
        Me.Preço.Name = "Preço"
        Me.Preço.ReadOnly = True
        Me.Preço.Width = 125
        '
        'Qtdd
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Qtdd.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qtdd.HeaderText = "Qtdd"
        Me.Qtdd.MinimumWidth = 6
        Me.Qtdd.Name = "Qtdd"
        Me.Qtdd.ReadOnly = True
        Me.Qtdd.Width = 60
        '
        'Subtotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.Subtotal.HeaderText = "Sub Total"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 125
        '
        'frm_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 471)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_a_receber)
        Me.Controls.Add(Me.txt_comanda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.txt_troco)
        Me.Controls.Add(Me.txt_recebido)
        Me.Controls.Add(Me.txt_desconto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_pix)
        Me.Controls.Add(Me.btn_cheque)
        Me.Controls.Add(Me.btn_credito)
        Me.Controls.Add(Me.btn_debito)
        Me.Controls.Add(Me.btn_vale)
        Me.Controls.Add(Me.btn_dinheiro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAIXA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_caixa As DataGridView
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_dinheiro As Button
    Friend WithEvents btn_vale As Button
    Friend WithEvents btn_credito As Button
    Friend WithEvents btn_debito As Button
    Friend WithEvents btn_pix As Button
    Friend WithEvents btn_cheque As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents txt_comanda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents txt_recebido As TextBox
    Friend WithEvents txt_a_receber As TextBox
    Friend WithEvents txt_desconto As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Preço As DataGridViewTextBoxColumn
    Friend WithEvents Qtdd As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
