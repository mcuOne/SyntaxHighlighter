<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.UserControl

    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MyPictureBox = New System.Windows.Forms.PictureBox()
        Me.m_syntaxRichTextBox = New SyntaxHighlighter.SyntaxRichTextBox()
        CType(Me.MyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyPictureBox
        '
        Me.MyPictureBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MyPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.MyPictureBox.Name = "MyPictureBox"
        Me.MyPictureBox.Size = New System.Drawing.Size(63, 547)
        Me.MyPictureBox.TabIndex = 4
        Me.MyPictureBox.TabStop = False
        '
        'm_syntaxRichTextBox
        '
        Me.m_syntaxRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.m_syntaxRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.m_syntaxRichTextBox.Location = New System.Drawing.Point(67, 2)
        Me.m_syntaxRichTextBox.Name = "m_syntaxRichTextBox"
        Me.m_syntaxRichTextBox.Size = New System.Drawing.Size(705, 545)
        Me.m_syntaxRichTextBox.TabIndex = 0
        Me.m_syntaxRichTextBox.Text = ""
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.MyPictureBox)
        Me.Controls.Add(Me.m_syntaxRichTextBox)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(775, 547)
        CType(Me.MyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents m_syntaxRichTextBox As SyntaxHighlighter.SyntaxRichTextBox
    Friend WithEvents MyPictureBox As PictureBox
End Class
