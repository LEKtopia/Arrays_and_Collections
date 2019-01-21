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
        Me.lstCollections = New System.Windows.Forms.ListBox()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCollections
        '
        Me.lstCollections.FormattingEnabled = True
        Me.lstCollections.Location = New System.Drawing.Point(12, 8)
        Me.lstCollections.Name = "lstCollections"
        Me.lstCollections.Size = New System.Drawing.Size(230, 225)
        Me.lstCollections.TabIndex = 0
        '
        'btnDemo
        '
        Me.btnDemo.Location = New System.Drawing.Point(86, 239)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo.TabIndex = 1
        Me.btnDemo.Text = "Go Go Demo"
        Me.btnDemo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 293)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.lstCollections)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCollections As ListBox
    Friend WithEvents btnDemo As Button
End Class
