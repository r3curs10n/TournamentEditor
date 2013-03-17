<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTmtEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboDays = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstOffsets = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOvers = New System.Windows.Forms.TextBox
        Me.cboTeamA = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboTeamH = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstFixtures = New System.Windows.Forms.ListBox
        Me.cboVenue = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.lblNumber = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstHelper = New System.Windows.Forms.ComboBox
        Me.numDiff = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstTeams = New System.Windows.Forms.CheckedListBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbltmtname = New System.Windows.Forms.ToolStripStatusLabel
        Me.ofd0 = New System.Windows.Forms.OpenFileDialog
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnOpen = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSteams = New System.Windows.Forms.ToolStripButton
        Me.btnSfixtures = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAbout = New System.Windows.Forms.ToolStripButton
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.numDiff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(287, 249)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboDays)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lstOffsets)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtOvers)
        Me.TabPage1.Controls.Add(Me.cboTeamA)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboTeamH)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lstFixtures)
        Me.TabPage1.Controls.Add(Me.cboVenue)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(279, 223)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fixtures"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboDays
        '
        Me.cboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDays.FormattingEnabled = True
        Me.cboDays.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboDays.Location = New System.Drawing.Point(153, 118)
        Me.cboDays.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboDays.Name = "cboDays"
        Me.cboDays.Size = New System.Drawing.Size(104, 21)
        Me.cboDays.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Days:"
        '
        'lstOffsets
        '
        Me.lstOffsets.FormattingEnabled = True
        Me.lstOffsets.Location = New System.Drawing.Point(143, 189)
        Me.lstOffsets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstOffsets.Name = "lstOffsets"
        Me.lstOffsets.Size = New System.Drawing.Size(96, 17)
        Me.lstOffsets.TabIndex = 33
        Me.lstOffsets.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Overs:"
        '
        'txtOvers
        '
        Me.txtOvers.Location = New System.Drawing.Point(153, 164)
        Me.txtOvers.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtOvers.Name = "txtOvers"
        Me.txtOvers.Size = New System.Drawing.Size(105, 20)
        Me.txtOvers.TabIndex = 31
        '
        'cboTeamA
        '
        Me.cboTeamA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeamA.FormattingEnabled = True
        Me.cboTeamA.Items.AddRange(New Object() {"Australia", "Bangladesh", "Border", "Canada", "Canterbury", "Derbyshire", "Durham", "England", "Essex", "Gauteng", "Glamorgan", "Gloucestershire", "Hampshire", "India", "Kent", "Kenya", "Lancashire", "Leicestershire", "Middlesex", "Masters XI", "Namibia", "Netherlands", "New South Wales", "New Zealand", "Northamptonshire", "Northern Districts", "Nottinghamshire", "Pakistan", "Queensland", "Somerset", "South Africa", "South Australia", "Sri Lanka", "Surrey", "Sussex", "Tasmania", "Trinidad", "Victoria", "Warwickshire", "West Indies", "Western Australia", "Worcestershire", "Yorkshire", "Zimbabwe", "Australia A", "India A", "Pakistan A", "South Africa A", "West Indies A", "Chairman's XI", "B. President's XI", "Duke's XI", "Governor's XI""", "Minister's XI", "V. Chancellor's XI", "World Test XI", "World One Day XI", "Scottish Saltires", "United States", "Bermuda", "Ireland", "Scotland", "Ireland County"})
        Me.cboTeamA.Location = New System.Drawing.Point(153, 72)
        Me.cboTeamA.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTeamA.Name = "cboTeamA"
        Me.cboTeamA.Size = New System.Drawing.Size(107, 21)
        Me.cboTeamA.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Away Team:"
        '
        'cboTeamH
        '
        Me.cboTeamH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeamH.FormattingEnabled = True
        Me.cboTeamH.Items.AddRange(New Object() {"Australia", "Bangladesh", "Border", "Canada", "Canterbury", "Derbyshire", "Durham", "England", "Essex", "Gauteng", "Glamorgan", "Gloucestershire", "Hampshire", "India", "Kent", "Kenya", "Lancashire", "Leicestershire", "Middlesex", "Masters XI", "Namibia", "Netherlands", "New South Wales", "New Zealand", "Northamptonshire", "Northern Districts", "Nottinghamshire", "Pakistan", "Queensland", "Somerset", "South Africa", "South Australia", "Sri Lanka", "Surrey", "Sussex", "Tasmania", "Trinidad", "Victoria", "Warwickshire", "West Indies", "Western Australia", "Worcestershire", "Yorkshire", "Zimbabwe", "Australia A", "India A", "Pakistan A", "South Africa A", "West Indies A", "Chairman's XI", "B. President's XI", "Duke's XI", "Governor's XI""", "Minister's XI", "V. Chancellor's XI", "World Test XI", "World One Day XI", "Scottish Saltires", "United States", "Bermuda", "Ireland", "Scotland", "Ireland County"})
        Me.cboTeamH.Location = New System.Drawing.Point(153, 26)
        Me.cboTeamH.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTeamH.Name = "cboTeamH"
        Me.cboTeamH.Size = New System.Drawing.Size(107, 21)
        Me.cboTeamH.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Home Team:"
        '
        'lstFixtures
        '
        Me.lstFixtures.FormattingEnabled = True
        Me.lstFixtures.Location = New System.Drawing.Point(5, 6)
        Me.lstFixtures.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstFixtures.Name = "lstFixtures"
        Me.lstFixtures.Size = New System.Drawing.Size(132, 186)
        Me.lstFixtures.TabIndex = 26
        '
        'cboVenue
        '
        Me.cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVenue.FormattingEnabled = True
        Me.cboVenue.Items.AddRange(New Object() {"--Australia--", "02-Adelaide", "03-Brisbane", "04-Melbourne", "05-Perth", "06-Sydney", "07-Hobart", "--------------------", "--Englang--", "10-Leeds", "11-Lords", "12-Nottingham", "13-The Oval", "14-Bristol", "15-Birmingham", "16-Canterbury", "17-Cardiff", "18-Chelmsford", "19-Chester-Le-Street", "20-Derby", "21-Hove", "22-Leicester", "23-Northampton", "24-Manchester", "26-Southampton", "27-Taunton", "28-Worcester", "--------------------", "--South Africa--", "30-Capetown", "31-Johanesburg", "--------------------", "--West Indies--", "34-Barbados", "--------------------", "--India--", "37-Kolkata", "--------------------", "--Pakistan--", "40-Faisalabad", "--------------------", "--Sri Lanka--", "43-Kandy", "--------------------", "--Zimbabwe--", "46-Harare", "--------------------", "--New Zealand--", "49-Auckland", "50-ChristCurch", "--------------------", "--Misc--", "53-Dhaka", "54-Sharjah", "55-Training Nets"})
        Me.cboVenue.Location = New System.Drawing.Point(5, 211)
        Me.cboVenue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboVenue.Name = "cboVenue"
        Me.cboVenue.Size = New System.Drawing.Size(132, 21)
        Me.cboVenue.TabIndex = 37
        Me.cboVenue.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Venue:"
        Me.Label6.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.lblNumber)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.lstHelper)
        Me.TabPage2.Controls.Add(Me.numDiff)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lstTeams)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(279, 223)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Teams"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(65, 197)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 22)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Down"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(5, 197)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 22)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Up"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(152, 116)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(59, 13)
        Me.lblNumber.TabIndex = 25
        Me.lblNumber.Text = "0/0 Teams"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 80)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 22)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 44)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 22)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstHelper
        '
        Me.lstHelper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstHelper.FormattingEnabled = True
        Me.lstHelper.Items.AddRange(New Object() {"Australia", "Bangladesh", "Border", "Canada", "Canterbury", "Derbyshire", "Durham", "England", "Essex", "Gauteng", "Glamorgan", "Gloucestershire", "Hampshire", "India", "Kent", "Kenya", "Lancashire", "Leicestershire", "Middlesex", "Masters XI", "Namibia", "Netherlands", "New South Wales", "New Zealand", "Northamptonshire", "Northern Districts", "Nottinghamshire", "Pakistan", "Queensland", "Somerset", "South Africa", "South Australia", "Sri Lanka", "Surrey", "Sussex", "Tasmania", "Trinidad", "Victoria", "Warwickshire", "West Indies", "Western Australia", "Worcestershire", "Yorkshire", "Zimbabwe", "Australia A", "India A", "Pakistan A", "South Africa A", "West Indies A", "Chairman's XI", "B. President's XI", "Duke's XI", "Governor's XI""", "Minister's XI", "V. Chancellor's XI", "World Test XI", "World One Day XI", "Scottish Saltires", "United States", "Bermuda", "Ireland", "Scotland", "Ireland County"})
        Me.lstHelper.Location = New System.Drawing.Point(152, 9)
        Me.lstHelper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstHelper.Name = "lstHelper"
        Me.lstHelper.Size = New System.Drawing.Size(108, 21)
        Me.lstHelper.TabIndex = 22
        '
        'numDiff
        '
        Me.numDiff.Location = New System.Drawing.Point(206, 168)
        Me.numDiff.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.numDiff.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numDiff.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDiff.Name = "numDiff"
        Me.numDiff.Size = New System.Drawing.Size(52, 20)
        Me.numDiff.TabIndex = 21
        Me.numDiff.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Difficulty"
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.Location = New System.Drawing.Point(5, 6)
        Me.lstTeams.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(116, 184)
        Me.lstTeams.TabIndex = 20
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbltmtname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 289)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(313, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbltmtname
        '
        Me.lbltmtname.Name = "lbltmtname"
        Me.lbltmtname.Size = New System.Drawing.Size(19, 17)
        Me.lbltmtname.Text = "..."
        '
        'ofd0
        '
        Me.ofd0.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.ToolStripSeparator1, Me.btnSteams, Me.btnSfixtures, Me.ToolStripSeparator2, Me.btnAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(313, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = Global.TournamentEditor.My.Resources.Resources.document_open_16_h
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSteams
        '
        Me.btnSteams.Image = Global.TournamentEditor.My.Resources.Resources.save_16_h
        Me.btnSteams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSteams.Name = "btnSteams"
        Me.btnSteams.Size = New System.Drawing.Size(85, 22)
        Me.btnSteams.Text = "Save Teams"
        '
        'btnSfixtures
        '
        Me.btnSfixtures.Image = Global.TournamentEditor.My.Resources.Resources.save_16_h
        Me.btnSfixtures.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSfixtures.Name = "btnSfixtures"
        Me.btnSfixtures.Size = New System.Drawing.Size(93, 22)
        Me.btnSfixtures.Text = "Save Fixtures"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = Global.TournamentEditor.My.Resources.Resources.home_16_h
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(23, 22)
        Me.btnAbout.Text = "About"
        '
        'frmTmtEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 311)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmTmtEditor"
        Me.Opacity = 0.9
        Me.Text = "Tournament Editor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.numDiff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboDays As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstOffsets As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOvers As System.Windows.Forms.TextBox
    Friend WithEvents cboTeamA As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTeamH As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstFixtures As System.Windows.Forms.ListBox
    Friend WithEvents cboVenue As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstHelper As System.Windows.Forms.ComboBox
    Friend WithEvents numDiff As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstTeams As System.Windows.Forms.CheckedListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ofd0 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbltmtname As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSteams As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSfixtures As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton

End Class
