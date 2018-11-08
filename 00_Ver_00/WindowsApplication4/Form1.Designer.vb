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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Butt_set_Scale = New System.Windows.Forms.Button()
        Me.Text_scale = New System.Windows.Forms.TextBox()
        Me.Butt_select = New System.Windows.Forms.Button()
        Me.Zinbutt = New System.Windows.Forms.Button()
        Me.Setup = New System.Windows.Forms.Button()
        Me.Start_bending = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Start_points = New System.Windows.Forms.Button()
        Me.Zoutbutt = New System.Windows.Forms.Button()
        Me.Open_butt = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Butt_Ext_Clamp_B = New System.Windows.Forms.Button()
        Me.Butt_Ext_Clamp_A = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Butt_Ext_HomeB = New System.Windows.Forms.Button()
        Me.Butt_Ext_HomeA = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Text_Ext_Forward = New System.Windows.Forms.TextBox()
        Me.Text_Ext_Previous = New System.Windows.Forms.TextBox()
        Me.Butt_extrude_fwd = New System.Windows.Forms.Button()
        Me.Butt_extrude_previous = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Butt_Cutter_Angle_Home = New System.Windows.Forms.Button()
        Me.Butt_cutter_angle_plus = New System.Windows.Forms.Button()
        Me.Butt_Cutter_angle_minus = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Butt_cutter_Grind_Start = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Butt_cutter_lifter_home = New System.Windows.Forms.Button()
        Me.Butt_Cutter_lift_down = New System.Windows.Forms.Button()
        Me.Butt_Cutter_lift_up = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mssg = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Send = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.ComboBox_AvailableSerialPorts = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_lich_su_1 = New System.Windows.Forms.TextBox()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Butt_set_Scale
        '
        Me.Butt_set_Scale.Location = New System.Drawing.Point(505, 2)
        Me.Butt_set_Scale.Name = "Butt_set_Scale"
        Me.Butt_set_Scale.Size = New System.Drawing.Size(67, 30)
        Me.Butt_set_Scale.TabIndex = 49
        Me.Butt_set_Scale.Text = "Set Scale"
        Me.Butt_set_Scale.UseVisualStyleBackColor = True
        '
        'Text_scale
        '
        Me.Text_scale.Location = New System.Drawing.Point(452, 8)
        Me.Text_scale.Name = "Text_scale"
        Me.Text_scale.Size = New System.Drawing.Size(47, 20)
        Me.Text_scale.TabIndex = 48
        Me.Text_scale.Text = "100"
        '
        'Butt_select
        '
        Me.Butt_select.Location = New System.Drawing.Point(379, 2)
        Me.Butt_select.Name = "Butt_select"
        Me.Butt_select.Size = New System.Drawing.Size(67, 30)
        Me.Butt_select.TabIndex = 47
        Me.Butt_select.Text = "Select"
        Me.Butt_select.UseVisualStyleBackColor = True
        '
        'Zinbutt
        '
        Me.Zinbutt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Zinbutt.BackgroundImage = CType(resources.GetObject("Zinbutt.BackgroundImage"), System.Drawing.Image)
        Me.Zinbutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Zinbutt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zinbutt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Zinbutt.Location = New System.Drawing.Point(51, 2)
        Me.Zinbutt.Name = "Zinbutt"
        Me.Zinbutt.Size = New System.Drawing.Size(29, 30)
        Me.Zinbutt.TabIndex = 46
        Me.Zinbutt.UseVisualStyleBackColor = False
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(306, 2)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(67, 30)
        Me.Setup.TabIndex = 45
        Me.Setup.Text = "SET UP"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'Start_bending
        '
        Me.Start_bending.BackColor = System.Drawing.SystemColors.Info
        Me.Start_bending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_bending.Location = New System.Drawing.Point(677, 2)
        Me.Start_bending.Name = "Start_bending"
        Me.Start_bending.Size = New System.Drawing.Size(79, 30)
        Me.Start_bending.TabIndex = 44
        Me.Start_bending.Text = "START"
        Me.Start_bending.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 30)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 30)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Start_points
        '
        Me.Start_points.Location = New System.Drawing.Point(225, 2)
        Me.Start_points.Name = "Start_points"
        Me.Start_points.Size = New System.Drawing.Size(75, 30)
        Me.Start_points.TabIndex = 41
        Me.Start_points.Text = "Start points"
        Me.Start_points.UseVisualStyleBackColor = True
        '
        'Zoutbutt
        '
        Me.Zoutbutt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Zoutbutt.BackgroundImage = CType(resources.GetObject("Zoutbutt.BackgroundImage"), System.Drawing.Image)
        Me.Zoutbutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Zoutbutt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zoutbutt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Zoutbutt.Location = New System.Drawing.Point(86, 2)
        Me.Zoutbutt.Name = "Zoutbutt"
        Me.Zoutbutt.Size = New System.Drawing.Size(29, 30)
        Me.Zoutbutt.TabIndex = 40
        Me.Zoutbutt.UseVisualStyleBackColor = False
        '
        'Open_butt
        '
        Me.Open_butt.BackgroundImage = CType(resources.GetObject("Open_butt.BackgroundImage"), System.Drawing.Image)
        Me.Open_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Open_butt.Location = New System.Drawing.Point(12, 2)
        Me.Open_butt.Name = "Open_butt"
        Me.Open_butt.Size = New System.Drawing.Size(33, 30)
        Me.Open_butt.TabIndex = 39
        Me.Open_butt.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(762, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(259, 240)
        Me.GroupBox6.TabIndex = 50
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "EXTRUDE CONTROL"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Butt_Ext_Clamp_B)
        Me.GroupBox8.Controls.Add(Me.Butt_Ext_Clamp_A)
        Me.GroupBox8.Location = New System.Drawing.Point(22, 155)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(218, 78)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Clamp control"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(132, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Clamp B"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Clamp A"
        '
        'Butt_Ext_Clamp_B
        '
        Me.Butt_Ext_Clamp_B.Location = New System.Drawing.Point(121, 28)
        Me.Butt_Ext_Clamp_B.Name = "Butt_Ext_Clamp_B"
        Me.Butt_Ext_Clamp_B.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Ext_Clamp_B.TabIndex = 0
        Me.Butt_Ext_Clamp_B.Text = "CLAMP"
        Me.Butt_Ext_Clamp_B.UseVisualStyleBackColor = True
        '
        'Butt_Ext_Clamp_A
        '
        Me.Butt_Ext_Clamp_A.Location = New System.Drawing.Point(15, 28)
        Me.Butt_Ext_Clamp_A.Name = "Butt_Ext_Clamp_A"
        Me.Butt_Ext_Clamp_A.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Ext_Clamp_A.TabIndex = 2
        Me.Butt_Ext_Clamp_A.Text = "CLAMP"
        Me.Butt_Ext_Clamp_A.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox7.Controls.Add(Me.Butt_Ext_HomeB)
        Me.GroupBox7.Controls.Add(Me.Butt_Ext_HomeA)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Text_Ext_Forward)
        Me.GroupBox7.Controls.Add(Me.Text_Ext_Previous)
        Me.GroupBox7.Controls.Add(Me.Butt_extrude_fwd)
        Me.GroupBox7.Controls.Add(Me.Butt_extrude_previous)
        Me.GroupBox7.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(218, 130)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Movement control"
        '
        'Butt_Ext_HomeB
        '
        Me.Butt_Ext_HomeB.BackColor = System.Drawing.SystemColors.Info
        Me.Butt_Ext_HomeB.Location = New System.Drawing.Point(121, 94)
        Me.Butt_Ext_HomeB.Name = "Butt_Ext_HomeB"
        Me.Butt_Ext_HomeB.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Ext_HomeB.TabIndex = 8
        Me.Butt_Ext_HomeB.Text = "HOME at B"
        Me.Butt_Ext_HomeB.UseVisualStyleBackColor = False
        '
        'Butt_Ext_HomeA
        '
        Me.Butt_Ext_HomeA.BackColor = System.Drawing.SystemColors.Info
        Me.Butt_Ext_HomeA.Location = New System.Drawing.Point(15, 94)
        Me.Butt_Ext_HomeA.Name = "Butt_Ext_HomeA"
        Me.Butt_Ext_HomeA.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Ext_HomeA.TabIndex = 7
        Me.Butt_Ext_HomeA.Text = "HOME at A"
        Me.Butt_Ext_HomeA.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(124, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "mm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "mm"
        '
        'Text_Ext_Forward
        '
        Me.Text_Ext_Forward.Location = New System.Drawing.Point(121, 19)
        Me.Text_Ext_Forward.Name = "Text_Ext_Forward"
        Me.Text_Ext_Forward.Size = New System.Drawing.Size(75, 20)
        Me.Text_Ext_Forward.TabIndex = 4
        Me.Text_Ext_Forward.Text = "100"
        '
        'Text_Ext_Previous
        '
        Me.Text_Ext_Previous.Location = New System.Drawing.Point(15, 19)
        Me.Text_Ext_Previous.Name = "Text_Ext_Previous"
        Me.Text_Ext_Previous.Size = New System.Drawing.Size(75, 20)
        Me.Text_Ext_Previous.TabIndex = 3
        Me.Text_Ext_Previous.Text = "100"
        '
        'Butt_extrude_fwd
        '
        Me.Butt_extrude_fwd.Location = New System.Drawing.Point(121, 55)
        Me.Butt_extrude_fwd.Name = "Butt_extrude_fwd"
        Me.Butt_extrude_fwd.Size = New System.Drawing.Size(75, 33)
        Me.Butt_extrude_fwd.TabIndex = 0
        Me.Butt_extrude_fwd.Text = "Forward(+)"
        Me.Butt_extrude_fwd.UseVisualStyleBackColor = True
        '
        'Butt_extrude_previous
        '
        Me.Butt_extrude_previous.Location = New System.Drawing.Point(15, 55)
        Me.Butt_extrude_previous.Name = "Butt_extrude_previous"
        Me.Butt_extrude_previous.Size = New System.Drawing.Size(75, 33)
        Me.Butt_extrude_previous.TabIndex = 2
        Me.Butt_extrude_previous.Text = "Previous(-)"
        Me.Butt_extrude_previous.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.GroupBox11)
        Me.GroupBox9.Location = New System.Drawing.Point(762, 258)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(259, 270)
        Me.GroupBox9.TabIndex = 51
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "CUTTER CONTROL"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox12.Controls.Add(Me.Butt_Cutter_Angle_Home)
        Me.GroupBox12.Controls.Add(Me.Butt_cutter_angle_plus)
        Me.GroupBox12.Controls.Add(Me.Butt_Cutter_angle_minus)
        Me.GroupBox12.Location = New System.Drawing.Point(22, 113)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(218, 84)
        Me.GroupBox12.TabIndex = 4
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Angle control"
        '
        'Butt_Cutter_Angle_Home
        '
        Me.Butt_Cutter_Angle_Home.BackColor = System.Drawing.SystemColors.Info
        Me.Butt_Cutter_Angle_Home.Location = New System.Drawing.Point(121, 48)
        Me.Butt_Cutter_Angle_Home.Name = "Butt_Cutter_Angle_Home"
        Me.Butt_Cutter_Angle_Home.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Cutter_Angle_Home.TabIndex = 4
        Me.Butt_Cutter_Angle_Home.Text = "HOME"
        Me.Butt_Cutter_Angle_Home.UseVisualStyleBackColor = False
        '
        'Butt_cutter_angle_plus
        '
        Me.Butt_cutter_angle_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Butt_cutter_angle_plus.Location = New System.Drawing.Point(121, 14)
        Me.Butt_cutter_angle_plus.Name = "Butt_cutter_angle_plus"
        Me.Butt_cutter_angle_plus.Size = New System.Drawing.Size(75, 33)
        Me.Butt_cutter_angle_plus.TabIndex = 0
        Me.Butt_cutter_angle_plus.Text = "+"
        Me.Butt_cutter_angle_plus.UseVisualStyleBackColor = True
        '
        'Butt_Cutter_angle_minus
        '
        Me.Butt_Cutter_angle_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Butt_Cutter_angle_minus.Location = New System.Drawing.Point(15, 14)
        Me.Butt_Cutter_angle_minus.Name = "Butt_Cutter_angle_minus"
        Me.Butt_Cutter_angle_minus.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Cutter_angle_minus.TabIndex = 2
        Me.Butt_Cutter_angle_minus.Text = "-"
        Me.Butt_Cutter_angle_minus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Butt_Cutter_angle_minus.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox10.Controls.Add(Me.Butt_cutter_Grind_Start)
        Me.GroupBox10.Location = New System.Drawing.Point(22, 205)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(218, 60)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Grinder control"
        '
        'Butt_cutter_Grind_Start
        '
        Me.Butt_cutter_Grind_Start.BackColor = System.Drawing.SystemColors.Highlight
        Me.Butt_cutter_Grind_Start.Location = New System.Drawing.Point(69, 21)
        Me.Butt_cutter_Grind_Start.Name = "Butt_cutter_Grind_Start"
        Me.Butt_cutter_Grind_Start.Size = New System.Drawing.Size(75, 33)
        Me.Butt_cutter_Grind_Start.TabIndex = 0
        Me.Butt_cutter_Grind_Start.Text = "START"
        Me.Butt_cutter_Grind_Start.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox11.Controls.Add(Me.Butt_cutter_lifter_home)
        Me.GroupBox11.Controls.Add(Me.Butt_Cutter_lift_down)
        Me.GroupBox11.Controls.Add(Me.Butt_Cutter_lift_up)
        Me.GroupBox11.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(218, 88)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Lifter control"
        '
        'Butt_cutter_lifter_home
        '
        Me.Butt_cutter_lifter_home.BackColor = System.Drawing.SystemColors.Info
        Me.Butt_cutter_lifter_home.Location = New System.Drawing.Point(121, 50)
        Me.Butt_cutter_lifter_home.Name = "Butt_cutter_lifter_home"
        Me.Butt_cutter_lifter_home.Size = New System.Drawing.Size(75, 33)
        Me.Butt_cutter_lifter_home.TabIndex = 3
        Me.Butt_cutter_lifter_home.Text = "HOME"
        Me.Butt_cutter_lifter_home.UseVisualStyleBackColor = False
        '
        'Butt_Cutter_lift_down
        '
        Me.Butt_Cutter_lift_down.Location = New System.Drawing.Point(121, 16)
        Me.Butt_Cutter_lift_down.Name = "Butt_Cutter_lift_down"
        Me.Butt_Cutter_lift_down.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Cutter_lift_down.TabIndex = 0
        Me.Butt_Cutter_lift_down.Text = "DOWN"
        Me.Butt_Cutter_lift_down.UseVisualStyleBackColor = True
        '
        'Butt_Cutter_lift_up
        '
        Me.Butt_Cutter_lift_up.Location = New System.Drawing.Point(15, 16)
        Me.Butt_Cutter_lift_up.Name = "Butt_Cutter_lift_up"
        Me.Butt_Cutter_lift_up.Size = New System.Drawing.Size(75, 33)
        Me.Butt_Cutter_lift_up.TabIndex = 2
        Me.Butt_Cutter_lift_up.Text = "UP"
        Me.Butt_Cutter_lift_up.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.RichTextBox1)
        Me.GroupBox13.Controls.Add(Me.GroupBox16)
        Me.GroupBox13.Location = New System.Drawing.Point(762, 534)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(259, 124)
        Me.GroupBox13.TabIndex = 52
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "BENDING CONTROL"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(-27, 172)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = ""
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox16.Controls.Add(Me.Button12)
        Me.GroupBox16.Controls.Add(Me.Button13)
        Me.GroupBox16.Controls.Add(Me.Button14)
        Me.GroupBox16.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(218, 94)
        Me.GroupBox16.TabIndex = 2
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Tool bender control"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Info
        Me.Button12.Location = New System.Drawing.Point(121, 57)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 33)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "HOME"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(121, 18)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 33)
        Me.Button13.TabIndex = 0
        Me.Button13.Text = "+"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(15, 18)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 33)
        Me.Button14.TabIndex = 2
        Me.Button14.Text = "-"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(11, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 537)
        Me.Panel1.TabIndex = 53
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 0
        '
        'mssg
        '
        Me.mssg.Location = New System.Drawing.Point(575, 2)
        Me.mssg.Name = "mssg"
        Me.mssg.Size = New System.Drawing.Size(96, 31)
        Me.mssg.TabIndex = 54
        Me.mssg.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(786, 680)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(869, 680)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Label3"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button_Send)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_AvailableSerialPorts)
        Me.GroupBox1.Location = New System.Drawing.Point(1027, 534)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 124)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ARDUINO CONNECT"
        '
        'Button_Send
        '
        Me.Button_Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Send.Location = New System.Drawing.Point(198, 85)
        Me.Button_Send.Name = "Button_Send"
        Me.Button_Send.Size = New System.Drawing.Size(111, 33)
        Me.Button_Send.TabIndex = 59
        Me.Button_Send.Text = "Send Data"
        Me.Button_Send.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Connect.Location = New System.Drawing.Point(25, 85)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(111, 33)
        Me.Button_Connect.TabIndex = 58
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'ComboBox_AvailableSerialPorts
        '
        Me.ComboBox_AvailableSerialPorts.FormattingEnabled = True
        Me.ComboBox_AvailableSerialPorts.Location = New System.Drawing.Point(25, 37)
        Me.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts"
        Me.ComboBox_AvailableSerialPorts.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_AvailableSerialPorts.TabIndex = 57
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1038, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(315, 505)
        Me.TextBox1.TabIndex = 57
        '
        'txt_lich_su_1
        '
        Me.txt_lich_su_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lich_su_1.ForeColor = System.Drawing.Color.LimeGreen
        Me.txt_lich_su_1.Location = New System.Drawing.Point(12, 582)
        Me.txt_lich_su_1.Multiline = True
        Me.txt_lich_su_1.Name = "txt_lich_su_1"
        Me.txt_lich_su_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_lich_su_1.Size = New System.Drawing.Size(744, 139)
        Me.txt_lich_su_1.TabIndex = 58
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.txt_lich_su_1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mssg)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Butt_set_Scale)
        Me.Controls.Add(Me.Text_scale)
        Me.Controls.Add(Me.Butt_select)
        Me.Controls.Add(Me.Zinbutt)
        Me.Controls.Add(Me.Setup)
        Me.Controls.Add(Me.Start_bending)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Start_points)
        Me.Controls.Add(Me.Zoutbutt)
        Me.Controls.Add(Me.Open_butt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butt_set_Scale As System.Windows.Forms.Button
    Friend WithEvents Text_scale As System.Windows.Forms.TextBox
    Friend WithEvents Butt_select As System.Windows.Forms.Button
    Friend WithEvents Zinbutt As System.Windows.Forms.Button
    Friend WithEvents Setup As System.Windows.Forms.Button
    Friend WithEvents Start_bending As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Start_points As System.Windows.Forms.Button
    Friend WithEvents Zoutbutt As System.Windows.Forms.Button
    Friend WithEvents Open_butt As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Butt_Ext_Clamp_B As System.Windows.Forms.Button
    Friend WithEvents Butt_Ext_Clamp_A As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Butt_Ext_HomeB As System.Windows.Forms.Button
    Friend WithEvents Butt_Ext_HomeA As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Text_Ext_Forward As System.Windows.Forms.TextBox
    Friend WithEvents Text_Ext_Previous As System.Windows.Forms.TextBox
    Friend WithEvents Butt_extrude_fwd As System.Windows.Forms.Button
    Friend WithEvents Butt_extrude_previous As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Butt_Cutter_Angle_Home As System.Windows.Forms.Button
    Friend WithEvents Butt_cutter_angle_plus As System.Windows.Forms.Button
    Friend WithEvents Butt_Cutter_angle_minus As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Butt_cutter_Grind_Start As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Butt_cutter_lifter_home As System.Windows.Forms.Button
    Friend WithEvents Butt_Cutter_lift_down As System.Windows.Forms.Button
    Friend WithEvents Butt_Cutter_lift_up As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mssg As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents ComboBox_AvailableSerialPorts As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Send As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lich_su_1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox

End Class
