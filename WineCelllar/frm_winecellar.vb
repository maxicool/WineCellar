Public Class frm_winecellar
    Private xml_winecellar As String = My.Application.Info.DirectoryPath & "\winecellar.xml"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_wine.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_cellar.Show()
    End Sub

    Private Sub frm_winecellar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_cellar.Hide()
        frm_wine.Hide()
        If My.Computer.FileSystem.FileExists(xml_winecellar) Then
            Ds_winecellar.ReadXml(xml_winecellar)
        End If
    End Sub

    Private Sub Tb_winecellarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_winecellarBindingNavigatorSaveItem.Click
        Me.Validate()
        Tb_winecellarBindingSource.EndEdit()
        Ds_winecellar.WriteXml(xml_winecellar)
    End Sub

End Class
