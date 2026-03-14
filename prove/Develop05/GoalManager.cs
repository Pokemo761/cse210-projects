using System;
using System.Collections.Generic;
using System.IO;

// This class manages all the goals and keeps track of your score
public class GoalManager
{
    // List to hold all the goals
    private List<Goal> _goals;
    
    // Your total score
    private int _score;

    // Constructor - starts with empty goals and zero score
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // This creates your personal goals automatically
    // It loads all the goals you told me about!
    public void LoadMyPersonalGoals()
    {
        // Clear any existing goals first
        _goals.Clear();
        _score = 0;

        Console.WriteLine("Loading your personal goals...\n");

        // Add your simple goal - finish reading a book
        _goals.Add(new SimpleGoal("Finish reading a book", "Read a book for at least an hour until done", 1000));

        // Add your eternal goals - things you can do every day
        _goals.Add(new EternalGoal("Learn Italian", "Spend time learning Italian", 100));
        _goals.Add(new EternalGoal("Play guitar", "Play guitar for an hour", 100));
        _goals.Add(new EternalGoal("Go to gym", "Push yourself to the limit for an hour", 150));

        // Add your checklist goal - daily reading habit
        _goals.Add(new ChecklistGoal("Daily reading habit", "Read for at least an hour", 50, 30, 500));

        // Add your negative goals - bad habits to avoid
        _goals.Add(new NegativeGoal("Got distracted by news", "Watched news instead of focusing on life and homework", -50));
        _goals.Add(new NegativeGoal("Walked around aimlessly", "Walked back and forth without purpose", -30));
        _goals.Add(new NegativeGoal("Talked to myself excessively", "Talked to myself too much", -20));

        Console.WriteLine("✅ Your personal goals have been loaded!");
        Console.WriteLine("You have 8 goals ready to track.\n");
    }

    // This is the main menu loop
    public void Start()
    {
        // Load your personal goals automatically when starting
        LoadMyPersonalGoals();
        
        bool running = true;

        while (running)
        {
            // Show the score
            DisplayPlayerInfo();
            
            // Show the menu
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();

            // Do different things based on what they picked
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("\n🎯 Great work on your goals today!");
                    Console.WriteLine("Keep up the good habits! Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("\n❌ Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // This shows your current score and level
    public void DisplayPlayerInfo()
    {
        // Calculate level (every 1000 points = 1 level)
        int level = _score / 1000;
        
        Console.WriteLine("\n" + new string('=', 40));
        Console.WriteLine($"🏆 Level {level} - Score: {_score} points");
        Console.WriteLine(new string('=', 40));
    }

    // This lists all the goals with details
    public void ListGoalDetails()
    {
        Console.WriteLine("\n📋 Your Goals:");
        Console.WriteLine(new string('-', 60));
        
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet! Create some goals to get started.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                // Show number and goal details
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
        
        Console.WriteLine(new string('-', 60));
    }

    // This lists goals with just numbers (for selecting one)
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    // This creates a new goal
    public void CreateGoal()
    {
        Console.WriteLine("\n🎯 Create a New Goal");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal (One-time completion)");
        Console.WriteLine("  2. Eternal Goal (Never ending)");
        Console.WriteLine("  3. Checklist Goal (Complete X times)");
        Console.WriteLine("  4. Negative Goal (Bad habit to avoid)");
        Console.Write("\nWhich type of goal would you like to create? ");
        
        string typeChoice = Console.ReadLine();

        // Ask for common info
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // Create the right type of goal
        if (typeChoice == "1")
        {
            // Simple Goal
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("\n✅ Simple goal created!");
        }
        else if (typeChoice == "2")
        {
            // Eternal Goal
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("\n✅ Eternal goal created!");
        }
        else if (typeChoice == "3")
        {
            // Checklist Goal
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
            Console.WriteLine("\n✅ Checklist goal created!");
        }
        else if (typeChoice == "4")
        {
            // Negative Goal
            NegativeGoal goal = new NegativeGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("\n✅ Negative goal created!");
        }
        else
        {
            Console.WriteLine("\n❌ Invalid choice. Goal not created.");
        }
    }

    // This records when you accomplish a goal
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\n❌ No goals available! Create some goals first.");
            return;
        }

        Console.WriteLine("\n🎯 Record an Event");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The goals are:");
        ListGoalNames();
        
        Console.Write("\nWhich goal did you accomplish? ");
        
        try
        {
            int choice = int.Parse(Console.ReadLine()) - 1;  // Subtract 1 because list starts at 0

            if (choice >= 0 && choice < _goals.Count)
            {
                Goal selectedGoal = _goals[choice];
                
                // Check if it's a simple goal that's already complete
                if (selectedGoal is SimpleGoal && selectedGoal.IsComplete())
                {
                    Console.WriteLine("\n❌ This goal is already complete!");
                    return;
                }
                
                // Record the event and get the points
                int pointsEarned = selectedGoal.RecordEvent();
                _score += pointsEarned;
                
                // Show different messages based on points
                if (pointsEarned > 0)
                {
                    Console.WriteLine($"\n🎉 Congratulations! You have earned {pointsEarned} points!");
                    
                    // Check if it was a checklist goal that just got completed
                    if (selectedGoal is ChecklistGoal && selectedGoal.IsComplete())
                    {
                        Console.WriteLine("🏆 BONUS! You completed the entire checklist goal!");
                    }
                    
                    // Show motivational messages for specific goals
                    string goalName = selectedGoal.GetShortName();
                    if (goalName.Contains("Italian"))
                    {
                        Console.WriteLine("🇮🇹 Fantastico! Keep learning Italian!");
                    }
                    else if (goalName.Contains("guitar"))
                    {
                        Console.WriteLine("🎸 Great job practicing guitar!");
                    }
                    else if (goalName.Contains("gym"))
                    {
                        Console.WriteLine("💪 You're getting stronger! Keep it up!");
                    }
                    else if (goalName.Contains("reading") || goalName.Contains("book"))
                    {
                        Console.WriteLine("📚 Reading is powerful! Keep going!");
                    }
                    
                    Console.WriteLine($"\n✨ You now have {_score} points.");
                    
                    // Check for level up
                    int newLevel = _score / 1000;
                    int oldLevel = (_score - pointsEarned) / 1000;
                    if (newLevel > oldLevel)
                    {
                        Console.WriteLine($"\n🎊 LEVEL UP! You are now Level {newLevel}! 🎊");
                    }
                }
                else
                {
                    Console.WriteLine($"\n⚠️  Oh no! You lost {Math.Abs(pointsEarned)} points for this bad habit.");
                    Console.WriteLine($"💡 Remember to stay focused on your goals and your homework!");
                    Console.WriteLine($"You now have {_score} points.");
                }
            }
            else
            {
                Console.WriteLine("\n❌ Invalid goal number!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\n❌ Please enter a valid number!");
        }
    }

    // This saves all goals to a file
    public void SaveGoals()
    {
        Console.Write("\n💾 What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write the score first
                writer.WriteLine(_score);
                
                // Write each goal
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            
            Console.WriteLine($"\n✅ Goals saved to {filename}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Error saving file: {ex.Message}");
        }
    }

    // This loads goals from a file
    public void LoadGoals()
    {
        Console.Write("\n📂 What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                
                // First line is the score
                _score = int.Parse(lines[0]);
                
                // Clear current goals
                _goals.Clear();
                
                // Load each goal
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] data = parts[1].Split(',');
                    
                    if (goalType == "SimpleGoal")
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        bool isComplete = bool.Parse(data[3]);
                        
                        SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                        _goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        
                        EternalGoal goal = new EternalGoal(name, description, points);
                        _goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        int bonus = int.Parse(data[3]);
                        int target = int.Parse(data[4]);
                        int amountCompleted = int.Parse(data[5]);
                        
                        ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                        _goals.Add(goal);
                    }
                    else if (goalType == "NegativeGoal")
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        
                        NegativeGoal goal = new NegativeGoal(name, description, points);
                        _goals.Add(goal);
                    }
                }
                
                Console.WriteLine($"\n✅ Goals loaded from {filename}!");
                Console.WriteLine($"You have {_goals.Count} goals and {_score} points.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Error loading file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"\n❌ File '{filename}' not found!");
        }
    }
}
