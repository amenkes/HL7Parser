namespace HL7Data.Models.Packages
{
    public partial class Package
    {
        /*

        The process was designed so the object(s), when they received data (Source property is set), that it
        manages itself to populate items, recursively, rather than having external methods operate on objects.

        The basic concept is as follows:

        A package is the entire message or messages to be parsed. The element hierarchy is

        Package (has 1-> M) Messages
        Message (has 1-> M) Segments
        Segment (has 1-> M) Fields
            -- A MessageHeader is a specialized segment containing information about the message itself, such as:
                -- Message Type
                -- Parsing Information
                    -- Field Separator
                    -- Escape Character (Not yet implemented)
                    -- Component Separator
                    -- Subcomponent Separator
                    -- Repetition Separator
        Groups (not yet implemented - may not be needed) : See below
        Field (has 0-> M) Components
        Component (has 0-> M) Subcomponents

        The flow of the program is to first get all the string data and parse it into the various generic
        elements listed above, without any validation. Once that is done, in theory, you could grab elements
        based solely on position.

        A message header is always the first segment, and the line must start with MSH, followed by a
        field separator (typically the pipe symbol (|), but could be just about any character),
        followed by component separator (default is caret (^)), then repetition separator (default is tilde (~)),
        the escape character (default is backslash (\)) and finally the subcomponent separator
        (default is ampersand (&)). After another field separator character (|), there are specific data elements
        that have different meanings.

        Knowing this, you could get every piece of information by position. Each element has a Children() property
        and there are helper methods to get the child by position (GetChildByPosition).

        Assuming no null values, you could get, the field separator, as an example, via:

            var data = genericPackage.GetChildByPosition(0).GetChildByPosition(0).GetChildByPosition(1).Value;

        keeping in mind that everything is a 0-based array, so the first element is 0, not 1.
        Also, since each element is an object, to get the string value, simply get the .Value property.

        The sample code above gets the first message, then the first segment, then the 2nd element
        (which is the first element past the MSH), being the field separator.

        However, the processor goes a step further and populates HL7 defined elements using attributes to
        specify the order in which items should be populated and what to ignore. Additionally, there are attributes
        for data validation in terms of required properties, maximum length (currently will truncate if too long for
        the field/property), and other attributes (not fully implemented) in terms of validation against specific
        table or lookup values, conditional fields, etc.

        Using reflection and casting to/from interfaces/classes and strings from the generic elements based on the
        attributes, there is no need to hard-code each and every property for each and every element along with
        converting the data types manually... this is all done generically by casting to/from dynamic types
        and concrete types as well as creating and populating a concrete type based on an interface.

        Since most of the generic elements are similar in terms of the hierarchy (if they have a parent and/or
        child elements), as well as Source, Value and other properties, a lot of the logic was combined to work
        off of BaseGenericElement, passing the generic <T> types to specify items such as the parent type, the child
        type, the interface type, etc. Though subcomponent is typically the last element with children, and a package
        is the first/last element (going up the hierarchy) without a parent, I decided to add 2 extra elements,
        GenericNoParent and GenericNoChildren to actually be the "final" elements at both ends. It could have been
        the same/similar logic with package and subcomponent as to how it handles the parent/child properties, but
        it seemed to make sense at the time, and it works, so I didn't see a reason to change it.

        By keeping everything generic using Generics (<T>), this allows for the code to avoid duplication,
        and only have the differences handled within the class.

        Most of the work happens automatically when the Source property is set on the generic element.
        In addition to running all the common/generic code, it also runs additional methods (empty in the base class)
        that can be overridden and handled in each specific class. ProcessElements is an example of this.

        */

        /*
                Not yet implemented: Groups
                Groups are a grouping of related segments, for example Patient, Next of Kin, Billing info, etc.
        */
    }
}
