using System.Collections.Generic;

namespace prep.utility
{
  public class MatchCreationExtensionPoint<ItemToMatch, PropertyType> : IProvideAccessToCreateMatchers<ItemToMatch, PropertyType>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;
    //IEnumerable<ItemToMatch> items;

    public IProvideAccessToCreateMatchers<ItemToMatch, PropertyType> not
    {
      get { return new NegatingMatchCreationExtensionPoint<ItemToMatch, PropertyType>(this);}
    }

    public IMatchAn<ItemToMatch> create_match_using(IMatchAn<PropertyType> condition)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor, condition);
    }

    //public IEnumerable<ItemToMatch> create_list_using(IMatchAn<PropertyType> condition)
    //{
    //    var match = new PropertyMatch<ItemToMatch, PropertyType>(accessor, condition);
    //    return items.all_items_matching(condition);
    //}

    public MatchCreationExtensionPoint(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    //public MatchCreationExtensionPoint(IEnumerable<ItemToMatch> items, PropertyAccessor<ItemToMatch, PropertyType> accessor)
    //{
    //    this.accessor = accessor;
    //    this.items = items;
    //}
  }
}