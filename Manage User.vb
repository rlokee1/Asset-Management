Imports System.Data.SqlClient
Public Class Manageuser
    Dim Con = New SqlConnection("Persist Security Info=False;User ID=sa;pwd=Lokee2,,,9;Initial Catalog=AssetManagementSystem;Data Source=LOKEELEGEND\ASSETSQL")
Private Sub populate()

        Dim query As String = "Select * from LoginForm"
        Using cmd As SqlCommand = New SqlCommand(query, Con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dtgmanageuser.DataSource = dt
                End Using
            End Using
        End Using
End Sub

Private Sub Manageuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssetManagementSystemmanageuser.LoginForm' table. You can move, or remove it, as needed.
        Me.LoginFormTableAdapter1.Fill(Me.AssetManagementSystemmanageuser.LoginForm)

End Sub

Private Sub dtgmanageuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgmanageuser.CellContentClick
        Dim row As DataGridViewRow = dtgmanageuser.Rows(e.RowIndex)

        usrname_txtbox.Text = row.Cells(0).Value.ToString
        Pwd_txtbox.Text = row.Cells(1).Value.ToString

        If usrname_txtbox.Text = "" Then
            key = 0
        Else
            key = Convert.ToString(row.Cells(0).Value.ToString)
        End If
End Sub

Private Sub User_Backbtn_Click(sender As Object, e As EventArgs) Handles User_Backbtn.Click
        Me.Close()
End Sub

Private Sub User_SaveBtn_Click(sender As Object, e As EventArgs) Handles User_SaveBtn.Click
        If usrname_txtbox.Text = "" Or Pwd_txtbox.Text = "" Then
            MsgBox("Please Input Username and Password...!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Insert into LoginForm Values('" & usrname_txtbox.Text & "','" & Pwd_txtbox.Text & "')"
                Dim Cmd As SqlCommand
                Cmd = New SqlCommand(query, Con)
                Cmd.ExecuteNonQuery()
                Con.Close()
                populate()
                Reset()
            Catch ex As Exception
                MsgBox("This User has already entered...", MsgBoxStyle.Exclamation)
            End Try

        End If
End Sub
Dim key = 0

Private Sub Mgeuser_Delbtn_Click(sender As Object, e As EventArgs) Handles Mgeuser_Delbtn.Click
Dim Cmd As SqlCommand = New SqlCommand("Delete from LoginForm WHERE Username = '" & usrname_txtbox.Text & "'", Con)
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        populate()
End Sub
End Class

