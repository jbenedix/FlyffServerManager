using System.Configuration;
using System.Diagnostics;

namespace FlyffServerManager
{
    public partial class Main : Form
    {
        public string account { get; set; }
        public string certifier { get; set; }
        public string database { get; set; }
        public string core { get; set; }
        public string login { get; set; }
        public string cache { get; set; }
        public string world { get; set; }

        public string client { get; set; }

        Process accountProcess;
        Process certifierProcess;
        Process databaseProcess;
        Process coreProcess;
        Process loginProcess;
        Process cacheProcess;
        Process worldProcess;

        Process clientProcess;

        ProcessStartInfo startInfoAccount;
        ProcessStartInfo startInfoCertifier;
        ProcessStartInfo startInfoDatabase;
        ProcessStartInfo startInfoCore;
        ProcessStartInfo startInfoLogin;
        ProcessStartInfo startInfoCache;
        ProcessStartInfo startInfoWorld;


        ProcessStartInfo startInfoClient;


        public Main()
        {
            InitializeComponent();
            LoadConfigFile();
            //account = ConfigurationManager.AppSettings["account"];
            //certifier = ConfigurationManager.AppSettings["certifier"];
            //database = ConfigurationManager.AppSettings["database"];
            //core = ConfigurationManager.AppSettings["core"];
            //login = ConfigurationManager.AppSettings["login"];
            //cache = ConfigurationManager.AppSettings["cache"];
            //world = ConfigurationManager.AppSettings["world"];
            //client = ConfigurationManager.AppSettings["client"];

            startInfoAccount = new ProcessStartInfo
            {
                FileName = account,
                WorkingDirectory = Path.GetDirectoryName(account)
            };

            startInfoCertifier = new ProcessStartInfo
            {
                FileName = certifier,
                WorkingDirectory = Path.GetDirectoryName(certifier)
            };

            startInfoDatabase = new ProcessStartInfo
            {
                FileName = database,
                WorkingDirectory = Path.GetDirectoryName(database)
            };

            startInfoCore = new ProcessStartInfo
            {
                FileName = core,
                WorkingDirectory = Path.GetDirectoryName(core)
            };

            startInfoLogin = new ProcessStartInfo
            {
                FileName = login,
                WorkingDirectory = Path.GetDirectoryName(login)
            };

            startInfoCache = new ProcessStartInfo
            {
                FileName = cache,
                WorkingDirectory = Path.GetDirectoryName(cache)
            };

            startInfoWorld = new ProcessStartInfo
            {
                FileName = world,
                WorkingDirectory = Path.GetDirectoryName(world)
            };

            startInfoClient = new ProcessStartInfo
            {
                FileName = client,
                WorkingDirectory = Path.GetDirectoryName(client)
            };

            textBox_Account.DataBindings.Add("Text", this, "account");
            textBox_Cache.DataBindings.Add("Text", this, "cache");
            textBox_Certifier.DataBindings.Add("Text", this, "certifier");
            textBox_Core.DataBindings.Add("Text", this, "core");
            textBox_Database.DataBindings.Add("Text", this, "database");
            textBox_Login.DataBindings.Add("Text", this, "login");
            textBox_World.DataBindings.Add("Text", this, "world");
            textBox_Client.DataBindings.Add("Text", this, "client");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tostart = "\"" + account + "\"";
            Console.WriteLine(tostart);
            Console.WriteLine(Path.GetDirectoryName(account));
            try
            {
                accountProcess = Process.Start(startInfoAccount);
                Status_Account.BackColor = Color.Green;
                Thread.Sleep(2000);

                certifierProcess = Process.Start(startInfoCertifier);
                Status_Certifier.BackColor = Color.Green;
                Thread.Sleep(2000);

                databaseProcess = Process.Start(startInfoDatabase);
                Status_Database.BackColor = Color.Green;
                Thread.Sleep(2000);

                coreProcess = Process.Start(startInfoCore);
                Status_Core.BackColor = Color.Green;
                Thread.Sleep(2000);

                loginProcess = Process.Start(startInfoLogin);
                Status_Login.BackColor = Color.Green;
                Thread.Sleep(2000);

                cacheProcess = Process.Start(startInfoCache);
                Status_Cache.BackColor = Color.Green;
                Thread.Sleep(2000);

                worldProcess = Process.Start(startInfoWorld);
                Status_World.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_stopServer_Click(object sender, EventArgs e)
        {
            accountProcess.Kill();
            Status_Account.BackColor = Color.Red;

            certifierProcess.Kill();
            Status_Certifier.BackColor = Color.Red;

            databaseProcess.Kill();
            Status_Database.BackColor = Color.Red;

            coreProcess.Kill();
            Status_Core.BackColor = Color.Red;

            loginProcess.Kill();
            Status_Login.BackColor = Color.Red;

            cacheProcess.Kill();
            Status_Cache.BackColor = Color.Red;

            worldProcess.Kill();
            Status_World.BackColor = Color.Red;
        }

        private void textBox_Account_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_stopServer.PerformClick();
            Thread.Sleep(3000);
            button1.PerformClick();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientProcess = Process.Start(startInfoClient);
            Status_Client.BackColor = Color.Green;
        }
        void LoadConfigFile()
        {
            var configData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\config.ini");

            //Go Thorugh each line and check config
            foreach (var line in configData)
            {
                //Dont check Comments
                if (!line.StartsWith("#"))
                {
                    // I prefer if/else if over switch/case
                    if (line.Split('=').First() == "account")
                    {
                        account = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "certifier")
                    {
                        certifier = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "database")
                    {
                        database = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "core")
                    {
                        core = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "login")
                    {
                        login = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "cache")
                    {
                        cache = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "world")
                    {
                        world = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "client")
                    {
                        client = line.Split("=").Last();
                    }
                }
            }
        }
    }
}