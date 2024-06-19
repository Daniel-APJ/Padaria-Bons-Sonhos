Imports System.Data.OleDb
Imports System.Globalization

Module ModuloGlobal
    Public DB As New ADODB.Connection
    Public RS As New ADODB.Recordset
    Public SQL As String
    Public diretorio = Application.StartupPath & "\Banco\padaria.mdb"
    Public cargo, aux_cpf, resp, pagamento As String
    Public aux_comanda, preco_total As Integer
    Public subtotal, qtdd As Decimal

    Sub limpar_login()
        Try
            With frm_login
                .txt_cpf.Clear()
                .txt_senha.Clear()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub conectar_banco()
        Try
            DB = CreateObject("ADODB.Connection")
            DB.Open("Provider=Microsoft.JET.OLEDB.4.0;Data source=" & diretorio)
            'MsgBox("Conexão OK!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro de Conexão!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    '====================================GERENCIAR CONTAS:====================================================
    Sub limpar_cadastro()
        Try
            With frm_gerenciar_contas
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_senha.Clear()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub carregar_filtro_contas()
        Try
            With frm_gerenciar_contas.TScmb_filtro.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frm_gerenciar_contas.TScmb_filtro.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao Carregar o Filtro!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub carregar_dgv_contas()
        Try
            SQL = "select * from tb_contas order by nome asc"
            RS = DB.Execute(SQL)
            With frm_gerenciar_contas.dgv_contas
                .Rows.Clear()
                Do While RS.EOF = False
                    .Rows.Add(RS.Fields(0).Value, RS.Fields(1).Value, RS.Fields(2).Value, RS.Fields(3).Value)
                    RS.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    '====================================ATENDENTE:====================================================
    Sub carregar_cmb_produtos()
        Try
            frm_atendente.cmb_produtos.Items.Clear()
            Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & diretorio
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim adapter As New OleDbDataAdapter("SELECT id_produto, nome FROM tb_produtos", conn)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    frm_atendente.cmb_produtos.DataSource = dataTable
                    frm_atendente.cmb_produtos.DisplayMember = "nome" ' Especifica qual coluna será exibida na ComboBox
                    frm_atendente.cmb_produtos.ValueMember = "id_produto" ' Especifica qual coluna será o valor real dos itens
                Else
                    MsgBox("Nenhum produto encontrado!", MsgBoxStyle.Information, "Aviso")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar Lista de Produtos!" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub carregar_dgv_produto()
        Try
            SQL = "SELECT * FROM tb_comandas WHERE num_comanda= " & aux_comanda
            RS = DB.Execute(SQL)

            With frm_atendente.dgv_produto
                .Rows.Clear()
                Do While Not RS.EOF
                    .Rows.Add(RS.Fields(1).Value, RS.Fields(3).Value, RS.Fields(4).Value, RS.Fields(5).Value, RS.Fields(6).Value, "", RS.Fields(0).Value)
                    RS.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar itens da comanda: " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub
    Sub limpar_atendente()
        Try
            With frm_atendente
                .txt_comanda.Clear()
                .txt_qtdd.Clear()
                .cmb_produtos.SelectedIndex = -1
                .txt_comanda.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    '====================================RELATÓRIO:====================================================
    Sub carregar_cmb_relatorio()
        Try
            With frm_relatorios.cmb_relatorio.Items
                .Add("Relatório Diário")
                .Add("Relatório Semanal")
                .Add("Relatório Mensal")
                .Add("Relatório Personalizado")
            End With
            frm_relatorios.cmb_relatorio.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao Carregar o Filtro!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub gerar_relatorio_diario()
        Dim hoje As Date = Date.Today
        Dim sql As String = "SELECT num_comanda as Comanda, produto as Produto, preco as Preço, qtdd as QTDD, subtotal as Subtotal, pagamento as Pagamento, data as Data FROM tb_relatorios WHERE [data] = #" & hoje.ToString("MM/dd/yyyy") & "#"
        frm_relatorio.dgv_relatorio.DataSource = carregar_relatorio(sql)
    End Sub

    Sub gerar_relatorio_semanal()
        Dim hoje As Date = Date.Today
        Dim inicioSemana As Date = hoje.AddDays(-hoje.DayOfWeek + 1) ' Primeiro dia da semana
        Dim fimSemana As Date = inicioSemana.AddDays(6) ' Último dia da semana
        Dim sql As String = "SELECT num_comanda as Comanda, produto as Produto, preco as Preço, qtdd as QTDD, subtotal as Subtotal, pagamento as Pagamento, data as Data FROM tb_relatorios WHERE [data] BETWEEN #" & inicioSemana.ToString("MM/dd/yyyy") & "# AND #" & fimSemana.ToString("MM/dd/yyyy") & "#"
        frm_relatorio.dgv_relatorio.DataSource = carregar_relatorio(sql)
    End Sub

    Sub gerar_relatorio_mensal()
        Dim hoje As Date = Date.Today
        Dim inicioMes As New Date(hoje.Year, hoje.Month, 1)
        Dim fimMes As Date = inicioMes.AddMonths(1).AddDays(-1)
        Dim sql As String = "SELECT num_comanda as Comanda, produto as Produto, preco as Preço, qtdd as QTDD, subtotal as Subtotal, pagamento as Pagamento, data as Data FROM tb_relatorios WHERE [data] BETWEEN #" & inicioMes.ToString("MM/dd/yyyy") & "# AND #" & fimMes.ToString("MM/dd/yyyy") & "#"
        frm_relatorio.dgv_relatorio.DataSource = carregar_relatorio(sql)
    End Sub

    Sub gerar_relatorio_personalizado(inicio As Date, fim As Date)
        Dim sql As String = "SELECT num_comanda as Comanda, produto as Produto, preco as Preço, qtdd as QTDD, subtotal as Subtotal, pagamento as Pagamento, data as Data FROM tb_relatorios WHERE [data] BETWEEN #" & inicio.ToString("MM/dd/yyyy") & "# AND #" & fim.ToString("MM/dd/yyyy") & "#"
        frm_relatorio.dgv_relatorio.DataSource = carregar_relatorio(sql)
    End Sub

    Function carregar_relatorio(sql As String) As DataTable
        Dim conn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & diretorio)
        Dim cmd As New OleDbCommand(sql, conn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    '====================================CAIXA:====================================================
    Sub carregar_dgv_caixa()
        Try
            SQL = "SELECT * FROM tb_comandas WHERE num_comanda= " & aux_comanda
            RS = DB.Execute(SQL)

            With frm_caixa.dgv_caixa
                .Rows.Clear()
                While Not RS.EOF
                    .Rows.Add(RS.Fields(3).Value, RS.Fields(4).Value, RS.Fields(5).Value, RS.Fields(6).Value)
                    RS.MoveNext()
                End While
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados na Grade!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub limpar_caixa()
        Try
            With frm_caixa
                .dgv_caixa.Rows.Clear()
                .txt_comanda.Clear()
                .txt_total.Clear()
                .txt_desconto.Clear()
                .txt_a_receber.Clear()
                .txt_recebido.Clear()
                .txt_troco.Clear()
                .txt_comanda.Focus()
            End With
            pagamento = String.Empty
        Catch ex As Exception
            MsgBox("Erro ao limpar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Module
