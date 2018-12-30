Imports System.Data
Imports System.Data.OleDb
Public Class Sign_Up
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\signup.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim cmdinsert As New OleDbCommand

    Private Sub Sign_Up_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Log.Show()

    End Sub
    Private Sub Sign_Up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (mycon.State = ConnectionState.Open) Then
            mycon.Close()
        Else
            mycon.Open()
            Try
                If (String.IsNullOrWhiteSpace(TextBox1.Text)) Then
                    MsgBox("Field Missing", MsgBoxStyle.Information)

                ElseIf (String.IsNullOrWhiteSpace(TextBox2.Text)) Then
                    MsgBox("Field Missing", MsgBoxStyle.Information)

                Else
                    Try

                        cmdinsert.CommandText = "INSERT INTO sign VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "')"
                        cmdinsert.CommandType = CommandType.Text
                        cmdinsert.Connection = mycon
                        cmdinsert.ExecuteNonQuery()
                        MsgBox("Signup Completed Memeber Added To The System", MsgBoxStyle.Information)
                        mycon.Close()
                    Catch ex As Exception
                        MsgBox("Some Of Your Inserted Values Are Already Exisist", MsgBoxStyle.Information)
                        mycon.Close()
                    End Try

                End If
            Catch er As Exception
                MsgBox("Database Connection Error Occured ", MsgBoxStyle.Information)
            End Try
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Log.Show()
    End Sub
End Class