Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Data
Imports Microsoft.Office.Interop
Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class MealSearchMainForm
    Dim FullReportLoaded As Boolean = False
    Dim UserNmeList As New List(Of String)()
    Dim ListOfAllAccounts As New List(Of Account)()
    Dim listOfAccountsSerchData As New List(Of Account)
    Dim File1 As String = ""
    Dim File1Loc As String = ""
    Dim ListFromLeftColum As New List(Of Integer)
    Dim ListColumWidth As New List(Of Integer)
    Dim CountCellHeight As Integer
    Dim Counter As Integer
    Dim isFirstPage As Boolean
    Dim isNewPage As Boolean
    Dim StrFormat = New StringFormat()
    Dim CountFullWidth As Integer
    Dim RowCount As Integer = 0
    Dim ListOfLoadedAccountNames As New List(Of String)()
    Public Function GetAccountByName(GetName As String)
        Dim Acc As Account
        For Each account In ListOfAllAccounts
            If account.AcName = GetName Then
                Acc = account
            End If
        Next
        Return Acc
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Win32.AllocConsole()
        'Console.WriteLine("Done!")

        If MealTypeComboBox.Items.Count > 0 Then
            MealTypeComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        If (UsernameTextBox.Text IsNot "") Then
            UserNmeList.Add(UsernameTextBox.Text)
            UsernameListBox.Items.Add(UsernameTextBox.Text)
            UsernameTextBox.Text = ""
        End If
    End Sub
    Private Sub RemoveUserButton_Click(sender As Object, e As EventArgs) Handles RemoveUserButton.Click
        Dim i As Int32
        If (UsernameListBox.SelectedIndex >= 0) Then
            i = UsernameListBox.SelectedIndex
            UserNmeList.RemoveAt(i)
            UsernameListBox.Items.Remove(UsernameListBox.SelectedItem)
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        'Will open load file dialog box And if a file Is chosen wil load 
        OFDialog.ShowDialog()
        'Check to see if there is a file selected
        If OFDialog.FileName > "" Then
            'Set the File1 path to the parth of the file we want to load
            Try
                File1 = File.ReadAllText(OFDialog.FileName)
                File1Loc = OFDialog.FileName
                ReadTheFile()
            Catch ex As System.IO.IOException
                MsgBox("An error occurred. Most likley you did not select a file.")
            End Try
        End If
    End Sub
    Private Sub ReadTheFile()
        Dim RawEntList As New List(Of Array)()

        Dim newline() As String
        Dim CurrentAccountName As String
        Dim CurrentAccount As Account
        Dim AccountNameExsists As Boolean
        Dim NewAccount As Account
        Dim NewEntry As Entrey
        Dim WrongFileErrorTrigger As String

        ListOfLoadedAccountNames.Clear()
        'opens the file
        Try
            Dim sr As New IO.StreamReader(File1Loc)
            Console.WriteLine("Loading full report please waite")
            MsgBox("Loading full report may take a while.")
            'While we have not finished reading the file
            While (Not sr.EndOfStream)
                'spliting eatch line up into an array
                newline = sr.ReadLine.Split(","c)
                'storring eatch array into a list
                RawEntList.Add(newline)
            End While
            Try
                WrongFileErrorTrigger = RawEntList(0)(36)
            Catch ex As Exception
                MessageBox.Show("Invallad file. This was onley ment for loading WCS dining hall reports and requires columns 33-37(AG-AK in excel) and in the order: Date(33 or AG), Time(34 or AH), ID(35 or AI), Name(36 or AJ), Type(36 or AK)")
            End Try
            For Each Entr In RawEntList
                Entr(33) = Entr(33).ToString().Replace("""", "").Trim()
                Entr(34) = Entr(34).ToString().Replace("""", "").Trim()
                Entr(35) = Entr(35).ToString().Replace("""", "").Trim()
                Entr(36) = Entr(36).ToString().Replace("""", "").Trim()
                Entr(37) = Entr(37).ToString().Replace("""", "").Trim()
                CurrentAccountName = Entr(36)
                AccountNameExsists = False
                For Each AccountName In ListOfLoadedAccountNames
                    If CurrentAccountName = AccountName Then
                        AccountNameExsists = True
                    End If
                Next
                If AccountNameExsists = False Then
                    NewAccount = New Account(Entr(36))
                    NewEntry = New Entrey(Entr(36), DateTime.Parse(Entr(33)).ToString("dd/MMM/yyyy"), DateTime.Parse(Entr(34).Replace(".", "")).ToString("hh:mm:sstt"), Entr(37), Entr(35))
                    NewAccount.AddAccountEntrey(NewEntry)
                    ListOfAllAccounts.Add(NewAccount)
                    ListOfLoadedAccountNames.Add(CurrentAccountName)
                Else
                    NewEntry = New Entrey(Entr(36), DateTime.Parse(Entr(33)).ToString("dd/MMM/yyyy"), DateTime.Parse(Entr(34).Replace(".", "")).ToString("hh:mm:sstt"), Entr(37), Entr(35))
                    CurrentAccount = GetAccountByName(CurrentAccountName)
                    CurrentAccount.AddAccountEntrey(NewEntry)
                End If
            Next
            Console.WriteLine("Finished loading report.")
            Console.WriteLine("Fulling Out autocompleat list.")

            For Each AccountName In ListOfLoadedAccountNames
                UsernameTextBox.AutoCompleteCustomSource.Add(AccountName)
            Next

            FullReportLoaded = True
            RawFullReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RawFullReport()
        'Load the file
        Dim sr As New IO.StreamReader(File1Loc)
        'Create a new datatable object
        Dim dt As New DataTable
        'Create a string from eatch line, split the string up at eatch "," into a array , Return the split string after c number of splits where c is the number in the array
        Dim newline() As String
        'Create new data colums (headings) in the Data table, Eatch colums value is that of the newline split
        dt.Columns.AddRange({New DataColumn("Date", GetType(Date)), New DataColumn("Time", GetType(Date)), New DataColumn("ID", GetType(Integer)), New DataColumn("Name"), New DataColumn("Type")})
        'While we have not finished reading the file
        While (Not sr.EndOfStream)
            'keep spliting the strings up
            newline = sr.ReadLine.Split(","c)
            'Define a newrow as a new row in the datatable
            Dim newrow As DataRow = dt.NewRow
            'the line for eatch newrow will be these
            newrow.ItemArray = {DateTime.Parse(newline(33)).ToString("dd/MMM/yyyy"), DateTime.Parse(newline(34).Replace(".", "")).ToString("hh:mm:sstt"), newline(35).Replace("""", ""), newline(36).Replace("""", ""), newline(37).Replace("""", "")}
            'newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4)}
            'Create a new row
            dt.Rows.Add(newrow)
        End While
        FullReportDataGridView.DataSource = dt
        FullReportDataGridView.Columns("Date").DefaultCellStyle.Format = "dd/MMM/yyyy"
        FullReportDataGridView.Columns("Time").DefaultCellStyle.Format = "hh:mm:ss tt"
        'FullReportDataGridView.Update()
    End Sub
    Private Sub ExportCsvButton_Click(sender As Object, e As EventArgs) Handles ExportCsvButton.Click
        Dim SfLoc As String
        'Will open save file dialog box 
        SFDialog.FileName = ""
        SFDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        SFDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SFDialog.ShowDialog()
        'Check to see if there is a file selected
        If (SFDialog.FileName > "") Then
            Try
                SfLoc = SFDialog.FileName
                SaveAsCsv(SfLoc)
            Catch ex As System.IO.IOException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Public Sub SaveAsCsv(SaveFileLoc As String)
        Try
            Dim Savefile As System.IO.StreamWriter
            Savefile = My.Computer.FileSystem.OpenTextFileWriter(SaveFileLoc, True)
            For Each Row As DataGridViewRow In SearchReportDataGridView.Rows
                Console.WriteLine("----------")
                Dim NewWriteLine As String
                Dim sb As New System.Text.StringBuilder()
                For i = 0 To Row.Cells.Count - 1
                    If (i > 0) Then
                        sb.Append(",")
                    End If
                    sb.Append(Row.Cells(i).FormattedValue.ToString)
                Next
                NewWriteLine = sb.ToString
                Console.WriteLine(NewWriteLine)
                Savefile.WriteLine(NewWriteLine)
            Next
            Savefile.Close()
            MsgBox("CSV file saved.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim Acc As Account
        Dim MissingAccErrorTrigger As String
        Dim SearchDT As New DataTable
        Dim StartDate As Date = StartDateTimePicker.Value
        Dim EndDate As Date = EndDateTimePicker.Value
        listOfAccountsSerchData.Clear()
        If (FullReportLoaded = False) Then
            MsgBox("Can not search if there is nothing to search through. Please load a full dining hall report first.")
        Else
            TabControl1.SelectedTab = SearchReportTab
            For Each persion In UsernameListBox.Items
                Try
                    Acc = GetAccountByName(persion.ToUpper)
                    MissingAccErrorTrigger = Acc.AcName
                    listOfAccountsSerchData.Add(Acc)
                Catch ex As Exception
                    MessageBox.Show("Can not find an account for " + persion + ". Please check that the full report is loaded and the username is correct. If authentic then the user may have never been to the dinning hall.")
                End Try
            Next
            SearchDT.Columns.AddRange({New DataColumn("Date", GetType(Date)), New DataColumn("Time", GetType(Date)), New DataColumn("ID", GetType(Integer)), New DataColumn("Name", GetType(String)), New DataColumn("Type", GetType(String)), New DataColumn("Count", GetType(Integer))})
            Dim i As Integer = 0
            'for each account that is on the list of accounts in the search (user accounts that have been asked for and also exsists in the full report) 
            For Each obj In listOfAccountsSerchData
                'set the entrey counter to 0 at the start of each account
                i = 0
                'for each entrey in the account
                For Each ent In obj.AccountEntList
                    'Check if the date falls  with in the search range
                    If (ent.AcDate > StartDate And ent.AcDate < EndDate) Then
                        'if yes
                        'Check if the its in the right meal type or if meal type serch option is set to all
                        If (ent.ACType = MealTypeComboBox.SelectedItem.ToString Or MealTypeComboBox.SelectedIndex = 0) Then
                            'if yes then add the account entrey to the report 
                            i = i + 1
                            Dim newrow As DataRow = SearchDT.NewRow
                            newrow.ItemArray = {ent.AcDate, ent.ACTime, ent.ACID, ent.AcName, ent.ACType, i}
                            SearchDT.Rows.Add(newrow)
                        End If
                    End If

                Next
            Next
            SearchReportDataGridView.DataSource = SearchDT
            SearchReportDataGridView.Columns("Date").DefaultCellStyle.Format = "dd/MMM/yyyy"
            SearchReportDataGridView.Columns("Time").DefaultCellStyle.Format = "hh:mm:ss tt"
        End If
    End Sub
    Private Sub SaveAsExcelBut_Click(sender As Object, e As EventArgs) Handles SaveAsExcelBut.Click
        Dim SfLoc As String
        'Will open save file dialog box
        SFDialog.FileName = ""
        SFDialog.Filter = "XLS files (*.xls)|*.xls|All files (*.*)|*.*"
        SFDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SFDialog.ShowDialog()
        'Check to see if there is a file selected
        Try
            If (SFDialog.FileName > "") Then
                SfLoc = SFDialog.FileName
                saveAsExcelFile(SfLoc)
            End If
        Catch ex As System.IO.IOException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub saveAsExcelFile(SaveLoc As String)
        'initialize the Excel application
        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        'check whether Excel is installed
        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!!")
            Return
        End If
        'create the workbook
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        'I have no idear at all what this is
        Dim misValue As Object = System.Reflection.Missing.Value
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        'enter infomation
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet.Cells(1, 1) = "Sheet 1 Test"
        Dim j As Integer = 1
        Dim i As Integer = 1
        For Each Col As DataGridViewColumn In SearchReportDataGridView.Columns
            xlWorkSheet.Cells(j, i) = Col.HeaderCell.Value.ToString()
            i = i + 1
        Next
        For Each Row As DataGridViewRow In SearchReportDataGridView.Rows
            j = j + 1
            For i = 0 To Row.Cells.Count - 1
                xlWorkSheet.Cells(j, i + 1) = Row.Cells(i).FormattedValue.ToString()
            Next
        Next
        'Autoadjusts the width of the spredsheet columns
        xlWorkSheet.Columns.AutoFit()
        'save workbook
        Try
            xlWorkBook.SaveAs(SaveLoc, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        Catch ex As Exception
            MsgBox("Excel is going to throw another save dialog as a failsafe at you.")
        End Try
        'clean up
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
        MsgBox("XLS file saved.")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub PTD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PTD.BeginPrint

        Try
            StrFormat.Alignment = StringAlignment.Near
            StrFormat.LineAlignment = StringAlignment.Center
            StrFormat.Trimming = StringTrimming.EllipsisCharacter
            ListFromLeftColum.Clear()
            ListColumWidth.Clear()
            CountCellHeight = 0
            Counter = 0
            isFirstPage = True
            isNewPage = True
            CountFullWidth = 0
            RowCount = 0
            For Each dtaGridCol As DataGridViewColumn In SearchReportDataGridView.Columns
                CountFullWidth += dtaGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PTD.PrintPage
        Try
            Dim CountHeaderHight As Integer
            'Set the left margin
            Dim CountLeftPadding As Integer = e.MarginBounds.Left
            'Set the top margin
            Dim CountTopPadding As Integer = e.MarginBounds.Top
            'Whether more pages have to print Or Not
            Dim MorePagesToPrint As Boolean = False
            Dim CountTempWidth As Integer = 0
            'For the first page to print set the cell width And header height
            If isFirstPage Then
                For Each GridCol As DataGridViewColumn In SearchReportDataGridView.Columns
                    CountTempWidth = Math.Floor(GridCol.Width / CountFullWidth * CountFullWidth * (e.MarginBounds.Width / CountFullWidth))
                    CountHeaderHight = (e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, CountTempWidth).Height) + 11
                    ListFromLeftColum.Add(CountLeftPadding)
                    ListColumWidth.Add(CountTempWidth)
                    CountLeftPadding += CountTempWidth
                Next
            End If
            'Loop till all the rows are in the print document
            While (RowCount <= SearchReportDataGridView.Rows.Count - 1)
                Dim DataGridRow As DataGridViewRow = SearchReportDataGridView.Rows(RowCount)
                'Set the cell height
                CountCellHeight = DataGridRow.Height + 5
                Counter = 0
                'Check whether there is enought space on the page for more rows
                'if not then create a new page
                If (CountCellHeight + CountTopPadding >= e.MarginBounds.Height + e.MarginBounds.Top) Then
                    MorePagesToPrint = True
                    isFirstPage = False
                    isNewPage = True
                    Exit While
                Else
                    If isNewPage Then
                        'Write the heading
                        'Title
                        e.Graphics.DrawString("Dining hall report", New Font(SearchReportDataGridView.Font, FontStyle.Bold), Brushes.CadetBlue, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Spaceeeeeeeeee", New Font(SearchReportDataGridView.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                        Dim strDate As String = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString()
                        'Date
                        e.Graphics.DrawString(strDate, New Font(SearchReportDataGridView.Font, FontStyle.Bold), Brushes.CadetBlue, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(SearchReportDataGridView.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Spaceeeeeeeeee", New Font(New Font(SearchReportDataGridView.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                        'Create the Columns                 
                        CountTopPadding = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In SearchReportDataGridView.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.CadetBlue), New Rectangle(ListFromLeftColum(Counter), CountTopPadding, ListColumWidth(Counter), CountHeaderHight))
                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(ListFromLeftColum(Counter), CountTopPadding, ListColumWidth(Counter), CountHeaderHight))
                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(Color.White), New RectangleF(ListFromLeftColum(Counter), CountTopPadding, ListColumWidth(Counter), CountHeaderHight), StrFormat)
                            Counter = Counter + 1
                        Next
                        isNewPage = False
                        CountTopPadding += CountHeaderHight
                    End If
                    Counter = 0
                    'populate the columns               
                    For Each Cell As DataGridViewCell In DataGridRow.Cells
                        If (Cell.Value IsNot Nothing) Then
                            e.Graphics.DrawString(Cell.FormattedValue.ToString(), Cell.InheritedStyle.Font, New SolidBrush(Cell.InheritedStyle.ForeColor), New RectangleF(ListFromLeftColum(Counter), CountTopPadding, ListColumWidth(Counter), CountCellHeight), StrFormat)
                        End If
                        'Drawing the grids 
                        e.Graphics.DrawRectangle(Pens.DarkGray, New Rectangle(ListFromLeftColum(Counter), CountTopPadding, ListColumWidth(Counter), CountCellHeight))
                        Counter = Counter + 1
                    Next
                    'Stop creating the new page
                End If
                CountTopPadding += CountCellHeight
                RowCount = RowCount + 1
            End While
            'If Theres still more to print then keep printing pages
            If MorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintPrevTestButton_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        PTD.DocumentName = "Dining Hall Print Report"
        PrintPreviewDialog1.Document = PTD
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub printtestbut_Click(sender As Object, e As EventArgs) Handles printtestbut.Click
        PrintDialog1.Document = PTD
        PrintDialog1.PrinterSettings = PTD.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PTD.PrinterSettings = PrintDialog1.PrinterSettings
            PTD.Print()
        End If
    End Sub
End Class
Public Class Win32
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean
    End Function
End Class

Public Class Account
    Public AccountEntList As New List(Of Entrey)()
    Public AcName As String
    Public Sub New(AN As String)
        Me.AcName = AN
    End Sub
    Public Sub AddAccountEntrey(Ent As Entrey)
        Me.AccountEntList.Add(Ent)
    End Sub
End Class
Public Class Entrey
    Public AcName As String
    Public AcDate As Date
    Public ACTime As Date
    Public ACType As String
    Public ACID As Integer
    Public Sub New(AN As String, AD As String, ATi As Date, ATy As String, AI As Integer)
        Me.AcName = AN
        Me.ACTime = ATi
        Me.ACType = ATy
        Me.ACID = AI
        Me.AcDate = AD
    End Sub
End Class