using System.Collections.Generic;

namespace CarShop
{
    public class User
    {
        private string Id { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private string Name { get; set; }
        private string Privilege { get; set; }

        /// <summary>
        /// Конструктор присваивания значений полям класса User
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <param name="Name">Имя пользователя</param>
        public User(string Id, string Login, string Password, string Name, string Privilege)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Privilege = Privilege;
        }
        /// <summary>
        /// Возвращение списка данных о пользователе (id, логин, пароль, имя)
        /// </summary>
        /// <returns>Список</returns>
        public List<string> GetUserData()
        {
            List<string> user = new List<string>
            {
                this.Id,
                this.Login,
                this.Password,
                this.Name
            };
            return user;
        }
        /// <summary>
        /// Возвращение Id
        /// </summary>
        /// <returns>ID</returns>
        public string GetId()
        {
            return this.Id;
        }
        /// <summary>
        /// Возвращение логина
        /// </summary>
        /// <returns>Логин</returns>
        public string GetLogin()
        {
            return this.Login;
        }
        /// <summary>
        /// Возвращение пароля
        /// </summary>
        /// <returns>Пароль</returns>
        public string GetPassword()
        {
            return this.Password;
        }
        /// <summary>
        /// Возвращение имени пользователя
        /// </summary>
        /// <returns>Имя</returns>
        public string GetName()
        {
            return this.Name;
        }
        /// <summary>
        /// Возвращение привелегии
        /// </summary>
        /// <returns>Имя</returns>
        public string GetPrivilege()
        {
            return this.Privilege;
        }
    }
}
