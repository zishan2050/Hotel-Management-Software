Imports System.Data.OleDb
Imports System.Data
Public Class Form2

    Private Sub FormDragDrop_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Visible = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Choose any option")
        ComboBox1.Items.Add("Show list")
        ComboBox1.Items.Add("Search")
        ComboBox1.SelectedIndex = 0
        Label1.Visible = True
        Label1.Text = " "
        Label1.Text = "What do u want to do?"
        dg1.Visible = False
        Button3.Visible = False
        TextBox1.Visible = False
    End Sub



    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ComboBox1.SelectedItem = "Those customer who have booked room or present in the hotel" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4 from hotel_paradise where flag=1", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "All customer" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4, AMT AS AMOUNT FROM HOTEL_PARADISE", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Those customer who have booked room or present in the hotel " Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Choose any option")
            ComboBox1.Items.Add("Search by hotel id no ")
            ComboBox1.Items.Add("Search by customer id no ")
            ComboBox1.Items.Add("Search by room no ")
            ComboBox1.Items.Add("Search by customer name ")
            ComboBox1.SelectedIndex = 0
            Label1.Text = " "
            Label1.Text = "Search type -"
            Button3.Visible = False
        ElseIf ComboBox1.SelectedItem = "All customer " Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Choose any option")
            ComboBox1.Items.Add("Search by hotel id no")
            ComboBox1.Items.Add("Search by customer id no")
            ComboBox1.Items.Add("Search by room no")
            ComboBox1.Items.Add("Search by customer name")
            ComboBox1.SelectedIndex = 0
            Label1.Text = " "
            Label1.Text = "Search type -"
            Button3.Visible = False
        ElseIf ComboBox1.SelectedItem = "Search by hotel id no" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4, amt as TOTAL BILL from hotel_paradise where HID='" + TextBox1.Text + "'", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by customer id no" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4 from hotel_paradise where ID_NUMBER='" + TextBox1.Text + "'", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by room no" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,UPPER(ROOM) as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4, AMT AS AMOUNT from hotel_paradise where ROOM='" + TextBox1.Text + "'", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by customer name" Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4, AMT AS AMOUNT from hotel_paradise where N1='" + TextBox1.Text + "'", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'only those who have booked room or present in the hotel
        ElseIf ComboBox1.SelectedItem = "Search by hotel id no " Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4,AMT AS AMOUNT from hotel_paradise where HID='" + TextBox1.Text + "'And Flag = 1", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by customer id no " Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4,AMT AS AMOUNT from hotel_paradise where ID_NUMBER='" + TextBox1.Text + "'And Flag = 1", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by room no " Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,UPPER(ROOM) as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4,AMT AS AMOUNT from hotel_paradise where ROOM='" + TextBox1.Text + "'And Flag = 1", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedItem = "Search by customer name " Then
            dg1.Visible = True
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim da As New OleDbDataAdapter("select HID as HOTEL_ID,N1 as NAME,A1 as AGE,G1 as GENDER,COUNTRY,STATE,DISTRICT,ADDRESS,ROOM as ROOM_NO,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,E_MAIL,RES as FOODING_COST,TRAVEL as TRAVEL_DESK_COST,INTERNET as INTERNET_COST,N2 as NAME2,R1 AS RELATION2,A2 AS AGE2,G2 AS GENDER2,N3 AS NAME3,R2 AS RELATION3,A3 AS AGE3,G3 AS GENDER3,N4 AS NAME4,R3 AS RELATION4,A4 AS AGE4, G4 AS GENDER4, AMT AS AMOUNT from hotel_paradise where N1='" + TextBox1.Text + "'And FLAG = 1", con1)
                Dim ta As New DataTable
                da.Fill(ta)
                dg1.DataSource = ta
                con1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ComboBox1.Visible = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Choose any option")
        ComboBox1.Items.Add("Show list")
        ComboBox1.Items.Add("Search")
        ComboBox1.SelectedIndex = 0
        Label1.Visible = True
        Label1.Text = ""
        Label1.Text = "What do u want to do?"
        dg1.Visible = False
        Button3.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Show list" Then
            Label1.Text = ""
            Label1.Text = "CUSTOMER TYPE -"
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Those customer who have booked room or present in the hotel")
            ComboBox1.Items.Add("All customer")
            ComboBox1.SelectedIndex = 0
            Button3.Visible = True
            Button3.Text = "Get Detail"
        ElseIf ComboBox1.SelectedItem = "Search" Then
            Label1.Text = ""
            Label1.Text = "CUSTOMER TYPE -"
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Those customer who have booked room or present in the hotel ")
            ComboBox1.Items.Add("All customer ")
            ComboBox1.SelectedIndex = 0
            Button3.Visible = True
            Button3.Text = "Next"
        ElseIf ComboBox1.SelectedItem = "Search by hotel id no" Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer hotel id no -"
            Button3.Visible = True
            Button3.Text = "Search"
            ComboBox1.Visible = False
        ElseIf ComboBox1.SelectedItem = "Search by customer id no" Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer id no -"
            ComboBox1.Visible = False
            Button3.Visible = True
            Button3.Text = "Search"
        ElseIf ComboBox1.SelectedItem = "Search by room no" Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the room no -"
            ComboBox1.Visible = False
            Button3.Visible = True
            Button3.Text = "Search"
        ElseIf ComboBox1.SelectedItem = "Search by customer name" Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer name -"
            Button3.Visible = True
            Button3.Text = "Search"
            ComboBox1.Visible = False

        ElseIf ComboBox1.SelectedItem = "Search by hotel id no " Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer hotel id no -"
            Button3.Text = "Search"
            Button3.Visible = True
            ComboBox1.Visible = False
        ElseIf ComboBox1.SelectedItem = "Search by customer id no " Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer id no -"
            ComboBox1.Visible = False
            Button3.Text = "Search"
            Button3.Visible = True
        ElseIf ComboBox1.SelectedItem = "Search by room no " Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the room no -"
            ComboBox1.Visible = False
            Button3.Text = "Search"
            Button3.Visible = True
        ElseIf ComboBox1.SelectedItem = "Search by customer name " Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label1.Text = ""
            Label1.Text = "Enter the customer name -"
            Button3.Text = "Search"
            Button3.Visible = True
            ComboBox1.Visible = False

        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form3.Visible = True
        Me.Visible = False
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
