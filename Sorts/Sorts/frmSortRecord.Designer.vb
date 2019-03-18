<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortRecord
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
        Me.btnLoadRecords = New System.Windows.Forms.Button()
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.btnSortName = New System.Windows.Forms.Button()
        Me.btnSortSurname = New System.Windows.Forms.Button()
        Me.lstSortedRecords = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnLoadRecords
        '
        Me.btnLoadRecords.Location = New System.Drawing.Point(26, 23)
        Me.btnLoadRecords.Name = "btnLoadRecords"
        Me.btnLoadRecords.Size = New System.Drawing.Size(119, 23)
        Me.btnLoadRecords.TabIndex = 0
        Me.btnLoadRecords.Text = "Load records"
        Me.btnLoadRecords.UseVisualStyleBackColor = True
        '
        'lstRecords
        '
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.Location = New System.Drawing.Point(26, 52)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(388, 186)
        Me.lstRecords.TabIndex = 1
        '
        'btnSortName
        '
        Me.btnSortName.Location = New System.Drawing.Point(433, 23)
        Me.btnSortName.Name = "btnSortName"
        Me.btnSortName.Size = New System.Drawing.Size(118, 23)
        Me.btnSortName.TabIndex = 2
        Me.btnSortName.Text = "Sort by Given Name"
        Me.btnSortName.UseVisualStyleBackColor = True
        '
        'btnSortSurname
        '
        Me.btnSortSurname.Location = New System.Drawing.Point(568, 23)
        Me.btnSortSurname.Name = "btnSortSurname"
        Me.btnSortSurname.Size = New System.Drawing.Size(118, 23)
        Me.btnSortSurname.TabIndex = 3
        Me.btnSortSurname.Text = "Sort by Surname"
        Me.btnSortSurname.UseVisualStyleBackColor = True
        '
        'lstSortedRecords
        '
        Me.lstSortedRecords.FormattingEnabled = True
        Me.lstSortedRecords.Location = New System.Drawing.Point(433, 52)
        Me.lstSortedRecords.Name = "lstSortedRecords"
        Me.lstSortedRecords.Size = New System.Drawing.Size(388, 186)
        Me.lstSortedRecords.TabIndex = 4
        '
        'frmSortRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 366)
        Me.Controls.Add(Me.lstSortedRecords)
        Me.Controls.Add(Me.btnSortSurname)
        Me.Controls.Add(Me.btnSortName)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.btnLoadRecords)
        Me.Name = "frmSortRecord"
        Me.Text = "frmSortRecord"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoadRecords As System.Windows.Forms.Button
    Friend WithEvents lstRecords As System.Windows.Forms.ListBox
    Friend WithEvents btnSortName As System.Windows.Forms.Button
    Friend WithEvents btnSortSurname As System.Windows.Forms.Button
    Friend WithEvents lstSortedRecords As System.Windows.Forms.ListBox
End Class
