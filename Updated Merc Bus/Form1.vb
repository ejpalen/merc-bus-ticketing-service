Public Class Form1
    Dim menucollapsed As Boolean = True
    Dim label As New Label
    Dim receiptlabel As New Label
    Dim ctr = 1, limit As Integer
    Dim passengername(70), age(70) As String
    Dim passcheckbox As String
    'ed codes
    Dim price, numpassen, insurance, totalfare1(70), totalfare2(70) As Single
    Dim discount, VAT, VATprice, discountedprice, vatableamount, vatpercent, srdiscount, groupdisc, totalbookpayment, bulkpackageprice, allinsurance, allbulkpackage, allvatprice, alldiscount As Single
    Dim insurepass As Integer = 0
    Dim payment, change, srtotal, kdiscount, busfare, kidprice, finaltotalbp As Single
    Dim dep, des, typeoftrip, bus, bustime, insu As String
    Dim trip, bulkpass As Integer
    Dim dateone, dateround1, dateround2 As DateTime
    'ed codes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlmenucollapse.Size = pnlmenucollapse.MinimumSize
        lblWelcome2.Parent = PictureBox5
        lblwelcome1.Parent = PictureBox5
        recbusfare.Parent = imgreceipttotalbreakdown
        recaddcharge.Parent = imgreceipttotalbreakdown
        recdiscount.Parent = imgreceipttotalbreakdown
        recinsurance.Parent = imgreceipttotalbreakdown
        recvat.Parent = imgreceipttotalbreakdown
        rectotal.Parent = imgreceipttotalbreakdown
        recsrdiscount.Parent = imgreceipttotalbreakdown
        recgrpdicount.Parent = imgreceipttotalbreakdown
        recpayment.Parent = imgreceipttotalbreakdown
        recchange.Parent = imgreceipttotalbreakdown
        btnHome.ForeColor = Color.FromArgb(5, 22, 77)
        btnHome.BackColor = Color.FromArgb(244, 245, 250)
        whitehomeicon.Hide()
        bluemenu.Hide()
        orangearrowicon.Hide()
        pnlhidemenu.Visible = False
        pnlhidehome.Visible = False
        pnlhideabout.Visible = False
        pnlhidesave.Hide()
        'ed codes
        OnewayDateTimePicker.MinDate = Date.Today
        OnewayDateTimePicker.MaxDate = New Date(Today.Year, 12, 31)
        roundtripdate1.Value = Date.Today
        roundtripdate1.MinDate = Date.Today
        roundtripdate1.MaxDate = New Date(Today.Year, 12, 31)
        roundtripdate2.MinDate = roundtripdate1.Value
        roundtripdate2.Value = roundtripdate2.MinDate
        roundtripdate2.MaxDate = New Date(Today.Year, 12, 31)
        'ed codes
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If menucollapsed Then
            btnMenu.Image = My.Resources.dsd
            pnlmenucollapse.Height += 10
            If pnlmenucollapse.Size = pnlmenucollapse.MaximumSize Then
                Timer1.Stop()
                menucollapsed = False
            End If
        Else
            pnlmenucollapse.Height -= 10
            btnAdditionalServiceInfo.ForeColor = Color.FromArgb(244, 245, 250)
            btnCustomerServicemenu.ForeColor = Color.FromArgb(244, 245, 250)
            btnPassengerrightsmenu.ForeColor = Color.FromArgb(244, 245, 250)
            btnMenu.Image = My.Resources.updatedorangedown_removebg_preview__2_
            If pnlmenucollapse.Size = pnlmenucollapse.MinimumSize Then
                Timer1.Stop()
                menucollapsed = True
            End If
        End If
    End Sub
    'SIDEBAR BUTTONS FUNCTIONS
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Timer1.Start()
        btnHome.ForeColor = Color.FromArgb(244, 245, 250)
        btnMenu.ForeColor = Color.FromArgb(5, 22, 77)
        btnabout.ForeColor = Color.FromArgb(244, 245, 250)
        btnHome.BackColor = Color.FromArgb(5, 22, 77)
        btnMenu.BackColor = Color.FromArgb(244, 245, 250)
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        bluehome.Hide()
        whitehomeicon.Show()
        bluemenu.Show()
        whitemenu.Hide()

    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menucollapsed = False
        Timer1.Start()
        pnlWelcome.Visible = True
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        btnHome.ForeColor = Color.FromArgb(5, 22, 77)
        btnMenu.ForeColor = Color.FromArgb(244, 245, 250)
        btnabout.ForeColor = Color.FromArgb(244, 245, 250)
        btnHome.BackColor = Color.FromArgb(244, 245, 250)
        bluehome.BackColor = Color.FromArgb(244, 245, 250)
        btnMenu.BackColor = Color.FromArgb(5, 22, 77)
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        whitehomeicon.Hide()
        bluehome.Show()
        bluemenu.Hide()
        whitemenu.Show()
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        pnlreceipt.Visible = False
    End Sub
    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        menucollapsed = False
        Timer1.Start()
        btnabout.BackgroundImage = My.Resources.newbtnaboutblue
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = True
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        btnabout.ForeColor = Color.FromArgb(5, 22, 77)
        btnHome.ForeColor = Color.FromArgb(244, 245, 250)
        btnMenu.ForeColor = Color.FromArgb(244, 245, 250)
        btnabout.BackColor = Color.FromArgb(244, 245, 250)
        btnHome.BackColor = Color.FromArgb(5, 22, 77)
        bluehome.BackColor = Color.FromArgb(5, 22, 77)
        btnMenu.BackColor = Color.FromArgb(5, 22, 77)
        bluehome.Hide()
        bluemenu.Hide()
        whitemenu.Show()
        whitehomeicon.Show()
    End Sub
    'HOMEPAGE ELEMENTS FUNCTIONS
    Private Sub lblWelcome2_MouseMove(sender As Object, e As MouseEventArgs) Handles lblWelcome2.MouseMove
        lblWelcome2.ForeColor = Color.Orange
    End Sub
    Private Sub lblWelcome2_MouseLeave(sender As Object, e As EventArgs) Handles lblWelcome2.MouseLeave
        lblWelcome2.ForeColor = Color.White
    End Sub
    Private Sub lblwelcome1_MouseMove(sender As Object, e As MouseEventArgs) Handles lblwelcome1.MouseMove
        lblwelcome1.ForeColor = Color.Orange
    End Sub
    Private Sub lblwelcome1_MouseLeave(sender As Object, e As EventArgs) Handles lblwelcome1.MouseLeave
        lblwelcome1.ForeColor = Color.White
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnGetstarted.Click
        menucollapsed = False
        Timer1.Start()
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = True
        pnlAbout.Visible = False
        pnlClassObuses.Visible = False
        pnlonewaytrip.Visible = True
        pnlroundtrip.Visible = False
        btnHome.ForeColor = Color.FromArgb(5, 22, 77)
        btnHome.BackColor = Color.FromArgb(244, 245, 250)
        whitemenu.Visible = True
        bluemenu.Visible = False
        btnMenu.ForeColor = Color.FromArgb(244, 245, 250)
        btnMenu.BackColor = Color.FromArgb(5, 22, 77)

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
    End Sub
    Private Sub btnGetstarted_MouseHover(sender As Object, e As EventArgs) Handles btnGetstarted.MouseHover
        btnGetstarted.ForeColor = Color.FromArgb(5, 22, 77)
        btnGetstarted.BackColor = Color.FromArgb(244, 245, 250)
        orangearrowicon.BackColor = Color.FromArgb(219, 220, 224)
        orangearrowicon.Show()
    End Sub
    Private Sub btnGetstarted_MouseLeave(sender As Object, e As EventArgs) Handles btnGetstarted.MouseLeave
        btnGetstarted.ForeColor = Color.White
        btnGetstarted.BackColor = Color.FromArgb(5, 22, 77)
        orangearrowicon.BackColor = Color.FromArgb(244, 245, 250)
        orangearrowicon.Hide()

    End Sub
    'BOOK A TRIP FIRST PANEL FUNCTIONS
    'ed code
    Private Sub cbofromdestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofromdestination.SelectedIndexChanged
        'manila
        If cbofromdestination.SelectedIndex = 0 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Manila"
            If cbotodestination.SelectedIndex = 0 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'ilocos
        ElseIf cbofromdestination.SelectedIndex = 1 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Ilocos"
            If cbotodestination.SelectedIndex = 1 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'Pampanga
        ElseIf cbofromdestination.SelectedIndex = 2 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Pampanga"
            If cbotodestination.SelectedIndex = 2 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'zambales
        ElseIf cbofromdestination.SelectedIndex = 3 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Zambales"
            If cbotodestination.SelectedIndex = 3 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'bagio
        ElseIf cbofromdestination.SelectedIndex = 4 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Baguio"
            If cbotodestination.SelectedIndex = 4 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'apari
        ElseIf cbofromdestination.SelectedIndex = 5 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Apari"
            If cbotodestination.SelectedIndex = 5 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'la union
        ElseIf cbofromdestination.SelectedIndex = 6 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "La Union"
            If cbotodestination.SelectedIndex = 6 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'nueva ecija
        ElseIf cbofromdestination.SelectedIndex = 7 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Nueva Ecija"
            If cbotodestination.SelectedIndex = 7 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'tugegrao
        ElseIf cbofromdestination.SelectedIndex = 8 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Tugegarao"
            If cbotodestination.SelectedIndex = 8 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'laog
        ElseIf cbofromdestination.SelectedIndex = 9 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Laog"
            If cbotodestination.SelectedIndex = 9 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
            'pangasinan
        ElseIf cbofromdestination.SelectedIndex = 10 Then
            dep = cbofromdestination.SelectedIndex
            recfrom.Text = "Pangasinan"
            If cbotodestination.SelectedIndex = 10 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbofromdestination.SelectedIndex = -1
            End If
        End If
        If cbofromdestination.SelectedIndex > -1 And cbotodestination.SelectedIndex > -1 Then
            rdoOneway.Enabled = True
            rdoRoundtrip.Enabled = True
        Else
            rdoOneway.Checked = False
            rdoRoundtrip.Checked = False
            rdoOneway.Enabled = False
            rdoRoundtrip.Enabled = False
            rdoOneway.ForeColor = Color.Orange
            rdoRoundtrip.ForeColor = Color.FromArgb(5, 22, 77)
            OnewayDateTimePicker.Visible = True
            OnewayDateTimePicker.Value = DateTime.Today
            OnewayDateTimePicker.Enabled = False
            roundtripdate1.Enabled = False
            roundtripdate2.Enabled = False
            roundtripdate1.Visible = False
            roundtripdate2.Visible = False
            cbobustype.SelectedIndex = -1
            cbobustype.Enabled = False
            nudpassengers.Value = 1
            nudpassengers.Enabled = False
            btntrippagenext.Enabled = False
        End If
    End Sub
    Private Sub cbotodestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotodestination.SelectedIndexChanged
        If cbotodestination.SelectedIndex = 0 Then
            des = cbotodestination.Text
            recto.Text = "Manila"
            If cbofromdestination.SelectedIndex = 0 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 1 Then
            des = cbotodestination.Text
            recto.Text = "Ilocos"
            If cbofromdestination.SelectedIndex = 1 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 2 Then
            des = cbotodestination.Text
            recto.Text = "Pampanga"
            If cbofromdestination.SelectedIndex = 2 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 3 Then
            des = cbotodestination.Text
            recto.Text = "Zambales"
            If cbofromdestination.SelectedIndex = 3 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 4 Then
            des = cbotodestination.Text
            recto.Text = "Baguio"
            If cbofromdestination.SelectedIndex = 4 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 5 Then
            des = cbotodestination.Text
            recto.Text = "Apari"
            If cbofromdestination.SelectedIndex = 5 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 6 Then
            des = cbotodestination.Text
            recto.Text = "La Union"
            If cbofromdestination.SelectedIndex = 6 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 7 Then
            des = cbotodestination.Text
            recto.Text = "Nueva Ecija"
            If cbofromdestination.SelectedIndex = 7 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 8 Then
            des = cbotodestination.Text
            recto.Text = "Tugegarao"
            If cbofromdestination.SelectedIndex = 8 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 9 Then
            des = cbotodestination.Text
            recto.Text = "Laog"
            If cbofromdestination.SelectedIndex = 9 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        ElseIf cbotodestination.SelectedIndex = 10 Then
            des = cbotodestination.Text
            recto.Text = "Pangasinan"
            If cbofromdestination.SelectedIndex = 10 Then
                MessageBox.Show("Location cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbotodestination.SelectedIndex = -1
            End If
        End If

        If cbofromdestination.SelectedIndex > -1 And cbotodestination.SelectedIndex > -1 Then
            rdoOneway.Enabled = True
            rdoRoundtrip.Enabled = True
            rdoOneway.ForeColor = Color.FromArgb(5, 22, 77)
            rdoRoundtrip.ForeColor = Color.FromArgb(5, 22, 77)
        Else
            rdoOneway.Checked = False
            rdoRoundtrip.Checked = False
            rdoOneway.Enabled = False
            rdoRoundtrip.Enabled = False
            rdoOneway.ForeColor = Color.Orange
            rdoRoundtrip.ForeColor = Color.FromArgb(5, 22, 77)
            OnewayDateTimePicker.Visible = True
            OnewayDateTimePicker.Value = DateTime.Today
            OnewayDateTimePicker.Enabled = False
            roundtripdate1.Value = DateTime.Today
            roundtripdate2.Value = roundtripdate1.Value.AddDays(1)
            roundtripdate1.Enabled = False
            roundtripdate2.Enabled = False
            roundtripdate1.Visible = False
            roundtripdate2.Visible = False
            cbobustype.SelectedIndex = -1
            cbobustype.Enabled = False
            nudpassengers.Value = 1
            nudpassengers.Enabled = False
            btntrippagenext.Enabled = False
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
        End If
    End Sub
    Private Sub rdoOneway_Click(sender As Object, e As EventArgs) Handles rdoOneway.Click
        pnlonewaytrip.Visible = True
        pnlroundtrip.Visible = False
        rdoOneway.ForeColor = Color.Orange
        rdoRoundtrip.ForeColor = Color.FromArgb(5, 22, 77)
        'ed code
        trip = 1
        typeoftrip = "One-way"
        rdoOneway.Visible = True
        OnewayDateTimePicker.Enabled = True
        OnewayDateTimePicker.Visible = True
        roundtripdate1.Visible = False
        roundtripdate2.Visible = False
        roundtripdate1.Enabled = False
        roundtripdate2.Enabled = False
        cbobustype.Enabled = True
        recdate2.Visible = False
        rectriptype.Text = typeoftrip
        'ed code
    End Sub
    Private Sub rdoRoundtrip_Click(sender As Object, e As EventArgs) Handles rdoRoundtrip.Click
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = True
        rdoRoundtrip.ForeColor = Color.Orange
        rdoOneway.ForeColor = Color.FromArgb(5, 22, 77)
        'ed code
        typeoftrip = "Roundtrip"
        trip = 2
        OnewayDateTimePicker.Visible = False
        roundtripdate1.Visible = True
        roundtripdate2.Visible = True
        roundtripdate1.Enabled = True
        roundtripdate2.Enabled = True
        cbobustype.Enabled = True
        recdate2.Visible = True
        rectriptype.Text = typeoftrip
        'ed code
    End Sub
    Private Sub OnewayDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles OnewayDateTimePicker.ValueChanged
        dateone = OnewayDateTimePicker.Value
        recdate1.Text = dateone
    End Sub
    Private Sub roundtripdate1_ValueChanged(sender As Object, e As EventArgs) Handles roundtripdate1.ValueChanged
        roundtripdate2.MinDate = roundtripdate1.Value
        dateround1 = Format(roundtripdate1.Value, "MMMM dd, yyyy")
        recdate1.Text = dateround1
    End Sub
    Private Sub roundtripdate2_ValueChanged(sender As Object, e As EventArgs) Handles roundtripdate2.ValueChanged
        dateround2 = Format(roundtripdate2.Value, "MMMM dd, yyyy")
        recdate2.Text = dateround2
    End Sub
    Private Sub cbobustype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobustype.SelectedIndexChanged
        If cbobustype.SelectedIndex = 0 Then
            nudpassengers.Maximum = 27
            bus = "Ordinary"
            btntrippagenext.Enabled = True
            recclass.Text = bus
        ElseIf cbobustype.SelectedIndex = 1 Then
            nudpassengers.Maximum = 35
            bus = "Class A"
            btntrippagenext.Enabled = True
            recclass.Text = bus
        ElseIf cbobustype.SelectedIndex = 2 Then
            nudpassengers.Maximum = 35
            bus = "Class B"
            btntrippagenext.Enabled = True
            recclass.Text = bus
        ElseIf cbobustype.SelectedIndex = 3 Then
            nudpassengers.Maximum = 56
            bus = "Class C"
            btntrippagenext.Enabled = True
            recclass.Text = bus
        End If
        nudpassengers.Enabled = True
    End Sub
    Private Sub nudpassengers_ValueChanged(sender As Object, e As EventArgs) Handles nudpassengers.ValueChanged
        numpassen = nudpassengers.Value
    End Sub
    Private Sub btntrippagenext_Click(sender As Object, e As EventArgs) Handles btntrippagenext.Click
        menucollapsed = False
        Timer1.Start()

        If rdoOneway.Checked = True Then
            If dateone = Date.Today Then
                If Date.Now.Hour >= 23 Then
                    MessageBox.Show("All Buses have departed for today", "Error Message", MessageBoxButtons.OK)
                    Exit Sub
                End If
                If cbobustype.SelectedIndex = 0 Then
                    If Date.Now.Hour >= 4 Then
                        btnClassObus1select.Text = "Departed"
                        btnClassObus1select.Enabled = False
                    End If
                    If Date.Now.Hour >= 10 Then
                        btnClassObus2select.Text = "Departed"
                        btnClassObus2select.Enabled = False
                    End If
                    If Date.Now.Hour >= 17 Then
                        btnClassObus3select.Text = "Departed"
                        btnClassObus3select.Enabled = False
                    End If
                ElseIf cbobustype.SelectedIndex = 1 Then
                    If Date.Now.Hour >= 4 Then
                        btnClassAbus1select.Text = "Departed"
                        btnClassAbus1select.Enabled = False
                    End If
                    If Date.Now.Hour >= 10 Then
                        btnClassAbus2select.Text = "Departed"
                        btnClassAbus2select.Enabled = False
                    End If
                    If Date.Now.Hour >= 17 Then
                        btnClassAbus3select.Text = "Departed"
                        btnClassAbus3select.Enabled = False
                    End If
                ElseIf cbobustype.SelectedIndex = 2 Then
                    If Date.Now.Hour >= 4 Then
                        btnClassBbus1select.Text = "Departed"
                        btnClassBbus1select.Enabled = False
                    End If
                    If Date.Now.Hour >= 10 Then
                        btnClassBbus2select.Text = "Departed"
                        btnClassBbus2select.Enabled = False
                    End If
                    If Date.Now.Hour >= 17 Then
                        btnClassBbus3select.Text = "Departed"
                        btnClassBbus3select.Enabled = False
                    End If
                ElseIf cbobustype.SelectedIndex = 3 Then
                    If Date.Now.Hour >= 4 Then
                        btnClassCbus1select.Text = "Departed"
                        btnClassCbus1select.Enabled = False
                    End If
                    If Date.Now.Hour >= 10 Then
                        btnClassCbus2select.Text = "Departed"
                        btnClassCbus2select.Enabled = False
                    End If
                    If Date.Now.Hour >= 17 Then
                        btnClassCbus3select.Text = "Departed"
                        btnClassCbus3select.Enabled = False
                    End If
                End If
            End If
        ElseIf rdoRoundtrip.Checked = True Then
            If dateround1 = Date.Today Then
                If dateround1 = dateround2 Then
                    btnClassObus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassObus4select.Text = "Unavailable"
                    btnClassObus4select.Enabled = False
                    btnClassAbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassAbus4select.Text = "Unavailable"
                    btnClassAbus4select.Enabled = False
                    btnClassBbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassBbus4select.Text = "Unavailable"
                    btnClassBbus4select.Enabled = False
                    btnClassCbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassCbus4select.Text = "Unavailable"
                    btnClassCbus4select.Enabled = False
                    If Date.Now.Hour >= 17 Then
                        MessageBox.Show("There are no Bus for return", "Error Message", MessageBoxButtons.OK)
                        Exit Sub
                    End If
                    If Date.Now.Hour >= 23 Then
                        MessageBox.Show("All Busses are departed for today", "Error Message", MessageBoxButtons.OK)
                        Exit Sub
                    End If
                    If cbobustype.SelectedIndex = 0 Then
                        If Date.Now.Hour >= 4 Then
                            btnClassObus1select.Text = "Departed"
                            btnClassObus1select.Enabled = False
                            btnClassObus1return.Text = "Departed"
                            btnClassObus1return.Enabled = False
                        End If
                        If Date.Now.Hour >= 10 Then
                            btnClassObus2select.Text = "Departed"
                            btnClassObus2select.Enabled = False
                            btnClassObus2return.Text = "Departed"
                            btnClassObus2return.Enabled = False
                        End If
                    ElseIf cbobustype.SelectedIndex = 1 Then
                        If Date.Now.Hour >= 4 Then
                            btnClassAbus1select.Text = "Departed"
                            btnClassAbus1select.Enabled = False
                            btnClassAbus1return.Text = "Departed"
                            btnClassAbus1return.Enabled = False
                        End If
                        If Date.Now.Hour >= 10 Then
                            btnClassAbus2select.Text = "Departed"
                            btnClassAbus2select.Enabled = False
                            btnClassAbus2return.Text = "Departed"
                            btnClassAbus2return.Enabled = False
                        End If
                    ElseIf cbobustype.SelectedIndex = 2 Then
                        If Date.Now.Hour >= 4 Then
                            btnClassBbus1select.Text = "Departed"
                            btnClassBbus1select.Enabled = False
                            btnClassBbus1return.Text = "Departed"
                            btnClassBbus1return.Enabled = False
                        End If
                        If Date.Now.Hour >= 10 Then
                            btnClassBbus2select.Text = "Departed"
                            btnClassBbus2select.Enabled = False
                            btnClassBbus2return.Text = "Departed"
                            btnClassBbus2return.Enabled = False
                        End If
                    ElseIf cbobustype.SelectedIndex = 3 Then
                        If Date.Now.Hour >= 4 Then
                            btnClassCbus1select.Text = "Departed"
                            btnClassCbus1select.Enabled = False
                            btnClassCbus1return.Text = "Departed"
                            btnClassCbus1return.Enabled = False
                        End If
                        If Date.Now.Hour >= 10 Then
                            btnClassCbus2select.Text = "Departed"
                            btnClassCbus2select.Enabled = False
                            btnClassCbus2return.Text = "Departed"
                            btnClassCbus2return.Enabled = False
                        End If
                    End If
                End If
            Else
                If dateround1 = dateround2 Then
                    btnClassObus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassObus4select.Text = "Unavailable"
                    btnClassObus4select.Enabled = False
                    btnClassAbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassAbus4select.Text = "Unavailable"
                    btnClassAbus4select.Enabled = False
                    btnClassBbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassBbus4select.Text = "Unavailable"
                    btnClassBbus4select.Enabled = False
                    btnClassCbus4select.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassCbus4select.Text = "Unavailable"
                    btnClassCbus4select.Enabled = False
                    If Date.Now.Hour >= 23 Then
                        MessageBox.Show("All Busses are departed for today", "Error Message", MessageBoxButtons.OK)
                        Exit Sub
                    End If
                End If
            End If
        End If
        'design for next panel
        pnlBookatrip.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        btnMenu.Enabled = False
        btnHome.Enabled = False
        btnabout.Enabled = False
        pnlhidemenu.Visible = True
        pnlhidehome.Visible = True
        pnlhideabout.Visible=True
        btnabout.BackgroundImage = My.Resources.grayabout
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        If rdoOneway.Checked = True Then
            lbltimedate.Text = dateone
            lblClassAAvailablebustxt.Text = dateone
            Label29.Text = dateone
            Label31.Text = dateone
        Else
            lbltimedate.Text = dateround1
            lblClassAAvailablebustxt.Text = dateround1
            Label29.Text = dateround1
            Label31.Text = dateround1
        End If
        If cbobustype.SelectedIndex = 0 Then
            If cbotodestination.SelectedIndex = 0 Then
                If cbofromdestination.SelectedIndex = 1 Then
                    price = 375
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price
                    lblClassObus1timest.Text = "Time Est. 10 HRS"
                    lblClassObus2timest.Text = "Time Est. 10 HRS"
                    lblClassObus3timest.Text = "Time Est. 10 HRS"
                    lblClassObus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 2 Then
                    price = 275
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 2 HRS"
                    lblClassObus2timest.Text = "Time Est. 2 HRS"
                    lblClassObus3timest.Text = "Time Est. 2 HRS"
                    lblClassObus4timest.Text = "Time Est. 2 HRS"
                ElseIf cbofromdestination.SelectedIndex = 3 Then
                    price = 335
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 5 HRS"
                    lblClassObus2timest.Text = "Time Est. 5 HRS"
                    lblClassObus3timest.Text = "Time Est. 5 HRS"
                    lblClassObus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 4 Then
                    price = 350
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 6 HRS"
                    lblClassObus2timest.Text = "Time Est. 6 HRS"
                    lblClassObus3timest.Text = "Time Est. 6 HRS"
                    lblClassObus4timest.Text = "Time Est. 6 HRS"
                ElseIf cbofromdestination.SelectedIndex = 5 Then
                    price = 900
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price


                    lblClassObus1timest.Text = "Time Est. 9 HRS"
                    lblClassObus2timest.Text = "Time Est. 9 HRS"
                    lblClassObus3timest.Text = "Time Est. 9 HRS"
                    lblClassObus4timest.Text = "Time Est. 9 HRS"
                ElseIf cbofromdestination.SelectedIndex = 6 Then
                    price = 540
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 5 HRS"
                    lblClassObus2timest.Text = "Time Est. 5 HRS"
                    lblClassObus3timest.Text = "Time Est. 5 HRS"
                    lblClassObus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 7 Then
                    price = 630
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 3 HRS"
                    lblClassObus2timest.Text = "Time Est. 3 HRS"
                    lblClassObus3timest.Text = "Time Est. 3 HRS"
                    lblClassObus4timest.Text = "Time Est. 3 HRS"
                ElseIf cbofromdestination.SelectedIndex = 8 Then
                    price = 520
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price


                    lblClassObus1timest.Text = "Time Est. 12 HRS"
                    lblClassObus2timest.Text = "Time Est. 12 HRS"
                    lblClassObus3timest.Text = "Time Est. 12 HRS"
                    lblClassObus4timest.Text = "Time Est. 12 HRS"
                ElseIf cbofromdestination.SelectedIndex = 9 Then
                    price = 620
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price


                    lblClassObus1timest.Text = "Time Est. 10 HRS"
                    lblClassObus2timest.Text = "Time Est. 10 HRS"
                    lblClassObus3timest.Text = "Time Est. 10 HRS"
                    lblClassObus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 10 Then
                    price = 550
                    lblClassObus1price.Text = price
                    lblClassObus2price.Text = price
                    lblClassObus3price.Text = price
                    lblClassObus4price.Text = price



                    lblClassObus1timest.Text = "Time Est. 6 HRS"
                    lblClassObus2timest.Text = "Time Est. 6 HRS"
                    lblClassObus3timest.Text = "Time Est. 6 HRS"
                    lblClassObus4timest.Text = "Time Est. 6 HRS"
                End If
            ElseIf cbotodestination.SelectedIndex = 1 Then
                price = 375
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 10 HRS"
                lblClassObus2timest.Text = "Time Est. 10 HRS"
                lblClassObus3timest.Text = "Time Est. 10 HRS"
                lblClassObus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 2 Then
                price = 275
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 2 HRS"
                lblClassObus2timest.Text = "Time Est. 2 HRS"
                lblClassObus3timest.Text = "Time Est. 2 HRS"
                lblClassObus4timest.Text = "Time Est. 2 HRS"
            ElseIf cbotodestination.SelectedIndex = 3 Then
                price = 335
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 5 HRS"
                lblClassObus2timest.Text = "Time Est. 5 HRS"
                lblClassObus3timest.Text = "Time Est. 5 HRS"
                lblClassObus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 4 Then
                price = 350
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 6 HRS"
                lblClassObus2timest.Text = "Time Est. 6 HRS"
                lblClassObus3timest.Text = "Time Est. 6 HRS"
                lblClassObus4timest.Text = "Time Est. 6 HRS"
            ElseIf cbotodestination.SelectedIndex = 5 Then
                price = 900
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 9 HRS"
                lblClassObus2timest.Text = "Time Est. 9 HRS"
                lblClassObus3timest.Text = "Time Est. 9 HRS"
                lblClassObus4timest.Text = "Time Est. 9 HRS"
            ElseIf cbotodestination.SelectedIndex = 6 Then
                price = 540
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 5 HRS"
                lblClassObus2timest.Text = "Time Est. 5 HRS"
                lblClassObus3timest.Text = "Time Est. 5 HRS"
                lblClassObus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 7 Then
                price = 630
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 3 HRS"
                lblClassObus2timest.Text = "Time Est. 3 HRS"
                lblClassObus3timest.Text = "Time Est. 3 HRS"
                lblClassObus4timest.Text = "Time Est. 3 HRS"
            ElseIf cbotodestination.SelectedIndex = 8 Then
                price = 520
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 12 HRS"
                lblClassObus2timest.Text = "Time Est. 12 HRS"
                lblClassObus3timest.Text = "Time Est. 12 HRS"
                lblClassObus4timest.Text = "Time Est. 12 HRS"
            ElseIf cbotodestination.SelectedIndex = 9 Then
                price = 620
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price


                lblClassObus1timest.Text = "Time Est. 10 HRS"
                lblClassObus2timest.Text = "Time Est. 10 HRS"
                lblClassObus3timest.Text = "Time Est. 10 HRS"
                lblClassObus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 10 Then
                price = 550
                lblClassObus1price.Text = price
                lblClassObus2price.Text = price
                lblClassObus3price.Text = price
                lblClassObus4price.Text = price

                lblClassObus1timest.Text = "Time Est. 6 HRS"
                lblClassObus2timest.Text = "Time Est. 6 HRS"
                lblClassObus3timest.Text = "Time Est. 6 HRS"
                lblClassObus4timest.Text = "Time Est. 6 HRS"
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = True
        ElseIf cbobustype.SelectedIndex = 1 Then
            If cbotodestination.SelectedIndex = 0 Then
                If cbofromdestination.SelectedIndex = 1 Then
                    price = 750
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 10 HRS"
                    lblClassAbus2timest.Text = "Time Est. 10 HRS"
                    lblClassAbus3timest.Text = "Time Est. 10 HRS"
                    lblClassAbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 2 Then
                    price = 500
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 2 HRS"
                    lblClassAbus2timest.Text = "Time Est. 2 HRS"
                    lblClassAbus3timest.Text = "Time Est. 2 HRS"
                    lblClassAbus4timest.Text = "Time Est. 2 HRS"
                ElseIf cbofromdestination.SelectedIndex = 3 Then
                    price = 415
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 5 HRS"
                    lblClassAbus2timest.Text = "Time Est. 5 HRS"
                    lblClassAbus3timest.Text = "Time Est. 5 HRS"
                    lblClassAbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 4 Then
                    price = 585
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 6 HRS"
                    lblClassAbus2timest.Text = "Time Est. 6 HRS"
                    lblClassAbus3timest.Text = "Time Est. 6 HRS"
                    lblClassAbus4timest.Text = "Time Est. 6 HRS"
                ElseIf cbofromdestination.SelectedIndex = 5 Then
                    price = 1300
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 9 HRS"
                    lblClassAbus2timest.Text = "Time Est. 9 HRS"
                    lblClassAbus3timest.Text = "Time Est. 9 HRS"
                    lblClassAbus4timest.Text = "Time Est. 9 HRS"
                ElseIf cbofromdestination.SelectedIndex = 6 Then
                    price = 850
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 5 HRS"
                    lblClassAbus2timest.Text = "Time Est. 5 HRS"
                    lblClassAbus3timest.Text = "Time Est. 5 HRS"
                    lblClassAbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 7 Then
                    price = 900
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 3 HRS"
                    lblClassAbus2timest.Text = "Time Est. 3 HRS"
                    lblClassAbus3timest.Text = "Time Est. 3 HRS"
                    lblClassAbus4timest.Text = "Time Est. 3 HRS"
                ElseIf cbofromdestination.SelectedIndex = 8 Then
                    price = 850
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 12 HRS"
                    lblClassAbus2timest.Text = "Time Est. 12 HRS"
                    lblClassAbus3timest.Text = "Time Est. 12 HRS"
                    lblClassAbus4timest.Text = "Time Est. 12 HRS"
                ElseIf cbofromdestination.SelectedIndex = 9 Then
                    price = 900
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 10 HRS"
                    lblClassAbus2timest.Text = "Time Est. 10 HRS"
                    lblClassAbus3timest.Text = "Time Est. 10 HRS"
                    lblClassAbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 10 Then
                    price = 800
                    lblClassAbus1price.Text = price
                    lblClassAbus2price.Text = price
                    lblClassAbus3price.Text = price
                    lblClassAbus4price.Text = price

                    lblClassAbus1timest.Text = "Time Est. 6 HRS"
                    lblClassAbus2timest.Text = "Time Est. 6 HRS"
                    lblClassAbus3timest.Text = "Time Est. 6 HRS"
                    lblClassAbus4timest.Text = "Time Est. 6 HRS"
                End If
            ElseIf cbotodestination.SelectedIndex = 1 Then
                price = 750
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 10 HRS"
                lblClassAbus2timest.Text = "Time Est. 10 HRS"
                lblClassAbus3timest.Text = "Time Est. 10 HRS"
                lblClassAbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 2 Then
                price = 500
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 2 HRS"
                lblClassAbus2timest.Text = "Time Est. 2 HRS"
                lblClassAbus3timest.Text = "Time Est. 2 HRS"
                lblClassAbus4timest.Text = "Time Est. 2 HRS"
            ElseIf cbotodestination.SelectedIndex = 3 Then
                price = 415
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 5 HRS"
                lblClassAbus2timest.Text = "Time Est. 5 HRS"
                lblClassAbus3timest.Text = "Time Est. 5 HRS"
                lblClassAbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 4 Then
                price = 585
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 6 HRS"
                lblClassAbus2timest.Text = "Time Est. 6 HRS"
                lblClassAbus3timest.Text = "Time Est. 6 HRS"
                lblClassAbus4timest.Text = "Time Est. 6 HRS"
            ElseIf cbotodestination.SelectedIndex = 5 Then
                price = 1300
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 9 HRS"
                lblClassAbus2timest.Text = "Time Est. 9 HRS"
                lblClassAbus3timest.Text = "Time Est. 9 HRS"
                lblClassAbus4timest.Text = "Time Est. 9 HRS"
            ElseIf cbotodestination.SelectedIndex = 6 Then
                price = 850
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 5 HRS"
                lblClassAbus2timest.Text = "Time Est. 5 HRS"
                lblClassAbus3timest.Text = "Time Est. 5 HRS"
                lblClassAbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 7 Then
                price = 900
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 3 HRS"
                lblClassAbus2timest.Text = "Time Est. 3 HRS"
                lblClassAbus3timest.Text = "Time Est. 3 HRS"
                lblClassAbus4timest.Text = "Time Est. 3 HRS"
            ElseIf cbotodestination.SelectedIndex = 8 Then
                price = 850
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 12 HRS"
                lblClassAbus2timest.Text = "Time Est. 12 HRS"
                lblClassAbus3timest.Text = "Time Est. 12 HRS"
                lblClassAbus4timest.Text = "Time Est. 12 HRS"
            ElseIf cbotodestination.SelectedIndex = 9 Then
                price = 900
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 10 HRS"
                lblClassAbus2timest.Text = "Time Est. 10 HRS"
                lblClassAbus3timest.Text = "Time Est. 10 HRS"
                lblClassAbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 10 Then
                price = 800
                lblClassAbus1price.Text = price
                lblClassAbus2price.Text = price
                lblClassAbus3price.Text = price
                lblClassAbus4price.Text = price

                lblClassAbus1timest.Text = "Time Est. 6 HRS"
                lblClassAbus2timest.Text = "Time Est. 6 HRS"
                lblClassAbus3timest.Text = "Time Est. 6 HRS"
                lblClassAbus4timest.Text = "Time Est. 6 HRS"
            End If
            pnlClassAbuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
        ElseIf cbobustype.SelectedIndex = 2 Then
            If cbotodestination.SelectedIndex = 0 Then
                If cbofromdestination.SelectedIndex = 1 Then
                    price = 450
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 10 HRS"
                    lblClassBbus2timest.Text = "Time Est. 10 HRS"
                    lblClassBbus3timest.Text = "Time Est. 10 HRS"
                    lblClassBbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 2 Then
                    price = 400
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 2 HRS"
                    lblClassBbus2timest.Text = "Time Est. 2 HRS"
                    lblClassBbus3timest.Text = "Time Est. 2 HRS"
                    lblClassBbus4timest.Text = "Time Est. 2 HRS"
                ElseIf cbofromdestination.SelectedIndex = 3 Then
                    price = 390
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 5 HRS"
                    lblClassBbus2timest.Text = "Time Est. 5 HRS"
                    lblClassBbus3timest.Text = "Time Est. 5 HRS"
                    lblClassBbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 4 Then
                    price = 485
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 6 HRS"
                    lblClassBbus2timest.Text = "Time Est. 6 HRS"
                    lblClassBbus3timest.Text = "Time Est. 6 HRS"
                    lblClassBbus4timest.Text = "Time Est. 6 HRS"
                ElseIf cbofromdestination.SelectedIndex = 5 Then
                    price = 975
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 9 HRS"
                    lblClassBbus2timest.Text = "Time Est. 9 HRS"
                    lblClassBbus3timest.Text = "Time Est. 9 HRS"
                    lblClassBbus4timest.Text = "Time Est. 9 HRS"
                ElseIf cbofromdestination.SelectedIndex = 6 Then
                    price = 750
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 5 HRS"
                    lblClassBbus2timest.Text = "Time Est. 5 HRS"
                    lblClassBbus3timest.Text = "Time Est. 5 HRS"
                    lblClassBbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 7 Then
                    price = 875
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price


                    lblClassBbus1timest.Text = "Time Est. 3 HRS"
                    lblClassBbus2timest.Text = "Time Est. 3 HRS"
                    lblClassBbus3timest.Text = "Time Est. 3 HRS"
                    lblClassBbus4timest.Text = "Time Est. 3 HRS"
                ElseIf cbofromdestination.SelectedIndex = 8 Then
                    price = 750
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 12 HRS"
                    lblClassBbus2timest.Text = "Time Est. 12 HRS"
                    lblClassBbus3timest.Text = "Time Est. 12 HRS"
                    lblClassBbus4timest.Text = "Time Est. 12 HRS"
                ElseIf cbofromdestination.SelectedIndex = 9 Then
                    price = 875
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 10 HRS"
                    lblClassBbus2timest.Text = "Time Est. 10 HRS"
                    lblClassBbus3timest.Text = "Time Est. 10 HRS"
                    lblClassBbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 10 Then
                    price = 700
                    lblClassBbus1price.Text = price
                    lblClassBbus2price.Text = price
                    lblClassBbus3price.Text = price
                    lblClassBbus4price.Text = price

                    lblClassBbus1timest.Text = "Time Est. 6 HRS"
                    lblClassBbus2timest.Text = "Time Est. 6 HRS"
                    lblClassBbus3timest.Text = "Time Est. 6 HRS"
                    lblClassBbus4timest.Text = "Time Est. 6 HRS"
                End If
            ElseIf cbotodestination.SelectedIndex = 1 Then
                price = 450
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 10 HRS"
                lblClassBbus2timest.Text = "Time Est. 10 HRS"
                lblClassBbus3timest.Text = "Time Est. 10 HRS"
                lblClassBbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 2 Then
                price = 400
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 2 HRS"
                lblClassBbus2timest.Text = "Time Est. 2 HRS"
                lblClassBbus3timest.Text = "Time Est. 2 HRS"
                lblClassBbus4timest.Text = "Time Est. 2 HRS"
            ElseIf cbotodestination.SelectedIndex = 3 Then
                price = 390
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 5 HRS"
                lblClassBbus2timest.Text = "Time Est. 5 HRS"
                lblClassBbus3timest.Text = "Time Est. 5 HRS"
                lblClassBbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 4 Then
                price = 485
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 6 HRS"
                lblClassBbus2timest.Text = "Time Est. 6 HRS"
                lblClassBbus3timest.Text = "Time Est. 6 HRS"
                lblClassBbus4timest.Text = "Time Est. 6 HRS"
            ElseIf cbotodestination.SelectedIndex = 5 Then
                price = 975
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 9 HRS"
                lblClassBbus2timest.Text = "Time Est. 9 HRS"
                lblClassBbus3timest.Text = "Time Est. 9 HRS"
                lblClassBbus4timest.Text = "Time Est. 9 HRS"
            ElseIf cbotodestination.SelectedIndex = 6 Then
                price = 750
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 5 HRS"
                lblClassBbus2timest.Text = "Time Est. 5 HRS"
                lblClassBbus3timest.Text = "Time Est. 5 HRS"
                lblClassBbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 7 Then
                price = 875
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 3 HRS"
                lblClassBbus2timest.Text = "Time Est. 3 HRS"
                lblClassBbus3timest.Text = "Time Est. 3 HRS"
                lblClassBbus4timest.Text = "Time Est. 3 HRS"
            ElseIf cbotodestination.SelectedIndex = 8 Then
                price = 750
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 12 HRS"
                lblClassBbus2timest.Text = "Time Est. 12 HRS"
                lblClassBbus3timest.Text = "Time Est. 12 HRS"
                lblClassBbus4timest.Text = "Time Est. 12 HRS"
            ElseIf cbotodestination.SelectedIndex = 9 Then
                price = 875
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price


                lblClassBbus1timest.Text = "Time Est. 10 HRS"
                lblClassBbus2timest.Text = "Time Est. 10 HRS"
                lblClassBbus3timest.Text = "Time Est. 10 HRS"
                lblClassBbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 10 Then
                price = 700
                lblClassBbus1price.Text = price
                lblClassBbus2price.Text = price
                lblClassBbus3price.Text = price
                lblClassBbus4price.Text = price

                lblClassBbus1timest.Text = "Time Est. 6 HRS"
                lblClassBbus2timest.Text = "Time Est. 6 HRS"
                lblClassBbus3timest.Text = "Time Est. 6 HRS"
                lblClassBbus4timest.Text = "Time Est. 6 HRS"
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
        ElseIf cbobustype.SelectedIndex = 3 Then
            If cbotodestination.SelectedIndex = 0 Then
                If cbofromdestination.SelectedIndex = 1 Then
                    price = 425
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 10 HRS"
                    lblClassCbus2timest.Text = "Time Est. 10 HRS"
                    lblClassCbus3timest.Text = "Time Est. 10 HRS"
                    lblClassCbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 2 Then
                    price = 375
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 2 HRS"
                    lblClassCbus2timest.Text = "Time Est. 2 HRS"
                    lblClassCbus3timest.Text = "Time Est. 2 HRS"
                    lblClassCbus4timest.Text = "Time Est. 2 HRS"
                ElseIf cbofromdestination.SelectedIndex = 3 Then
                    price = 350
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price


                    lblClassCbus1timest.Text = "Time Est. 5 HRS"
                    lblClassCbus2timest.Text = "Time Est. 5 HRS"
                    lblClassCbus3timest.Text = "Time Est. 5 HRS"
                    lblClassCbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 4 Then
                    price = 400
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 6 HRS"
                    lblClassCbus2timest.Text = "Time Est. 6 HRS"
                    lblClassCbus3timest.Text = "Time Est. 6 HRS"
                    lblClassCbus4timest.Text = "Time Est. 6 HRS"
                ElseIf cbofromdestination.SelectedIndex = 5 Then
                    price = 870
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 9 HRS"
                    lblClassCbus2timest.Text = "Time Est. 9 HRS"
                    lblClassCbus3timest.Text = "Time Est. 9 HRS"
                    lblClassCbus4timest.Text = "Time Est. 9 HRS"
                ElseIf cbofromdestination.SelectedIndex = 6 Then
                    price = 650
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 5 HRS"
                    lblClassCbus2timest.Text = "Time Est. 5 HRS"
                    lblClassCbus3timest.Text = "Time Est. 5 HRS"
                    lblClassCbus4timest.Text = "Time Est. 5 HRS"
                ElseIf cbofromdestination.SelectedIndex = 7 Then
                    price = 735
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 3 HRS"
                    lblClassCbus2timest.Text = "Time Est. 3 HRS"
                    lblClassCbus3timest.Text = "Time Est. 3 HRS"
                    lblClassCbus4timest.Text = "Time Est. 3 HRS"
                ElseIf cbofromdestination.SelectedIndex = 8 Then
                    price = 690
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 12 HRS"
                    lblClassCbus2timest.Text = "Time Est. 12 HRS"
                    lblClassCbus3timest.Text = "Time Est. 12 HRS"
                    lblClassCbus4timest.Text = "Time Est. 12 HRS"
                ElseIf cbofromdestination.SelectedIndex = 9 Then
                    price = 735
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price

                    lblClassCbus1timest.Text = "Time Est. 10 HRS"
                    lblClassCbus2timest.Text = "Time Est. 10 HRS"
                    lblClassCbus3timest.Text = "Time Est. 10 HRS"
                    lblClassCbus4timest.Text = "Time Est. 10 HRS"
                ElseIf cbofromdestination.SelectedIndex = 10 Then
                    price = 675
                    lblClassCbus1price.Text = price
                    lblClassCbus2price.Text = price
                    lblClassCbus3price.Text = price
                    lblClassCbus4price.Text = price
                    lblClassCbus1timest.Text = "Time Est. 6 HRS"
                    lblClassCbus2timest.Text = "Time Est. 6 HRS"
                    lblClassCbus3timest.Text = "Time Est. 6 HRS"
                    lblClassCbus4timest.Text = "Time Est. 6 HRS"
                End If
            ElseIf cbotodestination.SelectedIndex = 1 Then
                price = 425
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 10 HRS"
                lblClassCbus2timest.Text = "Time Est. 10 HRS"
                lblClassCbus3timest.Text = "Time Est. 10 HRS"
                lblClassCbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 2 Then
                price = 375
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 2 HRS"
                lblClassCbus2timest.Text = "Time Est. 2 HRS"
                lblClassCbus3timest.Text = "Time Est. 2 HRS"
                lblClassCbus4timest.Text = "Time Est. 2 HRS"
            ElseIf cbotodestination.SelectedIndex = 3 Then
                price = 350
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 5 HRS"
                lblClassCbus2timest.Text = "Time Est. 5 HRS"
                lblClassCbus3timest.Text = "Time Est. 5 HRS"
                lblClassCbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 4 Then
                price = 400
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 6 HRS"
                lblClassCbus2timest.Text = "Time Est. 6 HRS"
                lblClassCbus3timest.Text = "Time Est. 6 HRS"
                lblClassCbus4timest.Text = "Time Est. 6 HRS"
            ElseIf cbotodestination.SelectedIndex = 5 Then
                price = 870
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 9 HRS"
                lblClassCbus2timest.Text = "Time Est. 9 HRS"
                lblClassCbus3timest.Text = "Time Est. 9 HRS"
                lblClassCbus4timest.Text = "Time Est. 9 HRS"
            ElseIf cbotodestination.SelectedIndex = 6 Then
                price = 650
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 5 HRS"
                lblClassCbus2timest.Text = "Time Est. 5 HRS"
                lblClassCbus3timest.Text = "Time Est. 5 HRS"
                lblClassCbus4timest.Text = "Time Est. 5 HRS"
            ElseIf cbotodestination.SelectedIndex = 7 Then
                price = 735
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 3 HRS"
                lblClassCbus2timest.Text = "Time Est. 3 HRS"
                lblClassCbus3timest.Text = "Time Est. 3 HRS"
                lblClassCbus4timest.Text = "Time Est. 3 HRS"
            ElseIf cbotodestination.SelectedIndex = 8 Then
                price = 690
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 12 HRS"
                lblClassCbus2timest.Text = "Time Est. 12 HRS"
                lblClassCbus3timest.Text = "Time Est. 12 HRS"
                lblClassCbus4timest.Text = "Time Est. 12 HRS"
            ElseIf cbotodestination.SelectedIndex = 9 Then
                price = 735
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 10 HRS"
                lblClassCbus2timest.Text = "Time Est. 10 HRS"
                lblClassCbus3timest.Text = "Time Est. 10 HRS"
                lblClassCbus4timest.Text = "Time Est. 10 HRS"
            ElseIf cbotodestination.SelectedIndex = 10 Then
                price = 675
                lblClassCbus1price.Text = price
                lblClassCbus2price.Text = price
                lblClassCbus3price.Text = price
                lblClassCbus4price.Text = price

                lblClassCbus1timest.Text = "Time Est. 6 HRS"
                lblClassCbus2timest.Text = "Time Est. 6 HRS"
                lblClassCbus3timest.Text = "Time Est. 6 HRS"
                lblClassCbus4timest.Text = "Time Est. 6 HRS"
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlClassObuses.Visible = False
        End If
        lblAvailablebusesO.Text = "Departure Trip: Available buses"
        lblAvailablebusesA.Text = "Departure Trip: Available buses"
        lblAvailablebusesB.Text = "Departure Trip: Available buses"
        lblAvailablebusesC.Text = "Departure Trip: Available buses"
        lblpassengercount.Text = "Passenger " & ctr.ToString & " of " & nudpassengers.Value
    End Sub
    'dep des typeoftrip="Oneway"/"Roundtrip" trip=1/2 dateone dateround1 dateround2 bus numpassen price
    'Ordinary next and back button
    Private Sub btnClassObus1select_Click(sender As Object, e As EventArgs) Handles btnClassObus1select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassObus1return.Text = "Selected"
                btnClassObus1return.Enabled = False
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = True
            lbltimedate.Text = dateround2
            lblAvailablebusesO.Text = "Return Trip: Available buses"
            btnClassObus1select.Visible = False
            btnClassObus1return.Visible = True
            btnClassObus2select.Visible = False
            btnClassObus2return.Visible = True
            btnClassObus3select.Visible = False
            btnClassObus3return.Visible = True
            btnClassObus4select.Visible = False
            btnClassObus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassObus2select_Click(sender As Object, e As EventArgs) Handles btnClassObus2select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 4 Then
                    btnClassObus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassObus1return.Text = "Unavailable"
                    btnClassObus1return.Enabled = False
                    btnClassObus2return.Text = "Selected"
                    btnClassObus2return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = True
            lbltimedate.Text = dateround2
            lblAvailablebusesO.Text = "Return Trip: Available buses"
            btnClassObus1select.Visible = False
            btnClassObus1return.Visible = True
            btnClassObus2select.Visible = False
            btnClassObus2return.Visible = True
            btnClassObus3select.Visible = False
            btnClassObus3return.Visible = True
            btnClassObus4select.Visible = False
            btnClassObus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassObus3select_Click(sender As Object, e As EventArgs) Handles btnClassObus3select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 10 Then
                    btnClassObus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassObus1return.Text = "Unavailable"
                    btnClassObus1return.Enabled = False
                    btnClassObus2return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassObus2return.Text = "Unavailable"
                    btnClassObus2return.Enabled = False
                    btnClassObus3return.Text = "Selected"
                    btnClassObus3return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = True
            lbltimedate.Text = dateround2
            lblAvailablebusesO.Text = "Return Trip: Available buses"
            btnClassObus1select.Visible = False
            btnClassObus1return.Visible = True
            btnClassObus2select.Visible = False
            btnClassObus2return.Visible = True
            btnClassObus3select.Visible = False
            btnClassObus3return.Visible = True
            btnClassObus4select.Visible = False
            btnClassObus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassObus4select_Click(sender As Object, e As EventArgs) Handles btnClassObus4select.Click
        If rdoRoundtrip.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = True
            lbltimedate.Text = dateround2
            lblAvailablebusesO.Text = "Return Trip: Available buses"
            btnClassObus1select.Visible = False
            btnClassObus1return.Visible = True
            btnClassObus2select.Visible = False
            btnClassObus2return.Visible = True
            btnClassObus3select.Visible = False
            btnClassObus3return.Visible = True
            btnClassObus4select.Visible = False
            btnClassObus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassOback_Click(sender As Object, e As EventArgs) Handles btnClassOback.Click
        menucollapsed = False
        Timer1.Start()

        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = True
        pnlAbout.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        If rdoOneway.Checked = True Then
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
        Else
            pnlonewaytrip.Visible = False
            pnlroundtrip.Visible = True
            btnClassObus1select.Visible = True
            btnClassObus1return.Visible = False
            btnClassObus2select.Visible = True
            btnClassObus2return.Visible = False
            btnClassObus3select.Visible = True
            btnClassObus3return.Visible = False
            btnClassObus4select.Visible = True
            btnClassObus4return.Visible = False
        End If
        btnClassObus1select.Text = "Select"
        btnClassObus1select.Enabled = True
        btnClassObus2select.Text = "Select"
        btnClassObus2select.Enabled = True
        btnClassObus3select.Text = "Select"
        btnClassObus3select.Enabled = True
        btnClassObus4select.Text = "Select"
        btnClassObus4select.Enabled = True
        btnClassObus1return.Text = "Select"
        btnClassObus1return.Enabled = True
        btnClassObus2return.Text = "Select"
        btnClassObus2return.Enabled = True
        btnClassObus3return.Text = "Select"
        btnClassObus3return.Enabled = True
        btnClassObus4return.Text = "Select"
        btnClassObus4return.Enabled = True
        btnMenu.Enabled = True
        btnHome.Enabled = True
        btnabout.Enabled = True
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlhidemenu.Visible = False
        pnlhidehome.Visible = False
        pnlhideabout.Visible = False
    End Sub
    Private Sub btnClassObus1return_Click(sender As Object, e As EventArgs) Handles btnClassObus1return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassObus2return_Click(sender As Object, e As EventArgs) Handles btnClassObus2return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassObus3return_Click(sender As Object, e As EventArgs) Handles btnClassObus3return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassObus4sreturn_Click(sender As Object, e As EventArgs) Handles btnClassObus4return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    'Class A next and back button
    Private Sub btnClassAbus1select_Click(sender As Object, e As EventArgs) Handles btnClassAbus1select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassAbus1return.Text = "Selected"
                btnClassAbus1return.Enabled = False
            End If
            pnlClassAbuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            lblClassAAvailablebustxt.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassAbus1select.Visible = False
            btnClassAbus1return.Visible = True
            btnClassAbus2select.Visible = False
            btnClassAbus2return.Visible = True
            btnClassAbus3select.Visible = False
            btnClassAbus3return.Visible = True
            btnClassAbus4select.Visible = False
            btnClassAbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassAbus2select_Click(sender As Object, e As EventArgs) Handles btnClassAbus2select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 4 Then
                    btnClassAbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassAbus1return.Text = "Unavailable"
                    btnClassAbus1return.Enabled = False
                    btnClassAbus2return.Text = "Selected"
                    btnClassAbus2return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            lblClassAAvailablebustxt.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassAbus1select.Visible = False
            btnClassAbus1return.Visible = True
            btnClassAbus2select.Visible = False
            btnClassAbus2return.Visible = True
            btnClassAbus3select.Visible = False
            btnClassAbus3return.Visible = True
            btnClassAbus4select.Visible = False
            btnClassAbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassAbus3select_Click(sender As Object, e As EventArgs) Handles btnClassAbus3select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 10 Then
                    btnClassAbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassAbus1return.Text = "Unavailable"
                    btnClassAbus1return.Enabled = False
                    btnClassAbus2return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassAbus2return.Text = "Unavailable"
                    btnClassAbus2return.Enabled = False
                    btnClassAbus3return.Text = "Selected"
                    btnClassAbus3return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            lblClassAAvailablebustxt.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassAbus1select.Visible = False
            btnClassAbus1return.Visible = True
            btnClassAbus2select.Visible = False
            btnClassAbus2return.Visible = True
            btnClassAbus3select.Visible = False
            btnClassAbus3return.Visible = True
            btnClassAbus4select.Visible = False
            btnClassAbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassAbus4select_Click(sender As Object, e As EventArgs) Handles btnClassAbus4select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassAbus4return.Text = "Selected"
                btnClassAbus4return.Enabled = False
            End If
            pnlClassAbuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            lblClassAAvailablebustxt.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassAbus1select.Visible = False
            btnClassAbus1return.Visible = True
            btnClassAbus2select.Visible = False
            btnClassAbus2return.Visible = True
            btnClassAbus3select.Visible = False
            btnClassAbus3return.Visible = True
            btnClassAbus4select.Visible = False
            btnClassAbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassAback_Click(sender As Object, e As EventArgs) Handles btnClassAback.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = True
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        If rdoOneway.Checked = True Then
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
        Else
            pnlonewaytrip.Visible = False
            pnlroundtrip.Visible = True
            btnClassAbus1select.Visible = True
            btnClassAbus1return.Visible = False
            btnClassAbus2select.Visible = True
            btnClassAbus2return.Visible = False
            btnClassAbus3select.Visible = True
            btnClassAbus3return.Visible = False
            btnClassAbus4select.Visible = True
            btnClassAbus4return.Visible = False
        End If
        btnClassAbus1select.Text = "Select"
        btnClassAbus1select.Enabled = True
        btnClassAbus2select.Text = "Select"
        btnClassAbus2select.Enabled = True
        btnClassAbus3select.Text = "Select"
        btnClassAbus3select.Enabled = True
        btnClassAbus4select.Text = "Select"
        btnClassAbus4select.Enabled = True
        btnClassAbus1return.Text = "Select"
        btnClassAbus1return.Enabled = True
        btnClassAbus2return.Text = "Select"
        btnClassAbus2return.Enabled = True
        btnClassAbus3return.Text = "Select"
        btnClassAbus3return.Enabled = True
        btnClassAbus4return.Text = "Select"
        btnClassAbus4return.Enabled = True
        btnMenu.Enabled = True
        btnHome.Enabled = True
        btnabout.Enabled = True
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlhidemenu.Visible = False
        pnlhidehome.Visible = False
        pnlhideabout.Visible = False
    End Sub
    Private Sub btnClassAbus1return_Click(sender As Object, e As EventArgs) Handles btnClassAbus1return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassAbus2return_Click(sender As Object, e As EventArgs) Handles btnClassAbus2return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassAbus3return_Click(sender As Object, e As EventArgs) Handles btnClassAbus3return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassAbus4return_Click(sender As Object, e As EventArgs) Handles btnClassAbus4return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub

    'Class B next and back button
    Private Sub btnClassBbus1select_Click(sender As Object, e As EventArgs) Handles btnClassBbus1select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassBbus1return.Text = "Selected"
                btnClassBbus1return.Enabled = False
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            Label29.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassBbus1select.Visible = False
            btnClassBbus1return.Visible = True
            btnClassBbus2select.Visible = False
            btnClassBbus2return.Visible = True
            btnClassBbus3select.Visible = False
            btnClassBbus3return.Visible = True
            btnClassBbus4select.Visible = False
            btnClassBbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassBbus2select_Click(sender As Object, e As EventArgs) Handles btnClassBbus2select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 4 Then
                    btnClassBbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassBbus1return.Text = "Unavailable"
                    btnClassBbus1return.Enabled = False
                    btnClassBbus2return.Text = "Selected"
                    btnClassBbus2return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            Label29.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassBbus1select.Visible = False
            btnClassBbus1return.Visible = True
            btnClassBbus2select.Visible = False
            btnClassBbus2return.Visible = True
            btnClassBbus3select.Visible = False
            btnClassBbus3return.Visible = True
            btnClassBbus4select.Visible = False
            btnClassBbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub lblClassBbus3select_Click(sender As Object, e As EventArgs) Handles btnClassBbus3select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 10 Then
                    btnClassBbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassBbus1return.Text = "Unavailable"
                    btnClassBbus1return.Enabled = False
                    btnClassBbus2return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassBbus2return.Text = "Unavailable"
                    btnClassBbus2return.Enabled = False
                    btnClassBbus3return.Text = "Selected"
                    btnClassBbus3return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            Label29.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassBbus1select.Visible = False
            btnClassBbus1return.Visible = True
            btnClassBbus2select.Visible = False
            btnClassBbus2return.Visible = True
            btnClassBbus3select.Visible = False
            btnClassBbus3return.Visible = True
            btnClassBbus4select.Visible = False
            btnClassBbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassBbus4select_Click(sender As Object, e As EventArgs) Handles btnClassBbus4select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassBbus4return.Text = "Selected"
                btnClassBbus4return.Enabled = False
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlClassObuses.Visible = False
            Label29.Text = dateround2
            lblAvailablebusesA.Text = "Return Trip: Available buses"
            btnClassBbus1select.Visible = False
            btnClassBbus1return.Visible = True
            btnClassBbus2select.Visible = False
            btnClassBbus2return.Visible = True
            btnClassBbus3select.Visible = False
            btnClassBbus3return.Visible = True
            btnClassBbus4select.Visible = False
            btnClassBbus4return.Visible = True
        ElseIf rdoOneway.Checked = True Then
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassBback_Click(sender As Object, e As EventArgs) Handles btnClassBback.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = True
        pnlAbout.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        If rdoOneway.Checked = True Then
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
        Else
            pnlonewaytrip.Visible = False
            pnlroundtrip.Visible = True
            btnClassBbus1select.Visible = True
            btnClassBbus1return.Visible = False
            btnClassBbus2select.Visible = True
            btnClassBbus2return.Visible = False
            btnClassBbus3select.Visible = True
            btnClassBbus3return.Visible = False
            btnClassBbus4select.Visible = True
            btnClassBbus4return.Visible = False
        End If
        btnClassBbus1select.Text = "Select"
        btnClassBbus1select.Enabled = True
        btnClassBbus2select.Text = "Select"
        btnClassBbus2select.Enabled = True
        btnClassBbus3select.Text = "Select"
        btnClassBbus3select.Enabled = True
        btnClassBbus4select.Text = "Select"
        btnClassBbus4select.Enabled = True
        btnClassBbus1return.Text = "Select"
        btnClassBbus1return.Enabled = True
        btnClassBbus2return.Text = "Select"
        btnClassBbus2return.Enabled = True
        btnClassBbus3return.Text = "Select"
        btnClassBbus3return.Enabled = True
        btnClassBbus4return.Text = "Select"
        btnClassBbus4return.Enabled = True
        btnMenu.Enabled = True
        btnHome.Enabled = True
        btnabout.Enabled = True
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlhidemenu.Visible = False
        pnlhidehome.Visible = False
        pnlhideabout.Visible = False
    End Sub
    Private Sub btnClassBbus1return_Click(sender As Object, e As EventArgs) Handles btnClassBbus1return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassBbus2return_Click(sender As Object, e As EventArgs) Handles btnClassBbus2return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassBbus3return_Click(sender As Object, e As EventArgs) Handles btnClassBbus3return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassBbus4return_Click(sender As Object, e As EventArgs) Handles btnClassBbus4return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    'Class C next and back button
    Private Sub btnClassCbus1select_Click(sender As Object, e As EventArgs) Handles btnClassCbus1select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassCbus1return.Text = "Selected"
                btnClassCbus1return.Enabled = False
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlClassObuses.Visible = False
            Label31.Text = dateround2
            lblAvailablebusesC.Text = "Return Trip: Available buses"
            btnClassCbus1select.Visible = False
            btnClassCbus1return.Visible = True
            btnClassCbus2select.Visible = False
            btnClassCbus2return.Visible = True
            btnClassCbus3select.Visible = False
            btnClassCbus3return.Visible = True
            btnClassCbus4select.Visible = False
            btnClassCbus4return.Visible = True

        Else
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassCbus2select_Click(sender As Object, e As EventArgs) Handles btnClassCbus2select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 4 Then
                    btnClassBbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassCbus1return.Text = "Unavailable"
                    btnClassCbus1return.Enabled = False
                    btnClassCbus2return.Text = "Selected"
                    btnClassCbus2return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlClassObuses.Visible = False
            Label31.Text = dateround2
            lblAvailablebusesC.Text = "Return Trip: Available buses"
            btnClassCbus1select.Visible = False
            btnClassCbus1return.Visible = True
            btnClassCbus2select.Visible = False
            btnClassCbus2return.Visible = True
            btnClassCbus3select.Visible = False
            btnClassCbus3return.Visible = True
            btnClassCbus4select.Visible = False
            btnClassCbus4return.Visible = True

        Else
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassCbus3select_Click(sender As Object, e As EventArgs) Handles btnClassCbus3select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                If Date.Now.Hour < 10 Then
                    btnClassCbus1return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassCbus1return.Text = "Unavailable"
                    btnClassCbus1return.Enabled = False
                    btnClassCbus2return.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    btnClassCbus2return.Text = "Unavailable"
                    btnClassCbus2return.Enabled = False
                    btnClassCbus3return.Text = "Selected"
                    btnClassCbus3return.Enabled = False
                End If
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlClassObuses.Visible = False
            Label31.Text = dateround2
            lblAvailablebusesC.Text = "Return Trip: Available buses"
            btnClassCbus1select.Visible = False
            btnClassCbus1return.Visible = True
            btnClassCbus2select.Visible = False
            btnClassCbus2return.Visible = True
            btnClassCbus3select.Visible = False
            btnClassCbus3return.Visible = True
            btnClassCbus4select.Visible = False
            btnClassCbus4return.Visible = True

        Else
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassCbus4select_Click(sender As Object, e As EventArgs) Handles btnClassCbus4select.Click
        If rdoRoundtrip.Checked = True Then
            If dateround1 = dateround2 Then
                btnClassCbus4return.Text = "Selected"
                btnClassCbus4return.Enabled = False
            End If
            pnlClassAbuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlClassObuses.Visible = False
            Label31.Text = dateround2
            lblAvailablebusesC.Text = "Return Trip: Available buses"
            btnClassCbus1select.Visible = False
            btnClassCbus1return.Visible = True
            btnClassCbus2select.Visible = False
            btnClassCbus2return.Visible = True
            btnClassCbus3select.Visible = False
            btnClassCbus3return.Visible = True
            btnClassCbus4select.Visible = False
            btnClassCbus4return.Visible = True
        Else
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = True
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False
            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
        End If
        If nudpassengers.Value = 1 Then
            btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
            btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
            btnnextpassenger.Text = "Save and Confirm"
        End If
    End Sub
    Private Sub btnClassCback_Click(sender As Object, e As EventArgs) Handles btnClassCback.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = True
        pnlAbout.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        If rdoOneway.Checked = True Then
            pnlonewaytrip.Visible = True
            pnlroundtrip.Visible = False
        Else
            pnlonewaytrip.Visible = False
            pnlroundtrip.Visible = True
            btnClassCbus1select.Visible = True
            btnClassCbus1return.Visible = False
            btnClassCbus2select.Visible = True
            btnClassCbus2return.Visible = False
            btnClassCbus3select.Visible = True
            btnClassCbus3return.Visible = False
            btnClassCbus4select.Visible = True
            btnClassCbus4return.Visible = False
        End If
        btnClassCbus1select.Text = "Select"
        btnClassCbus1select.Enabled = True
        btnClassCbus2select.Text = "Select"
        btnClassCbus2select.Enabled = True
        btnClassCbus3select.Text = "Select"
        btnClassCbus3select.Enabled = True
        btnClassCbus4select.Text = "Select"
        btnClassCbus4select.Enabled = True
        btnClassCbus1return.Text = "Select"
        btnClassCbus1return.Enabled = True
        btnClassCbus2return.Text = "Select"
        btnClassCbus2return.Enabled = True
        btnClassCbus3return.Text = "Select"
        btnClassCbus3return.Enabled = True
        btnClassCbus4return.Text = "Select"
        btnClassCbus4return.Enabled = True
        btnMenu.Enabled = True
        btnHome.Enabled = True
        btnabout.Enabled = True
        btnabout.BackgroundImage = My.Resources.newbtnaboutwhite2
        btnabout.BackgroundImageLayout = ImageLayout.Stretch
        pnlhidemenu.Visible = False
        pnlhidehome.Visible = False
        pnlhideabout.Visible = False
    End Sub
    Private Sub btnClassCbus1return_Click(sender As Object, e As EventArgs) Handles btnClassCbus1return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassCbus2return_Click(sender As Object, e As EventArgs) Handles btnClassCbus2return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassCbus3return_Click(sender As Object, e As EventArgs) Handles btnClassCbus3return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub btnClassCbus4return_Click(sender As Object, e As EventArgs) Handles btnClassCbus4return.Click
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    'Contact Info
    Private Sub btnnextpassenger_Click(sender As Object, e As EventArgs) Handles btnnextpassenger.Click
        Dim mobnum As Single


        If txtboxfullnamecontactinfo.Text = "" Then
                MessageBox.Show("Please Enter Contact's Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtboxemailcontactinfo.Text = "" Then
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf txtboxmobilenumbercontactinfo.Text = "" Then
                MessageBox.Show("Please Enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtboxpassFname.Text = "" Then
                MessageBox.Show("Please Enter Passenger Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else

                limit = CInt(nudpassengers.Value)
                label.AutoSize = True
                Dim sline As New Panel
                With sline
                    .Size = New Size(100, 2)
                    .BackColor = Color.FromArgb(228, 228, 238)
                End With
                With label
                    .AutoSize = True
                    .ForeColor = Color.FromArgb(5, 22, 77)
                    .BackColor = Color.FromArgb(228, 228, 238)
                    .Font = New Font("Century Gothic", 12)
                    .Location = New Point(18, 130)
                    .Name = "label" + ctr.ToString
                End With
                With receiptlabel
                    .AutoSize = True
                    .ForeColor = Color.FromArgb(5, 22, 77)
                    .BackColor = Color.White
                    .Font = New Font("Century Gothic", 11)

                    .Name = "receiptlabel" + ctr.ToString
                End With
                flpPaymentbreakown.Controls.Add(sline)

                If ctr < limit Then
                    passengername(ctr) = txtboxpassFname.Text
                    age(ctr) = txtboxpassAge.Value
                    If ctr = 1 Then
                        If age(ctr) < 15 Then
                            MessageBox.Show("Please Enter an Adult First", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If
                    If cboxpassbulkpackages.Checked = True Then
                        passcheckbox = "Yes"
                        If cbobustype.SelectedIndex = 0 Then
                            'ordinary
                            bulkpackageprice = 150
                        ElseIf cbobustype.SelectedIndex = 1 Then
                            'class a
                            bulkpackageprice = 300
                        ElseIf cbobustype.SelectedIndex = 2 Then
                            'class b
                            bulkpackageprice = 250
                        ElseIf cbobustype.SelectedIndex = 3 Then
                            'class c
                            bulkpackageprice = 200
                        End If
                    ElseIf cboxpassbulkpackages.Checked = False Then
                        passcheckbox = "No"
                        bulkpackageprice = 0
                    End If
                    If checkboxinsurance.Checked = True Then
                        If cbobustype.SelectedIndex = 0 Then
                            insurance = 175
                        ElseIf cbobustype.SelectedIndex = 1 Then
                            insurance = 450
                        ElseIf cbobustype.SelectedIndex = 2 Then
                            insurance = 350
                        ElseIf cbobustype.SelectedIndex = 3 Then
                            insurance = 250
                        End If
                        insurepass = insurepass + 1
                        insu = "Yes"
                    ElseIf checkboxinsurance.Checked = False Then
                        insurance = 0
                        insu = "No"
                    End If
                    label.Text += "Passenger Name: " & passengername(ctr) & vbNewLine & "Age: " & age(ctr) & vbNewLine & "Bulk Packages: " & passcheckbox & vbNewLine & "Insurance: " & insu & vbNewLine & vbNewLine
                    receiptlabel.Text += passengername(ctr) & vbNewLine
                    flpPaymentbreakown.Controls.Add(label)
                    flpreceiptpassengers.Controls.Add(receiptlabel)
                    nudpassengers.Text = nudpassengers.Value
                    lblpassinfotxt.Text = "Passenger " & (ctr + 1).ToString & " Information"
                    lblpassengercount.Text = "Passenger " & (ctr + 1).ToString & " of " & nudpassengers.Value
                    txtboxpassFname.Text = ""
                    txtboxpassAge.Value = 1
                    cboxpassbulkpackages.Checked = False
                    checkboxinsurance.Checked = False
                    ctr = ctr + 1
                    If ctr = limit Then
                        btnnextpassenger.TextAlign = ContentAlignment.MiddleCenter
                        btnnextpassenger.BackgroundImageLayout = ImageLayout.Tile
                        btnnextpassenger.Text = "Save and Confirm"
                    End If
                    txtboxfullnamecontactinfo.Enabled = False
                    txtboxemailcontactinfo.Enabled = False
                    txtboxmobilenumbercontactinfo.Enabled = False
                Else
                    passengername(ctr) = txtboxpassFname.Text
                    age(ctr) = txtboxpassAge.Value
                    If ctr = 1 Then
                        If age(ctr) < 15 Then
                            MessageBox.Show("Please Enter an Adult First", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        If checkboxinsurance.Checked = True Then
                            If cbobustype.SelectedIndex = 0 Then
                                insurance = 175
                            ElseIf cbobustype.SelectedIndex = 1 Then
                                insurance = 450
                            ElseIf cbobustype.SelectedIndex = 2 Then
                                insurance = 350
                            ElseIf cbobustype.SelectedIndex = 3 Then
                                insurance = 250
                            End If
                            insurepass = insurepass + 1
                            insu = "Yes"
                        ElseIf checkboxinsurance.Checked = False Then
                            insurance = 0
                            insu = "No"
                        End If
                    Else
                        If checkboxinsurance.Checked = True Then
                            If cbobustype.SelectedIndex = 0 Then
                                insurance = 175
                            ElseIf cbobustype.SelectedIndex = 1 Then
                                insurance = 450
                            ElseIf cbobustype.SelectedIndex = 2 Then
                                insurance = 350
                            ElseIf cbobustype.SelectedIndex = 3 Then
                                insurance = 250
                            End If
                            insurepass = insurepass + 1
                            insu = "Yes"
                        ElseIf checkboxinsurance.Checked = False Then
                            insurance = 0
                            insu = "No"
                        End If
                    End If

                    If cboxpassbulkpackages.Checked = True Then
                        passcheckbox = "Yes"
                        If cbobustype.SelectedIndex = 0 Then
                            'ordinary
                            bulkpackageprice = 150
                        ElseIf cbobustype.SelectedIndex = 1 Then
                            'class a
                            bulkpackageprice = 300
                        ElseIf cbobustype.SelectedIndex = 2 Then
                            'class b
                            bulkpackageprice = 250
                        ElseIf cbobustype.SelectedIndex = 3 Then
                            'class c
                            bulkpackageprice = 200
                        End If
                    ElseIf cboxpassbulkpackages.Checked = False Then
                        passcheckbox = "No"
                        bulkpackageprice = 0
                    End If
                    label.Text += "Passenger Name: " & passengername(ctr) & vbNewLine & "Age: " & age(ctr) & vbNewLine & "Bulk Packages: " & passcheckbox & vbNewLine & "Insurance: " & insu & vbNewLine & vbNewLine
                    nudpassengers.Text = nudpassengers.Value
                    receiptlabel.Text += passengername(ctr) & vbNewLine
                    flpPaymentbreakown.Controls.Add(label)
                    flpreceiptpassengers.Controls.Add(receiptlabel)
                    btnContactInfonext.Enabled = True
                    pnlhidesave.Show()
                    txtboxpassFname.Enabled = False
                    txtboxpassAge.Enabled = False
                    btnnextpassenger.Enabled = False
                    cboxpassbulkpackages.Enabled = False
                    checkboxinsurance.Enabled = False
                End If
            End If



    End Sub
    Private Sub btnContactInfoback_Click(sender As Object, e As EventArgs) Handles btnContactInfoback.Click
        limit = CInt(nudpassengers.Value)
        label.Text = ""
        receiptlabel.Text = ""
        label.AutoSize = True
        btnContactInfonext.Enabled = False
        txtboxfullnamecontactinfo.Enabled = True
        txtboxemailcontactinfo.Enabled = True
        txtboxmobilenumbercontactinfo.Enabled = True
        txtboxfullnamecontactinfo.Clear()
        txtboxemailcontactinfo.Clear()
        txtboxmobilenumbercontactinfo.Clear()
        nudpassengers.Text = nudpassengers.Value
        pnlhidesave.Hide()
        ctr = 1
        lblpassengercount.Text = "Passenger " & ctr.ToString & " of " & nudpassengers.Value
        lblpassinfotxt.Text = "Passenger Information"
        txtboxpassFname.Enabled = True
        txtboxpassAge.Enabled = True
        txtboxpassFname.Text = ""
        txtboxpassAge.Value = 1
        cboxpassbulkpackages.Enabled = True
        checkboxinsurance.Enabled = True
        cboxpassbulkpackages.Checked = False
        checkboxinsurance.Checked = False
        btnnextpassenger.Visible = True
        insurepass = 0
        btnnextpassenger.Text = " Save then Proceed to Next Passenger"
        btnnextpassenger.Enabled = True
        txtboxpassFname.Enabled = True
        txtboxpassAge.Enabled = True
        lblAvailablebusesO.Text = "Departure Trip: Available buses"
        lblAvailablebusesA.Text = "Departure Trip: Available buses"
        lblAvailablebusesB.Text = "Departure Trip: Available buses"
        lblAvailablebusesC.Text = "Departure Trip: Available buses"
        If rdoOneway.Checked = True Then
            lbltimedate.Text = dateone
            lblClassAAvailablebustxt.Text = dateone
            Label29.Text = dateone
            Label31.Text = dateone
        Else
            lbltimedate.Text = dateround1
            lblClassAAvailablebustxt.Text = dateround1
            Label29.Text = dateround1
            Label31.Text = dateround1
        End If
        If dateround1 = Date.Today Then
            If cbobustype.SelectedIndex = 0 Then
                If Date.Now.Hour >= 4 Then
                    btnClassObus1select.Text = "Departed"
                    btnClassObus1select.Enabled = False
                    btnClassObus1return.Text = "Departed"
                    btnClassObus1return.Enabled = False
                    btnClassObus2select.Text = "Select"
                    btnClassObus2select.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3select.Text = "Select"
                    btnClassObus3select.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
                If Date.Now.Hour >= 10 Then
                    btnClassObus2select.Text = "Departed"
                    btnClassObus2select.Enabled = False
                    btnClassObus2return.Text = "Departed"
                    btnClassObus2return.Enabled = False
                    btnClassObus3select.Text = "Select"
                    btnClassObus3select.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4select.Text = "Select"
                    btnClassObus4select.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
            ElseIf cbobustype.SelectedIndex = 1 Then
                If Date.Now.Hour >= 4 Then
                    btnClassAbus1select.Text = "Departed"
                    btnClassAbus1select.Enabled = False
                    btnClassAbus1return.Text = "Departed"
                    btnClassAbus1return.Enabled = False
                    btnClassAbus2select.Text = "Select"
                    btnClassAbus2select.Enabled = True
                    btnClassAbus2return.Text = "Departed"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3select.Text = "Select"
                    btnClassAbus3select.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
                If Date.Now.Hour >= 10 Then
                    btnClassAbus2select.Text = "Departed"
                    btnClassAbus2select.Enabled = False
                    btnClassAbus2return.Text = "Departed"
                    btnClassAbus2return.Enabled = False
                    btnClassAbus3select.Text = "Select"
                    btnClassAbus3select.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4select.Text = "Select"
                    btnClassAbus4select.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
            ElseIf cbobustype.SelectedIndex = 2 Then
                If Date.Now.Hour >= 4 Then
                    btnClassBbus1select.Text = "Departed"
                    btnClassBbus1select.Enabled = False
                    btnClassBbus1return.Text = "Departed"
                    btnClassBbus1return.Enabled = False
                    btnClassBbus2select.Text = "Select"
                    btnClassBbus2select.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3select.Text = "Select"
                    btnClassBbus3select.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
                If Date.Now.Hour >= 10 Then
                    btnClassBbus2select.Text = "Departed"
                    btnClassBbus2select.Enabled = False
                    btnClassBbus2return.Text = "Departed"
                    btnClassBbus2return.Enabled = False
                    btnClassBbus3select.Text = "Select"
                    btnClassBbus3select.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4select.Text = "Select"
                    btnClassBbus4select.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
            ElseIf cbobustype.SelectedIndex = 3 Then
                If Date.Now.Hour >= 4 Then
                    btnClassCbus1select.Text = "Departed"
                    btnClassCbus1select.Enabled = False
                    btnClassCbus1return.Text = "Departed"
                    btnClassCbus1return.Enabled = False
                    btnClassCbus2select.Text = "Select"
                    btnClassCbus2select.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3select.Text = "Select"
                    btnClassCbus3select.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
                If Date.Now.Hour >= 10 Then
                    btnClassCbus2select.Text = "Departed"
                    btnClassCbus2select.Enabled = False
                    btnClassCbus2return.Text = "Departed"
                    btnClassCbus2return.Enabled = False
                    btnClassCbus3select.Text = "Select"
                    btnClassCbus3select.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4select.Text = "Select"
                    btnClassCbus4select.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                Else
                    btnClassObus1return.Text = "Select"
                    btnClassObus1return.Enabled = True
                    btnClassObus2return.Text = "Select"
                    btnClassObus2return.Enabled = True
                    btnClassObus3return.Text = "Select"
                    btnClassObus3return.Enabled = True
                    btnClassObus4return.Text = "Select"
                    btnClassObus4return.Enabled = True
                    btnClassAbus1return.Text = "Select"
                    btnClassAbus1return.Enabled = True
                    btnClassAbus2return.Text = "Select"
                    btnClassAbus2return.Enabled = True
                    btnClassAbus3return.Text = "Select"
                    btnClassAbus3return.Enabled = True
                    btnClassAbus4return.Text = "Select"
                    btnClassAbus4return.Enabled = True
                    btnClassBbus1return.Text = "Select"
                    btnClassBbus1return.Enabled = True
                    btnClassBbus2return.Text = "Select"
                    btnClassBbus2return.Enabled = True
                    btnClassBbus3return.Text = "Select"
                    btnClassBbus3return.Enabled = True
                    btnClassBbus4return.Text = "Select"
                    btnClassBbus4return.Enabled = True
                    btnClassCbus1return.Text = "Select"
                    btnClassCbus1return.Enabled = True
                    btnClassCbus2return.Text = "Select"
                    btnClassCbus2return.Enabled = True
                    btnClassCbus3return.Text = "Select"
                    btnClassCbus3return.Enabled = True
                    btnClassCbus4return.Text = "Select"
                    btnClassCbus4return.Enabled = True
                End If
            End If
        Else
            btnClassObus1return.Text = "Select"
            btnClassObus1return.Enabled = True
            btnClassObus2return.Text = "Select"
            btnClassObus2return.Enabled = True
            btnClassObus3return.Text = "Select"
            btnClassObus3return.Enabled = True
            btnClassObus4return.Text = "Select"
            btnClassObus4return.Enabled = True
            btnClassAbus1return.Text = "Select"
            btnClassAbus1return.Enabled = True
            btnClassAbus2return.Text = "Select"
            btnClassAbus2return.Enabled = True
            btnClassAbus3return.Text = "Select"
            btnClassAbus3return.Enabled = True
            btnClassAbus4return.Text = "Select"
            btnClassAbus4return.Enabled = True
            btnClassBbus1return.Text = "Select"
            btnClassBbus1return.Enabled = True
            btnClassBbus2return.Text = "Select"
            btnClassBbus2return.Enabled = True
            btnClassBbus3return.Text = "Select"
            btnClassBbus3return.Enabled = True
            btnClassBbus4return.Text = "Select"
            btnClassBbus4return.Enabled = True
            btnClassCbus1return.Text = "Select"
            btnClassCbus1return.Enabled = True
            btnClassCbus2return.Text = "Select"
            btnClassCbus2return.Enabled = True
            btnClassCbus3return.Text = "Select"
            btnClassCbus3return.Enabled = True
            btnClassCbus4return.Text = "Select"
            btnClassCbus4return.Enabled = True
        End If
        If cbobustype.SelectedIndex = 0 Then
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = True
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False

            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
            btnClassObus1select.Visible = True
            btnClassObus1return.Visible = False
            btnClassObus2select.Visible = True
            btnClassObus2return.Visible = False
            btnClassObus3select.Visible = True
            btnClassObus3return.Visible = False
            btnClassObus4select.Visible = True
            btnClassObus4return.Visible = False
        ElseIf cbobustype.SelectedIndex = 1 Then
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlClassAbuses.Visible = True
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False

            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
            btnClassAbus1select.Visible = True
            btnClassAbus1return.Visible = False
            btnClassAbus2select.Visible = True
            btnClassAbus2return.Visible = False
            btnClassAbus3select.Visible = True
            btnClassAbus3return.Visible = False
            btnClassAbus4select.Visible = True
            btnClassAbus4return.Visible = False
        ElseIf cbobustype.SelectedIndex = 2 Then
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = True
            pnlClassCBuses.Visible = False
            pnlContactInfo.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False

            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
            btnClassBbus1select.Visible = True
            btnClassBbus1return.Visible = False
            btnClassBbus2select.Visible = True
            btnClassBbus2return.Visible = False
            btnClassBbus3select.Visible = True
            btnClassBbus3return.Visible = False
            btnClassBbus4select.Visible = True
            btnClassBbus4return.Visible = False
        ElseIf cbobustype.SelectedIndex = 3 Then
            pnlpayment.Visible = False
            pnlreceipt.Visible = False
            pnlClassAbuses.Visible = False
            pnlClassObuses.Visible = False
            pnlClassBbuses.Visible = False
            pnlClassCBuses.Visible = True
            pnlContactInfo.Visible = False
            pnlWelcome.Visible = False
            pnlBookatrip.Visible = False
            pnlAbout.Visible = False

            pnlAddServicesInfo.Visible = False
            pnlCustomerService.Visible = False
            pnlPasengersrights.Visible = False
            btnClassCbus1select.Visible = True
            btnClassCbus1return.Visible = False
            btnClassCbus2select.Visible = True
            btnClassCbus2return.Visible = False
            btnClassCbus3select.Visible = True
            btnClassCbus3return.Visible = False
            btnClassCbus4select.Visible = True
            btnClassCbus4return.Visible = False
        End If
    End Sub
    Private Sub btnContactInfonext_Click(sender As Object, e As EventArgs) Handles btnContactInfonext.Click
        pnlpayment.Visible = True
        pnlreceipt.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlClassObuses.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False

        If rdoRoundtrip.Checked = True Then
            price = price * 2
        End If

        ctr = 1
        While ctr <= limit
            discountedprice = 0
            srdiscount = 0
            groupdisc = 0


            If age(ctr) <= 10 Then
                discount = Val(price) * 0.05
                kidprice = Val(price) - Val(discount)
                kdiscount += discount
                vatableamount = Val(bulkpackageprice) + Val(insurance) + Val(kidprice)
            Else
                vatableamount = Val(bulkpackageprice) + Val(insurance) + Val(price)
            End If


            If age(ctr) >= 60 Then
                VAT = 0
                VATprice = Val(vatableamount)
                srdiscount = Val(VATprice) * 0.2
                srtotal += srdiscount
                totalfare2(ctr) = Val(VATprice) - Val(srdiscount)
            Else
                VAT = 0.12
                vatpercent = Val(vatableamount) * Val(VAT)
                VATprice = Val(vatableamount) + Val(vatpercent)
                totalfare2(ctr) = Val(VATprice)
                allvatprice += vatpercent
            End If
            totalbookpayment = Val(totalbookpayment) + Val(totalfare2(ctr))
            finaltotalbp = totalbookpayment


            ctr += 1
        End While
        If nudpassengers.Value >= 5 Then
            groupdisc = finaltotalbp * 0.05
            finaltotalbp -= groupdisc
        End If
        allinsurance = insurance * insurepass
        recinsurance.Text = "Php " & allinsurance
        allbulkpackage = bulkpackageprice * bulkpass
        busfare = price * limit
        recbusfare.Text = "Php " & busfare
        recaddcharge.Text = "Php " & Val(allbulkpackage)
        recdiscount.Text = "Php " & kdiscount
        recsrdiscount.Text = "Php " & srtotal
        recgrpdicount.Text = "Php " & groupdisc
        recvat.Text = "Php " & allvatprice
        rectotal.Text = "Php " & finaltotalbp

        lblpaymenttotal.Text = "Php " & finaltotalbp

    End Sub
    'Payment
    Private Sub btnpaymentback_Click(sender As Object, e As EventArgs) Handles btnpaymentback.Click
        ctr = 1
        label.Text = ""
        receiptlabel.Text = ""
        pnlhidesave.Hide()
        btnContactInfonext.Enabled = False
        txtboxfullnamecontactinfo.Enabled = True
        txtboxemailcontactinfo.Enabled = True
        txtboxmobilenumbercontactinfo.Enabled = True
        txtboxfullnamecontactinfo.Clear()
        txtboxemailcontactinfo.Clear()
        txtboxmobilenumbercontactinfo.Clear()
        nudpassengers.Text = nudpassengers.Value
        lblpassengercount.Text = "Passenger " & ctr.ToString & " of " & nudpassengers.Value
        lblpassinfotxt.Text = "Passenger Information"
        txtboxpassFname.Enabled = True
        txtboxpassAge.Enabled = True
        txtboxpassFname.Text = ""
        txtboxpassAge.Value = 1
        cboxpassbulkpackages.Enabled = True
        checkboxinsurance.Enabled = True
        cboxpassbulkpackages.Checked = False
        checkboxinsurance.Checked = False
        btnnextpassenger.Enabled = True
        btnnextpassenger.Text = " Save then Proceed to Next Passenger"
        If nudpassengers.Value = 1 Then
            btnnextpassenger.Text = " Save and Confirm"
        End If
        discount = 0
        discountedprice = 0
        vatableamount = 0
        VATprice = 0
        srdiscount = 0
        totalfare2(ctr) = 0
        vatpercent = 0
        totalbookpayment = 0
        groupdisc = 0
        totalbookpayment = 0
        btnnextpassenger.Visible = True
        change = 0
        txtboxpaycashamount.Text = ""
        txtboxpaycashchange.Text = ""
        insurepass = 0
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = True
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            payment = CSng(txtboxpaycashamount.Text)

            change = Val(payment) - finaltotalbp


            If txtboxpaycashamount.Text >= finaltotalbp Then
                txtboxpaycashchange.Text = Format(change, "###,##0.00")
                txtboxpaycashchange.Text = change
                btnpaymentnext.Enabled = True
            Else
                MessageBox.Show("Insufficient Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                change = 0
                txtboxpaycashamount.Clear()
                Exit Sub
            End If
            txtboxpaycashchange.Text = change

        Catch Ex As Exception
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtboxpaycashamount.Clear()
        End Try

    End Sub
    Private Sub btnpaymentnext_Click(sender As Object, e As EventArgs) Handles btnpaymentnext.Click
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        pnlreceipt.Visible = True

        recchange.Text = "Php " & change
        recpayment.Text = "Php " & payment


    End Sub
    'reciept
    Private Sub recback_Click(sender As Object, e As EventArgs)
        pnlpayment.Visible = True
        pnlreceipt.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlClassObuses.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        txtboxpaycashamount.Text = ""
        txtboxpaycashchange.Text = ""
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim pnlprint As New Bitmap(pnlreceiptprintcontainerall.Width, pnlreceiptprintcontainerall.Height)
        pnlreceiptprintcontainerall.DrawToBitmap(pnlprint, pnlreceiptprintcontainerall.ClientRectangle)
        e.Graphics.DrawImage(pnlprint, 0, 0, e.PageBounds.Width, e.PageBounds.Height)

    End Sub
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub btnbookagain_Click(sender As Object, e As EventArgs) Handles btnbookagain.Click
        Application.Restart()
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim exitbtn As DialogResult
        exitbtn = MessageBox.Show("Do you wish to leave?", "Merc Bus Online Ticketing Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitbtn = DialogResult.Yes Then
            Close()
        ElseIf exitbtn = DialogResult.No Then

        End If
    End Sub
    'end
    Private Sub btnBookingInfo_Click(sender As Object, e As EventArgs)
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        btnAdditionalServiceInfo.ForeColor = Color.FromArgb(244, 245, 250)
        btnPassengerrightsmenu.ForeColor = Color.FromArgb(244, 245, 250)
        btnCustomerServicemenu.ForeColor = Color.FromArgb(244, 245, 250)
    End Sub
    Private Sub btnAdditionalServiceInfo_Click(sender As Object, e As EventArgs) Handles btnAdditionalServiceInfo.Click
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlAddServicesInfo.Visible = True
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = False
        btnAdditionalServiceInfo.ForeColor = Color.Orange
        btnPassengerrightsmenu.ForeColor = Color.FromArgb(244, 245, 250)
        btnCustomerServicemenu.ForeColor = Color.FromArgb(244, 245, 250)

    End Sub
    Private Sub btnPassengerrightsmenu_Click(sender As Object, e As EventArgs) Handles btnPassengerrightsmenu.Click
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False
        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = False
        pnlPasengersrights.Visible = True
        btnPassengerrightsmenu.ForeColor = Color.Orange
        btnAdditionalServiceInfo.ForeColor = Color.FromArgb(244, 245, 250)
        btnCustomerServicemenu.ForeColor = Color.FromArgb(244, 245, 250)
    End Sub
    Private Sub btnCustomerServicemenu_Click(sender As Object, e As EventArgs) Handles btnCustomerServicemenu.Click
        pnlWelcome.Visible = False
        pnlBookatrip.Visible = False
        pnlAbout.Visible = False
        pnlonewaytrip.Visible = False
        pnlroundtrip.Visible = False
        pnlClassObuses.Visible = False
        pnlClassBbuses.Visible = False
        pnlClassAbuses.Visible = False
        pnlClassCBuses.Visible = False
        pnlContactInfo.Visible = False
        pnlpayment.Visible = False
        pnlreceipt.Visible = False

        pnlAddServicesInfo.Visible = False
        pnlCustomerService.Visible = True
        pnlPasengersrights.Visible = False
        btnCustomerServicemenu.ForeColor = Color.Orange
        btnAdditionalServiceInfo.ForeColor = Color.FromArgb(244, 245, 250)
        btnPassengerrightsmenu.ForeColor = Color.FromArgb(244, 245, 250)
    End Sub
End Class