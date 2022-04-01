using Netezos.Encoding;
using Netezos.Forging;
using Netezos.Forging.Models;
using Netezos.Keys;
using Netezos.Rpc;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            _ = NewMethod();
        }

        private async Task<TezosRpc> NewMethod()
        {
            var rpc = new TezosRpc("https://rpc.tzkt.io/ithacanet");
            try
            {
                var bytesOfPublicKey = Base58.Parse(txtPrivateKeytFromTransfer.Text, 4);
                var key = Key.FromBytes(bytesOfPublicKey[0..32]);


                // use this address to receive some tez
                var address = key.PubKey.Address; // tz1SauKgPRsTSuQRWzJA262QR8cKdw1d9pyK

                // get a head block
                var head = await rpc.Blocks.Head.Hash.GetAsync<string>();
                // get account's counter
                var counter = await rpc.Blocks.Head.Context.Contracts[address].Counter.GetAsync<int>();

                var content = new ManagerOperationContent[]
                {
            /*new RevealContent
            {
                Source = address,
                Counter = ++counter,
                PublicKey = key.PubKey.GetBase58(),
                GasLimit = 1500,
                Fee = 1000 // 0.001 tez,
				,StorageLimit = 257
			},*/
            new TransactionContent
            {
                Source = address,
                Counter = ++counter,
                Amount = Int32.Parse( txtAmount.Text) * 1000000, // 1 tez
	            Destination =txtPublicKeyToTransfer.Text,
                GasLimit = 1500,
                Fee = 1000,// 0.001 tez,
                StorageLimit = 257
            }
                };
                var bytes = await new LocalForge().ForgeOperationGroupAsync(head, content);
                byte[] signature = key.SignOperation(bytes);
                // inject the operation and get its id (operation hash)
                var result = await rpc.Inject.Operation.PostAsync(bytes.Concat(signature));
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            return rpc;
        }
    }
}