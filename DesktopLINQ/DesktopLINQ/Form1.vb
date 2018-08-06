Imports DesktopLINQ.Context

Public Class CityBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim x As DataClasses1DataContext = New DataClasses1DataContext()


        Dim query = From person In x.Persons
                    Select person

        DataGridView1.DataSource = query
        MessageBox.Show("This is Working")




        x.Dispose()


    End Sub

    Private Sub CityBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TvsDataSet1.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter1.Fill(Me.TvsDataSet1.Person)
        'TODO: This line of code loads data into the 'TvsDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.TvsDataSet.Person)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sno = SnoBox.Text
        Dim Name = NameBox.Text
        Dim city = CityTxt.Text
        Dim Message = ""


        If Not IsNumeric(Sno) Then

            Message += " Sno Must be Number "

        End If

        If Sno.Length = 0 Then
            Message += " Please Enter Sno "

        End If

        If Name.Length < 3 Then
            Message += " Please Enter Name "
        End If

        If city.Length < 2 Then
            Message += " Please Enter City"
        End If

        If Message.Length > 1 Then
            MessageBox.Show(Message)


        Else
            Dim x As DataClasses1DataContext = New DataClasses1DataContext()

            Dim p As Person = New Person()

            p.Sno = Sno
            p.Name = Name
            p.City = city

            x.Persons.InsertOnSubmit(p)

            Try
                x.SubmitChanges()
                MessageBox.Show("Added")

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
                MessageBox.Show("Operation Failure")
            End Try



            UpdateGrid()
            x.Dispose()


        End If


    End Sub

    Private Sub SnoBox_TextChanged(sender As Object, e As EventArgs) Handles SnoBox.TextChanged
        Dim x As DataClasses1DataContext = New DataClasses1DataContext()
        Try
            Dim p As Person =
                x.Persons.Single(Function(temp As Person) temp.Sno = SnoBox.Text)
            NameBox.Text = p.Name
            CityTxt.Text = p.City

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As DataClasses1DataContext = New DataClasses1DataContext()
        Try
            Dim Sno = SnoBox.Text
            Dim Name = NameBox.Text
            Dim city = CityTxt.Text
            Dim Message = ""

            If Not IsNumeric(Sno) Then

                Message += " Sno Must be Number "

            End If

            If Sno.Length = 0 Then
                Message += " Please Enter Sno "

            End If

            If Name.Length < 3 Then
                Message += " Please Enter Name "
            End If

            If city.Length < 2 Then
                Message += " Please Enter City"
            End If

            If Message.Length > 1 Then
                MessageBox.Show(Message)


            Else
                Dim p As Person = x.Persons.Single(Function(temp As Person) temp.Sno = SnoBox.Text)
                p.Name = NameBox.Text
                p.City = CityTxt.Text
                x.SubmitChanges()

                MessageBox.Show("Record Updated")
                UpdateGrid()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As DataClasses1DataContext = New DataClasses1DataContext()
        Try
            Dim p As Person = x.Persons.Single(Function(temp As Person) temp.Sno = SnoBox.Text)
            x.Persons.DeleteOnSubmit(p)

            x.SubmitChanges()
            UpdateGrid()

        Catch ex As Exception
            MessageBox.Show("Please check whether sno exists")

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As DataClasses1DataContext = New DataClasses1DataContext()
        Dim query = From person In x.Persons Join employees In x.Employees
                        On person.Sno Equals employees.Sno
                    Select New With {
                        .Sno = person.Sno,
                        .Name = person.Name,
                        .City = person.City,
                        .Designation = employees.Designation,
                        .Income = employees.AnnualIncome
                     }

        DataGridView1.DataSource = query

    End Sub
    Sub UpdateGrid()
        Dim x As DataClasses1DataContext = New DataClasses1DataContext()

        Dim query = From person In x.Persons
                    Select person

        DataGridView1.DataSource = query
    End Sub
End Class

