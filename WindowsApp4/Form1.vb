Public Class Form1
    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database3DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database3DataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.png;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PhotoPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo SaveError
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database3DataSet)
        MsgBox("Your Ragistration Completed Successfully")
        Table1BindingSource.AddNew()

SaveError:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource.AddNew()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Last_nameTextBox.Clear()
        AgeTextBox.Clear()
        Mobile_numberTextBox.Clear()
        EmailTextBox.Clear()
        PincodeTextBox.Clear()
        StateComboBox.Text = "Select State"
        CountryComboBox.Text = "Select Country"
        CityComboBox.Text = "Select City"
        Sports_NameComboBox.Text = "Select Sports"
    End Sub

    Private Sub CountryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CountryComboBox.SelectedIndexChanged
        StateComboBox.Items.Clear()
        If CountryComboBox.Text = "India" Then
            StateComboBox.Items.Add("Maharashtra")
            StateComboBox.Items.Add("Goa")
            StateComboBox.Items.Add("Gujarat")
        Else
            StateComboBox.Items.Add("")
        End If
    End Sub

    Private Sub StateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateComboBox.SelectedIndexChanged
        If StateComboBox.Text = "Maharashtra" Then
            CityComboBox.Items.Add("Mumbai")
            CityComboBox.Items.Add("Pune")
            CityComboBox.Items.Add("Nashik")
            CityComboBox.Items.Add("Nagpur")
        Else
            CityComboBox.Items.Add("")
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        If Not IsNumeric(AgeTextBox.Text) Then
            ErrorProvider1.SetError(AgeTextBox, "this field contains integer value only")

        End If
    End Sub
    Private Sub Tex_TextChanged(sender As Object, e As EventArgs) Handles Mobile_numberTextBox.TextChanged
        If Not IsNumeric(Mobile_numberTextBox.Text) Then
            ErrorProvider1.SetError(Mobile_numberTextBox, "this field contains integer value only")

        End If
    End Sub

End Class
