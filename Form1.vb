Imports MapWinGIS
Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim layer As New Shapefile
        Dim ouvert As Boolean
        ouvert = layer.Open("C:\Users\ayoubovski\Desktop\Data\Shapefiles\world_adm0.shp")
        If (ouvert) Then

            Dim layer_handle As Integer
            layer_handle = AxMap1.AddLayer(layer, True)
            AxMap1.set_ShapeLayerLineColor(layer_handle, Convert.ToUInt32(RGB(0, 0, 0)))
            AxMap1.set_ShapeLayerFillColor(layer_handle, Convert.ToUInt32(RGB(0, 0, 255)))
            AxMap1.set_ShapeLayerLineWidth(layer_handle, 1)
           



            
        Else
            MessageBox.Show("le fichier est peut etre endommager")


        End If




    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        AxMap1.CursorMode = tkCursorMode.cmZoomIn

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        AxMap1.CursorMode = tkCursorMode.cmZoomOut
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        AxMap1.CursorMode = tkCursorMode.cmPan
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxMap1.ZoomToMaxExtents()

    End Sub
End Class
