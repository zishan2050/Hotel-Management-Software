Imports System.Data.OleDb
Imports System.Data
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.Button1.AllowDrop = True
        Me.Button1.AutoEllipsis = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ROOM BOOKING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1.  CUSTOMER NAME"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(39, 383)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(124, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(549, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CUSTOMER ADDRESS"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(552, 383)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ROOM TYPE-"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(236, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CHECK AVAILABILITY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(122, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(256, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(809, 117)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "HOTEL PARADISE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(724, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CONTACT NUMBER"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(727, 382)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ROOM NO-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(877, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "EMAIL ADDRESS"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(880, 380)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 21)
        Me.TextBox5.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(736, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ID PROOF-"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CHOOSE ANY OPTION", "VOTER ID CARD", "PAN CARD", "DRIVING LICENCE", "PASSPORT", "UID CARD"})
        Me.ComboBox2.Location = New System.Drawing.Point(829, 23)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox2.TabIndex = 23
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(122, 104)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox3.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(1009, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "AGE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(181, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "GENDER"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1012, 381)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(33, 20)
        Me.TextBox6.TabIndex = 28
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.White
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"SELECT", "MALE", "FEMALE"})
        Me.ComboBox4.Location = New System.Drawing.Point(184, 380)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox4.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "NO OF PERSON-"
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.White
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"CHOOSE ANY OPTION", "1", "2", "3", "4"})
        Me.ComboBox5.Location = New System.Drawing.Point(123, 65)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(203, 23)
        Me.ComboBox5.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(356, 586)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "CLEAR ALL ENTRIES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(594, 586)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(456, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "DISTRICT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(369, 358)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "STATE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(273, 358)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "COUNTRY"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(356, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CHECK IN DATE-"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(450, 150)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 26)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "EXTRA SERVICES"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(885, 151)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 26)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "CHECK OUT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox6.DropDownHeight = 120
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.DropDownWidth = 200
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox6.IntegralHeight = False
        Me.ComboBox6.Location = New System.Drawing.Point(276, 381)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(72, 23)
        Me.ComboBox6.TabIndex = 45
        '
        'ComboBox8
        '
        Me.ComboBox8.DropDownHeight = 120
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.DropDownWidth = 150
        Me.ComboBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.IntegralHeight = False
        Me.ComboBox8.Location = New System.Drawing.Point(459, 380)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox8.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(736, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 16)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "ID NUMBER-"
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(829, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(203, 20)
        Me.TextBox4.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 143)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(500, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 53
        Me.DateTimePicker1.Value = New Date(2012, 11, 17, 2, 58, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Location = New System.Drawing.Point(500, 68)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 52
        Me.DateTimePicker2.Value = New Date(2012, 11, 17, 10, 9, 0, 0)
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(356, 73)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(129, 16)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "CHECK OUT DATE-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(20, 449)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 16)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "2.  CUSTOMER NAME"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Green
        Me.Label17.Location = New System.Drawing.Point(20, 418)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(304, 16)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "ENTER THE DETAILS OF OTHER CUSTOMER:-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(181, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 16)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "GENDER"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(281, 449)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 16)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "AGE"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(341, 449)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 16)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "RELATION"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox7.Location = New System.Drawing.Point(39, 477)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox7.Size = New System.Drawing.Size(124, 20)
        Me.TextBox7.TabIndex = 57
        '
        'ComboBox9
        '
        Me.ComboBox9.BackColor = System.Drawing.Color.White
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"SELECT", "MALE", "FEMALE"})
        Me.ComboBox9.Location = New System.Drawing.Point(184, 477)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox9.TabIndex = 58
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(284, 477)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(33, 20)
        Me.TextBox8.TabIndex = 59
        '
        'TextBox9
        '
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Location = New System.Drawing.Point(344, 477)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(69, 20)
        Me.TextBox9.TabIndex = 60
        '
        'TextBox10
        '
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Location = New System.Drawing.Point(344, 546)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(69, 20)
        Me.TextBox10.TabIndex = 68
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(284, 546)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(33, 20)
        Me.TextBox11.TabIndex = 67
        '
        'ComboBox10
        '
        Me.ComboBox10.BackColor = System.Drawing.Color.White
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"SELECT", "MALE", "FEMALE"})
        Me.ComboBox10.Location = New System.Drawing.Point(184, 546)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox10.TabIndex = 66
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox12.Location = New System.Drawing.Point(39, 546)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox12.Size = New System.Drawing.Size(124, 20)
        Me.TextBox12.TabIndex = 65
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(341, 518)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 16)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "RELATION"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(281, 518)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 16)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "AGE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(181, 518)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 16)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "GENDER"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(20, 518)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 16)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "3.  CUSTOMER NAME"
        '
        'TextBox13
        '
        Me.TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox13.Location = New System.Drawing.Point(973, 478)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(69, 20)
        Me.TextBox13.TabIndex = 76
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(913, 478)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(33, 20)
        Me.TextBox14.TabIndex = 75
        '
        'ComboBox11
        '
        Me.ComboBox11.BackColor = System.Drawing.Color.White
        Me.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"SELECT", "MALE", "FEMALE"})
        Me.ComboBox11.Location = New System.Drawing.Point(816, 478)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox11.TabIndex = 74
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.White
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox15.Location = New System.Drawing.Point(668, 478)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox15.Size = New System.Drawing.Size(124, 20)
        Me.TextBox15.TabIndex = 73
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(970, 450)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 16)
        Me.Label26.TabIndex = 72
        Me.Label26.Text = "RELATION"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(910, 450)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 16)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "AGE"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(813, 450)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 16)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "GENDER"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(649, 450)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(143, 16)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "4.  CUSTOMER NAME"
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownHeight = 120
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.DropDownWidth = 150
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.IntegralHeight = False
        Me.ComboBox7.Location = New System.Drawing.Point(365, 381)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(76, 23)
        Me.ComboBox7.TabIndex = 46
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(668, 151)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(180, 26)
        Me.Button7.TabIndex = 87
        Me.Button7.Text = "CUSTOMER DETAIL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HOTEL_MANAGEMENT.My.Resources.Resources.Picture1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(201, 57)
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1078, 622)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.ComboBox10)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zi&H@N MoH&iN"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    
        Button3.Visible = True
        Button4.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        ComboBox4.Visible = True
        ComboBox5.Visible = True
        ComboBox6.Visible = True
        ComboBox7.Visible = True
        ComboBox8.Visible = True
        ComboBox9.Visible = True
        ComboBox10.Visible = False
        ComboBox11.Visible = False
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        GroupBox1.Visible = True
        ComboBox1.Items.Add("CHOOSE ANY OPTION")
        ComboBox1.Items.Add("AC ROOM WITH SINGLE BED")
        ComboBox1.Items.Add("AC ROOM WITH DOUBLE BED")
        ComboBox1.Items.Add("FAMILY ROOM (AC)")
        ComboBox1.Items.Add("FAMILY ROOM (NON-AC)")
        ComboBox1.Items.Add("NON-AC ROOM WITH DOUBLE BED")
        ComboBox1.Items.Add("NON-AC ROOM WITH SINGLE BED")
        ComboBox6.Items.Add("Afghanistan")
        ComboBox6.Items.Add("Akrotiri")
        ComboBox6.Items.Add("Albania")
        ComboBox6.Items.Add("Algeria")
        ComboBox6.Items.Add("American Samoa")
        ComboBox6.Items.Add("Andorra")
        ComboBox6.Items.Add("Angola")
        ComboBox6.Items.Add("Anguilla")
        ComboBox6.Items.Add("Antarctica")
        ComboBox6.Items.Add("Antigua and Barbuda")
        ComboBox6.Items.Add("Argentina")
        ComboBox6.Items.Add("Armenia")
        ComboBox6.Items.Add("Aruba")
        ComboBox6.Items.Add("Ashmore and Cartier Islands")
        ComboBox6.Items.Add("Australia")
        ComboBox6.Items.Add("Austria")
        ComboBox6.Items.Add("Azerbaijan")
        ComboBox6.Items.Add("Bahamas, The")
        ComboBox6.Items.Add("Bahrain")
        ComboBox6.Items.Add("Bangladesh")
        ComboBox6.Items.Add("Barbados")
        ComboBox6.Items.Add("Bassas da India")
        ComboBox6.Items.Add("Belarus")
        ComboBox6.Items.Add("Belgium")
        ComboBox6.Items.Add("Belize")
        ComboBox6.Items.Add("Benin")
        ComboBox6.Items.Add("Bermuda")
        ComboBox6.Items.Add("Bhutan")
        ComboBox6.Items.Add("Bolivia")
        ComboBox6.Items.Add("Bosnia and Herzegovina")
        ComboBox6.Items.Add("Botswana")
        ComboBox6.Items.Add("Bouvet Island")
        ComboBox6.Items.Add("Brazil")
        ComboBox6.Items.Add("British Indian Ocean Territory")
        ComboBox6.Items.Add("British Virgin Islands")
        ComboBox6.Items.Add("Brunei")
        ComboBox6.Items.Add("Bulgaria")
        ComboBox6.Items.Add("Burkina Faso")
        ComboBox6.Items.Add("Burma")
        ComboBox6.Items.Add("Burundi")
        ComboBox6.Items.Add("Cambodia")
        ComboBox6.Items.Add("Cameroon")
        ComboBox6.Items.Add("Canada")
        ComboBox6.Items.Add("Cape Verde")
        ComboBox6.Items.Add("Cayman Islands")
        ComboBox6.Items.Add("Central African Republic")
        ComboBox6.Items.Add("Chad")
        ComboBox6.Items.Add("Chile")
        ComboBox6.Items.Add("China")
        ComboBox6.Items.Add("Christmas Island")
        ComboBox6.Items.Add("Clipperton Island")
        ComboBox6.Items.Add("Cocos (Keeling) Islands")
        ComboBox6.Items.Add("Colombia")
        ComboBox6.Items.Add("Comoros")
        ComboBox6.Items.Add("Congo, Democratic Republic of the")
        ComboBox6.Items.Add("Congo, Republic of the")
        ComboBox6.Items.Add("Cook Islands")
        ComboBox6.Items.Add("Coral Sea Islands")
        ComboBox6.Items.Add("Costa Rica")
        ComboBox6.Items.Add("Cote d 'Ivoire")
        ComboBox6.Items.Add("Croatia")
        ComboBox6.Items.Add("Cuba")
        ComboBox6.Items.Add("Cyprus")
        ComboBox6.Items.Add("Czech Republic")
        ComboBox6.Items.Add("Denmark")
        ComboBox6.Items.Add("Dhekelia")
        ComboBox6.Items.Add("Djibouti")
        ComboBox6.Items.Add("Dominica")
        ComboBox6.Items.Add("Dominican Republic")
        ComboBox6.Items.Add("Ecuador")
        ComboBox6.Items.Add("Egypt")
        ComboBox6.Items.Add("El Salvador")
        ComboBox6.Items.Add("Equatorial Guinea")
        ComboBox6.Items.Add("Eritrea")
        ComboBox6.Items.Add("Estonia")
        ComboBox6.Items.Add("Ethiopia")
        ComboBox6.Items.Add("Europa Island")
        ComboBox6.Items.Add("Falkland Islands (Islas Malvinas)")
        ComboBox6.Items.Add("Faroe Islands")
        ComboBox6.Items.Add("Fiji")
        ComboBox6.Items.Add("Finland")
        ComboBox6.Items.Add("France")
        ComboBox6.Items.Add("French Guiana")
        ComboBox6.Items.Add("French Polynesia")
        ComboBox6.Items.Add("French Southern and Antarctic Lands")
        ComboBox6.Items.Add("Gabon")
        ComboBox6.Items.Add("Gambia, The")
        ComboBox6.Items.Add("Gaza Strip")
        ComboBox6.Items.Add("Georgia")
        ComboBox6.Items.Add("Germany")
        ComboBox6.Items.Add("Ghana")
        ComboBox6.Items.Add("Gibraltar")
        ComboBox6.Items.Add("Glorioso Islands")
        ComboBox6.Items.Add("Greece")
        ComboBox6.Items.Add("Greenland")
        ComboBox6.Items.Add("Grenada")
        ComboBox6.Items.Add("Guadeloupe")
        ComboBox6.Items.Add("Guam")
        ComboBox6.Items.Add("Guatemala")
        ComboBox6.Items.Add("Guatemala")
        ComboBox6.Items.Add("Guernsey")
        ComboBox6.Items.Add("Guinea")
        ComboBox6.Items.Add("Guinea-Bissau")
        ComboBox6.Items.Add("Guyana")
        ComboBox6.Items.Add("Haiti")
        ComboBox6.Items.Add("Heard Island and McDonald Islands")
        ComboBox6.Items.Add("Holy See (Vatican City)")
        ComboBox6.Items.Add("Honduras")
        ComboBox6.Items.Add("Hong Kong")
        ComboBox6.Items.Add("Hungary")
        ComboBox6.Items.Add("Iceland")
        ComboBox6.Items.Add("India")
        ComboBox6.Items.Add("Indonesia")
        ComboBox6.Items.Add("Iran")
        ComboBox6.Items.Add("Iraq")
        ComboBox6.Items.Add("Ireland")
        ComboBox6.Items.Add("Isle of Man")
        ComboBox6.Items.Add("Israel")
        ComboBox6.Items.Add("Italy")
        ComboBox6.Items.Add("Jamaica")
        ComboBox6.Items.Add("Jan Mayen")
        ComboBox6.Items.Add("Japan")
        ComboBox6.Items.Add("Jersey")
        ComboBox6.Items.Add("Jordan")
        ComboBox6.Items.Add("Juan de Nova Island")
        ComboBox6.Items.Add("Kazakhstan")
        ComboBox6.Items.Add("Kenya")
        ComboBox6.Items.Add("Kiribati")
        ComboBox6.Items.Add("Korea, North")
        ComboBox6.Items.Add("Korea, South")
        ComboBox6.Items.Add("Kuwait")
        ComboBox6.Items.Add("Kyrgyzstan")
        ComboBox6.Items.Add("Laos")
        ComboBox6.Items.Add("Latvia")
        ComboBox6.Items.Add("Lebanon")
        ComboBox6.Items.Add("Lesotho")
        ComboBox6.Items.Add("Liberia")
        ComboBox6.Items.Add("Libya")
        ComboBox6.Items.Add("Liechtenstein")
        ComboBox6.Items.Add("Lithuania")
        ComboBox6.Items.Add("Luxembourg")
        ComboBox6.Items.Add("Macau")
        ComboBox6.Items.Add("Macedonia")
        ComboBox6.Items.Add("Madagascar")
        ComboBox6.Items.Add("Malawi")
        ComboBox6.Items.Add("Malaysia")
        ComboBox6.Items.Add("Maldives")
        ComboBox6.Items.Add("Mali")
        ComboBox6.Items.Add("Malta")
        ComboBox6.Items.Add("Marshall Islands")
        ComboBox6.Items.Add("Martinique")
        ComboBox6.Items.Add("Mauritania")
        ComboBox6.Items.Add("Mauritius")
        ComboBox6.Items.Add("Mayotte")
        ComboBox6.Items.Add("Mexico")
        ComboBox6.Items.Add("Micronesia, Federated States of")
        ComboBox6.Items.Add("Moldova")
        ComboBox6.Items.Add("Monaco")
        ComboBox6.Items.Add("Mongolia")
        ComboBox6.Items.Add("Montserrat")
        ComboBox6.Items.Add("Morocco")
        ComboBox6.Items.Add("Mozambique")
        ComboBox6.Items.Add("Namibia")
        ComboBox6.Items.Add("Nauru")
        ComboBox6.Items.Add("Navassa Island")
        ComboBox6.Items.Add("Nepal")
        ComboBox6.Items.Add("Netherlands")
        ComboBox6.Items.Add("Netherlands Antilles")
        ComboBox6.Items.Add("New Caledonia")
        ComboBox6.Items.Add("New Zealand")
        ComboBox6.Items.Add("Nicaragua")
        ComboBox6.Items.Add("Niger")
        ComboBox6.Items.Add("Nigeria")
        ComboBox6.Items.Add("Niue")
        ComboBox6.Items.Add("NorfolkIsland")
        ComboBox6.Items.Add("Northern Mariana Islands")
        ComboBox6.Items.Add("Norway")
        ComboBox6.Items.Add("Oman")
        ComboBox6.Items.Add("Pakistan")
        ComboBox6.Items.Add("Palau")
        ComboBox6.Items.Add("Panama")
        ComboBox6.Items.Add("Papua New Guinea")
        ComboBox6.Items.Add("Paracel Islands")
        ComboBox6.Items.Add("Paraguay")
        ComboBox6.Items.Add("Peru")
        ComboBox6.Items.Add("Philippines")
        ComboBox6.Items.Add("Pitcairn Islands")
        ComboBox6.Items.Add("Poland")
        ComboBox6.Items.Add("Portugal")
        ComboBox6.Items.Add("Puerto Rico")
        ComboBox6.Items.Add("Qatar")
        ComboBox6.Items.Add("Reunion")
        ComboBox6.Items.Add("Romania")
        ComboBox6.Items.Add("Russia")
        ComboBox6.Items.Add("Rwanda")
        ComboBox6.Items.Add("Saint Helena")
        ComboBox6.Items.Add("Saint Kitts And Nevis")
        ComboBox6.Items.Add("Saint Lucia")
        ComboBox6.Items.Add("Saint Pierre And Miquelon")
        ComboBox6.Items.Add("Saint Vincent and the Grenadines")
        ComboBox6.Items.Add("Samoa")
        ComboBox6.Items.Add("SanMarino")
        ComboBox6.Items.Add("Sao Tome And Principe")
        ComboBox6.Items.Add("Saudi Arabia")
        ComboBox6.Items.Add("Senegal")
        ComboBox6.Items.Add("Serbia and Montenegro")
        ComboBox6.Items.Add("Seychelles")
        ComboBox6.Items.Add("Sierra Leone")
        ComboBox6.Items.Add("Singapore")
        ComboBox6.Items.Add("Slovakia")
        ComboBox6.Items.Add("Slovenia")
        ComboBox6.Items.Add("Solomon Islands")
        ComboBox6.Items.Add("Somalia")
        ComboBox6.Items.Add("South Africa")
        ComboBox6.Items.Add("South Georgia and the South Sandwich Islands")
        ComboBox6.Items.Add("Spain")
        ComboBox6.Items.Add("Spratly Islands")
        ComboBox6.Items.Add("Sri Lanka")
        ComboBox6.Items.Add("Sudan")
        ComboBox6.Items.Add("Suriname")
        ComboBox6.Items.Add("Svalbard")
        ComboBox6.Items.Add("Swaziland")
        ComboBox6.Items.Add("Sweden")
        ComboBox6.Items.Add("Switzerland")
        ComboBox6.Items.Add("Syria")
        ComboBox6.Items.Add("Taiwan")
        ComboBox6.Items.Add("Tajikistan")
        ComboBox6.Items.Add("Tanzania")
        ComboBox6.Items.Add("Thailand")
        ComboBox6.Items.Add("Timor-Leste")
        ComboBox6.Items.Add("Togo")
        ComboBox6.Items.Add("Tokelau")
        ComboBox6.Items.Add("Tonga")
        ComboBox6.Items.Add("Trinidad and Tobago")
        ComboBox6.Items.Add("Tromelin Island")
        ComboBox6.Items.Add("Tunisia")
        ComboBox6.Items.Add("Turkey")
        ComboBox6.Items.Add("Turkmenistan")
        ComboBox6.Items.Add("Turks and Caicos Islands")
        ComboBox6.Items.Add("Tuvalu")
        ComboBox6.Items.Add("Uganda")
        ComboBox6.Items.Add("Ukraine")
        ComboBox6.Items.Add("United Arab Emirates")
        ComboBox6.Items.Add("United Kingdom")
        ComboBox6.Items.Add("United States")
        ComboBox6.Items.Add("Uruguay")
        ComboBox6.Items.Add("Uzbekistan")
        ComboBox6.Items.Add("Vanuatu")
        ComboBox6.Items.Add("Venezuela")
        ComboBox6.Items.Add("Vietnam")
        ComboBox6.Items.Add("Virgin Islands")
        ComboBox6.Items.Add("Wake Island")
        ComboBox6.Items.Add("Wallis and Futuna")
        ComboBox6.Items.Add("West Bank")
        ComboBox6.Items.Add("Western Sahara")
        ComboBox6.Items.Add("Yemen")
        ComboBox6.Items.Add("Zambia")
        ComboBox6.Items.Add("Zimbabwe")
        ComboBox6.Items.Add("Other")
        ComboBox8.Items.Add("SELECT")
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 111
        ComboBox7.SelectedIndex = 0
        ComboBox9.SelectedIndex = 0
        ComboBox10.SelectedIndex = 0
        ComboBox11.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        Button3.Visible = True
        Button4.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        ComboBox4.Visible = True
        ComboBox5.Visible = True
        ComboBox6.Visible = True
        ComboBox7.Visible = True
        ComboBox8.Visible = True
        ComboBox9.Visible = False
        ComboBox10.Visible = False
        ComboBox11.Visible = False
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        GroupBox1.Visible = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Form5.Visible = True
        Me.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            ComboBox3.Items.Add("GF-1")
            ComboBox3.Items.Add("GF-2")
            ComboBox3.Items.Add("GF-3")
            ComboBox3.Items.Add("GF-4")
            ComboBox3.Items.Add("GF-5")
            ComboBox3.Items.Add("GF-6")
            ComboBox3.Items.Add("FF-7")
            ComboBox3.Items.Add("FF-8")
            ComboBox3.Items.Add("FF-9")
            ComboBox3.Items.Add("FF-10")
            ComboBox3.Items.Add("FF-11")
            ComboBox3.Items.Add("FF-12")
            ComboBox3.Items.Add("SF-13")
            ComboBox3.Items.Add("SF-14")
            ComboBox3.Items.Add("SF-15")
            ComboBox3.Items.Add("SF-16")
            ComboBox3.Items.Add("SF-17")
            ComboBox3.Items.Add("SF-18")

        End If
        If ComboBox1.SelectedIndex = 1 Then
            ComboBox5.SelectedIndex = 1
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r1 from hr"
                s2 = "select r2 from hr"
                s3 = "select r3 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
            If a = 0 Then
                ComboBox3.Items.Add("GF-1")
            End If
            If b = 0 Then
                ComboBox3.Items.Add("GF-2")
            End If
            If c = 0 Then
                ComboBox3.Items.Add("GF-3")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If ComboBox1.SelectedIndex = 2 Then
            ComboBox5.SelectedIndex = 2
            Label6.Visible = True
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r4 from hr"
                s2 = "select r5 from hr"
                s3 = "select r6 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
                If a = 0 Then
                    ComboBox3.Items.Add("GF-4")
                End If
                If b = 0 Then
                    ComboBox3.Items.Add("GF-5")
                End If
                If c = 0 Then
                    ComboBox3.Items.Add("GF-6")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ComboBox1.SelectedIndex = 3 Then
            ComboBox5.SelectedIndex = 0
            Label6.Visible = True
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r7 from hr"
                s2 = "select r8 from hr"
                s3 = "select r9 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
                If a = 0 Then
                    ComboBox3.Items.Add("FF-7")
                End If
                If b = 0 Then
                    ComboBox3.Items.Add("FF-8")
                End If
                If c = 0 Then
                    ComboBox3.Items.Add("FF-9")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ComboBox1.SelectedIndex = 4 Then
            ComboBox5.SelectedIndex = 0
            Label6.Visible = True
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r10 from hr"
                s2 = "select r11 from hr"
                s3 = "select r12 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
                If a = 0 Then
                    ComboBox3.Items.Add("FF-10")
                End If
                If b = 0 Then
                    ComboBox3.Items.Add("FF-11")
                End If
                If c = 0 Then
                    ComboBox3.Items.Add("FF-12")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ComboBox1.SelectedIndex = 5 Then
            ComboBox5.SelectedIndex = 2
            Label6.Visible = True
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r13 from hr"
                s2 = "select r14 from hr"
                s3 = "select r15 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
                If a = 0 Then
                    ComboBox3.Items.Add("SF-13")
                End If
                If b = 0 Then
                    ComboBox3.Items.Add("SF-14")
                End If
                If c = 0 Then
                    ComboBox3.Items.Add("SF-15")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ComboBox1.SelectedIndex = 6 Then
            ComboBox5.SelectedIndex = 1
            Label6.Visible = True
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("CHOOSE ANY OPTION")
            ComboBox3.SelectedIndex = 0
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim a As Integer
                Dim b As Integer
                Dim c As Integer
                Dim s1 As String
                Dim s2 As String
                Dim s3 As String
                s1 = "select r16 from hr"
                s2 = "select r17 from hr"
                s3 = "select r18 from hr"
                Dim com1 As New OleDbCommand(s1, con1)
                Dim com2 As New OleDbCommand(s2, con1)
                Dim com3 As New OleDbCommand(s3, con1)
                a = com1.ExecuteScalar
                b = com2.ExecuteScalar
                c = com3.ExecuteScalar
                con1.Close()
                If a = 0 Then
                    ComboBox3.Items.Add("SF-16")
                End If
                If b = 0 Then
                    ComboBox3.Items.Add("SF-17")
                End If
                If c = 0 Then
                    ComboBox3.Items.Add("SF-18")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
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
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox9.SelectedIndex = 0
        ComboBox10.SelectedIndex = 0
        ComboBox11.SelectedIndex = 0
        ComboBox6.SelectedIndex = 111

    End Sub

    Private Sub FormDragDrop_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DateTimePicker1.Value = DateTime.Now

        If ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in room type")
        ElseIf ComboBox5.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in no of person")
        ElseIf ComboBox3.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in room no")
        ElseIf ComboBox2.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in id proof")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Please enter the id number")

        ElseIf ComboBox5.SelectedIndex = 1 Then
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox4.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf ComboBox7.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in state")
        ElseIf ComboBox8.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in district")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter customer address")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter contact number")
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Please enter age")

        Else
                Dim t As String
                Dim d As Date
                Dim id As String
                Dim r As String
                r = ComboBox3.SelectedItem
                t = TimeOfDay
                d = DateTimePicker1.Value.ToShortDateString
                Console.WriteLine(d)
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                    Dim s1 As String
                    Dim s2 As String
                    s2 = "insert into HOTEL_PARADISE(N1,COUNTRY,STATE,DISTRICT,ADDRESS,PERSON,ROOM,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,FLAG,G1,A1,E_MAIL,RES,INTERNET,TRAVEL,AMT) values('" + TextBox1.Text + "','" + ComboBox6.SelectedItem + "' ,'" + ComboBox7.SelectedItem + "' , '" + ComboBox8.SelectedItem + "' , '" + TextBox2.Text + "' , '" + ComboBox5.SelectedItem + "' , '" + ComboBox3.SelectedItem + "' ,'" + ComboBox2.SelectedItem + "' ,'" + TextBox4.Text + "' ,'" + DateTimePicker1.Value.ToShortDateString + "' , '" + DateTimePicker2.Value.ToShortDateString + "' , 1  ,'" + ComboBox4.SelectedItem + "' , '" + TextBox6.Text + "' , '" + TextBox5.Text + "',0,0,0,0)"
                Dim com As New OleDbCommand(s2, con1)
                com.ExecuteNonQuery()
                    s1 = "select HID FROM HOTEL_PARADISE WHERE CHECK_IN='" + d + "'"
                Dim com1 As New OleDbCommand(s1, con1)
                    id = com1.ExecuteScalar
                    If r = "GF-1" Then
                        Dim s3 As String
                        s3 = "update hr set r1=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-2" Then
                        Dim s3 As String
                        s3 = "update hr set r2=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-3" Then
                        Dim s3 As String
                        s3 = "update hr set r3=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-4" Then
                        Dim s3 As String
                        s3 = "update hr set r4=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-5" Then
                        Dim s3 As String
                        s3 = "update hr set r5=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-6" Then
                        Dim s3 As String
                        s3 = "update hr set r6=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-7" Then
                        Dim s3 As String
                        s3 = "update hr set r7=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-8" Then
                        Dim s3 As String
                        s3 = "update hr set r8=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-9" Then
                        Dim s3 As String
                        s3 = "update hr set r9=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-10" Then
                        Dim s3 As String
                        s3 = "update hr set r10=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-11" Then
                        Dim s3 As String
                        s3 = "update hr set r11=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-12" Then
                        Dim s3 As String
                        s3 = "update hr set r12=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-13" Then
                        Dim s3 As String
                        s3 = "update hr set r13=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-14" Then
                        Dim s3 As String
                        s3 = "update hr set r14=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-15" Then
                        Dim s3 As String
                        s3 = "update hr set r15=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-16" Then
                        Dim s3 As String
                        s3 = "update hr set r16=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()

                    End If
                    con1.Close()
                    MessageBox.Show("                                 HOTEL PARADISE" + vbNewLine + vbNewLine + vbNewLine + "HOTEL ID NO -> " + id + vbNewLine + vbNewLine + "NAME -> " + TextBox1.Text + vbNewLine + vbNewLine + "ROOM TYPE -> " + ComboBox1.SelectedItem + vbNewLine + vbNewLine + "ROOM NO -> " + ComboBox3.SelectedItem + vbNewLine + vbNewLine + "NO OF PERSON -> " + ComboBox5.SelectedItem + vbNewLine + vbNewLine + "CHECK IN DATE -> " + DateTimePicker1.Value + vbNewLine + vbNewLine + "CHECK OUT DATE -> " + DateTimePicker2.Value + vbNewLine + vbNewLine + "                          Data has been saved successfully")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
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
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0
                ComboBox5.SelectedIndex = 0
                ComboBox4.SelectedIndex = 0
                ComboBox9.SelectedIndex = 0
                ComboBox10.SelectedIndex = 0
                ComboBox11.SelectedIndex = 0
                ComboBox6.SelectedIndex = 111


        End If

        ElseIf ComboBox5.SelectedIndex = 2 Then
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox4.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf ComboBox7.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in state")
        ElseIf ComboBox8.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in district")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter customer address")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter contact number")
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox9.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox9.Text = "" Then
            MessageBox.Show("Please enter the relation")

        Else
            Dim t As String
            Dim d As String
            Dim id As String
                Dim r As String
                r = ComboBox3.SelectedItem
                id = 0
            t = TimeOfDay
                d = DateTimePicker1.Value.ToShortDateString
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim s1 As String
                Dim s2 As String
                    s2 = "insert into HOTEL_PARADISE(N1,N2,COUNTRY,STATE,DISTRICT,ADDRESS,PERSON,ROOM,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,FLAG,G1,G2,A1,A2,R1,E_MAIL,RES,INTERNET,TRAVEL,AMT) values('" + TextBox1.Text + "', '" + TextBox7.Text + "' ,'" + ComboBox6.SelectedItem + "' ,'" + ComboBox7.SelectedItem + "' , '" + ComboBox8.SelectedItem + "' , '" + TextBox2.Text + "' , '" + ComboBox5.SelectedItem + "' , '" + ComboBox3.SelectedItem + "' ,'" + ComboBox2.SelectedItem + "' ,'" + TextBox4.Text + "' ,'" + DateTimePicker1.Value.ToShortDateString + "' , '" + DateTimePicker2.Value.ToShortDateString + "' , 1  ,'" + ComboBox4.SelectedItem + "' , '" + ComboBox9.SelectedItem + "' , '" + TextBox6.Text + "' , '" + TextBox8.Text + "','" + TextBox9.Text + "' , '" + TextBox5.Text + "',0,0,0,0)"
                Dim com As New OleDbCommand(s2, con1)
                com.ExecuteNonQuery()
                    s1 = "select HID FROM HOTEL_PARADISE WHERE  CHECK_IN='" + d + "'"
                Dim com1 As New OleDbCommand(s1, con1)
                    id = com1.ExecuteScalar
                    If r = "GF-1" Then
                        Dim s3 As String
                        s3 = "update hr set r1=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-2" Then
                        Dim s3 As String
                        s3 = "update hr set r2=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-3" Then
                        Dim s3 As String
                        s3 = "update hr set r3=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-4" Then
                        Dim s3 As String
                        s3 = "update hr set r4=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-5" Then
                        Dim s3 As String
                        s3 = "update hr set r5=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-6" Then
                        Dim s3 As String
                        s3 = "update hr set r6=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-7" Then
                        Dim s3 As String
                        s3 = "update hr set r7=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-8" Then
                        Dim s3 As String
                        s3 = "update hr set r8=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-9" Then
                        Dim s3 As String
                        s3 = "update hr set r9=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-10" Then
                        Dim s3 As String
                        s3 = "update hr set r10=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-11" Then
                        Dim s3 As String
                        s3 = "update hr set r11=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-12" Then
                        Dim s3 As String
                        s3 = "update hr set r12=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-13" Then
                        Dim s3 As String
                        s3 = "update hr set r13=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-14" Then
                        Dim s3 As String
                        s3 = "update hr set r14=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-15" Then
                        Dim s3 As String
                        s3 = "update hr set r15=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-16" Then
                        Dim s3 As String
                        s3 = "update hr set r16=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()

                    End If
                con1.Close()
                    MessageBox.Show("                                 HOTEL PARADISE" + vbNewLine + vbNewLine + vbNewLine + "HOTEL ID NO -> " + id + vbNewLine + vbNewLine + "NAME -> " + TextBox1.Text + vbNewLine + vbNewLine + "ROOM TYPE -> " + ComboBox1.SelectedItem + vbNewLine + vbNewLine + "ROOM NO -> " + ComboBox3.SelectedItem + vbNewLine + vbNewLine + "NO OF PERSON -> " + ComboBox5.SelectedItem + vbNewLine + vbNewLine + "CHECK IN DATE -> " + DateTimePicker1.Value + vbNewLine + vbNewLine + "CHECK OUT DATE -> " + DateTimePicker2.Value + vbNewLine + vbNewLine + "                           Data has been saved successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
                End Try
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
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0
                ComboBox5.SelectedIndex = 0
                ComboBox4.SelectedIndex = 0
                ComboBox9.SelectedIndex = 0
                ComboBox10.SelectedIndex = 0
                ComboBox11.SelectedIndex = 0
                ComboBox6.SelectedIndex = 111
         

        End If

        ElseIf ComboBox5.SelectedIndex = 3 Then
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox4.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf ComboBox7.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in state")
        ElseIf ComboBox8.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in district")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter customer address")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter contact number")
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox9.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox9.Text = "" Then
            MessageBox.Show("Please enter the relation")
        ElseIf TextBox12.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox10.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox11.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox10.Text = "" Then
            MessageBox.Show("Please enter the relation")

        Else
            Dim t As String
            Dim d As String
            Dim id As String
                Dim r As String
                r = ComboBox3.SelectedItem
                id = 0
            t = TimeOfDay
                d = DateTimePicker1.Value.ToShortDateString
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim s1 As String
                Dim s2 As String
                    s2 = "insert into HOTEL_PARADISE(N1,N2,N3,COUNTRY,STATE,DISTRICT,ADDRESS,PERSON,ROOM,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,FLAG,G1,G2,G3,A1,A2,A3,R1,R2,E_MAIL,RES,INTERNET,TRAVEL,AMT) values('" + TextBox1.Text + "', '" + TextBox7.Text + "' ,'" + TextBox12.Text + "','" + ComboBox6.SelectedItem + "' ,'" + ComboBox7.SelectedItem + "' , '" + ComboBox8.SelectedItem + "' , '" + TextBox2.Text + "' , '" + ComboBox5.SelectedItem + "' , '" + ComboBox3.SelectedItem + "' ,'" + ComboBox2.SelectedItem + "' ,'" + TextBox4.Text + "' ,'" + DateTimePicker1.Value.ToShortDateString + "' , '" + DateTimePicker2.Value.ToShortDateString + "' , 1  ,'" + ComboBox4.SelectedItem + "' , '" + ComboBox9.SelectedItem + "' ,'" + ComboBox10.SelectedItem + "', '" + TextBox6.Text + "' , '" + TextBox8.Text + "','" + TextBox11.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "' , '" + TextBox5.Text + "',0,0,0,0)"
                Dim com As New OleDbCommand(s2, con1)
                com.ExecuteNonQuery()
                    s1 = "select HID FROM HOTEL_PARADISE WHERE  CHECK_IN='" + d + "'"
                Dim com1 As New OleDbCommand(s1, con1)
                id = com1.ExecuteScalar
                    If r = "GF-1" Then
                        Dim s3 As String
                        s3 = "update hr set r1=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-2" Then
                        Dim s3 As String
                        s3 = "update hr set r2=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-3" Then
                        Dim s3 As String
                        s3 = "update hr set r3=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-4" Then
                        Dim s3 As String
                        s3 = "update hr set r4=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-5" Then
                        Dim s3 As String
                        s3 = "update hr set r5=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-6" Then
                        Dim s3 As String
                        s3 = "update hr set r6=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-7" Then
                        Dim s3 As String
                        s3 = "update hr set r7=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-8" Then
                        Dim s3 As String
                        s3 = "update hr set r8=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-9" Then
                        Dim s3 As String
                        s3 = "update hr set r9=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-10" Then
                        Dim s3 As String
                        s3 = "update hr set r10=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-11" Then
                        Dim s3 As String
                        s3 = "update hr set r11=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-12" Then
                        Dim s3 As String
                        s3 = "update hr set r12=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-13" Then
                        Dim s3 As String
                        s3 = "update hr set r13=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-14" Then
                        Dim s3 As String
                        s3 = "update hr set r14=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-15" Then
                        Dim s3 As String
                        s3 = "update hr set r15=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-16" Then
                        Dim s3 As String
                        s3 = "update hr set r16=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()

                    End If
                    con1.Close()
                    MessageBox.Show("                                 HOTEL PARADISE" + vbNewLine + vbNewLine + vbNewLine + "HOTEL ID NO -> " + id + vbNewLine + vbNewLine + "NAME -> " + TextBox1.Text + vbNewLine + vbNewLine + "ROOM TYPE -> " + ComboBox1.SelectedItem + vbNewLine + vbNewLine + "ROOM NO -> " + ComboBox3.SelectedItem + vbNewLine + vbNewLine + "NO OF PERSON -> " + ComboBox5.SelectedItem + vbNewLine + vbNewLine + "CHECK IN DATE -> " + DateTimePicker1.Value + vbNewLine + vbNewLine + "CHECK OUT DATE -> " + DateTimePicker2.Value + vbNewLine + vbNewLine + "                          Data has been saved successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
                End Try
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
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0
                ComboBox5.SelectedIndex = 0
                ComboBox4.SelectedIndex = 0
                ComboBox9.SelectedIndex = 0
                ComboBox10.SelectedIndex = 0
                ComboBox11.SelectedIndex = 0
                ComboBox6.SelectedIndex = 111
             

        End If

        ElseIf ComboBox5.SelectedIndex = 4 Then
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox4.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf ComboBox7.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in state")
        ElseIf ComboBox8.SelectedItem = "SELECT" Then
            MessageBox.Show("Please choose any option in district")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter customer address")
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please enter contact number")
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox9.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox9.Text = "" Then
            MessageBox.Show("Please enter the relation")
        ElseIf TextBox12.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox10.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox11.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox10.Text = "" Then
            MessageBox.Show("Please enter the relation")
        ElseIf TextBox15.Text = "" Then
            MessageBox.Show("Please enter customer name")
        ElseIf ComboBox11.SelectedIndex = 0 Then
            MessageBox.Show("Please choose any option in gender")
        ElseIf TextBox14.Text = "" Then
            MessageBox.Show("Please enter age")
        ElseIf TextBox13.Text = "" Then
            MessageBox.Show("Please enter the relation")

        Else
            Dim t As String
            Dim d As String
            Dim id As String
                Dim r As String
                r = ComboBox3.SelectedItem
                id = 0
            t = TimeOfDay
                d = DateTimePicker1.Value
            Try
                Dim con1 As New OleDb.OleDbConnection
                con1.ConnectionString = "Provider=msdaora;Data Source=xe;Persist Security Info=True;User ID=system;Password=7860639972;Unicode=True"
                con1.Open()
                Dim s1 As String
                Dim s2 As String
                    s2 = "insert into HOTEL_PARADISE(N1,N2,N3,N4,COUNTRY,STATE,DISTRICT,ADDRESS,PERSON,ROOM,ID_TYPE,ID_NUMBER,CHECK_IN,CHECK_OUT,FLAG,G1,G2,G3,G4,A1,A2,A3,A4,R1,R2,R3,E_MAIL,RES,INTERNET,TRAVEL,AMT) values('" + TextBox1.Text + "', '" + TextBox7.Text + "' ,'" + TextBox12.Text + "','" + TextBox15.Text + "','" + ComboBox6.SelectedItem + "' ,'" + ComboBox7.SelectedItem + "' , '" + ComboBox8.SelectedItem + "' , '" + TextBox2.Text + "' , '" + ComboBox5.SelectedItem + "' , '" + ComboBox3.SelectedItem + "' ,'" + ComboBox2.SelectedItem + "' ,'" + TextBox4.Text + "' ,'" + DateTimePicker1.Value.ToShortDateString + "' , '" + DateTimePicker2.Value.ToShortDateString + "' , 1  ,'" + ComboBox4.SelectedItem + "' , '" + ComboBox9.SelectedItem + "' ,'" + ComboBox10.SelectedItem + "','" + ComboBox11.SelectedItem + "', '" + TextBox6.Text + "' , '" + TextBox8.Text + "','" + TextBox11.Text + "','" + TextBox14.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox13.Text + "', '" + TextBox5.Text + "',0,0,0,0)"
                Dim com As New OleDbCommand(s2, con1)
                com.ExecuteNonQuery()
                    s1 = "select HID FROM HOTEL_PARADISE WHERE  CHECK_IN='" + d + "'"
                Dim com1 As New OleDbCommand(s1, con1)
                id = com1.ExecuteScalar
                    If r = "GF-1" Then
                        Dim s3 As String
                        s3 = "update hr set r1=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-2" Then
                        Dim s3 As String
                        s3 = "update hr set r2=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-3" Then
                        Dim s3 As String
                        s3 = "update hr set r3=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-4" Then
                        Dim s3 As String
                        s3 = "update hr set r4=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-5" Then
                        Dim s3 As String
                        s3 = "update hr set r5=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "GF-6" Then
                        Dim s3 As String
                        s3 = "update hr set r6=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-7" Then
                        Dim s3 As String
                        s3 = "update hr set r7=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-8" Then
                        Dim s3 As String
                        s3 = "update hr set r8=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-9" Then
                        Dim s3 As String
                        s3 = "update hr set r9=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-10" Then
                        Dim s3 As String
                        s3 = "update hr set r10=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-11" Then
                        Dim s3 As String
                        s3 = "update hr set r11=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "FF-12" Then
                        Dim s3 As String
                        s3 = "update hr set r12=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-13" Then
                        Dim s3 As String
                        s3 = "update hr set r13=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-14" Then
                        Dim s3 As String
                        s3 = "update hr set r14=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-15" Then
                        Dim s3 As String
                        s3 = "update hr set r15=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()
                    ElseIf r = "SF-16" Then
                        Dim s3 As String
                        s3 = "update hr set r16=1"
                        Dim com2 As New OleDbCommand(s3, con1)
                        com2.ExecuteNonQuery()

                    End If
                con1.Close()
                    MessageBox.Show("                                 HOTEL PARADISE" + vbNewLine + vbNewLine + vbNewLine + "HOTEL ID NO -> " + id + vbNewLine + vbNewLine + "NAME -> " + TextBox1.Text + vbNewLine + vbNewLine + "ROOM TYPE -> " + ComboBox1.SelectedItem + vbNewLine + vbNewLine + "ROOM NO -> " + ComboBox3.SelectedItem + vbNewLine + vbNewLine + "NO OF PERSON -> " + ComboBox5.SelectedItem + vbNewLine + vbNewLine + "CHECK IN DATE -> " + DateTimePicker1.Value + vbNewLine + vbNewLine + "CHECK OUT DATE -> " + DateTimePicker2.Value + vbNewLine + vbNewLine + "                          Data has been saved successfully")
            Catch ex As Exception
                MsgBox(ex.Message)
                End Try
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
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                ComboBox1.SelectedIndex = 0
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0
                ComboBox5.SelectedIndex = 0
                ComboBox4.SelectedIndex = 0
                ComboBox9.SelectedIndex = 0
                ComboBox10.SelectedIndex = 0
                ComboBox11.SelectedIndex = 0
                ComboBox6.SelectedIndex = 111
            

        End If

        End if
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub



    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Use only numeric key")
        End Select
    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Form3.Visible = True
        Me.Visible = False

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form4.Visible = True
        Me.Visible = False
    End Sub

    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker



    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedIndex = 1 Or ComboBox5.SelectedIndex = 0 Then
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            ComboBox9.Visible = False
            ComboBox10.Visible = False
            ComboBox11.Visible = False
        End If
        If ComboBox5.SelectedIndex = 2 Then
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            ComboBox9.Visible = True
            ComboBox10.Visible = False
            ComboBox11.Visible = False
        End If

        If ComboBox5.SelectedIndex = 3 Then
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label25.Visible = True
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            ComboBox9.Visible = True
            ComboBox10.Visible = True
            ComboBox11.Visible = False
        End If

        If ComboBox5.SelectedIndex = 4 Then
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label25.Visible = True
            Label26.Visible = True
            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            ComboBox9.Visible = True
            ComboBox10.Visible = True
            ComboBox11.Visible = True
        End If
    End Sub


    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedIndex = 111 Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("SELECT")
            ComboBox7.Items.Add("Andaman & Nicobar")
            ComboBox7.Items.Add("Andhra Pradesh")
            ComboBox7.Items.Add("Arunachal Pradesh")
            ComboBox7.Items.Add("Assam")
            ComboBox7.Items.Add("Bihar")
            ComboBox7.Items.Add("Chandigarh")
            ComboBox7.Items.Add("Chhattisgarh")
            ComboBox7.Items.Add("Goa")
            ComboBox7.Items.Add("Gujarat")
            ComboBox7.Items.Add("Haryana")
            ComboBox7.Items.Add("Himachal Pradesh")
            ComboBox7.Items.Add("Jammu Kashmir")
            ComboBox7.Items.Add("Jharkhand")
            ComboBox7.Items.Add("Karnataka")
            ComboBox7.Items.Add("Kerala")
            ComboBox7.Items.Add("Madhya Pradesh")
            ComboBox7.Items.Add("Maharashtra")
            ComboBox7.Items.Add("Manipur")
            ComboBox7.Items.Add("Meghalaya")
            ComboBox7.Items.Add("Mizoram")
            ComboBox7.Items.Add("Nagaland")
            ComboBox7.Items.Add("Delhi")
            ComboBox7.Items.Add("Orissa")
            ComboBox7.Items.Add("Pondicherry")
            ComboBox7.Items.Add("Punjab")
            ComboBox7.Items.Add("Rajasthan")
            ComboBox7.Items.Add("Sikkim")
            ComboBox7.Items.Add("Tamil Nadu")
            ComboBox7.Items.Add("Tripura")
            ComboBox7.Items.Add("Uttar Pradesh")
            ComboBox7.Items.Add("Uttarakhand")
            ComboBox7.Items.Add("West Bengal")
            ComboBox7.Items.Add("Dadra and Nagar Haveli")
            ComboBox7.Items.Add("Daman and Diu")
            ComboBox7.Items.Add("Lakshadweep")
            ComboBox7.Items.Add("Other")
            ComboBox7.SelectedIndex = 0
        Else
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("SELECT")
            ComboBox7.Items.Add("Other")
            ComboBox7.SelectedIndex = 0
        End If
    End Sub
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedItem = "Other" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "SELECT" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Andaman & Nicobar" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("North and Middle Andaman")
            ComboBox8.Items.Add("Nicobar")
            ComboBox8.Items.Add("South Andaman")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Andhra Pradesh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Nellore")
            ComboBox8.Items.Add("Cuddapah")
            ComboBox8.Items.Add("Karim Nagar")
            ComboBox8.Items.Add("Kurnool")
            ComboBox8.Items.Add("West Godavari")
            ComboBox8.Items.Add("Srikakulam")
            ComboBox8.Items.Add("Anantpur")
            ComboBox8.Items.Add("Adilabad")
            ComboBox8.Items.Add("Chittor")
            ComboBox8.Items.Add("East Godavari")
            ComboBox8.Items.Add("Guntur")
            ComboBox8.Items.Add("Hyderabad Urban")
            ComboBox8.Items.Add("Khammam")
            ComboBox8.Items.Add("Krishna")
            ComboBox8.Items.Add("Mehboobnagar")
            ComboBox8.Items.Add("MaskedTextBox")
            ComboBox8.Items.Add("Nalgonda")
            ComboBox8.Items.Add("Nizamabad")
            ComboBox8.Items.Add("Prakasam")
            ComboBox8.Items.Add("Ranga Reddy")
            ComboBox8.Items.Add("Vishakapatnam")
            ComboBox8.Items.Add("Vizianagaram")
            ComboBox8.Items.Add("Warangal")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Arunachal Pradesh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Diban Valley( Anini Valley)")
            ComboBox8.Items.Add("East Kameng Seppa")
            ComboBox8.Items.Add("Itanagar")
            ComboBox8.Items.Add("East Siang (Passighat)")
            ComboBox8.Items.Add("Lohit(Tezu)")
            ComboBox8.Items.Add("Lower Subansiri(Ziro)")
            ComboBox8.Items.Add("Khonsa")
            ComboBox8.Items.Add("Roin")
            ComboBox8.Items.Add("Tawang")
            ComboBox8.Items.Add("Changalang")
            ComboBox8.Items.Add("Dibang Valley")
            ComboBox8.Items.Add("Daporijo")
            ComboBox8.Items.Add("Bomdila")
            ComboBox8.Items.Add("Alog( West Siang )")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Assam" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Karimganj")
            ComboBox8.Items.Add("Darrang")
            ComboBox8.Items.Add("Dibrugarh")
            ComboBox8.Items.Add("Morigaon")
            ComboBox8.Items.Add("Tinsukia")
            ComboBox8.Items.Add("Bongaigaon")
            ComboBox8.Items.Add("Nalbari")
            ComboBox8.Items.Add("Kokrajhar")
            ComboBox8.Items.Add("Kamrup")
            ComboBox8.Items.Add("Karbi-Anglong")
            ComboBox8.Items.Add("Nagaon")
            ComboBox8.Items.Add("N.C.Hills")
            ComboBox8.Items.Add("Dhemaji")
            ComboBox8.Items.Add("Hailakandi")
            ComboBox8.Items.Add("Lakhimpur")
            ComboBox8.Items.Add("Sonitpur")
            ComboBox8.Items.Add("Dhubri")
            ComboBox8.Items.Add("Goalpara")
            ComboBox8.Items.Add("Barpeta")
            ComboBox8.Items.Add("Golaghat")
            ComboBox8.Items.Add("Jorhat")
            ComboBox8.Items.Add("Sibsagar")
            ComboBox8.Items.Add("Cachar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Bihar" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Muzaffarpur")
            ComboBox8.Items.Add("Jehanabad")
            ComboBox8.Items.Add("Gaya")
            ComboBox8.Items.Add("Patna")
            ComboBox8.Items.Add("Saran Chapra")
            ComboBox8.Items.Add("Darbhanga")
            ComboBox8.Items.Add("Saharsa")
            ComboBox8.Items.Add("Purnea")
            ComboBox8.Items.Add("Bhagalpur")
            ComboBox8.Items.Add("Munger")
            ComboBox8.Items.Add("Aurangabad")
            ComboBox8.Items.Add("Bhojpur Arah")
            ComboBox8.Items.Add("Begusarai")
            ComboBox8.Items.Add("East Champaran")
            ComboBox8.Items.Add("Gopalganj")
            ComboBox8.Items.Add("Jamui")
            ComboBox8.Items.Add("Katihar")
            ComboBox8.Items.Add("Khagaria")
            ComboBox8.Items.Add("Madhepura")
            ComboBox8.Items.Add("Madhubani")
            ComboBox8.Items.Add("Nalanda")
            ComboBox8.Items.Add("Nawada")
            ComboBox8.Items.Add("Rohtas Sasaram")
            ComboBox8.Items.Add("Samastipur")
            ComboBox8.Items.Add("Sitamarhi")
            ComboBox8.Items.Add("Siwan")
            ComboBox8.Items.Add("Vaishali Hajipur")
            ComboBox8.Items.Add("West Champaran")
            ComboBox8.Items.Add("Kishanganj")
            ComboBox8.Items.Add("Araria")
            ComboBox8.Items.Add("Bhabua")
            ComboBox8.Items.Add("Banka")
            ComboBox8.Items.Add("Buxar")
            ComboBox8.Items.Add("Supaul")
            ComboBox8.Items.Add("Sekhpura")
            ComboBox8.Items.Add("Seohar")
            ComboBox8.Items.Add("Lakhisarai")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Chandigarh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Chandigarh")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Chhattisgarh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Bastar")
            ComboBox8.Items.Add("Bilaspur")
            ComboBox8.Items.Add("Dantewada")
            ComboBox8.Items.Add("Dhamtari")
            ComboBox8.Items.Add("Durg")
            ComboBox8.Items.Add("Janjgir-Champa")
            ComboBox8.Items.Add("Jashpur")
            ComboBox8.Items.Add("Kanker")
            ComboBox8.Items.Add("Kawardha")
            ComboBox8.Items.Add("Korba")
            ComboBox8.Items.Add("Koriya")
            ComboBox8.Items.Add("Mahasamund")
            ComboBox8.Items.Add("Raigarh")
            ComboBox8.Items.Add("Rajnandgaon")
            ComboBox8.Items.Add("Surguja")
            ComboBox8.Items.Add("Raipur")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Goa" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("North Goa")
            ComboBox8.Items.Add("South Goa")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Gujarat" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Panchmahals")
            ComboBox8.Items.Add("Vadodara")
            ComboBox8.Items.Add("Amrela")
            ComboBox8.Items.Add("Kheda")
            ComboBox8.Items.Add("Ahmedabad")
            ComboBox8.Items.Add("Valsad")
            ComboBox8.Items.Add("Junagadh")
            ComboBox8.Items.Add("Mehsana")
            ComboBox8.Items.Add("Banaskantha")
            ComboBox8.Items.Add("Gandhinagar")
            ComboBox8.Items.Add("Bharuch")
            ComboBox8.Items.Add("Dangs")
            ComboBox8.Items.Add("Jamnagar")
            ComboBox8.Items.Add("Rajkot")
            ComboBox8.Items.Add("Surat")
            ComboBox8.Items.Add("Sabarkantha")
            ComboBox8.Items.Add("Kutch")
            ComboBox8.Items.Add("Bhavnagar")
            ComboBox8.Items.Add("Surendranagar")
            ComboBox8.Items.Add("Navsari")
            ComboBox8.Items.Add("Anand")
            ComboBox8.Items.Add("Narmada")
            ComboBox8.Items.Add("Patan")
            ComboBox8.Items.Add("Porbander")
            ComboBox8.Items.Add("Dahod")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Haryana" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Gurgaon")
            ComboBox8.Items.Add("Rohtak")
            ComboBox8.Items.Add("Ambala")
            ComboBox8.Items.Add("Bhiwani")
            ComboBox8.Items.Add("Faridabad")
            ComboBox8.Items.Add("Hissar")
            ComboBox8.Items.Add("Jind")
            ComboBox8.Items.Add("Kaithal")
            ComboBox8.Items.Add("Karnal")
            ComboBox8.Items.Add("Kurukshetra")
            ComboBox8.Items.Add("Mahendragarh")
            ComboBox8.Items.Add("Panchkula")
            ComboBox8.Items.Add("Panipat")
            ComboBox8.Items.Add("Sonipat")
            ComboBox8.Items.Add("Yamunanagar")
            ComboBox8.Items.Add("Sirsa")
            ComboBox8.Items.Add("Rewari")
            ComboBox8.Items.Add("Jhanjhar")
            ComboBox8.Items.Add("Fatehabad")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Himachal Pradesh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Sirmour")
            ComboBox8.Items.Add("Hamirpur")
            ComboBox8.Items.Add("Kullu")
            ComboBox8.Items.Add("Solan")
            ComboBox8.Items.Add("Mandi")
            ComboBox8.Items.Add("Chamba")
            ComboBox8.Items.Add("Bilaspur")
            ComboBox8.Items.Add("Kangra")
            ComboBox8.Items.Add("Kinnaur")
            ComboBox8.Items.Add("Lahaul-Spiti")
            ComboBox8.Items.Add("Shimla")
            ComboBox8.Items.Add("Una")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Jammu Kashmir" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Kathua")
            ComboBox8.Items.Add("Badgan")
            ComboBox8.Items.Add("Poonch")
            ComboBox8.Items.Add("Rajauri")
            ComboBox8.Items.Add("Baramula")
            ComboBox8.Items.Add("Doda")
            ComboBox8.Items.Add("Udhampur")
            ComboBox8.Items.Add("Jammu")
            ComboBox8.Items.Add("Kupwara")
            ComboBox8.Items.Add("Pulwama")
            ComboBox8.Items.Add("Anantnag")
            ComboBox8.Items.Add("Srinagar")
            ComboBox8.Items.Add("Leh")
            ComboBox8.Items.Add("Kargil")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Jharkhand" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Deoghar")
            ComboBox8.Items.Add("Dhanbad")
            ComboBox8.Items.Add("Giridih")
            ComboBox8.Items.Add("Godda")
            ComboBox8.Items.Add("Gumla")
            ComboBox8.Items.Add("Hazaribagh")
            ComboBox8.Items.Add("Lohardaga")
            ComboBox8.Items.Add("Palamu")
            ComboBox8.Items.Add("Ranchi")
            ComboBox8.Items.Add("Dumka")
            ComboBox8.Items.Add("Chaibasa West Singhbhum")
            ComboBox8.Items.Add("Jamshedpur East Singhbhum")
            ComboBox8.Items.Add("Bokaro")
            ComboBox8.Items.Add("Chatra")
            ComboBox8.Items.Add("Garhwa")
            ComboBox8.Items.Add("Koderma")
            ComboBox8.Items.Add("Pakur")
            ComboBox8.Items.Add("Sahebganj")
            ComboBox8.Items.Add("Simdega")
            ComboBox8.Items.Add("Latehar")
            ComboBox8.Items.Add("Saraikela")
            ComboBox8.Items.Add("Jamtara")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Karnataka" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Mysore")
            ComboBox8.Items.Add("Gulberga")
            ComboBox8.Items.Add("Chitradurga")
            ComboBox8.Items.Add("Kolar")
            ComboBox8.Items.Add("Bijapur")
            ComboBox8.Items.Add("Dakshina Kannada")
            ComboBox8.Items.Add("Raichur")
            ComboBox8.Items.Add("Bellary")
            ComboBox8.Items.Add("Belgaum")
            ComboBox8.Items.Add("Hassan")
            ComboBox8.Items.Add("Dharwad")
            ComboBox8.Items.Add("Bangalore Rural")
            ComboBox8.Items.Add("Shimoga")
            ComboBox8.Items.Add("Mandya")
            ComboBox8.Items.Add("Chickmagalur")
            ComboBox8.Items.Add("Bangalore Urban")
            ComboBox8.Items.Add("Madikeri")
            ComboBox8.Items.Add("Tumkur")
            ComboBox8.Items.Add("Bidar")
            ComboBox8.Items.Add("Karwar")
            ComboBox8.Items.Add("Udupi")
            ComboBox8.Items.Add("Davanagare")
            ComboBox8.Items.Add("Chamrajnagar")
            ComboBox8.Items.Add("Koppal")
            ComboBox8.Items.Add("Haveri")
            ComboBox8.Items.Add("Gadak")
            ComboBox8.Items.Add("Yadgir")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Kerala" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Kozhikode")
            ComboBox8.Items.Add("Kasaragod")
            ComboBox8.Items.Add("Idukki")
            ComboBox8.Items.Add("Ernakulam")
            ComboBox8.Items.Add("Cannanore")
            ComboBox8.Items.Add("Mallapuram")
            ComboBox8.Items.Add("Palghat")
            ComboBox8.Items.Add("Pathanamthitta")
            ComboBox8.Items.Add("Quilon")
            ComboBox8.Items.Add("Trichur")
            ComboBox8.Items.Add("Wayanad")
            ComboBox8.Items.Add("Trivandrum")
            ComboBox8.Items.Add("Kottayam")
            ComboBox8.Items.Add("Alapuzzha")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Madhya Pradesh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Sindi")
            ComboBox8.Items.Add("Vidisha")
            ComboBox8.Items.Add("Jabalpur")
            ComboBox8.Items.Add("Bhopal")
            ComboBox8.Items.Add("Hoshangabad")
            ComboBox8.Items.Add("Indore")
            ComboBox8.Items.Add("Rewa")
            ComboBox8.Items.Add("Satna")
            ComboBox8.Items.Add("Shahdol")
            ComboBox8.Items.Add("Chhindwara")
            ComboBox8.Items.Add("Ratlam")
            ComboBox8.Items.Add("Balaghat")
            ComboBox8.Items.Add("Betul")
            ComboBox8.Items.Add("Bhind")
            ComboBox8.Items.Add("Mandla")
            ComboBox8.Items.Add("Chhattarpur")
            ComboBox8.Items.Add("Damoh")
            ComboBox8.Items.Add("Datia")
            ComboBox8.Items.Add("Dewas")
            ComboBox8.Items.Add("Dhar")
            ComboBox8.Items.Add("Guna")
            ComboBox8.Items.Add("Gwalior")
            ComboBox8.Items.Add("Jhabua")
            ComboBox8.Items.Add("Sehore")
            ComboBox8.Items.Add("Mandsaur")
            ComboBox8.Items.Add("Narsinghpur")
            ComboBox8.Items.Add("Panna")
            ComboBox8.Items.Add("Raisen")
            ComboBox8.Items.Add("Rajgarh")
            ComboBox8.Items.Add("Sagar")
            ComboBox8.Items.Add("Seoni")
            ComboBox8.Items.Add("Morena")
            ComboBox8.Items.Add("Shivpuri")
            ComboBox8.Items.Add("Shajapur")
            ComboBox8.Items.Add("Tikamgarh")
            ComboBox8.Items.Add("Ujjain")
            ComboBox8.Items.Add("Khandwa")
            ComboBox8.Items.Add("Khargone")
            ComboBox8.Items.Add("Dindori")
            ComboBox8.Items.Add("Umaria")
            ComboBox8.Items.Add("Badwani")
            ComboBox8.Items.Add("Sheopur")
            ComboBox8.Items.Add("Katni")
            ComboBox8.Items.Add("Neemuch")
            ComboBox8.Items.Add("Harda")
            ComboBox8.Items.Add("Anooppur")
            ComboBox8.Items.Add("Burhanpur")
            ComboBox8.Items.Add("Ashoknagar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Maharashtra" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Aurangabad")
            ComboBox8.Items.Add("Bandra(Mumbai Suburban district)")
            ComboBox8.Items.Add("Nagpur")
            ComboBox8.Items.Add("Pune")
            ComboBox8.Items.Add("Akola")
            ComboBox8.Items.Add("Chandrapur")
            ComboBox8.Items.Add("Jalgaon")
            ComboBox8.Items.Add("Parbhani")
            ComboBox8.Items.Add("Sholapur")
            ComboBox8.Items.Add("Thane")
            ComboBox8.Items.Add("Latur")
            ComboBox8.Items.Add("Mumbai-City")
            ComboBox8.Items.Add("Buldhana")
            ComboBox8.Items.Add("Dhule")
            ComboBox8.Items.Add("Kolhpur")
            ComboBox8.Items.Add("Nanded")
            ComboBox8.Items.Add("Raigad")
            ComboBox8.Items.Add("Amravati")
            ComboBox8.Items.Add("Nashik")
            ComboBox8.Items.Add("Wardha")
            ComboBox8.Items.Add("Ahmednagar")
            ComboBox8.Items.Add("Beed")
            ComboBox8.Items.Add("Bhandara")
            ComboBox8.Items.Add("Gadchiroli")
            ComboBox8.Items.Add("Jalna")
            ComboBox8.Items.Add("Osmanabad")
            ComboBox8.Items.Add("Ratnagiri")
            ComboBox8.Items.Add("Sangli")
            ComboBox8.Items.Add("Satara")
            ComboBox8.Items.Add("Sindudurg")
            ComboBox8.Items.Add("Yavatmal")
            ComboBox8.Items.Add("Nandurbar")
            ComboBox8.Items.Add("Washim")
            ComboBox8.Items.Add("Gondia")
            ComboBox8.Items.Add("Hingoli")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Manipur" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Imphal East")
            ComboBox8.Items.Add("Imphal West")
            ComboBox8.Items.Add("Thoubal")
            ComboBox8.Items.Add("Bishnupur")
            ComboBox8.Items.Add("Chandel")
            ComboBox8.Items.Add("Churachandpur")
            ComboBox8.Items.Add("Senapati")
            ComboBox8.Items.Add("Ukhrul")
            ComboBox8.Items.Add("Tamenglong")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Meghalaya" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Ri-Bhoi District")
            ComboBox8.Items.Add("South Garo Hills")
            ComboBox8.Items.Add("East Khasi Hill")
            ComboBox8.Items.Add("East Garo Hill")
            ComboBox8.Items.Add("West Garo Hill")
            ComboBox8.Items.Add("Jaintia Hill")
            ComboBox8.Items.Add("West Khasi Hill")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Mizoram" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Luglei District")
            ComboBox8.Items.Add("Chimtipui District")
            ComboBox8.Items.Add("Aizawal")
            ComboBox8.Items.Add("Champhai")
            ComboBox8.Items.Add("Mamit")
            ComboBox8.Items.Add("Kolasib")
            ComboBox8.Items.Add("Serchhip")
            ComboBox8.Items.Add("Lawngtlai")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Nagaland" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Wokha")
            ComboBox8.Items.Add("Phek")
            ComboBox8.Items.Add("Tuensang")
            ComboBox8.Items.Add("Mon")
            ComboBox8.Items.Add("Kohima")
            ComboBox8.Items.Add("Zunheboto")
            ComboBox8.Items.Add("Mokokchung")
            ComboBox8.Items.Add("Dimapur")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Delhi" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("New Delhi")
            ComboBox8.Items.Add("Central")
            ComboBox8.Items.Add("North")
            ComboBox8.Items.Add("North West")
            ComboBox8.Items.Add("West")
            ComboBox8.Items.Add("South West")
            ComboBox8.Items.Add("North")
            ComboBox8.Items.Add("North East")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Orissa" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Khurda")
            ComboBox8.Items.Add("Navaragpur")
            ComboBox8.Items.Add("Navapada")
            ComboBox8.Items.Add("Gajapati")
            ComboBox8.Items.Add("Boudh")
            ComboBox8.Items.Add("Bhadrak")
            ComboBox8.Items.Add("Ganjam")
            ComboBox8.Items.Add("Dhenkanal")
            ComboBox8.Items.Add("Angul")
            ComboBox8.Items.Add("Puri")
            ComboBox8.Items.Add("Cuttak")
            ComboBox8.Items.Add("Sambalpur")
            ComboBox8.Items.Add("Kalhandi")
            ComboBox8.Items.Add("Koraput")
            ComboBox8.Items.Add("Phulbani")
            ComboBox8.Items.Add("Balangir")
            ComboBox8.Items.Add("Bargah")
            ComboBox8.Items.Add("Deogarh")
            ComboBox8.Items.Add("Jagatsinghpur")
            ComboBox8.Items.Add("Jajpur")
            ComboBox8.Items.Add("Jharsuguda")
            ComboBox8.Items.Add("Kendrapara")
            ComboBox8.Items.Add("Malkangiri")
            ComboBox8.Items.Add("Nayagarh")
            ComboBox8.Items.Add("Rayagada")
            ComboBox8.Items.Add("Sonepur")
            ComboBox8.Items.Add("Balasore")
            ComboBox8.Items.Add("Mayurbhanj")
            ComboBox8.Items.Add("Keonjhar")
            ComboBox8.Items.Add("Sundergarh")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Pondicherry" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Karikal")
            ComboBox8.Items.Add("Mahe")
            ComboBox8.Items.Add("Yaman")
            ComboBox8.Items.Add("Pondicherry")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Punjab" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Sangrur")
            ComboBox8.Items.Add("Jalandhar")
            ComboBox8.Items.Add("Ludhiana")
            ComboBox8.Items.Add("Bhatinda")
            ComboBox8.Items.Add("Kapurthala")
            ComboBox8.Items.Add("Patiala")
            ComboBox8.Items.Add("Amritsar")
            ComboBox8.Items.Add("Ferozepur")
            ComboBox8.Items.Add("Fatehgarh Saheb")
            ComboBox8.Items.Add("Ropar")
            ComboBox8.Items.Add("Gurdaspur")
            ComboBox8.Items.Add("Hosiarpur")
            ComboBox8.Items.Add("Faridkot")
            ComboBox8.Items.Add("Mansa")
            ComboBox8.Items.Add("Moga")
            ComboBox8.Items.Add("Muktsar")
            ComboBox8.Items.Add("Navansahar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Rajasthan" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Jaipur")
            ComboBox8.Items.Add("Barmer")
            ComboBox8.Items.Add("Dungarpur")
            ComboBox8.Items.Add("Jodhpur")
            ComboBox8.Items.Add("Kota")
            ComboBox8.Items.Add("Udaipur")
            ComboBox8.Items.Add("Bikaner")
            ComboBox8.Items.Add("Dausa")
            ComboBox8.Items.Add("Bundi")
            ComboBox8.Items.Add("Sikar")
            ComboBox8.Items.Add("Tonk")
            ComboBox8.Items.Add("Jaisalmer")
            ComboBox8.Items.Add("Nagaur")
            ComboBox8.Items.Add("Rajsamand")
            ComboBox8.Items.Add("Banswara")
            ComboBox8.Items.Add("Bhilwara")
            ComboBox8.Items.Add("Ajmer")
            ComboBox8.Items.Add("Alwar")
            ComboBox8.Items.Add("Bharatpur")
            ComboBox8.Items.Add("Chittorgarh")
            ComboBox8.Items.Add("Churu")
            ComboBox8.Items.Add("Dholpur")
            ComboBox8.Items.Add("Ganganagar")
            ComboBox8.Items.Add("Jalor")
            ComboBox8.Items.Add("Jhalawar")
            ComboBox8.Items.Add("Jhunjhunu")
            ComboBox8.Items.Add("Pali")
            ComboBox8.Items.Add("Sawai Madhopur")
            ComboBox8.Items.Add("Sirohi")
            ComboBox8.Items.Add("Baran")
            ComboBox8.Items.Add("Hanumangarh")
            ComboBox8.Items.Add("Karauli")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Sikkim" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("East")
            ComboBox8.Items.Add("South")
            ComboBox8.Items.Add("West")
            ComboBox8.Items.Add("North")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Tamil Nadu" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Chennai")
            ComboBox8.Items.Add("Coimbotore")
            ComboBox8.Items.Add("Cuddalorei")
            ComboBox8.Items.Add("Dharmapuri")
            ComboBox8.Items.Add("Dindigul")
            ComboBox8.Items.Add("Erode")
            ComboBox8.Items.Add("Kancheepuram")
            ComboBox8.Items.Add("Kanniyakumari (HQ : Nagercoil)")
            ComboBox8.Items.Add("Karur")
            ComboBox8.Items.Add("Madurai")
            ComboBox8.Items.Add("Nagapattinam")
            ComboBox8.Items.Add("Namakkal")
            ComboBox8.Items.Add("Nilgiris (HQ: Udhagamandalam)")
            ComboBox8.Items.Add("Perambalur")
            ComboBox8.Items.Add("Pudukkottai")
            ComboBox8.Items.Add("Ramanathapuram")
            ComboBox8.Items.Add("Salem")
            ComboBox8.Items.Add("Sivaganga")
            ComboBox8.Items.Add("Thanjavur")
            ComboBox8.Items.Add("Theni")
            ComboBox8.Items.Add("Thoothkudi")
            ComboBox8.Items.Add("Tiruchiorappalli")
            ComboBox8.Items.Add("Tirunelveli")
            ComboBox8.Items.Add("Tiruvallur")
            ComboBox8.Items.Add("Tiruvannamalai")
            ComboBox8.Items.Add("Tiruvarur")
            ComboBox8.Items.Add("Vellore")
            ComboBox8.Items.Add("Villupuram")
            ComboBox8.Items.Add("Virudhunagar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Tripura" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("North District")
            ComboBox8.Items.Add("South District")
            ComboBox8.Items.Add("West District")
            ComboBox8.Items.Add("Dhalai District")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Uttar Pradesh" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Allahabad")
            ComboBox8.Items.Add("Aligarh")
            ComboBox8.Items.Add("Azamgarh")
            ComboBox8.Items.Add("Bareilly")
            ComboBox8.Items.Add("Gonda")
            ComboBox8.Items.Add("Hardoi")
            ComboBox8.Items.Add("Kanpur Dehat")
            ComboBox8.Items.Add("Ghaziabad")
            ComboBox8.Items.Add("Unnav")
            ComboBox8.Items.Add("Varanasi")
            ComboBox8.Items.Add("Faizabad")
            ComboBox8.Items.Add("Gorakpur")
            ComboBox8.Items.Add("Jhansi")
            ComboBox8.Items.Add("Lucknow")
            ComboBox8.Items.Add("Agra")
            ComboBox8.Items.Add("Meerut")
            ComboBox8.Items.Add("Moradabad")
            ComboBox8.Items.Add("Barabanki")
            ComboBox8.Items.Add("Mainpuri")
            ComboBox8.Items.Add("Etawah")
            ComboBox8.Items.Add("Gazipur")
            ComboBox8.Items.Add("Etah")
            ComboBox8.Items.Add("Muzaffar Nagar")
            ComboBox8.Items.Add("Saharanpur")
            ComboBox8.Items.Add("Bulandshehar")
            ComboBox8.Items.Add("Mathura")
            ComboBox8.Items.Add("Firozabad")
            ComboBox8.Items.Add("Budaun")
            ComboBox8.Items.Add("Shahjahanpur")
            ComboBox8.Items.Add("Pilibhit")
            ComboBox8.Items.Add("Bijnor")
            ComboBox8.Items.Add("Rampur")
            ComboBox8.Items.Add("Kanpur Nagar")
            ComboBox8.Items.Add("Farrukhabad")
            ComboBox8.Items.Add("Fatehpur")
            ComboBox8.Items.Add("Pratapgarh")
            ComboBox8.Items.Add("Jalaun")
            ComboBox8.Items.Add("Hamirpur")
            ComboBox8.Items.Add("Lalitpur")
            ComboBox8.Items.Add("Mirzapur")
            ComboBox8.Items.Add("Basti")
            ComboBox8.Items.Add("Deoria")
            ComboBox8.Items.Add("Raebareili")
            ComboBox8.Items.Add("Sitapur")
            ComboBox8.Items.Add("Banda")
            ComboBox8.Items.Add("Lakhimpur-Khedi")
            ComboBox8.Items.Add("Bahraich")
            ComboBox8.Items.Add("Sultanpur")
            ComboBox8.Items.Add("Mau")
            ComboBox8.Items.Add("Azamgarh")
            ComboBox8.Items.Add("Jaunpur")
            ComboBox8.Items.Add("Balia")
            ComboBox8.Items.Add("Bhadoi")
            ComboBox8.Items.Add("Padrauna")
            ComboBox8.Items.Add("Maharajganj")
            ComboBox8.Items.Add("SiddharthNagar")
            ComboBox8.Items.Add("Sunbhadra")
            ComboBox8.Items.Add("Mahoba")
            ComboBox8.Items.Add("Ambedkarnagar")
            ComboBox8.Items.Add("Gautam Bodda Nagar")
            ComboBox8.Items.Add("Maha Maya Nagar")
            ComboBox8.Items.Add("jyotiba Phoole Nagar")
            ComboBox8.Items.Add("Kaushambi")
            ComboBox8.Items.Add("Shooji Maharaj")
            ComboBox8.Items.Add("Chandauli")
            ComboBox8.Items.Add("Balrampur")
            ComboBox8.Items.Add("Shravati")
            ComboBox8.Items.Add("Bagpat")
            ComboBox8.Items.Add("Kanooj")
            ComboBox8.Items.Add("Oraiyya")
            ComboBox8.Items.Add("Sant Kabir Nagar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Uttarakhand" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Nainital")
            ComboBox8.Items.Add("Almora")
            ComboBox8.Items.Add("Pitoragarh")
            ComboBox8.Items.Add("Udhamsingh Nagar")
            ComboBox8.Items.Add("Bageshwar")
            ComboBox8.Items.Add("Champawat")
            ComboBox8.Items.Add("Garhwal Pauri")
            ComboBox8.Items.Add("Tehri-Garhwal")
            ComboBox8.Items.Add("Chamoli Gopeshwar")
            ComboBox8.Items.Add("Uttarkashi")
            ComboBox8.Items.Add("Dehradun")
            ComboBox8.Items.Add("Rudraprayag")
            ComboBox8.Items.Add("Haridwar")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "West Bengal" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Howrah")
            ComboBox8.Items.Add("Darjeeling")
            ComboBox8.Items.Add("Medinipur")
            ComboBox8.Items.Add("Murshidabad")
            ComboBox8.Items.Add("Coochbehar")
            ComboBox8.Items.Add("Malda")
            ComboBox8.Items.Add("Birbhum")
            ComboBox8.Items.Add("North 24 Parganas")
            ComboBox8.Items.Add("South 24 Parganas")
            ComboBox8.Items.Add("Bankura")
            ComboBox8.Items.Add("Bardhaman")
            ComboBox8.Items.Add("Jalpaiguri")
            ComboBox8.Items.Add("Hooghly")
            ComboBox8.Items.Add("Nadia")
            ComboBox8.Items.Add("Dakshin Dinajpur")
            ComboBox8.Items.Add("Purulia")
            ComboBox8.Items.Add("Uttar Dinajpur")
            ComboBox8.Items.Add("Siliguri")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Dadra and Nagar Haveli" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Dadra")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Daman and Diu" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Dama")
            ComboBox8.Items.Add("Diu")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Lakshadweep" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Lakshdweep")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        ElseIf ComboBox7.SelectedItem = "Other" Then
            ComboBox8.Items.Clear()
            ComboBox8.Items.Add("SELECT")
            ComboBox8.Items.Add("Other")
            ComboBox8.SelectedIndex = 0
        End If
    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button



    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        Form2.Visible = True
        Me.Visible = False

    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker1.Value = DateTime.Now
       
    End Sub

End Class
