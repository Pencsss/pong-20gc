# Pong

A two-player Pong made in Unity 6, game 1 of the [20 Games Challenge](https://20_games_challenge.gitlab.io/challenge/).

▶️ **Play it in the browser:** https://pencsss.itch.io/pong

## Controls

| Player | Up | Down |
|---|---|---|
| Left | W | S |
| Right | ↑ | ↓ |

The ball launches in a random direction. When it hits the wall behind a paddle, the other player scores and the ball resets to the centre.

For the best experience, play in fullscreen.

## Scope

Built to the challenge's definition of done: arena, two player-controlled paddles, a ball that bounces off paddles and walls, and on-screen scoring. No AI opponent, menu or sound.

## Built with

Unity 6.3 LTS (6000.3.27f2) · C# · Input System · URP 2D · TextMesh Pro

## Project structure

| Script | What it does |
|---|---|
| `PlayerMovementLeft.cs` / `PlayerMovementRight.cs` | Read the keyboard and move each paddle through its `Rigidbody2D` |
| `BallMovement.cs` | Launches the ball in a random direction and resets it after a goal |
| `GoalLeft.cs` / `GoalRight.cs` | Trigger on the side walls: award the point and update the score text |

To open the project: add this folder in Unity Hub, open it with Unity 6.3 LTS and load `Assets/Scenes/SampleScene.unity`.

## Post-mortem

**What went wrong**
- I started with the old `Input.GetKey` API, but the project only has the new Input System enabled, so I switched to `Keyboard.current`.
- The paddles went through the walls. Moving them with `transform.position` skips the physics, so I switched to `Rigidbody2D.linearVelocity`. They still went through, because the walls also had a dynamic `Rigidbody2D`. Removing it made the walls static colliders and fixed it.
- The score is read back from the UI text with `int.Parse`. I had linked the label ("Player 1:") instead of the number, which threw a `FormatException`.
- In the web build the UI was in the wrong place. The Canvas Scaler was on Constant Pixel Size and the texts were anchored to the centre.

**What I learned**
- If an object has a Rigidbody, move it through the Rigidbody. Things that never move only need a collider.
- Use Scale With Screen Size and anchors for the UI, and test the Game view at the build's resolution.

**Next time**
- Keep the game state (the score) in variables and let the UI only display it.
- Commit after each feature instead of one big commit.
- Use one script per behaviour with Inspector fields instead of Left/Right copies.
