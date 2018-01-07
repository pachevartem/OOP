using UnityEngine;

namespace Patern.Strategy
{
    /// <summary>
    /// Интерфейс описывает состояние покоя. Реализация пустово метода. 
    /// </summary>
    public class FlyNoWays: IFlyBehavior
    {
        public void Fly(GameObject model)
        {
            
        }
    }
}