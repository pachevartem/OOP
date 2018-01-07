using UnityEngine;

namespace Patern.Strategy
{
    /// <inheritdoc />
    /// <summary>
    /// Класс опысывает конкретную уточку. 
    /// </summary>
    public class YellowDuck: Duck
    {
        public YellowDuck(IFlyBehavior flyBehavior, GameObject model) : base(flyBehavior, model)
        {
        }
        
    }
}