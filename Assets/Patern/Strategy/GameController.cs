using UnityEngine;

namespace Patern.Strategy
{
    /// <summary>
    /// Класс описывающий работу игры. Точка входа.
    /// </summary>
    public class GameController: MonoBehaviour
    {
        /// <summary>
        /// Ссылка на объект
        /// </summary>
        public GameObject DuckObj;
       
        /// <summary>
        /// Класс опиывающий уточку
        /// </summary>
        private Duck _firstDuck;
        
        private void Awake()
        {
            _firstDuck = new YellowDuck(new FlyWithWings(), DuckObj); //Создаем конкретную уточку, которая умеет летать
        }

        /// <summary>
        /// Переменная нужна для реализации переключателя
        /// </summary>
        private int _k = 0;

        /// <summary>
        /// Переключатель поведения. Может быть реализован очень очень по разному
        /// </summary>
        void Switcher()
        {
            _k ++ ;
            if (_k%2!=0)
            {
                _firstDuck.SetFlyBehavior(new FlyNoWays());
            }
            else
            {
                _firstDuck.SetFlyBehavior(new FlyWithWings());
            } 
        }

        private void Update()
        {
            _firstDuck.PerformFly(); // Независимо от реализации метод будет вызван. Демонстрация инкапсуляции вызова метода.
            
            if (Input.GetMouseButtonDown(0))
            {
                Switcher();
            }
        }

    }
}