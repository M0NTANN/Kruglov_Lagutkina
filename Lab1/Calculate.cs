
namespace Lab1
{
    /// <summary>
    /// Функция вычисления скорости
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">Время</param>
        /// <param name="speed">Скорость</param>
        /// <returns></returns>
        public static int CalculateSpeed(double time, double speed)
        {
            CheckValues(time);
            var distance = Convert.ToInt32(time * speed);
            return distance;
        }
        public static void CheckValues(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(String.Format("", value),"eyeye");    
            }
        }
    }
}