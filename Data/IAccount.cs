using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace VKTest.Data
{
    public interface IAccount
    {
        #region Auth
        /// <summary>
        /// Логин для авторизации, телефон, почта
        /// </summary>
        [Display(AutoGenerateField = false)]
        string login { get; set; }
        /// <summary>
        /// Пароль, используется для авторизации
        /// </summary>
        [Display(AutoGenerateField = false)]
        string pass { get; set; }
        /// <summary>
        /// При успешной авторизации заполнены
        /// </summary>
        [Display(AutoGenerateField = false)]
        // Dictionary<string, string> cookie { get; set; }
        #endregion
        #region SettingsForConnection
        /// <summary>
        /// Прокси для данного аккаунта
        /// </summary>
        string proxy { get; set; }
        /// <summary>
        /// Юзер агент используемый для выхода на страницу
        /// </summary>
        string userAgent { get; set; }
        #endregion
        #region LoadedInfo
        /// <summary>
        /// Ссылка на страницу (https://www.instagram.com/akhimey/)
        /// </summary>
        string link { get; set; }
        /// <summary>
        /// Ник, имя в соцсети
        /// </summary>
        string nickName { get; set; }
        /// <summary>
        /// Аватар пользователя
        /// </summary>
        Image avatar { get; set; }
        
        /// <summary>
        /// Статус описывающий текущюю задачу
        /// </summary>
        string status { get; set; }
        /// <summary>
        /// Диалоги пользователя
        /// </summary>
        [Display(AutoGenerateField = false)]
        List<Dialog> dialogs { get; set; }
        #endregion
        /// <summary>
        /// Привязанное задание
        /// </summary>
        [Display(AutoGenerateField = false)]
        Task task { get; set; }
        /// <summary>
        /// Задание включено?
        /// </summary>
        bool enabled { get; set; }
        /// <summary>
        /// Черный список, попадают пользователи с которыми уже взаимодействовали
        /// </summary>
        [Display(AutoGenerateField = false)]
        List<string>blackList { get; set; }
        /// <summary>
        /// Дата снятия ограничения по счетчикам
        /// когда аккаунт продолжит работу
        /// </summary>
        [Display(AutoGenerateField = false)]
        DateTime countersLimitDate { get; set; }
        /// <summary>
        /// Авторизация, присваивает значение cookie,
        /// загружает ник, ссылку на страницу, аватар
        /// </summary>
        /// <returns></returns>
        bool Auth();

        #region AtionWithUser
        /// <summary>
        /// Посетить пользователя
        /// </summary>
        /// <param name="id">id или имя страницы</param>
        void VisitUser(string id);
        /// <summary>
        /// Возвращает id пользователей(друзей, подписчиков группы, из строки веб браузера)
        /// Если без параметра возвращает друзей анкеты
        /// </summary>
        /// <param name="id">id пользователя, группы, строка поиска</param>
        /// <returns></returns>
        List<string> GetUserIds(string id = null);
        /// <summary>
        /// Пробует добавить пользователя в друзья
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Статус добавления</returns>
        bool AddToFriends(string id);
        /// <summary>
        /// Пробует лайкнуь аватар указанного пользователя
        /// </summary>
        /// <param name="id">id пользователя</param>
        /// <returns>Статус</returns>
        bool LikeAvatar(string id);
        /// <summary>
        /// Пробует лайкнуь указанное количество записей, указанного пользователя
        /// </summary>
        /// <param name="id">id пользователя</param>
        /// <param name="count">количество лайков</param>
        /// <returns>Количество поставленных лайков</returns>
        byte LikePosts(string id, byte count = 3);
        /// <summary>
        /// Пробует лайкнуть конкретный пост
        /// </summary>
        /// <param name="idPost">Ссылка на пост</param>
        /// <returns>Статус</returns>
        bool LikePost(string idPost);
        #endregion
        #region MessagesAndComments
        bool SendMessage(string id, string msg);
        /// <summary>
        /// Возвращает количество непрочитанных сообщений
        /// </summary>
        /// <returns></returns>
        int CheckMessage();
        /// <summary>
        /// Получает диалоги текущей анкеты
        /// </summary>
        /// <returns></returns>
        List<Dialog> GetDialogs();
        /// <summary>
        /// Получает дилог с указанным пользователем
        /// </summary>
        /// <param name="id">id пользователя</param>
        /// <returns></returns>
        Dialog GetDialog(string id);
        /// <summary>
        /// Оставить комменарий
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool SendComment(string id);
        #endregion

        #region System
        /// <summary>
        /// Сохраняет экземпляр класса
        /// </summary>
        /// <param name="fileName">Путь для сохранения</param>
        /// <returns></returns>
        //bool Save();
        /// <summary>
        /// Загружает сохраненный ранее экземпляр класса
        /// </summary>
        /// <param name="fileName">Путь к загружаемому файлу</param>
        /// <returns></returns>
        //object Open(string fileName);
        #endregion
    }
}
