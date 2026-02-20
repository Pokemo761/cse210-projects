using System;

// EXCEEDING REQUIREMENTS:
// I added support for multiple verses (Jacob 2:1–9).
// I also improved hiding logic so it only hides words that are not already hidden.
// This makes the memorization experience more realistic and prevents wasted hides.

class Program
{
    static void Main()
    {
        // Reference with verse range
        Reference reference = new Reference("Jacob", 2, 1, 9); // this going back to the reference 

        // Scripture text
        string text = @"The words which Jacob, the brother of Nephi, spake unto the people of Nephi, after the death of Nephi.
Now, my beloved brethren, I, Jacob, according to the responsibility which I am under to God, to magnify mine office with soberness.
And ye yourselves know that I have hitherto been diligent in the office of my calling.
For behold, as yet, ye have been obedient unto the word of the Lord.
But behold, hearken ye unto me, and know that by the help of the all-powerful Creator.
Yea, it grieveth my soul and causeth me to shrink with shame before the presence of my Maker.
And also it grieveth me that I must use so much boldness of speech concerning you.
And it supposeth me that they have come up hither to hear the pleasing word of God.
Wherefore, it burdeneth my soul that I should be constrained.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllHidden())
        {
            Console.Clear(); // clean screen
            Console.WriteLine(scripture.GetDisplayText()); // display the scriputres

            Console.WriteLine("\nPress ENTER to hide words or type 'quit'");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine("Memorization complete!");
    }
}