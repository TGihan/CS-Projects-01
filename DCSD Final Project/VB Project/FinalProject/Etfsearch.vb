Imports System.Data.OleDb

Public Class Etfsearch
    Dim query4 As String
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\EmployeeM.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim updateb As New OleDbCommand
    Dim co As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If (mycon.State = ConnectionState.Open) Then
                mycon.Close()
            Else
                mycon.Open()

                If (Not IsNumeric(TextBox2.Text)) Then

                    MessageBox.Show("Please Enter Employee Number!", "Invaid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Try
                        query4 = "SELECT * FROM employee WHERE emp_No =" & TextBox2.Text & " "

                        Dim myadp4 As New OleDbDataAdapter(query4, mycon)
                        Dim ds4 As New DataTable
                        myadp4.Fill(ds4)

                        Dim dv4 As New DataView(ds4)
                        DataGridView1.DataSource = dv4
                    Catch fg As Exception
                        MsgBox("Database Connection Error")
                    End Try

                    DataGridView1.Columns(0).Width = 60
                    DataGridView1.Columns(1).Width = 110
                    DataGridView1.Columns(2).Width = 110
                    DataGridView1.Columns(3).Width = 110
                    

                End If
            End If


        Catch ds As Exception
            'MsgBox(ds.Message)
        End Try
    End Sub

    Private Sub Etfsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim c1, c2, c3, c4 As String

        c1 = DataGridView1.SelectedCells.Item(0).Value.ToString
        c2 = DataGridView1.SelectedCells.Item(1).Value.ToString
        c3 = DataGridView1.SelectedCells.Item(2).Value.ToString
        c4 = DataGridView1.SelectedCells.Item(3).Value.ToString
       


        'co = e.ColumnIndex().ToString
        ETF.TextBox1.Text = c1
        ETF.TextBox2.Text = c2
        If (c3 = "January") Then
            ETF.ComboBox1.SelectedIndex = 0

        ElseIf (c3 = "March") Then
            ETF.ComboBox1.SelectedIndex = 1
        End If
        ETF.TextBox3.Text = c4
        
    End Sub
End Class