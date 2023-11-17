# FileHasher
A .NET 8.0 WinForms Application is shown below:

![image](https://github.com/cgers/FileHasher/assets/14121781/347f5f04-89d0-4e4f-9967-f1c5b708face)

Generates a CSV file containing a ***Name, Path and Hash*** (SHA256) for each file in the selected folder (recursively) that matches the search pattern.

# How to Use
1. Open the App
2. Enter filter e.g. *.txt
3. Click the button Process
4. Select a folder to Search (it will search all sub-folders that match the search pattern)

![image](https://github.com/cgers/FileHasher/assets/14121781/a8a374d2-df2f-4f65-8e4c-462c9bdfab8f)

6. Select a name for an output CSV file.
7. The CSV file will be generated.

 
## Sample Output
Here is a sample of the output created, which in this example only contains data for 1 file. There could be 1 to n of lines depending on how many files match the pattern.
```
FileName, Path, Hash
internal-nlog-AspNetCore.txt,C:\Temp\LOGS\internal-nlog-AspNetCore.txt,84be67eb4a9714ca0c064571d52bb97ff02e384da3d9f5a084b65c29e0b2a758
```


