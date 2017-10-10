Public Class frm_wine
    Private xml_wine As String = My.Application.Info.DirectoryPath & "\wine.xml"

    Private Sub Tb_wineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_wineBindingNavigatorSaveItem.Click
        Me.Validate()
        Tb_wineBindingSource.EndEdit()
        Ds_wine.WriteXml(xml_wine)
    End Sub

    Private Sub frm_wine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xml_wine) Then
            Ds_wine.ReadXml(xml_wine)
        End If
    End Sub
End Class