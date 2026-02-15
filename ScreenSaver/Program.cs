using System;

namespace Screensaver;

/// <summary>
/// Главный класс приложения.
/// </summary>
static class Program
{
    /// <summary>
    /// Главная точка входа приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Для настройки конфигурации приложения (например, DPI, шрифт по умолчанию),
        // см. https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new ScreensaverForm());
    }
}