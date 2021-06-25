using System;
using YoutubeExplode;
using System.Threading.Tasks;
using YoutubeExplode.Converter;

namespace ConsoleAppModul18_Youtube
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        YoutubeClient youtube = new YoutubeClient();

        /// <summary>
        /// Получение информации о видео
        /// </summary>
        public async Task GetVideoAsync(string url)
        {
            var video = await youtube.Videos.GetAsync(url);

            Console.WriteLine($"\r\nНазвание: {video.Title}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
            Console.WriteLine($"Автор: {video.Author.Title}");
        }

        /// <summary>
        /// Скачивание видео
        /// </summary>
        public async Task SaveVideoAsync(string url, string filePath)
        {
            await youtube.Videos.DownloadAsync(url, filePath);
            Console.WriteLine("\r\nВидео сохранено в " + filePath);
        }
    }
}
