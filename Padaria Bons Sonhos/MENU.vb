Public Class frm_menu
    Private Sub btn_contas_Click(sender As Object, e As EventArgs) Handles btn_contas.Click
        frm_gerenciar_contas.ShowDialog()
        'Fechar Formulário MENU
    End Sub

    Private Sub btn_relat_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        frm_relatorios.ShowDialog()
        'Fechar Formulário MENU
    End Sub

    Private Sub btn_atendente_Click(sender As Object, e As EventArgs) Handles btn_atendente.Click
        frm_atendente.ShowDialog()
        'Fechar Formulário MENU
    End Sub

    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        frm_caixa.ShowDialog()
        'Fechar Formulário MENU
    End Sub
End Class