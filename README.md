<h1>Restoraunt True Cost</h1>

<p>Этот проект является дипломной работой, посвященной реализации алгоритма "True Cost" для автоматизации работы сети ресторанов.</p>

<h2>Предварительные требования</h2>

<p>Перед запуском проекта убедитесь, что у вас установлены следующие программные средства:</p>

<ul>
<li>PostgreSQL 15 и выше</li>
<li>pgAdmin 4</li>
<li>Visual Studio 2019 и выше (необходимо установить пакеты для работы с ASP.NET Core в Visual Studio Installer)</li>
<li>.NET 7.0 runtime</li>
</ul>

<h2>Начало работы</h2>

<p>Для запуска проекта выполните следующие шаги:</p>

<ol>
<li>Клонируйте этот репозиторий на ваше локальное устройство.</li>
<li>Установите строку подключения к вашему серверу PostgreSQL в файле <code>appsettings.json</code>, который находится в проекте Server:
<code>
"ConnectionStrings": {
"RestorauntDb": "Server=localhost;Database=yourdatabase;Port=5432;User Id=postgres;Password=yourpassword"
}
</code>
</li>
<li><code>Server</code> - название сервера в PostgreSQL</li>
<li><code>Databse</code> - название создаваемой базы данных (можно выбрать любое)</li>
<li><code>Port</code> - порт сервера PostgreSQL</li>
<li><code>User Id</code> - логин пользователя сервера PostgreSQL</li>
<li><code>Password</code> - пароль пользователя сервера PostgreSQL</li>
<li>Соберите и запустите проект. Это создаст необходимую структуру базы данных.</li>
<li>В папке <code>Samples</code> проекта Server вы найдете скрипт. Скопируйте содержимое скрипта и примените его к созданной базе данных. Это можно сделать с помощью Query Tools в pg Admin (нажмите на созданную базу данных, в выпадающем списке выберите Query Tools, вставьте скрипт и запустите его).</li>
</ol>

<h2>Вклад</h2>

<p>Вклад в проект приветствуется! Если вы обнаружили какие-либо проблемы или у вас есть предложения по улучшению, пожалуйста, не стесняйтесь открывать issue или отправлять pull request.</p>

<h2>Лицензия</h2>

<p>Этот проект лицензируется в соответствии с <a href="LICENSE">MIT License</a>.</p>

<h1>Тестовые данные</h1>

<p>Аккаунты, содержащиеся в скрипте в папке Samples:</p>

<ol>
<li>
<strong>Администратор:</strong>
<ul>
<li>Логин: admin@example.com</li>
<li>Пароль: Admin123</li>
</ul>
</li>
<li>
<strong>Менеджер:</strong>
<ul>
<li>Логин: manager@example.com</li>
<li>Пароль: Manager123</li>
</ul>
</li>
<li>
<strong>Пользователь:</strong>
<ul>
<li>Логин: user@example.com</li>
<li>Пароль: User123</li>
</ul>
</li>
</ol>
