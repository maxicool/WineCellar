Public Class frm_winecellar
    Private xml_winecellar As String = My.Application.Info.DirectoryPath & "\winecellar.xml"
    Private xml_cellar As String = My.Application.Info.DirectoryPath & "\cellar.xml"
    Private xml_wine As String = My.Application.Info.DirectoryPath & "\wine.xml"


    Private Sub frm_winecellar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xml_winecellar) Then
            Ds_winecellar.ReadXml(xml_winecellar)
        End If
        If My.Computer.FileSystem.FileExists(xml_cellar) Then
            ds_cellar.ReadXml(xml_cellar)
        End If
        If My.Computer.FileSystem.FileExists(xml_wine) Then
            ds_wine.ReadXml(xml_wine)
        End If

    End Sub

    Private Sub Tb_winecellarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_winecellarBindingNavigatorSaveItem.Click
        Me.Validate()
        Tb_winecellarBindingSource.EndEdit()
        Tb_wineBindingSource.EndEdit()
        Tb_cellarBindingSource.EndEdit()
        Ds_winecellar.WriteXml(xml_winecellar)
        Ds_wine.WriteXml(xml_wine)
        Ds_cellar.WriteXml(xml_cellar)
    End Sub

    Private Sub frm_winecellar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Validate()
        Tb_winecellarBindingSource.EndEdit()
        Tb_wineBindingSource.EndEdit()
        Tb_cellarBindingSource.EndEdit()
        Ds_winecellar.WriteXml(xml_winecellar)
        Ds_wine.WriteXml(xml_wine)
        Ds_cellar.WriteXml(xml_cellar)
    End Sub
End Class
