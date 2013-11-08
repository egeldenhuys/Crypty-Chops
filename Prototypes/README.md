## Prototypes
This is a summary of what each prototype demonstrates and notes relating to them.

### Bytes_1
Prints the bytes of the given file to a textbox in HEX values.
Extremely slow to print so many values to a textbox.

### Bytes_2
Read the entire file into memory and print the bytes in HEX value to a textbox.
Display operation time.
Prints all HEX values at the same time. Does not keep appending to textbox,
This is significantly faster

### Bytes_3
Improved version of Bytes_2
Reads a specified amount of bytes into a buffer. It does not do anything
with the read bytes. Repeats until all bytes have been read and ignored.
Textbox to change buffer size.
No longer prints any HEX values.

### CryptyChops_1
Prototype of the final solution.
Modular structure.
Uses classes copied from CryptyFiles prototype

### CryptyFiles
Classes:
* CryptyFileManager (Functions for managing the File List
* CryptyFiles (The files added to the File List)

### FileEncryptionGUIMockup
Example of what the Main Screen will look like

### FileEncryptionGUIMockup2
Keyboard Shortcuts
Forms for other functions
Buttons for functions
Copied from FileEncryptionGUIMockup

### GUI_Prototype_1
Basic examples for modifying items in a ListView

### Reverse Encryption
The basic idea is that it reverses the byte array in every position then goes through again and reverses it in random positions.
Decrypting is done in the opposite order encrypting is.

### TextEncryption_1
Encrypt a string using a custom algorithm. Data encrypted based on key.

### TextEncryption_2
Similar to TextEncryption_1.
Different algorithm.
XOR
Generates a new key every (x) bytes. This eliminates repetition.
