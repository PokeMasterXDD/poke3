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