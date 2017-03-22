using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepAlive
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            _keepAliveTimer = new Timer();
            _keepAliveTimer.Interval = 1000; // ms
            _keepAliveTimer.Tick += KeepAliveTimerOnTick;
            _keepAliveTimer.Start();
        }

        private bool _isPerformingKeepAlive = false;
        private int _currentSecondsCount = 0;
        private const int SECONDS_INTERVAL = 15;
        private Timer _keepAliveTimer;
        private int _urlsCount = 0;
        private int _urlsReported = 0;

        private void KeepAliveTimerOnTick(object sender, EventArgs eventArgs) {
            if (_isPerformingKeepAlive) {
                lblTimeUntilRefresh.Text = "loading...";
                return;
            }

            _currentSecondsCount += 1;
            lblTimeUntilRefresh.Text = (SECONDS_INTERVAL - _currentSecondsCount).ToString() + " seconds";
            if (_currentSecondsCount >= SECONDS_INTERVAL) {
                _isPerformingKeepAlive = true;
                var urls = GetUrlsFromForm();
                KeepAliveAllUrls(urls);
                _currentSecondsCount = 0;
            }
        }

        private List<string> GetUrlsFromForm() {
            var txtBlob = txtUrlsToKeepAlive.Text;
            var urls = txtBlob.Split(new string[] {",", "\n", Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            return urls.ToList();
        }

        private void KeepAliveAllUrls(List<string> urls) {
            txtStatus.Text = "";

            if (urls == null || urls.Count == 0) {
                txtStatus.Text = "no urls";
                return;
            }

            txtStatus.Text = "Running " + DateTime.Now.ToString() + Environment.NewLine;
            _urlsCount = urls.Count;
            _urlsReported = 0;
            prgbarStatus.Value = 0;
            prgbarStatus.Maximum = _urlsCount;
            foreach (var url in urls) {
                txtStatus.Text += "Loading " + url + Environment.NewLine;

                WebClient web = new WebClient();
                web.DownloadStringCompleted += WebOnDownloadStringCompleted;
                var uri = new Uri(url);
                web.DownloadStringAsync(uri, uri);
            }
        }

        private void WebOnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs eventArgs) {
            txtStatus.Text += "Completed " + eventArgs.UserState + Environment.NewLine;
            ++_urlsReported;
            prgbarStatus.Value = _urlsReported;
            if (_urlsReported >= _urlsCount)
                _isPerformingKeepAlive = false;
        }

        private void btnPauseResume_Click(object sender, EventArgs e) {
            if (_keepAliveTimer.Enabled) {
                _keepAliveTimer.Stop();
            }
            else {
                _keepAliveTimer.Start();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
