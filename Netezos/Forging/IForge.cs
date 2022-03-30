using Netezos.Forging.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Netezos.Forging
{
    public interface IForge
    {
        Task<byte[]> ForgeOperationAsync(string branch, OperationContent content);

        Task<byte[]> ForgeOperationGroupAsync(string branch, IEnumerable<ManagerOperationContent> contents);
    }
}
