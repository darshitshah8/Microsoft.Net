// Build a Console Guest Book. Ask the user for their name and how many are in the party'
//keep track of how many people are at the party. at the end , print out the guest list 
//and the total number of guest

using MiniProjectGuestBook;

var ( guests , totalGuest) = ConsoleMessages.AllGuest();
//return Guest names
ConsoleMessages.DisplayTotalGuestName(guests);
//return Total Number of the guest
ConsoleMessages.totalNumberOfGuest(totalGuest);
