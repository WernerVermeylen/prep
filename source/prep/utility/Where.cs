using System.Collections.Generic;

namespace prep.utility
{
  public class Where<ItemToMatch>
  {
    public static MatchCreationExtensionPoint<ItemToMatch, PropertyType> has_a<PropertyType>(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchCreationExtensionPoint<ItemToMatch, PropertyType>(accessor);
    }

    //public static MatchCreationExtensionPoint<ItemToMatch, PropertyType> has_a<PropertyType>(IEnumerable<ItemToMatch> items, PropertyAccessor<ItemToMatch, PropertyType> accessor)
    //{
    //    return new MatchCreationExtensionPoint<ItemToMatch, PropertyType>(items, accessor);
    //}
  }
}