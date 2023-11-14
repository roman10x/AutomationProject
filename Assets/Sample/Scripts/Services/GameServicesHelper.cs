using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Entities;
using Services;

namespace Nora.Services.GameServices
{
    /// <summary>
    /// Service created to initialize game services like events, quests, streak etc.
    /// Initializer working with IGameService interface and allow to work with services from any place of the game.
    /// </summary>
    public static class GameServicesHelper
    {
        private static EntitiesManager _entitiesManager = new EntitiesManager(); // field is static to simplify project. Locate services in appropriate place.
        private static bool _isInitialized;
        public static bool IsInitialized => _isInitialized;

        public static EntitiesManager EntitiesManager => _entitiesManager;

        // List of services that can be initialized on the start of the game
        private static List<IGameService> _servicesToInitOnStart = new List<IGameService>();

        public static async UniTask InitGameServices()
        {
            try
            {
                var servicesTasks = new List<UniTask<bool>>();
                InitServicesList();
                foreach (var service in _servicesToInitOnStart)
                {
                    servicesTasks.Add(service.TryInitialize());
                }

                await UniTask.WhenAll(servicesTasks);
                _isInitialized = true;
            }
            catch (Exception e)
            {
                throw new Exception($"Game services is not initialized properly - exception{e}");
            }
        }

        private static void InitServicesList()
        {
            _servicesToInitOnStart = new List<IGameService>
            {
               _entitiesManager
            };
        }
    }
}