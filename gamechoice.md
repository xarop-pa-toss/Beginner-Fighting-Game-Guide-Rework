Here’s a full markdown write-up that explains the structure, enums, and class responsibilities:

---

# Fighting Game Info Helper – C# Console App Structure

This guide shows how to refactor a basic switch-based game info helper into a cleaner, more modular structure using enums and separate handler classes (`FG_Movement`, `FG_Character`, and `FG_Combos`).

---

## 📂 Project Structure


```
/FightingGameApp
│
├── Program.cs           # Main logic for input/output
├── FightingGame.cs      # Enums for game and info types
├── FG\_Movement.cs       # Movement info handler
├── FG\_Character.cs      # Character info handler
└── FG\_Combos.cs         # Combo info handler
```


---

## 🧠 Program.cs (Main Logic)

```csharp
FightingGame game;

switch (gamechoice)
{
    case 1: game = FightingGame.Tekken8; break;
    case 2: game = FightingGame.StreetFighter6; break;
    case 3: game = FightingGame.MortalKombat1; break;
    default:
        Console.WriteLine("Invalid choice.");
        return;
}

Console.WriteLine($"\n{game} is a fighting game that focuses on movement.");
Console.WriteLine($"{game} has a good tutorial that teaches you about movement & mechanics.");
Console.WriteLine($"\nWhat would you like to learn about {game}?");
Console.WriteLine("1. Movement \n2. Picking a Character \n3. Combos");
Console.Write("Input: ");

int input = Convert.ToInt32(Console.ReadLine());
InfoType info = (InfoType)input;

switch (info)
{
    case InfoType.Movement:
        FG_Movement.Show(game);
        break;
    case InfoType.Character:
        FG_Character.Show(game);
        break;
    case InfoType.Combo:
        FG_Combos.Show(game);
        break;
    default:
        Console.WriteLine("Invalid info choice.");
        break;
}
```

---

## 🧾 FightingGame.cs (Enums)

```csharp
enum FightingGame
{
    Tekken8,
    StreetFighter6,
    MortalKombat1
}

enum InfoType
{
    Movement = 1,
    Character = 2,
    Combo = 3
}
```

---

## 🕹️ FG\_Movement.cs

```csharp
static class FG_Movement
{
    public static void Show(FightingGame game)
    {
        switch (game)
        {
            case FightingGame.Tekken8:
                Tekken_8();
                break;
            case FightingGame.StreetFighter6:
                SF6();
                break;
            case FightingGame.MortalKombat1:
                MK1();
                break;
        }
    }

    static void Tekken_8() => Console.WriteLine("Tekken 8 movement tutorial...");
    static void SF6() => Console.WriteLine("SF6 movement tutorial...");
    static void MK1() => Console.WriteLine("MK1 movement tutorial...");
}
```

---

## 🎭 FG\_Character.cs

```csharp
static class FG_Character
{
    public static void Show(FightingGame game)
    {
        switch (game)
        {
            case FightingGame.Tekken8:
                TK8_Characters();
                break;
            case FightingGame.StreetFighter6:
                SF6_Characters();
                break;
            default:
                Console.WriteLine("Character info not available for this game.");
                break;
        }
    }

    static void TK8_Characters() => Console.WriteLine("Tekken 8 characters...");
    static void SF6_Characters() => Console.WriteLine("SF6 characters...");
}
```

---

## 🥋 FG\_Combos.cs

```csharp
static class FG_Combos
{
    public static void Show(FightingGame game)
    {
        switch (game)
        {
            case FightingGame.Tekken8:
                TK8_Combos();
                break;
            case FightingGame.StreetFighter6:
                SF6_Combos();
                break;
            default:
                Console.WriteLine("Combo info not available for this game.");
                break;
        }
    }

    static void TK8_Combos() => Console.WriteLine("Tekken 8 combos...");
    static void SF6_Combos() => Console.WriteLine("SF6 combos...");
}
```

---

## Benefits

* **Main only handles input and flow**.
* **Enum Safety** – Avoids magic numbers and string comparisons.
* **Each class knows only about its concern.**

You can expand this by adding more games, error handling, or even replacing the switch blocks in each FG\_\* class with dictionaries or strategy pattern later.