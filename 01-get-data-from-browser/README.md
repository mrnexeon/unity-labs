# 01 - Обмен данными между браузером и Unity

Цель: Передать строку из браузера в Unity

Мы имеем callback js-функцию `OnUnityReady()` в index.html, которая будет вызвана после загрузки сцены в Unity. Мы также имеем unity-функцию `setText()` из C# скрипта `CamerScript.cs`, который привязан к камере Main Camera.

В функции `OnUnityReady()` получаем строку с сайта https://jsonplaceholder.typicode.com/users и отправляем ее в Unity через внешний вызов функции `setText()` чтобы отобразить текст на экране

## Запуск

Чтобы запустить проект, нужно установить http-server через NPM
```
npm i http-server -g
```
после чего выполнить `cd` в директорию `web-build` и прописать `http-server`. Запуститься сервер, откройте ссылку в браузере.
