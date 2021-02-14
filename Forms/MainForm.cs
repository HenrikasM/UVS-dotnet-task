using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using uvsWinFormTask.DB;

namespace uvsWinFormTask
{
    public partial class Main : Form
    {
        public Random rnd = new Random();
        public bool Status { get; set; }
        public DateTime Time { get; private set; }

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        //Button to start application
        private void Button1_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Button1Controller();
        }
        private void Button1Controller()
        {
            Status = true;
            // Create X amount of threads. X value from UI numericUpDown component. 
            for (int i = 1; i <= threadAmount.Value; i++)
            {
                Thread childThread = CreateThread(i);
                childThread.IsBackground = true;
                childThread.Start();
            }
        }
        private Thread CreateThread(int i)
        {
            return new Thread(() => { UpdateUI(i); });
        }
        public void UpdateUI(int id)
        {
            //Execute single thread until var Status changes to false.
            while (Status == true)
            {
                Thread.Sleep(rnd.Next(5000, 20000)); //Pause thread for 0.5sec-2sec, before execution.

                //Create a single row item with thread id and random string.
                ListViewItem itm = new ListViewItem((id).ToString());
                string data = CreateString(rnd.Next(5, 10));
                itm.SubItems.Add(data);
                Time = DateTime.Now.ToLocalTime(); //Assign thread "create date" value.
                listView1.BeginInvoke(new Action(() => //Add new row item to ListView in UI. BeginInvoke becouse async. 
                listView1.Items.Add(itm)
                ));

                //To only show last 20 rows. Invoke becouse sync.
                if (listView1.Items.Count > 19)
                    listView1.Invoke(new Action(() =>
                listView1.Items.RemoveAt(0)
                ));

                //Insert row to DB file.
                UpdateDB((id).ToString(), Time, data);
            }
        }
        public void UpdateDB(string id, DateTime Time, string data)
        {
            DBcontroller dbObj = new DBcontroller();
            dbObj.DBInsert(id, Time, data);
        }

        //Random string generator from web.
        public string CreateString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        //Button to stop thread execution
        private void Button2_Click(object sender, EventArgs e)
        {
            Status = false;
            Start.Enabled = true;
        }
    }
}


