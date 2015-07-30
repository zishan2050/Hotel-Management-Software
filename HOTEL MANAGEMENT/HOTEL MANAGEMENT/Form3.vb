Imports System.Data.OleDb
Imports System.Data

Public Class Form3

    Private Sub FormDragDrop_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
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
        TextBox1.Clear()
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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
                If CheckBox1.CheckState = CheckState.Checked Then
                    Try
                        Dim con1 As New OleDb.OleDbConnection
                        con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                        con1.Open()
                        Dim i As String
                        Dim s1 As String
                        s1 = "select travel from hotel_paradise where hid='" + TextBox1.Text + "'"
                        Dim com1 As New OleDbCommand(s1, con1)
                        i = com1.ExecuteScalar
                        If i = 0 Then
                            i = 1000
                        Else
                            i = i + 1000
                        End If
                        Dim s2 As String
                        s2 = "Update hotel_paradise set travel='" + i + "' where hid='" + TextBox1.Text + "'"
                        Dim com As New OleDbCommand(s2, con1)
                        com.ExecuteNonQuery()
                        con1.Close()
                        f = 1
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If CheckBox2.CheckState = CheckState.Checked Then
                    Try
                        Dim con1 As New OleDb.OleDbConnection
                        con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                        con1.Open()
                        Dim i As String
                        Dim s1 As String
                        s1 = "select internet from hotel_paradise where hid='" + TextBox1.Text + "'"
                        Dim com1 As New OleDbCommand(s1, con1)
                        i = com1.ExecuteScalar
                        If i = 0 Then
                            i = 10
                        Else
                            i = i + 10
                        End If
                        Dim s2 As String
                        s2 = "Update hotel_paradise set internet='" + i + "' where hid='" + TextBox1.Text + "'"
                        Dim com2 As New OleDbCommand(s2, con1)
                        com2.ExecuteNonQuery()
                        con1.Close()
                        f = 1
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If CheckBox3.CheckState = CheckState.Checked Then
                    Try
                        Dim con1 As New OleDb.OleDbConnection
                        con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                        con1.Open()
                        Dim i As String
                        Dim p As String
                        Dim s1 As String
                        s1 = "select res from hotel_paradise where hid='" + TextBox1.Text + "'"
                        Dim com2 As New OleDbCommand(s1, con1)
                        i = com2.ExecuteScalar
                        If i = 0 Then
                            p = ComboBox1.SelectedItem
                            i = p * 150
                        Else
                            i = i + (p * 150)
                        End If
                        Dim s2 As String
                        s2 = "Update hotel_paradise set res='" + i + "' where hid='" + TextBox1.Text + "'"
                        Dim com3 As New OleDbCommand(s2, con1)
                        com3.ExecuteNonQuery()
                        con1.Close()
                        f = 1
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                If f = 0 Then
                    f = 2
                End If
            End If
            If f = 1 Then
                MessageBox.Show("Done successfully")
                CheckBox1.CheckState = CheckState.Unchecked
                CheckBox2.CheckState = CheckState.Unchecked
                CheckBox3.CheckState = CheckState.Unchecked
                TextBox1.Clear()
            ElseIf f = 0 Then
                MessageBox.Show("Invalid customer id")
            Else
                MessageBox.Show("Please check any service")
            End If

            End If
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


    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim con1 As New OleDb.OleDbConnection
            con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
            con1.Open()
            Dim p As String
            Dim s3 As String
            s3 = "select person from hotel_paradise where hid='" + TextBox1.Text + "'"
            Dim com1 As New OleDbCommand(s3, con1)
            p = com1.ExecuteScalar
            ComboBox1.SelectedItem = p
            con1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form4.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form5.Visible = True
        Me.Visible = False
    End Sub
End Class