Imports System.Data.OleDb
Imports System.Data

Public Class Form4

    Private Sub FormDragDrop_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Form2.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form3.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        DateTimePicker1.Value = DateTime.Now
        Dim roomtype As String
        Dim check_in As String
        Dim n As Integer
        Dim person As Integer
        Dim res As Integer
        Dim total As Integer
        Dim room As Integer
        Dim internet As Integer
        Dim travel As Integer
        Dim r As String
        Dim t As String
        Dim i1 As String
        i1 = vbNull
        Dim f As Integer
        f = 0
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter the customer H-ID no first")
        Else

            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim s1 As String
                s1 = "select hid from hotel_paradise where hid='" + TextBox1.Text + "'and flag =1"
                Dim com1 As New OleDbCommand(s1, con1)
                i1 = com1.ExecuteScalar
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If TextBox1.Text = i1 Then
                Try
                    Dim con1 As New OleDb.OleDbConnection
                    con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                    con1.Open()

                    t = DateTimePicker1.Value.ToShortDateString
                    Dim s1 As String
                    s1 = "update hotel_paradise set check_out='" + t + "' where hid='" + TextBox1.Text + "'and flag=1"
                    Dim com1 As New OleDbCommand(s1, con1)
                    com1.ExecuteNonQuery()
                    Dim s3 As String
                    s3 = "select room from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com3 As New OleDbCommand(s3, con1)
                    r = com3.ExecuteScalar()
                    If r = "GF-1" Then
                        Dim s4 As String
                        s4 = "update hr set r1=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "GF-2" Then
                        Dim s4 As String
                        s4 = "update hr set r2=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "GF-3" Then
                        Dim s4 As String
                        s4 = "update hr set r3=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "GF-4" Then
                        Dim s4 As String
                        s4 = "update hr set r4=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "GF-5" Then
                        Dim s4 As String
                        s4 = "update hr set r5=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "GF-6" Then
                        Dim s4 As String
                        s4 = "update hr set r6=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-7" Then
                        Dim s4 As String
                        s4 = "update hr set r7=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-8" Then
                        Dim s4 As String
                        s4 = "update hr set r8=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-9" Then
                        Dim s4 As String
                        s4 = "update hr set r9=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-10" Then
                        Dim s4 As String
                        s4 = "update hr set r10=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-11" Then
                        Dim s4 As String
                        s4 = "update hr set r11=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "FF-12" Then
                        Dim s4 As String
                        s4 = "update hr set r12=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-13" Then
                        Dim s4 As String
                        s4 = "update hr set r13=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-14" Then
                        Dim s4 As String
                        s4 = "update hr set r14=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-15" Then
                        Dim s4 As String
                        s4 = "update hr set r15=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-16" Then
                        Dim s4 As String
                        s4 = "update hr set r16=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-17" Then
                        Dim s4 As String
                        s4 = "update hr set r17=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    If r = "SF-18" Then
                        Dim s4 As String
                        s4 = "update hr set r18=0"
                        Dim com4 As New OleDbCommand(s4, con1)
                        com4.ExecuteNonQuery()
                    End If
                    Dim s11 As String
                    s11 = "select check_in from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com11 As New OleDbCommand(s11, con1)
                    check_in = com11.ExecuteScalar

                    If check_in = t Then
                        n = 1
                    Else
                        Dim s As String
                        s = "select trunc((((86400*(check_out-check_in))/60)/60)/24)from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                        Dim com As New OleDbCommand(s, con1)
                        n = com.ExecuteScalar
                    End If
                    Console.WriteLine(n)
                    Dim s5 As String
                    s5 = "select res from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com5 As New OleDbCommand(s5, con1)

                    res = com5.ExecuteScalar
                    Dim s6 As String
                    s6 = "select internet from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com6 As New OleDbCommand(s6, con1)

                    internet = com6.ExecuteScalar
                    Dim s7 As String
                    s7 = "select travel from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com7 As New OleDbCommand(s7, con1)

                    travel = com7.ExecuteScalar
                    Dim s8 As String
                    s8 = "select room from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com8 As New OleDbCommand(s8, con1)
                    roomtype = com8.ExecuteScalar

                    If roomtype = "GF-1" Or roomtype = "GF-2" Or roomtype = "GF-3" Then
                        room = 500
                    End If
                    If roomtype = "GF-4" Or roomtype = "GF-5" Or roomtype = "GF-6" Then
                        room = 1000
                    End If
                    If roomtype = "FF-7" Or roomtype = "FF-8" Or roomtype = "FF-9" Then
                        room = 1500
                    End If
                    If roomtype = "FF-10" Or roomtype = "FF-11" Or roomtype = "FF-12" Then
                        room = 750
                    End If
                    If roomtype = "SF-13" Or roomtype = "SF-14" Or roomtype = "SF-15" Then
                        room = 500
                    End If
                    If roomtype = "SF-16" Or roomtype = "SF-17" Or roomtype = "SF-18" Then
                        room = 250
                    End If
                    total = res + travel + internet + (n * room)
                    Label3.Text = total
                    Dim s25 As String
                    s25 = "select n1 from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com25 As New OleDbCommand(s25, con1)
                    Label14.Text = com25.ExecuteScalar
                    Dim s9 As String
                    s9 = "update hotel_paradise set amt= '" + Label3.Text + "'  where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com9 As New OleDbCommand(s9, con1)
                    com9.ExecuteNonQuery()
                    Dim s10 As String
                    s10 = "select person from hotel_paradise where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com10 As New OleDbCommand(s10, con1)
                    person = com10.ExecuteScalar
                    Label5.Text = person
                    Dim s2 As String
                    s2 = "update hotel_paradise set flag=0 where hid='" + TextBox1.Text + "' and flag=1"
                    Dim com2 As New OleDbCommand(s2, con1)
                    com2.ExecuteNonQuery()
                    f = 1
                    Label7.Text = room
                    Label8.Text = travel
                    Label9.Text = internet
                    LABEL10.TEXT = res
                    Label6.Text = i1
                    Label11.Text = t
                    Label12.Text = check_in
                    Label13.Text = roomtype
                    con1.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If f = 1 Then
                MessageBox.Show("                   HOTEL PARADISE" + vbNewLine + vbNewLine + vbNewLine + "Check out Bill" + vbNewLine + "HOTEL ID NO -> " + Label6.Text + vbNewLine + vbNewLine + "NAME -> " + Label14.Text + vbNewLine + vbNewLine + "ROOM NO -> " + Label13.Text + vbNewLine + vbNewLine + "NO OF PERSON -> " + Label5.Text + vbNewLine + vbNewLine + "CHECK IN DATE -> " + Label12.Text + vbNewLine + vbNewLine + "CHECK OUT DATE -> " + Label11.Text + vbNewLine + vbNewLine + "Room charge -> " + Label7.Text + vbNewLine + vbNewLine + "Internet usage charge -> " + Label9.Text + vbNewLine + vbNewLine + "Travel desk charge -> " + Label8.Text + vbNewLine + vbNewLine + "Fooding charge -> " + Label10.Text + vbNewLine + vbNewLine + "Total bill -> " + Label3.Text + vbNewLine + vbNewLine + "                          Thanks")
                TextBox1.Clear()
            ElseIf f = 0 Then
                MessageBox.Show("Invalid customer id")
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Clear()
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form5.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now

    End Sub

  
   
End Class