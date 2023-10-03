'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.

Imports System.Data.SqlClient
Public Class Loginform

Private Sub Login_Btn_Click(sender As Object, e As EventArgs) Handles Login_Btn.Click
        Dim con As SqlConnection = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")
        Dim cmd As SqlCommand = New SqlCommand("Select * From LoginForm where Username=@Username And Password=@Password", con)

        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = User_txtBox.Text
        cmd.Parameters.Add("@Password", SqlDbType.NChar).Value = Pass_txtbox.Text

        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim table As DataTable = New DataTable()
        sda.Fill(table)
        If (table.Rows.Count > 0) Then
            Dashboard.Show()
        Else
            MessageBox.Show("Invalid", "informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
End Sub
Private Sub User_txtBox_previewkeydown(sender As Object, e As KeyEventArgs) Handles User_txtBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Pass_txtbox.Focus()
        End If
End Sub

Private Sub Pass_txtbox_keydown(sender As Object, e As KeyEventArgs) Handles Pass_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_Btn.PerformClick()
        End If
End Sub

Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        Me.Close()
End Sub
End Class


Imports System.Data.SqlClient
Public Class Loginform

Private Sub Login_Btn_Click(sender As Object, e As EventArgs) Handles Login_Btn.Click
        Dim con As SqlConnection = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")
        Dim cmd As SqlCommand = New SqlCommand("Select * From LoginForm where Username=@Username And Password=@Password", con)

        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = User_txtBox.Text
        cmd.Parameters.Add("@Password", SqlDbType.NChar).Value = Pass_txtbox.Text

        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim table As DataTable = New DataTable()
        sda.Fill(table)
        If (table.Rows.Count > 0) Then
            Dashboard.Show()
        Else
            MessageBox.Show("Invalid", "informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
End Sub
Private Sub User_txtBox_previewkeydown(sender As Object, e As KeyEventArgs) Handles User_txtBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Pass_txtbox.Focus()
        End If
End Sub

Private Sub Pass_txtbox_keydown(sender As Object, e As KeyEventArgs) Handles Pass_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_Btn.PerformClick()
        End If
End Sub

Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        Me.Close()
End Sub
End Class
