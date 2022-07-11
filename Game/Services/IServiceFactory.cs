using simon_says_memory.Game.Casting;

namespace simon_says_memory.Game.Services
{
    public interface IServiceFactory
    {
        IAudioService GetAudioService();
        IKeyboardService GetKeyboardService();
        IMouseService GetMouseService();
        ISettingsService GetSettingsService();
        IVideoService GetVideoService();
    }
}