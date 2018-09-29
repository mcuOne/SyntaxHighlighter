Public Class TextBoxHighlighter
    Private Sub DrawRichTextBoxLineNumbers(ByRef g As Graphics)
        'calculate font heigth as the difference in Y coordinate between line 2 and line 1
        'note that the RichTextBox text must have at least two lines. So the initial Text property of the RichTextBox should not be an empty string. It could be something like vbcrlf & vbcrlf & vbcrlf 
        Dim font_height As Single = m_syntaxRichTextBox.GetPositionFromCharIndex(m_syntaxRichTextBox.GetFirstCharIndexFromLine(2)).Y - m_syntaxRichTextBox.GetPositionFromCharIndex(m_syntaxRichTextBox.GetFirstCharIndexFromLine(1)).Y
        If font_height = 0 Then Exit Sub

        'Get the first line index and location
        Dim firstIndex As Integer = m_syntaxRichTextBox.GetCharIndexFromPosition(New Point(0, g.VisibleClipBounds.Y + font_height / 3))
        Dim firstLine As Integer = m_syntaxRichTextBox.GetLineFromCharIndex(firstIndex)
        Dim firstLineY As Integer = m_syntaxRichTextBox.GetPositionFromCharIndex(firstIndex).Y

        'Print on the PictureBox the visible line numbers of the RichTextBox
        g.Clear(Color.FromArgb(30, 30, 30))
        Dim ir As Font = New Drawing.Font("Consolas",
                               m_syntaxRichTextBox.Font.Size,
                               FontStyle.Regular)
        Dim i As Integer = firstLine
        Dim y As Single
        Do While y < g.VisibleClipBounds.Y + g.VisibleClipBounds.Height
            y = firstLineY + 2 + font_height * (i - firstLine - 1)
            Dim brushy As Brush
            brushy = New Drawing.SolidBrush(Color.FromArgb(86, 156, 214))
            g.DrawString((i).ToString, ir, brushy, MyPictureBox.Width - g.MeasureString((i).ToString, ir).Width, y)

            i += 1
        Loop

        'Debug.WriteLine("Finished: " & firstLine + 1 & " " & i - 1)
    End Sub

    Private Sub r_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_syntaxRichTextBox.Resize
        MyPictureBox.Invalidate()
    End Sub

    Private Sub r_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_syntaxRichTextBox.VScroll
        MyPictureBox.Invalidate()
    End Sub

    Private Sub p_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyPictureBox.Paint
        DrawRichTextBoxLineNumbers(e.Graphics)
    End Sub

    Public Sub AddKeyword(ByVal key As String)
        m_syntaxRichTextBox.Settings.Keywords.Add(key)
    End Sub
    Public Sub Comment(ByVal str As String)
        m_syntaxRichTextBox.Settings.Comment = str
    End Sub

    Public Sub KeywordColor(ByVal col As Color)
        m_syntaxRichTextBox.Settings.KeywordColor = col
    End Sub
    Public Sub CommentColor(ByVal col As Color)
        m_syntaxRichTextBox.Settings.CommentColor = col
    End Sub
    Public Sub StringColor(ByVal col As Color)
        m_syntaxRichTextBox.Settings.StringColor = col
    End Sub
    Public Sub IntegerColor(ByVal col As Color)
        m_syntaxRichTextBox.Settings.IntegerColor = col
    End Sub
    Public Sub EnableStrings(ByVal bool As Boolean)
        m_syntaxRichTextBox.Settings.EnableStrings = bool
    End Sub

    Public Sub EnableIntegers(ByVal bool As Boolean)
        m_syntaxRichTextBox.Settings.EnableIntegers = bool
    End Sub
    Public Sub CompileKeywords()
        m_syntaxRichTextBox.CompileKeywords()
        m_syntaxRichTextBox.Text = vbCrLf & vbCrLf & vbCrLf
        m_syntaxRichTextBox.SelectAll()
        m_syntaxRichTextBox.ScrollToCaret()
    End Sub
    Public Sub ProcessAllLines()
        m_syntaxRichTextBox.ProcessAllLines()
    End Sub
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        m_syntaxRichTextBox.ForeColor = Color.FromArgb(216, 220, 220)
    End Sub
End Class
