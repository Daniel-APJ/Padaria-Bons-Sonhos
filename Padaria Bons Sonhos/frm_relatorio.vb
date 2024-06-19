Public Class frm_relatorio
    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case resp
            Case "DIA"
                gerar_relatorio_diario()
            Case "SEMANA"
                gerar_relatorio_semanal()
            Case "MES"
                gerar_relatorio_mensal()
            Case "PERSONALIZADO"
                Dim frmPeriodo As New frm_periodo
                If frmPeriodo.ShowDialog() = DialogResult.OK Then
                    Dim inicio As Date = frmPeriodo.dtp_inicio.Value
                    Dim fim As Date = frmPeriodo.dtp_fim.Value
                    gerar_relatorio_personalizado(inicio, fim)
                End If
        End Select
    End Sub
End Class