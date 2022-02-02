namespace TimeTool;

public partial class Form1 : Form
{
    string timeAusgabe = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\Ausgabe\TimeToolAusgabe.txt");
    string timeBackup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\BACKUP\TimeToolBACKUP.txt");
    public Form1()
    {
        InitializeComponent();

        if (File.Exists(timeAusgabe))
        {
            using (StreamReader sr = new StreamReader(timeAusgabe))
            {
                txtZeitAusgabe.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        // Gets the Calendar instance associated with a CultureInfo.
        CultureInfo myCI = new CultureInfo("de");
        Calendar myCal = myCI.Calendar;

        // Gets the DTFI properties required by GetWeekOfYear.
        CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
        DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

        // Displays the number of the current week relative to the beginning of the year.
        txtKw.Text = $"KW: {myCal.GetWeekOfYear(dTP1.Value.Date, (CalendarWeekRule)2, (DayOfWeek)1).ToString()}";
    }

    private void txtZeitpunkt_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtZeitAusgabe.Text))
                {
                    e.SuppressKeyPress = true;
                    DateTime zeitpunkt = DateTime.Now;

                    using (StreamWriter sw = new(timeAusgabe, false))
                    {
                        sw.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");
                    }

                    using (StreamWriter sw1 = new(timeBackup, true))
                    {
                        sw1.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");
                    }

                    using (StreamReader sr = new StreamReader(timeAusgabe))
                    {
                        txtZeitpunkt.Clear();
                        txtZeitAusgabe.Text = sr.ReadToEnd();
                    }
                }
                else
                {
                    e.SuppressKeyPress = true;
                    DateTime zeitpunkt = DateTime.Now;

                    using (StreamWriter sw = new(timeAusgabe, true))
                    {
                        sw.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");
                    }

                    using (StreamWriter sw1 = new(timeBackup, true))
                    {
                        sw1.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");
                    }

                    using (StreamReader sr = new StreamReader(timeAusgabe))
                    {
                        txtZeitpunkt.Clear();
                        txtZeitAusgabe.Text = sr.ReadToEnd();
                    }
                }
            }
        }
        catch
        {
            MessageBox.Show(@"Bitte erstelle einen Ordner im Verzeichnis C:\ mit dem Namen ToolBOX (C:\ToolBOX)! In diesem Ordner wird die Ausgabe dann in die Textdatei TimeToolAusgabe.txt geschrieben.");
        }
    }

    private void BtnAusgabe_Click(object sender, EventArgs e)
    {
        StreamWriter sw = new(timeAusgabe, false);
        sw.WriteLine(txtZeitAusgabe.Text);
        sw.Close();

        StreamWriter sw1 = new(timeBackup, true);
        sw1.WriteLine(txtZeitAusgabe.Text);
        sw1.Close();
        BtnAusgabe.Enabled = false;
    }

    private void BtnLaden_Click(object sender, EventArgs e)
    {
        if (File.Exists(timeAusgabe))
        {
            StreamReader sr = new StreamReader(timeAusgabe);

            txtZeitAusgabe.Text = sr.ReadToEnd();
            sr.Close();
        }
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtZeitAusgabe.Text = "";
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (txtZeitpunkt.Focused == false && dTP2.Focused == false)
            dTP2.Value = DateTime.Now;
    }

    private void dTP1_ValueChanged(object sender, EventArgs e)
    {
        // Gets the Calendar instance associated with a CultureInfo.
        CultureInfo myCI = new CultureInfo("de");
        Calendar myCal = myCI.Calendar;

        // Gets the DTFI properties required by GetWeekOfYear.
        CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
        DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

        // Displays the number of the current week relative to the beginning of the year.
        //txtKw.Text = myCal.GetWeekOfYear(dTP1.Value.Date, myCWR, myFirstDOW).ToString();
        txtKw.Text = $"KW: {myCal.GetWeekOfYear(dTP1.Value.Date, (CalendarWeekRule)2, (DayOfWeek)1).ToString()}";
    }

    private void txtZeitAusgabe_TextChanged(object sender, EventArgs e)
    {
        BtnAusgabe.Enabled = true;
    }

    private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        dTP1.Value = DateTime.Now;
        dTP2.Value = DateTime.Now;
    }
}
