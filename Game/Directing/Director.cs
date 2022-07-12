using simon_says_memory.Game.Casting;
using simon_says_memory.Game.Scripting;
using simon_says_memory.Game.Services;


namespace simon_says_memory.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director : IActionCallback
    {
        private IAudioService _audioService = null;
        private IVideoService _videoService = null;
        private ISettingsService _settingsService = null;

        public Director(IServiceFactory serviceFactory)
        {
            _audioService = serviceFactory.GetAudioService();
            _videoService = serviceFactory.GetVideoService();
            _settingsService = serviceFactory.GetSettingsService();
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast and script.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        /// <param name="script">The given script.</param>
        public void StartGame(Cast cast, Script script)
        {
            while (_videoService.IsWindowOpen())
            {
                ExecuteActions("input", cast, script);
                ExecuteActions("update", cast, script);
                ExecuteActions("output", cast, script);
            }
        }
        
        public void OnError(string message, System.Exception exception)
        {
            _audioService.Release();
            _videoService.Release();
            _settingsService.Save();
            System.Console.Error.WriteLine($"ERROR: {message}");
            System.Console.Error.WriteLine(exception.Message);
            System.Console.Error.WriteLine(exception.StackTrace);
        }

        public void OnInfo(string message)
        {
            System.Console.Out.WriteLine($"INFO: {message}");
        }

        public void OnStop()
        {
            _audioService.Release();
            _videoService.Release();
        }

        public void Direct(Scene scene)
        {
            _audioService.Initialize();
            _videoService.Initialize();
            while (_videoService.IsWindowOpen())
            {
                DoActions(Phase.Input, scene);
                DoActions(Phase.Update, scene);
                DoActions(Phase.Output, scene);
                scene.ApplyChanges();
            }
            _audioService.Release();
            _videoService.Release();
            _settingsService.Save();
        }

        private void DoActions(int phase, Scene scene)
        {
            float deltaTime = _videoService.GetDeltaTime();
            List<Action> actions = scene.GetAllActions(phase);
            foreach(Action action in actions)
            {
                action.Execute(scene, deltaTime, this);
            }
        }

        

        /// <summary>
        /// Calls execute for each action in the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="cast">The cast of actors.</param>
        /// <param name="script">The script of actions.</param>
        private void ExecuteActions(string group, Cast cast, Script script)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script);
            }
        }
    }
}