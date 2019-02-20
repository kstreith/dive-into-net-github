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






