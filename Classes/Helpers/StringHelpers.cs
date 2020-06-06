using System.Threading.Tasks;
using HL7Data.Models.Types;

namespace HL7Data.Classes.Helpers
{
    internal static class StringHelpers
    {
        internal static string[] TrimLines(string[] messageLines)
        {
            if (messageLines == null || messageLines.Length == 0) return null;

            for (var i = 0; i < messageLines.Length; i++)
                messageLines[i] = messageLines[i].TrimStart().TrimEnd();
            return messageLines;
        }

        internal static async Task<string[]> TrimLinesAsync(string[] messageLines)
        {
            if (messageLines == null || messageLines.Length == 0) return null;

            for (var i = 0; i < messageLines.Length; i++)
                messageLines[i] = messageLines[i].TrimStart().TrimEnd();
            return await Task.FromResult(messageLines);
        }

        internal static bool IsMessageHeader(string data)
        {
            return !string.IsNullOrWhiteSpace(data) && data.StartsWith(SegmentTypes.MSH.ToString());
        }
    }
}