using UnityEngine;

namespace Patern.Strategy
{
    /// <inheritdoc />
    /// <summary>
    /// Реализация поведения полета. 
    /// </summary>
    public class FlyWithWings: IFlyBehavior
    {
        public void Fly(GameObject model)
        {
            model.transform.Translate(Vector3.up*Time.deltaTime);
        }
    }
}