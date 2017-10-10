Public Class frm_cellar
    Private xml_cellar As String = My.Application.Info.DirectoryPath & "\cellar.xml"

    Private Sub frm_cellar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xml_cellar) Then
            Ds_cellar.ReadXml(xml_cellar)
        End If
    End Sub

    Private Sub Tb_cellarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_cellarBindingNavigatorSaveItem.Click
        Me.Validate()
        Tb_cellarBindingSource.EndEdit()
        Ds_cellar.WriteXml(xml_cellar)
    End Sub
End Class