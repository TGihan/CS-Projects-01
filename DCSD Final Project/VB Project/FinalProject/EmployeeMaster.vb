Imports System.Data
Imports System.Data.OleDb
Public Class EmployeeMaster
    Dim con As String = "provider=Microsoft.ACE.OLEDB.12.0;Data source=F:\access databases\EmployeeM.accdb"
    Dim mycon As New OleDbConnection(con)
    Dim cmdinsert As New OleDbCommand

    Dim query As String
    Dim query4 As String
    Private Sub EmployeeMaster_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Maintenance.Show()
    End Sub
    Dim count As Integer
    Private Sub countcal()
        If (mycon.State = ConnectionState.Open) Then
            mycon.Close()
        Else
            mycon.Open()
            Try

                Dim countm As New OleDbCommand
                countm.CommandText = "SELECT COUNT(Emp_No) FROM employee"
                countm.CommandType = CommandType.Text
                countm.Connection = mycon
                countm.ExecuteNonQuery()

                Dim rdr4 As OleDbDataReader = countm.ExecuteReader

                While (rdr4.Read)
                    TextBox2.Text = rdr4(0) + 1
                End While

            Catch dd As Exception
                MsgBox(dd.Message)
            End Try
        End If
        mycon.Close()
    End Sub

    Private Sub EmployeeMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        countcal()
        defaulter()
    End Sub
    Private Sub defaulter()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        RadioButton1.Select()
        TextBox9.Text = ""
        ComboBox1.SelectedIndex = 0
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        ComboBox2.SelectedIndex = 0
        TextBox15.Text = ""
        TextBox16.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Dim sex As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (mycon.State = ConnectionState.Open) Then
                mycon.Close()
            Else
                Dim value As Integer
                countcal()
                mycon.Open()

                'TextBox2.Text = count


                If (String.IsNullOrWhiteSpace(TextBox3.Text)) Then
                    MessageBox.Show("Please Enter First Name Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox4.Text)) Then
                    MessageBox.Show("Please Enter Last Name Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox5.Text)) Then
                    MessageBox.Show("Please Enter Address 1 Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox6.Text)) Then
                    MessageBox.Show("Please Enter Address 2 Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox7.Text)) Then
                    MessageBox.Show("Please Enter NIC Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox9.Text)) Then
                    MessageBox.Show("Please Enter Date Of Birth Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox11.Text)) Then
                    MessageBox.Show("Please Enter Designation Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox12.Text)) Then
                    MessageBox.Show("Please Enter Department Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox13.Text)) Then
                    MessageBox.Show("Please Enter Basic Salry Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox14.Text)) Then
                    MessageBox.Show("Please Enter Date Joined Field ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox15.Text)) Then
                    MessageBox.Show("Please Enter Telephone ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox15.Text)) Then
                    MessageBox.Show("Please Enter Different Telephone ", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf (String.IsNullOrWhiteSpace(TextBox1.Text)) Then
                    MessageBox.Show("Please Enter Bank Account No", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                ElseIf (Not IsNumeric(TextBox7.Text)) Then
                    If value > 0 AndAlso value < 10 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Valid NIC No!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox11.Text)) Then
                    If value > 0 AndAlso value < 1000 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Designation No Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox12.Text)) Then
                    If value > 0 AndAlso value < 5 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Department No Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox13.Text)) Then
                    If value > 0 AndAlso value < 400000 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Basic Salary Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox14.Text)) Then
                    If value > 0 AndAlso value < 8 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Date Joined Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox15.Text)) Then
                    If value > 0 AndAlso value < 10 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Telephone No Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox16.Text)) Then
                    If value > 0 AndAlso value < 10 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Different Telephone No Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                ElseIf (Not IsNumeric(TextBox1.Text)) Then
                    If value > 0 AndAlso value < 1000 Then
                        value = value
                    Else
                        MessageBox.Show("please Enter Number For Valid Bank Account No Field!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else

                    If (RadioButton1.Checked) Then
                        sex = "Male"
                    End If
                    If (RadioButton2.Checked) Then
                        sex = "Female"
                    End If

                    Dim com1 As String
                    Dim com2 As String
                    com1 = ComboBox1.SelectedItem.ToString
                    com2 = ComboBox2.SelectedItem.ToString

                    Try

                        cmdinsert.CommandText = "INSERT INTO employee VALUES('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & sex & "','" & TextBox9.Text & "','" & com1 & "','" & TextBox11.Text & "','" & TextBox11.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & com2 & "','" & TextBox16.Text & "','" & TextBox15.Text & "','" & TextBox1.Text & "')"
                        cmdinsert.CommandType = CommandType.Text
                        cmdinsert.Connection = mycon
                        cmdinsert.ExecuteNonQuery()
                        MsgBox("Memeber Records Added To The System", MsgBoxStyle.Information)


                        mycon.Close()
                        countcal()
                        defaulter()
                    Catch ex As Exception
                        MsgBox("Some Of Your Inserted Values Are Already Exisist", MsgBoxStyle.Information)
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                        mycon.Close()
                    End Try

                End If
            End If
        Catch ec As Exception
            MsgBox("Database Connection Error Occured ", MsgBoxStyle.Information)
        End Try
        mycon.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (mycon.State = ConnectionState.Open) Then
            mycon.Close()
        Else
            mycon.Open()
            countcal()
            TextBox2.Text = count

            Dim up As New OleDbCommand
            Dim co As Integer
            Try
                mycon.Open()
                co = TextBox2.Text
                up.CommandText = "DELETE FROM employee WHERE emp_No=" & co & ""
                up.CommandType = CommandType.Text
                up.Connection = mycon
                up.ExecuteNonQuery()

                MsgBox("Record deleted successed", MsgBoxStyle.Information, "Data Delete")
                countcal()
                defaulter()

            Catch rt As Exception
                MsgBox(rt.Message)
            End Try


            'query4 = "SELECT * FROM reader "

            'Dim myadp4 As New OleDbDataAdapter(query4, mycon)
            'Dim ds4 As New DataTable
            'myadp4.Fill(ds4)
            'Dim dv4 As New DataView(ds4)
            'DataGridView1.DataSource = dv4
            mycon.Close()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
        EmpSearch.Show()
        countcal()
        defaulter()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (mycon.State = ConnectionState.Open) Then
            mycon.Close()
        Else
            mycon.Open()
            countcal()

            Dim com1 As String
            Dim com2 As String
            com1 = ComboBox1.SelectedItem.ToString
            com2 = ComboBox2.SelectedItem.ToString
            Try
                mycon.Open()
                Dim up As New OleDbCommand
                up.CommandText = "UPDATE employee SET First_Name='" & TextBox3.Text & "',Last_Name='" & TextBox4.Text & "',Address_1='" & TextBox5.Text & "',Address_2='" & TextBox6.Text & "',NIC='" & TextBox7.Text & "',Sex='" & sex & "',Date_Of_Birth='" & TextBox9.Text & "',Marriage='" & com1 & "',Designation='" & TextBox11.Text & "',Department='" & TextBox12.Text & "',Basic_Salary='" & TextBox13.Text & "',Joined='" & TextBox14.Text & "',Status='" & com2 & "',Tel_1='" & TextBox16.Text & "',Tel_2='" & TextBox15.Text & "',Bank_Acc='" & TextBox1.Text & "' WHERE Emp_No=" & TextBox2.Text & ""
                up.CommandType = CommandType.Text
                up.Connection = mycon
                up.ExecuteNonQuery()


                MsgBox("Record Update Successed", MsgBoxStyle.Information, "Modify Record")
                countcal()
                defaulter()
            Catch er As Exception
                MsgBox(er.Message)
            End Try
            'Dim myadp As New OleDbDataAdapter(query4, mycon)
            'Dim ds As New DataTable
            'myadp.Fill(ds)
            'Dim dv As New DataView(ds)
            'DataGridView1.DataSource = dv

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Maintenance.Show()
    End Sub
End Class