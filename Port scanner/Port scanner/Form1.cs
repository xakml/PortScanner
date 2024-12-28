using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_scanner
{
    public partial class Form1 : Form
    {
        /*用来接受控件中值的变量*/
        private string ipStart;
        private string ipEnd;
        private int portStart;
        private int portEnd;
        private int numThread = 20;//默认为20；
        private int overTime;
        private Thread t;//定义一个线程
        private Thread scanthread;
        private bool[] done = new bool[65536];
        private bool ok;
        private int port;
        List<string> str;
        /*用来记录扫描结果并填充进DataGridView控件*/


        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*如果控件中值均不为空，将值赋给变量*/
            if (txtIPStart.Text != "")
            {
                ipStart = txtIPStart.Text;
            }
            if (txtPortStart.Text != "")
            {
                portStart = int.Parse(txtPortStart.Text);//注意类型转换
            }
            if (txtThreadNumber.Text != "")
            {
                numThread = int.Parse(txtThreadNumber.Text);
            }

            if (chkSingleIP.Checked)
            {
                txtIPStart.ReadOnly = true;
            }

            if (chkSinglePort.Checked)
            {
                txtPortEnd.ReadOnly = true;
            }

            txtThreadNumber.Text = Environment.ProcessorCount.ToString();// "10";

            /*设置超时时限最小为10s，最大为30s*/
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 30;
            overTime = trackBar1.Value;

            //清楚Lisview中的数据
            listBox1.Items.Add("IP地址              " + "    端口       " + "  端口状态 " + "             服务");
            listBox1.Items.Add("");
            this.txtIPStart.Text = "192.168.0.1";

            this.txtIPEnd.Text = "192.168.0.255";
            this.txtPortStart.Text = "0";
            this.txtPortEnd.Text = "65535";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        /*开始*/
        private void Start_Click(object sender, EventArgs e)
        {
            /*改变开始、停止按钮状态*/
            button2.Enabled = true;

            richTextBox1.Clear();

            listBox1.Items.Clear();
            listBox1.Items.Add("IP地址              " + "    端口       " + "  端口状态 " + "             服务");
            listBox1.Items.Add("");


            if (chkSingleIP.Checked)
            {
                txtIPEnd.Text = txtIPStart.Text;
            }
            if (chkSinglePort.Checked)
            {
                txtPortEnd.Text = txtPortStart.Text;
            }

            richTextBox1.Text = "开始\n";
            //匹配正确的IP地址
            Regex rgx = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");

            if (rgx.IsMatch(txtIPStart.Text) && rgx.IsMatch(txtIPEnd.Text))//匹配正确IP
            {
                if (txtPortStart.Text == "")
                {
                    MessageBox.Show("请输入端口号！");
                }
                else
                {
                    portStart = Int32.Parse(txtPortStart.Text);
                    portEnd = Int32.Parse(txtPortEnd.Text);
                    progressBar1.Minimum = portStart;
                    progressBar1.Maximum = portEnd;
                }

            }
            else
            {
                MessageBox.Show("请填写正确IP");
                return;
            }

            if (portEnd < portStart)
            {
                MessageBox.Show("请填写正确端口范围");
                return;
            }
            ok = true;
            Thread waitT = new Thread(new ThreadStart(wait));
            waitT.Start();//等待所有线程执行完毕在写入textbox中
        }

        public void wait()
        {
            int startIp = Int32.Parse(txtIPStart.Text.Split('.')[3]);
            int endIp = Int32.Parse(txtIPEnd.Text.Split('.')[3]);

            string ip = txtIPStart.Text.Split('.')[0] + "." + txtIPStart.Text.Split('.')[1] + "." + txtIPStart.Text.Split('.')[2] + ".";


            for (int q = startIp; q <= endIp && ok == true; q++)
            {

                //---------------------ping
                //Ping ping = new Ping();
                //PingReply reply = ping.Send(IPAddress.Parse(ip + q), overTime);
                //if (reply.Status == IPStatus.Success)
                //{
                //    richTextBox1.Text += ip + q + " Ping时间" + reply.RoundtripTime + "毫秒\n";
                //    IPHostEntry host = Dns.GetHostEntry(ip + q);
                //    richTextBox1.Text += "主机名为 " + host.HostName + "\n";
                //}
                //else
                //{
                //    listBox1.Items.Add(ip + q + "                 " + "-" + "            " + "-" + "   " + "                - 不可达\n");
                //    richTextBox1.Text += ip + q + "不可达\n";
                //    continue;
                //}





                //---------------------end
                Thread[] tharr;
                if (numThread < (portEnd - portStart + 1))
                {
                    tharr = new Thread[portEnd - portStart + 1];
                }
                else
                {
                    tharr = new Thread[numThread];
                }
                str = new List<string>();
                for (int i = portStart; i <= portEnd; i++)
                {
                    if (!ok) break;
                    Thread thread = new Thread(new ParameterizedThreadStart(Scan));
                    thread.Start(new IPEndPoint(IPAddress.Parse(ip + q), i));//每扫描一个端口创建一个线程

                    richTextBox1.Text += i + " 端口扫描中---\n";

                    tharr[i - portStart] = thread;
                    progressBar1.Value = i;

                    string s = State(i);
                    if (checkBox1.Checked)
                    {
                        if (s == "Open")
                        {

                            listBox1.Items.Add(ip + q + "                " + i + "           " + s + "   " + "          " + Service(i));
                        }
                    }
                    else
                    {
                        if (s == "Open")
                        {

                            listBox1.Items.Add(ip + q + "                " + i + "            " + s + "   " + "         " + Service(i));
                        }
                        else
                        {
                            listBox1.Items.Add(ip + q + "                " + i + "            " + s + "   " + "          ");
                        }
                    }

                }


                bool iscon = true;//第一个线程等待时间
                for (int i = 0; i < tharr.Length; i++)
                {
                    if (tharr[i] == null)
                        continue;
                    while (tharr[i].IsAlive && iscon)//端口超时设置时间(目前200毫秒),一直等待此ip所有线程执行完毕才扫描下个ip
                    {
                        Thread.Sleep(200);
                        iscon = false;//第一个线程给200ms等待时间，其他线程由于同步执行的，所以没等待时间了,如果线程还没执行完，说明此端口不可达。
                    }
                }
                str.Sort();
                richTextBox1.Text += "开放端口： ";
                for (int k = 0; k < str.Count; k++)
                    richTextBox1.Text += str[k] + "  ";
                richTextBox1.Text += "\n";
            }
            if (ok == true)
            {
                MessageBox.Show("扫描完成");
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                MessageBox.Show("扫描终止");
            }


        }
        public string State(int i)
        {
            str.Sort();
            for (int k = 0; k < str.Count; k++)
            {
                string s = str[k];
                if (Convert.ToString(i) == s)
                    return "Open";
            }
            return "Closed";
        }
        public string Service(int i)
        {
            switch (i)
            {

                case 80:
                    return "HTTP协议代理服务";
                case 135:
                    return "DCE endpoint resolutionnetbios-ns";
                case 445:
                    return "安全服务";
                case 1025:
                    return "NetSpy.698(YAI)";


                case 8080:
                    return "HTTP协议代理服务";

                case 8081:
                    return "HTTP协议代理服务";

                case 3128:
                    return "HTTP协议代理服务";

                case 9080:
                    return "HTTP协议代理服务";

                case 1080:
                    return "SOCKS代理协议服务";

                case 21:
                    return "FTP(文件传输)协议代理服务";

                case 23:
                    return "Telnet(远程登录)协议代理服务";

                case 443:
                    return "HTTPS协议代理服务";

                case 69:
                    return "TFTP协议代理服务";

                case 22:
                    return "SSH、SCP、端口重定向协议代理服务";

                case 25:
                    return "SMTP协议代理服务";

                case 110:
                    return "POP3协议代理服务";
                default:
                    return "Unknow Servies";
            }
        }

        public void Scan(object Point)
        {
            IPEndPoint IPPoint = (IPEndPoint)Point;
            try
            {
                TcpClient tcp = new TcpClient();
                tcp.Connect(IPPoint);
                if (tcp.Connected)
                    str.Add(Convert.ToString(IPPoint.Port));
            }
            catch
            {
                ;
            }
        }


        /*停止*/
        private void Stop_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            ok = false;
            progressBar1.Value = progressBar1.Minimum;
        }

        /*关于*/
        private void button3_Click(object sender, EventArgs e)
        {
            /*弹出关于PortScanner窗体*/
            Form2 f = new Form2();
            f.Show();
        }

        /*“只显示开放端口”按钮被选定*/
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            /*将textbox中值与trackbar中值联系起来*/
            textBox6.Text = this.trackBar1.Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPEnd.Visible == true)
            {
                txtIPEnd.Visible = false;
                label2.Text = "";
            }
            else
            {
                txtIPEnd.Visible = true;
                txtIPStart.Text = txtIPEnd.Text = "";
                label2.Text = "-";
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPortEnd.Visible == true)
            {
                txtPortEnd.Visible = false;
                label3.Text = "";
            }
            else
            {
                txtPortEnd.Visible = true;
                txtPortStart.Text = txtPortEnd.Text = "";
                label3.Text = "-";
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start(object sender, EventArgs e)
        {
            /*改变开始、停止按钮状态*/
            button2.Enabled = true;

            richTextBox1.Clear();

            listBox1.Items.Clear();
            listBox1.Items.Add("IP地址              " + "    端口       " + "  端口状态 " + "             服务");
            listBox1.Items.Add("");

            string threadNumberStr = this.txtThreadNumber.Text;
            if (string.IsNullOrEmpty(threadNumberStr))
                numThread = Environment.ProcessorCount;
            else
                numThread = int.Parse(threadNumberStr);

            long[] ips = null;
            int[] ports = null;

            if (chkSingleIP.Checked)
            {
                txtIPEnd.Text = txtIPStart.Text;
                long singleIP = this.GetIpStartLongFormat(out string err_msg);
                if (singleIP < 0)
                {
                    MessageBox.Show("请填写正确IP");
                    return;
                }
                ips = new long[] { singleIP };
            }
            else
            {
                long startIP = this.GetIpStartLongFormat(out _);
                if (startIP < 0)
                {
                    MessageBox.Show("请填写正确IP");
                    return;
                }

                long endIP = this.GetIpEndLongFormat(out _);
                if (endIP < 0)
                {
                    MessageBox.Show("请填写正确IP");
                    return;
                }
                if (endIP < startIP)
                {
                    MessageBox.Show("开始与结束IP顺序有误");
                    return;
                }

                ips = new long[endIP - startIP + 1];
                for (long ip = startIP; ip <= endIP; ip++)
                {
                    ips[ip - startIP] = ip;
                }
            }

            if (chkSinglePort.Checked)
            {
                txtPortEnd.Text = txtPortStart.Text;
                ports = new int[] { int.Parse(txtPortStart.Text) };
            }
            else
            {
                int startPort = -1;
                int endPort = -1;
                if (!int.TryParse(txtPortStart.Text, out startPort))
                {
                    MessageBox.Show("请输入有效的开始端口");
                    return;
                }

                if (!int.TryParse(txtPortEnd.Text, out endPort))
                {
                    MessageBox.Show("请输入有效的结束端口");
                    return;
                }

                ports = new int[endPort - startPort + 1];
                for (int port = startPort; port <= endPort; port++)
                {
                    ports[port - startPort] = port;
                }
            }

            Parallel.ForEach(ips, new ParallelOptions() { MaxDegreeOfParallelism = this.numThread }, async (ip) =>
            {
                foreach (int port in ports)
                {
                    var scanResult = await IsPortOpenAsync(LongToIp(ip), port, TimeSpan.FromSeconds(3));
                    if (scanResult != null)
                        WriteLineOutput(scanResult.ToString());
                    Thread.Sleep(200);
                }
            });
        }

        #region IP和long类型的互转
        // <summary>
        ///  将127.0.0.1形式的IP地址转换成十进制整数
        /// </summary>
        /// <param name="strIp"></param>
        /// <returns></returns>
        public long IpToLong(string strIp)
        {
            long[] ip = new long[4];
            int position1 = strIp.IndexOf(".");
            int position2 = strIp.IndexOf(".", position1 + 1);
            int position3 = strIp.IndexOf(".", position2 + 1);
            // 将每个.之间的字符串转换成整型  
            ip[0] = long.Parse(strIp.Substring(0, position1));
            ip[1] = long.Parse(strIp.Substring(position1 + 1, position2 - position1 - 1));
            ip[2] = long.Parse(strIp.Substring(position2 + 1, position3 - position2 - 1));
            ip[3] = long.Parse(strIp.Substring(position3 + 1));
            //进行左移位处理
            return (ip[0] << 24) + (ip[1] << 16) + (ip[2] << 8) + ip[3];
        }

        /// <summary>
        /// 将十进制整数形式转换成127.0.0.1形式的ip地址 
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public string LongToIp(long ip)
        {
            StringBuilder sb = new StringBuilder();
            //直接右移24位
            sb.Append(ip >> 24);
            sb.Append(".");
            //将高8位置0，然后右移16
            sb.Append((ip & 0x00FFFFFF) >> 16);
            sb.Append(".");
            //将高16位置0，然后右移8位
            sb.Append((ip & 0x0000FFFF) >> 8);
            sb.Append(".");
            //将高24位置0
            sb.Append((ip & 0x000000FF));
            return sb.ToString();
        }
        #endregion

        #region IsPortOpen
        /// <summary>
        /// 判断端口是否打开
        /// </summary>
        /// <param name="host">主机</param>
        /// <param name="port">端口</param>
        /// <param name="timeout">等待时间</param>
        /// <returns></returns>
        public async Task<bool> IsPortOpenAsync(string host, int port, int timeout)
        {
            bool isConnected = false;
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    await tcpClient.ConnectAsync(host, port).WithTimeout(timeout);
                    if (tcpClient.Connected)
                        isConnected = true;
                    tcpClient.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"端口 {port} 是关闭的。");
            }
            return isConnected;
        }

        public async Task<PortScanResult> IsPortOpenAsync(string host, int port, TimeSpan timeout)
        {
            PortScanResult isConnectedOut = new PortScanResult(host, port) { IPv4Value = IpToLong(host) };
            var cts = new CancellationTokenSource();
            var connectTask = Task.Run(() =>
            {
                bool isConnected = false;
                try
                {
                    using (TcpClient tcpClient = new TcpClient())
                    {
                        tcpClient.Connect(host, port);
                        if (tcpClient.Connected)
                            isConnected = true;
                        tcpClient.Close();
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine($"端口 {port} 是关闭的。");
                }
                return isConnected;
            });

            try
            {
                // 等待连接完成或超时
                if (await Task.WhenAny(connectTask, Task.Delay(timeout)) == connectTask)
                {
                    // 如果是connectTask先完成，则返回结果
                    isConnectedOut.IsOpen = await connectTask;
                }
                else
                {
                    // 否则取消任务并抛出超时异常
                    cts.Cancel();
                    throw new SocketException((int)SocketError.TimedOut);
                }
            }
            catch (OperationCanceledException)
            {
                throw new SocketException((int)SocketError.TimedOut);
            }
            finally
            {
                cts.Dispose();
            }
            return isConnectedOut;
        }
        #endregion

        #region StartIP,EndIP string to long value
        private long GetIpStartLongFormat(out string errMsg)
        {
            errMsg = "";
            long value = -1;
            string ipStart = this.txtIPStart.Text;
            if (ipStart.Length <= 0)
            {
                errMsg = "请输入有效的开始ip";
                return value;
            }
            if (this.IsValidIP(ipStart))
                value = this.IpToLong(ipStart);
            else
            {
                errMsg = "ipStart 格式不正确";
            }
            return value;
        }

        private long GetIpEndLongFormat(out string errMsg)
        {
            errMsg = "";
            long value = -1;
            string ipEnd = this.txtIPEnd.Text;
            if (ipEnd.Length <= 0)
            {
                errMsg = "请输入有效的结束ip";
                return value;
            }
            if (this.IsValidIP(ipEnd))
                value = this.IpToLong(ipEnd);
            else
            {
                errMsg = "ipStart 格式不正确";
            }
            return value;
        }
        #endregion

        private static readonly string ipv4RegexPattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        private static readonly Regex ipv4Regex = new Regex(ipv4RegexPattern);

        private bool IsValidIP(string ip)
        {
            return ipv4Regex.IsMatch(ip);
        }

        private void WriteLineOutput(string outputLine)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(()=>this.WriteLineOutput(outputLine)));
            else
                this.listBox1.Items.Add(outputLine);
        }
    }

    public static class TaskExtensions
    {
        public static async Task WithTimeout(this Task task, int millisecondsTimeout)
        {
            if (task == await Task.WhenAny(task, Task.Delay(millisecondsTimeout)))
            {
                await task;
            }
            else
            {
                throw new TimeoutException("操作超时。");
            }
        }
    }

    public class PortScanResult
    {
        public int Port { get; set; }

        public bool IsOpen { get; set; }

        public string IPv4 { get; set; }

        public string IPv6 { get; set; }

        public long IPv4Value { get; set; }

        public PortScanResult(string host,int port)
        {
            this.IPv4 = host;
        }

        public override string ToString()
        {
            return $"{{{nameof(IPv4)}={IPv4},{nameof(Port)}={Port.ToString()}, {nameof(IsOpen)}={IsOpen.ToString()}}}";
        }
    }
}
