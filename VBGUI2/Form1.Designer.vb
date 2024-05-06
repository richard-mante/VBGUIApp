<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        head1 = New Label()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        nameLabel = New Label()
        studentNameField = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' head1
        ' 
        head1.AutoSize = True
        head1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        head1.Location = New Point(109, 55)
        head1.Name = "head1"
        head1.RightToLeft = RightToLeft.Yes
        head1.Size = New Size(862, 37)
        head1.TabIndex = 1
        head1.Text = "KOFORIDUA TECHNICAL UNIVERSITY STUDENT GRADING SYSTEM"
        head1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(371, 110)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(342, 35)
        Label1.TabIndex = 2
        Label1.Text = "STUDENT GRADING SYSTEM"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(79, 265)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 15)
        LinkLabel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(15, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 42)
        Button1.TabIndex = 0
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(studentNameField)
        GroupBox1.Controls.Add(nameLabel)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ImeMode = ImeMode.Off
        GroupBox1.Location = New Point(94, 177)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(877, 285)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Bio Data"
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(15, 88)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(122, 21)
        nameLabel.TabIndex = 1
        nameLabel.Text = "Student Name"
        ' 
        ' studentNameField
        ' 
        studentNameField.Location = New Point(143, 85)
        studentNameField.Name = "studentNameField"
        studentNameField.Size = New Size(220, 29)
        studentNameField.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1039, 643)
        Controls.Add(GroupBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label1)
        Controls.Add(head1)
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents head1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents studentNameField As TextBox

End Class
