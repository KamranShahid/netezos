﻿using Dynamic.Json;
using Netezos.Contracts;
using Netezos.Encoding;
using System.IO;
using System.Linq;
using Xunit;

namespace Netezos.Tests.Contracts
{
    public class TestContracts
    {
        [Fact]
        public void TestHumanizeParameters()
        {
            foreach (var address in Directory.GetFiles($@"../../../Contracts/Parameters").Select(x => x.Substring(x.Length - 41, 36)))
            {
                var script = DJson.Read($@"../../../Contracts/Scripts/{address}.json");
                var contract = new ContractScript(Micheline.FromJson((string)script.code));
                var storage = Micheline.FromJson((string)script.storage);

                var storageJson = contract.HumanizeStorage(storage);

                foreach (var sample in DJson.Read($@"../../../Contracts/Parameters/{address}.json"))
                {
                    var rawEntrypoint = sample.raw.entrypoint;
                    var rawValue = Micheline.FromJson(sample.raw.value);

                    var (normEntrypoint, normValue) = contract.NormalizeParameter((string)rawEntrypoint, (IMicheline)rawValue);
                    var humanized = contract.HumanizeParameter(normEntrypoint, normValue);

                    Assert.Equal(
                        ((string)sample.human.value).Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", ""),
                        humanized.Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "").Trim('\"'));
                }
            }
        }
    }
}
