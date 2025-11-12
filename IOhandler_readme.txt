The IOHandler.java class manages all input/output operations and validation for the Bank Line-Up Simulation System.

Loading Input Files
Opens a file-chooser dialog for the user to select a .txt file.
Each line must contain two integers separated by spaces or tabs in the format:
arrivalTime serviceTime


Validation checks:

File not empty
Exactly 2 values per line
Both numeric and positive
Invalid input triggers a descriptive error dialog and cancels loading.

Exporting Results
After simulation, the user can export output via a Save dialog.
Results are written to a plain .txt file in the same format displayed in the GUI.
If no results exist, a warning dialog prevents accidental empty exports.

Error Handling
All read/write operations are wrapped in try / catch blocks.
Any I/O exception (e.g., missing file, permission denied) shows a user-friendly error message through JOptionPane.