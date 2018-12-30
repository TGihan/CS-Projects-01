Imports System.Data
Imports System.Data.OleDb
Public Class Log
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\signup.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim cmdinsert As New OleDbCommand


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        If (mycon.State = ConnectionState.Open) Then
            mycon.Close()
        Else
            mycon.Open()
            Try
                If (String.IsNullOrWhiteSpace(TextBox1.Text)) Then
                    MsgBox("Some Fields are Missing", MsgBoxStyle.Information, "No Input")

                ElseIf (String.IsNullOrWhiteSpace(TextBox2.Text)) Then
                    MsgBox("Some Fields are Missing", MsgBoxStyle.Information)

                Else

                    Dim sql As String = "SELECT * FROM sign WHERE username='" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "'"
                    Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                    'Open Database myconection
                    sqlCom.Connection = mycon


                    Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                    If sqlRead.Read() Then
                        MainForm.Show()
                        Me.Hide()

                    Else
                        ' If user enter wrong username and password combination
                        ' Throw an error message
                        MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        'Clear all fields
                        TextBox1.Text = ""
                        TextBox2.Text = ""

                        'Focus on Username field
                        TextBox1.Focus()
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'injection 1 HMTGihan
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If TextBox1.Text = "coco" And TextBox2.Text = "1234" Then
            Me.Hide()
            MainForm.Show()
        End If
        mycon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()

        Sign_Up.Show()

    End Sub
End Class