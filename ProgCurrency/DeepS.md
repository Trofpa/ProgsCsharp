Создание программы для мониторинга курса валют на языке C# также возможно с
использованием API, например, того же Open Exchange Rates.
В C# для работы с HTTP-запросами можно использовать библиотеку
HttpClient, а для парсинга JSON — Newtonsoft.Json (Json.NET).

Шаги для создания программы:

    Получите API ключ:

        Зарегистрируйтесь на Open Exchange Rates и получите API ключ.

    Создайте проект C#:

        Создайте консольное приложение в Visual Studio или любой другой среде разработки.

    Установите необходимые библиотеки:

        Установите библиотеку Newtonsoft.Json для работы с JSON:
        bash
        Copy

        dotnet add package Newtonsoft.Json

    Напишите программу:

        Создайте программу, которая будет запрашивать данные о курсах валют и выводить их.

Пример кода на C#:

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    // Ваш API ключ от Open Exchange Rates
    private const string ApiKey = "ваш_api_ключ";
    private const string BaseUrl = "https://openexchangerates.org/api/latest.json";

    // Список валют, которые мы хотим отслеживать
    private static readonly string[] Currencies = { "USD", "RUB", "TRY" };

    static async Task Main(string[] args)
    {
        while (true)
        {
            await GetExchangeRatesAsync();
            // Проверяем курсы каждые 5 минут
            await Task.Delay(300000); // 300000 мс = 5 минут
        }
    }

    private static async Task GetExchangeRatesAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Формируем URL для запроса
                string requestUrl = $"{BaseUrl}?app_id={ApiKey}";
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonResponse);

                    // Получаем курсы валют
                    JObject rates = (JObject)data["rates"];
                    Console.WriteLine("Актуальные курсы валют:");

                    foreach (string currency in Currencies)
                    {
                        if (rates.ContainsKey(currency))
                        {
                            Console.WriteLine($"1 USD = {rates[currency]} {currency}");
                        }
                        else
                        {
                            Console.WriteLine($"Курс для {currency} недоступен.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

Объяснение кода:

    ApiKey: Ваш ключ от Open Exchange Rates.

    BaseUrl: Базовый URL для запроса актуальных курсов валют.

    Currencies: Список валют, которые мы хотим отслеживать (USD, RUB, TRY).

    GetExchangeRatesAsync(): Асинхронный метод для получения и вывода курсов валют.

    Main(): Основной цикл программы, который проверяет курсы каждые 5 минут.

Запуск программы:

    Сохраните код в файл Program.cs.

    Запустите проект в Visual Studio или через командную строку:
    bash
    Copy

    dotnet run

Дополнительные улучшения:

    Добавьте логирование в файл для сохранения истории курсов.

    Реализуйте уведомления (например, через email или Telegram) при значительных изменениях курса.

    Если нужно отслеживать курсы относительно другой базовой валюты (не USD), измените параметры запроса к API.

Этот пример использует Open Exchange Rates, но вы можете адаптировать его для других API,
таких как CurrencyLayer или любой другой, предоставляющий данные о курсах валют.
