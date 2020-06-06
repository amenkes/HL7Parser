using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Generics;
using System.Threading.Tasks;

namespace HL7Data.Services.Import
{
    public static class ImportService
    {
        public static IGenericPackage ImportHL7(string data)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);
            var package = new GenericPackage(data);
            return package;
        }

        public static async Task<IGenericPackage> ImportHL7Async(string data)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);

            //TODO:watch seconds
            //var watch = new Stopwatch();
            //watch.Start();
            var genericPackage = new GenericPackage {Source = data};
            //watch.Stop();
            return await Task.FromResult(genericPackage);
        }
    }
}