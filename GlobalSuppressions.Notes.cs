namespace HL7Data
{
    // ReSharper disable once PartialTypeWithSinglePart
    public partial class GlobalSuppressions
    {
        /*
         Typically, collections would be read only and handled as described here:
         https://docs.microsoft.com/en-us/visualstudio/code-quality/ca2227-collection-properties-should-be-read-only

        However, due to the way in which reflection is being used to update the properties, a decision was made to handle
        it the same way as updating standard properties, whether string, int, class, interface or collection of anything.

        */
    }
}
