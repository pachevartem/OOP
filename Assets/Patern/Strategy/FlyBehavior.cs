using UnityEngine;

namespace Patern.Strategy
{
    /// <summary>
    /// Интерфейс описывает возможность летать
    /// </summary>
    public interface IFlyBehavior
    {
        void Fly(GameObject model);
    }
}