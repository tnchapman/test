<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortArray
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItem1 = New System.Windows.Forms.TextBox()
        Me.txtItem2 = New System.Windows.Forms.TextBox()
        Me.txtItem3 = New System.Windows.Forms.TextBox()
        Me.txtItem4 = New System.Windows.Forms.TextBox()
        Me.txtItem5 = New System.Windows.Forms.TextBox()
        Me.btnCreateArray = New System.Windows.Forms.Button()
        Me.lstDisplayArray = New System.Windows.Forms.ListBox()
        Me.lstDisplaySort = New System.Windows.Forms.ListBox()
        Me.btnBubbleSort = New System.Windows.Forms.Button()
        Me.btnSelectionSort = New System.Windows.Forms.Button()
        Me.btnInsertionSort = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOpenSortRecords = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type a word or number into each of the boxes below then click Create Array."
        '
        'txtItem1
        '
        Me.txtItem1.Location = New System.Drawing.Point(25, 46)
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.Size = New System.Drawing.Size(100, 20)
        Me.txtItem1.TabIndex = 1
        Me.txtItem1.Text = "txtItem1"
        '
        'txtItem2
        '
        Me.txtItem2.Location = New System.Drawing.Point(131, 46)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(100, 20)
        Me.txtItem2.TabIndex = 2
        Me.txtItem2.Text = "txtItem2"
        '
        'txtItem3
        '
        Me.txtItem3.Location = New System.Drawing.Point(237, 46)
        Me.txtItem3.Name = "txtItem3"
        Me.txtItem3.Size = New System.Drawing.Size(100, 20)
        Me.txtItem3.TabIndex = 3
        Me.txtItem3.Text = "txtItem3"
        '
        'txtItem4
        '
        Me.txtItem4.Location = New System.Drawing.Point(343, 46)
        Me.txtItem4.Name = "txtItem4"
        Me.txtItem4.Size = New System.Drawing.Size(100, 20)
        Me.txtItem4.TabIndex = 4
        Me.txtItem4.Text = "txtItem4"
        '
        'txtItem5
        '
        Me.txtItem5.Location = New System.Drawing.Point(449, 46)
        Me.txtItem5.Name = "txtItem5"
        Me.txtItem5.Size = New System.Drawing.Size(100, 20)
        Me.txtItem5.TabIndex = 5
        Me.txtItem5.Text = "txtItem5"
        '
        'btnCreateArray
        '
        Me.btnCreateArray.Location = New System.Drawing.Point(25, 82)
        Me.btnCreateArray.Name = "btnCreateArray"
        Me.btnCreateArray.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateArray.TabIndex = 6
        Me.btnCreateArray.Text = "Create Array"
        Me.btnCreateArray.UseVisualStyleBackColor = True
        '
        'lstDisplayArray
        '
        Me.lstDisplayArray.FormattingEnabled = True
        Me.lstDisplayArray.Location = New System.Drawing.Point(111, 82)
        Me.lstDisplayArray.Name = "lstDisplayArray"
        Me.lstDisplayArray.Size = New System.Drawing.Size(120, 160)
        Me.lstDisplayArray.TabIndex = 8
        '
        'lstDisplaySort
        '
        Me.lstDisplaySort.FormattingEnabled = True
        Me.lstDisplaySort.Location = New System.Drawing.Point(396, 82)
        Me.lstDisplaySort.Name = "lstDisplaySort"
        Me.lstDisplaySort.Size = New System.Drawing.Size(120, 160)
        Me.lstDisplaySort.TabIndex = 9
        '
        'btnBubbleSort
        '
        Me.btnBubbleSort.Location = New System.Drawing.Point(312, 82)
        Me.btnBubbleSort.Name = "btnBubbleSort"
        Me.btnBubbleSort.Size = New System.Drawing.Size(75, 23)
        Me.btnBubbleSort.TabIndex = 10
        Me.btnBubbleSort.Text = "Bubble"
        Me.btnBubbleSort.UseVisualStyleBackColor = True
        '
        'btnSelectionSort
        '
        Me.btnSelectionSort.Location = New System.Drawing.Point(315, 111)
        Me.btnSelectionSort.Name = "btnSelectionSort"
        Me.btnSelectionSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectionSort.TabIndex = 11
        Me.btnSelectionSort.Text = "Selection Sort"
        Me.btnSelectionSort.UseVisualStyleBackColor = True
        '
        'btnInsertionSort
        '
        Me.btnInsertionSort.Location = New System.Drawing.Point(315, 140)
        Me.btnInsertionSort.Name = "btnInsertionSort"
        Me.btnInsertionSort.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertionSort.TabIndex = 12
        Me.btnInsertionSort.Text = "Insertion Sort"
        Me.btnInsertionSort.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOpenSortRecords
        '
        Me.btnOpenSortRecords.Location = New System.Drawing.Point(202, 307)
        Me.btnOpenSortRecords.Name = "btnOpenSortRecords"
        Me.btnOpenSortRecords.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenSortRecords.TabIndex = 14
        Me.btnOpenSortRecords.Text = "Sort records"
        Me.btnOpenSortRecords.UseVisualStyleBackColor = True
        '
        'frmSortArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.btnOpenSortRecords)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInsertionSort)
        Me.Controls.Add(Me.btnSelectionSort)
        Me.Controls.Add(Me.btnBubbleSort)
        Me.Controls.Add(Me.lstDisplaySort)
        Me.Controls.Add(Me.lstDisplayArray)
        Me.Controls.Add(Me.btnCreateArray)
        Me.Controls.Add(Me.txtItem5)
        Me.Controls.Add(Me.txtItem4)
        Me.Controls.Add(Me.txtItem3)
        Me.Controls.Add(Me.txtItem2)
        Me.Controls.Add(Me.txtItem1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSortArray"
        Me.Text = "Sort Algorithms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItem1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem4 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem5 As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateArray As System.Windows.Forms.Button
    Friend WithEvents lstDisplayArray As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplaySort As System.Windows.Forms.ListBox
    Friend WithEvents btnBubbleSort As System.Windows.Forms.Button
    Friend WithEvents btnSelectionSort As System.Windows.Forms.Button
    Friend WithEvents btnInsertionSort As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnOpenSortRecords As System.Windows.Forms.Button

End Class
