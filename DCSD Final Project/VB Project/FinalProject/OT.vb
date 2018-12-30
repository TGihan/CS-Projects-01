Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class OT
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\EmployeeM.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim cmdinsert As New OleDbCommand

    Dim query As String
    Dim query4 As String
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OT_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Maintenance.Show()
    End Sub

    Private Sub OT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        OTsearch.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            If (mycon.State = ConnectionState.Open) Then
                mycon.Close()
            Else
                Dim value As Integer

                mycon.Open()

                'TextBox2.Text = count


                If (String.IsNullOrWhiteSpace(TextBox4.Text)) Then
                    MessageBox.Show("Please Enter Employee Rate Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox5.Text)) Then
                    MessageBox.Show("Please Enter OT rate Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox6.Text)) Then
                    MessageBox.Show("Please Enter Amount Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)





                ElseIf (Not IsNumeric(TextBox4.Text)) Then
                    If value > 0 AndAlso value < 400000 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Employee rate Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox5.Text)) Then
                    If value > 0 AndAlso value < 8 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For OT rate Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox6.Text)) Then
                    If value > 0 AndAlso value < 10 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Amount Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If

                Dim com1 As String

                com1 = ComboBox1.SelectedItem.ToString


                Try

                    cmdinsert.CommandText = "INSERT INTO otdata VALUES('" & TextBox1.Text & "','" & com1 & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
                    cmdinsert.CommandType = CommandType.Text
                    cmdinsert.Connection = mycon
                    cmdinsert.ExecuteNonQuery()
                    MsgBox("Memeber OT Records Added To The System", MsgBoxStyle.Information)


                    mycon.Close()

                Catch ex As Exception
                    MsgBox("Some Of Your Inserted Values Are Already Exisist", MsgBoxStyle.Information)
                    'MsgBox(ex.Message, MsgBoxStyle.Information)
                    mycon.Close()
                End Try

            End If

        Catch ec As Exception
            MsgBox("Database Connection Error Occured ", MsgBoxStyle.Information)
        End Try
        mycon.Close()
    End Sub
End Class