<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarRental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CustomerNameLabel = New Label()
        AddressLabel = New Label()
        CityLabel = New Label()
        StateLabel = New Label()
        ZipCodeLabel = New Label()
        BeginningOMLabel = New Label()
        EndingOMLabel = New Label()
        DaysLabel = New Label()
        CustomerNameTextBox = New TextBox()
        AddressTextBox = New TextBox()
        CityTextBox = New TextBox()
        StateTextBox = New TextBox()
        ZipCodeTextBox = New TextBox()
        BeginningOMTextBox = New TextBox()
        EndingOMTextBox = New TextBox()
        OfDaysTextBox = New TextBox()
        KmOrMiGroupBox = New GroupBox()
        KilometersRadioButton = New RadioButton()
        MilesRadioButton = New RadioButton()
        DiscountGroupBox = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        CalculateButton = New Button()
        ClearButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TotalDistanceLabel = New Label()
        MileageChargeLabel = New Label()
        DayChargeLabel = New Label()
        DiscountLabel = New Label()
        TotalOwedLabel = New Label()
        KmOrMiGroupBox.SuspendLayout()
        DiscountGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New Point(12, 24)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(141, 25)
        CustomerNameLabel.TabIndex = 0
        CustomerNameLabel.Text = "Customer Name"
        ' 
        ' AddressLabel
        ' 
        AddressLabel.AutoSize = True
        AddressLabel.Location = New Point(12, 94)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New Size(77, 25)
        AddressLabel.TabIndex = 1
        AddressLabel.Text = "Address"
        ' 
        ' CityLabel
        ' 
        CityLabel.AutoSize = True
        CityLabel.Location = New Point(12, 163)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New Size(42, 25)
        CityLabel.TabIndex = 2
        CityLabel.Text = "City"
        ' 
        ' StateLabel
        ' 
        StateLabel.AutoSize = True
        StateLabel.Location = New Point(12, 226)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New Size(51, 25)
        StateLabel.TabIndex = 3
        StateLabel.Text = "State"
        ' 
        ' ZipCodeLabel
        ' 
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New Point(12, 289)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New Size(84, 25)
        ZipCodeLabel.TabIndex = 4
        ZipCodeLabel.Text = "Zip Code"
        ' 
        ' BeginningOMLabel
        ' 
        BeginningOMLabel.AutoSize = True
        BeginningOMLabel.Location = New Point(12, 351)
        BeginningOMLabel.Name = "BeginningOMLabel"
        BeginningOMLabel.Size = New Size(247, 25)
        BeginningOMLabel.TabIndex = 5
        BeginningOMLabel.Text = "Beginning Odometer Reading"
        ' 
        ' EndingOMLabel
        ' 
        EndingOMLabel.AutoSize = True
        EndingOMLabel.Location = New Point(12, 422)
        EndingOMLabel.Name = "EndingOMLabel"
        EndingOMLabel.Size = New Size(223, 25)
        EndingOMLabel.TabIndex = 6
        EndingOMLabel.Text = "Ending Odometer Reading"
        ' 
        ' DaysLabel
        ' 
        DaysLabel.AutoSize = True
        DaysLabel.Location = New Point(12, 488)
        DaysLabel.Name = "DaysLabel"
        DaysLabel.Size = New Size(143, 25)
        DaysLabel.TabIndex = 7
        DaysLabel.Text = "Number of Days"
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(309, 18)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(154, 31)
        CustomerNameTextBox.TabIndex = 8
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(309, 88)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(154, 31)
        AddressTextBox.TabIndex = 9
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(309, 163)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(154, 31)
        CityTextBox.TabIndex = 10
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(309, 220)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(154, 31)
        StateTextBox.TabIndex = 11
        ' 
        ' ZipCodeTextBox
        ' 
        ZipCodeTextBox.Location = New Point(309, 283)
        ZipCodeTextBox.Name = "ZipCodeTextBox"
        ZipCodeTextBox.Size = New Size(154, 31)
        ZipCodeTextBox.TabIndex = 12
        ' 
        ' BeginningOMTextBox
        ' 
        BeginningOMTextBox.Location = New Point(309, 351)
        BeginningOMTextBox.Name = "BeginningOMTextBox"
        BeginningOMTextBox.Size = New Size(154, 31)
        BeginningOMTextBox.TabIndex = 13
        ' 
        ' EndingOMTextBox
        ' 
        EndingOMTextBox.Location = New Point(309, 422)
        EndingOMTextBox.Name = "EndingOMTextBox"
        EndingOMTextBox.Size = New Size(154, 31)
        EndingOMTextBox.TabIndex = 14
        ' 
        ' OfDaysTextBox
        ' 
        OfDaysTextBox.Location = New Point(309, 488)
        OfDaysTextBox.Name = "OfDaysTextBox"
        OfDaysTextBox.Size = New Size(154, 31)
        OfDaysTextBox.TabIndex = 15
        ' 
        ' KmOrMiGroupBox
        ' 
        KmOrMiGroupBox.Controls.Add(KilometersRadioButton)
        KmOrMiGroupBox.Controls.Add(MilesRadioButton)
        KmOrMiGroupBox.Location = New Point(55, 576)
        KmOrMiGroupBox.Name = "KmOrMiGroupBox"
        KmOrMiGroupBox.Size = New Size(479, 152)
        KmOrMiGroupBox.TabIndex = 16
        KmOrMiGroupBox.TabStop = False
        KmOrMiGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        ' 
        ' KilometersRadioButton
        ' 
        KilometersRadioButton.AutoSize = True
        KilometersRadioButton.Location = New Point(39, 83)
        KilometersRadioButton.Name = "KilometersRadioButton"
        KilometersRadioButton.Size = New Size(146, 29)
        KilometersRadioButton.TabIndex = 1
        KilometersRadioButton.TabStop = True
        KilometersRadioButton.Text = "RadioButton2"
        KilometersRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MilesRadioButton
        ' 
        MilesRadioButton.AutoSize = True
        MilesRadioButton.Location = New Point(39, 30)
        MilesRadioButton.Name = "MilesRadioButton"
        MilesRadioButton.Size = New Size(78, 29)
        MilesRadioButton.TabIndex = 0
        MilesRadioButton.TabStop = True
        MilesRadioButton.Text = "Miles"
        MilesRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DiscountGroupBox
        ' 
        DiscountGroupBox.Controls.Add(CheckBox2)
        DiscountGroupBox.Controls.Add(CheckBox1)
        DiscountGroupBox.Location = New Point(740, 580)
        DiscountGroupBox.Name = "DiscountGroupBox"
        DiscountGroupBox.Size = New Size(592, 193)
        DiscountGroupBox.TabIndex = 17
        DiscountGroupBox.TabStop = False
        DiscountGroupBox.Text = "Enter Any discounts"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(52, 119)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(124, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(52, 44)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(124, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(176, 791)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(149, 87)
        CalculateButton.TabIndex = 18
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(485, 791)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(149, 87)
        ClearButton.TabIndex = 19
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(753, 791)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(149, 87)
        SummaryButton.TabIndex = 20
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(994, 791)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(149, 87)
        ExitButton.TabIndex = 21
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1080, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(371, 31)
        TextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1080, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(371, 31)
        TextBox2.TabIndex = 23
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1080, 226)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(371, 31)
        TextBox3.TabIndex = 24
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1080, 316)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(371, 31)
        TextBox4.TabIndex = 25
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(1080, 379)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(371, 31)
        TextBox5.TabIndex = 26
        ' 
        ' TotalDistanceLabel
        ' 
        TotalDistanceLabel.AutoSize = True
        TotalDistanceLabel.Location = New Point(843, 71)
        TotalDistanceLabel.Name = "TotalDistanceLabel"
        TotalDistanceLabel.Size = New Size(200, 25)
        TotalDistanceLabel.TabIndex = 27
        TotalDistanceLabel.Text = "Distance Driven in Miles"
        ' 
        ' MileageChargeLabel
        ' 
        MileageChargeLabel.AutoSize = True
        MileageChargeLabel.Location = New Point(843, 140)
        MileageChargeLabel.Name = "MileageChargeLabel"
        MileageChargeLabel.Size = New Size(135, 25)
        MileageChargeLabel.TabIndex = 28
        MileageChargeLabel.Text = "Mileage Charge"
        ' 
        ' DayChargeLabel
        ' 
        DayChargeLabel.AutoSize = True
        DayChargeLabel.Location = New Point(843, 229)
        DayChargeLabel.Name = "DayChargeLabel"
        DayChargeLabel.Size = New Size(104, 25)
        DayChargeLabel.TabIndex = 29
        DayChargeLabel.Text = "Day Charge"
        ' 
        ' DiscountLabel
        ' 
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New Point(843, 316)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New Size(135, 25)
        DiscountLabel.TabIndex = 30
        DiscountLabel.Text = "Minus Discount"
        ' 
        ' TotalOwedLabel
        ' 
        TotalOwedLabel.AutoSize = True
        TotalOwedLabel.Location = New Point(843, 382)
        TotalOwedLabel.Name = "TotalOwedLabel"
        TotalOwedLabel.Size = New Size(82, 25)
        TotalOwedLabel.TabIndex = 31
        TotalOwedLabel.Text = "You Owe"
        ' 
        ' CarRental
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1543, 989)
        Controls.Add(TotalOwedLabel)
        Controls.Add(DiscountLabel)
        Controls.Add(DayChargeLabel)
        Controls.Add(MileageChargeLabel)
        Controls.Add(TotalDistanceLabel)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ExitButton)
        Controls.Add(SummaryButton)
        Controls.Add(ClearButton)
        Controls.Add(CalculateButton)
        Controls.Add(DiscountGroupBox)
        Controls.Add(KmOrMiGroupBox)
        Controls.Add(OfDaysTextBox)
        Controls.Add(EndingOMTextBox)
        Controls.Add(BeginningOMTextBox)
        Controls.Add(ZipCodeTextBox)
        Controls.Add(StateTextBox)
        Controls.Add(CityTextBox)
        Controls.Add(AddressTextBox)
        Controls.Add(CustomerNameTextBox)
        Controls.Add(DaysLabel)
        Controls.Add(EndingOMLabel)
        Controls.Add(BeginningOMLabel)
        Controls.Add(ZipCodeLabel)
        Controls.Add(StateLabel)
        Controls.Add(CityLabel)
        Controls.Add(AddressLabel)
        Controls.Add(CustomerNameLabel)
        Name = "CarRental"
        Text = "Form1"
        KmOrMiGroupBox.ResumeLayout(False)
        KmOrMiGroupBox.PerformLayout()
        DiscountGroupBox.ResumeLayout(False)
        DiscountGroupBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BeginningOMLabel As Label
    Friend WithEvents EndingOMLabel As Label
    Friend WithEvents DaysLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BeginningOMTextBox As TextBox
    Friend WithEvents EndingOMTextBox As TextBox
    Friend WithEvents OfDaysTextBox As TextBox
    Friend WithEvents KmOrMiGroupBox As GroupBox
    Friend WithEvents DiscountGroupBox As GroupBox
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TotalDistanceLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents TotalOwedLabel As Label

End Class
