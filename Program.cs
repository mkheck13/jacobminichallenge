// The program will:

// 1.) take in a sentence from the user
Console.WriteLine("Please enter a sentence: ");
string input = Console.ReadLine();

// 2.) take in a letter form the user
Console.WriteLine("Please enter a letter: ");
string letter = Console.ReadLine();

// 3.) count how many times the letter appears in the sentence

    // 3.a) since we have to count, we need to keep track of a number
int counter = 0;

    // 3.b) we have to select each letter for the sentence one at a time
foreach(char selectedLetter in input.ToLower()){

    // 3.c) we have to compare the letter of the sentence to the letter that the user chose
    if(selectedLetter == char.Parse(letter)){
        // 3.d) if the letters match we add one to our count
        counter++;
    }
}

// 4.) output the results 
Console.WriteLine($"The character {letter} appered in the sentence {counter} time(s)!");
