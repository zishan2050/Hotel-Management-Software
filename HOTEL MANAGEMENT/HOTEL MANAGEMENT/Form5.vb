Imports System.Data.OleDb
Imports System.Data

Public Class Form5

    Private Sub FormDragDrop_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form3.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Form2.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form4.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label2.Visible = False
        ListBox1.Visible = False

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label2.Visible = True
        ListBox1.Items.Clear()
        ListBox1.Visible = True
        Try
            Dim con1 As New OleDb.OleDbConnection
            con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
            con1.Open()
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            Dim d As Integer
            Dim z As Integer
            Dim f As Integer
            Dim g As Integer
            Dim h As Integer
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim m As Integer
            Dim n As Integer
            Dim o As Integer
            Dim p As Integer
            Dim q As Integer
            Dim r As Integer
            Dim s1 As String
            Dim s2 As String
            Dim s3 As String
            Dim s4 As String
            Dim s5 As String
            Dim s6 As String
            Dim s7 As String
            Dim s8 As String
            Dim s9 As String
            Dim s10 As String
            Dim s11 As String
            Dim s12 As String
            Dim s13 As String
            Dim s14 As String
            Dim s15 As String
            Dim s16 As String
            Dim s17 As String
            Dim s18 As String

            s1 = "select r1 from hr"
            Dim com1 As New OleDbCommand(s1, con1)
            a = com1.ExecuteScalar
            s2 = "select r2 from hr"
            s3 = "select r3 from hr"
            Dim com2 As New OleDbCommand(s2, con1)
            Dim com3 As New OleDbCommand(s3, con1)
            b = com2.ExecuteScalar
            c = com3.ExecuteScalar
            s4 = "select r4 from hr"
            Dim com4 As New OleDbCommand(s4, con1)
            d = com4.ExecuteScalar
            s5 = "select r5 from hr"
            Dim com5 As New OleDbCommand(s5, con1)
            z = com5.ExecuteScalar
            s6 = "select r6 from hr"
            Dim com6 As New OleDbCommand(s6, con1)
            f = com6.ExecuteScalar
            s7 = "select r7 from hr"
            Dim com7 As New OleDbCommand(s7, con1)
            g = com7.ExecuteScalar
            s8 = "select r8 from hr"
            Dim com8 As New OleDbCommand(s8, con1)
            h = com8.ExecuteScalar
            s9 = "select r9 from hr"
            Dim com9 As New OleDbCommand(s9, con1)
            i = com9.ExecuteScalar
            s10 = "select r10 from hr"
            Dim com10 As New OleDbCommand(s10, con1)
            j = com10.ExecuteScalar
            s11 = "select r11 from hr"
            Dim com11 As New OleDbCommand(s11, con1)
            k = com11.ExecuteScalar
            s12 = "select r12 from hr"
            Dim com12 As New OleDbCommand(s12, con1)
            l = com12.ExecuteScalar
            s13 = "select r13 from hr"
            Dim com13 As New OleDbCommand(s13, con1)
            m = com13.ExecuteScalar
            s14 = "select r14 from hr"
            Dim com14 As New OleDbCommand(s14, con1)
            n = com14.ExecuteScalar
            s15 = "select r15 from hr"
            Dim com15 As New OleDbCommand(s15, con1)
            o = com15.ExecuteScalar
            s16 = "select r16 from hr"
            Dim com16 As New OleDbCommand(s16, con1)
            p = com16.ExecuteScalar
            s17 = "select r17 from hr"
            Dim com17 As New OleDbCommand(s17, con1)
            q = com17.ExecuteScalar
            s18 = "select r18 from hr"
            Dim com18 As New OleDbCommand(s18, con1)
            r = com18.ExecuteScalar

            If a = 0 Then
                ListBox1.Items.Add("GF-1")
            End If
            If b = 0 Then
                ListBox1.Items.Add("GF-2")
            End If
            If c = 0 Then
                ListBox1.Items.Add("GF-3")
            End If
            If d = 0 Then
                ListBox1.Items.Add("GF-4")
            End If
            If z = 0 Then
                ListBox1.Items.Add("GF-5")
            End If
            If f = 0 Then
                ListBox1.Items.Add("GF-6")
            End If

            If g = 0 Then
                ListBox1.Items.Add("FF-7")
            End If
            If h = 0 Then
                ListBox1.Items.Add("FF-8")
            End If
            If i = 0 Then
                ListBox1.Items.Add("FF-9")
            End If

            If j = 0 Then
                ListBox1.Items.Add("FF-10")
            End If
            If k = 0 Then
                ListBox1.Items.Add("FF-11")
            End If
            If l = 0 Then
                ListBox1.Items.Add("FF-12")
            End If

            If m = 0 Then
                ListBox1.Items.Add("SF-13")
            End If
            If n = 0 Then
                ListBox1.Items.Add("SF-14")
            End If
            If o = 0 Then
                ListBox1.Items.Add("SF-15")
            End If

            If p = 0 Then
                ListBox1.Items.Add("SF-16")
            End If
            If q = 0 Then
                ListBox1.Items.Add("SF-17")
            End If
            If r = 0 Then
                ListBox1.Items.Add("SF-18")
            End If

            con1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        Label2.Visible = False
        Label1.Text = "Press the check button to check the availability - "
    End Sub

   
End Class