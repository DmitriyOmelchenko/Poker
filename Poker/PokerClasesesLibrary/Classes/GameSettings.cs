namespace PokerClasesesLibrary.Classes
{
    public class GameSettings
    {
        private static GameSettings _gameSettings;

        public static GameSettings InstanceSettings => _gameSettings ?? (_gameSettings = new GameSettings());

        private GameSettings()
        {

        }

        /// <summary>
        /// If this enabled while misery and gold round
        /// player with thero result receive additional point
        /// </summary>
        public bool BonusEnabled { get; set; }

        /// <summary>
        /// Point for one success order
        /// </summary>
        public int SimpleBetValue { get; set; } = 10;

        /// <summary>
        /// Point for one success order
        /// </summary>
        public int MiseryBetValue { get; set; } = -10;

        /// <summary>
        /// Point for one success order
        /// </summary>
        public int ShadowBetValue { get; set; } = 20;

        /// <summary>
        /// Additional point for gold round
        /// usual it's -50
        /// </summary>
        public int PointForGoldenZero { get; set; } = -50;

        /// <summary>
        /// Additional point for misery round
        /// usual it's +50 
        /// </summary>
        public int PointForMiseryZero { get; set; } = 50;

        /// <summary>
        /// For shadow round received point multiply 
        /// usual it's 2
        /// </summary>
        public int ShadowRatio { get; set; }
    }
}
