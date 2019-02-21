# dive-into-net-github
Repository for presentation, Dive Into .NET Core GitHub Repository at TRINUG Meetup

## Where to find .NET Core Source Code

1. The CoreCLR on GitHub
    - https://github.com/dotnet/coreclr
    - This is the JIT and Garbage Collector
2. The CoreFX on GitHub
    - https://github.com/dotnet/corefx
    - This is the Standard Library

## What about .NET Framework?
1. Use the MS ReferenceSource site
    - https://referencesource.microsoft.com/

2. They also mirror it to GitHub
    - https://github.com/Microsoft/referencesource

## How do I search for things on GitHub?
1. Use the search box in the upper-left corner when on the GitHub repository of interest. This searches the contents of the files.
2. Use the Find Files feature, either press the button or press the 't' key on the page. This searches the names of the files only.
3. These both are only searching the master branch, so it may have changes, e.g. a newer version of .NET than you are using.

## How do I search the code locally?
1. Either git clone the repository
2. Or download the source code as a zip. CoreFX-master.zip is ~38 MB download.

Then use something like VS Code, https://code.visualstudio.com/ to search the cloned Git repository or the extracted zip file.

## How do I debug the .NET Core source code locally?

1. For .NET Core 2 or later
2. Disable Just My Code in Debugging\General settings.
3. Enable Source Link support in Debugging. You must have VS 2017 15.3 or later.
4. Enable the Microsoft Symbol Servers in Debugging\Symbols
5. Step into .NET Core code, e.g. String.Join, List<T> constructor.
6. Or click farther up in the call stack when on a breakpoint.
7. It will prompt you to download the raw source code file from the GitHub repository.
8. Now that you have the source code file, you can set breakpoints in the .NET Core code.
9. Copied from this Steve Gordon Blog, https://www.stevejgordon.co.uk/debugging-asp-net-core-2-source
10. In you want to clean the downloaded files, go to C:\Users\\[YourUserName]\AppData\Local\SourceServer and delete the subfolders.

## Can I debug into .NET Core code using VS Code?

1. Yes, you can.
2. In the .vscode\launch.json add
```
"justMyCode": false,
"symbolOptions": {
    "searchMicrosoftSymbolServer": true
}
```
2. For full details https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md

## What are pdbs?

1. Your compiled code, e.g. .dll and .exe only contain the generated IL, (https://en.wikipedia.org/wiki/Common_Intermediate_Language)
2. Show how does the debugger point you at a source code file?
3. The pdb contains a mapping from generated IL addresses to a mapping into the name of the class and the name of the method.
4. The pdb optionally can include the original line number and original file name.
5. The pdb can optionally contain a reference to how to locate the original source code (e.g. where on the filesystem the code was originally built from). Most recently, SourceLink embeds links to external servers when the source code can be downloaded from.
6. The Visual Studio debugger allows you to turn on symbol servers. When this is done it will contact the symbol server as assemblies are loaded in attempt to locate .pdb files from the symbol server and download them to your local machine.

## How do I debug the .NET Framework?

**I couldn't get it to work**
1. Try https://referencesource.microsoft.com/setup.html
2. http://www.symbolsource.org/Public/Home/VisualStudio

## What is source link?

1. It is a generic way for .NET packages to bundle their debug symbols and then point to the corresponding source code on GitHub or somewhere else.
2. https://blog.nuget.org/20180827/Introducing-Source-Code-Link-for-NuGet-packages.html
3. https://www.hanselman.com/blog/ExploringNETCoresSourceLinkSteppingIntoTheSourceCodeOfNuGetPackagesYouDontOwn.aspx
4. https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/sourcelink
5. https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/nuget#symbol-packages
6. See current source code providers here: https://github.com/dotnet/sourcelink

## Review of actual meeting

1. We looked at List<T> source code. 
https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/Collections/Generic/List.cs
2. We are did a .Select() followed .ToList() on an original list. That lead us to specialized SelectListIterator in https://github.com/dotnet/corefx/blob/master/src/System.Linq/src/System/Linq/Select.cs
3. We looked at Random.Next() code, https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/Random.cs
4. We looked at the EmailAddressAttribute, https://github.com/dotnet/corefx/blob/master/src/System.ComponentModel.Annotations/src/System/ComponentModel/DataAnnotations/EmailAddressAttribute.cs
5. We also used the .NET reference source and looked at the prior implementation of EmailAddressAttribute, which used to use a RegEx.
6. We also learned how to set a function breakpoint, see this blog https://blog.reyno.co.uk/debugging-asp-net-core-source-code/ for more details.
7. We quickly looked at String, https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/String.cs
8. We looked at ArgumentNullException and ArgumentException, https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/ArgumentNullException.cs
9. Specifically we looked at https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/ArgumentException.cs to see how serialization of exception properties is done.
10. We looked back at List<T>, https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/Collections/Generic/List.cs to learn about the DebuggerDisplayAttribute.
11. Specifically it's a feature you can use in your types, https://docs.microsoft.com/en-us/visualstudio/debugger/using-the-debuggerdisplay-attribute?view=vs-2017





