Imports System.Globalization

Public Class frm_caixa
    Dim total As Decimal
    Dim desconto As Double
    Dim receber As Double
    Dim recebido As Double
    Dim troco As Double
    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_total.Enabled = False
        carregar_dgv_caixa()
        aux_comanda = 0
        txt_total.Text = "0,00"
        txt_desconto.Text = "0,00"
        txt_a_receber.Text = "0,00"
        txt_recebido.Text = "0,00"
        txt_troco.Text = "0,00"
    End Sub

    Private Sub txt_comanda_TextChanged(sender As Object, e As EventArgs) Handles txt_comanda.TextChanged
        Try
            If String.IsNullOrEmpty(txt_comanda.Text) Then
                carregar_dgv_caixa()
                limpar_caixa()
            Else
                total = 0
                SQL = "SELECT * FROM tb_comandas WHERE num_comanda LIKE '%" & CInt(txt_comanda.Text) & "%'"
                RS = DB.Execute(SQL)
                While Not RS.EOF
                    total += Convert.ToDecimal(RS.Fields("subtotal").Value)
                    RS.MoveNext()
                End While
                txt_total.Text = total.ToString

                SQL = "SELECT * FROM tb_comandas WHERE num_comanda LIKE '%" & CInt(txt_comanda.Text) & "%'"
                RS = DB.Execute(SQL)
                With dgv_caixa
                    .Rows.Clear()
                    Do While Not RS.EOF
                        .Rows.Add(RS.Fields(3).Value, RS.Fields(4).Value, RS.Fields(5).Value, RS.Fields(6).Value)
                        RS.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_desconto_TextChanged(sender As Object, e As EventArgs) Handles txt_desconto.TextChanged
        If txt_desconto.Text = "" Then
            txt_desconto.Text = 0
        ElseIf Double.TryParse(txt_desconto.Text, desconto) Then
            receber = total - desconto
            txt_a_receber.Text = receber.ToString
        Else
            MsgBox("Insira um desconto válido!'.", MsgBoxStyle.Exclamation, "Erro")
        End If
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try
            If String.IsNullOrEmpty(pagamento) Then
                MsgBox("Por favor, selecione um método de pagamento.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")
                Exit Sub
            End If

            Dim numComanda As Integer
            If Not Integer.TryParse(txt_comanda.Text, numComanda) Then
                MsgBox("Por favor, insira um número de comanda válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")
                Exit Sub
            End If

            Dim dataAtual As String = Date.Today.ToString("MM/dd/yyyy") ' Formato MM/dd/yyyy para SQL
            Dim horarioAtual As String = DateTime.Now.ToString("HH:mm:ss")

            For Each row As DataGridViewRow In dgv_caixa.Rows
                If Not row.IsNewRow Then
                    Dim produto As String = row.Cells("Produto").Value.ToString()
                    Dim preco As Decimal = Convert.ToDecimal(row.Cells("Preço").Value)
                    Dim qtdd As Integer = Convert.ToInt32(row.Cells("Qtdd").Value)
                    Dim subtotal As Decimal = Convert.ToDecimal(row.Cells("Subtotal").Value)

                    SQL = "INSERT INTO tb_relatorios (num_comanda, produto, preco, qtdd, subtotal, pagamento, [data]) " &
                      "VALUES (" & numComanda & ", '" & produto & "', " & preco & ", " & qtdd & ", " & subtotal & ", '" & pagamento & "', #" & dataAtual & "#)"
                    DB.Execute(SQL)
                End If
            Next
            limpar_caixa()

            MsgBox("Pedido finalizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
        Catch ex As Exception
            MsgBox("Falha ao finalizar o Pedido. " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_dinheiro_Click(sender As Object, e As EventArgs) Handles btn_dinheiro.Click
        txt_desconto.Text = total / 10 '10% de desconto
        txt_recebido.Enabled = True
        pagamento = "DINHEIRO"
    End Sub

    Private Sub btn_pix_Click(sender As Object, e As EventArgs) Handles btn_pix.Click
        txt_desconto.Text = total / 10 '10% de desconto
        txt_recebido.Enabled = True
        pagamento = "PIX"
    End Sub

    Private Sub btn_debito_Click(sender As Object, e As EventArgs) Handles btn_debito.Click
        txt_desconto.Text = total / 20 '5% de desconto
        txt_recebido.Enabled = True
        pagamento = "C. DEBITO"
    End Sub

    Private Sub btn_cheque_Click(sender As Object, e As EventArgs) Handles btn_cheque.Click
        txt_desconto.Text = "0,00" 'sem desconto
        txt_a_receber.Text = txt_total.Text
        txt_recebido.Enabled = True
        pagamento = "CHEQUE"
    End Sub

    Private Sub btn_vale_Click(sender As Object, e As EventArgs) Handles btn_vale.Click
        txt_desconto.Text = "0,00" 'sem desconto
        txt_a_receber.Text = txt_total.Text
        txt_recebido.Enabled = True
        pagamento = "VALE R."
    End Sub

    Private Sub btn_credito_Click(sender As Object, e As EventArgs) Handles btn_credito.Click
        txt_desconto.Text = "0,00" 'sem desconto
        txt_a_receber.Text = txt_total.Text
        txt_recebido.Enabled = True
        pagamento = "C. CREDITO"
    End Sub

    Private Sub txt_recebido_TextChanged(sender As Object, e As EventArgs) Handles txt_recebido.TextChanged
        If Decimal.TryParse(txt_recebido.Text, recebido) Then
            troco = recebido - receber
            txt_troco.Text = troco.ToString
        Else
            recebido = "0,00"
            troco = "0,00"
            txt_troco.Text = "0,00"
        End If
    End Sub
End Class