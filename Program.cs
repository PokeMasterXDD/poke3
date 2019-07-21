using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using SFML.Audio;
using System.Collections.Generic;
namespace CSharpSFML
{
    public static class Program
    {
        //static Styles styles = Styles.None;
        //static RectangleShape rectangle = new RectangleShape();
        static Sprite QuitButton = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Quit Button (1).png"));
        static Sprite SettingsButton = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Settings Button (1).png"));
        static Sprite Settings = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Settings 3.png"));
        static Sprite StartButton = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Start Button.png"));
        static Sprite IntroGame = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Inazuma Eleven Beggining Game 2.png"));
        static Sprite OptionsIntro = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Inazuma Eleven Options Button.png"));
        static Sprite BlackButton = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Black Button.png"));
        static Sprite BlackButton2 = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Black Button 2.png"));
        static Sprite FootballPitch = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\football pitch.png"));
        static Sprite Ball = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\ball.png"));
        static Sprite Lightning = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Lightning.png"));
        static Sprite ChosenOne = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\TheChosenOne.png"));
        static Sprite IDontKnowWhatShouldBeCalled = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Score and Emblem and Name Place.png"));
        static Sprite ManoCelestial = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Mano Celestial.png"));
        static Sprite Thunder1 = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Thunders 1.png"));
        static Sprite Thunder2 = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Thunders 2.0.png"));
        static Sprite ManoCelestial2 = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Mano Celestial 2.png"));
        static Sprite ManoCelestial2D = new Sprite(new Texture("C:\\Users\\Paulo\\source\\repos\\ConsoleApp4\\ConsoleApp4\\bin\\x64\\Debug\\Mano Celestial 2D.png"));
        static Sprite HandPower = new Sprite(new Texture("C:\\Users\\Paulo\\Videos\\Hand Power.png"));
        static Sprite MultiplayerButton = new Sprite(new Texture("C:\\Users\\Paulo\\Desktop\\Multiplayer button.png"));
        static Sprite MatchButton = new Sprite(new Texture("C:\\Users\\Paulo\\Desktop\\Match button.png"));
        static Sprite TrainingButton = new Sprite(new Texture("C:\\Users\\Paulo\\Desktop\\Training button.png"));
        static Sprite TournamentButton = new Sprite(new Texture("C:\\Users\\Paulo\\Desktop\\Tournament button.png"));
        static Sprite Mark = new Sprite(new Texture(new Texture("C:\\Users\\Paulo\\Videos\\Mark 2.png")));
        static Sprite Axel = new Sprite(new Texture(new Texture("C:\\Users\\Paulo\\Videos\\Axel 2.png")));
        public static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
        public static void Main()
        {
            Keyboard.Key LastKeyPressed = Keyboard.Key.W;//Defaults to Down on init? Your choice Poke.
            Dictionary<string, Sprite> dictionary = new Dictionary<string, Sprite>();
            if (!dictionary.ContainsKey("Mark"))
            {
                dictionary.Add("Mark", Mark);
            }
            bool Kick = false;
            //Axel.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 100);
            TournamentButton.Scale = new Vector2f(2, 2);
            MatchButton.Scale = new Vector2f(2, 2);
            TrainingButton.Scale = new Vector2f(2, 2);
            MultiplayerButton.Scale = new Vector2f(2, 2);
            TournamentButton.Position = new Vector2f(400, 270);
            MatchButton.Position = new Vector2f(85, 270);
            TrainingButton.Position = new Vector2f(460, 400);
            MultiplayerButton.Position = new Vector2f(20, 400);
            float DeltaTime = 0;
            float DeltaTime1 = 0;
            double ScaleX = 0;
            double ScaleX2 = 2.5;
            double Scaling = 0.002;
            double ScaleX1 = 2.1;
            bool ZPressed = false;
            double velocity = 0.0050;
            Clock clock = new Clock();
            int m = 0;
            bool LeftPressed = false;
            bool RightPressed = false;
            bool UpPressed = false;
            bool DownPressed = false;
            float frametimer = 0f;
            int frame = 0;
            int a = 0;
            float n = 0;
            float o = 0;
            float p = 0;
            float CurrentTime = clock.ElapsedTime.AsMilliseconds();
            float PreviousTime = 0;
            float CurrentTime1 = clock.ElapsedTime.AsMilliseconds();
            float PreviousTime1 = 0;
            RenderWindow app = new RenderWindow(new VideoMode(800, 600), "Inazuma Eleven");
            View view = new View();
            Vector2f position = app.MapPixelToCoords(new Vector2i(Mouse.GetPosition(app).X, Mouse.GetPosition(app).Y));
            SettingsButton.Position = new Vector2f(450, 500);
            StartButton.Position = new Vector2f(20, 500);
            QuitButton.Position = new Vector2f(300, 500);
            BlackButton.Position = new Vector2f(500, 236);
            BlackButton2.Position = new Vector2f(500, 377);
            Mark.Position = new Vector2f(400, 500);
            ManoCelestial.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 70);
            HandPower.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 70);
            ManoCelestial2D.Position = ManoCelestial.Position;
            ManoCelestial2.Position = new Vector2f(Mark.Position.X - 30, Mark.Position.Y);
            Ball.Position = new Vector2f(620, 1380);
            Lightning.Position = new Vector2f(-100, 600);
            bool ReachedTheLimit = false;
            bool ReachedTheLimitAgain = false;
            Ball.Texture.Smooth = true;
            SettingsButton.Texture.Smooth = true;
            Mark.Texture.Smooth = true;
            QuitButton.Texture.Smooth = true;
            StartButton.Texture.Smooth = true;
            FootballPitch.Texture.Smooth = true;
            Settings.Texture.Smooth = true;
            IntroGame.Texture.Smooth = true;
            app.Closed += new EventHandler(OnClose);
            int plshelp = 0;
            //Mark.TextureRect = new IntRect(new Vector2i(0, 0), new Vector2i(40, 70));
            Sprite[] RaimonPlayers =
            {
                Mark,
            };
            Texture[] MarkUp = {
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 3.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 7.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 8.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 3.png"),
            };
            Texture[] MarkDown = {
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 2.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 4.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 5.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 6.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 2.png")
            };
            Texture[] target = MarkDown;
            Texture[] MarkLeft = {
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 9.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 10.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 9.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 11.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 9.png")
            };
            Texture[] MarkRight = {
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 12.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 13.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 12.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 14.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark 12.png")
            };
            Texture[] AxelUp = {
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 3.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 7.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 8.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 3.png"),
            };
            Texture[] AxelDown = {
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 2.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 4.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 5.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 6.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 2.png")
            };
            Texture[] AxelLeft = {
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 9.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 10.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 9.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 11.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 9.png")
            };
            Texture[] AxelRight = {
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 12.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 13.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 12.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 14.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Axel 12.png")
            };
            Texture[] GodHand =
            {
                new Texture("C:\\Users\\Paulo\\Videos\\Mark IDontKnowHowToCallHim.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark Evans HandPose.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark AlmostHandUp.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark HandsUp.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark IDontKnowHowToCallHim.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark Evans HandPose.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark Phase 1.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark AlmostInPosition.png"),
                new Texture("C:\\Users\\Paulo\\Videos\\Mark God Hand.png"),
            };
            app.MouseButtonPressed += (sender, e) =>
            {
                if (SettingsButton.GetGlobalBounds().Contains(e.X, e.Y) && a == 0)
                {
                    a = 1;
                }
                if (QuitButton.GetGlobalBounds().Contains(e.X, e.Y) && a == 2)
                {
                    a = 0;
                }
                if (StartButton.GetGlobalBounds().Contains(e.X, e.Y) && a == 0)
                {
                    a = 2;
                    QuitButton.Position = new Vector2f(285, 500);
                }
                if (MatchButton.GetGlobalBounds().Contains(e.X, e.Y) && a == 2)
                {
                    a = 3;
                }
                if (QuitButton.GetGlobalBounds().Contains(e.X, e.Y) && a == 1)
                {
                    a = 0;
                }
            };
            app.MouseButtonPressed += (sender, e) =>
            {
                if (a == 3)
                {
                    if (Mark.Position.Y == Ball.Position.Y - 40 && Mark.Position.X <= Ball.Position.X + 20 && Mark.Position.X >= Ball.Position.X - 20 || Mark.Position.Y == Ball.Position.Y - 80 && Mark.Position.X <= Ball.Position.X + 40 && Mark.Position.X >= Ball.Position.X - 40 || Mark.Position.X >= Ball.Position.X - 40 && Mark.Position.X <= Ball.Position.X && Mark.Position.Y == Ball.Position.Y - 60 || Mark.Position.X >= Ball.Position.X - 20 && Mark.Position.X <= Ball.Position.X + 20 && Mark.Position.Y == Ball.Position.Y - 60)
                    {
                        Vector2f position1 = app.MapPixelToCoords(new Vector2i(Mouse.GetPosition(app).X, Mouse.GetPosition(app).Y));
                        n = (position1.X - Ball.Position.X) / 100;
                        o = (position1.Y - Ball.Position.Y) / 100;
                        p = position1.X;
                        Kick = true;
                    }
                }
            };
            app.KeyPressed += (sender, e) =>
            {
                if (a == 3)
                {
                    if (Mark.GetGlobalBounds().Intersects(Ball.GetGlobalBounds()))
                    {
                        if (!dictionary.ContainsKey("ball"))
                        {
                            dictionary.Add("ball", Ball);
                        }
                        //the same with the A, S and D
                    } // I don't know if is Global or Local
                    if (e.Code == Keyboard.Key.W && Mark.Position.Y == Ball.Position.Y - 40 && Mark.Position.X <= Ball.Position.X + 30 && Mark.Position.X >= Ball.Position.X - 30)
                    {
                        Ball.Position = new Vector2f(Mark.Position.X + 10, Ball.Position.Y - 60);
                    }
                    if (e.Code == Keyboard.Key.S && Mark.Position.Y == Ball.Position.Y - 80 && Mark.Position.X <= Ball.Position.X + 40 && Mark.Position.X >= Ball.Position.X - 40)
                    {
                        Ball.Position = new Vector2f(Mark.Position.X + 10, Ball.Position.Y + 100);
                    }
                    if (e.Code == Keyboard.Key.D && Mark.Position.X >= Ball.Position.X - 40 && Mark.Position.X <= Ball.Position.X && Mark.Position.Y == Ball.Position.Y - 60)
                    {
                        Ball.Position = new Vector2f(Ball.Position.X + 60, Ball.Position.Y);
                    }
                    if (e.Code == Keyboard.Key.A && Mark.Position.X >= Ball.Position.X - 20 && Mark.Position.X <= Ball.Position.X + 20 && Mark.Position.Y == Ball.Position.Y - 60)
                    {
                        Ball.Position = new Vector2f(Ball.Position.X - 40, Ball.Position.Y);
                    }
                    if (e.Code == Keyboard.Key.W)
                    {
                        LastKeyPressed = Keyboard.Key.W;
                        target = MarkUp;
                        if (frametimer > 1)
                        {//Change texture every second. Use smaller number if it should be faster
                            frame = ++frame % target.Length;//Keep frame between 0 and target.Length
                            Mark.Texture = target[frame];
                            frametimer %= 1;
                        }
                        if (dictionary.ContainsKey("ball"))
                        {
                            if (LastKeyPressed == Keyboard.Key.S)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 32);
LastKeyPressed = Keyboard.Key.S;
                            }
                            else if (LastKeyPressed == Keyboard.Key.D)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 32);
LastKeyPressed = Keyboard.Key.D;
                            }
                            else if (LastKeyPressed == Keyboard.Key.A)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y - 32);
LastKeyPressed = Keyboard.Key.A;
                            }
                        }
                        LastKeyPressed = Keyboard.Key.W;
                        view.Center = new Vector2f(Mark.Position.X, Mark.Position.Y - 10);
app.SetView(view);
                        //view.Move(new Vector2f(view.Center.X, view.Center.Y - 20));
                    }
                    if (e.Code == Keyboard.Key.S)
                    {
                        LastKeyPressed = Keyboard.Key.S;
                        target = MarkDown;
                        if (frametimer > 1)
                        {//Change texture every second. Use smaller number if it should be faster
                            frame = ++frame % target.Length;//Keep frame between 0 and target.Length
                            Mark.Texture = target[frame];
                            frametimer %= 1;
                        }
                        if (dictionary.ContainsKey("ball"))
                        {
                            if (LastKeyPressed == Keyboard.Key.W)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y + 128);
                            }
                            else if (LastKeyPressed == Keyboard.Key.D)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y + 128);
LastKeyPressed = Keyboard.Key.D;
                            }
                            else if (LastKeyPressed == Keyboard.Key.A)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X, Mark.Position.Y + 128);
LastKeyPressed = Keyboard.Key.A;
                            }
                            LastKeyPressed = Keyboard.Key.S;
                        }
                        view.Center = new Vector2f(Mark.Position.X, Mark.Position.Y + 10);
app.SetView(view);
                    }
                   
                    int i = 0;
                    if (e.Code == Keyboard.Key.A)
                    {
                       
                        target = MarkRight;
                        if (frametimer > 1)
                        {//Change texture every second. Use smaller number if it should be faster
                            frame = ++frame % target.Length;//Keep frame between 0 and target.Length
                            Mark.Texture = target[frame];
                            frametimer %= 1;
                        }
                        if (dictionary.ContainsKey("ball"))
                        {
                            if (LastKeyPressed == Keyboard.Key.S)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X - 72, Mark.Position.Y + 60);
LastKeyPressed = Keyboard.Key.S;
                            }
                            else if (LastKeyPressed == Keyboard.Key.D)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X - 64, Mark.Position.Y + 72);
LastKeyPressed = Keyboard.Key.D;
                            }
                            else if (LastKeyPressed == Keyboard.Key.W)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X - 32, Mark.Position.Y + 32 + 32);
LastKeyPressed = Keyboard.Key.W;
                            }
                            LastKeyPressed = Keyboard.Key.A;
                        }
                        view.Center = new Vector2f(Mark.Position.X - 5, Mark.Position.Y);
app.SetView(view);
                    }
                    if (e.Code == Keyboard.Key.D)
                    {
                        if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                        {
                            RightPressed = true;
                        }
                        target = MarkLeft;
                        if (frametimer > 1)
                        {//Change texture every second. Use smaller number if it should be faster
                            frame = ++frame % target.Length;//Keep frame between 0 and target.Length
                            Mark.Texture = target[frame];
                            frametimer %= 1;
                        }
                        if (dictionary.ContainsKey("ball"))
                        {
                            if (LastKeyPressed == Keyboard.Key.W)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X + 32, Mark.Position.Y + 96);
LastKeyPressed = Keyboard.Key.W;
                            }
                            else if (LastKeyPressed == Keyboard.Key.S)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X + 32, Mark.Position.Y + 50);
LastKeyPressed = Keyboard.Key.S;
                            }
                            else if (LastKeyPressed == Keyboard.Key.A)
                            {
                                Ball.Position = new Vector2f(Mark.Position.X + 32, Mark.Position.Y + 64);
LastKeyPressed = Keyboard.Key.A;
                            }
                            LastKeyPressed = Keyboard.Key.D;
                        }
                        view.Center = new Vector2f(Mark.Position.X + 5, Mark.Position.Y);
app.SetView(view);
                    }
                    foreach (KeyValuePair<string, Sprite> pair in dictionary)
                    {
                        if (Keyboard.IsKeyPressed(Keyboard.Key.W))
                        {
                            pair.Value.Position = new Vector2f(pair.Value.Position.X, pair.Value.Position.Y - 20);
                        }
                        if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                        {
                            pair.Value.Position = new Vector2f(pair.Value.Position.X - 20, pair.Value.Position.Y);
                        }
                        if (Keyboard.IsKeyPressed(Keyboard.Key.S))
                        {
                            pair.Value.Position = new Vector2f(pair.Value.Position.X, pair.Value.Position.Y + 20);
                        }
                        if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                        {
                            pair.Value.Position = new Vector2f(pair.Value.Position.X + 20, pair.Value.Position.Y);
                        }
                    }
                }
           };
            app.KeyReleased += (sender, e) =>
            {
                if (e.Code == Keyboard.Key.W)
                {
                    Mark.Texture = MarkUp[0];
                }
                if (e.Code == Keyboard.Key.D)
                {
                    Mark.Texture = MarkLeft[0];
                }
                if (e.Code == Keyboard.Key.S)
                {
                    Mark.Texture = MarkDown[0];
                }
                if (e.Code == Keyboard.Key.A)
                {
                    Mark.Texture = MarkRight[0];
                }
            };
            // Start the game loop
            while (app.IsOpen)
            {
                if (a == 0)
                {
                    app.Draw(IntroGame);
                    app.Draw(StartButton);
                    app.Draw(SettingsButton);
                }
                if (a == 1)
                {
                    app.Draw(Settings);
                    app.Draw(QuitButton);
                    app.Draw(BlackButton);
                    app.Draw(BlackButton2);
                }
                if (a == 2)
                {
                    app.Draw(OptionsIntro);
                    app.Draw(MultiplayerButton);
                    app.Draw(MatchButton);
                    app.Draw(TournamentButton);
                    app.Draw(TrainingButton);
                    app.Draw(QuitButton);
                }
                if (a == 3)
                {
                    view.Viewport = new FloatRect(0.1f, 0.2f, 0.5f, 0.5f);
                    app.SetView(view);
                    app.Draw(FootballPitch);
                    app.Draw(Ball);
                    app.Draw(Mark);
                    PreviousTime = CurrentTime;
                    CurrentTime = clock.ElapsedTime.AsMilliseconds();
                    DeltaTime = CurrentTime - PreviousTime;
                    if (DeltaTime1 > 0.15f)
                    {
                        DeltaTime1 = 0.15f;
                    }
                    app.Draw(Mark);
                    if (m == 0)
                    {
                        Mark.Scale = new Vector2f(5, 5);
                        Axel.Scale = new Vector2f(3, 3);
                        Ball.Scale = new Vector2f(5, 5);
                        FootballPitch.Scale = new Vector2f(2, 2);
                        m = 1;
                    }

                    /*if ((velocity * DeltaTime1) > 0 && (velocity * DeltaTime1) < 3.001)
                    {
                        velocity += 0.04;
                    }
                    if (velocity * DeltaTime1 > 3 && velocity * DeltaTime1 < 4)
                    {
                        if (ReachedTheLimit != true)
                        {
                            app.Draw(ManoCelestial);
                            ScaleX = ManoCelestial.Scale.X + Scaling;
                            ManoCelestial.Scale = new Vector2f((float)ScaleX, (float)ScaleX);
                            ManoCelestial.Position = new Vector2f((float)(ManoCelestial.Position.X - (35 * Scaling)), (float)(ManoCelestial.Position.Y - (40 * Scaling)));
                            if (ScaleX >= ScaleX1)
                            {
                                HandPower.Scale = ManoCelestial.Scale;
                                HandPower.Position = ManoCelestial.Position;
                                ReachedTheLimit = true;
                            }
                        }
                        else 
                        {
                            if (ReachedTheLimitAgain != true)
                            {
                                app.Draw(HandPower);
                                app.Draw(ManoCelestial);
                                ScaleX = HandPower.Scale.X + Scaling;
                                HandPower.Scale = new Vector2f((float)ScaleX, (float)ScaleX);
                                HandPower.Position = new Vector2f((float)(HandPower.Position.X - (35 * Scaling)), (float)(HandPower.Position.Y - (30 * Scaling)));
                            }
                            if (ScaleX > ScaleX2 && ScaleX != 0)
                            {
                                ReachedTheLimitAgain = true;
                            }
                            if (ReachedTheLimitAgain)
                            {
                                app.Draw(HandPower);
                                app.Draw(ManoCelestial);
                                ScaleX = HandPower.Scale.X - Scaling;
                                HandPower.Scale = new Vector2f((float)ScaleX, (float)ScaleX);
                                HandPower.Position = new Vector2f((float)(HandPower.Position.X + (35 * Scaling)), (float)(HandPower.Position.Y + (30 * Scaling)));
                                if (ScaleX <= ScaleX1)
                                {
                                    ReachedTheLimitAgain = false;
                                }
                            }
                        }
                    }
                    if (velocity * DeltaTime1 > 3 && velocity * DeltaTime1 < 3.2)
                    {
                        app.Draw(Thunder1);
                        Thunder1.Position = new Vector2f(Mark.Position.X + 25, Mark.Position.Y - 25);
                        velocity += 0.001;
                    }
                    if (velocity * DeltaTime1 > 3.2 && velocity * DeltaTime1 < 3.4)
                    {
                        app.Draw(Thunder2);
                        Thunder2.Position = new Vector2f(Mark.Position.X + 25, Mark.Position.Y - 25);
                        velocity += 0.001;
                    }
                    if (velocity * DeltaTime1 > 3.4 && velocity * DeltaTime1 < 3.6)
                    {
                        app.Draw(Thunder1);
                        Thunder1.Position = new Vector2f(Mark.Position.X + 25, Mark.Position.Y - 25);
                        velocity += 0.001;
                    }
                    if (velocity * DeltaTime1 > 3.6 && velocity * DeltaTime1 < 4)
                    {
                        app.Draw(Thunder2);
                        Thunder2.Position = new Vector2f(Mark.Position.X + 25, Mark.Position.Y - 25);
                        velocity += 0.0005;
                    }
                    if (velocity * DeltaTime1 >= 4 && (velocity * DeltaTime1 <= 7))
                    {
                        velocity += 0.3;
                        app.Draw(ManoCelestial2);
                        app.Draw(Mark);
                    }
                    if (Math.Round(velocity * DeltaTime1) >= 7 && Math.Round(velocity * DeltaTime1) <= 9)
                    {
                        velocity += 0.3;
                        app.Draw(ManoCelestial2);
                        app.Draw(Mark);
                    }
                    if (Math.Round(velocity * DeltaTime1) >= 9)
                    {
                        Mark.Texture = GodHand[GodHand.Length - 1];
                        if (ManoCelestial2.Scale.X < 1.25)
                        {
                            app.Draw(Mark);
                            app.Draw(ManoCelestial2);
                            ScaleX = ManoCelestial2.Scale.X + Scaling;
                            ManoCelestial2.Scale = new Vector2f((float)ScaleX, (float)ScaleX);
                            ManoCelestial2.Position = new Vector2f((float)(ManoCelestial2.Position.X - (35 * Scaling)), (float)(ManoCelestial2.Position.Y - (40 * Scaling)));
                            ManoCelestial2D.Scale = ManoCelestial2.Scale;
                            ManoCelestial2D.Position = ManoCelestial2.Position;
                        }
                        else
                        {
                            app.Draw(Mark);
                            app.Draw(ManoCelestial2D);
                        }
                    }
                    else
                    {
                        Mark.Texture = GodHand[(int)(velocity * DeltaTime1)];
                    }*/
            FootballPitch.Position = new Vector2f(0, 0);
                    frametimer += DeltaTime * 0.0060f;
                }
                app.DispatchEvents();
                    app.Display();
                    app.Clear();
            } //End game loop
        } //End Main()
    }
}
