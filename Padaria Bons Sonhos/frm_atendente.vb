Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frm_atendente

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        aux_comanda = txt_comanda.Text
        Try
            If String.IsNullOrEmpty(txt_comanda.Text) OrElse cmb_produtos.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txt_qtdd.Text) Then
                MsgBox("Preencha todos os campos para adicionar o item à comanda.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            Dim produtoNome As String = cmb_produtos.Text
            Dim produtoId As Integer = CInt(cmb_produtos.SelectedValue)
            Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & diretorio
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim SQL As String = "SELECT preco FROM tb_produtos WHERE id_produto = ?"
                Using cmd As New OleDbCommand(SQL, conn)
                    cmd.Parameters.AddWithValue("id_produto", produtoId)
                    Dim precoProduto As Decimal
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            precoProduto = reader.GetDecimal(0)
                        Else
                            MsgBox("Preço do produto não encontrado.", MsgBoxStyle.Exclamation, "Erro")
                            Exit Sub
                        End If
                    End Using
                    qtdd = CInt(txt_qtdd.Text)
                    subtotal = precoProduto * qtdd

                    SQL = "INSERT INTO tb_comandas (num_comanda, produto, preco, qtdd, subtotal) VALUES (?, ?, ?, ?, ?)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("num_comanda", aux_comanda)
                    cmd.Parameters.AddWithValue("produto", produtoNome)
                    cmd.Parameters.AddWithValue("preco", precoProduto)
                    cmd.Parameters.AddWithValue("qtdd", CInt(txt_qtdd.Text))
                    cmd.Parameters.AddWithValue("subtotal", subtotal)
                    cmd.CommandText = SQL
                    cmd.ExecuteNonQuery()

                    carregar_dgv_produto()
                    cmb_produtos.SelectedIndex = -1
                    txt_preco.Text = ""
                    txt_qtdd.Text = ""
                    txt_comanda.Focus()

                    MsgBox("Item adicionado à comanda com sucesso!", MsgBoxStyle.Information, "Sucesso")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao adicionar item à comanda: " & ex.Message, MsgBoxStyle.Exclamation, "Erro")
        End Try
    End Sub

    Private Sub dgv_produto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellContentClick
        Try
            With dgv_produto
                If .CurrentRow.Cells(5).Selected = True Then    'Remover Pedido da Lista
                    SQL = "SELECT * FROM tb_comandas WHERE num_comanda= " & aux_comanda
                    RS = DB.Execute(SQL)

                    If RS.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente Excluir esse Pedido?",
                                                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exclusão!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_comandas WHERE id= " & .CurrentRow.Cells(6).Value.ToString
                            DB.Execute(SQL)
                            carregar_dgv_produto()
                            txt_comanda.Focus()
                        End If
                    Else
                        MsgBox("Registro não Encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Ação!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub



    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        SQL = "DELETE * FROM tb_comandas WHERE num_comanda= " & aux_comanda
        RS = DB.Execute(SQL)
        aux_comanda = 0
        limpar_atendente()
        carregar_dgv_produto()
    End Sub

    Private Sub frm_atendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aux_comanda = 0
        conectar_banco()
        carregar_cmb_produtos()
        carregar_dgv_produto()
        limpar_atendente()
    End Sub

    Private Sub txt_comanda_LostFocus(sender As Object, e As EventArgs) Handles txt_comanda.LostFocus
        Try
            If String.IsNullOrEmpty(txt_comanda.Text) Then  'Obriga a modificar o aux_comanda
                MsgBox("Adicione o Número da Comanda.", MsgBoxStyle.Information, "Aviso")
                txt_comanda.Focus()
            Else
                aux_comanda = CInt(txt_comanda.Text)
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_comanda_TextChanged(sender As Object, e As EventArgs) Handles txt_comanda.TextChanged
        Try
            If String.IsNullOrEmpty(txt_comanda.Text) Then
                carregar_dgv_produto()
            Else
                SQL = "SELECT * FROM tb_comandas WHERE num_comanda LIKE '%" & CInt(txt_comanda.Text) & "%'"
                RS = DB.Execute(SQL)

                With dgv_produto
                    .Rows.Clear()
                    Do While Not RS.EOF
                        .Rows.Add(RS.Fields(1).Value, RS.Fields(3).Value, RS.Fields(4).Value, RS.Fields(5).Value, RS.Fields(6).Value, "", RS.Fields(0).Value)
                        RS.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Public Sub cmb_produtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produtos.SelectedIndexChanged
        Try
            If cmb_produtos.SelectedIndex <> -1 Then
                Dim produtoId As Integer = CInt(cmb_produtos.SelectedValue)
                Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & diretorio
                Using conn As New OleDbConnection(connectionString)
                    conn.Open()
                    Dim SQL As String = "SELECT preco FROM tb_produtos WHERE id_produto = ?"
                    Using cmd As New OleDbCommand(SQL, conn)
                        cmd.Parameters.AddWithValue("?", produtoId)
                        Using reader As OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                txt_preco.Text = Convert.ToDecimal(reader("preco")).ToString("C2")
                            Else
                                txt_preco.Text = ""
                            End If
                        End Using
                    End Using
                End Using
            End If
        Catch ex As Exception
            'MsgBox("Erro ao Carregar Dados: " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub frm_atendente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If String.IsNullOrEmpty(txt_comanda.Text) Then
                txt_comanda.Text = "1"
            End If
        Catch ex As Exception
            MsgBox("Erro ao Sair", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        aux_comanda = 0
        limpar_atendente()
        carregar_dgv_produto()
    End Sub
End Class