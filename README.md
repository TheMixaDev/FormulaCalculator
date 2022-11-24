# FormulaCalculator
Программа для вычисления формул Бернулли, Байеса и полной вероятности.

# О программе
Программа для проведения вычислений написана в качестве веб-страницы с использованием языка программирования JavaScript без использования дополнительных инструментов.
Для удобства использования, чтобы не использовать браузер, был создан порт программы с использованием языка программирования C# с .Net Framework и реализацией окон приложения с помощью Windows Forms.
Для запуска написанной программы в порте использовалась библиотека CefSharp для встраивания Chromium с целью отображения веб-страниц, их стилей и скриптов JavaScript внутри отдельного оконного приложения, и библиотека Costura.Fody для минимизации количества выходных библиотек dll.
Для запуска порта необходима [Microsoft Visual Studio Redistributable](https://learn.microsoft.com/ru-ru/cpp/windows/latest-supported-vc-redist?view=msvc-170) минимум 2015 года. Исполняемый файл: `Calculator.exe`.
В случае проблем с запуском порта приложения, можно воспользоваться запуском через браузер с использованием HTML страницы, расположенной в "data/index.html" или воспользоваться [онлайн версией приложения](https://themixadev.github.io/formulacalculator/).
Работоспособность программы проверялась на Windows 10 и Windows 11, а так же в веб-браузере Google Chrome.

# Использование и установка
Онлайн версия доступна по ссылке: https://themixadev.github.io/formulacalculator/

Так же доступны порты на персональные компьютеры, скачивание которых доступно в [релизе C# приложения](https://github.com/TheMixaDev/FormulaCalculator/releases/tag/Release).

Тип процессора | Ссылка для скачивания
--- | ---
Любой процессор | [Скачать](https://github.com/TheMixaDev/FormulaCalculator/releases/download/Release/FormulaCalculator-anycpu.zip)
x64 | [Скачать](https://github.com/TheMixaDev/FormulaCalculator/releases/download/Release/FormulaCalculator-x64.zip)
x86 | [Скачать](https://github.com/TheMixaDev/FormulaCalculator/releases/download/Release/FormulaCalculator-x86.zip)
ARM64 | [Скачать](https://github.com/TheMixaDev/FormulaCalculator/releases/download/Release/FormulaCalculator-arm64.zip)

Для запуска порта необходимо разархивировать скачанный .zip файл, и открыть `Calculator.exe`, требуется установленный [пакет Microsoft Visual Studio C++](https://learn.microsoft.com/ru-ru/cpp/windows/latest-supported-vc-redist?view=msvc-170) минимум 2015 года.

# Авторство
Программа написана _Михаилом Беляевым_ для статьи _Быстровой Дарьи_ на тему "Применение теории вероятности в ветеринарии"
