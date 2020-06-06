namespace HL7Data.Models.Generics
{
    public partial class GenericRepeatedItem
    {
        /*
            This class has different characteristics than the others, which typically are in
            a hierarchy:

                Subcomponent -> Component -> Field -> Segment -> Message -> Package
            or
                Package -> List<Message> -> List<Segment> -> List<Field> -> List<Component> -> Subcomponent

            where MessageHeader is really a segment, but a specialized one with additional info (ParsingInfo, etc.)

            Since the repetition character can be within a Field, Component, or Subcomponent, it really cannot
            fit within the hierarchy of a specific parent/child, but needs to be flexible.

            One option would be to convert all Children properties from IList<T> to IList<IList<T>>. Right now, Plan B
            if implementing this class doesn't work.



         */
    }
}
