Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ETF
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\EmployeeM.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim cmdinsert As New OleDbCommand

    Dim query As String
    Dim query4 As String
    Private Sub ETF_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Maintenance.Show()
    End Sub

    Private Sub ETF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (mycon.State = ConnectionState.Open) Then
                mycon.Close()
            Else
                Dim value As Integer

                mycon.Open()

                'TextBox2.Text = count


                If (String.IsNullOrWhiteSpace(TextBox2.Text)) Then
                    MessageBox.Show("Please Enter Employee Rate Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox3.Text)) Then
                    MessageBox.Show("Please Enter OT rate Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)




                ElseIf (Not IsNumeric(TextBox2.Text)) Then
                    If value > 0 AndAlso value < 4000 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Employee rate Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox3.Text)) Then
                    If value > 0 AndAlso value < 8 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For OT rate Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

                Dim com1 As String

                com1 = ComboBox1.SelectedItem.ToString
                Try
                    Dim ds As New DataSet

                    Dim relation As DataRelation
                    Dim table1Column As DataColumn
                    Dim table2Column As DataColumn
                    Dim adapter As New SqlDataAdapter

                    'retrieve column
                    table1Column = ds.Tables("employee").Columns(0)
                    table2Column = ds.Tables("otdata").Columns(0)
                    'relating tables
                    relation = New DataRelation("relation", table1Column, table2Column)
                    'assign relation to dataset
                    ds.Relations.Add(relation)

                    MsgBox("Data relation completed")
                Catch s As Exception
                    MsgBox("hello")
                End Try
                Try

                    cmdinsert.CommandText = "INSERT INTO etfdata VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & com1 & "','" & TextBox3.Text & "')"
                    cmdinsert.CommandType = CommandType.Text
                    cmdinsert.Connection = mycon
                    cmdinsert.ExecuteNonQuery()
                    MsgBox("Memeber ETF Records Added To The System", MsgBoxStyle.Information)


                    mycon.Close()

                Catch ex As Exception
                    MsgBox("Some Of Your Inserted Values Are Already Exisist", MsgBoxStyle.Information)
                    'MsgBox(ex.Message, MsgBoxStyle.Information)
                    mycon.Close()
                End Try

            End If
        Catch ec As Exception
            'MsgBox("Database Connection Error Occured ", MsgBoxStyle.Information)
            MsgBox(ec.Message, MsgBoxStyle.Information)
        End Try
        mycon.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        EmpSearch.Show()

    End Sub
End Class