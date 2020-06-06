using HL7Data.Classes.ExtensionMethods;
using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HL7Data.Models.Generics
{
    public abstract class BaseGenericElement<TGenericCurrent, TGenericChild, TGenericChildInterface, TGenericParent> :
        IGenericElement<TGenericCurrent, TGenericChildInterface, TGenericParent>
        where TGenericCurrent : IGenericRootItem, IHasGenericRepeatedItems
        where TGenericChild : TGenericChildInterface, IGenericRootItem, IHasParent<TGenericCurrent>, new()
        where TGenericChildInterface : IGenericRootItem, IHasParent<TGenericCurrent>
        where TGenericParent : IHasChildren<TGenericCurrent>, IGenericRootItem
    {
        private string[] _dataArrayAdditionalProcessing;
        private IParsingInfo _parsingInfo;
        private string _source;
        private string _value;
        private IList<string> _parsingInfoIgnoreList;

        public virtual IList<TGenericChildInterface> Children { get; set; }

        public IList<TGenericCurrent> GetRepeatedItems()
        {
            return !GenericRepeatedItem.HasChildren ? new List<TGenericCurrent>() : GenericRepeatedItem.Children.ToList().Cast<TGenericCurrent>().ToList();
        }

        public IGenericRepeatedItem GenericRepeatedItem { get; set; }

        public virtual TGenericParent Parent { get; set; }
        public IParsingInfo ParsingInfo
        {
            get => _parsingInfo;
            set
            {
                _parsingInfo = value;
                _parsingInfoIgnoreList = GetIgnoreList();

            }
        }
        public virtual IElement ReferenceElement { get; set; }
        public TGenericCurrent Self { get; set; }
        public virtual string SeparatorCharacter => ParsingInfo?.FieldSeparator;

        public virtual string Source
        {
            get => _source;
            set
            {
                _source = value; // Set this first.
                //TODO:watch 2ms - 1st time, ticks after
                if (ParsingInfo == null)
                    SetParsingInfo(value);
                //TODO:watch ticks
                SetSelf<TGenericCurrent>();
                //TODO:watch 16ms
                ProcessData<TGenericCurrent, TGenericChild>(_source);
                //TODO:watch ticks
                ProcessElements(_dataArrayAdditionalProcessing);
            }
        }

        // Only use (rarely) when trying to bypass the method calls on Source.
        // For cases where source already set and processed but need different data stored
        public void SetSourceDirect(string data)
        {
            _source = data;
        }

        public virtual string Value
        {
            get => _value = GetValue();
            set => _value = value;
        }

        public virtual TGenericChildInterface GetChildByPosition(int position)
        {
            return Children == null || Children.Count < position ? default(TGenericChildInterface) : Children[position];
        }

        protected virtual string GetValue()
        {
            if (Children == null || Children.Count == 0) return _value ?? Source;
            if (Children.Count == 1)
            {
                var firstChild = Children.First();
                return firstChild.Value ?? firstChild.Source ?? Source;
            }

            // Check child properties
            if (Children.Select(λ => λ.Value).Any(λ => _parsingInfoIgnoreList.Contains(λ)))
                return _value ?? _source;

            return string.Join(SeparatorCharacter, Children.Select(λ => λ.Value ?? λ.Source ?? SeparatorCharacter));
        }

        protected virtual void ProcessData<TGenericCurrentItem, TGenericChildItem>(string data)
        {
            _dataArrayAdditionalProcessing = null;

            Children = new List<TGenericChildInterface>();
            if (data == null) return;

            string[] dataArray;
            if (data.Length == 1 && ParsingInfo.ToString().Contains(data))
                dataArray = new[] { data };
            else if (data == ParsingInfo.ToString() || data == ParsingInfo.EncodingCharacters.ToString())
                dataArray = data.Select(λ => λ.ToString()).ToArray();
            else
                dataArray = data.ToSeparatorArray(SeparatorCharacter);

            if (dataArray == null || dataArray.Length == 0) return;

            if (typeof(TGenericCurrentItem) == typeof(IGenericPackage))
            {
                _dataArrayAdditionalProcessing = dataArray;
                return;
            }

            var genericDataArray = new TGenericChildInterface[dataArray.Length];
            //TODO:watch ticks
            Parallel.For(0, genericDataArray.Length, async i =>
            {
                if (!StringHelpers.IsMessageHeader(dataArray[i]) && !IsParsingInfo(dataArray[i]) && dataArray[i].Contains(ParsingInfo.EncodingCharacters.RepetitionSeparator))
                {
                    var childItems = await ProcessGenericChildElements(dataArray[i]);
                    var genericRepeatedItem = new GenericRepeatedItem {ParsingInfo = ParsingInfo, Source = dataArray[i]};
                    var rootItemList = childItems.Cast<IGenericRootItem>().ToList();
                    genericRepeatedItem.SetChildren(rootItemList);

                    // Create Generic Child placeholder which contains the "children" which are really not children,
                    // but the multiple item (IList) replacements for the current item placeholder.
                    var genericChild = new TGenericChild{ParsingInfo = ParsingInfo};
                    if (genericChild is IHasGenericRepeatedItems)
                    {
                        var castItem = genericChild as IHasGenericRepeatedItems;
                        castItem.GenericRepeatedItem = genericRepeatedItem;
                    }
                    genericDataArray[i] = genericChild;
                }
                else
                {
                    var genericChild = await ProcessGenericChildElement(dataArray[i]);
                    genericDataArray[i] = genericChild;
                    genericChild.Parent = Self;
                }
            });
            Children = genericDataArray.ToList();
        }

        protected virtual void ProcessElements(string[] additionalData)
        {
        } // Override for specific subclasses only

        protected virtual async Task<IList<TGenericChildInterface>> ProcessGenericChildElements(string data)
        {
            var items = data.ToSeparatorArray(ParsingInfo.EncodingCharacters.RepetitionSeparator);
            var list = new List<TGenericChildInterface>();
            foreach (var item in items)
            {
                var result = await ProcessGenericChildElement(item);
                list.Add(result);
            }
            return await Task.FromResult(list);
        }

        protected virtual async Task<TGenericChildInterface> ProcessGenericChildElement(string data)
        {
            var item = new TGenericChild
            {
                Parent = Self,
                ParsingInfo = ParsingInfo,
                Source = data
            };
            return await Task.FromResult(item);
        }

        protected virtual void SetParsingInfo(string data)
        {
            if (!StringHelpers.IsMessageHeader(data)) return;
            ParsingInfo = ParsingInfo ?? new ParsingInfo(data);
            _parsingInfoIgnoreList = GetIgnoreList();
        }

        protected abstract void SetSelf<T>();

        private IList<string> GetIgnoreList()
        {
            return new List<string>
            {
                ParsingInfo.FieldSeparator,
                ParsingInfo.EncodingCharacters.ComponentSeparator,
                ParsingInfo.EncodingCharacters.RepetitionSeparator,
                ParsingInfo.EncodingCharacters.EscapeCharacter,
                ParsingInfo.EncodingCharacters.SubcomponentSeparator
            };
        }

        private bool IsParsingInfo(string data)
        {
            return _parsingInfoIgnoreList.Contains(data) || string.Join(string.Empty, _parsingInfoIgnoreList).Contains(data);
        }

    }
}