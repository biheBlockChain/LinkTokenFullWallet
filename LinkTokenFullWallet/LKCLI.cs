using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    class LKCLI
    {
        public static void Init()
        {
            Methods.Common.UnGzipFile(GlobalVar.state_db_local_path, GlobalVar.lk_init_data);
            Methods.Common.CopyDirectory(GlobalVar.lk_init_data + @"\state.db", GlobalVar.lk_data_path + @"\ethermint\chaindata");
            ihslib.FileHandle.FileHelper.Copy(GlobalVar.lk_init_data + @"\genesis.json", GlobalVar.lk_data_path + @"\tendermint\genesis.json");
        }

        public static Process InitEthermint()
        {
            var argsString = $"--datadir {GlobalVar.lk_data_path} ";
            argsString += $"--lkonline --verbosity 5 ";
            argsString += $"--log_file {GlobalVar.lk_log_path}\\ethermint.log ";
            argsString += $"init -lkstate={GlobalVar.lk_init_data}\\state.db";

            var p = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = GlobalVar.lk_bin_path + @"\ethermint.exe",
                    Arguments = argsString
                }
            };
            //Console.WriteLine(argsString);
            //Console.WriteLine(Application.StartupPath);
            //Console.WriteLine(minerProcess.StartInfo.FileName);
            //Console.WriteLine(Path.Combine(Application.StartupPath, @"\core\Claymore\EthDcrMiner64.exe"));
            p.OutputDataReceived += (s, e) => InitEthermintProcess_OutputDataReceived(e);
            p.ErrorDataReceived += (s, e) => InitEthermintProcess_ErrorDataReceived(e);
            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(InitEthermintProcess_Exited);
            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            return p;
        }

        private static void InitEthermintProcess_ErrorDataReceived(DataReceivedEventArgs e)
        {
            Console.WriteLine("ErrorDataReceived" + e.Data);
        }

        private static void InitEthermintProcess_OutputDataReceived(DataReceivedEventArgs e)
        {
            Console.WriteLine("OutputDataReceived:" + e.Data);
        }

        private static void InitEthermintProcess_Exited(object sender, EventArgs e)
        {
            ((FormMain)Application.OpenForms["FormMain"]).LogMessage("Ethermint Exit.init success.");
        }

        public static Process InitTendermint()
        {
            var argsString = $"init --home {GlobalVar.lk_data_path}\\tendermint ";
            argsString += $"--chain_id chain --genesis genesis.json";

            var p = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = GlobalVar.lk_bin_path + @"\tendermint.exe",
                    Arguments = argsString
                }
            };
            //Console.WriteLine(argsString);
            //Console.WriteLine(Application.StartupPath);
            //Console.WriteLine(minerProcess.StartInfo.FileName);
            //Console.WriteLine(Path.Combine(Application.StartupPath, @"\core\Claymore\EthDcrMiner64.exe"));
            p.OutputDataReceived += (s, e) => InitTendermintProcess_OutputDataReceived(e);
            p.ErrorDataReceived += (s, e) => InitTendermintProcess_ErrorDataReceived(e);
            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(InitTendermintProcess_Exited);
            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            return p;
        }

        private static void InitTendermintProcess_ErrorDataReceived(DataReceivedEventArgs e)
        {
            Console.WriteLine("ErrorDataReceived" + e.Data);
        }

        private static void InitTendermintProcess_OutputDataReceived(DataReceivedEventArgs e)
        {
            Console.WriteLine("OutputDataReceived:" + e.Data);
        }

        private static void InitTendermintProcess_Exited(object sender, EventArgs e)
        {
            ((FormMain)Application.OpenForms["FormMain"]).LogMessage("Tendermint Exit.init success.");
        }


        public static void Start()
        {
            if (IsRunning())
            {
                return;
            }
            var nodename = "peer_1";
            var ethrpcport = 44000;
            var ethabciport = 43000;
            var tendrpcport = 41000;
            var tendp2pport = 42000;//和主节点通讯
            var ethsubport = 45000;
            var peerseeds = "\"\""; //peers to connect

            var emptyBlockInterval = 300;
            var blockInterval = 1000;
            var blockWarnInterval = 350;

            var argsEthermint = $"--datadir {GlobalVar.lk_data_path} ";
            argsEthermint += $"--rpc --rpcaddr=0.0.0.0 --rpcapi eth,net,web3,personal,admin ";
            argsEthermint += $"--abci_laddr tcp://127.0.0.1:{ethabciport} ";
            argsEthermint += $"--tendermint_addr tcp://127.0.0.1:{tendrpcport} ";
            argsEthermint += $"--rpcport {ethrpcport} --lkrpc_addr 0.0.0.0:{ethsubport} ";
            argsEthermint += $"--no_block_create_interval {blockWarnInterval} --verbosity 5 ";
            argsEthermint += $"--log_file {GlobalVar.lk_log_path}\\ethermint.log ";
            argsEthermint += $"node >>{GlobalVar.lk_log_path}\\ether.log";
            Console.WriteLine(argsEthermint);
            var p_ethermint = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = GlobalVar.lk_bin_path + @"\ethermint.exe",
                    Arguments = argsEthermint
                }
            };

            p_ethermint.OutputDataReceived += (s, e) => StartProcess_OutputDataReceived(e);
            p_ethermint.ErrorDataReceived += (s, e) => StartProcess_ErrorDataReceived(e);
            p_ethermint.EnableRaisingEvents = true;
            p_ethermint.Exited += new EventHandler(StartProcess_Exited);
            p_ethermint.Start();
            p_ethermint.BeginOutputReadLine();
            p_ethermint.BeginErrorReadLine();

            var argsTendermint = $"--home {GlobalVar.lk_data_path}\\tendermint ";
            argsTendermint += $"--rpc.laddr tcp://0.0.0.0:{tendrpcport} ";
            argsTendermint += $"--proxy_app tcp://127.0.0.1:{ethabciport} ";
            argsTendermint += $"--p2p.laddr tcp://0.0.0.0:{tendp2pport} --p2p.pex=1 --p2p.seeds {peerseeds} ";
            argsTendermint += $"--eth_rpcaddr http://127.0.0.1:{ethrpcport} --moniker {nodename} ";
            argsTendermint += $"--consensus.create_empty_blocks_interval {emptyBlockInterval} ";
            argsTendermint += $"--consensus.timeout_commit {blockInterval} ";
            argsTendermint += $"--log_level info --log_file {GlobalVar.lk_log_path}\\tendermint.log ";
            argsTendermint += $"node >>{GlobalVar.lk_log_path}\\tender.log";
            Console.WriteLine(argsTendermint);
            var p_tendermint = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = GlobalVar.lk_bin_path + @"\tendermint.exe",
                    Arguments = argsTendermint
                }
            };

            p_tendermint.OutputDataReceived += (s, e) => StartProcess_OutputDataReceived(e);
            p_tendermint.ErrorDataReceived += (s, e) => StartProcess_ErrorDataReceived(e);
            p_tendermint.EnableRaisingEvents = true;
            p_tendermint.Exited += new EventHandler(StartProcess_Exited);
            p_tendermint.Start();
            p_tendermint.BeginOutputReadLine();
            p_tendermint.BeginErrorReadLine();
        }

        public static void Restart()
        {
            Stop();
            Start();
        }

        private static void StartProcess_Exited(object sender, EventArgs e)
        {
            ((FormMain)Application.OpenForms["FormMain"]).LogMessage("Link Node Exit.");
        }

        private static void StartProcess_ErrorDataReceived(DataReceivedEventArgs e)
        {
            //Console.WriteLine("ErrorDataReceived" + e.Data);
            ((FormMain)Application.OpenForms["FormMain"]).LogMessage("ErrorDataReceived:" + e.Data);
        }

        private static void StartProcess_OutputDataReceived(DataReceivedEventArgs e)
        {
            //Console.WriteLine("OutputDataReceived:" + e.Data);
            ((FormMain)Application.OpenForms["FormMain"]).LogMessage("OutputDataReceived:" + e.Data);
        }

        public static void Stop()
        {
            var p1 = Process.GetProcessesByName("ethermint");
            var p2 = Process.GetProcessesByName("tendermint");
            foreach (var item in p1)
            {
                item.Kill();
            }
            foreach (var item in p2)
            {
                item.Kill();
            }
        }

        public static bool IsRunning()
        {
            var p1 = Process.GetProcessesByName("ethermint");
            var p2 = Process.GetProcessesByName("tendermint");
            if (p1.Length > 0 && p2.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
