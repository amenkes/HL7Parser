using HL7Data.Classes.Helpers;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Factory;
using HL7Data.Contracts.Generics;
using HL7Data.Services.Parsing;
using System.Threading.Tasks;

namespace HL7Data.Factory.Base
{
    /// <summary>
    ///     Abstract Factory to create various types (Segment, Messages, Message Headers, Trigger Events, etc.
    /// </summary>
    /// <typeparam name="TFactory">The factory type. Typically pass "self"</typeparam>
    /// <typeparam name="TType">Return type from GetParameterType which gets passed as parameter to GetElementFromType</typeparam>
    /// <typeparam name="TElementType">Return type from GetElementFromType</typeparam>
    /// <typeparam name="TGenericElement">Parameter to CreateAsync</typeparam>
    /// <typeparam name="TResultType">Return type from CreateAsync</typeparam>
    public abstract class AbstractFactory<TFactory, TType, TElementType, TGenericElement, TResultType> : BaseFactory<TFactory>
        //Note: DO NOT specify conditions for TType, as it could be struct (enum) or class or Interface.
        where TFactory : class, IFactory, new()
        where TElementType : class, IElement
        where TGenericElement : class, IGenericRootItem // where TType : struct where TElementType : class
        where TResultType : IElement, TElementType
    {
        public virtual async Task<TResultType> CreateAsync(TGenericElement genericElement)
        {
            Ensure.ArgumentNotNull(nameof(genericElement), genericElement);

            //TODO:watch ticks
            var type = await GetParameterType(genericElement);
            //var watch = new Stopwatch();
            //watch.Start();
            //TODO:watch : SECONDS - FIX THIS
            var element = await GetElementFromType(type, genericElement);
            //watch.Stop();
            if (element == null) return default(TResultType); //new ErrorMessage(); //TODO: populate with some info of some sort

            var castElement = (TResultType) element;
            ParsingService.UpdateReferences(castElement, genericElement);
            return await Task.FromResult(castElement);
        }

        /// <summary>
        ///     Gets the return type from the generic element to pass to GetElementFromType
        /// </summary>
        /// <param name="genericElement"></param>
        /// <returns></returns>
        public abstract Task<TType> GetParameterType(TGenericElement genericElement);

        /// <summary>
        ///     Gets the concrete element (segment, message, message header, etc.) but as it's interface type.
        /// </summary>
        /// <param name="type">The custom type parameter</param>
        /// <param name="genericElement">The generic element from which to create the type</param>
        /// <returns></returns>
        public abstract Task<TElementType> GetElementFromType(TType type, TGenericElement genericElement);
    }
}