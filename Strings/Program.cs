// See https://aka.ms/new-console-template for more information
string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
Console.WriteLine("What word or phrase are you looking for? ");
string input = Console.ReadLine();
input = input.ToLower();
alice = alice.ToLower();
bool isPresent = alice.Contains(input);
if (isPresent) {
    int index = alice.IndexOf(input);
    int length = input.Length;
    Console.WriteLine("Your word is " + length + " characters long and was found at index " + index);
    string newString = alice.Remove(index, length);
    Console.WriteLine(newString);
} else {
    Console.WriteLine("Not Found");
}


