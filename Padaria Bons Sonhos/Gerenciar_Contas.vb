Public Class frm_gerenciar_contas
    Private Sub frm_gerenciar_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        limpar_cadastro()
        carregar_filtro_contas()
        carregar_dgv_contas()
        txt_cpf.Enabled = True
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Try
            If IsDBNull(cargo) OrElse String.IsNullOrEmpty(cargo.ToString()) Then
                MsgBox("Defina um Cargo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            SQL = "SELECT * FROM tb_contas WHERE cpf='" & txt_cpf.Text & "'"
            RS = DB.Execute(SQL)

            If RS.EOF = False Then  'Atualizar
                SQL = "UPDATE tb_contas SET nome='" & txt_nome.Text & "', " &
                "senha='" & txt_senha.Text & "', cargo='" & cargo & "' WHERE cpf='" & txt_cpf.Text & "'"
                DB.Execute(SQL)
                MsgBox("Dados Atualizados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            Else    'Salvar novo
                SQL = "INSERT INTO tb_contas (cpf, nome, senha, cargo) VALUES ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_senha.Text & "', '" & cargo & "')"
                DB.Execute(SQL)
                MsgBox("Dados Salvos com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Salvando!")
            End If
            txt_cpf.Enabled = True
            limpar_cadastro()
            carregar_dgv_contas()
        Catch ex As Exception
            MsgBox("Erro ao Confirmar Dados! " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Private Sub TStxt_filtro_TextChanged(sender As Object, e As EventArgs) Handles TStxt_filtro.TextChanged
        Try
            If TScmb_filtro.SelectedIndex = 0 Then
                SQL = "SELECT * FROM tb_contas WHERE cpf LIKE '%" & TStxt_filtro.Text & "%'"
                RS = DB.Execute(SQL)

                With dgv_contas
                    .Rows.Clear()
                    Do While RS.EOF = False
                        .Rows.Add(RS.Fields(0).Value, RS.Fields(1).Value, RS.Fields(2).Value, RS.Fields(3).Value)
                        RS.MoveNext()
                    Loop
                End With
            ElseIf TScmb_filtro.SelectedIndex = 1 Then
                SQL = "SELECT * FROM tb_contas WHERE nome LIKE '%" & TStxt_filtro.Text & "%'"
                RS = DB.Execute(SQL)

                With dgv_contas
                    .Rows.Clear()
                    Do While RS.EOF = False
                        .Rows.Add(RS.Fields(0).Value, RS.Fields(1).Value, RS.Fields(2).Value, RS.Fields(3).Value)
                        RS.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao Carregar Dados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Private Sub dgv_contas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contas.CellContentClick
        Try
            With dgv_contas
                ' Atribuir o CPF selecionado à variável aux_cpf
                aux_cpf = .CurrentRow.Cells(0).Value.ToString()

                If .CurrentRow.Cells(4).Selected = True Then    'Editar
                    SQL = "SELECT * FROM tb_contas WHERE cpf='" & aux_cpf & "'"
                    RS = DB.Execute(SQL)

                    If RS.EOF = False Then
                        txt_cpf.Text = RS.Fields("cpf").Value.ToString()
                        txt_nome.Text = RS.Fields("nome").Value.ToString()
                        txt_senha.Text = RS.Fields("senha").Value.ToString()
                        cargo = RS.Fields("cargo").Value
                        txt_cpf.Enabled = False
                    Else
                        MsgBox("Registro não Encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then   'Excluir
                    SQL = "SELECT * FROM tb_contas WHERE cpf='" & aux_cpf & "'"
                    RS = DB.Execute(SQL)

                    If RS.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente Excluir o Cadastro?",
                                                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exclusão!")
                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_contas WHERE cpf='" & aux_cpf & "'"
                            DB.Execute(SQL)
                            carregar_dgv_contas()
                            limpar_cadastro()
                        End If
                    Else
                        MsgBox("Registro não Encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar Ação! " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        cargo = "CAIXA"
    End Sub
    Private Sub btn_atend_Click(sender As Object, e As EventArgs) Handles btn_atend.Click
        cargo = "ATENDENTE"
    End Sub
    Private Sub btn_gere_Click(sender As Object, e As EventArgs) Handles btn_gere.Click
        cargo = "GERENTE"
    End Sub
End Class