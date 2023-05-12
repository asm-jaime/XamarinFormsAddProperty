# XamarinFormsAddProperty

Представим себе ситуацию, что у класса Button в Xamarin.Forms/MAUI (без разницы) отсутствует свойство цвета кнопки BackgroundColor. Как бы ты добавил свойство в существующий контрол? При этом это свойство должно заработать как в iOS, так и в Android.

Добавим класс ExtendedButtonRenderer в главный проект.
Создадим также ExtendedButtonRenderer класс в android и ios проектах.

Внутри Android renderer-а допишем:
Control.SetBackgroundColor(Color.Blue.ToAndroid());

По умолчанию Background должен быть Red.

Смотрим что выводится на эмуляторе:

![android blue button](docs/android-custom-button-background.png)
