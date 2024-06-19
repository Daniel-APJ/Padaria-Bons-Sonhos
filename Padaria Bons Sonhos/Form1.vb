Public Class frm_login
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Try
            SQL = "select * from tb_contas where cpf='" & txt_cpf.Text & "' and senha='" & txt_senha.Text & "'"
            RS = DB.Execute(SQL)

            If txt_cpf.Text = "111.111.111-11" And txt_senha.Text = "admin" Then
                MsgBox("Bem vindo Administrador(a)!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Bem Vindo!")
                frm_menu.ShowDialog()
                'Fechar Formulário Login
            ElseIf txt_cpf.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Preencha Todos os Campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")
            Else
                If RS.EOF = False Then
                    If RS.Fields(3).Value = "CAIXA" Then    'Verificação de Cargo
                        MsgBox("Login Realizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Bem Vindo!")
                        frm_caixa.ShowDialog()
                        'Fechar Formulário Login
                    ElseIf RS.Fields(3).Value = "ATENDENTE" Then
                        MsgBox("Login Realizado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Bem Vindo!")
                        frm_atendente.ShowDialog()
                        'Fechar Formulário Login
                    Else
                        MsgBox("Login Realizado com Sucesso!" + vbNewLine &
                               "Bem Vindo caro Gerente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Bem Vindo!")
                        frm_menu.ShowDialog()
                        'Fechar Formulário Login
                    End If
                Else
                    MsgBox("Você Digitou o Email ou a Senha Errados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso!")
                    limpar_login()
                End If
            End If
            limpar_login()
        Catch ex As Exception
            MsgBox("Erro ao fazer Login!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso!")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpar_login()
        conectar_banco()
    End Sub
End Class
