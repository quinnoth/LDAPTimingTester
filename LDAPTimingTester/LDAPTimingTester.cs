using Novell.Directory.Ldap;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace LDAPTimingTester
{
    public partial class LDAPTimingTester : Form
    {
        private LdapConnection connection;

        public LDAPTimingTester()
        {
            InitializeComponent();
            ReadApplicationSettings();
        }

        private void ReadApplicationSettings()
        {
            var settings = new AppSettingsReader();
            chkLDAPSEnabled.Checked = false;
            try
            {
                txtDirectoryHostname.Text = (string)settings.GetValue("DirectoryHostname", typeof(string));
                txtDirectoryPort.Text = (string)settings.GetValue("DirectoryPort", typeof(string));
                txtUsername.Text = (string)settings.GetValue("Username", typeof(string));
                txtPassword.Text = (string)settings.GetValue("Password", typeof(string));
                txtSearchBase.Text = (string)settings.GetValue("SearchBase", typeof(string));
                txtSearchFilter.Text = (string)settings.GetValue("SearchFilter", typeof(string));
            }
            catch (Exception ex)
            {
                Log("Application Settings Not Found");
                Log(ex.Message);
                txtDirectoryHostname.Text = "";
                txtDirectoryPort.Text = "389";
                txtUsername.Text = "Username";
                txtPassword.Text = "";
                txtSearchBase.Text = "";
                txtSearchFilter.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRunAsSync_Click(object sender, EventArgs e)
        {
            Log("-----------------------------");
            Log("Started Syncronous Query Test");
            Log("-----------------------------");
            Run(false);
        }

        private void btnRunAsAsync_Click(object sender, EventArgs e)
        {
            Log("------------------------------");
            Log("Started Asyncronous Query Test");
            Log("------------------------------");
            Run(true);
        }

        private void Run(bool isAsync)
        {
            try
            {
                Connect();

                long totalTime = 0;
                foreach (string s in txtSearchItems.Lines)
                {
                    if (isAsync)
                    {
                        totalTime += SearchDirectoryAsync(txtSearchBase.Text, "(" + txtSearchFilter.Text + s + ")");
                    }
                    else
                    {
                        totalTime += SearchDirectorySync(txtSearchBase.Text, "(" + txtSearchFilter.Text + s + ")");
                    }
                }
                Log("Average Search Time: " + (totalTime / txtSearchItems.Lines.Length) + "ms");
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void Connect()
        {
            connection = new LdapConnection();
            connection.SecureSocketLayer = chkLDAPSEnabled.Checked;
            Log("LDAPS Enabled: " + chkLDAPSEnabled.Checked.ToString());
            Log("Hostname: " + txtDirectoryHostname.Text);
            Log("Port: " + txtDirectoryPort.Text);
            Log("Attempting to Connect to Directory...");
            connection.Connect(txtDirectoryHostname.Text, Convert.ToInt32(txtDirectoryPort.Text));
            Log("Connected to Directory!");
            Log("Attempting to Bind to Directory...");
            Log("Username: " + txtUsername.Text);
            Log("Password: ********");
            connection.Bind(txtUsername.Text, txtPassword.Text);
            Log("Bound to Directory!");
        }

        private long SearchDirectorySync(string searchBase, string searchFilter)
        {
            Log("Searching Base: " + searchBase + " and Filter: " + searchFilter);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                LdapSearchResults lsq = connection.Search(
                    searchBase
                    , LdapConnection.SCOPE_SUB
                    , searchFilter
                    , null
                    , false);

                while (lsq.hasMore())
                {
                    LdapEntry nextEntry = null;
                    nextEntry = lsq.next();
                    sw.Stop();
                    Log("Entry FOUND. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                    return sw.ElapsedMilliseconds;
                }

                if (sw.IsRunning)
                {
                    sw.Stop();
                    Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                    return sw.ElapsedMilliseconds;
                }
                sw.Stop();
                Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                return sw.ElapsedMilliseconds;
            }
            catch (Exception ex)
            {
                sw.Stop();
                Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                Log(ex.Message);
                return sw.ElapsedMilliseconds;
            }
        }

        private long SearchDirectoryAsync(string searchBase, string searchFilter)
        {
            Log("Searching Base: " + searchBase + " and Filter: " + searchFilter);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                var queue = connection.Search(
                    searchBase
                    , LdapConnection.SCOPE_SUB
                    , searchFilter
                    , null
                    , false
                    , (LdapSearchQueue)null
                    , (LdapSearchConstraints)null);

                LdapMessage message;
                while ((message = queue.getResponse()) != null) //we wait for a response from the server
                {
                    if (message is LdapSearchResult)
                    {
                        sw.Stop();
                        Log("Entry FOUND. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                        return sw.ElapsedMilliseconds;
                    }
                }
                if (sw.IsRunning)
                {
                    sw.Stop();
                    Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                    return sw.ElapsedMilliseconds;
                }
                sw.Stop();
                Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                return sw.ElapsedMilliseconds;
            }
            catch (Exception ex)
            {
                sw.Stop();
                Log("NO Entry Found. Elapsed Time: " + sw.ElapsedMilliseconds + "ms");
                Log(ex.Message);
                return sw.ElapsedMilliseconds;
            }
        }

        private void Log(string s)
        {
            txtOutput.Text += s + "\r\n";
            txtOutput.Update();
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.ScrollToCaret();
        }
    }
}
