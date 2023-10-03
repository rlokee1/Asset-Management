Imports System.Data.SqlClient
Public Class Dashboard
Dim Con = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")

Private Sub Manage_Btn_Click(sender As Object, e As EventArgs) Handles Manage_Btn.Click
        ManageAsset.Show()
End Sub

Private Sub Search_Btn_Click(sender As Object, e As EventArgs) Handles Search_Btn.Click
        SearchAsset.Show()
End Sub

Private Sub Exchange_Btn_Click(sender As Object, e As EventArgs) Handles Exchange_Btn.Click
        Exchangeasset.Show()
End Sub

Private Sub User_Btn_Click(sender As Object, e As EventArgs) Handles User_Btn.Click
        Manageuser.Show()
End Sub

Private Sub Totalasset_Label_Click(sender As Object, e As EventArgs) Handles Totalasset_Label.Click
        Dim Reader As SqlDataReader
        Dim A As Integer
        Con.Open()
        Dim sql = "Select COUNT(*) From Device"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)

        Reader = cmd.ExecuteReader
        Reader.Read()
        A = Reader.Item(0)

        Totalasset_Label.Text = A
        Con.Close()
    End Sub

Private Sub Totallab_Label_Click(sender As Object, e As EventArgs) Handles Totallab_Label.Click
        Dim Reader1 As SqlDataReader
        Dim L As Integer
        Con.Open()
        Dim sql1 = "Select COUNT(*) From Lab"
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(sql1, Con)

        Reader1 = cmd1.ExecuteReader
        Reader1.Read()
       L = Reader1.Item(0)
        Totallab_Label.Text = L
        Con.Close()
End Sub
Private Sub TotalExg_Label_Click(sender As Object, e As EventArgs) Handles TotalExg_Label.Click
        Dim Reader2 As SqlDataReader
        Dim Ex As Integer
        Con.Open()
        Dim sql2 = "Select COUNT(*) From Exchangetable"
        Dim cmd2 As SqlCommand
        cmd2 = New SqlCommand(sql2, Con)

        Reader2 = cmd2.ExecuteReader
        Reader2.Read()
       Ex = Reader2.Item(0)
        TotalExg_Label.Text = Ex
        Con.Close()
End Sub
Private Sub Totaluser_Label_Click(sender As Object, e As EventArgs) Handles Totaluser_Label.Click
        Dim Reader3 As SqlDataReader
        Dim U As Integer
        Con.Open()
        Dim sql3 = "Select COUNT(*) From LoginForm"
        Dim cmd3 As SqlCommand
        cmd3 = New SqlCommand(sql3, Con)
        Reader3 = cmd3.ExecuteReader
        Reader3.Read()
        U = Reader3.Item(0)
        Totaluser_Label.Text = U
        Con.Close()
End Sub

Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reader As SqlDataReader
        Dim NUM As Integer
        Con.Open()
        Dim sql = "Select COUNT(*) From Device"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)

        Reader = cmd.ExecuteReader
        Reader.Read()

        NUM = Reader.Item(0)

        Totalasset_Label.Text = NUM
        Con.close()

        Dim Reader1 As SqlDataReader
        Dim NUM1 As Integer
        Con.open()
        Dim sql1 = "Select COUNT(*) From Lab"
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(sql1, Con)

        Reader1 = cmd1.ExecuteReader
        Reader1.Read()
        NUM1 = Reader1.Item(0)
        Totallab_Label.Text = NUM1
        Con.close()

        Dim Reader2 As SqlDataReader
        Dim NUM2 As Integer
        Con.open()
        Dim sql2 = "Select COUNT(*) From Exchangetable"
        Dim cmd2 As SqlCommand
        cmd2 = New SqlCommand(sql2, Con)
        Reader2 = cmd2.ExecuteReader
        Reader2.Read()
        NUM2 = Reader2.Item(0)

        TotalExg_Label.Text = NUM2
        Con.close()

        Dim Reader3 As SqlDataReader
        Dim NUM3 As Integer
        Con.open()
        Dim sql3 = "Select COUNT(*) From LoginForm"
        Dim cmd3 As SqlCommand
        cmd3 = New SqlCommand(sql3, Con)
        Reader3 = cmd3.ExecuteReader
        Reader3.Read()

        NUM3 = Reader3.Item(0)
        Totaluser_Label.Text = NUM3
        Con.Close()
End Sub

Private Sub QRGenerate_btn_Click(sender As Object, e As EventArgs) Handles QRGenerate_btn.Click
        QRCodeGeneration.Show()
End Sub

Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Loginform.Close()
End Sub
End Class

