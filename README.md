
Project Title:        Iron Software Coding Challenge 

Date:                 Devcember 2024

Author:               Ron Long


Two main files are:
1) PhoneDecoder.cs - class file so the phone decoder
2) UnitTest1.cs - nunit testing file for 11 test cases (only 11 entered based on time, there are many more tests I could do)



About The Project
This is a coding challednge for a job opening. Here is the challenge (requirement)


Here is an old phone keypad with alphabetical letters, a
backspace key, and a send
button.

Each button has a number to identify it and pressing a button
multiple times will
cycle through the letters on it allowing
each button to represent more than one letter.

For example, pressing 2 once will return ‘A’ but pressing twice
in succession will return
‘B’.

You must pause for a second in order to type two characters from the same
button
after each other: “222 2 22” -> “CAB”.
Prompt:

Please design and document a class of method that will turn any input to OldPhonePad
into the correct output.

Assume that a send “#” will always be included at the end of every input.


public static String OldPhonePad(string input) {}
// Please write your implementation here!


Examples:

OldPhonePad(“33#”) => output: E
OldPhonePad(“227*#”) => output: B
OldPhonePad(“4433555 555666#”) => output: HELLO
OldPhonePad(“8 88777444666*664#”) => output: ?????
