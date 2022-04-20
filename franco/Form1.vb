Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Form1


    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "X54D3XzMXBGUtmNWcrovnVe5s6t6aC2VJlDXSMgs",
        .BasePath = "https://dbfranco-ad568-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click, DataGridView1.Click

        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("There was an isssue in the internet connection")

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox11.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox12.Text = Val(TextBox11.Text) / 10
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim grand As Double
        grand = TextBox12.Text
        Select Case grand
            Case 0 To 49
                TextBox25.Text = "E"
            Case 50 To 59
                TextBox25.Text = "D"
            Case 60 To 69
                TextBox25.Text = "C"
            Case 70 To 79
                TextBox25.Text = "B"
            Case 80 To 100
                TextBox25.Text = "A"


        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("DO you Really want to logout!!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mark As Double
        mark = TextBox1.Text
        Select Case mark
            Case 0 To 49
                TextBox15.Text = "E"
            Case 50 To 59
                TextBox15.Text = "D"
            Case 60 To 69
                TextBox15.Text = "C"
            Case 70 To 79
                TextBox15.Text = "B"
            Case 80 To 100
                TextBox15.Text = "A"

        End Select
        Dim aaa As Double
        aaa = TextBox2.Text
        Select Case aaa
            Case 0 To 49
                TextBox16.Text = "E"
            Case 50 To 59
                TextBox15.Text = "D"
            Case 60 To 69
                TextBox16.Text = "C"
            Case 70 To 79
                TextBox16.Text = "B"
            Case 80 To 100
                TextBox16.Text = "A"
        End Select

        Dim baa As Double
        baa = TextBox3.Text
        Select Case baa
            Case 0 To 49
                TextBox17.Text = "E"
            Case 50 To 59
                TextBox17.Text = "D"
            Case 60 To 69
                TextBox17.Text = "C"
            Case 70 To 79
                TextBox17.Text = "B"
            Case 80 To 100
                TextBox17.Text = "A"

        End Select
        Dim caa As Double
        caa = TextBox4.Text
        Select Case caa
            Case 0 To 49
                TextBox18.Text = "E"
            Case 50 To 59
                TextBox18.Text = "D"
            Case 60 To 69
                TextBox18.Text = "C"
            Case 70 To 79
                TextBox18.Text = "B"
            Case 80 To 100
                TextBox18.Text = "A"
        End Select

        Dim daa As Double
        daa = TextBox5.Text
        Select Case daa
            Case 0 To 49
                TextBox19.Text = "E"
            Case 50 To 59
                TextBox19.Text = "D"
            Case 60 To 69
                TextBox19.Text = "C"
            Case 70 To 79
                TextBox19.Text = "B"
            Case 80 To 100
                TextBox19.Text = "A"

        End Select
        Dim foo As Double
        foo = TextBox6.Text
        Select Case foo
            Case 0 To 49
                TextBox20.Text = "E"
            Case 50 To 59
                TextBox20.Text = "D"
            Case 60 To 69
                TextBox20.Text = "C"
            Case 70 To 79
                TextBox20.Text = "B"
            Case 80 To 100
                TextBox20.Text = "A"

        End Select
        Dim faa As Double
        faa = TextBox7.Text
        Select Case faa
            Case 0 To 49
                TextBox21.Text = "E"
            Case 50 To 59
                TextBox21.Text = "D"
            Case 60 To 69
                TextBox21.Text = "C"
            Case 70 To 79
                TextBox21.Text = "B"
            Case 80 To 100
                TextBox21.Text = "A"
        End Select

        Dim h As Double
        h = TextBox8.Text
        Select Case h
            Case 0 To 49
                TextBox22.Text = "E"
            Case 50 To 59
                TextBox22.Text = "D"
            Case 60 To 69
                TextBox22.Text = "C"
            Case 70 To 79
                TextBox22.Text = "B"
            Case 80 To 100
                TextBox22.Text = "A"

        End Select
        Dim m As Double
        m = TextBox9.Text
        Select Case m
            Case 0 To 49
                TextBox23.Text = "E"
            Case 50 To 59
                TextBox23.Text = "D"
            Case 60 To 69
                TextBox23.Text = "C"
            Case 70 To 79
                TextBox23.Text = "B"
            Case 80 To 100
                TextBox23.Text = "A"
        End Select

        Dim j As Double
        j = TextBox10.Text
        Select Case j
            Case 0 To 49
                TextBox24.Text = "E"
            Case 50 To 59
                TextBox24.Text = "D"
            Case 60 To 69
                TextBox24.Text = "C"
            Case 70 To 79
                TextBox24.Text = "B"
            Case 80 To 100
                TextBox24.Text = "A"

        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""


        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim std As New student() With
            {
            .FullName = TextBox14.Text,
            .Indexn = TextBox13.Text,
            .English = TextBox1.Text,
            .Engg = TextBox15.Text,
            .Math = TextBox2.Text,
            .Mathg = TextBox16.Text,
            .Cre = TextBox3.Text,
            .Creg = TextBox17.Text,
            .Social = TextBox4.Text,
            .Socialg = TextBox18.Text,
            .Geo = TextBox5.Text,
            .Geog = TextBox19.Text,
            .Physic = TextBox6.Text,
            .Physicg = TextBox20.Text,
            .Biology = TextBox7.Text,
            .Biologyg = TextBox21.Text,
            .Ecomm = TextBox8.Text,
            .Ecommg = TextBox22.Text,
            .Engineer = TextBox9.Text,
            .Engineerg = TextBox23.Text,
            .Art = TextBox10.Text,
            .Artg = TextBox24.Text,
            .Score = TextBox11.Text,
            .Average = TextBox12.Text,
            .Finalg = TextBox25.Text
            }
        Dim setter = client.Set("Student/" + TextBox13.Text, std)
        MessageBox.Show("Data Submitted Successfully")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim res = client.Delete("Student/" + TextBox13.Text)
        MessageBox.Show("Record Deleted Successfully.")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim std As New student() With
             {
            .FullName = TextBox14.Text,
            .Indexn = TextBox13.Text,
            .English = TextBox1.Text,
            .Engg = TextBox15.Text,
            .Math = TextBox2.Text,
            .Mathg = TextBox16.Text,
            .Cre = TextBox3.Text,
            .Creg = TextBox17.Text,
            .Social = TextBox4.Text,
            .Socialg = TextBox18.Text,
            .Geo = TextBox5.Text,
            .Geog = TextBox19.Text,
            .Physic = TextBox6.Text,
            .Physicg = TextBox20.Text,
            .Biology = TextBox7.Text,
            .Biologyg = TextBox21.Text,
            .Ecomm = TextBox8.Text,
            .Ecommg = TextBox22.Text,
            .Engineer = TextBox9.Text,
            .Engineerg = TextBox23.Text,
            .Art = TextBox10.Text,
            .Artg = TextBox24.Text,
            .Score = TextBox11.Text,
            .Average = TextBox12.Text,
            .Finalg = TextBox25.Text
            }
        Dim setter = client.Update("Student/" + TextBox13.Text, std)
        MessageBox.Show("Data Updated Successfully")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim res = client.Get("Student/" + TextBox13.Text)
        Dim std As New student()
        std = res.ResultAs(Of student)
        TextBox14.Text = std.FullName
        TextBox13.Text = std.Indexn
        TextBox1.Text = std.English
        TextBox15.Text = std.Engg
        TextBox2.Text = std.Math
        TextBox16.Text = std.Mathg
        TextBox3.Text = std.Cre
        TextBox17.Text = std.Creg
        TextBox4.Text = std.Social
        TextBox18.Text = std.Socialg
        TextBox5.Text = std.Geo
        TextBox19.Text = std.Geog
        TextBox6.Text = std.Physic
        TextBox20.Text = std.Physicg
        TextBox7.Text = std.Biology
        TextBox21.Text = std.Biologyg
        TextBox8.Text = std.Ecomm
        TextBox22.Text = std.Ecommg
        TextBox9.Text = std.Engineer
        TextBox23.Text = std.Engineerg
        TextBox10.Text = std.Art
        TextBox24.Text = std.Artg
        TextBox11.Text = std.Score
        TextBox12.Text = std.Average
        TextBox25.Text = std.Finalg
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
End Class
