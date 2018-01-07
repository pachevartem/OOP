using UnityEngine;

namespace Patern.Strategy
{
    /// <summary>
    /// Абстрактный класс описывающий Утку
    /// </summary>
    public abstract class Duck
    {
        /// <summary>
        /// Интерфейс описывающий поведение полета
        /// </summary>
        private IFlyBehavior _flyBehavior;
      
        /// <summary>
        /// Ссылка на модель утку GameObject в Unity
        /// </summary>
        private readonly GameObject _model;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="flyBehavior"> Поведение полета </param>
        /// <param name="model"> Ссылка на уточку </param>
        protected Duck(IFlyBehavior flyBehavior, GameObject model)
        {
            _flyBehavior = flyBehavior;
            _model = model;
        }
        
        /// <summary>
        /// Метод запускает полет
        /// </summary>
        public void PerformFly()
        {
            _flyBehavior.Fly(_model);
        }

        /// <summary>
        /// Метод позволяющий сменить поведение полета уточки
        /// </summary>
        /// <param name="behavior"></param>
        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }
    }
}