﻿namespace Client
{
    enum PlayerState
    {
        LOBBY,
        SEARCHING,
        PLAYING
    };

    enum ResponseType
    {
        FULL,
        FOUND,
        ERROR
    }

    enum FeedbackType
    {
        MOVE,
        ACTION
    }

    enum State
    {
        COUNTDOWN,
        WAITING,
        GAMEPLAY,
        SCORE,
        VICTORY,
        GAMEOVER,
        OFFLINE
    }

    // new player info
    class PlayerInfo
    {
        public int ID { get; set; }
        public string Tag { get; set; }
    }

    // pregame response
    class GameResponse
    {
        public ResponseType Response { get; set; }
        public int GameID { get; set; }
        public int Index { get; set; }
    }

    class Ball
    {
        public Coords pos;
        public Coords dir;
        public int player;
        public int size;
        public double speed;

        public Ball(Coords pos, int player, Coords dir, int size, double speed)
        {
            this.pos = pos;
            this.player = player;
            this.dir = dir;
            this.size = size;
            this.speed = speed;
        }
    }

    // current state of the game
    class GameState
    {
        public State Type { get; set; }
        public Coords[] Players { get; set; }
        public Ball[] Balls { get; set; }
        public int[] Score { get; set; }
        public int[] Shields { get; set; }
        public int time { get; set; }
        public int Count { get; set; }
        public bool[] Ready { get; set; }
        public int[,] Blocks { get; set; }
        public string Scored { get; set; }
    }

    // player feedback
    class PlayerFeedback
    {
        public FeedbackType type { get; set; }
        public Coords Position { get; set; }
        public int Index { get; set; }
    }
}
