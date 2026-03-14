using System;

// EXCEEDING REQUIREMENTS:
//
// 1. NEGATIVE GOALS - I added a new "NegativeGoal" class to help me track bad habits
//    I want to break. When I record a negative goal (meaning I did the bad habit), I
//    LOSE points instead of gaining them. This creates accountability and helps me
//    stay focused on my studies and personal growth. For example:
//    - Getting distracted by news: -50 points
//    - Walking around aimlessly: -30 points
//    - Talking to myself too much: -20 points
//    This negative reinforcement helps me stay on track with my goals.
//
// 2. LEVELING SYSTEM - I added a level system where I gain levels as I earn points.
//    Every 1000 points = 1 level. This makes tracking my progress more fun and gives
//    me milestones to celebrate. The level is displayed alongside my score, making
//    the gamification aspect more engaging.
//
// 3. ENHANCED FEEDBACK - When recording events, the program provides different feedback
//    messages for positive goals (encouragement) versus negative goals (reminder to
//    stay focused). This personalized feedback keeps me motivated and accountable.

class Program
{
    static void Main(string[] args)
    {
        // Create the goal manager and start the program
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}