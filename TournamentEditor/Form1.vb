'//////////////////////////////////////////////////
Imports System.IO
Imports System.Data.OleDb
'//////////////////////////////////////////////////

Public Class frmTmtEditor
    '
    Dim FS As FileStream, BR As BinaryReader, BW As BinaryWriter
    '
    Dim intMatches As Integer       'total number of matches
    Dim intMatch1 As Integer        'first match
    Dim intTeams As Integer         'number of teams
    Dim intTotTeams As Integer      'number of teams
    Dim intUserStart As Integer     'start of user team offset
    Dim intNo As Integer            'Difference between team offsets
    Dim intNo1 As Integer           '   "   "       "   user offsets

    Private Sub TmtSelector(ByVal x As Integer)

        Const curTxt As String = ":: "
        '
        'Select Case x
        '    Case 6      'knockout
        '        intMatches = 24
        '        intMatch1 = 719432
        '        intTeams = 719392
        '        intUserStart = 719424
        '        intTotTeams = 8
        '        lblTmtName.Text = curTxt & "Knockout Cup"
        '    Case 8      'world cup
        '        intMatches = 24
        '        intMatch1 = 720436
        '        intTeams = 720356
        '        intUserStart = 720420
        '        intTotTeams = 16
        '        lblTmtName.Text = curTxt & "World Cup"
        '    Case 10     'test series
        '        intMatches = 5
        '        intMatch1 = 719416
        '        intTeams = 719400
        '        intUserStart = 719404
        '        intTotTeams = 2
        '        lblTmtName.Text = curTxt & "Test Series"
        '    Case 22     'Long Aus
        '        intMatches = 26
        '        intMatch1 = 721160
        '        intTeams = 721112
        '        intUserStart = 721148
        '        intTotTeams = 9
        '        lblTmtName.Text = curTxt & "Long Australian Tour"
        '    Case 23     'short aus
        '        intMatches = 16
        '        intMatch1 = 721164
        '        intTeams = 721112
        '        intTotTeams = 10
        '        intUserStart = 721152
        '        lblTmtName.Text = curTxt & "Short Australian Tour"
        '    Case 25      'Long Eng
        '        intMatches = 25
        '        intMatch1 = 722048
        '        intTeams = 721968
        '        intTotTeams = 16
        '        intUserStart = 722032
        '        lblTmtName.Text = curTxt & "Long English Tour"
        '    Case 26     'Short Eng
        '        intMatches = 26
        '        intMatch1 = 721172
        '        intTeams = 721112
        '        intTotTeams = 12
        '        intUserStart = 721160
        '        lblTmtName.Text = curTxt & "Short English Tour"
        '    Case 32     'NZ/Zim
        '        intMatches = 16
        '        intMatch1 = 722852
        '        intTeams = 722824
        '        intTotTeams = 5
        '        intUserStart = 722844
        '        lblTmtName.Text = curTxt & "New Zealand/Zimbabwe Tour"
        '    Case 24     'WI
        '        intMatches = 16
        '        intMatch1 = 721140
        '        intTeams = 721112
        '        intTotTeams = 5
        '        intUserStart = 721132
        '        lblTmtName.Text = curTxt & "West Indies Tour"
        '    Case 30     's africa
        '        intMatches = 16
        '        intMatch1 = 721144
        '        intTeams = 721112
        '        intTotTeams = 5
        '        intUserStart = 721136
        '        lblTmtName.Text = curTxt & "South Africa Tour"
        '    Case Else
        '        MessageBox.Show("Format not yet supported", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '
        'End Select
        '/////////////////// Database Test /////////////
        Dim objConn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\Data\tmtInfo.mdb")
        Dim objRS As New OleDbDataAdapter("SELECT * FROM tmtInfo WHERE Identification = " & Chr(34) & x.ToString & Chr(34), objConn)
        Dim objDT As New DataTable("tmtInfo")
        objRS.Fill(objDT)
        '
        If (objDT.Rows.Count = 0) Then
            MessageBox.Show("Format not yet supported", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GoTo DiffSelector
        End If
        '
        With objDT.Rows(0)
            intMatches = CInt(.Item("intMatches"))
            intMatch1 = CInt(.Item("intMatch1"))
            intTeams = CInt(.Item("intTeams"))
            intTotTeams = CInt(.Item("intTotTeams"))
            intUserStart = CInt(.Item("intUserStart"))
            lbltmtname.Text = curTxt & .Item("TmtName")
        End With
        '///////////////////////////////////////////////
DiffSelector:
        If x <> 10 Then
            intNo = 4
            intNo1 = 1
        Else
            intNo = 8
            intNo1 = 8
        End If
        '
    End Sub

    Private Sub fileOpen()
        On Error Resume Next
        '
        lstFixtures.Items.Clear()
        lstTeams.Items.Clear()
        lstOffsets.Items.Clear()
        '
        Dim fileName As String, intReader As Byte
        With ofd0
            .Reset()
            .Filter = "Cricket 2007 Tournament File|*.tmt"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                'If .FileName = "" Then Exit Sub

                '
                fileName = .FileName



                FS = Nothing
                '
                FS = New FileStream(fileName, FileMode.Open, FileAccess.ReadWrite)
                BR = New BinaryReader(FS)
                BW = New BinaryWriter(FS)
                '
                FS.Seek(692104, SeekOrigin.Begin)
                intReader = BR.ReadByte
                '
                Call TmtSelector(intReader)
            End If

        End With
    End Sub

    Private Sub TeamsReader()
        Dim x As Integer, reader As Integer
        '
        For x = 0 To intTotTeams - 1
            FS.Seek(intTeams + x * intNo, SeekOrigin.Begin)
            reader = BR.ReadByte
            lstHelper.SelectedIndex = reader
            '
            FS.Seek(intUserStart + x * intNo1, SeekOrigin.Begin)
            reader = BR.ReadByte
            '
            If reader = 1 Then
                lstTeams.Items.Add(lstHelper.Text, True)
            Else
                lstTeams.Items.Add(lstHelper.Text, False)
            End If
        Next
        '
        For x = 1 To intMatches
            lstFixtures.Items.Add("Match" & " " & x)
        Next x
        '
        For x = 0 To intMatches - 1
            lstOffsets.Items.Add(intMatch1 + x * 24)
        Next
        '
        FS.Seek(1004272, SeekOrigin.Begin)
        numDiff.Value = BR.ReadByte + 1
        '
        lblNumber.Text = "Teams: " & lstTeams.Items.Count & " / " & intTotTeams
    End Sub

    Private Sub FixturesReader()
        Dim reader As Integer
        '
        FS.Seek(Convert.ToInt64(lstOffsets.Text) + 0, SeekOrigin.Begin)
        reader = BR.ReadByte
        cboTeamA.SelectedIndex = reader
        '
        FS.Seek(Convert.ToInt64(lstOffsets.Text) + 1, SeekOrigin.Begin)
        reader = BR.ReadByte
        cboTeamH.SelectedIndex = reader
        '
        FS.Seek(Convert.ToInt64(lstOffsets.Text) + 2, SeekOrigin.Begin)
        reader = BR.ReadByte
        cboDays.Text = reader
        '
        FS.Seek(Convert.ToInt64(lstOffsets.Text) + 14, SeekOrigin.Begin)
        reader = BR.ReadByte
        txtOvers.Text = reader
        '

    End Sub

    Private Sub TeamsWriter()
        Dim x As Integer
        '
        For x = 0 To intTotTeams - 1
            FS.Seek(intTeams + x * 4, SeekOrigin.Begin)
            lstTeams.SelectedIndex = x
            lstHelper.Text = lstTeams.Text
            BW.Write(Convert.ToByte(lstHelper.SelectedIndex))
            '
            FS.Seek(intUserStart + x * 1, SeekOrigin.Begin)
            lstTeams.SelectedIndex = x
            If lstTeams.GetItemChecked(x) = True Then
                BW.Write(CByte(1))
            Else
                BW.Write(CByte(0))
            End If
        Next
        '
        FS.Seek(1004272, SeekOrigin.Begin)
        BW.Write(CByte(numDiff.Value - 1))

        '
        MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FixturesWriter()
        '
        lstOffsets.SelectedIndex = lstFixtures.SelectedIndex
        '
        FS.Seek(Convert.ToInt32(lstOffsets.Text), SeekOrigin.Begin)
        BW.Write(CByte(cboTeamA.SelectedIndex))
        '
        FS.Seek(Convert.ToInt32(lstOffsets.Text) + 1, SeekOrigin.Begin)
        BW.Write(CByte(cboTeamH.SelectedIndex))
        '
        FS.Seek(Convert.ToInt32(lstOffsets.Text) + 2, SeekOrigin.Begin)
        BW.Write(CByte(Convert.ToByte(cboDays.Text)))
        '
        FS.Seek(Convert.ToInt32(lstOffsets.Text) + 14, SeekOrigin.Begin)
        BW.Write(CByte(Convert.ToByte(txtOvers.Text)))
        '
    End Sub

#Region "Shortcuts"



    Private Sub lstFixtures_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFixtures.SelectedIndexChanged
        lstOffsets.SelectedIndex = lstFixtures.SelectedIndex
        '
        Call FixturesReader()
    End Sub

    Private Sub frmTmtEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            FS.Close()
            BW.Close()
            BR.Close()
        Catch ex As Exception
            MessageBox.Show(e.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmTmtEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fileOpen()
        Call TeamsReader()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        fileOpen()
        TeamsReader()
    End Sub

    Private Sub btnSteams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSteams.Click
        TeamsWriter()
    End Sub

    Private Sub btnSfixtures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSfixtures.Click
        FixturesWriter()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MessageBox.Show("Tournament Editor for Cricket 07. Created by: Shreyas Basarge", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

    Private Sub cboDays_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDays.SelectedIndexChanged
        If cboDays.Text <> 1 Then
            txtOvers.Text = 225
            txtOvers.Visible = False
            Label3.Visible = False
        Else
            txtOvers.Visible = True
            Label3.Visible = True
        End If
    End Sub

#Region "Teams Changer"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lstTeams.Items.Add(lstHelper.Text)
        '
        lblNumber.Text = "Teams: " & lstTeams.Items.Count & " / " & intTotTeams
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lstTeams.Items.RemoveAt(lstTeams.SelectedIndex)
        '
        lblNumber.Text = "Teams: " & lstTeams.Items.Count & " / " & intTotTeams
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim nItem As Short
        With lstTeams
            If .SelectedIndex < 0 Then Exit Sub
            nItem = .SelectedIndex
            If nItem = 0 Then Exit Sub
            .Items.Insert(nItem - 1, .Text)
            .Items.RemoveAt(nItem + 1)
            .SetSelected(nItem - 1, True)
        End With

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim nItem As Short
        With lstTeams
            If .SelectedIndex < 0 Then Exit Sub
            nItem = .SelectedIndex
            If nItem = .Items.Count - 1 Then Exit Sub
            Dim data As Object = .Items(.SelectedIndex)
            .Items.RemoveAt(nItem)
            .Items.Insert(nItem + 1, .Text)
            .SetSelected(nItem + 1, True)
            .Items.Item(.SelectedIndex) = data
            .SetSelected(nItem + 1, True)
        End With

    End Sub

#End Region

End Class