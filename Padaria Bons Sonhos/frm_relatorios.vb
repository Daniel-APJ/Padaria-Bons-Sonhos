Public Class frm_relatorios
    Private Sub frm_relatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_cmb_relatorio()
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Select Case cmb_relatorio.SelectedItem.ToString()
            Case "Relatório Diário"
                resp = "DIA"
            Case "Relatório Semanal"
                resp = "SEMANA"
            Case "Relatório Mensal"
                resp = "MES"
            Case "Relatório Personalizado"
                resp = "PERSONALIZADO"
        End Select

        ' Exibir o formulário frm_relatorio com o DataGridView
        frm_relatorio.ShowDialog()
    End Sub
End Class