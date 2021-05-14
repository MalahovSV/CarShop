using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace AutorisationForm
{
    public class Settings
    {
        public Color MouseEnter ()
        {
            return Color.FromArgb(0xff5d00);
        }
        public Color MouseLeave()
        {
            return Color.FromArgb(0x8E8D8A);
        }
        public Color MouseEnterClosed()
        {
            return Color.Red;
        }

        /// <summary>
        /// Чтение записи из кофигуратора SQL строки
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        public string ReadSettingSqlConnection()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings["SqlConnection"] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// Чтение записи из кофигуратора
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";                
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// Добавление записи в конфигуратор
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        /// <param name="value">Значение</param>
        public void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                MessageBox.Show("Успешно", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error writing app settings", "System", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
