using System.Configuration;

namespace Ga.Personal.BackgroundTasks.ClassLibrary
{
    /// <summary>
    /// Класс для работы с конфигурацией библиотеки.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Возвращает строку подключения по имени.
        /// </summary>
        /// <param name="name">Имя строки подключения</param>
        /// <returns>Строка подключения или null, если имя не найдено.</returns>
        public static string GetConnectionStringByName(string name)
        {
            return ConfigurationManager.ConnectionStrings[name]?.ConnectionString;
        }
    }
}
