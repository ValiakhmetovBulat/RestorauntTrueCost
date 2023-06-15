&lt;h1&gt;Restoraunt True Cost&lt;/h1&gt;

&lt;p&gt;Этот проект является дипломной работой, посвященной реализации алгоритма "True Cost" для автоматизации работы сети ресторанов.&lt;/p&gt;

&lt;h2&gt;Предварительные требования&lt;/h2&gt;

&lt;p&gt;Перед запуском проекта убедитесь, что у вас установлены следующие программные средства:&lt;/p&gt;

&lt;ul&gt;
  &lt;li&gt;PostgreSQL 15 и выше&lt;/li&gt;
  &lt;li&gt;pgAdmin 4&lt;/li&gt;
  &lt;li&gt;Visual Studio 2019 и выше (необходимо установить пакеты для работы с ASP.NET Core в Visual Studio Installer)&lt;/li&gt;
  &lt;li&gt;.NET 7.0 runtime&lt;/li&gt;
&lt;/ul&gt;

&lt;h2&gt;Начало работы&lt;/h2&gt;

&lt;p&gt;Для запуска проекта выполните следующие шаги:&lt;/p&gt;

&lt;ol&gt;
  &lt;li&gt;Клонируйте этот репозиторий на ваше локальное устройство.&lt;/li&gt;
  &lt;li&gt;Установите строку подключения к вашему серверу PostgreSQL в файле &lt;code&gt;appsettings.json&lt;/code&gt;, который находится в проекте Server:
  &lt;code&gt;
    "ConnectionStrings": {
    "RestorauntDb": "Server=localhost;Database=yourdatabase;Port=5432;User Id=postgres;Password=yourpassword"
  }
  &lt;/code&gt;
  &lt;/li&gt;
  &lt;li&gt;&lt;code&gt;Server&lt;/code&gt; - название сервера в PostgreSQL&lt;/li&gt;
  &lt;li&gt;&lt;code&gt;Databse&lt;/code&gt; - название создаваемой базы данных (можно выбрать любое)&lt;/li&gt;
  &lt;li&gt;&lt;code&gt;Port&lt;/code&gt; - порт сервера PostgreSQL&lt;/li&gt;
  &lt;li&gt;&lt;code&gt;User Id&lt;/code&gt; - логин пользователя сервера PostgreSQL&lt;/li&gt;
  &lt;li&gt;&lt;code&gt;Password&lt;/code&gt; - пароль пользователя сервера PostgreSQL&lt;/li&gt;
  &lt;li&gt;Соберите и запустите проект. Это создаст необходимую структуру базы данных.&lt;/li&gt;
  &lt;li&gt;В папке &lt;code&gt;Samples&lt;/code&gt; проекта Server вы найдете скрипт. Скопируйте содержимое скрипта и примените его к созданной базе данных. Это можно сделать с помощью Query Tools в pg Admin (нажмите на созданную базу данных, в выпадающем списке выберите Query Tools, вставьте скрипт и запустите его

).&lt;/li&gt;
&lt;/ol&gt;

&lt;h2&gt;Вклад&lt;/h2&gt;

&lt;p&gt;Вклад в проект приветствуется! Если вы обнаружили какие-либо проблемы или у вас есть предложения по улучшению, пожалуйста, не стесняйтесь открывать issue или отправлять pull request.&lt;/p&gt;

&lt;h2&gt;Лицензия&lt;/h2&gt;

&lt;p&gt;Этот проект лицензируется в соответствии с &lt;a href="LICENSE"&gt;MIT License&lt;/a&gt;.&lt;/p&gt;

&lt;h1&gt;Тестовые данные&lt;/h1&gt;

&lt;p&gt;Аккаунты, содержащиеся в скрипте в папке Samples:&lt;/p&gt;

&lt;ol&gt;
  &lt;li&gt;
    &lt;strong&gt;Администратор:&lt;/strong&gt;
    &lt;ul&gt;
      &lt;li&gt;Логин: admin@example.com&lt;/li&gt;
      &lt;li&gt;Пароль: Admin123&lt;/li&gt;
    &lt;/ul&gt;
  &lt;/li&gt;
  &lt;li&gt;
    &lt;strong&gt;Менеджер:&lt;/strong&gt;
    &lt;ul&gt;
      &lt;li&gt;Логин: manager@example.com&lt;/li&gt;
      &lt;li&gt;Пароль: Manager123&lt;/li&gt;
    &lt;/ul&gt;
  &lt;/li&gt;
  &lt;li&gt;
    &lt;strong&gt;Пользователь:&lt;/strong&gt;
    &lt;ul&gt;
      &lt;li&gt;Логин: user@example.com&lt;/li&gt;
      &lt;li&gt;Пароль: User123&lt;/li&gt;
    &lt;/ul&gt;
  &lt;/li&gt;
&lt;/ol&gt;
