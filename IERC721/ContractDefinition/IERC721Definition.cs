using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Millow.Contracts.IERC721.ContractDefinition
{


    public partial class IERC721Deployment : IERC721DeploymentBase
    {
        public IERC721Deployment() : base(BYTECODE) { }
        public IERC721Deployment(string byteCode) : base(byteCode) { }
    }

    public class IERC721DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public IERC721DeploymentBase() : base(BYTECODE) { }
        public IERC721DeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "_from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_id", 3)]
        public virtual BigInteger Id { get; set; }
    }


}
