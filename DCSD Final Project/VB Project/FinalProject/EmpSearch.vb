Imports System.Data.OleDb
Public Class EmpSearch
    Dim query4 As String
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\EmployeeM.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim updateb As New OleDbCommand
    Dim co As String
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
       
    End Sub

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
                    DataGridView1.Columns(4).Width = 110
                    DataGridView1.Columns(5).Width = 70
                    DataGridView1.Columns(6).Width = 40
                    DataGridView1.Columns(7).Width = 80
                    DataGridView1.Columns(8).Width = 60
                    DataGridView1.Columns(9).Width = 70
                    DataGridView1.Columns(10).Width = 70
                    DataGridView1.Columns(11).Width = 70
                    DataGridView1.Columns(12).Width = 60
                    DataGridView1.Columns(13).Width = 60
                    DataGridView1.Columns(14).Width = 70
                    DataGridView1.Columns(15).Width = 70
                    DataGridView1.Columns(16).Width = 110

                End If
            End If


        Catch ds As Exception
            'MsgBox(ds.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17 As String

        c1 = DataGridView1.SelectedCells.Item(0).Value.ToString
        c2 = DataGridView1.SelectedCells.Item(1).Value.ToString
        c3 = DataGridView1.SelectedCells.Item(2).Value.ToString
        c4 = DataGridView1.SelectedCells.Item(3).Value.ToString
        c5 = DataGridView1.SelectedCells.Item(4).Value.ToString
        c6 = DataGridView1.SelectedCells.Item(5).Value.ToString
        c7 = DataGridView1.SelectedCells.Item(6).Value.ToString
        c8 = DataGridView1.SelectedCells.Item(7).Value.ToString
        c9 = DataGridView1.SelectedCells.Item(8).Value.ToString
        c10 = DataGridView1.SelectedCells.Item(9).Value.ToString
        c11 = DataGridView1.SelectedCells.Item(10).Value.ToString
        c12 = DataGridView1.SelectedCells.Item(11).Value.ToString
        c13 = DataGridView1.SelectedCells.Item(12).Value.ToString
        c14 = DataGridView1.SelectedCells.Item(13).Value.ToString
        c15 = DataGridView1.SelectedCells.Item(14).Value.ToString
        c16 = DataGridView1.SelectedCells.Item(15).Value.ToString
        c17 = DataGridView1.SelectedCells.Item(16).Value.ToString


        'co = e.ColumnIndex().ToString
        EmployeeMaster.TextBox2.Text = c1
        EmployeeMaster.TextBox3.Text = c2
        EmployeeMaster.TextBox4.Text = c3
        EmployeeMaster.TextBox5.Text = c4
        EmployeeMaster.TextBox6.Text = c5
        EmployeeMaster.TextBox7.Text = c6
        If (c7 = "Male") Then
            EmployeeMaster.RadioButton1.Select()

        Else
            EmployeeMaster.RadioButton2.Select()
        End If
        EmployeeMaster.TextBox9.Text = c8
        If (c9 = "Single") Then
            EmployeeMaster.ComboBox1.SelectedIndex = 0

        Else
            EmployeeMaster.ComboBox1.SelectedIndex = 1
        End If
        EmployeeMaster.TextBox11.Text = c10
        EmployeeMaster.TextBox12.Text = c11
        EmployeeMaster.TextBox13.Text = c12
        EmployeeMaster.TextBox14.Text = c13
        If (c14 = "Manager") Then
            EmployeeMaster.ComboBox2.SelectedIndex = 0

        ElseIf (c14 = "Assistent") Then
            EmployeeMaster.ComboBox2.SelectedIndex = 1
        End If
        EmployeeMaster.TextBox16.Text = c15
        EmployeeMaster.TextBox15.Text = c16
        EmployeeMaster.TextBox1.Text = c17

        ETF.TextBox1.Text = c1


        Me.Hide()
        'MainForm.Show()
        EmployeeMaster.Show()
    End Sub

    Private Sub EmpSearch_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        EmployeeMaster.Show()
    End Sub

    Private Sub EmpSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class