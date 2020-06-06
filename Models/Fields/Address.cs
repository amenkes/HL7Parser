using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class Address : BaseField //, IAddress //TODO
    {
        public override ElementDataType DataType => ElementDataType.AD;
#if TODO
        AD.1	0	ST	O		    Street Address
        AD.2	0	ST	O		    Other Designation
        AD.3	0	ST	O		    City
        AD.4	0	ST	O		    State Or Province
        AD.5	0	ST	O		    Zip Or Postal Code
        AD.6	3	ID	O	0399	Country
        AD.7	3	ID	O	0190	Address Type
        AD.8	0	ST	O	        Other Geographic Designation
#endif
    }
}