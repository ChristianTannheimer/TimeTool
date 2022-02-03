namespace TimeTool;

public partial class Form1 : Form
{
    string mainFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX");
    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\Ausgabe");
    string folderPathBackup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\BACKUP");
    string timeAusgabe = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\Ausgabe\TimeToolAusgabe.txt");
    string timeBackup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ToolBOX\BACKUP\TimeToolBACKUP.txt");
    CultureInfo myCI = new CultureInfo("de");
    public Form1()
    {
        InitializeComponent();
        if (!Directory.Exists(folderPath)) { Directory.CreateDirectory(folderPath); }
        if (!Directory.Exists(folderPathBackup)) { Directory.CreateDirectory(folderPathBackup); }

        if (File.Exists(timeAusgabe))
        {
            using (StreamReader sr = new StreamReader(timeAusgabe))
                txtZeitAusgabe.Text = sr.ReadToEnd();
        }
        Calendar myCal = myCI.Calendar;
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
                        sw.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");

                    using (StreamWriter sw1 = new(timeBackup, true))
                        sw1.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");

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
                        sw.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");

                    using (StreamWriter sw1 = new(timeBackup, true))
                        sw1.WriteLine($"{dTP1.Value.ToShortDateString()}  {dTP2.Text}    {txtZeitpunkt.Text}");

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
            MessageBox.Show(@"Die abgelegte Datei ist fehlerhaft oder nicht vorhanden!");
        }
    }
    private void BtnAusgabe_Click(object sender, EventArgs e)
    {
        using (StreamWriter sw = new(timeAusgabe, false))
            sw.WriteLine(txtZeitAusgabe.Text);

        using (StreamWriter sw1 = new(timeBackup, true))
        {
            sw1.WriteLine(txtZeitAusgabe.Text);
        }
        BtnAusgabe.Enabled = false;
    }
    private void BtnLaden_Click(object sender, EventArgs e)
    {
        if (File.Exists(timeAusgabe))
        {
            using (StreamReader sr = new StreamReader(timeAusgabe))
                txtZeitAusgabe.Text = sr.ReadToEnd();
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
        Calendar myCal = myCI.Calendar;
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
    private void ausgabe÷ffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("explorer", timeAusgabe);
    }
    private void backup÷ffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("explorer", timeBackup);
    }
    private void ordner÷ffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("explorer", mainFolderPath);
    }
}